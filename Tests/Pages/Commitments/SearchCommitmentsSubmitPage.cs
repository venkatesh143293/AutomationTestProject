using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;


namespace TPMI.Tests.Pages.Commitments
{
    class SearchCommitmentsSubmitPage : BaseUIPage
    {
        public IWebElement legendSearchCommitments => WebDriver.FindByXpath("//legend[contains(text(),'Search Commitments')]");

        public IWebElement btnExportToExcel => WebDriver.FindByXpath("//button[@id='btnExportToExcelTop']");
    }
}
