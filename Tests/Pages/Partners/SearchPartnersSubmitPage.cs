using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;

namespace TPMI.Tests.UITests
{
    class SearchPartnersSubmitPage : BaseUIPage
    {
         public IWebElement btnExportToExcel => WebDriver.FindByXpath("//button[@id='btnExportToExcelTop']");

    }
}
