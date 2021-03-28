using System;
using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;


namespace TPMI.Tests.UITests
{
    class ApproveCommitments : BaseUIPage
    {
        public IWebElement legendapproveCommitments1 = WebDriver.FindByXpath("//div[@class='pnlPageTitleSearch']");
    }
}

