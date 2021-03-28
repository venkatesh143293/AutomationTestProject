using System;
using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;


namespace TPMI.Tests.UITests
{
    class Offers : BaseUIPage
    {
        public IWebElement legendoffers => WebDriver.FindByXpath("//div[@class='legend-lg']");
    }
}

