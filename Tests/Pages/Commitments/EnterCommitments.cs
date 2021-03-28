using System;
using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;


namespace TPMI.Tests.UITests
{
    class EnterCommitments : BaseUIPage
    {
        public IWebElement legendCommitmentsenrty = WebDriver.FindByXpath("//div[@class='legend-lg']");
    }
}

