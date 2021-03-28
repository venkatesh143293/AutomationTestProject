using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;

namespace TPMI.Tests.UITests
{
    class EditPartnerGroupPage : BaseUIPage
    {
        public IWebElement legendeditPartnergroup => WebDriver.FindByXpath("//div[@class='Header1']");

    }
}

