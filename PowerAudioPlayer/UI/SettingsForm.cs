namespace PowerAudioPlayer.UI
{
    public partial class SettingsForm : BaseForm
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            playSettingsPage1.Owner = Owner;
            appearanceSettingsPage1.Owner = Owner;
            mediaLibrarySettingsPage1.Owner = Owner;
        }
    }
}
