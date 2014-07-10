namespace Football.Core
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;
    using System.Linq;

    public sealed class Game
    {
        private readonly IGameRunner _runner;

        private readonly IGameRunnerStateBuilder _gameRunnerStateBuilder;

        private readonly Team _firstTeam;

        private readonly Team _secondTeam;

        private readonly Ball _ball;

        public Game(IGameRunner runner, IGameRunnerStateBuilder gameRunnerStateBuilder, Team firstTeam, Team secondTeam, Ball ball)
        {
            Contract.Requires<ArgumentNullException>(runner != null);
            Contract.Requires<ArgumentNullException>(gameRunnerStateBuilder != null);

            Contract.Requires<ArgumentNullException>(firstTeam != null);
            Contract.Requires<ArgumentNullException>(secondTeam != null);
            Contract.Requires<ArgumentNullException>(ball != null);

            _runner = runner;
            _gameRunnerStateBuilder = gameRunnerStateBuilder;
            _firstTeam = firstTeam;
            _secondTeam = secondTeam;
            _ball = ball;
        }

        public void Run()
        {
            BallPosition ballPosition = InitBallPosition(_ball);
            TeamPosition firstTeamPosition = InitTeamPosition(_firstTeam);
            TeamPosition secondTeamPosition = InitTeamPosition(_secondTeam);
            GamePosition gamePosition = new GamePosition(firstTeamPosition, secondTeamPosition, ballPosition);

            while (true)
            {
                IGameRunnerState gameRunnerState = _gameRunnerStateBuilder.BuildState(gamePosition);

                TeamAction firstTeamAction = BuildTeamAction(_firstTeam, gameRunnerState);
                TeamAction secondTeamAction = BuildTeamAction(_secondTeam, gameRunnerState);
                GameAction gameAction = new GameAction(firstTeamAction, secondTeamAction);

                bool stepResult = _runner.Step(gamePosition, gameAction, ref ballPosition);
                if (!stepResult)
                    break;
            }
        }

        private static BallPosition InitBallPosition(Ball ball)
        {
            return new BallPosition();
        }

        private static TeamPosition InitTeamPosition(Team team)
        {
            IDictionary<Player, PlayerPosition> playerPositions = new Dictionary<Player, PlayerPosition>(team.Players.Count);
            foreach (Player player in team.Players)
                playerPositions[player] = new PlayerPosition();

            return new TeamPosition(playerPositions);
        }
        
        private static TeamAction BuildTeamAction(Team team, IGameRunnerState gameRunnerState)
        {
            IDictionary<Player, PlayerAction> playerActions = new Dictionary<Player, PlayerAction>(team.Players.Count);
            foreach (Player player in team.Players)
                playerActions.Add(player, team.Strategy.GetPlayerStrategy(player).GetAction(gameRunnerState));

            return new TeamAction(playerActions);
        }
    }
}