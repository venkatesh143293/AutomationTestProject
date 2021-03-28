using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;

namespace TPMI.Tests.UITests
{
    class EnterFunds : BaseUIPage
    {
        public IWebElement lnkSearchFunds => WebDriver.FindByXpath("//a[contains(text(),'Search Funds')]");
    }
}