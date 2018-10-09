using AutomationFramework.Automation;
using AutomationFramework.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutomationFramework
{
    [TestClass]
    public class HomePageTests : AutomationBase
    {
       
        [TestMethod]
        public void Search()
        {
            string searchText = "iphone";
            HomePage homePage = new HomePage();
            homePage.SearchItems(searchText);
            homePage.SearchButton();
        }
        
        
       
    }
}
