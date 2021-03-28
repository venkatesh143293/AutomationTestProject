using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using Ansira.Test.AutomationFramework.Helpers;
using NUnit.Framework;
using System.Threading;
using TPMI.Tests.BaseClasses;
using TPMI.Tests.Pages;

namespace TPMI.Tests.UITests
{
    [TestFixture]
    public class PlanCds : UIBaseTest
    {
        [Test]
        public void PlanCards1()
        {
            //Reading input data from Excel
            string fileName = CommonHelpers.GetPath() + "TestData\\Login.xlsx";
            ExcelHelpers.PopulateInCollection(fileName);



            // Enter userid and Password, Click Login
            Reporter.LogInfo("Login Page");

            LoginPage loginPage = new LoginPage();
            loginPage.Login(ExcelHelpers.ReadData(1, "UserName"), ExcelHelpers.ReadData(1, "Password"));
            Thread.Sleep(5000);

            //Application navigates to Client Page
            Reporter.LogInfo("Select Client Page ");

            ClientSelectPage clientSelectpage = new ClientSelectPage();
            clientSelectpage.ClientName("Red Hat");

            Thread.Sleep(5000);
            WebDriver.FindByXpath("//button[contains(text(),'Add New Plan')]").Click();
            Thread.Sleep(5000);
            //WebDriver.FindByXpath("//input[@id='txtName']").SetText("Test");
            //Consent Center
        }


    }
}
