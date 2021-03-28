using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;

namespace TPMI.Tests.UITests
{
    class UserSearchPage : BaseUIPage
    {
        public IWebElement btnUserSearchExportToExcel => WebDriver.FindByXpath("//button[@id='ctl00_MainContent_btnExportToExcel']");

    }
}
