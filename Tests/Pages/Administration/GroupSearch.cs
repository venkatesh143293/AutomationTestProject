using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;

namespace TPMI.Tests.UITests
{
    class GroupSearchPage : BaseUIPage
    {
        public IWebElement btnGroupSearchExportToExcel => WebDriver.FindByXpath("//a[contains(@id, 'MainContent_lbtnGoSearchFields')]");

    }
}
