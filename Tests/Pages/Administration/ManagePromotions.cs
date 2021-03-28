using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;

namespace TPMI.Tests.UITests
{
    class ManagePromotionsPage : BaseUIPage
    {
        public IWebElement legendManagepromotions => WebDriver.FindByXpath("//thead//tr[@class='rgCommandRow']//div[1]");
    }
}
