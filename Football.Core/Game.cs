namespace Football.Core
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;
    using System.Linq;

    public sealed class Game
    {
        private readonly IGameRunner _runner;

        private readonly IGameRunnerStateBuilder _gameStateBuilder;

        private readonly Field _field;

        private readonly Team _firstTeam;

        private readonly Team _secondTeam;

        private readonly Ball _ball;

        public Game(IGameRunner runner, IGameRunnerStateBuilder gameStateBuilder, Field field, Team firstTeam, Team secondTeam, Ball ball)
        {
            Contract.Requires<ArgumentNullException>(runner != null);
            Contract.Requires<ArgumentNullException>(gameStateBuilder != null);

            Contract.Requires<ArgumentNullException>(firstTeam != null);
            Contract.Requires<ArgumentNullException>(secondTeam != null);
            Contract.Requires<ArgumentNullException>(ball != null);

            _runner = runner;
            _gameStateBuilder = gameStateBuilder;
            _field = field;
            _firstTeam = firstTeam;
            _secondTeam = secondTeam;
            _ball = ball;
        }

        public void Run()
        {
            BallPosition ballPosition = InitBallPosition(_ball);
            TeamPosition firstTeamPosition = InitTeamPosition(_firstTeam);
            TeamPosition secondTeamPosition = InitTeamPosition(_secondTeam);
            GamePosition currentPosition = new GamePosition(firstTeamPosition, secondTeamPosition, ballPosition);

            while (true)
            {
                IGameState gameState = _gameStateBuilder.BuildState(currentPosition);

                TeamAction firstTeamAction = BuildTeamAction(_firstTeam, gameState);
                TeamAction secondTeamAction = BuildTeamAction(_secondTeam, gameState);
                GameAction gameAction = new GameAction(firstTeamAction, secondTeamAction);

                GamePosition nextPosition = _runner.Step(currentPosition, gameAction);
                if (nextPosition == null)
                    break;

                currentPosition = nextPosition;
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
        
        private static TeamAction BuildTeamAction(Team team, IGameState gameState)
        {
            IDictionary<Player, PlayerAction> playerActions = new Dictionary<Player, PlayerAction>(team.Players.Count);
            foreach (Player player in team.Players)
                playerActions.Add(player, team.Strategy.GetPlayerStrategy(player).GetAction(gameState));

            return new TeamAction(playerActions);
        }
    }
}