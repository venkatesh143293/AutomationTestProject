using System;
using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;


namespace TPMI.Tests.UITests
{
    class PreAuditActivities : BaseUIPage
    {
        public IWebElement Tblpreauditsctivity1 = WebDriver.FindByXpath("//legend[contains(text(),'Pre-Audit Entry')]");
    }
}

