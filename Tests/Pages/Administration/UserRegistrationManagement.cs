using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;

namespace TPMI.Tests.UITests
{
    class UserRegistrationManagementPage : BaseUIPage
    {
        public IWebElement legendUserregmnmgt => WebDriver.FindByXpath("//legend[contains(text(),'User Registration Manager')]");
    }
}