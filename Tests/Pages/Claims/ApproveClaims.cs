using System;
using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;


namespace TPMI.Tests.UITests
{
    class ApproveClaims : BaseUIPage
    {
        public IWebElement Tblapproveclaims1 = WebDriver.FindByXpath("//legend[contains(text(),'Approve Claims')]");
    }
}

