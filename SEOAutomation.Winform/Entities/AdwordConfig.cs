using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOAutomation.Winform.Entities
{
    public partial class AdwordConfig
    {
        public int ID { get; set; }
        public string URL { get; set; }
        public string KeyWord { get; set; }
        public string LinkQuantityClick { get; set; }
        public string IntervalClick { get; set; }
        public Nullable<bool> IsBackLink { get; set; }
        public string TextLink { get; set; }
        public Nullable<bool> IsAdsen { get; set; }
        public Nullable<int> PageLimit { get; set; }
        public string TextBackLink { get; set; }
    }
}
