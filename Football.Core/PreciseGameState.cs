namespace Football.Core
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;

    class PreciseGameState : IGameState
    {
        private readonly Dictionary<Player, PlayerPosition> _playerPositions;

        private readonly Dictionary<Player, PlayerSpeed> _playerSpeeds;

        private readonly BallPosition _ballPosition;

        private readonly BallSpeed _ballSpeed;

        PreciseGameState(
            Dictionary<Player, PlayerPosition> playerPositions,
            Dictionary<Player, PlayerSpeed> playerSpeeds,
            BallPosition ballPosition,
            BallSpeed ballSpeed)
        {
            Contract.Requires<ArgumentNullException>(playerPositions != null);
            Contract.Requires<ArgumentNullException>(playerSpeeds != null);

            _playerPositions = playerPositions;
            _playerSpeeds = playerSpeeds;
            _ballPosition = ballPosition;
            _ballSpeed = ballSpeed;
        }

        public PlayerSpeed GetPlayerSpeed(Player player)
        {
            return _playerSpeeds[player];
        }

        public PlayerPosition GetPlayerPosition(Player player)
        {
            return _playerPositions[player];
        }

        public BallSpeed GetBallSpeed()
        {
            return _ballSpeed;
        }

        public BallPosition GetBallPosition()
        {
            return _ballPosition;
        }
    }
}