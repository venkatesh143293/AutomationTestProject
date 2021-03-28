using System;
using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;


namespace TPMI.Tests.UITests
{
    class AdjustPage : BaseUIPage
    {
        public IWebElement legenAdjust => WebDriver.FindByXpath("//div[@class='pnlPageTitleSearch']");
    }
}

