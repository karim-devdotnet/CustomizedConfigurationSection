using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomizedConfigurationSection.Configuration
{
    public class CustomConfigSection: ConfigurationSection
    {
        [ConfigurationProperty("ConfigElements", IsRequired = true)]
        public ConfigElementsCollection ConfigElements
        {
            get
            {
                return base["ConfigElements"] as ConfigElementsCollection;
            }
        }
    }
}
