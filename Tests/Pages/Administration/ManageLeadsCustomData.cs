using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;

namespace TPMI.Tests.UITests
{
    class ManageLeadsCustomDataPage : BaseUIPage
    {
        public IWebElement legendMngldscustomdata => WebDriver.FindByXpath("//h3[@class='pageHeader']");
    }
}