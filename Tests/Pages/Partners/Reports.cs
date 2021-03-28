using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;

namespace TPMI.Tests.UITests
{
    class ReportsPage : BaseUIPage
    {
        public IWebElement legendreports => WebDriver.FindByXpath("//div[@class='pnlPageTitleSearch']");
    }
}
