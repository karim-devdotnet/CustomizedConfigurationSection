using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomizedConfigurationSection.Configuration
{
    public class ConfigElement : ConfigurationElement
    {

        [ConfigurationProperty("key", IsKey = true, IsRequired = true)]
        public string Key
        {
            get
            {
                return base["key"] as string;
            }
            set
            {
                base["key"] = value;
            }
        }

        [ConfigurationProperty("SubElements")]
        public ConfigSubElementsCollection SubElements
        {
            get
            {
                return base["SubElements"] as ConfigSubElementsCollection;
            }
        }

    }
}
