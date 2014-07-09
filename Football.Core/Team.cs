namespace Football.Core
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;

    public sealed class Team
    {
        private readonly Player[] _players;

        private readonly ITeamStrategy _strategy;

        public IReadOnlyCollection<Player> Players
        {
            get { return _players; }
        }

        public ITeamStrategy Strategy
        {
            get { return _strategy; }
        }

        public Team(Player[] players, ITeamStrategy strategy)
        {
            Contract.Requires<ArgumentNullException>(players != null);
            Contract.Requires<ArgumentNullException>(strategy != null);

            _players = players;
            _strategy = strategy;
        }
    }
}