using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;

namespace TPMI.Tests.UITests
{
    class SearchManagementPage : BaseUIPage
    {
        public IWebElement legendSearchmngmt => WebDriver.FindByXpath("//legend[contains(text(),'Search Manager')]");
    }
}
