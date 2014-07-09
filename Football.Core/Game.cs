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
            Dictionary<Player, PlayerPosition> playerPositions = InitPlayersPositions();
            BallPosition ballPosition = new BallPosition();

            IGameState gameState = null;

            Dictionary<Player, PlayerAction> playerActions = new Dictionary<Player, PlayerAction>();
            while (true)
            {
                BuilPlayerActions(playerActions, _firstTeam, gameState);
                BuilPlayerActions(playerActions, _secondTeam, gameState);
                
                RunPlayerActions(playerActions, playerPositions, ref ballPosition);

                playerActions.Clear();
            }
        }

        private Dictionary<Player, PlayerPosition> InitPlayersPositions()
        {
            Dictionary<Player, PlayerPosition> playerPositions = new Dictionary<Player, PlayerPosition>();

            foreach (Player player in _firstTeam.Players)
                playerPositions[player] = new PlayerPosition();

            foreach (Player player in _secondTeam.Players)
                playerPositions[player] = new PlayerPosition();

            return playerPositions;
        }
        
        private static void BuilPlayerActions(IDictionary<Player, PlayerAction> playerActions, Team team, IGameState gameState)
        {
            foreach (Player player in team.Players)
                playerActions.Add(player, team.Strategy.GetPlayerStrategy(player).GetAction(gameState));
        }

        private static void RunPlayerActions(IDictionary<Player, PlayerAction> playerActions, Dictionary<Player, PlayerPosition> playerPositions, ref BallPosition ballPosition)
        {
            foreach (var playerAction in playerActions)
            {
                
            }
        }
    }
}