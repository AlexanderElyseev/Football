namespace Football.Game
{
    /// <summary>
    /// Interface for football game subscribers.
    /// Observer pattern.
    /// </summary>
    public interface IGameSubscriber
    {
        /// <summary>
        /// Notify this subscriber.
        /// </summary>
        /// <param name="data">The game data for subscriber.</param>
        void Notify(SubscriberData data);
        //-----------------------------------------------------------------------------
        //-----------------------------------------------------------------------------

    } // End class
    //-----------------------------------------------------------------------------

} // End namespace
//-----------------------------------------------------------------------------