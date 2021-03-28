using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;

namespace TPMI.Tests.Pages
{
    class ReportsPage : BaseUIPage
    {

        public IWebElement lnkReports => WebDriver.FindByXpath("//a[contains(text(),'Reports')]");


    }
}
