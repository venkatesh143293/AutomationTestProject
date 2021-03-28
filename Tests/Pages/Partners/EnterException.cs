using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;

namespace TPMI.Tests.UITests
{
    class EnterExceptionPage : BaseUIPage
    {
        public IWebElement legendenterexception => WebDriver.FindByXpath("//div[@class='legend-lg']");
    }
}
