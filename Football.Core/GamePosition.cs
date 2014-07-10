using System;
namespace Football.Core
{
    using System.Diagnostics.Contracts;

    public class GamePosition
    {
        private readonly TeamPosition _firstTeamPosition;

        private readonly TeamPosition _secondTeamPosition;

        private readonly BallPosition _ballPosition;

        public GamePosition(TeamPosition firstTeamPosition, TeamPosition secondTeamPosition, BallPosition ballPosition)
        {
            Contract.Requires<ArgumentNullException>(firstTeamPosition != null);
            Contract.Requires<ArgumentNullException>(secondTeamPosition != null);

            _firstTeamPosition = firstTeamPosition;
            _secondTeamPosition = secondTeamPosition;
            _ballPosition = ballPosition;
        }

        public TeamPosition FirstTeamPosition
        {
            get { return _firstTeamPosition; }
        }

        public TeamPosition SecondTeamPosition
        {
            get { return _secondTeamPosition; }
        }

        public BallPosition BallPosition
        {
            get { return _ballPosition; }
        }
    }
}
