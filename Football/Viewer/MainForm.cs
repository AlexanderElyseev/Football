using System.Windows.Forms;
using Football;

namespace Viewer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            var builder = new RandomTeamBuilder();

            var team = builder.Build();

            InitializeComponent();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {

        }
    }
}
