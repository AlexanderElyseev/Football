namespace Football.Core
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;

    public sealed class TeamAction
    {
        private readonly IDictionary<Player, PlayerAction> _playerActions;

        public TeamAction(IDictionary<Player, PlayerAction> playerActions)
        {
            Contract.Requires<ArgumentNullException>(playerActions != null);

            _playerActions = playerActions;
        }

        public PlayerAction this[Player player]
        {
            get { return _playerActions[player]; }
        } 
    }
}