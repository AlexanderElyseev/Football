namespace Football.Core
{
    using System;
    using System.Diagnostics.Contracts;

    public sealed class Player
    {
        private string _name;

        public Player(string name)
        {
            Contract.Requires<ArgumentNullException>(name != null);
            Contract.Requires<ArgumentException>(name != string.Empty);

            _name = name;
        }
    }
}