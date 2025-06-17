using SAPFioneerSeleniumTests.Pages;
using SAPFioneerSeleniumTests.Tests.Tests;

namespace SAPFioneerSeleniumTests.Tests
{
    [TestFixture]
    public class HomePageTests : BaseTest
    {
        private HomePage homePage;

        [SetUp]
        public void BeforeTests()
        {
            homePage = new HomePage(Driver);
            homePage.NavigateToHomePage();
        }

        [TearDown]
        public void AfterTests()
        {
            Driver.Quit();
        }

        [Test]
        public void Test_GetInTouchButtonColor_IsYellow()
        {
            var getInTouchButtonColor = homePage.GetGetInTouchButtonColor();
            var expectedColor = homePage.ExpectedGetInTouchButtonColor;
            Assert.That(getInTouchButtonColor, Is.EqualTo(expectedColor), "The 'Get in Touch' button color is not yellow.");
        }

        [Test]
        public void Test_NavigateToESGKPIEngine()
        {
            var esgKpiEnginePage = new ESGKPIEnginePage(Driver);
            var menu = new TopMenuSection(Driver);

            homePage.NavigateToHomePage();
            menu.SelectOptionFromFinanceAndEsgMenu("ESG KPI Engine");
            var currentUrl = Driver.Url;

            Assert.Multiple(() =>
            {
                Assert.That(currentUrl, Is.EqualTo(expected: esgKpiEnginePage.GetESGKPIEnginePageUrl()), "Navigation to ESG KPI Engine page failed.");
                Assert.That(Driver.Title, Is.EqualTo(expected: esgKpiEnginePage.GetESGKPIEnginePageTitle()), "Page title does not match expected title for ESG KPI Engine page.");
            });
        }

        [Test]
        public void Test_InvalidEmailValidation()
        {
            var contactUsPage = new ContactUsPage(Driver);

            homePage.NavigateToHomePage();
            homePage.ClickGetInTouchButton();

            var currentUrl = Driver.Url;

            Assert.Multiple(() =>
            {
                Assert.That(currentUrl, Is.EqualTo(expected: contactUsPage.GetContactUsPageUrl()), "Navigation to Contact Us page failed.");
                Assert.That(Driver.Title, Is.EqualTo(expected: contactUsPage.GetContactUsPageTitle()), "Page title does not match expected title for Contact Us page.");
            });

            contactUsPage.FillInContactForm("John", "Doe", "invalid-email","123456789", "This is a test message.");

            Assert.That(contactUsPage.GetIncorrectEmailValidationMessage(), Is.EqualTo(contactUsPage.GetInvalidEmailMessage()), "The incorrect email validation message is not displayed as expected.");
        }
    }
}