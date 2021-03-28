using System;
using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;


namespace TPMI.Tests.UITests
{
    class PaymentCenter : BaseUIPage
    {
        public IWebElement Tblpaymentcenter1 => WebDriver.FindByXpath("//div[@class='pnlPageTitleSearch']");
    }
}

