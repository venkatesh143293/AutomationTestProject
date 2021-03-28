using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;

namespace TPMI.Tests.UITests
{
    class ExceptionCenterPage : BaseUIPage
    {
        public IWebElement legendexceptioncenter => WebDriver.FindByXpath("//legend[contains(text(),'Exception Center')]");
    }
}
