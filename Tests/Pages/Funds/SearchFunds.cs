using System;
using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;


namespace TPMI.Tests.UITests
{
    class SearchFunds : BaseUIPage
    {
        public IWebElement legendSearchFunds => WebDriver.FindByXpath("//a[contains(text(),'Search Funds')]");
    }
}

