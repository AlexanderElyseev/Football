namespace Football.Core
{
    using System.Collections.Generic;

    public sealed class TeamSpeed
    {
        private readonly IDictionary<Player, PlayerSpeed> _speed;

        public TeamSpeed(IDictionary<Player, PlayerSpeed> speed)
        {
            _speed = speed;
        }

        PlayerSpeed this[Player player]
        {
            get { return _speed[player]; }
        }
    }
}