using System;
using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;


namespace TPMI.Tests.UITests
{
    class EnterAccounts : BaseUIPage
    {
        public IWebElement legendEnterAccounts => WebDriver.FindByXpath("//div[@class='pnlPageTitleSearch']");
    }
}

