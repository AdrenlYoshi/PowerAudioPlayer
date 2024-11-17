using Un4seen.Bass.Misc;
using Un4seen.Bass;
using System.Text;
using Un4seen.Bass.AddOn.Midi;
using System.IO;
using System.Runtime.InteropServices;
using PowerAudioPlayer.Model;
using PowerAudioPlayer.Controllers.Helper;

namespace PowerAudioPlayer.Controllers.PlayerCore
{
    public class BASSCore : IPlayerCore
    {
        private readonly static float[] FREQ_TABLE = [80f, 125f, 250f, 500f, 1000f, 1500f, 2000f, 4000f, 8000f, 1600f];
        private static int hStream = 0;
        private static int hSoundFont = 0;
        private static readonly int[] _fxEQ = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0];
        private static DSP_Gain _gain = new DSP_Gain();
        private static Dictionary<int, string> loadedPlugins = new Dictionary<int, string>();

        public void Close()
        {
            if (hStream != 0)
            {
                Bass.BASS_ChannelStop(hStream);
                Bass.BASS_ChannelFree(hStream);
                Bass.BASS_StreamFree(hStream);
                Bass.BASS_MusicFree(hStream);
                hStream = 0;
            }
        }

        public string[] GetAllSupportedFileArray()
        {
            StringBuilder sb = new StringBuilder(Bass.SupportedStreamExtensions + ";" + Bass.SupportedMusicExtensions + ";");
            foreach (var p in loadedPlugins)
            {
                var pinfo = Bass.BASS_PluginGetInfo(p.Key);

                for (int i = 0; i < pinfo.formatc; i++)
                {
                    var f = pinfo.formats[i];
                    sb.Append(f.exts);
                    sb.Append(';');
                }
            }
            return sb.ToString().Split(';', StringSplitOptions.RemoveEmptyEntries);
        }

        public string GetAllSupportedFileFilter(string AllSupportedFileFilterString = "All Supported Files", string AllFilesString = "All Files")
        {
            return $"{Un4seen.Bass.Utils.BASSAddOnGetPluginFileFilter(loadedPlugins, AllSupportedFileFilterString, true)}|{AllFilesString}|*.*";
        }

        public PlayerChannelInfo GetChannelInfo()
        {
            if (hStream != 0)
            {
                PlayerChannelInfo info = new PlayerChannelInfo();
                BASS_CHANNELINFO binfo = Bass.BASS_ChannelGetInfo(hStream);
                info.chans = binfo.chans;
                info.freq = binfo.freq;
                info.type = AudioInfoHelper.GetAudioTypeByCType(binfo.ctype);
                return info;
            }
            else
            {
                return new PlayerChannelInfo();
            }
        }

        public PlayerChannelStatus GetChannelStatus()
        {
            switch (Bass.BASS_ChannelIsActive(hStream))
            {
                case BASSActive.BASS_ACTIVE_STOPPED:
                    return PlayerChannelStatus.Stopped;
                case BASSActive.BASS_ACTIVE_PLAYING:
                    return PlayerChannelStatus.Playing;
                case BASSActive.BASS_ACTIVE_STALLED:
                    return PlayerChannelStatus.Playing;
                case BASSActive.BASS_ACTIVE_PAUSED:
                    return PlayerChannelStatus.Paused;
                default:
                    return PlayerChannelStatus.Stopped;
            }
        }

        public int GetConfig(PlayerCoreConfig cfg)
        {
            switch (cfg)
            {
                case PlayerCoreConfig.PlayBuffer:
                    return Bass.BASS_GetConfig(BASSConfig.BASS_CONFIG_BUFFER);
                case PlayerCoreConfig.MIDIVoices:
                    return Bass.BASS_GetConfig(BASSConfig.BASS_CONFIG_MIDI_VOICES);
                case PlayerCoreConfig.NetBuffer:
                    return Bass.BASS_GetConfig(BASSConfig.BASS_CONFIG_NET_BUFFER);
                case PlayerCoreConfig.NetTimeOut:
                    return Bass.BASS_GetConfig(BASSConfig.BASS_CONFIG_NET_TIMEOUT);
                default:
                    return 0;
            }
        }

        public int GetLengthMillisecond()
        {
            return (int)(Bass.BASS_ChannelBytes2Seconds(hStream, Bass.BASS_ChannelGetLength(hStream)) * 1000);
        }

        public int GetLengthSecond()
        {
            return (int)Bass.BASS_ChannelBytes2Seconds(hStream, Bass.BASS_ChannelGetLength(hStream));
        }

        public int GetPositionMillisecond()
        {
            return (int)(Bass.BASS_ChannelBytes2Seconds(hStream, Bass.BASS_ChannelGetPosition(hStream)) * 1000);
        }

        public int GetPositionSecond()
        {
            return (int)Bass.BASS_ChannelBytes2Seconds(hStream, Bass.BASS_ChannelGetPosition(hStream));
        }

        public void Init()
        {
            BassNet.Registration("adrenl1234@163.com", "2X39331812622");
            Bass.BASS_Init(Settings.Default.OutputDevice, 44100, 0, IntPtr.Zero);
            loadedPlugins = Bass.BASS_PluginLoadDirectory(AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "Plugins");
            Bass.BASS_SetConfig(BASSConfig.BASS_CONFIG_NET_PLAYLIST, 2);
        }

        public bool IsEnded()
        {
            if (GetChannelStatus() == PlayerChannelStatus.Stopped || hStream == 0)
                return true;
            else
                return false;
        }

        public void Open(string file)
        {
            if (hStream != 0)
                Close();
            try
            {
                if (Utils.IsUrl(file))
                {
                    hStream = Bass.BASS_StreamCreateURL(file, 0, 0, null, IntPtr.Zero);
                }
                else
                {
                    hStream = Bass.BASS_MusicLoad(file, 0, 0, BASSFlag.BASS_MUSIC_PRESCAN | BASSFlag.BASS_MUSIC_STOPBACK, Settings.Default.OutputSampleRate);
                    if (hStream == 0)
                        hStream = Bass.BASS_StreamCreateFile(file, 0, 0, 0);
                }
                BASS_DX8_PARAMEQ eq = new BASS_DX8_PARAMEQ();
                for (int i = 0; i < _fxEQ.Length; i++)
                {
                    _fxEQ[i] = Bass.BASS_ChannelSetFX(hStream, BASSFXType.BASS_FX_DX8_PARAMEQ, 0);
                }
                _gain = new DSP_Gain(hStream, 0);
                SetGain(Settings.Default.EnableEqualizer ? Settings.Default.SoundEffectGain / 10f : 0);
                eq.fBandwidth = 18f;
                for (int i = 0; i < 10; i++)
                {
                    eq.fCenter = FREQ_TABLE[i];
                    eq.fGain = Convert.ToInt16(Settings.Default.EnableEqualizer ? Settings.Default.Equalizer[i] : 0);
                    Bass.BASS_FXSetParameters(_fxEQ[i], eq);
                }
            }
            catch (SEHException)
            {
                hStream = 0;
            }
        }

        public void Pause()
        {
            Bass.BASS_ChannelPause(hStream);
        }

        public void Play()
        {
            Bass.BASS_ChannelPlay(hStream, false);
        }

        public void SetConfig(PlayerCoreConfig cfg, int value)
        {
            switch (cfg)
            {
                case PlayerCoreConfig.PlayBuffer:
                    Bass.BASS_SetConfig(BASSConfig.BASS_CONFIG_BUFFER, value);
                    break;
                case PlayerCoreConfig.MIDIVoices:
                    Bass.BASS_SetConfig(BASSConfig.BASS_CONFIG_MIDI_VOICES, value);
                    break;
                case PlayerCoreConfig.NetBuffer:
                    Bass.BASS_SetConfig(BASSConfig.BASS_CONFIG_NET_BUFFER, value);
                    break;
                case PlayerCoreConfig.NetTimeOut:
                    Bass.BASS_SetConfig(BASSConfig.BASS_CONFIG_NET_TIMEOUT, value);
                    break;
            }
        }

        public void SetEQ(int band, float gain)
        {
            BASS_DX8_PARAMEQ eq = new BASS_DX8_PARAMEQ();
            if (Bass.BASS_FXGetParameters(_fxEQ[band], eq))
            {
                eq.fGain = gain;
                Bass.BASS_FXSetParameters(_fxEQ[band], eq);
            }
        }

        public void SetGain(double value)
        {
            if (_gain != null)
            {
                try
                {
                    double gainDB = value;
                    if (gainDB == 0.0)
                        _gain.SetBypass(true);
                    else
                    {
                        _gain.SetBypass(false);
                        _gain.Gain_dBV = gainDB;
                    }
                }
                catch { }
            }
        }

        public void SetMIDISoundFont(string file)
        {
            if (!File.Exists(file))
            {
                BassMidi.BASS_MIDI_FontFree(hSoundFont);
                hSoundFont = 0;
                return;
            }
            int newfont = BassMidi.BASS_MIDI_FontInit(file);
            if (newfont != 0)
            {
                BASS_MIDI_FONT[] sf = [new BASS_MIDI_FONT(newfont, -1, 0)];
                BassMidi.BASS_MIDI_StreamSetFonts(0, sf, 1);
                BassMidi.BASS_MIDI_StreamSetFonts(hStream, sf, 1);
                BassMidi.BASS_MIDI_FontFree(hSoundFont);
                hSoundFont = newfont;
            }
        }

        public void SetPositionSecond(int pos)
        {
            Bass.BASS_ChannelSetPosition(hStream, pos);
        }

        public void SetPositionMillisecond(int pos)
        {
            long p = Bass.BASS_ChannelSeconds2Bytes(hStream, pos / 1000);
            Bass.BASS_ChannelSetPosition(hStream, p);
        }

        public void SetVolume(int vol)
        {
            Bass.BASS_SetConfig(BASSConfig.BASS_CONFIG_GVOL_STREAM, vol * 100);
            Bass.BASS_SetConfig(BASSConfig.BASS_CONFIG_GVOL_MUSIC, vol * 100);
        }

        public void Stop()
        {
            Bass.BASS_ChannelStop(hStream);
            Bass.BASS_ChannelSetPosition(hStream, 0);
        }

        public void UnInit()
        {
            Close();
            foreach (KeyValuePair<int, string> plugin in loadedPlugins)
            {
                Bass.BASS_PluginFree(plugin.Key);
            }
            Bass.BASS_Stop();
            Bass.BASS_Free();
        }

        public int GetVolume()
        {
            return Bass.BASS_GetConfig(BASSConfig.BASS_CONFIG_GVOL_STREAM) / 100;
        }

        public bool IsOpened()
        {
            return hStream == 0 ? false : true;
        }

        public float[] GetFFTData()
        {
            if (IsOpened())
            {
                float[] fft = new float[128];
                Bass.BASS_ChannelGetData(hStream, fft, (int)Un4seen.Bass.BASSData.BASS_DATA_FFT256);
                return fft;
            }
            else
            {
                return [];
            }
        }

        public string GetMIDILyrics()
        {
            string lrc = string.Empty;
            if (GetChannelInfo().type == AudioType.MIDI)
            {
                BASS_MIDI_MARK[]? marks = BassMidi.BASS_MIDI_StreamGetMarks(hStream, -1, BASSMIDIMarker.BASS_MIDI_MARK_LYRIC);
                if (marks == null)
                    marks = BassMidi.BASS_MIDI_StreamGetMarks(hStream, -1, BASSMIDIMarker.BASS_MIDI_MARK_TEXT);
                string line = string.Empty;
                bool newLine = true;
                if (marks != null && marks.Length > 0)
                {
                    foreach (BASS_MIDI_MARK mark in marks)
                    {
                        if (mark.text.StartsWith('/'))
                        {
                            lrc += line.Replace("\n", "") + "\n\n\n\n";
                            newLine = true;
                        }
                        else if (mark.text.StartsWith('@'))
                        {
                            string[] spilt = mark.text.Split('@');
                            foreach (string str in spilt)
                            {
                                lrc += $"[00:00.00]{str}\n";
                            }
                        }
                        else
                        {
                            if (newLine)
                            {
                                line = $"[{Utils.FormatTimeSecond(Bass.BASS_ChannelBytes2Seconds(hStream, mark.pos))}]{mark.text}";
                                newLine = false;
                            }
                            else
                            {
                                line += mark.text;
                            }
                        }
                    }
                    lrc = Utils.Windows1254ToGB2312(lrc).Replace('\\', new char()).Replace("\0", " ");
                }
            }
            return lrc;
        }

        public bool IsSoundFontLoaded()
        {
            return hSoundFont != 0;
        }

        public List<SupportrdFormat> GetSupportrdFormatArray()
        {
            List<SupportrdFormat> s = new List<SupportrdFormat>();
            foreach (var p in loadedPlugins)
            {
                var pinfo = Bass.BASS_PluginGetInfo(p.Key);

                for (int i = 0; i < pinfo.formatc; i++)
                {
                    var f = pinfo.formats[i];
                    s.Add(new SupportrdFormat(f.name, f.exts));
                }
            }
            return s;
        }
    }
}
