using PowerAudioPlayer.Controllers;
using System.ComponentModel;

namespace PowerAudioPlayer.UI.CustomControls.SettingsPages
{
    public partial class AppearanceSettingsPage : UserControl
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Form? Owner
        {
            get; set;
        }

        public AppearanceSettingsPage()
        {
            InitializeComponent();
            cpLyricsHighlightColor.DataBindings.Add("Color", Settings.Default, "LyricsHighlightColor", true, DataSourceUpdateMode.OnPropertyChanged);
            //cpLyricsNormalColor.DataBindings.Add("Color", Settings.Default, "LyricsNormalColor", true, DataSourceUpdateMode.OnPropertyChanged);
            nudLyricsItemsMargin.DataBindings.Add("Value", Settings.Default, "LyricsItemsMargin", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void cpLyricsNormalColor_ColorChanged(object sender, EventArgs e)
        {
        }

        private void nudLyricsItemsMargin_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}