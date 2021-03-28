using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;

namespace TPMI.Tests.UITests
{
    class LeadsCenter : BaseUIPage
    {
        public IWebElement legendleadcenter1 = WebDriver.FindByXpath("//h3[@class='pageHeader']");
    }
}