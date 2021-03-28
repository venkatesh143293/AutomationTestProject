using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using Ansira.Test.AutomationFramework.Helpers;
using NUnit.Framework;
using TPMI.Tests.BaseClasses;
using TPMI.Tests.Pages;

namespace TPMI.Tests.UITests

{
    [TestFixture]
    public class Login : UIBaseTest
    {
        [Test]
        public void LoginTest()
        {
            //Reading input data from Excel
            string fileName = CommonHelpers.GetPath() + "TestData\\Login.xlsx";
            ExcelHelpers.PopulateInCollection(fileName);



            // Enter userid and Password, Click Login
            Reporter.LogInfo("Login Page");

            LoginPage loginPage = new LoginPage();
            loginPage.Login(ExcelHelpers.ReadData(1, "UserName"),ExcelHelpers.ReadData(1, "Password"));

            //Application navigates to Client Page
            Reporter.LogInfo("Select Client Page ");

            ClientSelectPage clientSelectpage = new ClientSelectPage();
            WebDriver.ClickButton(clientSelectpage.linkClientName("[Ansira Test Client]"));
        }


    }
}
