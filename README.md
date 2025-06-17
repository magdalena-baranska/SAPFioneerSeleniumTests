# Tests for SAP Fioneer webpage

## SAP Fioneer Selenium Tests

Repository: https://github.com/magdalena-baranska/SAPFioneerSeleniumTests
This repository contains automated tests for the SAP Fioneer webpage using Selenium.
Follow instructions in README

## Project Features 
- Automated tests for SAP Fioneer webpage
- Built with .NET 8 and NUnit
- Uses Selenium WebDriver
- Page Object Model (POM) structure
- Fully sequential execution (no parallelization)
- Validations for button color, redirection, and form error messages

### Local recommended tools:

- Visual Studio 2022
- Git
- .NET 8 SDK
- Chrome browser installed
- chromedriver installed

## Configuration
NuGet packages are managed via the `SAPFioneerSeleniumTests.csproj` file. The project uses the following packages:
- `NUnit`: For unit testing framework.
- `Selenium.WebDriver`: For browser automation.
- `Selenium.Support`: For additional Selenium support features.
- `Selenium.WebDriver.ChromeDriver`: For Chrome browser support.
- `NUnit3TestAdapter`: For integrating NUnit with Visual Studio's Test Explorer.
- `Microsoft.NET.Test.Sdk`: For running tests in Visual Studio.
	
No additional config is needed. Tests use ChromeDriver via Selenium's default behavior.
If you experience issues, ensure your Chrome is up-to-date and compatible with your local ChromeDriver version.

## Running Tests - Command Line
cd SAPFioneerSeleniumTests

dotnet restore

dotnet test

## Running Tests - Visual Studio

1. Open the solution file in Visual Studio.
2. Build the solution (Ctrl + Shift + B).
3. Open the Test Explorer (Test > Windows > Test Explorer).
4. Run all tests (click the Run All button in Test Explorer).
5. View test results in the Test Explorer window.
6. To run a specific test, right-click on the test in the Test Explorer and select "Run Selected Tests".

## License
This project is intended for learning and demonstration purposes only.
