using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;

namespace TPMI.Tests.UITests
{
    class ManageBaselinesPage : BaseUIPage
    {
        public IWebElement legendManagebaselines => WebDriver.FindByXpath("//div[@class='pnlPageTitleSearch']");
    }
}
