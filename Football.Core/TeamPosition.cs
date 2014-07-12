namespace Football.Core
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;

    public sealed class TeamPosition : IEnumerable<KeyValuePair<Player, PlayerPosition>>
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

        IEnumerator<KeyValuePair<Player, PlayerPosition>> IEnumerable<KeyValuePair<Player, PlayerPosition>>.GetEnumerator()
        {
            return _playerPositions.GetEnumerator();
        }

        public IEnumerator GetEnumerator()
        {
            return _playerPositions.GetEnumerator();
        }
    }
}