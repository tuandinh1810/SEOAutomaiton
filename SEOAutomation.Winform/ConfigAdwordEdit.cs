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
using SEOAutomation.Base.Models.Common;
using SEOAutomation.GoogleAdword.Services;
using System.Net.Http;
using System.Net.Http.Headers;
namespace SEOAutomation.Winform
{
    public partial class ConfigAdwordEdit : Form
    {
        private IGoogleAdwordService _googleAdwordService;
        private int Id = 0;

        public ConfigAdwordEdit()
        {
            InitializeComponent();
            dtGridAdwordConfig.AutoGenerateColumns = false;
            _googleAdwordService = new GoogleAdwordService();
            //string a=GetIPAddress();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidInput())
                {
                    
                    AdwordConfig obAdwordConfig = new AdwordConfig();
                    if (Id > 0)
                        obAdwordConfig.ID = Id;
                    obAdwordConfig.URL = txtURL.Text;
                    obAdwordConfig.LinkQuantityClick = txtQuantityClick.Text;
                    obAdwordConfig.KeyWord = txtKeyWord.Text;
                    obAdwordConfig.IntervalClick = txtIntervalClick.Text;
                    obAdwordConfig.PageLimit = int.Parse(txtPageLimit.Text);
                    obAdwordConfig.IsBackLink = chkBackLink.Checked;
                    obAdwordConfig.TextBackLink = txtTextBackLink.Text;
                    obAdwordConfig.TextLink = txtTextLink.Text;
                    obAdwordConfig.IsAdsen = chkAdsen.Checked;


                    using (var client = new HttpClient())
                    {
                        client.BaseAddress = new Uri("http://localhost:58199/");
                        client.DefaultRequestHeaders.Accept.Clear();
                        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                        // New code:
                        var response = client.PostAsJsonAsync("api/GoogleAdword/Add_addWord", obAdwordConfig).Result;


                        //var response = client.GetAsync("api/GoogleAdword/get").Result;
                        //client.PostAsJsonAsync
                        response.EnsureSuccessStatusCode();
                        //This method is an extension method, defined in System.Net.Http.HttpContentExtensions    
                        // var books = response.Content.ReadAsAsync<IEnumerable<AdwordConfig>>().Result;
                        //if (response.IsSuccessStatusCode)
                        //{
                        //    //AdwordConfig product = await response.Content.ReadAsAsync>AdwordConfig>();
                        //   List<AdwordConfig> product = await response.Content.ReadAsAsync<List<AdwordConfig>>();
                        //    //Console.WriteLine("{0}\t${1}\t{2}", product.Name, product.Price, product.Category);
                        //}
                    }


                    //_googleAdwordService.Add(obAdwordConfig);
                    bindData();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        private bool ValidInput()
        {
            if (String.IsNullOrEmpty(txtURL.Text))
            {
                MessageBox.Show("Bạn chưa nhập URL.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            if (String.IsNullOrEmpty(txtTextLink.Text))
            {
                MessageBox.Show("Bạn chưa nhập Title link.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            if (String.IsNullOrEmpty(txtKeyWord.Text))
            {
                MessageBox.Show("Bạn chưa nhập Key Word.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            if (String.IsNullOrEmpty(txtIntervalClick.Text))
            {
                MessageBox.Show("Bạn chưa nhập Interval.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            if (String.IsNullOrEmpty(txtPageLimit.Text))
            {
                MessageBox.Show("Bạn chưa nhập page limit.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            if (String.IsNullOrEmpty(txtQuantityClick.Text))
            {
                MessageBox.Show("Bạn chưa nhập số lượng link cần click.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            if (_googleAdwordService.iskExisURL(txtURL.Text,Id))
            {
                MessageBox.Show("URL đã tồn tại.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfigAdwordEdit_Load(object sender, EventArgs e)
        {
           bindData();
        }

        private void bindData()
        {
            // dtGridAdwordConfig.DataSource = _googleAdwordService.GetAdwordConfigs();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:58199/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // New code:

                var response = client.GetAsync("api/GoogleAdword/get").Result;
                //client.PostAsJsonAsync
                response.EnsureSuccessStatusCode();
                //This method is an extension method, defined in System.Net.Http.HttpContentExtensions    
                List<AdwordConfig> lstAdword = response.Content.ReadAsAsync<List<AdwordConfig>>().Result;
                dtGridAdwordConfig.DataSource = lstAdword;// _googleAdwordService.GetAdwordConfigs();

            }

        }

        private void dtGridAdwordConfig_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
            int rowIndex = e.RowIndex;
            
            DataGridViewRow row = dtGridAdwordConfig.Rows[rowIndex];
            if (row != null)
            {
                if (row.Cells["URL"] != null)
                    txtURL.Text = row.Cells["URL"].Value.ToString();
                if (row.Cells["KeyWord"] != null)
                    txtKeyWord.Text = row.Cells["KeyWord"].Value.ToString();
                if (row.Cells["LinkQuantityClick"] != null)
                    txtQuantityClick.Text = row.Cells["LinkQuantityClick"].Value.ToString();
                if (row.Cells["IntervalClick"] != null)
                    txtIntervalClick.Text = row.Cells["IntervalClick"].Value.ToString();
                if (row.Cells["IsBackLink"] != null)
                    chkBackLink.Checked = (bool) row.Cells["IsBackLink"].Value;
                if (row.Cells["TextBackLink"].Value != null)
                    txtTextBackLink.Text = row.Cells["TextBackLink"].Value.ToString();
                if (row.Cells["TextLink"] != null)
                    txtTextLink.Text = row.Cells["TextLink"].Value.ToString();
                if (row.Cells["IsAdsen"] != null)
                    chkAdsen.Checked = (bool)row.Cells["IsAdsen"].Value;
                if (row.Cells["PageLimit"].Value != null)
                    txtPageLimit.Text = row.Cells["PageLimit"].Value.ToString();
                if (row.Cells["AdWordID"].Value != null)
                    Id = (int) row.Cells["AdWordID"].Value;

            }
          
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            txtURL.Text = "";

            txtKeyWord.Text = "";

            txtQuantityClick.Text = "";

            txtIntervalClick.Text = "";

            chkBackLink.Checked = false;

            txtTextBackLink.Text = "";

            chkAdsen.Checked = false;

            txtPageLimit.Text = "";

            txtTextBackLink.Text = "";

            Id = 0;



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
