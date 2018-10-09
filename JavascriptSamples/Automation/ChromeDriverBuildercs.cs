using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationFramework.Automation
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
