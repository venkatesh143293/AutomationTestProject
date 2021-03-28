using System;
using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;


namespace TPMI.Tests.UITests
{
    class RegionPreview : BaseUIPage
    {
        public IWebElement hdRegionPreview => WebDriver.FindByXpath("//h3[@id='regionalPreviewHeader']");
    }
}

