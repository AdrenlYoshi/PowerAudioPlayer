using PowerAudioPlayer.Controllers;
using PowerAudioPlayer.Controllers.Helper;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace PowerAudioPlayer.UI
{
    partial class AboutForm : BaseForm
    {
        public AboutForm()
        {
            InitializeComponent();
            rtbAcknowledgement.Text = Resources.Acknowledgement;
            Text = string.Format(Player.GetString("MsgAbout"), Application.ProductName);
            llblProductName.Text = Application.ProductName;
            lblVersion.Text = string.Format(Player.GetString("MsgVersion"), Assembly.GetExecutingAssembly().GetName().Version);
            lblCompany.Text = Application.CompanyName;
            lbldotNETVersion.Text = Player.GetString("DotNETVersion", Environment.Version.ToString());
            lblLastCompileTime.Text = Player.GetString("MsgLastCompileTime", File.GetLastWriteTime(GetType().Assembly.Location).ToString());
        }

        private void rtbAcknowledgement_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.LinkText) { UseShellExecute = true });
        }

        private void llblProgramName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo(Player.GetString("ProjectPageURL")) { UseShellExecute = true });
        }
    }
}