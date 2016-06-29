using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SEOAutomation.Base.Service.GoogleAdword;
using SEOAutomation.Base.Models.Common;
using SEOAutomation.GoogleAdword.Services;
using System.Web.Http;
namespace SEOAutomation.WebAPI.Controllers

{
    public class GoogleAdwordController : ApiController
    {
        // GET: GoogleAdword
        private readonly IGoogleAdwordService _googleAdwordService;
       

        public GoogleAdwordController()
        {
            _googleAdwordService = new GoogleAdwordService();
        }

        public IEnumerable<AdwordConfig> Get()
        {
            return _googleAdwordService.GetAdwordConfigs();
            
        }
        public string Add_addWord(AdwordConfig adword)
        {
           return _googleAdwordService.Add_Adword(adword);
        }
    }
}