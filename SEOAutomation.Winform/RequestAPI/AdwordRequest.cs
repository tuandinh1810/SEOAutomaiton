using System;
using System.Collections.Generic;
using SEOAutomation.Ultilities.Common;
using SEOAutomation.Base.Models.Common;
using System.Net.Http;
using System.Net.Http.Headers;
namespace SEOAutomation.Winform.RequestAPI
{
    public class AdwordRequest
    {
        string APIURI = "";
        public AdwordRequest()
        {
            APIURI = Common.getURI("APIURI");
        }

        public List<AdwordConfig> GetAdwordConfigs()
        {
            List<AdwordConfig> lstAdword = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(APIURI);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // New code:

                var response = client.GetAsync("api/GoogleAdword/get").Result;
                //client.PostAsJsonAsync
                if (response.EnsureSuccessStatusCode().StatusCode == System.Net.HttpStatusCode.OK)
                //This method is an extension method, defined in System.Net.Http.HttpContentExtensions    
                {
                     lstAdword = response.Content.ReadAsAsync<List<AdwordConfig>>().Result;
                    
                }

            }
            return lstAdword;
        }
        public bool IsExisURL(string URL, int Id)
        {
            bool isExis = false;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(APIURI);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // New code:

                var response = client.GetAsync("api/GoogleAdword/IsExisURL?URL=" + URL + "&Id=" + Id + "").Result;
                //client.PostAsJsonAsync
                if (response.EnsureSuccessStatusCode().StatusCode == System.Net.HttpStatusCode.OK)
                {
                    //This method is an extension method, defined in System.Net.Http.HttpContentExtensions    
                    isExis = response.Content.ReadAsAsync<bool>().Result;
                }


            }
            return isExis;
        }

        public bool Add_Adword(AdwordConfig obAdwordConfig)
        {
            bool status = false;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(APIURI);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // New code:
                var response = client.PostAsJsonAsync("api/GoogleAdword/Add_addWord", obAdwordConfig).Result;

                if (response.EnsureSuccessStatusCode().StatusCode == System.Net.HttpStatusCode.OK)
                {
                    status = true;
                }
                
            }
            return status;
        }

    }
}
