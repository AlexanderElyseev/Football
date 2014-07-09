namespace Football.Core
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;
    using System.Linq;

    public sealed class Game
    {
        private readonly IGameRunner _runner;

        private readonly Team _firstTeam;

        private readonly Team _secondTeam;

        private readonly Ball _ball;

        public Game(IGameRunner runner, Team firstTeam, Team secondTeam, Ball ball)
        {
            Contract.Requires<ArgumentNullException>(runner != null);

            Contract.Requires<ArgumentNullException>(firstTeam != null);
            Contract.Requires<ArgumentNullException>(secondTeam != null);
            Contract.Requires<ArgumentNullException>(ball != null);

            _runner = runner;
            _firstTeam = firstTeam;
            _secondTeam = secondTeam;
            _ball = ball;
        }

        public void Run()
        {
            BallPosition ballPosition = new BallPosition();

            Dictionary<Player, PlayerPosition> playerPositions = new Dictionary<Player, PlayerPosition>();
            InitPlayersPositions(playerPositions, _firstTeam);
            InitPlayersPositions(playerPositions, _secondTeam);
            
            IGameState gameState = null;

            Dictionary<Player, PlayerAction> playerActions = new Dictionary<Player, PlayerAction>();
            while (true)
            {
                BuilPlayerActions(playerActions, _firstTeam, gameState);
                BuilPlayerActions(playerActions, _secondTeam, gameState);
                
                var stepResult = _runner.Step(playerActions, playerPositions, ref ballPosition);
                if (!stepResult)
                    break;

                playerActions.Clear();
            }
        }

        private static void InitPlayersPositions(Dictionary<Player, PlayerPosition> playerPositions, Team team)
        {
            foreach (Player player in team.Players)
                playerPositions[player] = new PlayerPosition();
        }
        
        private static void BuilPlayerActions(IDictionary<Player, PlayerAction> playerActions, Team team, IGameState gameState)
        {
            foreach (Player player in team.Players)
                playerActions.Add(player, team.Strategy.GetPlayerStrategy(player).GetAction(gameState));
        }
    }
}