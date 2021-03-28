
using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;

namespace TPMI.Tests.Pages
{
    class ClientSelectPage : BaseUIPage
    {
        public By linkClientName(string clientName) => By.XPath("//div[contains(text(),'" + clientName + "')]");

        //  public IWebElement ClientName() => linkClientName;
        public By ClientName(string clientName)
        {
            return By.XPath("//div[contains(text(),'" + clientName + "')]"); ;
        }
    }
}
