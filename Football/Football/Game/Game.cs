using System;
using System.Threading;

namespace Football.Game
{
    /// <summary>
    /// Abstraction class of football game.
    /// </summary>
    public partial class Game
    {
        /// <summary>
        /// Home team of current team.
        /// </summary>
        private readonly Team.Team _homeTeam;
        //-----------------------------------------------------------------------------

        /// <summary>
        /// Visiting team of current team.
        /// </summary>
        private readonly Team.Team _visitingTeam;
        //-----------------------------------------------------------------------------

        /// <summary>
        /// Ball of current game.
        /// </summary>
        private readonly Ball _ball;
        //-----------------------------------------------------------------------------
        //-----------------------------------------------------------------------------

        /// <summary>
        /// Initializes a new instance of the <see cref="Game"/> class.
        /// </summary>
        /// <param name="homeTeam">The home team.</param>
        /// <param name="visitingTeam">The visiting team.</param>
        public Game(Team.Team homeTeam, Team.Team visitingTeam)
        {
            _homeTeam = homeTeam;
            _visitingTeam = visitingTeam;
            _ball = new Ball();

        } // End
        //-----------------------------------------------------------------------------
        //-----------------------------------------------------------------------------

    } // End class
    //-----------------------------------------------------------------------------

} // End namespace
//-----------------------------------------------------------------------------