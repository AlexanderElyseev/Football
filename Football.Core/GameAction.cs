namespace Football.Core
{
    using System;
    using System.Diagnostics.Contracts;

    public class GameAction
    {
        private readonly TeamAction _firstTeamAction;

        private readonly TeamAction _secondTeamAction;

        public GameAction(TeamAction firstTeamAction, TeamAction secondTeamAction)
        {
            Contract.Requires<ArgumentNullException>(firstTeamAction != null);
            Contract.Requires<ArgumentNullException>(secondTeamAction != null);

            _firstTeamAction = firstTeamAction;
            _secondTeamAction = secondTeamAction;
        }

        public TeamAction FirstTeamAction
        {
            get { return _firstTeamAction; }
        }

        public TeamAction SecondTeamAction
        {
            get { return _secondTeamAction; }
        }
    }
}