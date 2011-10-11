using System.Collections.Generic;

namespace Football.Game
{
    /// <summary>
    /// Abstraction class of football game.
    /// Subscribers to the game. Observer pattern.
    /// </summary>
    public partial class Game
    {
        /// <summary>
        /// Subscribers to the game.
        /// </summary>
        private readonly List<IGameSubscriber> _subscribers = new List<IGameSubscriber>();
        //-----------------------------------------------------------------------------
        //-----------------------------------------------------------------------------

        /// <summary>
        /// Subscribes the specified listener to the game.
        /// </summary>
        /// <param name="subscriber">The subscriber for adding to the game.</param>
        public void Subscribe(IGameSubscriber subscriber)
        {
            _subscribers.Add(subscriber);

        } // End
        //-----------------------------------------------------------------------------

        /// <summary>
        /// Unsubscribes the specified listener from the game.
        /// </summary>
        /// <param name="subscriber">The subscriber for deleting from the game.</param>
        public void Unsubscribe(IGameSubscriber subscriber)
        {
            _subscribers.Remove(subscriber);

        } // End
        //-----------------------------------------------------------------------------

        /// <summary>
        /// Notify all subscribers.
        /// </summary>
        /// <param name="subscriberData">The data for subscribers.</param>
        private void NotifySubscribers(SubscriberData subscriberData)
        {
            foreach (var subscriber in _subscribers)
                subscriber.Notify(subscriberData);

        } // End
        //-----------------------------------------------------------------------------

    } // End class
    //-----------------------------------------------------------------------------

} // End namespace
//-----------------------------------------------------------------------------