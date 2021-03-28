using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;

namespace TPMI.Tests.UITests
{
    class ClientManagementPage : BaseUIPage
    {
        public IWebElement legendClientmanagement => WebDriver.FindByXpath("//div[contains(text(),'Client Profile')]");

        

    }
}
