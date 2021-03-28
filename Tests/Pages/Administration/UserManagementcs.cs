using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;

namespace TPMI.Tests.UITests
{
    class UserManagementPage : BaseUIPage
    {
        public IWebElement legendUsermngmt => WebDriver.FindByXpath("//div[@class='pnlPageTitleSearch']");
        public IWebElement btnUserSearch => WebDriver.FindByXpath("//input[@id='ctl00_MainContent_btnUserSearch']");
        

    }
}