using PowerAudioPlayer.Controllers;

namespace PowerAudioPlayer.UI.CustomControls.SettingsPages
{
    public partial class AppearanceSettingsPage : UserControl
    {
        public Form? Owner
        {
            get; set;
        }

        public AppearanceSettingsPage()
        {
            InitializeComponent();
            cbSpectrumDisable.DataBindings.Add("Checked", Settings.Default, "SpectrumDisable", true, DataSourceUpdateMode.OnPropertyChanged);
            cbSpectrumWithGrid.DataBindings.Add("Checked", Settings.Default, "SpectrumWithGrid", true, DataSourceUpdateMode.OnPropertyChanged);
            cbSpectrumFalloff.DataBindings.Add("Checked", Settings.Default, "SpectrumFalloff", true, DataSourceUpdateMode.OnPropertyChanged);
            cpSpectrumHighColor.DataBindings.Add("Color", Settings.Default, "SpectrumColorHigh", true, DataSourceUpdateMode.OnPropertyChanged);
            cpSpectrumMediumColor.DataBindings.Add("Color", Settings.Default, "SpectrumColorMedium", true, DataSourceUpdateMode.OnPropertyChanged);
            cpSpectrumNormalColor.DataBindings.Add("Color", Settings.Default, "SpectrumColorNormal", true, DataSourceUpdateMode.OnPropertyChanged);
            cpSpectrumGridColor.DataBindings.Add("Color", Settings.Default, "SpectrumColorGrid", true, DataSourceUpdateMode.OnPropertyChanged);
            cpSpectrumColorFalloff.DataBindings.Add("Color", Settings.Default, "SpectrumColorFalloff", true, DataSourceUpdateMode.OnPropertyChanged);
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