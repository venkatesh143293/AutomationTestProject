using System;
using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;


namespace TPMI.Tests.UITests
{
    class ResetQueue : BaseUIPage
    {
        public IWebElement hdResetQueue => WebDriver.FindByXpath("//h3[@id='resetHeader']");
    }
}

