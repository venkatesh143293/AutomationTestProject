using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;

namespace TPMI.Tests.UITests
{
    class ManageMessagesPage : BaseUIPage
    {
        public IWebElement legendMangemessages => WebDriver.FindByXpath("//div[@class='pnlPageTitleSearch']");
    }
}
