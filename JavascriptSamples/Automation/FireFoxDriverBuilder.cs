using System;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium;

namespace JavascriptSamples.Automation
{
    internal class FireFoxDriverBuilder: IBrowserCapabilities
    {
        public FireFoxDriverBuilder()
        {
        }

        public IWebDriver SetupBrowserBuilder()
        {
            throw new NotImplementedException();
        }
    }
}