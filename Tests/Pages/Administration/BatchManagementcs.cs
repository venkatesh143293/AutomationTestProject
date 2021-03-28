using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;

namespace TPMI.Tests.UITests
{
    class BatchManagementPage : BaseUIPage
    {
        public IWebElement legendBatchmngmt => WebDriver.FindByXpath("//div[@class='pnlPageTitleSearch']");
        public IWebElement legendBatchsearch => WebDriver.FindByXpath("//input[@id='ctl00_ctl00_MainContent_btnSubmit']");

    }
}
