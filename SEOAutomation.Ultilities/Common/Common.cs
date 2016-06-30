using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOAutomation.Ultilities.Common
{
    public class Common
    {

        public static string  getURI(string key)
        {
            string value = System.Configuration.ConfigurationManager.AppSettings[key];
            return value;
        }

    }
}
