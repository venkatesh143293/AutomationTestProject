
using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;

namespace TPMI.Tests.Pages
{
    class LoginPage : BaseUIPage
    {

        public By txtUserName = By.XPath("//*[contains(@id, 'txtUser')]"); 

        public By txtPassword = By.XPath("//*[contains(@id, 'txtPassword')]");


        public By btnLogin = By.XPath("//*[@class='btn btn-primary w-50']");

        public void Login(string userName, string password)
        {
            WebDriver.SetText(txtUserName, userName);
            WebDriver.SetSecureText(txtPassword, password);
            WebDriver.ClickButton(btnLogin);
        }
    }
}
