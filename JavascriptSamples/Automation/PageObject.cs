using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;


namespace JavascriptSamples.Automation
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
