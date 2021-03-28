using System;
using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;


namespace TPMI.Tests.UITests
{
    class SearchAccounts : BaseUIPage
    {
        public IWebElement legendSearchAccounts1 = WebDriver.FindByXpath("//legend[contains(text(),'Search Accounts')]");
    }
}

