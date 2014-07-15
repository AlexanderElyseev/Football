namespace Viewer.Forms
{
    using System.Collections.Generic;
    using System.Windows.Forms;

    using Footbal.Visualization;

    using Football.Core;

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
            InitializeComponent();
        }

        private void m_btnStart_Click(object sender, System.EventArgs e)
        {
            var field = new Field(100, 50, 0.12f);
            var firstTeamPosition = new TeamPosition(new Dictionary<Player, PlayerPosition>());
            var secondTeamPosition = new TeamPosition(new Dictionary<Player, PlayerPosition>());
            var ballPosition = new BallPosition();
            var gamePosition = new GamePosition(field, firstTeamPosition, secondTeamPosition, ballPosition);

            m_imgTopView.Image = new BitmapVisualizer(m_imgTopView.Width, m_imgTopView.Height).Draw(gamePosition);
        }
    }
}