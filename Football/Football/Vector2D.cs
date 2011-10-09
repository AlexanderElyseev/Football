namespace Football
{
    /// <summary>
    /// Abstraction class for 2D vector.
    /// </summary>
    public class Vector2D
    {
        /// <summary>
        /// The x coordinate.
        /// </summary>
        public double X;
        //-----------------------------------------------------------------------------

        /// <summary>
        /// The y coordinate.
        /// </summary>
        public double Y;
        //-----------------------------------------------------------------------------
        //-----------------------------------------------------------------------------
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Vector3D"/> class.
        /// </summary>
        public Vector2D() : this(0, 0)
        {
        } // End
        //-----------------------------------------------------------------------------

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector2D"/> class.
        /// </summary>
        /// <param name="x">The x coordinate.</param>
        /// <param name="y">The y coordinate.</param>
        public Vector2D(double x, double y)
        {
            X = x;
            Y = y;

        } // End
        //-----------------------------------------------------------------------------

        public static Vector2D operator -(Vector2D t1, Vector2D t2)
        {
            return new Vector2D(t1.X - t2.X, t1.Y - t2.Y);

        } // End
        //-----------------------------------------------------------------------------

        public static Vector2D operator +(Vector2D t1, Vector2D t2)
        {
            return new Vector2D(t1.X + t2.X, t1.Y + t2.Y);

        } // End
        //-----------------------------------------------------------------------------

        public static Vector2D operator *(double t1, Vector2D t2)
        {
            return new Vector2D(t1 * t2.X, t1 * t2.Y);

        } // End
        //-----------------------------------------------------------------------------

        public static Vector2D operator *(Vector2D t1, double t2)
        {
            return new Vector2D(t1.X * t2, t1.Y * t2);

        } // End
        //-----------------------------------------------------------------------------

    } // End class
    //-----------------------------------------------------------------------------

} // End namespace
//-----------------------------------------------------------------------------