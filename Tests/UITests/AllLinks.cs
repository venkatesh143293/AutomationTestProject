using System;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using Ansira.Test.AutomationFramework.Helpers;
using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using NUnit.Framework;
using OpenQA.Selenium;
using TPMI.Tests.BaseClasses;
using TPMI.Tests.Pages;
using System.Threading;

namespace TPMI.Tests.UITests

{
    [TestFixture]
    public class AllLinks : UIBaseTest
    {
        [Test]
        public void NavtoAllLinksInUserHomePage()
        {
            string navigateURL;
            //Login in to the application
            Reporter.LogInfo("Login Page ");
            LoginPage loginPage = new LoginPage();
            WebDriver.SetText(loginPage.txtUserName, "bhagyat");
            WebDriver.SetSecureText(loginPage.txtPassword, "test1234");
            WebDriver.ClickButton(loginPage.btnLogin);

            //Navigate to specific Client Page 
            Reporter.LogInfo("Select Client Page ");
            ClientSelectPage clientSelectPage = new ClientSelectPage();
            WebDriver.ClickButton(clientSelectPage.linkClientName("[Ansira DEMO]"));
            string currentUrl = WebDriver.Url.ToString();

            // Navigate to User Homepage
            Reporter.LogInfo("User Home Page ");
            UserHomePage userHomePage = new UserHomePage();

            // Read all the links 
            var links = WebDriver.FindElements(By.XPath("//*[@href]"));

            //Navigate to all the links on client Home page 
            //   Do not Navigate Logout or User Home page
            //   Click a URL
            //   Check errors on the page
            //   Navigate back to User Homepage
            //   Click the next and continue aboce steps
            Reporter.LogInfo("Navigating to all Links on Home Page ");
            for (int i = 0; i < links.Count; i++)
            {
                navigateURL = links[i].GetAttribute("href");
                // Do not Navigate Logout or User Home page
                if (navigateURL.Contains("https://")
                    && (navigateURL.Contains("Logout.aspx") == false)
                    && (navigateURL.Contains(currentUrl) == false))
                {
                    // /Navigate to a link on client Home page
                    WebDriver.Navigate().GoToUrl(navigateURL);
                    WebDriver.WaitForPageLoaded();
                    Thread.Sleep(TimeSpan.FromSeconds(1));

                    // Check for errors on the page
                    WebDriver.CheckErrorsOnPage();

                    // Navigate back to User Home page
                    WebDriver.Navigate().GoToUrl(currentUrl);
                    WebDriver.WaitForPageLoaded();
                    Thread.Sleep(TimeSpan.FromSeconds(1));

                    // Read all the links 
                    links = WebDriver.FindElements(By.XPath("//*[@href]"));
                }
            }
        }
    }
}

