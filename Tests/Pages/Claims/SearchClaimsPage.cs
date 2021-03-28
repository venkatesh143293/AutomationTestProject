using System;
using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;


namespace TPMI.Tests.UITests
{
    class SearchClaimsPage : BaseUIPage
    {
        public IWebElement legendSearchClaims1 = WebDriver.FindByXpath("//legend[contains(text(),'Search Claims')]");
    }
}

