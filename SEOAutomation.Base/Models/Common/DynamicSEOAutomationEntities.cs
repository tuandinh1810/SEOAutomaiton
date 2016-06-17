using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOAutomation.Base.Models.Common
{
    public class DynamicSEOAutomationEntities:SEOAutomationEntities
    {
        internal DynamicSEOAutomationEntities()
        {
            var adapter = (IObjectContextAdapter)this;
            var objectContext = adapter.ObjectContext;
            objectContext.CommandTimeout = 60 * 60; // value in seconds
        }
    }
}
