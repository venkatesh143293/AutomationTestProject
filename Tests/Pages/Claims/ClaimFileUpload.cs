using System;
using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;


namespace TPMI.Tests.UITests
{
    class ClaimFileUpload : BaseUIPage
    {
        public IWebElement Tblclaimfileupload1 = WebDriver.FindByXpath("//div[@class='dataCenter-heading']//div[contains(text(),'Claim File Upload')]");
    }
}

