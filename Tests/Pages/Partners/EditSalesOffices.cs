using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;

namespace TPMI.Tests.UITests
{
    class EditSalesOfficesPage : BaseUIPage
    {
        public IWebElement legendeditSalesoffices => WebDriver.FindByXpath("//div[@class='Header1']");

    }
}
