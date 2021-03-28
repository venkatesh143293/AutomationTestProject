using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;

namespace TPMI.Tests.UITests
{
    class PartnerGroupManagementPage : BaseUIPage
    {
        public IWebElement legendPArtnergrpmnmgmt => WebDriver.FindByXpath("//div[@class='pnlPageTitleSearch']");
    }
}
