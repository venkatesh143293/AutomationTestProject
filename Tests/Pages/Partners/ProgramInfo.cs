using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;

namespace TPMI.Tests.UITests
{
    class ProgramInfoPage : BaseUIPage
    {
        public IWebElement legendprograminfo => WebDriver.FindByXpath("//td[1]");
    }
}
