using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SAPFioneerSeleniumTests.Helpers;

namespace SAPFioneerSeleniumTests.Pages
{
    public class ContactUsPage : BasePage
    {
        private readonly IWebDriver _driver;
        private const string ContactUsPageUrl = "https://www.sapfioneer.com/contact/";
        private const string ContactUsPageTitle = "SAP Fioneer | Contact | Get in touch!";
        private const string InvalidEmailMessage = "Email must be formatted correctly.";
        public ContactUsPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        public string GetContactUsPageUrl() => ContactUsPageUrl;
        public string GetContactUsPageTitle() => ContactUsPageTitle;
        public string GetInvalidEmailMessage() => InvalidEmailMessage;

        private IWebElement FirstNameInput => _driver.FindElement(By.Name("firstname"));
        private IWebElement LastNameInput => _driver.FindElement(By.Name("lastname"));
        private IWebElement WorkEmailInput => _driver.FindElement(By.Name("email"));
        private IWebElement PhoneNumberInput => _driver.FindElement(By.Name("phone"));
        private IWebElement MessageInput => _driver.FindElement(By.Name("note"));
        private IWebElement SubmitButton => _driver.FindElement(By.CssSelector("input[type='submit']"));
        private IWebElement IncorrectEmailValidationMessage => _driver.FindElement(By.XPath("//input[@name='email']/ancestor::div[contains(@class, 'hs_email')]//label[@class='hs-error-msg hs-main-font-element']"));
        private IWebElement IFrameForm => _driver.FindElement(By.CssSelector("[title='Form 0']"));


        public void FillInContactForm(string firstName, string lastName, string workEmail, string phoneNumber, string message)
        {
            Wait.Until(d => _driver.FindElement(By.CssSelector("[title='Form 0']")) != null);
            _driver.SwitchTo().Frame(IFrameForm);
            Wait.Until(d => FirstNameInput.Displayed);
            FirstNameInput.SendKeys(firstName);
            LastNameInput.SendKeys(lastName);
            WorkEmailInput.SendKeys(workEmail);
            PhoneNumberInput.SendKeys(phoneNumber);
            MessageInput.SendKeys(message);
            _driver.SwitchTo().DefaultContent();
        }

        public string GetIncorrectEmailValidationMessage()
        {
            Wait.Until(d => _driver.FindElement(By.CssSelector("[title='Form 0']")) != null);
            _driver.SwitchTo().Frame(IFrameForm);
            Wait.Until(d => IncorrectEmailValidationMessage.Displayed);
            string validationMessage = IncorrectEmailValidationMessage.Text;
            _driver.SwitchTo().DefaultContent();
            return validationMessage;
            
        }
    }
}
