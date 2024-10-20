using BrightIdeasSoftware;
using PowerAudioPlayer.Controllers;

namespace PowerAudioPlayer.UI
{
    public partial class SupportrdFormatForm : Form
    {
        private readonly OLVColumn olvColumn1 = new OLVColumn(Player.GetString("Extensions"), "Extensions") { Width = 190, MinimumWidth = 10 };
        private readonly OLVColumn olvColumn2 = new OLVColumn(Player.GetString("Describe"), "Name") { Width = 290, MinimumWidth = 10 };

        public SupportrdFormatForm()
        {
            InitializeComponent();
            var f = Player.Core.GetSupportrdFormatArray();
            lvFormat.Columns.AddRange([olvColumn1, olvColumn2]);
            lvFormat.SetObjects(f);
        }
    }
}
