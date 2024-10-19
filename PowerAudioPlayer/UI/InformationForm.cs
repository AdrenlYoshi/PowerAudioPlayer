using PowerAudioPlayer.Controllers;
using PowerAudioPlayer.Controllers.Helper;
using PowerAudioPlayer.Model;
using System;
using System.Diagnostics;
using System.IO;
using Un4seen.Bass;
using Un4seen.Bass.AddOn.Tags;
using Utils = PowerAudioPlayer.Controllers.Utils;

namespace PowerAudioPlayer.UI
{
    public partial class InformationForm : BaseForm
    {
        public InformationForm()
        {
            InitializeComponent();
        }

        private void LoadInfo(string file)
        {
            tbFileName.Text = Utils.IsUrl(file) ? file : Path.GetFileName(file);
            tbPath.Text = file;
            if (Path.Exists(file))
            {
                int hStream = 0;
                if (Utils.IsUrl(file))
                {
                    hStream = Bass.BASS_StreamCreateURL(file, 0, 0, null, IntPtr.Zero);
                }
                else
                {
                    hStream = Bass.BASS_MusicLoad(file, 0, 0, BASSFlag.BASS_MUSIC_PRESCAN, 44100);
                    if (hStream == 0)
                        hStream = Bass.BASS_StreamCreateFile(file, 0, 0, 0);
                }
                if (hStream != 0)
                {
                    BASS_CHANNELINFO channelInfo = new BASS_CHANNELINFO();
                    Bass.BASS_ChannelGetInfo(hStream, channelInfo);
                    tbSize.Text = Utils.FormatFileSize(Utils.GetFileSize(file));
                    tbType.Text = AudioInfoHelper.GetAudioTypeByCType(channelInfo.ctype).ToString();
                    tbSamplerate.Text = string.Format("{0} Hz", channelInfo.freq);
                    tbBitrate.Text = string.Format("{0} Bit", channelInfo.sample);
                    tbChannel.Text = channelInfo.chans.ToString();
                    tbLength.Text = Player.GetString("Second", Bass.BASS_ChannelBytes2Seconds(hStream, Bass.BASS_ChannelGetLength(hStream)));
                    TAG_INFO tag = new TAG_INFO();
                    BassTags.BASS_TAG_GetFromFile(hStream, tag);
                    tbAlbum.Text = tag.album; ;
                    tbArtist.Text = tag.artist;
                    tbComment.Text = tag.comment;
                    tbCopyright.Text = tag.copyright;
                    tbGenre.Text = tag.genre;
                    tbTitle.Text = tag.title;
                    tbDisc.Text = tag.disc;
                    tbYear.Text = tag.year;
                    tbTrack.Text = tag.track;

                    pictureBox.Image = AudioInfoHelper.GetAudioPicture(file);
                    if(pictureBox.Image != null )
                        lblImage.Text = Player.GetString("ImageInformation", pictureBox.Image.Width, pictureBox.Image.Height, tag.PictureGet(0).MIMEType);
                }
            }
        }

        private void InformationForm_Load(object sender, EventArgs e)
        {
            if (Tag != null)
            {
                LoadInfo((string)Tag);
            }
            else
            {
                Close();
            }
        }

        private void llblView_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!Utils.IsUrl(tbPath.Text))
            {
                Utils.ExploreFile(tbPath.Text);
            }
            else
            {
                Process.Start(new ProcessStartInfo() { FileName = tbPath.Text, UseShellExecute = true});
            }
        }

        private void InformationForm_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBox.Show(Player.GetString("MsgInformationFormHelp"), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            e.Cancel = true;
        }

        private void pictureBox_DoubleClick(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = Player.GetString("FilterAllFile");
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox.Image.Save(saveFileDialog.FileName);
                }
            }
        }
    }
}
