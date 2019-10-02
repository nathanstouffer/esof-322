using System;
using System.Windows.Forms;

namespace DesignPatternFinder
{
    internal class Run
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DesignPatternFinderForm());
        }
    }
}