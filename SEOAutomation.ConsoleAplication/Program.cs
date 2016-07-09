using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System.Timers;
namespace SEOAutomation.ConsoleAplication
{
    class Program
    {
        static FirefoxDriver drive;
        static void Main(string[] args)
        {
        

            Console.WriteLine("Press \'q\' to quit the sample.");
            drive = new FirefoxDriver();

            drive.Navigate().GoToUrl("https://www.google.com.vn/?gws_rd=cr,ssl&ei=W59-V6j3Ksq80ATEwomADQ#q=sieu+thi+nha+dat+hai+phong");


            IReadOnlyCollection<IWebElement> elements = drive.FindElements(By.XPath("//h3/a"));
            foreach (var element in elements)
            {
                string abc = element.GetAttribute("href");
            }


            //System.Timers.Timer aTimer = new System.Timers.Timer();
            //aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            //aTimer.Interval = 15000;
            //aTimer.Enabled = true;
            //while (Console.Read() != 'q') ;


           
            // drive.Navigate().G
        }
        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        { 
            
        
            IReadOnlyCollection < IWebElement > elements= drive.FindElements(By.XPath("//a"));
            foreach (var element in elements)
            {
                string abc=element.GetAttribute("href");
            }
        }
    }
}
