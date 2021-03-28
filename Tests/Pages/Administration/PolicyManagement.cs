using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;

namespace TPMI.Tests.UITests
{
    class PolicyManagementPage : BaseUIPage
    {
        public IWebElement legendPolicymngmt => WebDriver.FindByXpath("//div[@class='pnlPageTitleSearch']");
    }
}