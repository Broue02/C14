using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDP_Generator
{
    public class Settings
    {
        public string settingName;
        public string settingType;
        public string settingValue;

        public Settings(string name, string type, string value)
        {
            settingName = name;
            settingType = type;
            settingValue = value;
        }
    }
}
