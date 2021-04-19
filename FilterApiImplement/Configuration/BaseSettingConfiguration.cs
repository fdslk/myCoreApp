using System.Collections.Generic;

namespace FilterApiImplement.Configuration
{
    public class BaseSettingConfiguration
    {
        public string Url { get; set; }

        public Dictionary<string, string> LogLevel { get; set; }

        public string this[string LogLevelName] => LogLevel?.GetValueOrDefault(LogLevelName);
    }
}