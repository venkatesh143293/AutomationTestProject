using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;

namespace TPMI.Tests.UITests
{
    class ReviewExceptionsPage : BaseUIPage
    {
        public IWebElement legendreviewexception => WebDriver.FindByXpath("//legend[contains(text(),'Exception Center')]");
    }
}
