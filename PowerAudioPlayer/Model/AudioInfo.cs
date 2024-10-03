using MemoryPack;
using PowerAudioPlayer.Controllers.Helper;
using System.ComponentModel;

namespace PowerAudioPlayer.Model
{
    public enum AudioType
    {
        MP1, 
        MP2, 
        MP3,
        MP4,
        MIDI,
        OGG,
        WAV,
        WMA,
        FLAC,
        AIFF,
        MOD,
        MO3,
        MTM,
        S3M,
        XM,
        IT,
        WV,
        APE,
        MPC,
        AAC,
        SPX,
        ALAC,
        TTA,
        AC3,
        OPUS,
        OFR,
        ADX,
        AIX,
        CDA,
        Other
    }

    public enum ViewType
    {
        Artist,
        Album,
        Genre,
        FileType,
        Folder
    }

    [Serializable]
    [MemoryPackable]
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public partial class AudioTag
    {
        public string Album { get; set; } = string.Empty;

        public string Artist { get; set; } = string.Empty;

        public string Comment { get; set; } = string.Empty;

        public string Genre { get; set; } = string.Empty;

        public string Title { get; set; } = string.Empty;

        public string Copyright { get; set; } = string.Empty;

        public uint Disc { get; set; } = 0;

        public uint Track { get; set; } = 0;

        public uint Year { get; set; } = 0;
    }

    [Serializable]
    [MemoryPackable]
    public partial class AudioInfo
    {
        public string File { get; } = string.Empty;

        public int Length { get; } = 0;

        public AudioType Type { get; } = AudioType.Other;

        public AudioTag Tag { get; set; } = new AudioTag();

        [MemoryPackConstructor]
        public AudioInfo(string file = "", int length = 0, AudioType type = AudioType.Other)
        {
            File = file;
            Length = length;
            Type = type;
        }

        public AudioInfo(string file = "")
        {
            File = file;
            AudioInfo info = AudioInfoHelper.GetAudioInfo(file);
            Length = info.Length;
            Type = info.Type;
            Tag = info.Tag;
        }

        public AudioInfo()
        { 
        }
    }

    public class StringArrayItem
    {
        public string Value { get; set; } = string.Empty;

        public override string ToString()
        {
            return Value;
        }

        public StringArrayItem(string str)
        {
            Value = str;
        }

        public StringArrayItem() { }
    }

}