using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using Ansira.Test.AutomationFramework.Helpers;
using NUnit.Framework;
using System;
using System.Threading;
using TPMI.Tests.BaseClasses;
using TPMI.Tests.Pages;
using TPMI.Tests.Pages.Commitments;

namespace TPMI.Tests.UITests

{
    [TestFixture]
    public class SmokeTest : UIBaseTest
    {
        [Test]
        public void SmokeTests()
        {
            //Reading input data from Excel
            string fileName = CommonHelpers.GetPath() + "TestData\\Login.xlsx";
            ExcelHelpers.PopulateInCollection(fileName);

            // Enter userid and Password, Click Login
            Reporter.LogInfo("Login Page");

            LoginPage loginPage = new LoginPage();
            loginPage.Login(ExcelHelpers.ReadData(1, "UserName"), ExcelHelpers.ReadData(1, "Password"));


            WebDriver.WaitForPageLoaded();
            //Thread.Sleep(4000);
           //Application navigates to Client Page
            Reporter.LogInfo("Select Client Page ");
            ClientSelectPage clientSelectpage = new ClientSelectPage();
            WebDriver.ClickButton(clientSelectpage.linkClientName("[Ansira Test Client]"));
            UserHomePage ansira = new UserHomePage();

            // ansira.lnkAnsiraDemo1.Click();            
            string urlName = WebDriver.Url;
            TextCompareHelper.VerifyTextContains("Ansira Demo page URL is ", urlName, "/home/UserHome.aspx");
            
            //Verifying Partners/Concent Center Page
            NavigationPage navigationPage = new NavigationPage();
            WebDriver.Hover(navigationPage.lnkPartners);
            WebDriver.ClickButton(navigationPage.lnkConsentCenter);
            WebDriver.WaitForPageLoaded();
            WebDriver.CheckErrorsOnPage();
            ConsentCenterPage consentCenterPage = new ConsentCenterPage();
            WebDriver.VerifyText(consentCenterPage.legendConsentCenter,"Consent Center", "Consent Center");

            ////Verifying Partners/Search Partners Page
            navigationPage = new NavigationPage();
            WebDriver.Hover(navigationPage.lnkPartners);
            //navigationPage.lnkSearchPartners.Click();
            //SearchPartnerPage searchPartnerPage = new SearchPartnerPage();
            //searchPartnerPage.legendSearchPartners.VerifyText("Search Partners", "Search Partners");
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();
            //searchPartnerPage.btnSubmit.Click();
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();
            //SearchPartnersSubmitPage searchPartnersSubmitPage = new SearchPartnersSubmitPage();
            //searchPartnersSubmitPage.btnExportToExcel.VerifyText("Export to Excel", "Export To Excel");

            ////Verifying Partners/Enter Partner Page
            //navigationPage = new NavigationPage();
            //navigationPage.lnkPartners.Hover("Partners");            
            //navigationPage.lnkenterPartners.Click();
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();
            //EnterPartnerPage enterPartnerPage = new EnterPartnerPage();
            //enterPartnerPage.legendenterPartners.VerifyText("Partner Profile", "Partner Profile");


            ////Verifying Partners/Edit Partner Group Page
            //navigationPage = new NavigationPage();
            //navigationPage.lnkPartners.Hover("Partners");
            //navigationPage.lnkeditPartnerGroup.Click();
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();
            //EditPartnerGroupPage editPartnerGroupPage = new EditPartnerGroupPage();
            //editPartnerGroupPage.legendeditPartnergroup.VerifyText("Partner Groups", "Partner Groups");


            ////Verifying Partners/Partner Sub Group PAge
            //navigationPage = new NavigationPage();
            //navigationPage.lnkPartners.Hover("Partners");            
            //navigationPage.lnkeditPartnersubgroup.Click();
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();
            //EditPartnerSubGroupPage editPartnerSubGroupPage = new EditPartnerSubGroupPage();
            //editPartnerSubGroupPage.legendeditPartnersubgroup.VerifyText("Partner Sub Groups", "Partner Sub Groups");

            ////Partners/Edit Sales Group Page
            //navigationPage = new NavigationPage();
            //navigationPage.lnkPartners.Hover("Partners");
            //navigationPage.lnkeditSalesgroup.Click();
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();
            //EditSalesGroupsPage editSalesGroupsPage = new EditSalesGroupsPage();
            //editSalesGroupsPage.legendeditSalesgroup.VerifyText("Sales Groups", "Sales Groups");

            ////Verifying Partners/Edit Sales Offices Page
            //navigationPage = new NavigationPage();
            //navigationPage.lnkPartners.Hover("Partners");
            //navigationPage.lnkeditSalesoffices.Click();
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();
            //EditSalesOfficesPage editSalesOfficesPage = new EditSalesOfficesPage();
            //editSalesOfficesPage.legendeditSalesoffices.VerifyText("Sales Offices", "Sales Offices");


            ////Verifying Partners/Exception Center Page
            //navigationPage = new NavigationPage();
            //navigationPage.lnkPartners.Hover("Partners");
            //navigationPage.lnkexceptioncenter.Click();
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();
            //ExceptionCenterPage exceptionCenterPage = new ExceptionCenterPage();
            //exceptionCenterPage.legendexceptioncenter.VerifyText("Exception Center", "Exception Center");

            ////Verifying Partners/Enter Exception Page
            //navigationPage = new NavigationPage();
            //navigationPage.lnkPartners.Hover("Partners");
            //navigationPage.lnkenterexception.Click();
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();
            //EnterExceptionPage enterExceptionPage = new EnterExceptionPage();
            //enterExceptionPage.legendenterexception.VerifyText("STAGE - Exception Profile", "STAGE - Exception Profile");

            ////Verifying Partners/Review Exception Page
            //navigationPage = new NavigationPage();
            //navigationPage.lnkPartners.Hover("Partners");
            //navigationPage.lnkreviewexception.Click();
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();
            //ReviewExceptionsPage reviewExceptionsPage = new ReviewExceptionsPage();
            //reviewExceptionsPage.legendreviewexception.VerifyText("Exception Center", "Exception Center");


            ////Partners/Salesrep ReAlignment
            //navigationPage = new NavigationPage();
            //navigationPage.lnkPartners.Hover("Partners");
            //navigationPage.lnksalesreprealignment.Click();
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();
            //SalesRepReAlignmentPage salesRepReAlignmentPage = new SalesRepReAlignmentPage();
            //salesRepReAlignmentPage.legendsalesreprealignment.VerifyText("Sales Rep Realignment", "Sales Rep Realignment");


            ////Verifying Program Info Page
            //navigationPage = new NavigationPage();
            //navigationPage.lnkprograminfo.Click();
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();
            //ProgramInfoPage programInfoPage = new ProgramInfoPage();
            //TextCompareHelper.VerifyTextContains("Header - Program Info", programInfoPage.legendprograminfo.GetText(), "Test Client Program");


            ////Verifying Reports Page
            //navigationPage = new NavigationPage();
            //navigationPage.lnkReports.Click();
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();
            //ReportsPage reportsPage = new ReportsPage();
            //reportsPage.legendreports.VerifyText("Reports Menu", "Reports Menu");


            ////Administration/search notifications          
            //navigationPage = new NavigationPage();
            //navigationPage.lnkAdministration.Hover("Administration");
            //navigationPage.lnksearchnotifications.Click();           
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();         
            //SearchNotificationsPage searchNotificationsPage = new SearchNotificationsPage();
            //searchNotificationsPage.btnSubmit2.Click();
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();
            //searchNotificationsPage.legendsearchnotificaions.VerifyText("Notification Search", "Notification Search");

            ////Administration /Cleint Managemeent
            //navigationPage = new NavigationPage();
            //navigationPage.lnkAdministration.Hover("Administration");
            //navigationPage.lnkClientmanagement.Click();
            //WebDriver.WaitForPageLoaded();
            //Thread.Sleep(1000);
            //WebDriver.CheckErrorsOnPage();
            //ClientManagementPage clientManagementPage = new ClientManagementPage();
            //TextCompareHelper.VerifyTextContains("Header - Client Profile", clientManagementPage.legendClientmanagement.GetText(), "Client Profile");



            ////Administration /Dashboard Managemeent
            //navigationPage = new NavigationPage();
            //navigationPage.lnkAdministration.Hover("Administration");
            //navigationPage.lnkDashboardmanagement.Click();
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();
            //DashboardManagementPage dashboardManagementPage = new DashboardManagementPage();
            //dashboardManagementPage.legendDashboardmanagement.VerifyText("Dashboard Manager", "Dashboard Manager");

            ////Administration /Partner Group Managemeent
            //navigationPage = new NavigationPage();
            //navigationPage.lnkAdministration.Hover("Administration");
            //navigationPage.lnkPartnergrpmngmt.Click();
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();
            //PartnerGroupManagementPage partnerGroupManagementPage = new PartnerGroupManagementPage();
            //partnerGroupManagementPage.legendPArtnergrpmnmgmt.VerifyText("Partner Group Manager", "Partner Group Manager");


            ////Administration /Search Managemeent
            //navigationPage = new NavigationPage();
            //navigationPage.lnkAdministration.Hover("Administration");
            //navigationPage.lnkSearchmngmt.Click();
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();
            //SearchManagementPage searchManagementPage = new SearchManagementPage();
            //searchManagementPage.legendSearchmngmt.VerifyText("Search Manager", "Search Manager");

            ////Administration /Enter Program
            //navigationPage = new NavigationPage();
            //navigationPage.lnkAdministration.Hover("Administration");
            //navigationPage.lnkEnterprgm.Click();
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();
            //EnterProgramPage enterProgramPage = new EnterProgramPage();
            //enterProgramPage.legendEnterprg.VerifyText("Program Profile", "Program Profile");

            ////Administration /Batch Managemeent            
            //navigationPage = new NavigationPage();
            //navigationPage.lnkAdministration.Hover("Administration");
            //navigationPage.lnkBatchmngmt.Click();
            //BatchManagementPage batchManagementPage = new BatchManagementPage();
            //batchManagementPage.legendBatchmngmt.VerifyText("Batch Search", "Batch Search");
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();
            //batchManagementPage.legendBatchsearch.Click();
            //BatchSearchPage batchSearchPage = new BatchSearchPage();
            //batchSearchPage.legendBatchSearch.VerifyText("Return to Search Fields", "Return to Search Fields");

            ////Administration /Policy Managemeent
            //navigationPage = new NavigationPage();
            //navigationPage.lnkAdministration.Hover("Administration");
            //navigationPage.lnkPolicymngmt.Click();
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();
            //PolicyManagementPage policyManagementPage = new PolicyManagementPage();
            //policyManagementPage.legendPolicymngmt.VerifyText("Policy Profile", "Policy Profile");

            ////Administration /Manage metrics
            //navigationPage = new NavigationPage();
            //navigationPage.lnkAdministration.Hover("Administration");
            //navigationPage.lnkManagemetrics.Click();
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();
            //ManageMetricsPage manageMetricsPage = new ManageMetricsPage();
            //manageMetricsPage.legendMangemetrics.VerifyText("Manage Metrics", "Manage Metrics");

            ////Administration /Manage messages            
            //navigationPage = new NavigationPage();
            //navigationPage.lnkAdministration.Hover("Administration");
            //navigationPage.lnkManagemessages.Click();
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();
            //ManageMessagesPage manageMessagesPage = new ManageMessagesPage();
            //manageMessagesPage.legendMangemessages.VerifyText("Message Board Profile", "Message Board Profile");

            ////Administration /Manage Promotions            
            //navigationPage = new NavigationPage();
            //navigationPage.lnkAdministration.Hover("Administration");
            //navigationPage.lnkManagepromotionss.Click();
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();
            //ManagePromotionsPage managePromotionsPage = new ManagePromotionsPage();
            //TextCompareHelper.VerifyTextContains("Header - Manage Promotions", managePromotionsPage.legendManagepromotions.GetText(), "Add New Promotion");

            ////Administration /Media
            //navigationPage = new NavigationPage();
            //navigationPage.lnkAdministration.Hover("Administration");
            //navigationPage.lnkMedia.Click();
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();
            //MediaPage mediaPage = new MediaPage();
            //mediaPage.legendMedia.VerifyText("Media Profile", "Media Profile");

            ////Administration /Manage Baselines
            //navigationPage = new NavigationPage();
            //navigationPage.lnkAdministration.Hover("Administration");
            //navigationPage.lnkManagebaselines.Click();
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();
            //ManageBaselinesPage manageBaselinesPage = new ManageBaselinesPage();
            //manageBaselinesPage.legendManagebaselines.VerifyText("Manage Baselines", "Manage Baselines");

            ////Administration /User registration
            //navigationPage = new NavigationPage();
            //navigationPage.lnkAdministration.Hover("Administration");
            //navigationPage.lnkUserregmnmgmt.Click();
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();
            //UserRegistrationManagementPage userRegistrationManagementPage = new UserRegistrationManagementPage();
            //userRegistrationManagementPage.legendUserregmnmgt.VerifyText("User Registration Manager", "User Registration Manager");

            ////Administration /Manage Fixed Currency Rates
            //navigationPage = new NavigationPage();
            //navigationPage.lnkAdministration.Hover("Administration");
            //navigationPage.lnkManagefxdcurrency.Click();
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();
            //ManageFixedCurrencyRatesPage manageFixedCurrencyRatesPage = new ManageFixedCurrencyRatesPage();
            //manageFixedCurrencyRatesPage.legendManagefxdcurrency.VerifyText("Fixede Currency Rates", "Fixed Currency Rates");

            ////Administration /User Management
            //navigationPage = new NavigationPage();
            //navigationPage.lnkAdministration.Hover("Administration");
            //navigationPage.lnkUsermngmt.Click();
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();
            //UserManagementPage userManagementPage = new UserManagementPage();
            //userManagementPage.legendUsermngmt.VerifyText("User Search", "User Search");
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();
            //userManagementPage.btnUserSearch.Click();
            //UserSearchPage userSearchPage = new UserSearchPage();
            //userSearchPage.btnUserSearchExportToExcel.VerifyText("Export to Excel", "Export To Excel");


            ////Administration /Group Management
            //navigationPage = new NavigationPage();
            //navigationPage.lnkAdministration.Hover("Administration");
            //navigationPage.lnkGroupmngmt.Click();
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();
            //GroupManagementPage groupManagementPage = new GroupManagementPage();
            //groupManagementPage.legendGroupmngmt.VerifyText("Group Search", "Group Search");
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();
            //groupManagementPage.btnGroupSearch.Click();
            //GroupSearchPage groupSearchPage = new GroupSearchPage();
            //groupSearchPage.btnGroupSearchExportToExcel.VerifyText("Group Search", "Return to Search Fields");

            ////Administration /Manage Terms and Translations
            //navigationPage.lnkAdministration.Hover("Administration");
            //navigationPage.lnkMngtersmntrans.Click();
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();
            //ManageTermsandTranslationsPage manageTermsandTranslationsPage = new ManageTermsandTranslationsPage();
            //manageTermsandTranslationsPage.legendMngtersmntrans.VerifyText("Phrase Management", "Phrase Management");

            ////Administration /Leads and Custom Data 
            //navigationPage.lnkAdministration.Hover("Administration");
            //navigationPage.lnkMngldscustomdata.Click();
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();
            //ManageLeadsCustomDataPage manageLeadsCustomDataPage = new ManageLeadsCustomDataPage();
            //manageLeadsCustomDataPage.legendMngldscustomdata.VerifyText("Program Leads Custom Data Profile", "Program Leads Custom Data Profile");

            ////Administration /Scheduler Admin 
            //navigationPage.lnkAdministration.Hover("Administration");
            //navigationPage.lnkScheduleradmin.Click();
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();
            //SchedulerAdminPage schedulerAdminPage = new SchedulerAdminPage();
            //schedulerAdminPage.legendScheduleradmin.VerifyText("Scheduler Admin", "Scheduler Admin");


            ////Navigating to Search Funds Page
            //navigationPage = new NavigationPage();
            //navigationPage.lnkFunds.Hover("Funds");
            //navigationPage.lnkSearchFunds.Click();
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();


            ////Verifying Search Funds Page
            ////SearchFunds searchFunds = new SearchFunds();
            ////searchFunds.legendSearchFunds.VerifyText("Fund Search", "Fund Search");

            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();

            ////Navigating to Enter Funds Page

            //navigationPage.lnkFunds.Hover("Funds");
            //navigationPage.lnkEnterFunds.Click();
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();

            ////Navigating to Search Account Funds Page

            //navigationPage.lnkFunds.Hover("Funds");
            //navigationPage.lnksearchAccounts.Click();
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();

            ////Verifying Search Account Page
            //SearchAccounts searchAccounts = new SearchAccounts();
            //searchAccounts.legendSearchAccounts1.VerifyText("Search Accounts", "Search Accounts");

            ////Navigating to Enter Account Funds Page

            //navigationPage.lnkFunds.Hover("Funds");
            //navigationPage.lnkEnterAccounts.Click();
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();

            ////Verifying Enter Account Page
            //EnterAccounts enterAccounts = new EnterAccounts();
            //enterAccounts.legendEnterAccounts.VerifyText("Account Profile", "Account Profile");

            ////Navigating to Search Transaction Funds Page

            //navigationPage.lnkFunds.Hover("Funds");
            //navigationPage.lnkSearchTransactions.Click();
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();

            ////Verifying  Search Transaction Page
            //SearchTransactions searchTransactions = new SearchTransactions();
            //searchTransactions.legendSearchTransactions.VerifyText("Search Transactions", "Search Transactions");

            ////Navigating to Allocate Funds Page

            //navigationPage.lnkFunds.Hover("Funds");
            //navigationPage.lnkAllocate.Click();
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();
            ////Verifying  Allocate Funds Page
            //AllocatePage allocatePage = new AllocatePage();
            //allocatePage.legendAllocation.VerifyText("Allocation Profile", "Allocation Profile");

            ////Navigating to Adjust Funds Page

            //navigationPage.lnkFunds.Hover("Funds");
            //navigationPage.lnkAdjust.Click();
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();
            ////Verifying  Adjust Funds Page
            //AdjustPage adjustPage = new AdjustPage();
            //adjustPage.legenAdjust.VerifyText("Adjustment Profile", "Adjustment Profile");

            ////Navigating to Transfer Funds Page

            //navigationPage.lnkFunds.Hover("Funds");
            //navigationPage.lnkTransfer.Click();
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();
            ////Verifying  Transfer Funds Page
            //TransferPage transferPage = new TransferPage();
            //transferPage.legentransfer.VerifyText("Transfer Entry Profile", "Transfer Entry Profile");

            ////Navigating to Offers Funds Page

            //navigationPage.lnkFunds.Hover("Funds");
            //navigationPage.lnkOffer.Click();
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();
            ////Verifying  Offers Funds Page
            //Offers offers = new Offers();
            //offers.legendoffers.VerifyText("Offers", "Offers");

            ////Commiments
            ////Navigating to ActivityCenter  Page
            //navigationPage.lnkCommitmets.Hover("Commitments");
            //navigationPage.lnkActivityCenter.Click();
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();

            ////Verifying ActivityCenter Page
            //ActivityCenter activityCenter = new ActivityCenter();
            //activityCenter.TblActivityCenter1.VerifyText("Activity Center", "Activity Center");



            ////Navigating to Search Commitments Page

            //navigationPage.lnkCommitmets.Hover("Commitments");
            //navigationPage.lnkSearchCommitmnets.Click();
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();

            ////Verifying Search Commitments Page
            //SearchCommitmentsPage searchCommitmentsPage = new SearchCommitmentsPage();
            //searchCommitmentsPage.legendSearchCommitments.VerifyText("Search Commitments", "Search Commitments");
            //searchCommitmentsPage.btnSubmit.Click();
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();

            ////Verfying  Search Commitments Search Page
            //SearchCommitmentsSubmitPage searchCommitmentsSubmitPage = new SearchCommitmentsSubmitPage();
            //searchCommitmentsSubmitPage.btnExportToExcel.VerifyText("Export to Excel", "Export To Excel");

            ////Navigating to Enter Commititments  Page
            //navigationPage.lnkCommitmets.Hover("Commitments");
            //navigationPage.lnkenterCommitmnets.Click();
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();

            ////Verifying Enter Commititments Page
            //EnterCommitments enterCommitments = new EnterCommitments();
            //enterCommitments.legendCommitmentsenrty.VerifyText("Commitment Entry Profile", "Commitment Entry Profile");


            ////Navigating to Approve Commititments  Page
            //navigationPage.lnkCommitmets.Hover("Commitments");
            //navigationPage.lnkapproveCommitmnets.Click();
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();

            ////Verifying Approve Commititments Page
            //ApproveCommitments approveCommitments = new ApproveCommitments();
            //approveCommitments.legendapproveCommitments1.VerifyText("Commitment List", "Commitment List");


            ////Navigating to Lead Center  Page
            //navigationPage.lnkCommitmets.Hover("Commitments");
            //navigationPage.lnkleadcenter.Click();
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();

            ////Verifying Lead Centers Page
            //LeadsCenter leadsCenter = new LeadsCenter();
            //leadsCenter.legendleadcenter1.VerifyText("Leads Center", "Leads Center");


            //Reporter.Flush();
            //Thread.Sleep(10000);

            ////Claims
            ////Navigate to  Claims Center Page


            //navigationPage.lnkClaims.Hover("Claims");
            //navigationPage.lnkClaimCenter.Click();
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();
            ////Verifying  ClaimsCenter Page
            //NewClaimCenter newClaimCenter = new NewClaimCenter();
            //newClaimCenter.TblClaimsCenter.VerifyText("Claim Center", "Claim Center");

            //// Navigate to Search Claims page
            //navigationPage = new NavigationPage();
            //navigationPage.lnkClaims.Hover("Claims");
            //navigationPage.lnkSearchClaims.Click();
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();


            //// Verify Search Claims Page
            //SearchClaimsPage searchClaimsPage = new SearchClaimsPage();
            //searchClaimsPage.legendSearchClaims1.VerifyText("Search Claims", "Search Claims");


            //// Navigate to Enter Claims page
            //navigationPage = new NavigationPage();
            //navigationPage.lnkClaims.Hover("Claims");
            //navigationPage.lnkenterClaim.Click();
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();


            //// Verify Enter Claims Page
            //EnterClaims enterClaims = new EnterClaims();
            //enterClaims.TblenterClaims1.VerifyText("Claim Entry Profile", "Claim Entry Profile");

            //// Navigate to Pre-Audit Claims page
            //navigationPage = new NavigationPage();
            //navigationPage.lnkClaims.Hover("Claims");
            //navigationPage.lnkpreautidtClaim.Click();
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();


            //// Verify PreAudit Claims Page
            //PreAuditClaims preAuditClaims = new PreAuditClaims();
            //preAuditClaims.TblpreauditClaims1.VerifyText("Claim Pre-Audit Profile", "Claim Pre-Audit Profile");

            //// Navigate to Pre-Audit Activities page
            //navigationPage = new NavigationPage();
            //navigationPage.lnkClaims.Hover("Claims");
            //navigationPage.lnkpreautidtactivity.Click();
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();


            //// Verify Pre-Audit Activities Page
            //PreAuditActivities preAuditActivities = new PreAuditActivities();
            //preAuditActivities.Tblpreauditsctivity1.VerifyText("Pre-Audit Entry", "Pre-Audit Entry");

            //// Navigate to Audit Claims page
            //navigationPage = new NavigationPage();
            //navigationPage.lnkClaims.Hover("Claims");
            //navigationPage.lnkauditclaims.Click();
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();


            //// Verify Audit Claims Page
            //AuditClaims auditClaims = new AuditClaims();
            //auditClaims.TblauditClaims1.VerifyText("Search Claims", "Search Claims");

            //// Navigate to Payment Center page
            //navigationPage = new NavigationPage();
            //navigationPage.lnkClaims.Hover("Claims");
            //navigationPage.lnkpaymentcenter.Click();
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();


            //// Verify  Payment Center Page
            //PaymentCenter paymentCenter = new PaymentCenter();
            //paymentCenter.Tblpaymentcenter1.VerifyText("Search Claims", "Search Claims");

            //// Navigate to Process Claims page
            //navigationPage = new NavigationPage();
            //navigationPage.lnkClaims.Hover("Claims");
            //navigationPage.lnkprocessclaims.Click();
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();


            //// Verify Process Claims Page
            //ProcessClaimsPage processClaimsPage = new ProcessClaimsPage();
            //processClaimsPage.Tblprocessclaims1.VerifyText("Search Claims", "Search Claims");

            //// Navigate to Approve Claims page
            //navigationPage = new NavigationPage();
            //navigationPage.lnkClaims.Hover("Claims");
            //navigationPage.lnkapproveclaims.Click();
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();


            //// Verify Approve Claims Page
            //ApproveClaims approveClaims = new ApproveClaims();
            //approveClaims.Tblapproveclaims1.VerifyText("Search Claims", "Search Claims");

            //// Navigate to Claim File upload page
            //navigationPage = new NavigationPage();
            //navigationPage.lnkClaims.Hover("Claims");
            //navigationPage.lnkclaimfileupload.Click();
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();


            //// Verify Claim File upload Page
            //ClaimFileUpload claimFileUpload = new ClaimFileUpload();
            //claimFileUpload.Tblclaimfileupload1.VerifyText("Search Claims", "Search Claims");

            ////Pre-Approvals
            //// Navigate to Pre approval Center page
            //navigationPage = new NavigationPage();
            //navigationPage.lnkPreapprovals.Hover("Pre-Approvals");
            //navigationPage.lnkPreapprovalcenter.Click();
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();


            //// Verify Pre approval Center Page
            //PreApprovalCenter preApprovalCenter = new PreApprovalCenter();
            //preApprovalCenter.legendpreapprovalcenter1.VerifyText("Search Claims", "Search Claims");

            //// Navigate to Enter Pre-Pre approval page
            //navigationPage = new NavigationPage();
            //navigationPage.lnkPreapprovals.Hover("Pre-Approvals");
            //navigationPage.lnkenterpreapprovals.Click();
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();


            //// Verify Enter Pre-Pre approval Page
            //EnterPreApproval enterPreApproval = new EnterPreApproval();
            //enterPreApproval.legendenterpreapprovals.VerifyText("Search Claims", "Search Claims");

            //// Navigate to Review Pre-Pre approval page
            //navigationPage = new NavigationPage();
            //navigationPage.lnkPreapprovals.Hover("Pre-Approvals");
            //navigationPage.lnkreviewpreapprovals.Click();
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();


            //// Verify Review Pre-Pre approval Page
            //ReviewPreApproval reviewPreApproval = new ReviewPreApproval();
            //reviewPreApproval.legendreviewpreapprovals.VerifyText("Search Claims", "Search Claims");


            ////Monitoring
            ////Navigate to Monitoring review Queue
            //navigationPage = new NavigationPage();
            //navigationPage.lnkMonitorig.Hover("Monitoring");
            //navigationPage.lnkMonitorigReviewQueue.Click();
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();
            //Thread.Sleep(1000);
            //// Verify Monitoring review Page
            //MonitoringReview monitoringReview = new MonitoringReview();
            //monitoringReview.hdMonitoringReview.VerifyText("Monitoring", "Monitoring");

            ////Navigate to RegionPreview
            //navigationPage = new NavigationPage();
            //navigationPage.lnkMonitorig.Hover("Monitoring");
            //navigationPage.lnkRegionPreview.Click();
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();
            //Thread.Sleep(2000);

            //// Verify RegionPreview Page
            //RegionPreview regionPreview = new RegionPreview();
            //regionPreview.hdRegionPreview.VerifyText("Region Preview", "Region Preview");

            ////Navigate to Monitoring center
            //navigationPage = new NavigationPage();
            //navigationPage.lnkMonitorig.Hover("Monitoring");
            //navigationPage.lnkMonitoringCenter.Click();
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();
            //Thread.Sleep(1000);

            //// Verify MonitoringCenter Page
            //MonitoringCenter monitoringCenter = new MonitoringCenter();
            //monitoringCenter.hdMonitoringCenter.VerifyText("Monitoring Center", "Monitoring Center");

            ////Navigate to Submit Monitor
            //navigationPage = new NavigationPage();
            //navigationPage.lnkMonitorig.Hover("Monitoring");
            //navigationPage.lnkSubmitMonitor.Click();
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();
            //Thread.Sleep(1000);

            //// Verify Submit Monitor
            //SubmitMonitor submitMonitor = new SubmitMonitor();
            //submitMonitor.hdSubmitMonitor.VerifyText("Submit Monitor", "Submit Monitor");

            ////Navigate to Publish Approval
            //navigationPage = new NavigationPage();
            //navigationPage.lnkMonitorig.Hover("Monitoring");
            //navigationPage.lnkPublishApproval.Click();
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();
            //Thread.Sleep(1000);

            //// Verify Publish Approval
            //PublishApproval publishApproval = new PublishApproval();
            //publishApproval.hdPublishApproval.VerifyText("Publish Approval", "Publish Approval");


            ////Navigate to Partner History
            //navigationPage = new NavigationPage();
            //navigationPage.lnkMonitorig.Hover("Monitoring");
            //navigationPage.lnkPartnerHistory.Click();
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();
            //Thread.Sleep(1000);

            //// Verify Partner History
            //PartnerHistory partnerHistory = new PartnerHistory();
            //partnerHistory.hdPartnerHistory.VerifyText("Partner History", "Partner History");

            ////Navigate to Reset Queue
            //navigationPage = new NavigationPage();
            //navigationPage.lnkMonitorig.Hover("Monitoring");
            //navigationPage.lnkResetQueue.Click();
            //WebDriver.WaitForPageLoaded();
            //WebDriver.CheckErrorsOnPage();
            //Thread.Sleep(1000);

            //// Verify Reset Queue
            //ResetQueue resetQueue = new ResetQueue();
            //resetQueue.hdResetQueue.VerifyText("Reset Queue", "Reset Queue");
        }


    }
}
