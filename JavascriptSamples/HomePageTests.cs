using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JavascriptSamples.Automation;
using JavascriptSamples.Pages;

namespace JavascriptSamples
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
