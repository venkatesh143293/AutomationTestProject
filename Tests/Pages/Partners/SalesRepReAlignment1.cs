using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;

namespace TPMI.Tests.UITests
{
    class SalesRepReAlignmentPage : BaseUIPage
    {
        public IWebElement legendsalesreprealignment => WebDriver.FindByXpath("//div[@class='dataCenter-heading']");
    }
}
