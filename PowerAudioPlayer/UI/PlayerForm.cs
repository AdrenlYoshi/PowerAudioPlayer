using Microsoft.WindowsAPICodePack.Taskbar;
using PowerAudioPlayer.Controllers;
using PowerAudioPlayer.Controllers.Helper;
using PowerAudioPlayer.Controllers.PlayerCore;
using PowerAudioPlayer.Model;
using PowerAudioPlayer.UI;
using System.IO;
using Clipboard = System.Windows.Forms.Clipboard;
using DataFormats = System.Windows.Forms.DataFormats;
using DragDropEffects = System.Windows.Forms.DragDropEffects;
using DragEventArgs = System.Windows.Forms.DragEventArgs;
using MessageBox = System.Windows.Forms.MessageBox;
using SaveFileDialog = System.Windows.Forms.SaveFileDialog;
using Utils = PowerAudioPlayer.Controllers.Utils;

namespace PowerAudioPlayer
{
    public partial class PlayerForm : BaseForm
    {
        //private SYNCPROC endSync = new SYNCPROC((int handle, int channel, int data, IntPtr user) => { });
        //private SYNCPROC metaSync = new SYNCPROC((int handle, int channel, int data, IntPtr user) => { });
        private readonly ThumbnailToolBarButton tbtnPrevious = new ThumbnailToolBarButton(Resources.Previousi, Player.GetString("SPrevious"));
        private readonly ThumbnailToolBarButton tbtnPlay = new ThumbnailToolBarButton(Resources.Playi, Player.GetString("Play"));
        private readonly ThumbnailToolBarButton tbtnPause = new ThumbnailToolBarButton(Resources.Pausei, Player.GetString("Pause"));
        private readonly ThumbnailToolBarButton tbtnStop = new ThumbnailToolBarButton(Resources.Stopi, Player.GetString("Stop"));
        private readonly ThumbnailToolBarButton tbtnNext = new ThumbnailToolBarButton(Resources.Nexti, Player.GetString("SNext"));
        private SoundEffectForm? soundEffectForm = null;
        private MediaLibraryForm mediaLibraryForm = new MediaLibraryForm();
        private PlaylistEditorForm playlistEditorForm = new PlaylistEditorForm();
        private LyricsForm lyricsForm = new LyricsForm();

        public PlayerForm()
        {
            InitializeComponent();
            InitBinding();
            Size = Settings.Default.PlayerFormSize;
            Location = Settings.Default.PlayerFormLocation;
            //endSync = new SYNCPROC(EndSync);
            //metaSync = new SYNCPROC(MetaSync);
            tbtnPrevious.Click += (object? sender, ThumbnailButtonClickedEventArgs e) => { btnPrevious_Click(new object(), new EventArgs()); };
            tbtnPlay.Click += (object? sender, ThumbnailButtonClickedEventArgs e) => { btnPlay_Click(new object(), new EventArgs()); };
            tbtnPause.Click += (object? sender, ThumbnailButtonClickedEventArgs e) => { btnPause_Click(new object(), new EventArgs()); };
            tbtnStop.Click += (object? sender, ThumbnailButtonClickedEventArgs e) => { btnStop_Click(new object(), new EventArgs()); };
            tbtnNext.Click += (object? sender, ThumbnailButtonClickedEventArgs e) => { btnNext_Click(new object(), new EventArgs()); };
            playlistEditorForm.Owner = this;
            playlistEditorForm.TopLevel = false;
            playlistEditorForm.Dock = DockStyle.Fill;
            playlistEditorForm.FormBorderStyle = FormBorderStyle.None;
            splitContainer1.Panel2.Controls.Add(playlistEditorForm);
            playlistEditorForm.Show();
            lyricsForm.Owner = this;
            lyricsForm.TopLevel = false;
            lyricsForm.Dock = DockStyle.Fill;
            lyricsForm.FormBorderStyle = FormBorderStyle.None;
            plLyrics.Controls.Add(lyricsForm);
            lyricsForm.Show();
            mediaLibraryForm.Owner = this;
            if (Settings.Default.MediaLibraryStartUpUpdate && mediaLibraryForm != null)
                NativeAPI.SendMessage(mediaLibraryForm.Handle, Player.WM_REFRESHMEDIALIBRARY, 0, 0);
        }

        #region Player Control Method
        private void ReadConfig()
        {
            Player.Core.SetVolume(Settings.Default.Volume);
            trbVolume.Value = Settings.Default.Volume;
            UpdateContols();
            switch (Settings.Default.PlayMode)
            {
                case PlayMode.OrderPlay:
                    tsbtnOrderPlay.Checked = true;
                    break;
                case PlayMode.ShufflePlay:
                    tsbtnShufflePlay.Checked = true;
                    break;
                case PlayMode.TrackLoop:
                    tsbtnTrackLoop.Checked = true;
                    break;
                case PlayMode.PlaylistLoop:
                    tsbtnPlaylistLoop.Checked = true;
                    break;
            }
        }

        private void Play(int index)
        {
            if (PlaylistHelper.ActivePlaylist.IsOutOfRange(index))
            {
                return;
            }
            lblStatus1.Text = Player.GetString("MsgReady");
            Player.ResetABRepeat();
            UpdateABRepeatToolTip();
            Player.Core.Open(PlaylistHelper.ActivePlaylist.Items[index].File);
            if (!Player.Core.IsOpened())
            {
                lblStatus1.Text = Player.GetString("MsgPlayErrorWithArg", PlaylistHelper.ActivePlaylist.Items[index].DisplayTitle);
                if (!Settings.Default.StopPlayingWhenError)
                {
                    Play(index + 1);
                    return;
                }
                else
                {
                    return;
                }
            }
            if (!Player.Core.IsSoundFontLoaded())
                lblStatus1.Text = Player.GetString("MsgMIDISoundFontNotSelected");
            Player.playIndex = index;
            Player.Core.Play();
            AudioInfo audioInfo = AudioInfoHelper.GetAudioInfo(PlaylistHelper.ActivePlaylist.Items[index].File);
            picAlbum.Image = AudioInfoHelper.GetAudioPicture(PlaylistHelper.ActivePlaylist.Items[index].File);
            if (audioInfo != null)
            {
                lblTitle.Text = !string.IsNullOrEmpty(audioInfo.Tag.Title) ? audioInfo.Tag.Title : string.Empty;
                lblArtist.Text = !string.IsNullOrEmpty(audioInfo.Tag.Artist) ? audioInfo.Tag.Artist : string.Empty;
                lblAlbum.Text = !string.IsNullOrEmpty(audioInfo.Tag.Album) ? audioInfo.Tag.Album : string.Empty;
                lblInfo.Text = Player.Core.GetChannelInfo().ToString();
            }
            lblDisplayTitle.Text = PlaylistHelper.ActivePlaylist.Items[index].DisplayTitle;

            tmrPlayer.Start();
            tmrSpectrum.Start();
            peakMeterCtrl.Start(1000 / 60);
            LoadLyrics();
            UpdateContols();
            if (Settings.Default.RecordPlayHistroy)
            {
                PlayHistoryHelper.Add(PlaylistHelper.ActivePlaylist.Items[index]);
                NativeAPI.SendMessage(mediaLibraryForm.Handle, Player.WM_REFRESHHISTORYVIEW, 0, 0);
            }
        }

        private void Play(PlaylistItem item)
        {
            Play(PlaylistHelper.ActivePlaylist.Items.IndexOf(item));
        }

        //private void EndSync(int handle, int channel, int data, nint user)
        //{
        //    Invoke(new Action(() =>
        //    {
        //        if (Settings.Default.PlayMode == PlayMode.TrackLoop)
        //        {
        //            Play(Player.playIndex);
        //            return;
        //        }
        //        tmrPlayer.Stop();
        //        tmrSpectrum.Stop();
        //        tmrLyrics.Stop();
        //        peakMeterCtrl.Stop();
        //        switch (Settings.Default.PlayMode)
        //        {
        //            case PlayMode.OrderPlay:
        //                if (Player.playIndex >= PlaylistHelper.ActivePlaylist.Count - 1)
        //                {
        //                    Player.Core.Close();
        //                    UpdateContols();
        //                }
        //                else
        //                {
        //                    btnNext_Click(new object(), new EventArgs());
        //                }
        //                break;
        //            case PlayMode.TrackLoop:

        //                break;
        //            case PlayMode.PlaylistLoop:
        //                if (Player.playIndex >= PlaylistHelper.ActivePlaylist.Count - 1)
        //                    Play(0);
        //                else
        //                    btnNext_Click(new object(), new EventArgs());
        //                break;
        //            case PlayMode.ShufflePlay:
        //                Play(new Random().Next(0, PlaylistHelper.ActivePlaylist.Count));
        //                break;
        //        }
        //    }));
        //}

        //private void MetaSync(int handle, int channel, int data, nint user)
        //{
        //    TAG_INFO _tagInfo = new TAG_INFO(Bass.BASS_ChannelGetInfo(channel).filename);
        //    if (_tagInfo.UpdateFromMETA(Bass.BASS_ChannelGetTags(channel, BASSTag.BASS_TAG_META), false, true))
        //    {
        //        Invoke(() =>
        //        {
        //            lblTitle.Text = !string.IsNullOrEmpty(_tagInfo.title) ? _tagInfo.title : "";
        //            lblArtist.Text = !string.IsNullOrEmpty(_tagInfo.artist) ? _tagInfo.artist : "";
        //            lblAlbum.Text = !string.IsNullOrEmpty(_tagInfo.album) ? _tagInfo.album : "";
        //            lblInfo.Text = Player.Core.GetChannelInfo().ToString();
        //            lblDisplayTitle.Text = AudioInfoHelper.GetDisplayTitle(AudioInfoHelper.BassTagInfo2AudioInfo(_tagInfo, _tagInfo.filename));
        //        });
        //    }
        //}

        private void Stop()
        {
            tmrPlayer.Stop();
            tmrLyrics.Stop();
            NativeAPI.SendMessage(lyricsForm.Handle, Player.WM_CLEARLRC, 0, 0);
            Player.Core.Stop();
            UpdateContols();
        }

        private void LoadLyrics()
        {
            NativeAPI.SendMessage(lyricsForm.Handle, Player.WM_LOADLYRICS, 0, 0);
            tmrLyrics.Start();
        }

        private void HandleCommandLine(string[] cmd)
        {

        }

        #endregion

        #region UI Method
        private void InitBinding()
        {
            Binding binding = new Binding("Text", Settings.Default, "Volume", true, DataSourceUpdateMode.OnPropertyChanged);
            binding.Format += (object? sender, ConvertEventArgs e) => { e.Value = string.Format("{0}%", e.Value.ToString()); };
            lblVolume.DataBindings.Add(binding);

            peakMeterCtrl.DataBindings.Add("ColorHigh", Settings.Default, "SpectrumColorHigh", true, DataSourceUpdateMode.OnPropertyChanged);
            peakMeterCtrl.DataBindings.Add("ColorMedium", Settings.Default, "SpectrumColorMedium", true, DataSourceUpdateMode.OnPropertyChanged);
            peakMeterCtrl.DataBindings.Add("ColorNormal", Settings.Default, "SpectrumColorNormal", true, DataSourceUpdateMode.OnPropertyChanged);
            peakMeterCtrl.DataBindings.Add("FalloffColor", Settings.Default, "SpectrumColorFalloff", true, DataSourceUpdateMode.OnPropertyChanged);
            peakMeterCtrl.DataBindings.Add("GridColor", Settings.Default, "SpectrumColorGrid", true, DataSourceUpdateMode.OnPropertyChanged);
            peakMeterCtrl.DataBindings.Add("ShowGrid", Settings.Default, "SpectrumWithGrid", true, DataSourceUpdateMode.OnPropertyChanged);
            peakMeterCtrl.DataBindings.Add("FalloffEffect", Settings.Default, "SpectrumFalloff", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void UpdateContols()
        {
            if (Player.Core.GetChannelStatus() == PlayerChannelStatus.Stopped || !Player.Core.IsOpened())
            {
                Text = Application.ProductName;
                lblPosition.Text = "00:00 / 00:00";
                trbPosition.Enabled = false;
                trbPosition.Maximum = 0;
                lblAlbum.Text = string.Empty;
                lblArtist.Text = string.Empty;
                lblTitle.Text = string.Empty;
                lblDisplayTitle.Text = Application.ProductName;
                lblInfo.Text = string.Empty;
                picAlbum.Image = null;
                lblStatus.Text = Player.GetString("Stop");
                SetTaskbarOverlayIcon(null, lblStatus.Text);
                SetTaskbarProgressState(TaskbarProgressBarState.NoProgress);
            }
            else
            {
                lblPosition.Text = string.Format("{0} / {1}", Utils.FormatTimeSecond(Player.Core.GetPositionSecond()), Utils.FormatTimeSecond(Player.Core.GetLengthSecond()));
                trbPosition.Maximum = Player.Core.GetLengthMillisecond();
                if (Player.Core.GetChannelStatus() == PlayerChannelStatus.Playing)
                {
                    try
                    {
                        trbPosition.Value = Player.Core.GetPositionMillisecond();
                        trbPosition.Enabled = true;
                    }
                    catch
                    {
                        trbPosition.Enabled = false;
                    }
                    lblStatus.Text = Player.GetString("Play");
                    SetTaskbarOverlayIcon(Resources.Playi, lblStatus.Text);
                    SetTaskbarProgressState(TaskbarProgressBarState.Normal);
                }
                else
                {
                    trbPosition.Enabled = false;
                    lblStatus.Text = Player.GetString("Pause");
                    SetTaskbarOverlayIcon(Resources.Pausei, lblStatus.Text);
                    SetTaskbarProgressState(TaskbarProgressBarState.Paused);
                }
                Text = $"[{lblStatus.Text}]{lblDisplayTitle.Text} - {Application.ProductName}";
                try
                {
                    SetTaskbarProgressValue(trbPosition.Value, trbPosition.Maximum);
                }
                catch
                {
                    SetTaskbarProgressValue(0, 0);
                }
            }
        }

        private void UpdateABRepeatToolTip()
        {
            if (Player.abRepeatMode == ABRepeatMode.ASelected)
            {
                tsbtnAPRepeat.Image = Resources.ABRepeatASelected;
                trbPosition.EnableSelRange = true;
                trbPosition.SelStart = trbPosition.Value;
            }
            else if (Player.abRepeatMode == ABRepeatMode.ABRepeat)
            {
                tsbtnAPRepeat.Image = Resources.ABRepeat;
                tsbtnAPRepeat.Checked = true;
                trbPosition.SelEnd = trbPosition.Value;
            }
            else
            {
                tsbtnAPRepeat.Image = Resources.ABRepeat;
                tsbtnAPRepeat.Checked = false;
                trbPosition.EnableSelRange = false;
            }
        }

        private void InitTrackbarControlButton()
        {
            TaskbarManager.Instance.ThumbnailToolBars?.AddButtons(Handle, tbtnPrevious, tbtnPlay, tbtnPause, tbtnStop, tbtnNext);
        }

        private void SetTaskbarProgressState(TaskbarProgressBarState state)
        {
            if (Settings.Default.EnableTrackbarProgress)
                TaskbarManager.Instance.SetProgressState(state);
            else
                TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.NoProgress);
        }

        private void SetTaskbarProgressValue(int currentValue, int? maximumValue)
        {
            if (Settings.Default.EnableTrackbarProgress)
                TaskbarManager.Instance.SetProgressValue(currentValue, maximumValue);
            else
                TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.NoProgress);
        }

        private void SetTaskbarOverlayIcon(Icon? icon, string accessibilityText)
        {
            if (Settings.Default.ShowStatusInTaskbarIcon)
                TaskbarManager.Instance.SetOverlayIcon(icon, accessibilityText);
            else
                TaskbarManager.Instance.SetOverlayIcon(null, "");
        }
        #endregion

        #region Events

        private void tmrSpectrum_Tick(object sender, EventArgs e)
        {
            if (Player.Core.GetChannelStatus() == PlayerChannelStatus.Playing && (!Settings.Default.SpectrumDisable && WindowState != FormWindowState.Minimized))
            {
                int[] FFTFall = Array.ConvertAll<float, int>(Player.Core.GetFFTData(), delegate (float f) { return (int)Math.Abs(f * 1500); });
                peakMeterCtrl.SetData(FFTFall, 0, FFTFall.Length);
            }
        }

        private void tmrPlayer_Tick(object sender, EventArgs e)
        {
            if (Player.Core.IsEnded())
            {
                if (Settings.Default.PlayMode == PlayMode.TrackLoop)
                {
                    Play(Player.playIndex);
                    return;
                }
                tmrPlayer.Stop();
                tmrSpectrum.Stop();
                tmrLyrics.Stop();
                switch (Settings.Default.PlayMode)
                {
                    case PlayMode.OrderPlay:
                        if (Player.playIndex >= PlaylistHelper.ActivePlaylist.Count - 1)
                        {
                            Player.Core.Close();
                            UpdateContols();
                        }
                        else
                        {
                            btnNext_Click(new object(), new EventArgs());
                        }
                        break;
                    case PlayMode.TrackLoop:

                        break;
                    case PlayMode.PlaylistLoop:
                        if (Player.playIndex >= PlaylistHelper.ActivePlaylist.Count - 1)
                            Play(0);
                        else
                            btnNext_Click(new object(), new EventArgs());
                        break;
                    case PlayMode.ShufflePlay:
                        Play(new Random().Next(0, PlaylistHelper.ActivePlaylist.Count));
                        break;
                }
            }
            Player.ContinueABRepeat();
            UpdateContols();
        }

        private void trbVolume_Scroll(object sender, EventArgs e)
        {
            Player.Core.SetVolume(trbVolume.Value);
            Settings.Default.Volume = trbVolume.Value;
        }

        private void tmrLyrics_Tick(object sender, EventArgs e)
        {
            try
            {
                if (Player.playIndex != -1 && Player.Core.GetChannelStatus() == PlayerChannelStatus.Playing)
                    NativeAPI.SendMessage(lyricsForm.Handle, Player.WM_LRCROLL, Player.Core.GetPositionMillisecond(), 0);
            }
            catch
            {
                NativeAPI.SendMessage(lyricsForm.Handle, Player.WM_CLEARLRC, 0, 0);
            }
        }

        private void trbPosition_Scroll(object sender, EventArgs e)
        {
            if (Player.Core.GetChannelStatus() == PlayerChannelStatus.Playing)
                Player.Core.SetPositionMillisecond(trbPosition.Value);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (((PlayMode)Settings.Default.PlayMode) == PlayMode.ShufflePlay)
                Play(new Random().Next(0, PlaylistHelper.ActivePlaylist.Count));
            else
                Play(Player.playIndex - 1);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (Player.playIndex == -1 && PlaylistHelper.ActivePlaylist.Count > 0)
            {
                Play(0);
                return;
            }
            if (Player.Core.GetChannelStatus() == PlayerChannelStatus.Paused)
            {
                Player.Core.Play();
                tmrPlayer.Start();
            }
            else if (Player.Core.GetChannelStatus() == PlayerChannelStatus.Stopped)
            {
                Play(Player.playIndex);
            }
            else
            {
                Player.ResetABRepeat();
                UpdateABRepeatToolTip();
                Player.Core.SetPositionMillisecond(0);
            }
            UpdateContols();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (Player.playIndex == -1 && PlaylistHelper.ActivePlaylist.Count > 0)
            {
                Play(0);
                return;
            }
            if (Player.Core.GetChannelStatus() == PlayerChannelStatus.Paused)
            {
                Player.Core.Play();
                tmrPlayer.Start();
            }
            else if (Player.Core.GetChannelStatus() == PlayerChannelStatus.Stopped)
            {
                Play(Player.playIndex);
            }
            else
            {
                Player.Core.Pause();
                tmrPlayer.Stop();
            }
            UpdateContols();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Player.ResetABRepeat();
            UpdateABRepeatToolTip();
            Stop();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (((PlayMode)Settings.Default.PlayMode) == PlayMode.ShufflePlay)
                btnPrevious_Click(sender, e);
            else
                Play(Player.playIndex + 1);
        }

        private void PlayerForm_Shown(object sender, EventArgs e)
        {
            ReadConfig();
            if (Settings.Default.EnableTrackbarControlButton)
                InitTrackbarControlButton();

            if (Environment.GetCommandLineArgs().Length > 1 && PlaylistHelper.ActivePlaylist.Count > 0)
                Play(0);
        }

        private void tsbtnSettings_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Owner = this;
            settingsForm.ShowDialog();
        }

        private void tsmiExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Filter = Player.GetString("FilterPlaylist"),
                FileName = $"{PlaylistHelper.ActivePlaylist.Name}.json"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                PlaylistHelper.SavePlaylist(saveFileDialog.FileName);
            }
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case Player.WM_PLAY:
                    Play(Convert.ToInt32(m.WParam));
                    if (m.LParam == 1)
                        NativeAPI.SendMessage(playlistEditorForm.Handle, Player.WM_REFRESHPLAYLISTVIEW, 0, 0);
                    break;
                case Player.WM_REFRESHPLAYLISTVIEW:
                    NativeAPI.SendMessage(playlistEditorForm.Handle, Player.WM_REFRESHPLAYLISTVIEW, 0, 0);
                    break;
                case Player.WM_LOCATETO:
                    NativeAPI.SendMessage(playlistEditorForm.Handle, Player.WM_LOCATETO, 0, 0);
                    break;
                case Player.WM_REFRESHMEDIALIBRARY:
                    NativeAPI.SendMessage(mediaLibraryForm.Handle, Player.WM_REFRESHMEDIALIBRARY, 0, 0);
                    break;
                case Player.WM_HANDLECOMMANDLINE:
                    HandleCommandLine(Environment.GetCommandLineArgs());
                    break;
                case NativeAPI.WM_COPYDATA:
                    NativeAPI.COPYDATASTRUCT cdata = new NativeAPI.COPYDATASTRUCT();
                    Type mytype = cdata.GetType();
                    cdata = (NativeAPI.COPYDATASTRUCT)m.GetLParam(mytype);
                    var args = Utils.SegmentCommandLine(cdata.lpData);
                    args[0] = string.Empty;
                    if (args.Length > 1)
                    {
                        PlaylistHelper.ActivePlaylist.Items.Clear();
                        foreach (var f in args)
                        {
                            if (!string.IsNullOrEmpty(f))
                                PlaylistHelper.ActivePlaylist.Items.Add(PlaylistItem.FormFile(f));
                        }
                        NativeAPI.SendMessage(playlistEditorForm.Handle, Player.WM_REFRESHPLAYLISTVIEW, 0, 0);
                        Play(0);
                    }
                    break;
                case NativeAPI.WM_APPCOMMAND:
                    if (Settings.Default.ResponseAppCommand)
                    {
                        int cmd = (int)((uint)m.LParam >> 16 & ~0xf000);
                        switch (cmd)
                        {
                            case NativeAPI.APPCOMMAND_MEDIA_PREVIOUSTRACK:
                                btnPrevious_Click(new(), new());
                                break;
                            case NativeAPI.APPCOMMAND_MEDIA_NEXTTRACK:
                                btnNext_Click(new(), new());
                                break;
                            case NativeAPI.APPCOMMAND_MEDIA_PAUSE:
                                btnPause_Click(new(), new());
                                break;
                            case NativeAPI.APPCOMMAND_MEDIA_PLAY:
                                btnPlay_Click(new(), new());
                                break;
                            case NativeAPI.APPCOMMAND_MEDIA_PLAY_PAUSE:
                                btnPause_Click(new(), new());
                                break;
                            case NativeAPI.APPCOMMAND_MEDIA_STOP:
                                btnStop_Click(new(), new());
                                break;
                            case NativeAPI.APPCOMMAND_VOLUME_DOWN:
                                try
                                {
                                    trbVolume.Value -= 4;
                                    trbVolume_Scroll(new(), new());
                                }
                                catch
                                {
                                    trbVolume.Value = 100;
                                }
                                break;
                            case NativeAPI.APPCOMMAND_VOLUME_UP:
                                try
                                {
                                    trbVolume.Value += 4;
                                    trbVolume_Scroll(new(), new());
                                }
                                catch
                                {
                                    trbVolume.Value = 100;
                                }
                                break;
                        }
                    }
                    break;
            }

            base.WndProc(ref m);
        }

        private void PlayerForm_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                try
                {
                    trbVolume.Value += 2;
                    trbVolume_Scroll(sender, new EventArgs());
                }
                catch
                {
                    trbVolume.Value = 100;
                }
            }
            else
            {
                try
                {
                    trbVolume.Value -= 2;
                    trbVolume_Scroll(sender, new EventArgs());
                }
                catch
                {
                    trbVolume.Value = 0;
                }
            }
        }

        private void PlayerForm_DragDrop(object sender, DragEventArgs e)
        {
            string[]? files = (string[]?)e.Data?.GetData(DataFormats.FileDrop, false);
            if (files != null)
            {
                string[]? allFileFilter = Player.Core.GetAllSupportedFileArray();
                List<PlaylistItem> items = new List<PlaylistItem>();
                foreach (var file in files)
                {
                    string ext = Path.GetExtension(file).ToLower();
                    if (ext == ".sf2" || ext == ".sf2pack" || ext == ".sf3")
                    {
                        Player.Core.SetMIDISoundFont(file);
                        Settings.Default.MIDISoundFont = file;
                    }
                    else if (allFileFilter.Contains("*" + ext) || allFileFilter.Length == 0)
                    {
                        items.Add(PlaylistItem.FormFile(file));
                    }
                }
                if (items.Count > 0)
                {
                    PlaylistHelper.ActivePlaylist.Clear();
                    PlaylistHelper.ActivePlaylist.Items.AddRange(items);
                    NativeAPI.SendMessage(playlistEditorForm.Handle, Player.WM_REFRESHPLAYLISTVIEW, 0, 0);
                    Play(0);
                }
            }
        }

        private void PlayerForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void tsbtnAPRepeat_Click(object sender, EventArgs e)
        {
            if (Player.Core.GetChannelStatus() == PlayerChannelStatus.Stopped || Player.Core.GetChannelStatus() == PlayerChannelStatus.Paused)
                return;
            Player.DoABRepeat();
            UpdateABRepeatToolTip();
        }

        private void tsbtnSoundEffect_Click(object sender, EventArgs e)
        {
            if (soundEffectForm == null)
            {
                soundEffectForm = new SoundEffectForm() { Owner = this };
                soundEffectForm.FormClosed += (object? sender, FormClosedEventArgs e) =>
                {
                    soundEffectForm = null;
                };
                soundEffectForm.Show();
            }
            else
            {
                soundEffectForm.Close();
                soundEffectForm = null;
            }
        }

        private void PlayerForm_LocationChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                Settings.Default.PlayerFormLocation = Location;
        }

        private void PlayerForm_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                Settings.Default.PlayerFormSize = Size;
        }

        private void lbl_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(((Label)sender).Text);
            MessageBox.Show(Player.GetString("MsgCopyed", ((Label)sender).Text), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tsbtnMediaLibraryForm_Click(object sender, EventArgs e)
        {
            if (mediaLibraryForm.Visible)
            {
                mediaLibraryForm.Hide();
            }
            else
            {
                mediaLibraryForm.Show();
            }
        }

        private void PlayerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            mediaLibraryForm.Dispose();
            playlistEditorForm.Dispose();
            lyricsForm.Dispose();
            e.Cancel = false;
        }

        private void lblDisplayTitle_DoubleClick(object sender, EventArgs e)
        {
            if (Player.playIndex != -1)
                new InformationForm() { Tag = PlaylistHelper.ActivePlaylist.Items[Player.playIndex].File }.ShowDialog();
        }

        private void tsbtnPlayMode_Click(object sender, EventArgs e)
        {
            Settings.Default.PlayMode = (PlayMode)Enum.Parse(typeof(PlayMode), ((string)((WinFormsExtendedControls.ToolStripRadioButton)sender).Tag).Split('|')[0]);
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog();
        }

        private void tsmiSupportedFormat_Click(object sender, EventArgs e)
        {
            new SupportrdFormatForm().ShowDialog();
        }

        private void tsmiCreateDesktopShortcut_Click(object sender, EventArgs e)
        {
            Utils.CreateShortcut(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), Application.ProductName + ".lnk"), Application.ExecutablePath, "");
        }
        #endregion
    }
}