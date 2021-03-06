﻿using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace AutomationFramework.Automation
{
    public class BrowserBuilderFactory
    {
        public IWebDriver GetBrowserCapabilities(string browserName = null)
        {
            IWebDriver webDriver = null;
            if (string.IsNullOrWhiteSpace(browserName))
            {
                webDriver = new RemoteWebDriver(DesiredCapabilities.Chrome());
            }
            else if(browserName.Equals(BrowserType.Chrome))
            {
                webDriver = new ChromeDriverBuilders().SetupBrowserBuilder();
            }
            else if(browserName.Equals(BrowserType.FireFox))
            {
                webDriver = new FireFoxDriverBuilder().SetupBrowserBuilder();
            }
            return webDriver;
        }
        
    }
}
