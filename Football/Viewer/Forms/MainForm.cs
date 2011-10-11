using System.Threading;
using System.Windows.Forms;
using Football.Game;
using Football.Team.Builder;
//-----------------------------------------------------------------------------

namespace Viewer.Forms
{
    /// <summary>
    /// Class of main form.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            // Initialization of form components.
            InitializeComponent();

            // Build new football game.
            var homeTeam = new RandomTeamBuilder().Build();
            var guestTeam = new RandomTeamBuilder().Build();
            var game = new Game(homeTeam, guestTeam);
            game.Subscribe(this);

            game.Start();

            Thread.Sleep(1000);
            game.Pause();

        } // End
        //-----------------------------------------------------------------------------

    } // End class
    //-----------------------------------------------------------------------------

} // End namespace
//-----------------------------------------------------------------------------