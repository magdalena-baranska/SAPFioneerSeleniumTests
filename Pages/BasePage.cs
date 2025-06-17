using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPFioneerSeleniumTests.Pages
{
    public class BasePage
    {
        private readonly IWebDriver _driver;
        protected WebDriverWait Wait;

        public BasePage(IWebDriver driver)
        {
            _driver = driver ?? throw new ArgumentNullException(nameof(driver), "Driver cannot be null");
            Wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));

        }
        public string GetPageTitle()
        {
            return _driver.Title;
        }
        public bool IsPageLoaded()
        {
            return _driver.FindElement(By.TagName("h1")).Displayed;
        }
    }
}
