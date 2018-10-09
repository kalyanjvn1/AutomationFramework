using OpenQA.Selenium;

namespace AutomationFramework.Automation
{
    public class PageObject : WebDriverFactory
    {
        public IWebDriver WebDriver { get; set; }
        public PageObject()
        {
            WebDriver = IntializeWebDriverProp;
        }               
    }
}
