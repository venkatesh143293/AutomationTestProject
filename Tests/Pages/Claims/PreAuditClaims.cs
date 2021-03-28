using System;
using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;


namespace TPMI.Tests.UITests
{
    class PreAuditClaims : BaseUIPage
    {
        public IWebElement TblpreauditClaims1 = WebDriver.FindByXpath("//div[@class='pnlPageTitleSearch']");
    }
}

