using System;
using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;


namespace TPMI.Tests.UITests
{
    class PreApprovalCenter : BaseUIPage
    {
        public IWebElement legendpreapprovalcenter1 => WebDriver.FindByXpath("//div[@class='dataCenter-heading']");
    }
}

