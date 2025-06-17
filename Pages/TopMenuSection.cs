
using OpenQA.Selenium;

namespace SAPFioneerSeleniumTests.Pages
{
    public class TopMenuSection : BasePage
    {
        private readonly IWebDriver _driver;

        public TopMenuSection(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }


        private IWebElement FinanceAndEsgMenuButton => _driver.FindElement(By.LinkText("Finance & ESG"));

        public void SelectOptionFromFinanceAndEsgMenu(string optionText)
        {
            FinanceAndEsgMenuButton.Click();
            var option = _driver.FindElement(By.LinkText(optionText));
            option.Click();
        }
    }
}
