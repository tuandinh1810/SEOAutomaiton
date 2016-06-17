using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SEOAutomation.Base.Service.GoogleAdword;
using  SEOAutomation.Base.Models.Common;
using SEOAutomation.GoogleAdword.Services;

namespace SEOAutomation.Winform
{
    public partial class ConfigAdword : Form
    {
        private IGoogleAdwordService _googleAdwordService;
        

        public ConfigAdword()
        {
            InitializeComponent();
           _googleAdwordService=new GoogleAdwordService();
            string a = GetIPAddress();


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                AdwordConfig obAdwordConfig = new AdwordConfig();
                obAdwordConfig.URL = txtURL.Text;
                obAdwordConfig.LinkQuantityClick = txtQuantityClick.Text;
                obAdwordConfig.KeyWord = txtKeyWord.Text;
                obAdwordConfig.IntervalClick = txtIntervalClick.Text;
                obAdwordConfig.PageLimit = int.Parse(txtPageLimit.Text);
                obAdwordConfig.IsBackLink = chkBackLink.Checked;
                obAdwordConfig.TextLink = txtTextLink.Text;
                obAdwordConfig.IsAdsen = chkAdsen.Checked;
                
                _googleAdwordService.Add(obAdwordConfig);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        protected string GetIPAddress()
        {
            // Gets the current context
            System.Web.HttpContext context = System.Web.HttpContext.Current;

            // Checks the HTTP_X_FORWARDED_FOR Header (which can be multiple IPs)
            string ipAddress = context.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

            //If that is not empty
            if (!string.IsNullOrEmpty(ipAddress))
            {
                // Grab the first address
                string[] addresses = ipAddress.Split(',');
                if (addresses.Length != 0)
                {
                    return addresses[0];
                }
            }

            // Otherwise use the REMOTE_ADDR Header
            return context.Request.ServerVariables["REMOTE_ADDR"];
        }
    }
}
