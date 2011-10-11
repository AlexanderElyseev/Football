using System;
using System.Threading;

namespace Football.Game
{
    /// <summary>
    /// Abstraction class of football game.
    /// Actions with the game.
    /// </summary>
    public partial class Game
    {
        /// <summary>
        /// Thread for the game.
        /// </summary>
        private Thread _gameThread;
        //-----------------------------------------------------------------------------

        /// <summary>
        /// Current game status.
        /// </summary>
        private GameStatus _gameStatus = GameStatus.Stopped;
        //-----------------------------------------------------------------------------
        //-----------------------------------------------------------------------------

        /// <summary>
        /// Run this game.
        /// </summary>
        private void Run()
        {
            const double dt = 0.00001;
            double totalTime = 0;
            while (true)
            {
                // Do nothing if game is paused.
                if (_gameStatus == GameStatus.Paused)
                    continue;

                // Exit if game is stopped.
                if (_gameStatus == GameStatus.Stopped)
                    break;

                // Notify game subscribers with game data.
                NotifySubscribers(
                    new SubscriberData
                    {
                        GameTime = totalTime
                    }
                );

                // Move teams and ball.
                _homeTeam.Move(dt);
                _visitingTeam.Move(dt);
                _ball.Move(dt);

                // Increase time.
                totalTime += dt;

                // Check end of time.
                if (totalTime > 90 * 60)
                    break;

            } // End while

        } // End
        //-----------------------------------------------------------------------------

        /// <summary>
        /// Start this game.
        /// </summary>
        public void Start()
        {
            if (_gameStatus != GameStatus.Stopped)
                throw new SystemException("Game is running.");

            _gameStatus = GameStatus.Running;
            _gameThread = new Thread(Run)
            {
                Name = "Game"
            };
            _gameThread.Start();

        } // End
        //-----------------------------------------------------------------------------

        /// <summary>
        /// Stop this game.
        /// </summary>
        public void Stop()
        {
            if (_gameStatus == GameStatus.Stopped)
                throw new Exception("Game is not runing.");

            _gameStatus = GameStatus.Stopped;
            _gameThread.Join();

        } // End
        //-----------------------------------------------------------------------------

        /// <summary>
        /// Pause this game.
        /// </summary>
        public void Pause()
        {
            if (_gameStatus == GameStatus.Stopped)
                throw new Exception("Game is not running.");

            if (_gameStatus == GameStatus.Running)
            {
                _gameStatus = GameStatus.Paused;
            }
            else if (_gameStatus == GameStatus.Paused)
            {
                _gameStatus = GameStatus.Running;
            }

        } // End
        //-----------------------------------------------------------------------------
        //-----------------------------------------------------------------------------

    } // End class
    //-----------------------------------------------------------------------------

} // End namespace
//-----------------------------------------------------------------------------