using System;
using System.Windows.Forms;
using Viewer.Forms;

namespace Viewer
{
    using Ninject;

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (IKernel kernel = new StandardKernel())
            {
                Application.Run(new MainForm());    
            }
        }
    }
}
