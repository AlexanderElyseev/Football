namespace Football
{
    /// <summary>
    /// Player abstraction class.
    /// </summary>
    public class Player
    {
        /// <summary>
        /// The number of the player.
        /// </summary>
        public int Number;
        //-----------------------------------------------------------------------------

        /// <summary>
        /// The name of the player.
        /// </summary>
        public string Name;
        //-----------------------------------------------------------------------------

        /// <summary>
        /// The skills of the player.
        /// </summary>
        public PlayerSkills Skills;
        //-----------------------------------------------------------------------------

        /// <summary>
        /// Current coordinates of player at the field.
        /// In meters.
        /// </summary>
        public Vector2D Coordinates = new Vector2D();
        //-----------------------------------------------------------------------------

        /// <summary>
        /// Current velocity of player at the field.
        /// In meters per second.
        /// </summary>
        public Vector2D Velocity = new Vector2D();
        //-----------------------------------------------------------------------------
        //-----------------------------------------------------------------------------

        /// <summary>
        /// Initializes a new instance of the <see cref="Player"/> class.
        /// </summary>
        /// <param name="number">The number of the player.</param>
        /// <param name="name">The name of the player.</param>
        /// <param name="skills">The skills of the player.</param>
        public Player(int number, string name, PlayerSkills skills)
        {
            Number = number;
            Name = name;
            Skills = skills;

        } // End
        //-----------------------------------------------------------------------------

    } // End class
    //-----------------------------------------------------------------------------

} // End namespace
//-----------------------------------------------------------------------------