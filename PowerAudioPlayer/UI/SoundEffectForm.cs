using PowerAudioPlayer.Controllers;
using Un4seen.Bass;
using Un4seen.Bass.AddOn.Fx;

namespace PowerAudioPlayer.UI
{
    public partial class SoundEffectForm : BaseForm
    {
        public SoundEffectForm()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                if (GetControlFromName(this, $"trbEQ{i + 1}") is TrackBar trb)
                {
                    trb.Value = Settings.Default.Equalizer[i];
                }
            }
            cbEnableEQ.Checked = Settings.Default.EnableEqualizer;
            trbGain.Value = Settings.Default.SoundEffectGain;
        }

        private Control? GetControlFromName(Control container, string controlName)
        {
            foreach (Control c in container.Controls)
            {
                if (c.Name == controlName)
                {
                    return c;
                }
                if (c.HasChildren)
                {
                    Control? myControl = GetControlFromName(c, controlName);
                    if (myControl != null)
                    {
                        return myControl;
                    }
                }
            }
            return null;
        }

        private void EqTrackBar_Scroll(object sender, EventArgs e)
        {
            TrackBar currentTrackBar = (TrackBar)sender;
            if (currentTrackBar.Tag != null)
            {
                int band;
                if (!int.TryParse((string)currentTrackBar.Tag, out band)) band = 1;
                Settings.Default.Equalizer[band] = currentTrackBar.Value;
                if (Settings.Default.EnableEqualizer)
                    Player.Core.SetEQ(band, (float)(currentTrackBar.Value / 10f));
            }
        }

        private void btnResetEQ_Click(object sender, EventArgs e)
        {
            Player.Core.SetGain(0);
            trbGain.Value = 0;
            Settings.Default.SoundEffectGain = 0;
            for (int i = 0; i < 10; i++)
            {
                if (GetControlFromName(this, $"trbEQ{i + 1}") is TrackBar trb)
                {
                    trb.Value = 0;
                    Player.Core.SetEQ(i, 0);
                    Settings.Default.Equalizer[i] = 0;
                }
            }
        }

        private void trbGain_Scroll(object sender, EventArgs e)
        {
            if (Settings.Default.EnableEqualizer)
                Player.Core.SetGain(trbGain.Value / 10f);
            Settings.Default.SoundEffectGain = trbGain.Value;
        }

        private void cbEnableEQ_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.EnableEqualizer = cbEnableEQ.Checked;
            if (cbEnableEQ.Checked)
            {
                Player.Core.SetGain(Settings.Default.SoundEffectGain / 10f);
                for (int i = 0; i < 10; i++)
                {
                    Player.Core.SetEQ(i, Convert.ToInt32(Settings.Default.Equalizer[i]) / 10f);
                }
            }
            else
            {
                Player.Core.SetGain(0);
                for (int i = 0; i < 10; i++)
                {
                    Player.Core.SetEQ(i, 0);
                }
            }
        }

        private void trb_ValueChanged(object sender, EventArgs e)
        {
            toolTip.SetToolTip((TrackBar)sender, ((TrackBar)sender).Value.ToString());
        }
    }
}