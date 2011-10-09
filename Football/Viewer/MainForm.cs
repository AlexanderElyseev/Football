using System.Windows.Forms;
using Football.Team.Builder;

namespace Viewer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            var builder = new RandomTeamBuilder();

            var team1 = builder.Build();
            var team2 = builder.Build();
            var game = new Football.Game(team1, team2);

            game.Run();

            InitializeComponent();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {

        }
    }
}
