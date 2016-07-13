using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOAutomation.Base.Models.Common;
using SEOAutomation.Base.Service;
using SEOAutomation.Base.Service.GoogleAdword;

namespace SEOAutomation.GoogleAdword.Services
{
    public class GoogleAdwordService : BaseService, IGoogleAdwordService
    {
        public void Add(AdwordConfig objAdwordConfig)
        {
            if (objAdwordConfig.ID > 0)
            {
                var adwordConfig=SeoAutomationEntities.AdwordConfigs.FirstOrDefault(o => o.ID == objAdwordConfig.ID);
                //adwordConfig.ID = objAdwordConfig.ID;
                adwordConfig.URL = objAdwordConfig.URL;
                adwordConfig.KeyWord = objAdwordConfig.KeyWord;
                adwordConfig.IntervalClick = objAdwordConfig.IntervalClick;
                adwordConfig.IsAdsen = objAdwordConfig.IsAdsen;
                adwordConfig.IsBackLink= objAdwordConfig.IsBackLink;
                adwordConfig.LinkQuantityClick = objAdwordConfig.LinkQuantityClick;
                adwordConfig.PageLimit = objAdwordConfig.PageLimit;
                adwordConfig.TextLink = objAdwordConfig.TextLink;
            }
            else
            {
                SeoAutomationEntities.AdwordConfigs.Add(objAdwordConfig);
            }
                
            SeoAutomationEntities.SaveChanges();
        }

        public List<AdwordConfig> GetAdwordConfigs()
        {
            return SeoAutomationEntities.AdwordConfigs.ToList();
        }
        public string Add_Adword(AdwordConfig objAdwordConfig)
        {
            string strReturn = "";
            if (objAdwordConfig.ID > 0)
            {
                var adwordConfig = SeoAutomationEntities.AdwordConfigs.FirstOrDefault(o => o.ID == objAdwordConfig.ID);
                //adwordConfig.ID = objAdwordConfig.ID;
                adwordConfig.URL = objAdwordConfig.URL;
                adwordConfig.KeyWord = objAdwordConfig.KeyWord;
                adwordConfig.IntervalClick = objAdwordConfig.IntervalClick;
                adwordConfig.IsAdsen = objAdwordConfig.IsAdsen;
                adwordConfig.IsBackLink = objAdwordConfig.IsBackLink;
                adwordConfig.LinkQuantityClick = objAdwordConfig.LinkQuantityClick;
                adwordConfig.PageLimit = objAdwordConfig.PageLimit;
                adwordConfig.TextLink = objAdwordConfig.TextLink;
                strReturn = "Updated";
            }
            else
            {
                SeoAutomationEntities.AdwordConfigs.Add(objAdwordConfig);
                strReturn = "Added";
            }

            SeoAutomationEntities.SaveChanges();
            return strReturn;
        }
        public bool Delete(int Id)
        {
            try
            {
                AdwordConfig adword = SeoAutomationEntities.AdwordConfigs.Where(o => o.ID == Id).FirstOrDefault();
                SeoAutomationEntities.AdwordConfigs.Remove(adword);
                SeoAutomationEntities.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool isExisURL(string URL,int Id)
        {

           AdwordConfig adword = SeoAutomationEntities.AdwordConfigs.Where(o => o.URL.Equals(URL)).FirstOrDefault();
            if (adword != null && adword.ID!=Id)
            {
                 
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
