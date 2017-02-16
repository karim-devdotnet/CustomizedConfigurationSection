using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomizedConfigurationSection.Configuration
{
    [ConfigurationCollection(typeof(ConfigSubElement), AddItemName = "ConfigSubElement")]
    public class ConfigSubElementsCollection : ConfigurationElementCollection, IEnumerable<ConfigSubElement>
    {

        protected override ConfigurationElement CreateNewElement()
        {
            return new ConfigSubElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            var l_configElement = element as ConfigSubElement;
            if (l_configElement != null)
                return l_configElement.Key;
            else
                return null;
        }

        public ConfigSubElement this[int index]
        {
            get
            {
                return BaseGet(index) as ConfigSubElement;
            }
        }

        #region IEnumerable<ConfigSubElement> Members

        IEnumerator<ConfigSubElement> IEnumerable<ConfigSubElement>.GetEnumerator()
        {
            return (from i in Enumerable.Range(0, this.Count)
                    select this[i])
                    .GetEnumerator();
        }

        #endregion
    }
}
