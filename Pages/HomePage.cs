using OpenQA.Selenium;
using SAPFioneerSeleniumTests.Helpers;

namespace SAPFioneerSeleniumTests.Pages
{
    public class HomePage
    {
        private readonly IWebDriver _driver;
        private string expectedGetInTouchButtonColor = "#ffd43c"; // Expected color in HEX format

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        private IWebElement GetInTouchButton => _driver.FindElement(By.CssSelector("a[href='/contact/']"));
        public string ExpectedGetInTouchButtonColor => expectedGetInTouchButtonColor.ToUpper();

        public void NavigateToHomePage()
        {
            _driver.Navigate().GoToUrl("https://www.sapfioneer.com/");
        } 

        public void ClickGetInTouchButton()
        {
            GetInTouchButton.Click();
        }

        public string GetGetInTouchButtonColor()
        {
            var rgbColor = GetInTouchButton.GetCssValue("background-color");
            return ColorHelper.ConvertRgbToHex(rgbColor).ToUpper();
        }

        private string ConvertRgbToHex(string rgb)
        {
            // Usunięcie 'rgba(' lub 'rgb(' oraz nawiasów końcowych, podział na składowe
            var components = rgb.Replace("rgba(", "")
                                 .Replace("rgb(", "")
                                 .Replace(")", "")
                                 .Split(',');

            int r = int.Parse(components[0].Trim());
            int g = int.Parse(components[1].Trim());
            int b = int.Parse(components[2].Trim());

            // Konwersja do formatu HEX np. #FFCC00
            var hexColor = $"#{r:X2}{g:X2}{b:X2}";
            return hexColor;
        }

        public string GetInTouchButtonColorHex()
        {
            return GetGetInTouchButtonColor();
        }

       
    }
}
