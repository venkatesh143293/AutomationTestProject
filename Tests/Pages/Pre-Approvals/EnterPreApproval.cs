using System;
using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;


namespace TPMI.Tests.UITests
{
    class EnterPreApproval : BaseUIPage
    {
        public IWebElement legendenterpreapprovals => WebDriver.FindByXpath("//div[@class='legend-lg']");
    }
}

