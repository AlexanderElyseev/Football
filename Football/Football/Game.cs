namespace Football
{
    public class Game
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

        /// <summary>
        /// Run this game.
        /// </summary>
        public void Run()
        {
            const double dt = 0.1;
            double totalTime = 0;
            for (var step = 0; step < 1000; step++)
            {
                _homeTeam.Move(dt);
                _visitingTeam.Move(dt);
                _ball.Move(dt);

                totalTime += dt;
            }

        } // End
        //-----------------------------------------------------------------------------
        //-----------------------------------------------------------------------------

    } // End class
    //-----------------------------------------------------------------------------

} // End namespace
//-----------------------------------------------------------------------------