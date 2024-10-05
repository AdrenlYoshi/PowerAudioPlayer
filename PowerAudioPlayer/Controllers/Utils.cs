using Microsoft.Win32;
using System.IO;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace PowerAudioPlayer.Controllers
{
    internal static class Utils
    {
        public static IEnumerable<string> SearchFiles(string directoryPath, string[] fileExtensions, bool searchSubdirectories, bool ignoreInaccessible = true)
        {
            if (!Directory.Exists(directoryPath))
            {
                throw new DirectoryNotFoundException(directoryPath);
            }
            var options = searchSubdirectories ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
            try
            {
                var matchingFiles = fileExtensions.SelectMany(extension =>
                    Directory.EnumerateFiles(directoryPath, "*" + extension, options)
                );

                return matchingFiles;
            }
            catch (UnauthorizedAccessException) when (ignoreInaccessible)
            {
                return Enumerable.Empty<string>();
            }
        }

        public static bool IsSubDirectoryOf(string potentialSubdirectory, string directory)
        {
            potentialSubdirectory = Path.GetFullPath(potentialSubdirectory);
            directory = Path.GetFullPath(directory);
            if (potentialSubdirectory.Length < directory.Length)
            {
                return false;
            }
            if (!directory.EndsWith(Path.DirectorySeparatorChar.ToString()))
            {
                directory += Path.DirectorySeparatorChar;
            }
            return potentialSubdirectory.StartsWith(directory, StringComparison.OrdinalIgnoreCase);
        }

        public static void SetPropertyValue(object obj, string propertyName, object sValue)
        {
            PropertyInfo? p = obj.GetType().GetProperty(propertyName, BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);
            if (p != null)
            {
                object? dynmicValue;
                if (p.PropertyType.IsArray)
                {
                    p.SetValue(obj, sValue, null);
                }
                else
                {
                    if (string.IsNullOrEmpty(sValue.ToString()))
                        dynmicValue = p.PropertyType.IsValueType ? Activator.CreateInstance(p.PropertyType) : null;
                    else
                        dynmicValue = TypeDescriptor.GetConverter(p.PropertyType).ConvertFromString(sValue.ToString());
                    p.SetValue(obj, dynmicValue, null);
                }
            }
        }

        public static object GetPropertyValue(object obj, string propertyName)
        {
            Type type = obj.GetType();
            PropertyInfo propertyInfo = type.GetProperty(propertyName);
            return propertyInfo.GetValue(obj, null);
        }

        public static bool IsDesignMode()
        {
            bool returnFlag = false;
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                returnFlag = true;
            else if (Process.GetCurrentProcess().ProcessName == "DesignToolsServer" || Process.GetCurrentProcess().ProcessName == "devenv")
                returnFlag = true;
            return returnFlag;
        }

        public static bool IsUrl(string url)
        {
            if (string.IsNullOrWhiteSpace(url)) return false;
            if (Regex.IsMatch(url, @"^[A-Za-z]+://"))
                return true;
            else
                return false;
        }

        public static long GetFileSize(string sFullName)
        {
            long lSize = 0;
            if (File.Exists(sFullName))
                lSize = new FileInfo(sFullName).Length;
            return lSize;
        }

        public static string FormatTimeSecond(int t)
        {
            if (t <= 0)
                return "00:00";
            long minutes = t / 60;
            long seconds = t % 60;
            string formattedMinutes = minutes.ToString().PadLeft(2, '0');
            string formattedSeconds = seconds.ToString().PadLeft(2, '0');
            return $"{formattedMinutes}:{formattedSeconds}";
        }

        public static string FormatTimeSecond(double t)
        {
            if (t <= 0)
                return "00:00.00";
            int minutes = (int)Math.Truncate(t / 60);
            int seconds = (int)Math.Truncate(t % 60);
            double fractionalSeconds = (t - Math.Truncate(t)) * 100;
            fractionalSeconds = Math.Round(fractionalSeconds, 2);
            return $"{minutes:D2}:{seconds:D2}.{fractionalSeconds:F2}";
        }

        public static string FormatTimeMillisecond(int t)
        {
            if (t <= 0)
                return "00:00";
            long seconds = t / 1000;
            long minutes = seconds / 60;
            long sec = seconds % 60;
            string formattedMinutes = minutes.ToString().PadLeft(2, '0');
            string formattedSeconds = sec.ToString().PadLeft(2, '0');
            return $"{formattedMinutes}:{formattedSeconds}";
        }

        public static string FormatFileSize(long factSize)
        {
            string size;
            double sizeInBytes = factSize;
            if (sizeInBytes < 1024)
                size = sizeInBytes.ToString("F0") + " Byte"; // 小于1KB，直接使用字节  
            else if (sizeInBytes < 1048576) // 1MB  
                size = (sizeInBytes / 1024.0).ToString("F2") + " KiB"; // 转换为KB  
            else if (sizeInBytes < 1073741824) // 1GB  
                size = (sizeInBytes / (1024.0 * 1024.0)).ToString("F2") + " MiB"; // 转换为MB  
            else if (sizeInBytes < 1099511627776) // 1TB  
                size = (sizeInBytes / (1024.0 * 1024.0 * 1024.0)).ToString("F2") + " GiB"; // 转换为GB  
            else
                size = (sizeInBytes / (1024.0 * 1024.0 * 1024.0 * 1024.0)).ToString("F2") + " TiB"; // 转换为TB  
            return size;
        }

        public static Color GetSystemThemeColor()
        {
            using (RegistryKey? dwm = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\DWM", false))
            {
                if (dwm != null && dwm.GetValueNames().Contains("AccentColor"))
                {
                    int accentColor = Convert.ToInt32(dwm.GetValue("AccentColor"));
                    return Color.FromArgb(
                        (byte)(accentColor >> 24 & 0xFF),
                        (byte)(accentColor & 0xFF),
                        (byte)(accentColor >> 8 & 0xFF),
                        (byte)(accentColor >> 16 & 0xFF)
                        );
                }
            }
            return Color.Orange;
        }

        public static bool IsDarkMode()
        {
            const string registryKeyPath = @"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize";
            const string registryValueName = "AppsUseLightTheme";
            object? registryValueObject = Registry.CurrentUser.OpenSubKey(registryKeyPath)?.GetValue(registryValueName);
            if (registryValueObject is null)
                return false;
            return (int)registryValueObject <= 0;
        }

        public static bool EnableDarkModeForWindowTitle(IntPtr hWnd, bool enable)
        {
            int darkMode = enable ? 1 : 0;
            int hResult = NativeAPI.DwmSetWindowAttribute(hWnd, NativeAPI.DWMWA_USE_IMMERSIVE_DARK_MODE, ref darkMode, sizeof(int));
            return hResult > 0;
        }

        public static System.Windows.Media.Color GetMediaColorFromDrawingColor(Color color)
        {
            return System.Windows.Media.Color.FromArgb(color.A, color.R, color.G, color.B);
        }

        public static string Windows1254ToGB2312(string input)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            byte[] bytes = Encoding.GetEncoding(1254).GetBytes(input);
            return Encoding.GetEncoding(936).GetString(bytes, 0, bytes.Length);
        }

        public static Color ChangeColorLight(Color color, float correctionFactor)
        {
            float red = color.R;
            float green = color.G;
            float blue = color.B;
            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }
            if (red < 0) red = 0;
            if (red > 255) red = 255;
            if (green < 0) green = 0;
            if (green > 255) green = 255;
            if (blue < 0) blue = 0;
            if (blue > 255) blue = 255;
            return Color.FromArgb(color.A, (byte)(int)red, (byte)(int)green, (byte)(int)blue);
        }

        public static Color GetForColorByBackgroundColor(Color backgroundColor)
        {
            int brightness = (int)((backgroundColor.R * 0.299) + (backgroundColor.G * 0.587) + (backgroundColor.B * 0.114));
            if (brightness > 128)
                return Color.Black;
            else
                return Color.White;
        }

        unsafe public static void ExploreFile(string filePath)
        {
            if (!File.Exists(filePath) && !Directory.Exists(filePath))
                return;
            if (Directory.Exists(filePath))
                Process.Start(@"explorer.exe", "/select,\"" + filePath + "\"");
            else
            {
                IntPtr pidlList = NativeAPI.ILCreateFromPath(filePath);
                if (pidlList != IntPtr.Zero)
                {
                    try
                    {
                        Marshal.ThrowExceptionForHR(NativeAPI.SHOpenFolderAndSelectItems(pidlList, 0, IntPtr.Zero, 0));
                    }
                    finally
                    {
                        NativeAPI.ILFree(pidlList);
                    }
                }
            }
        }

        public static byte[] ImageToBytes(Image image)
        {
            if (image == null)
                return [];
            MemoryStream ms = new MemoryStream();
            image.Save(ms, image.RawFormat);
            return ms.ToArray();
        }

        public static Image? ByteToImage(byte[]? myByte)
        {
            if (myByte == null)
                return null;
            MemoryStream ms = new MemoryStream(myByte);
            Image _Image = Image.FromStream(ms);
            return _Image;
        }

        public static string RunCommandExeAndReturnOutput(string filename, string arguments)
        {
            Process process = new Process();
            process.StartInfo.FileName = filename;
            process.StartInfo.Arguments = arguments;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            return output;
        }

        public static string[] SegmentCommandLine(string args)
        {
            var nch = args.Length;
            var argv = new string[nch];
            var psrc = args;
            bool inquote;
            bool copychar;
            int numslash;
            int pNumArgs = 0;
            inquote = false;
            var currentIndex = 0;
            for (; ; )
            {
                if (currentIndex != psrc.Length)
                {
                    while (currentIndex != psrc.Length && (psrc[currentIndex] == ' ' || psrc[currentIndex] == '\t'))
                    {
                        currentIndex++;
                    }
                }
                if (currentIndex == psrc.Length)
                    break;
                var result = string.Empty;
                for (; ; )
                {
                    copychar = true;
                    numslash = 0;
                    while (currentIndex != psrc.Length && psrc[currentIndex] == '\\')
                    {
                        currentIndex++;
                        ++numslash;
                    }
                    if (currentIndex != psrc.Length && psrc[currentIndex] == '"')
                    {
                        if (numslash % 2 == 0)
                        {
                            if (inquote && psrc.Length != currentIndex + 1 && psrc[currentIndex + 1] == '"')
                            {
                                currentIndex++;
                            }
                            else
                            {
                                copychar = false;
                                inquote = !inquote;
                            }
                        }
                        numslash /= 2;
                    }
                    while (numslash != 0)
                    {
                        numslash--;
                        result += '\\';
                    }
                    if (currentIndex == psrc.Length || (!inquote && (psrc[currentIndex] == ' ' || psrc[currentIndex] == '\t')))
                        break;
                    if (copychar)
                    {
                        result += psrc[currentIndex];
                    }
                    currentIndex++;
                }
                argv[pNumArgs] = result;
                pNumArgs++;
            }
            return argv.TakeWhile(n => n != null).ToArray();
        }

        public static string GetProgramLocalAppDataPath()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), Assembly.GetExecutingAssembly().GetName().Name.ToString());
        }

        public static void AddShieldToButton(Button btn)
        {
            btn.FlatStyle = FlatStyle.System;
            NativeAPI.SendMessage(btn.Handle, NativeAPI.BCM_SETSHIELD, 0, 255);
        }

        public static void DeleteShieldFromButton(Button btn)
        {
            btn.FlatStyle = FlatStyle.System;
            NativeAPI.SendMessage(btn.Handle, NativeAPI.BCM_SETSHIELD, 0, 0);
        }
    }
}

