using System;
using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;


namespace TPMI.Tests.UITests
{
    class AllocatePage : BaseUIPage
    {
        public IWebElement legendAllocation => WebDriver.FindByXpath("//div[@class='pnlPageTitleSearch']");
    }
}

