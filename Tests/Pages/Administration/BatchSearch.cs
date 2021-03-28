using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;

namespace TPMI.Tests.UITests
{
    class BatchSearchPage : BaseUIPage
    {
        public IWebElement legendBatchSearch => WebDriver.FindByXpath("//a[@id='ctl00_ctl00_MainContent_lbtnGoSearchFields']");
    }
}
