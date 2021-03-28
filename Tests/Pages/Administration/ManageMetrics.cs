using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;

namespace TPMI.Tests.UITests
{
    class ManageMetricsPage : BaseUIPage
    {
        public IWebElement legendMangemetrics => WebDriver.FindByXpath("//div[@class='pnlPageTitleSearch']");
    }
}