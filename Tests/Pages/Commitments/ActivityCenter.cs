using System;
using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;


namespace TPMI.Tests.UITests
{
    class ActivityCenter : BaseUIPage
    {
        public IWebElement TblActivityCenter1 = WebDriver.FindByXpath("//div[@class='dataCenter-heading']");
    }
}

