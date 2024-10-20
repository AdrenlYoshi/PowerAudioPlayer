using PowerAudioPlayer.Controllers.Helper;
using PowerAudioPlayer.Model;
using System.IO;

namespace PowerAudioPlayer.Controllers.PlayerCore
{
    public class MCICore : IPlayerCore
    {
        private const string alias = "poweraudioplayer";
        private string file = string.Empty;
        private int midiSpeed = 0;
        private int midiTempo = 0;
        private int midiPosition = 0;
        private int midiLength = 0;

        public void Close()
        {
            NativeAPI.mciSendString(string.Format("close {0}", alias), null, 0, IntPtr.Zero);
        }

        public string[] GetAllSupportedFileArray()
        {
            return [];
        }

        public string GetAllSupportedFileFilter(string AllSupportedFileFilterString = "All Supported Files", string AllFilesString = "All Files")
        {
            return "";
        }

        public PlayerChannelInfo GetChannelInfo()
        {
            if (IsOpened())
            {
                PlayerChannelInfo info = new PlayerChannelInfo();
                info.type = AudioInfoHelper.StringToAudioType(Path.GetExtension(file).TrimStart('.'));
                return info;
            }
            else
            {
                return new PlayerChannelInfo();
            }
        }

        public PlayerChannelStatus GetChannelStatus()
        {
            string buffer = new string('\0', 16);  
            NativeAPI.mciSendString(string.Format("status {0} mode", alias), buffer, 16, IntPtr.Zero);
            switch (buffer.TrimEnd('\0'))
            {
                case "stopped":
                    return PlayerChannelStatus.Stopped;
                case "playing":
                    return PlayerChannelStatus.Playing;
                case "paused":
                    return PlayerChannelStatus.Paused;
                default:
                    return PlayerChannelStatus.Stopped;
            }

        }

        public int GetConfig(PlayerCoreConfig cfg)
        {
            return 0;
        }

        public int GetLengthMillisecond()
        {
            string buffer = new string('\0', 16);
            NativeAPI.mciSendString(string.Format("status {0} length", alias), buffer, 16, IntPtr.Zero);
            int length = Convert.ToInt32(buffer);
            if (GetChannelInfo().type == AudioType.MIDI && IsOpened())
            {
                midiLength = length / 4;
                if (midiSpeed > 0)
                    length = length * midiSpeed;
            }
            return length;
        }

        public int GetLengthSecond()
        {
            return GetLengthMillisecond() / 1000;
        }

        public int GetPositionMillisecond()
        {
            string buffer = new string('\0', 16);
            NativeAPI.mciSendString(string.Format("status {0} position", alias), buffer, 16, IntPtr.Zero);
            int position = Convert.ToInt32(buffer);
            if (GetChannelInfo().type == AudioType.MIDI && IsOpened())
            {
                midiPosition = position / 4;
                position = position * midiSpeed;
            }
            return position;
        }

        public int GetPositionSecond()
        {
            return GetPositionMillisecond() / 1000;
        }

        public int GetVolume()
        {
            string buffer = new string('\0', 16);
            NativeAPI.mciSendString(string.Format("status {0} volume", alias), buffer, 16, IntPtr.Zero);
            return Convert.ToInt32(buffer) / 10;
        }

        public void Init()
        {
            
        }

        public bool IsEnded()
        {
            return false;
        }

        public void Open(string file)
        {
            Close();
            this.file = file;
            NativeAPI.mciSendString(string.Format("open \"{0}\" alias {1}", file, alias), null, 0, IntPtr.Zero);
            if(GetChannelInfo().type == AudioType.MIDI && IsOpened())
            {
                string buffer = new string('\0', 16);
                NativeAPI.mciSendString(string.Format("status {0} length", alias), buffer, 16, IntPtr.Zero);
                midiLength = Convert.ToInt32(buffer);
                NativeAPI.mciSendString(string.Format("status {0} tempo", alias), buffer, 16, IntPtr.Zero);
                midiSpeed = Convert.ToInt32(buffer);
                if (midiSpeed > 0)
                    midiTempo = 60000000 / midiSpeed;
            }
        }

        public void Pause()
        {
            NativeAPI.mciSendString(string.Format("pause {0}", alias), null, 0, IntPtr.Zero);
        }

        public void Play()
        {
            NativeAPI.mciSendString(string.Format("play {0}", alias), null, 0, IntPtr.Zero);
        }

        public void SetConfig(PlayerCoreConfig cfg, int value)
        {
            
        }

        public void SetEQ(int band, float gain)
        {
            
        }

        public void SetGain(double value)
        {
            
        }

        public void SetMIDISoundFont(string file)
        {
            
        }

        public void SetPositionMillisecond(int pos)
        {
            if (GetChannelInfo().type == AudioType.MIDI && IsOpened())
                pos = pos / midiSpeed;
            NativeAPI.mciSendString(string.Format("seek {0} to {1}", alias, pos), null, 0, IntPtr.Zero);
            Play();
        }

        public void SetPositionSecond(int pos)
        {
            if (GetChannelInfo().type == AudioType.MIDI && IsOpened())
                pos = pos / midiSpeed;
            NativeAPI.mciSendString(string.Format("seek {0} to {1}", alias, pos * 1000), null, 0, IntPtr.Zero);
            Play();
        }

        public void SetVolume(int vol)
        {
            NativeAPI.mciSendString(string.Format("setaudio {0} volume to {1}", alias, vol * 10), null, 0, IntPtr.Zero);
        }

        public void Stop()
        {
            NativeAPI.mciSendString(string.Format("stop {0}", alias), null, 0, IntPtr.Zero);
        }

        public void UnInit()
        {
            Close();
        }

        public bool IsOpened()
        {
            string buffer = new string('\0', 16);
            NativeAPI.mciSendString(string.Format("status {0} mode", alias), buffer, 16, IntPtr.Zero);
            if (buffer.TrimEnd('\0') != string.Empty)
                return true;
            else
                return false;
        }

        public float[] GetFFTData()
        {
            return [];
        }

        public string GetMIDILyrics()
        {
            return "";
        }

        public bool IsSoundFontLoaded()
        {
            return true;
        }

        public List<SupportrdFormat> GetSupportrdFormatArray()
        {
            return new List<SupportrdFormat>();
        }
    }
}
