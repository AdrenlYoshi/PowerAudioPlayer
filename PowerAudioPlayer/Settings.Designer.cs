﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace PowerAudioPlayer {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.11.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("80")]
        public int Volume {
            get {
                return ((int)(this["Volume"]));
            }
            set {
                this["Volume"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("OrderPlay")]
        public global::PowerAudioPlayer.Controllers.PlayMode PlayMode {
            get {
                return ((global::PowerAudioPlayer.Controllers.PlayMode)(this["PlayMode"]));
            }
            set {
                this["PlayMode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string MIDISoundFont {
            get {
                return ((string)(this["MIDISoundFont"]));
            }
            set {
                this["MIDISoundFont"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("zh-CN")]
        public string Language {
            get {
                return ((string)(this["Language"]));
            }
            set {
                this["Language"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("44100")]
        public int OutputSampleRate {
            get {
                return ((int)(this["OutputSampleRate"]));
            }
            set {
                this["OutputSampleRate"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("-1")]
        public int OutputDevice {
            get {
                return ((int)(this["OutputDevice"]));
            }
            set {
                this["OutputDevice"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool SpectrumDisable {
            get {
                return ((bool)(this["SpectrumDisable"]));
            }
            set {
                this["SpectrumDisable"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool StopPlayingWhenError {
            get {
                return ((bool)(this["StopPlayingWhenError"]));
            }
            set {
                this["StopPlayingWhenError"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool EnableTrackbarProgress {
            get {
                return ((bool)(this["EnableTrackbarProgress"]));
            }
            set {
                this["EnableTrackbarProgress"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool EnableTrackbarControlButton {
            get {
                return ((bool)(this["EnableTrackbarControlButton"]));
            }
            set {
                this["EnableTrackbarControlButton"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ShowStatusInTaskbarIcon {
            get {
                return ((bool)(this["ShowStatusInTaskbarIcon"]));
            }
            set {
                this["ShowStatusInTaskbarIcon"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int SoundEffectGain {
            get {
                return ((int)(this["SoundEffectGain"]));
            }
            set {
                this["SoundEffectGain"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool EnableEqualizer {
            get {
                return ((bool)(this["EnableEqualizer"]));
            }
            set {
                this["EnableEqualizer"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("923, 631")]
        public global::System.Drawing.Size PlayerFormSize {
            get {
                return ((global::System.Drawing.Size)(this["PlayerFormSize"]));
            }
            set {
                this["PlayerFormSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("100, 100")]
        public global::System.Drawing.Point PlayerFormLocation {
            get {
                return ((global::System.Drawing.Point)(this["PlayerFormLocation"]));
            }
            set {
                this["PlayerFormLocation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ResponseAppCommand {
            get {
                return ((bool)(this["ResponseAppCommand"]));
            }
            set {
                this["ResponseAppCommand"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string HotKeyNext {
            get {
                return ((string)(this["HotKeyNext"]));
            }
            set {
                this["HotKeyNext"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string HotKeyPrevious {
            get {
                return ((string)(this["HotKeyPrevious"]));
            }
            set {
                this["HotKeyPrevious"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string HotKeyVolUp {
            get {
                return ((string)(this["HotKeyVolUp"]));
            }
            set {
                this["HotKeyVolUp"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string HotKeyVolDown {
            get {
                return ((string)(this["HotKeyVolDown"]));
            }
            set {
                this["HotKeyVolDown"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string HotKeyPlayPause {
            get {
                return ((string)(this["HotKeyPlayPause"]));
            }
            set {
                this["HotKeyPlayPause"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string HotKeyStop {
            get {
                return ((string)(this["HotKeyStop"]));
            }
            set {
                this["HotKeyStop"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string HotKeyExit {
            get {
                return ((string)(this["HotKeyExit"]));
            }
            set {
                this["HotKeyExit"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool EnableHotKey {
            get {
                return ((bool)(this["EnableHotKey"]));
            }
            set {
                this["EnableHotKey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("255, 128, 0")]
        public global::System.Drawing.Color LyricsHighlightColor {
            get {
                return ((global::System.Drawing.Color)(this["LyricsHighlightColor"]));
            }
            set {
                this["LyricsHighlightColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10")]
        public int LyricsItemsMargin {
            get {
                return ((int)(this["LyricsItemsMargin"]));
            }
            set {
                this["LyricsItemsMargin"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Generic.List<PowerAudioPlayer.Controllers.MediaLibraryDirectory> MediaLibraryDirectories {
            get {
                return ((global::System.Collections.Generic.List<PowerAudioPlayer.Controllers.MediaLibraryDirectory>)(this["MediaLibraryDirectories"]));
            }
            set {
                this["MediaLibraryDirectories"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public int[] Equalizer {
            get {
                return ((int[])(this["Equalizer"]));
            }
            set {
                this["Equalizer"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool MediaLibraryStartUpUpdate {
            get {
                return ((bool)(this["MediaLibraryStartUpUpdate"]));
            }
            set {
                this["MediaLibraryStartUpUpdate"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool MediaLibraryAutoRemove {
            get {
                return ((bool)(this["MediaLibraryAutoRemove"]));
            }
            set {
                this["MediaLibraryAutoRemove"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool PlaylistEditorShowFileNameColumn {
            get {
                return ((bool)(this["PlaylistEditorShowFileNameColumn"]));
            }
            set {
                this["PlaylistEditorShowFileNameColumn"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool RecordPlayHistroy {
            get {
                return ((bool)(this["RecordPlayHistroy"]));
            }
            set {
                this["RecordPlayHistroy"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5000")]
        public int NetTimeOut {
            get {
                return ((int)(this["NetTimeOut"]));
            }
            set {
                this["NetTimeOut"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5000")]
        public int NetBuffer {
            get {
                return ((int)(this["NetBuffer"]));
            }
            set {
                this["NetBuffer"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("500")]
        public int PlayBuffer {
            get {
                return ((int)(this["PlayBuffer"]));
            }
            set {
                this["PlayBuffer"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("100")]
        public int MIDIVoices {
            get {
                return ((int)(this["MIDIVoices"]));
            }
            set {
                this["MIDIVoices"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ThemeColorFollowingSystem {
            get {
                return ((bool)(this["ThemeColorFollowingSystem"]));
            }
            set {
                this["ThemeColorFollowingSystem"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("128, 255, 128")]
        public global::System.Drawing.Color ThemeColor {
            get {
                return ((global::System.Drawing.Color)(this["ThemeColor"]));
            }
            set {
                this["ThemeColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UseSMTC {
            get {
                return ((bool)(this["UseSMTC"]));
            }
            set {
                this["UseSMTC"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("200")]
        public int PlayerControlInterval {
            get {
                return ((int)(this["PlayerControlInterval"]));
            }
            set {
                this["PlayerControlInterval"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("BASS")]
        public global::PowerAudioPlayer.Controllers.PlayerCores PlayerCore {
            get {
                return ((global::PowerAudioPlayer.Controllers.PlayerCores)(this["PlayerCore"]));
            }
            set {
                this["PlayerCore"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool SpectrumWithGrid {
            get {
                return ((bool)(this["SpectrumWithGrid"]));
            }
            set {
                this["SpectrumWithGrid"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Red")]
        public global::System.Drawing.Color SpectrumColorHigh {
            get {
                return ((global::System.Drawing.Color)(this["SpectrumColorHigh"]));
            }
            set {
                this["SpectrumColorHigh"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Yellow")]
        public global::System.Drawing.Color SpectrumColorMedium {
            get {
                return ((global::System.Drawing.Color)(this["SpectrumColorMedium"]));
            }
            set {
                this["SpectrumColorMedium"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Green")]
        public global::System.Drawing.Color SpectrumColorNormal {
            get {
                return ((global::System.Drawing.Color)(this["SpectrumColorNormal"]));
            }
            set {
                this["SpectrumColorNormal"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Gainsboro")]
        public global::System.Drawing.Color SpectrumColorGrid {
            get {
                return ((global::System.Drawing.Color)(this["SpectrumColorGrid"]));
            }
            set {
                this["SpectrumColorGrid"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool SpectrumFalloff {
            get {
                return ((bool)(this["SpectrumFalloff"]));
            }
            set {
                this["SpectrumFalloff"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Gray")]
        public global::System.Drawing.Color SpectrumColorFalloff {
            get {
                return ((global::System.Drawing.Color)(this["SpectrumColorFalloff"]));
            }
            set {
                this["SpectrumColorFalloff"] = value;
            }
        }
    }
}
