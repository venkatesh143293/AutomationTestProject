using System;
using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;


namespace TPMI.Tests.UITests
{
    class MonitoringCenter : BaseUIPage
    {
        public IWebElement hdMonitoringCenter => WebDriver.FindByXpath("//h3[contains(text(),'Monitoring')]");
    }
}

