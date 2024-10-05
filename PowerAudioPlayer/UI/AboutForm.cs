using PowerAudioPlayer.Controllers;
using PowerAudioPlayer.Controllers.Helper;
using System.Diagnostics;
using System.IO;

namespace PowerAudioPlayer.UI
{
    partial class AboutForm : BaseForm
    {
        public AboutForm()
        {
            InitializeComponent();
            AssemblyHelper assemblyHelper = new AssemblyHelper();
            rtbAcknowledgement.Rtf = Resources.Acknowledgement;
            Text = string.Format(Player.GetString("MsgAbout"), assemblyHelper.Title);
            llblProgramName.Text = assemblyHelper.Product.ToString();
            lblVersion.Text = string.Format(Player.GetString("MsgVersion"), assemblyHelper.Version.ToString());
            lblCompany.Text = assemblyHelper.Company;
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