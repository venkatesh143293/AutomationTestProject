using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;

namespace TPMI.Tests.UITests
{
    class ManageTermsandTranslationsPage : BaseUIPage
    {
        public IWebElement legendMngtersmntrans => WebDriver.FindByXpath("//div[@class='dataCenter-heading']");
    }
}