using CustomizedConfigurationSection.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomizedConfigurationSection
{
    class Program
    {
        static void Main(string[] args)
        {
            var l_configSettings = (CustomConfigSection)ConfigurationManager.GetSection("CustomConfigSection");

            foreach (var l_element in l_configSettings.ConfigElements.AsEnumerable())
            {
                Console.WriteLine(l_element.Key);

                foreach (var l_subElement in l_element.SubElements.AsEnumerable())
                {
                    Console.WriteLine(l_subElement.Key);
                }

            }

            Console.WriteLine("Press any key...");
            Console.ReadKey(true);
        }
    }
}
