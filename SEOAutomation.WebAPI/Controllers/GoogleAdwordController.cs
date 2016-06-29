

using SEOAutomation.Base.Service.GoogleAdword;
using SEOAutomation.Base.Models.Common;
using SEOAutomation.GoogleAdword.Services;
using System.Web.Http;
using System.Collections.Generic;


namespace SEOAutomation.WebAPI.Controllers

{
    //[RoutePrefix("api/AdWord")]
    public class GoogleAdwordController : ApiController
    {
        // GET: GoogleAdword
        private readonly IGoogleAdwordService _googleAdwordService;
       

        public GoogleAdwordController()
        {
            _googleAdwordService = new GoogleAdwordService();
        }
       // [Route("Get")]
        public IEnumerable<AdwordConfig> Get()
        {
            return _googleAdwordService.GetAdwordConfigs();

        }
        public string Add_addWord(AdwordConfig adword)
        {
           return _googleAdwordService.Add_Adword(adword);
        }
        // 
        

        //[Route("ChecExisURL")]
        [HttpGet]
        public bool IsExisURL(string URL, int Id)
        {   
            return _googleAdwordService.isExisURL(URL,Id);
         
        }
    }
}