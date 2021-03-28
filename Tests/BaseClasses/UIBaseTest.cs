using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.Enums;
using Ansira.Test.AutomationFramework.ConfigParser;
using Ansira.Test.AutomationFramework.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TPMI.Tests.BaseClasses
{

    public class UIBaseTest : Driver
    {
        [OneTimeSetUp]
        public void Setup()
        {
            //Parse Configuration settings...
            InitializeSettings(EnvironmentType.Staging);

            //Set Browser Type...
            BrowserType = UIConfigSettings.BrowserType;

            Reporter.StartReport();

            //Init web driver... 
            InitBrowser();

            // DriverContext.Browser.GoToUrl(Configs.Settings.AUT);
            //Settings.ApplicationCon = Settings.ApplicationCon.DBConnect(Settings.AppConnectionString);
        }


        [SetUp]
        public void BeforeTest()
        {
            Reporter.NewTestCase(TestContext.CurrentContext.Test.Name, TestContext.CurrentContext.Test.FullName);
            NavigateSite();
            // Reporter.LogPass("Navigated to URL :" + ConfigSettings.AUT.ToString());
        }

        [TearDown]
        public void CleanUp()
        {
            //Closing the browser and reporter.
            WebDriver.Close();
            Reporter.LogInfo("Closed the browser !!!");
            Reporter.EndReport();
        }

    }
}
