using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;

namespace TPMI.Tests.UITests
{
    class GroupManagementPage : BaseUIPage
    {
        public IWebElement legendGroupmngmt => WebDriver.FindByXpath("//div[@class='pnlPageTitleSearch']");
        public IWebElement btnGroupSearch => WebDriver.FindByXpath("//input[@id='ctl00_ctl00_MainContent_btnSubmit']");
    }
}