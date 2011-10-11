namespace Football
{
    /// <summary>
    /// Abstraction class of ball.
    /// </summary>
    class Ball
    {
        #region Fields
        /// <summary>
        /// Current coordinates of ball.
        /// In meters.
        /// </summary>
        private Vector3D _coodinates = new Vector3D();
        //-----------------------------------------------------------------------------

        /// <summary>
        /// Current velocity of ball.
        /// In meters per second.
        /// </summary>
        private Vector3D _velocity = new Vector3D();
        //----------------------------------------------------------------------------- 
        #endregion
        //-----------------------------------------------------------------------------

        /// <summary>
        /// Moves this ball.
        /// </summary>
        /// <param name="dt">Time interval for moving.</param>
        public void Move(double dt)
        {
            // Change speed.
            _velocity = _velocity + new Vector3D(0, 0, -9.8) * dt;

            // Change coordiantes.
            _coodinates = _coodinates + _velocity * dt;

            // The ball can not fall below zero.
            if (_coodinates.Z < 0)
            {
                //TODO: Dissipation of energy.
                _velocity.Z = -_velocity.Z * 0.5;
                _coodinates.Z = 0;
            }

        } // End
        //-----------------------------------------------------------------------------
        //-----------------------------------------------------------------------------

    } // End class
    //-----------------------------------------------------------------------------

} // End namespace
//-----------------------------------------------------------------------------