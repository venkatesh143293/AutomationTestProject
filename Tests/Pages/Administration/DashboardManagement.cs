using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;

namespace TPMI.Tests.UITests
{
    class DashboardManagementPage : BaseUIPage
    {
        public IWebElement legendDashboardmanagement => WebDriver.FindByXpath("//div[@class='pnlPageTitleSearch']");
    }
}
