namespace Football.Core
{
    using System;
    using System.Diagnostics.Contracts;

    public sealed class Game
    {
        private readonly Team _firstTeam;

        private readonly Team _secondTeam;

        private readonly Ball _ball;

        public Game(Team firstTeam, Team secondTeam, Ball ball)
        {
            Contract.Requires<ArgumentNullException>(firstTeam != null);
            Contract.Requires<ArgumentNullException>(secondTeam != null);
            Contract.Requires<ArgumentNullException>(ball != null);

            _firstTeam = firstTeam;
            _secondTeam = secondTeam;
            _ball = ball;
        }
    }
}