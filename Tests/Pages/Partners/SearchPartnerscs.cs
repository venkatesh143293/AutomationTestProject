using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;

namespace TPMI.Tests.UITests
{
    class SearchPartnerPage : BaseUIPage
    {
       public IWebElement legendSearchPartners => WebDriver.FindByXpath("//legend[contains(text(),'Search Partners')]");
        public IWebElement btnSubmit => WebDriver.FindByXpath("//button[@id='btnSubmit']");
    }
}
