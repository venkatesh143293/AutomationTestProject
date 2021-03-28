using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;

namespace TPMI.Tests.UITests
{
    class MediaPage : BaseUIPage
    {
        public IWebElement legendMedia => WebDriver.FindByXpath("//div[contains(text(),'Media Profile')]");
    }
}
