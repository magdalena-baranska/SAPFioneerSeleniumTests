using OpenQA.Selenium;

namespace SAPFioneerSeleniumTests.Pages
{
    public class ESGKPIEnginePage
    {

        private readonly IWebDriver _driver;
        private const string ESGKPIEnginePageUrl = "https://www.sapfioneer.com/finance-esg/esg-kpi-engine/";
        private const string ESGKPIEnginePageTitle = "Stay audit-ready with the ESG KPI Engine | SAP Fioneer";

        public ESGKPIEnginePage(IWebDriver driver)
        {
            _driver = driver;
        }
        public void NavigateToESGKPIEngine()
        {
            _driver.Navigate().GoToUrl(ESGKPIEnginePageUrl);
        }
        public string GetESGKPIEnginePageTitle() => ESGKPIEnginePageTitle;
        public string GetESGKPIEnginePageUrl() => ESGKPIEnginePageUrl;
    }
}
