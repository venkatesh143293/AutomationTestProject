using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;

namespace TPMI.Tests.UITests
{
    class SubmitMonitor : BaseUIPage
    {
        public IWebElement hdSubmitMonitor => WebDriver.FindByXpath("//h3[@id='monitorHeader']");
    }
}