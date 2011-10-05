using System;

namespace Football
{
    /// <summary>
    /// Abstraction class of player's skills.
    /// </summary>
    public class PlayerSkills
    {
        #region Fields

        /// <summary>
        /// Power of the player.
        /// </summary>
        private int _power;
        //-----------------------------------------------------------------------------

        /// <summary>
        /// Endurance of the player.
        /// </summary>
        private int _endurance;
        //-----------------------------------------------------------------------------

        /// <summary>
        /// Speed of the player.
        /// </summary>
        private int _speed;
        //----------------------------------------------------------------------------- 

        #endregion
        //-----------------------------------------------------------------------------

        #region Constants

        /// <summary>
        /// Minimal value of player skills.
        /// </summary>
        public const int MinSkillValue = 0;
        //-----------------------------------------------------------------------------

        /// <summary>
        /// Maximal value of the skill.
        /// </summary>
        public const int MaxSkillValue = 100;
        //----------------------------------------------------------------------------- 

        #endregion
        //-----------------------------------------------------------------------------

        #region Properties

        /// <summary>
        /// Gets or sets the strength of the player.
        /// </summary>
        /// <value>
        /// The strength of the player.
        /// </value>
        public int Power
        {
            get
            {
                return _power;
            }

            set
            {
                if (_power < MinSkillValue || _power > MaxSkillValue)
                    throw new ArgumentException();

                _power = value;
            }
        }
        //-----------------------------------------------------------------------------

        /// <summary>
        /// Gets or sets the endurance of the player.
        /// </summary>
        /// <value>
        /// The endurance of the player.
        /// </value>
        public int Endurance
        {
            get
            {
                return _endurance;
            }

            set
            {
                if (_endurance < MinSkillValue || _endurance > MaxSkillValue)
                    throw new ArgumentException();

                _endurance = value;
            }
        }
        //-----------------------------------------------------------------------------

        /// <summary>
        /// Gets or sets the speed of the player.
        /// </summary>
        /// <value>
        /// The speed of the player.
        /// </value>
        public int Speed
        {
            get
            {
                return _speed;
            }

            set
            {
                if (_speed < MinSkillValue || _speed > MaxSkillValue)
                    throw new ArgumentException();

                _speed = value;
            }
        }
        //----------------------------------------------------------------------------- 

        #endregion
        //----------------------------------------------------------------------------- 

    } // End class
    //-----------------------------------------------------------------------------

} // End namespace
//-----------------------------------------------------------------------------