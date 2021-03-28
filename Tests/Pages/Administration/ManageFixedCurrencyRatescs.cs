using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;

namespace TPMI.Tests.UITests
{
    class ManageFixedCurrencyRatesPage : BaseUIPage
    {
        public IWebElement legendManagefxdcurrency => WebDriver.FindByXpath("//div[@class='pnlPageTitleSearch']");
    }
}