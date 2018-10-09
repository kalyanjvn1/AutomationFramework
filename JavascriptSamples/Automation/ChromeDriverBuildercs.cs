using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavascriptSamples.Automation
{
    class ChromeDriverBuilders: IBrowserCapabilities
    {
        public IWebDriver SetupBrowserBuilder()
        {
           ChromeOptions options = new ChromeOptions();
            options.AddArgument("start - maximized");
            return new ChromeDriver(options);
        }
    }
}
