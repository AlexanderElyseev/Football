namespace Football
{
    /// <summary>
    /// Abstraction class for 3D vector.
    /// </summary>
    public class Vector3D
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

        /// <summary>
        /// The z coordinate.
        /// </summary>
        public double Z;
        //-----------------------------------------------------------------------------
        //-----------------------------------------------------------------------------

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector3D"/> class.
        /// </summary>
        public Vector3D() : this(0, 0, 0)
        {
        } // End
        //-----------------------------------------------------------------------------

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector3D"/> class.
        /// </summary>
        /// <param name="x">The x coordinate.</param>
        /// <param name="y">The y coordinate.</param>
        /// <param name="z">The z coordinate.</param>
        public Vector3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;

        } // End
        //-----------------------------------------------------------------------------

        public static Vector3D operator -(Vector3D t1, Vector3D t2)
        {
            return new Vector3D(t1.X - t2.X, t1.Y - t2.Y, t1.Z - t2.Z);

        } // End
        //-----------------------------------------------------------------------------

        public static Vector3D operator +(Vector3D t1, Vector3D t2)
        {
            return new Vector3D(t1.X + t2.X, t1.Y + t2.Y, t1.Z + t2.Z);

        } // End
        //-----------------------------------------------------------------------------

        public static Vector3D operator *(double t1, Vector3D t2)
        {
            return new Vector3D(t1 * t2.X, t1 * t2.Y, t1 * t2.Z);

        } // End
        //-----------------------------------------------------------------------------

        public static Vector3D operator *(Vector3D t1, double t2)
        {
            return new Vector3D(t1.X * t2, t1.Y * t2, t1.Z * t2);

        } // End
        //-----------------------------------------------------------------------------

    } // End class
    //-----------------------------------------------------------------------------

} // End namespace
//-----------------------------------------------------------------------------