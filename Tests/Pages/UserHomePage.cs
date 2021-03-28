
using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;

namespace TPMI.Tests.UITests
{
    class UserHomePage : BaseUIPage
    {

        public IWebElement lnkAllLinks => WebDriver.FindByXpath("//*[@href]");
        public IWebElement AllLinks() => lnkAllLinks;
    }
}
