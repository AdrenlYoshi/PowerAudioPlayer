using PowerAudioPlayer.Controllers;
using PowerAudioPlayer.Controllers.Helper;
using System.Diagnostics;

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
            labelProductName.Text = assemblyHelper.Product.ToString();
            labelVersion.Text = string.Format(Player.GetString("MsgVersion"), assemblyHelper.Version.ToString());
            labelCompanyName.Text = assemblyHelper.Company;
            labelDotNetVersion.Text = Player.GetString("DotNETVersion", Environment.Version.ToString());
        }

        private void rtbAcknowledgement_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.LinkText) { UseShellExecute = true });
        }
    }
}
