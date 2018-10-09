using JavascriptSamples.Automation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;

namespace JavascriptSamples.Pages
{
    public class HomePage : PageObject
    {
        private IWebElement SearchTextBox => WebDriver.FindElement(By.Id("twotabsearchtextbox"));
        private IWebElement SubmitButton => WebDriver.FindElement(By.CssSelector("[value='Go']"));
        private IWebElement SearchResultsText => WebDriver.FindElement(By.Id("s-result-count"));

        public void SearchItems(string searchItems)
        {
            this.WaitForCondition(() => SearchTextBox.Displayed, ControlTimeOutInMs);
            SearchTextBox.Clear();
            SearchTextBox.SendKeys(searchItems);
        }

        public void SearchButton()
        {
            SubmitButton.Click();
        }
    }
}
