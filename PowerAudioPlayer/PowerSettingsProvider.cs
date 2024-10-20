using System.Collections.Specialized;
using System.Collections;
using System.Configuration;
using System.Diagnostics;
using System.Globalization;
using System.Xml;
using System.Reflection;

namespace PowerAudioPlayer
{
    public class PowerSettingsProvider : SettingsProvider
    {
        private const string UserSettingsGroupName = "userSettings";
        private string _applicationName = "";
        public override string ApplicationName { get => _applicationName; set => _applicationName = value; }

        public override void Initialize(string name, NameValueCollection values)
        {
            _applicationName = Assembly.GetExecutingAssembly().GetName().ToString();
            if (string.IsNullOrEmpty(name))
            {
                name = "CustomProvider";
            }
            base.Initialize(name, values);
        }

        private Configuration configuration;

        private void Open()
        {
            var fileMap = new ExeConfigurationFileMap
            {
                ExeConfigFilename = $"{_applicationName}.exe.config",
                RoamingUserConfigFilename = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\" + _applicationName + "\\Settings\\user.config"
            };
            configuration = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.PerUserRoaming);
        }

        public override SettingsPropertyValueCollection GetPropertyValues(SettingsContext context, SettingsPropertyCollection collection)
        {
            Open();
            var settings = ReadSettingsFromFile(GetSectionName(context));
            var values = new SettingsPropertyValueCollection();
            foreach (SettingsProperty settingProperty in collection)
            {
                var value = new SettingsPropertyValue(settingProperty);
                if (settings.Contains(settingProperty.Name))
                {
                    var ss = (StoredSetting)settings[settingProperty.Name];
                    var valueString = ss.xmlNode.InnerXml;
                    if (ss.serializeAs == SettingsSerializeAs.String)
                    {
                        valueString = Escaper.Unescape(valueString);
                    }
                    value.SerializedValue = valueString;
                }
                else if (settingProperty.DefaultValue != null)
                {
                    value.SerializedValue = settingProperty.DefaultValue;
                }

                value.IsDirty = false;
                values.Add(value);
            }
            return values;
        }

        private XmlEscaper Escaper = new XmlEscaper();

        private IDictionary ReadSettingsFromFile(string sectionName)
        {
            Hashtable settings = new Hashtable();

            var sectionGroup = configuration.GetSectionGroup(UserSettingsGroupName);
            if (sectionGroup != null)
            {
                if (sectionGroup.Sections[sectionName] is ClientSettingsSection section)
                {
                    foreach (SettingElement setting in section.Settings)
                    {
                        settings[setting.Name] = new StoredSetting(setting.SerializeAs, setting.Value.ValueXml);
                    }
                }
            }
            return settings;
        }

        private string GetSectionName(SettingsContext context)
        {
            string groupName = (string)context["GroupName"];
            string key = (string)context["SettingsKey"];

            Debug.Assert(groupName != null, "SettingsContext did not have a GroupName!");

            string sectionName = groupName;

            if (!string.IsNullOrEmpty(key))
            {
                sectionName = string.Format(CultureInfo.InvariantCulture, "{0}.{1}", sectionName, key);
            }

            return XmlConvert.EncodeLocalName(sectionName);
        }

        public override void SetPropertyValues(SettingsContext context, SettingsPropertyValueCollection collection)
        {
            string sectionName = GetSectionName(context);
            Hashtable userSettings = new Hashtable();
            foreach (SettingsPropertyValue value in collection)
            {
                SettingsProperty setting = value.Property;
                if (value.IsDirty)
                {
                    StoredSetting ss = new StoredSetting(setting.SerializeAs, SerializeToXmlElement(setting, value));
                    userSettings[setting.Name] = ss;
                }
            }
            WriteSettings(sectionName, userSettings);
        }

        private void WriteSettings(string sectionName, IDictionary newSettings)
        {
            Open();
            var section = GetConfigSection(sectionName);

            if (section != null)
            {
                SettingElementCollection sec = section.Settings;
                foreach (DictionaryEntry entry in newSettings)
                {
                    SettingElement se = sec.Get((string)entry.Key);

                    if (se == null)
                    {
                        se = new SettingElement();
                        se.Name = (string)entry.Key;
                        sec.Add(se);
                    }

                    StoredSetting? ss = (StoredSetting)entry.Value;
                    se.SerializeAs = ss.serializeAs;
                    se.Value.ValueXml = ss.xmlNode;
                }

                try
                {
                    configuration.Save();
                }
                catch (ConfigurationErrorsException ex)
                {
                    // We wrap this in an exception with our error message and throw again.
                    throw new ConfigurationErrorsException($"Save file to {configuration.FilePath} failed", ex);
                }
            }
            else
            {
                throw new ConfigurationErrorsException($"Can not find the section {section} in the setting file");
            }
        }

        private ClientSettingsSection GetConfigSection(string sectionName)
        {
            Configuration config = configuration;
            string fullSectionName = UserSettingsGroupName + "/" + sectionName;
            ClientSettingsSection? section = null;

            if (config != null)
            {
                section = config.GetSection(fullSectionName) as ClientSettingsSection;

                if (section == null)
                {
                    // Looks like the section isn't declared - let's declare it and try again.
                    DeclareSection(sectionName);
                    section = config.GetSection(fullSectionName) as ClientSettingsSection;
                }
            }

            return section;
        }

        // Declares the section handler of a given section in its section group, if a declaration isn't already
        // present. 
        private void DeclareSection(string sectionName)
        {
            Configuration config = configuration;
            ConfigurationSectionGroup settingsGroup = config.GetSectionGroup(UserSettingsGroupName);

            if (settingsGroup == null)
            {
                //Declare settings group
                ConfigurationSectionGroup group = new UserSettingsGroup();
                config.SectionGroups.Add(UserSettingsGroupName, group);
            }

            settingsGroup = config.GetSectionGroup(UserSettingsGroupName);

            Debug.Assert(settingsGroup != null, "Failed to declare settings group");

            if (settingsGroup != null)
            {
                ConfigurationSection section = settingsGroup.Sections[sectionName];
                if (section == null)
                {
                    section = new ClientSettingsSection();
                    section.SectionInformation.AllowExeDefinition = ConfigurationAllowExeDefinition.MachineToLocalUser;
                    section.SectionInformation.RequirePermission = false;
                    settingsGroup.Sections.Add(sectionName, section);
                }
            }
        }

        private XmlElement SerializeToXmlElement(SettingsProperty setting, SettingsPropertyValue value)
        {
            XmlDocument doc = new XmlDocument();
            XmlElement valueXml = doc.CreateElement("value");

            string? serializedValue = value.SerializedValue as string;
            if (serializedValue == null && setting.SerializeAs == SettingsSerializeAs.Binary)
            {
                // SettingsPropertyValue returns a byte[] in the binary serialization case. We need to
                // encode this - we use base64 since SettingsPropertyValue understands it and we won't have
                // to special case while deserializing.
                if (value.SerializedValue is byte[] buf)
                {
                    serializedValue = Convert.ToBase64String(buf);
                }
            }

            serializedValue ??= string.Empty;

            // We need to escape string serialized values
            if (setting.SerializeAs == SettingsSerializeAs.String)
            {
                serializedValue = Escaper.Escape(serializedValue);
            }

            valueXml.InnerXml = serializedValue;

            // Hack to remove the XmlDeclaration that the XmlSerializer adds. 
            XmlNode? unwanted = null;
            foreach (XmlNode child in valueXml.ChildNodes)
            {
                if (child.NodeType == XmlNodeType.XmlDeclaration)
                {
                    unwanted = child;
                    break;
                }
            }
            if (unwanted != null)
            {
                valueXml.RemoveChild(unwanted);
            }

            return valueXml;
        }

        private class XmlEscaper
        {
            private XmlDocument doc;
            private XmlElement temp;

            internal XmlEscaper()
            {
                doc = new XmlDocument();
                temp = doc.CreateElement("temp");
            }

            internal string Escape(string xmlString)
            {
                if (String.IsNullOrEmpty(xmlString))
                {
                    return xmlString;
                }

                temp.InnerText = xmlString;
                return temp.InnerXml;
            }

            internal string Unescape(string escapedString)
            {
                if (string.IsNullOrEmpty(escapedString))
                {
                    return escapedString;
                }

                temp.InnerXml = escapedString;
                return temp.InnerText;
            }
        }
    }

    internal class StoredSetting(SettingsSerializeAs serializeAs, XmlNode xmlNode)
    {
        internal SettingsSerializeAs serializeAs = serializeAs;
        internal XmlNode xmlNode = xmlNode;
    }
}