using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using SEOAutomation.Base.Models.Common;

namespace SEOAutomation.Base.Service.GoogleAdword
{
    public interface IGoogleAdwordService
    {
        
        List<AdwordConfig> GetAdwordConfigs();
        void Add(AdwordConfig objAdwordConfig);

        bool iskExisURL(string URL,int Id);
        
    }
}
