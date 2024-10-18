using PowerAudioPlayer.Controllers;

namespace PowerAudioPlayer.UI.CustomControls.SettingsPages
{
    public partial class ControlSettingsPage : UserControl
    {
        private string editingHotKey = string.Empty;

        public ControlSettingsPage()
        {
            InitializeComponent();
            cbEnableTrackbarControlButton.DataBindings.Add("Checked", Settings.Default, "EnableTrackbarControlButton", true, DataSourceUpdateMode.OnPropertyChanged);
            cbEnableTrackbarProgress.DataBindings.Add("Checked", Settings.Default, "EnableTrackbarProgress", true, DataSourceUpdateMode.OnPropertyChanged);
            cbShowStatusInTaskbarIcon.DataBindings.Add("Checked", Settings.Default, "ShowStatusInTaskbarIcon", true, DataSourceUpdateMode.OnPropertyChanged);
            cbResponseAppCommand.DataBindings.Add("Checked", Settings.Default, "ResponseAppCommand", true, DataSourceUpdateMode.OnPropertyChanged);
            cbEnableTrackbarProgress.DataBindings.Add("Enabled", Settings.Default, "EnableTrackbarControlButton", true, DataSourceUpdateMode.OnPropertyChanged);
            cbShowStatusInTaskbarIcon.DataBindings.Add("Enabled", Settings.Default, "EnableTrackbarControlButton", true, DataSourceUpdateMode.OnPropertyChanged);
        }
    }
}
