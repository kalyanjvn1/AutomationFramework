using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium;

namespace JavascriptSamples.Automation
{
    interface IBrowserCapabilities
    {
        IWebDriver SetupBrowserBuilder();
    }
}
