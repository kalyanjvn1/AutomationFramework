using AutomationFramework.Automation;
using OpenQA.Selenium;

namespace AutomationFramework.Pages
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
