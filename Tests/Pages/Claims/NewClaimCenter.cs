using System;
using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;


namespace TPMI.Tests.UITests
{
    class NewClaimCenter : BaseUIPage
    {
        public IWebElement TblClaimsCenter = WebDriver.FindByXpath("//div[@class='dataCenter-heading']");
    }
}

