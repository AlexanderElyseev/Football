namespace Football.Core
{
    using System;
    using System.Diagnostics.Contracts;

    internal sealed class Team
    {
        private readonly Player[] _players;

        public Team(Player[] players)
        {
            Contract.Requires<ArgumentNullException>(players != null);

            _players = players;
        }
    }
}