using System.Diagnostics;
using System.Windows.Forms;

namespace DesignPatternFinder
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void jonasEmailLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("mailto:Jonas.Butt@gmail.com");
        }

        private void jonasWebsiteLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.codeplex.com/UserAccount/UserProfile.aspx?UserName=JonasButt");
        }
    }
}