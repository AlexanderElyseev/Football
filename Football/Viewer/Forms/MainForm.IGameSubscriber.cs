using Football.Game;

namespace Viewer.Forms
{
    public partial class MainForm : IGameSubscriber
    {
        /// <summary>
        /// Last data from game.
        /// </summary>
        private SubscriberData _lastSubscriberData;
        //-----------------------------------------------------------------------------
        //-----------------------------------------------------------------------------

        /// <summary>
        /// Notify this subscriber.
        /// </summary>
        /// <param name="data">The game data for subscriber.</param>
        public void Notify(SubscriberData data)
        {
            _lastSubscriberData = data;

        } // End
        //-----------------------------------------------------------------------------
        //-----------------------------------------------------------------------------

    } // End class
    //-----------------------------------------------------------------------------

} // End namespace
//-----------------------------------------------------------------------------