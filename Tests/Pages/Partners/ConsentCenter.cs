using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;

namespace TPMI.Tests.UITests
{
    class ConsentCenterPage : BaseUIPage
    {
        public By legendConsentCenter => By.XPath("//h3[@id='partnerConsentHeader']");
    }
}
