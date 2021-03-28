using System;
using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;


namespace TPMI.Tests.UITests
{
    class PublishApproval : BaseUIPage
    {
        public IWebElement hdPublishApproval => WebDriver.FindByXpath("//h3[@id='publishApprovalHeader']");
    }
}

