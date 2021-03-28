using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;

namespace TPMI.Tests.UITests
{
    class EditSalesGroupsPage : BaseUIPage
    {
        public IWebElement legendeditSalesgroup => WebDriver.FindByXpath("//div[@class='Header1']");

    }
}

