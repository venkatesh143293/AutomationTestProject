using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;

namespace TPMI.Tests.UITests
{
    class SearchNotificationsPage : BaseUIPage
    {
       
        public IWebElement legendsearchnotificaions => WebDriver.FindByXpath("//div[@class='pnlPageTitleSearch']");
        public IWebElement btnSubmit2 => WebDriver.FindByXpath("//input[@id='ctl00_ctl00_MainContent_btnSubmit']");
    }
}
