namespace Football.Core
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;

    public sealed class TeamPosition
    {
        private readonly IDictionary<Player, PlayerPosition> _playerPositions;

        public TeamPosition(IDictionary<Player, PlayerPosition> playerPositions)
        {
            Contract.Requires<ArgumentNullException>(playerPositions != null);

            _playerPositions = playerPositions;
        }

        public PlayerPosition this[Player player]
        {
            get { return _playerPositions[player]; }
        }
    }
}