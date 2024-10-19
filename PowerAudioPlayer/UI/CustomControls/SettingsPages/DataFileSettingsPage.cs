using PowerAudioPlayer.Controllers;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;

namespace PowerAudioPlayer.UI.CustomControls.SettingsPages
{
    public partial class DataFileSettingsPage : UserControl
    {
        public DataFileSettingsPage()
        {
            InitializeComponent();
            lblMsg.Text = Player.GetString("MsgDataFile", Environment.UserName, Utils.GetProgramLocalAppDataPath());
        }

        private void btnExploreFolder_Click(object sender, EventArgs e)
        {
            Utils.ExploreFile(Utils.GetProgramLocalAppDataPath());
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = Player.GetString("FilterZIP");
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Player.SaveDataFile();
                if (File.Exists(saveFileDialog.FileName))
                    File.Delete(saveFileDialog.FileName);
                ZipFile.CreateFromDirectory(Utils.GetProgramLocalAppDataPath(), saveFileDialog.FileName);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = Player.GetString("FilterZIP");
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Directory.Delete(Utils.GetProgramLocalAppDataPath(), true);
                    Directory.CreateDirectory(Utils.GetProgramLocalAppDataPath());
                    ZipFile.ExtractToDirectory(openFileDialog.FileName, Utils.GetProgramLocalAppDataPath());
                    MessageBox.Show(Player.GetString("MsgDataFileImportOK"), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Restart();
                    Process.GetCurrentProcess().Kill();
                }
                catch
                {
                    MessageBox.Show(Player.GetString("MsgDataFileImportError"), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClearCurrentUser_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show(Player.GetString("MsgClearDataFile", Environment.UserName), Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Directory.Delete(Utils.GetProgramLocalAppDataPath(), true);
                MessageBox.Show(Player.GetString("MsgClearDataFileOK"), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();
                Process.GetCurrentProcess().Kill();
            }
        }
    }
}