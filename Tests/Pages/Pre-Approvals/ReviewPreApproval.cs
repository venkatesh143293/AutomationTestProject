using System;
using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;


namespace TPMI.Tests.UITests
{
    class ReviewPreApproval : BaseUIPage
    {
        public IWebElement legendreviewpreapprovals => WebDriver.FindByXpath("//legend[contains(text(),'Pre-Approval Review List')]");
    }
}

