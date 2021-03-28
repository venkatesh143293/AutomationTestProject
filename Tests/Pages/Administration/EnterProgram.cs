using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;

namespace TPMI.Tests.UITests
{
    class EnterProgramPage : BaseUIPage
    {
        public IWebElement legendEnterprg => WebDriver.FindByXpath("//div[@class='pnlPageTitleSearch']");
    }
}