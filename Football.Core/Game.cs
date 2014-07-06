namespace Football.Core
{
    using System;
    using System.Diagnostics.Contracts;

    internal sealed class Game
    {
        private Team _firstTeam;

        private Team _secondTeam;

        public Game(Team firstTeam, Team secondTeam)
        {
            Contract.Requires<ArgumentNullException>(firstTeam != null);
            Contract.Requires<ArgumentNullException>(secondTeam != null);

            _firstTeam = firstTeam;
            _secondTeam = secondTeam;
        }
    }
}