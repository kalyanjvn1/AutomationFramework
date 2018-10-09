using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.Extensions;

namespace AutomationFramework.Automation
{
    public class AutomationBase : WebDriverFactory
    {
        public IWebDriver AutomationBaseInstance { get; set; }
                      
        [TestCleanup]
        public void TestTearDown()
        {
            TearDownWebDriver();
        }
        
        [TestInitialize]
        public void TestSetup()
        {
            Setup();
        }
        
        public void Setup()
        {
            AutomationBaseInstance = IntializeWebDriverProp;
            AutomationBaseInstance.Navigate().GoToUrl(LinkUri);
        }

        public void TakeScreenShots()
        {
            RemoteWebDriver automationBaseInstance =  AutomationBaseInstance as RemoteWebDriver;
            if(automationBaseInstance != null)
            {
                ITakesScreenshot screenshot = (ITakesScreenshot) AutomationBaseInstance.TakeScreenshot();
                
            }
        }       

    }
}
