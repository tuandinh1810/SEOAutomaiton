using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using SEOAutomation.Base.Models.Common;
using SEOAutomation.RequestAPI;
using System.Web;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System.Text.RegularExpressions;

namespace SEOAutomation.FirefoxDrive
{
    public partial class FireFoxDrive : Form
    {

        public bool isClick = false;
        Timer clickLinkTimer = new Timer();
        Timer clickAdsenTimer = new Timer();
        int intInterval = 20;
        int clickLimit = 0;
        List<AdwordConfig> lstAdwordConfigs = null;
        private AdwordConfig objAdwordConfig = null;
        private int numberURL = 0;
        int countClickOnSite = 0;
        private string googleURL = "https://www.google.com/search?q=";
        private string yahooURL = "https://vn.search.yahoo.com/search?p=";
        private string bingURL = "http://www.bing.com/search?q=";
        private bool isFindingURL = false;
        private int page = 0;
        string IPPublic = "";
        private string APIURI = "";
        private AdwordRequest rqAdword;
        string excutePath = "";
        FirefoxDriver firefoxDrive;

        public FireFoxDrive()
        {
            InitializeComponent();
            firefoxDrive = new FirefoxDriver();

            rqAdword = new AdwordRequest();
            excutePath = Path.GetDirectoryName(Application.ExecutablePath);
            IPPublic = getPublicIP();
            WriteLog(IPPublic.ToString());
            WriteLogIP("Activated");
        }




        private string getPublicIP()
        {
            //string url = "http://checkip.dyndns.org";
            //System.Net.WebRequest req = System.Net.WebRequest.Create(url);
            //System.Net.WebResponse resp = req.GetResponse();
            //System.IO.StreamReader sr = new System.IO.StreamReader(resp.GetResponseStream());
            //string response = sr.ReadToEnd().Trim();
            //string[] a = response.Split(':');
            //string a2 = a[1].Substring(1);
            //string[] a3 = a2.Split('<');
            //string a4 = a3[0];
            //return a4;
            string externalip = "";
            try
            {
                externalip = new System.Net.WebClient().DownloadString("http://ipinfo.io/ip");

            }

            catch
            {
                //externalip = new System.Net.WebClient().DownloadString("http://checkip.dyndns.org");
                WriteLog("Donn't get IP");
            }
            return externalip;
        }

        private void WriteLog(string strLog)
        {
            File.AppendAllText(excutePath + @"\Log\LogViewLink.txt", strLog + Environment.NewLine);
        }
        private void WriteLogIP(string strLog)
        {
            File.AppendAllText(excutePath + @"\Log\ResetIPFlag.txt", strLog + Environment.NewLine);
        }

        private void FireFoxDrive_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            lstAdwordConfigs = rqAdword.GetAdwordConfigs().OrderByDescending(o => o.ID).ToList();
             ViewLink();
        }
        public static string StripHTML(string input)
        {
            return Regex.Replace(input, "<.*?>", String.Empty);
        }
        private void ViewLink()
        {
            if (numberURL <= lstAdwordConfigs.Count - 1)
            {

                if (lstAdwordConfigs != null && lstAdwordConfigs.Count > 0)
                {
                    objAdwordConfig = lstAdwordConfigs[numberURL];
                }


                string[] arrKeyWord = objAdwordConfig.KeyWord.Split(',');
                string[] arrclickLimit = objAdwordConfig.LinkQuantityClick.Split(',');
                if (arrclickLimit.Length > 0)
                {
                    Random rdClickLimit = new Random();
                    clickLimit = rdClickLimit.Next(int.Parse(arrclickLimit[0]), int.Parse(arrclickLimit[1]));
                    //MessageBox.Show("số lần click tối đa : " + clickLimit.ToString());
                }
                if (arrKeyWord.Length > 0)
                {
                    int i = 0;
                    //rdKeyWord.Next(0,arrKeyWord.Count()-1]
                    Random rdKeyWord = new Random();
                    string strQuery = HttpUtility.UrlEncode(arrKeyWord[i]);
                    // geckoBrower.Dispose();
                    firefoxDrive.Navigate().GoToUrl(googleURL + strQuery);
                    System.Threading.Thread.Sleep(5000);
                    ViewLinkDetail();


                }

            }
            else
            {
                clickLinkTimer.Stop();
                clickLinkTimer.Enabled = false;
                clickLinkTimer.Dispose();
                //MessageBox.Show("Done Number URL : " + numberURL);
                WriteLogIP("NewIP");
                //WriteLogIP("ADSEN");



                //click adsen

                //clickAdsenTimer = new Timer();
                //clickAdsenTimer.Interval = (1 * 20 * 1000);
                //clickAdsenTimer.Tick += new EventHandler(clickAdsenTimer_Tick);
                //clickAdsenTimer.Start();

                ////Loop khi reset IP

                System.Threading.Thread.Sleep(3 * 60000);
                IPPublic = getPublicIP();
                WriteLog(IPPublic.ToString());
                if (!IPPublic.Equals(IPPublic.ToString()))
                {

                    MessageBox.Show(IPPublic);

                }

                numberURL = 0;

                loop_ViewLinkWithIP();

            }
        }
        private void clickAdsenTimer_Tick(object sender, EventArgs e)
        {
            //Loop khi reset IP
            string[] arrLog = File.ReadAllLines(excutePath + @"\Log\ResetIPFlag.txt");
            if (arrLog.Length > 0 && arrLog[arrLog.Length - 1].Equals("NewIP"))
            {
                System.Threading.Thread.Sleep(3 * 60000);
                IPPublic = getPublicIP();
                WriteLog(IPPublic.ToString());
                if (!IPPublic.Equals(IPPublic.ToString()))
                {

                    MessageBox.Show(IPPublic);

                }

                numberURL = 0;
               
                loop_ViewLinkWithIP();
            }
        }
        private void ViewLinkDetail()
        {

            IReadOnlyCollection<IWebElement> elements = firefoxDrive.FindElements(By.XPath("//h3/a"));
            
            foreach (var item in elements)
            {
                //Doanh nghiệp xanh - Diễn đàn cộng đồng doanh nghiệp Việt Nam
                if (StripHTML(item.Text).Equals(objAdwordConfig.TextLink))
                {
                    isFindingURL = true;
                    System.Threading.Thread.Sleep(20000);
                    WriteLog(StripHTML(item.Text));
                    item.Click();

                    //Tim thay URL can view thi goi timer de click tren trang 
                    clickLinkTimer = new Timer();
                    clickLinkTimer.Interval = (1 * 20 * 1000);
                    clickLinkTimer.Tick += new EventHandler(clickLinkTimer_Tick);
                    clickLinkTimer.Start();
                    break;
                }

            }
            if (elements.Count > 0 && !isFindingURL)
            {
                page = page + 1;
                string googleUri = firefoxDrive.Url.ToString();
                int paraStart = 10 * page;
                //System.Threading.Thread.Sleep(10000);
                firefoxDrive.Navigate().GoToUrl(googleUri + "&start=" + paraStart.ToString());
            }
        }
        private void clickLinkTimer_Tick(object sender, EventArgs e)
        {
            //clickLinkTimer.Stop();
            Timer timer = (Timer)sender;
            timer.Stop();


            Random rd = new Random();
            try
            {
                if (countClickOnSite <= clickLimit)

                {

                    // GeckoElementCollection cv = geckoBrower.Document.GetElementsByTagName("a");

                    IReadOnlyCollection<IWebElement> elements = firefoxDrive.FindElements(By.XPath("//a"));


                    string[] arrInterval = objAdwordConfig.IntervalClick.Split(',');
                    int rdFrom = -1;
                    int rdTo = -1;
                    if (arrInterval.Length > 0)
                    {
                        rdFrom = int.Parse(arrInterval[0]);
                        rdTo = int.Parse(arrInterval[1]);
                    }
                    if (elements != null && elements.Count > 0)
                    {
                        int randomClick = rd.Next(0, elements.Count - 1);

                        if (!StripHTML(elements.ElementAt(randomClick).Text).Equals("Xem hướng nhà theo tuổi") &&
                            !String.IsNullOrEmpty(StripHTML(elements.ElementAt(randomClick).Text)) && elements.ElementAt(randomClick).GetAttribute("href") != null && elements.ElementAt(randomClick).GetAttribute("href").IndexOf("google.com") == -1)
                        {
                            string strHref = elements.ElementAt(randomClick).GetAttribute("href");
                            if (strHref.IndexOf("javascript") == -1 && strHref.IndexOf("facebook.com") == -1 && strHref.IndexOf("twitter") == -1 && strHref.IndexOf("maylammatvn.com") == -1
                                && strHref.IndexOf("plus.google.com") == -1 && strHref.IndexOf("quatlammatvn") == -1 && strHref.IndexOf("duongquoccuongbds.com") == -1 && strHref.IndexOf("http://diaocthanglong.net/bieumaubds.aspx")==-1
                                && strHref.IndexOf("http://sieuthinhadathaiphong.com/rss.aspx")==-1)
                            {
                                WriteLog(strHref+DateTime.Now.ToString("dd/MM/yyyy"));

                                elements.ElementAt(randomClick).Click();

                                // MessageBox.Show(countClickOnSite.ToString());
                                countClickOnSite = countClickOnSite + 1;
                            }


                        }


                    }
                    else
                    {
                        //MessageBox.Show("href : " + geckoBrower.Url.ToString());
                        firefoxDrive.Navigate().GoToUrl(objAdwordConfig.URL);
                        WriteLog("Khong co the a : " + firefoxDrive.Url.ToString());
                    }
                    timer.Interval = (1 * rd.Next(rdFrom, rdTo) * 1000);
                    timer.Start();
                }
                else
                {
                    // MessageBox.Show("Số lần click on site " + countClickOnSite.ToString());
                    viewNextURL();
                    ViewLink();

                }
            }
            catch
            {
                System.Threading.Thread.Sleep(60000);
                firefoxDrive.Navigate().GoToUrl(objAdwordConfig.URL);
            }

        }
        private void viewNextURL()
        {
            numberURL = numberURL + 1;
            countClickOnSite = 0;
            isFindingURL = false;
            page = 0;
            clickLimit = 0;
        }
        private void loop_ViewLinkWithIP()
        {
            numberURL = 0;
            countClickOnSite = 0;
            isFindingURL = false;
            page = 0;
            clickLimit = 0;
            ViewLink();
        }

    }

}

