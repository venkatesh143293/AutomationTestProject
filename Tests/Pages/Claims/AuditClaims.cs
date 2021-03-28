using System;
using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;


namespace TPMI.Tests.UITests
{
    class AuditClaims : BaseUIPage
    {
        public IWebElement TblauditClaims1 = WebDriver.FindByXpath("//div[@class='card-header']");
    }
}

