using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;

namespace TPMI.Tests.UITests
{
    class EditPartnerSubGroupPage : BaseUIPage
    {
        public IWebElement legendeditPartnersubgroup => WebDriver.FindByXpath("//div[@class='Header1']");

    }
}
