using System;
using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;


namespace TPMI.Tests.UITests
{
    class TransferPage : BaseUIPage
    {
        public IWebElement legentransfer => WebDriver.FindByXpath("//legend[contains(text(),'Transfer Entry Profile')]");
    }
}

