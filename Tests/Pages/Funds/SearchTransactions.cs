using System;
using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;


namespace TPMI.Tests.UITests
{
    class SearchTransactions : BaseUIPage
    {
        public IWebElement legendSearchTransactions => WebDriver.FindByXpath("//legend[contains(text(),'Search Transactions')]");
    }
}

