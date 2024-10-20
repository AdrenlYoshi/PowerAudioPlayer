using PowerAudioPlayer.Controllers.Helper;
using PowerAudioPlayer.Model;

namespace PowerAudioPlayer.Controllers.PlayerCore
{
    public enum PlayerCoreConfig
    {
        PlayBuffer,
        MIDIVoices,
        NetBuffer,
        NetTimeOut
    }

    public enum PlayerChannelStatus
    {
        Stopped,
        Playing,
        Paused
    }

    public class PlayerChannelInfo
    {
        public int freq;
        public int chans;
        public AudioType type;

        public override string ToString()
        {
            return string.Format("{0}, {1}Hz, {2}", AudioInfoHelper.AudioTypeToString(type), freq, AudioInfoHelper.ChannelNumberToString(chans));
        }
    }

    public class SupportrdFormat
    {
        public string Name { get; set; } = "";

        public string Extensions { get; set; } = "";


        public SupportrdFormat(string name, string extension)
        {
            Name = name;
            Extensions = extension;
        }

        public SupportrdFormat()
        {
        }
    }
    public interface IPlayerCore
    {
        void Open(string file);

        void Close();

        void Play();

        void Pause();

        void Stop();

        void SetVolume(int vol);

        int GetPositionSecond();

        int GetPositionMillisecond();

        void SetPositionSecond(int pos);

        void SetPositionMillisecond(int pos);

        int GetLengthSecond();

        int GetLengthMillisecond();

        void Init();

        void UnInit();

        void SetConfig(PlayerCoreConfig cfg, int value);

        int GetConfig(PlayerCoreConfig cfg);

        void SetMIDISoundFont(string file);

        PlayerChannelInfo GetChannelInfo();

        PlayerChannelStatus GetChannelStatus();

        bool IsEnded();

        void SetEQ(int band, float gain);

        void SetGain(double value);

        string[] GetAllSupportedFileArray();

        string GetAllSupportedFileFilter(string AllSupportedFileFilterString = "All Supported Files", string AllFilesString = "All Files");

        int GetVolume();

        bool IsOpened();

        float[] GetFFTData();

        string GetMIDILyrics();

        bool IsSoundFontLoaded();

        List<SupportrdFormat> GetSupportrdFormatArray();
    }
}