using System;
using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;


namespace TPMI.Tests.UITests
{
    class EnterClaims : BaseUIPage
    {
        public IWebElement TblenterClaims1 = WebDriver.FindByXpath("//div[@class='legend-lg']");
    }
}

