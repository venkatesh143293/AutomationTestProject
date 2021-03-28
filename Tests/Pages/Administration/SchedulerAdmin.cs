using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;

namespace TPMI.Tests.UITests
{
    class SchedulerAdminPage : BaseUIPage
    {
        public IWebElement legendScheduleradmin => WebDriver.FindByXpath("//h3[@id='taskMaintenanceHeader']");
    }
}