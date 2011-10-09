﻿namespace Football.Team
{
    /// <summary>
    /// Abstraction class of football team.
    /// </summary>
    public class Team
    {
        /// <summary>
        /// Name of the team.
        /// </summary>
        public string Name;
        //-----------------------------------------------------------------------------

        /// <summary>
        /// List of players in the team.
        /// </summary>
        public Player[] Players;
        //-----------------------------------------------------------------------------
        //-----------------------------------------------------------------------------

        /// <summary>
        /// Initializes a new instance of the <see cref="Team"/> class.
        /// </summary>
        /// <param name="name">The name of the team.</param>
        /// <param name="players">The players of the team.</param>
        public Team(string name, Player[] players)
        {
            Name = name;
            Players = players;

        } // End
        //-----------------------------------------------------------------------------

        /// <summary>
        /// Move this team.
        /// </summary>
        /// <param name="dt">Time interval for moving.</param>
        public void Move(double dt)
        {

        } // End
        //-----------------------------------------------------------------------------

    } // End class
    //-----------------------------------------------------------------------------

} // End namespace
//-----------------------------------------------------------------------------