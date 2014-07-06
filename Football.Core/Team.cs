namespace Football.Core
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;

    public sealed class Team
    {
        private readonly Player[] _players;

        public IEnumerable<Player> Players
        {
            get { return _players; }
        }

        public Team(Player[] players)
        {
            Contract.Requires<ArgumentNullException>(players != null);

            _players = players;
        }
    }
}