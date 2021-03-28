using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;

namespace TPMI.Tests.UITests
{
    class EnterPartnerPage : BaseUIPage
    {
        public IWebElement legendenterPartners => WebDriver.FindByXpath("//div[@class='pnlPageTitleSearch']");

    }
}
