using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Remote;

namespace JavascriptSamples.Automation
{
    public abstract class WebDriverFactory
    {
        private static IWebDriver driver;
        int _controlTimeOutInMs = 2000;
        int _pageTimeoutInMs = 4000;
        const string BrowserName = "Chrome";
        const PlatformType PlatformName = PlatformType.Windows;
        static TimeSpan WaitTimeDuration = TimeSpan.FromSeconds(30);

        //private Uri _uri = new Uri("http://www.google.com/");
        public virtual int ControlTimeOutInMs { get; set; } = 2000;
        public virtual int PageTimeOutInMs { get; set; } = 4000;

        public static Uri LinkUri { get; set; } = new Uri("http://www.google.com/");

        public static IWebDriver IntializeWebDriverProp
        {
            get
            {
                if (driver != null)
                {
                    return driver;
                }
                else
                {
                   return IntializeWebDriver();
                }
             }            
        }

        //Intialize webdriver as a singleton calls
        private static IWebDriver IntializeWebDriver()
        {
            if (driver == null)
            {
                driver.Manage().Cookies.DeleteAllCookies();            
                driver.Manage().Timeouts().ImplicitWait = WaitTimeDuration;
                driver.Manage().Timeouts().PageLoad = WaitTimeDuration;
                driver.Manage().Timeouts().AsynchronousJavaScript = WaitTimeDuration;
                driver = GetWebDriverWithDesiredCapabilities();               
            }
            return driver;
        }

        public static IWebDriver GetWebDriverWithDesiredCapabilities()
        {
            return new BrowserBuilderFactory().GetBrowserCapabilities(BrowserName);            
        }

        public void TearDownWebDriver()
        {
            if(driver!=null)
            {
                driver.Close();
                driver.Quit();
            }
        }      
             
    }
}
