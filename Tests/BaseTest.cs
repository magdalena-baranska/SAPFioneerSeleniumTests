
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SAPFioneerSeleniumTests.Tests.Tests
{
    public class BaseTest
    {
        protected IWebDriver Driver;
        protected WebDriverWait Wait;
        

        [SetUp]
        public void SetUp()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            var homePage = new Pages.HomePage(Driver);
            homePage.NavigateToHomePage();

        }

        [TearDown]
        public void TearDown()
        {
            if (Driver != null)
            {
                Driver.Quit();
                Driver.Dispose();
            }
        }
    }
}
