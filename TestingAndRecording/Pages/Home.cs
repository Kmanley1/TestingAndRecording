
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
namespace Test
{
    public class Home
    {
        public Home()
        {
            driver = null;
        }
        public Home(IWebDriver webDriver)
        {
            driver = webDriver;
        }
        //Driver
        IWebDriver driver;
        //Locators
        [FindsBy(How = How.XPath, Using = "//ul[@class='top-menu notmobile']//a[@href='/computers']")]
        private IWebElement ComputersLink;
        //Actions
        public Home isAt()
        {
            Assert.IsTrue(driver.Title.Equals("nopCommerce demo store"));
            return this;
        }
        public Home GoToComputers()
        {
            ComputersLink.Click();
            return this;
        }
    }
}