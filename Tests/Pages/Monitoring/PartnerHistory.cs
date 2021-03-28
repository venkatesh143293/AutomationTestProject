using System;
using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;


namespace TPMI.Tests.UITests
{
    class PartnerHistory : BaseUIPage
    {
        public IWebElement hdPartnerHistory => WebDriver.FindByXpath("//h3[@id='partnerHistoryHeader']");
    }
}

