using Ansira.Test.AutomationFramework.CoreLibrary.UI;
using Ansira.Test.AutomationFramework.CoreLibrary.UI.Extensions;
using OpenQA.Selenium;

namespace TPMI.Tests.Pages
{
    class NavigationPage : BaseUIPage 
{
       
        //Partners
        public By lnkPartners =By.XPath("//a[@class='dropdown-toggle h-100 d-block nav-link'][contains(text(),'Partners')]");
        //Consent Center
        public By lnkConsentCenter =By.XPath("//a[contains(text(),'Consent Center')]");
       
        //Search Partners 
        public By lnkSearchPartners =By.XPath("//a[contains(text(),'Search Partners')]");
       
        //Enter Partners
        public By lnkenterPartners =By.XPath("//a[contains(text(),'Enter Partner')]");
     
        //Edit Partner Group
        public By lnkeditPartnerGroup =By.XPath("//a[contains(text(),'Edit Partner Groups')]");


        //Edit Partner sub Group
        public By lnkeditPartnersubgroup =By.XPath("//a[contains(text(),'Edit Partner Sub Groups')]");
        
        //Edit Sales Group
        public By lnkeditSalesgroup =By.XPath("//a[contains(text(),'Edit Sales Groups')]");
       
        //Edit Sales Offices
        public By lnkeditSalesoffices =By.XPath("//a[contains(text(),'Edit Sales Offices')]");
     
        //Exception Center
        public By lnkexceptioncenter =By.XPath("//a[contains(text(),'Exception Center')]");
        
        //Enter Exception
        public By lnkenterexception =By.XPath("//a[contains(text(),'Enter Exception')]");
        
        //Review Exception
        public By lnkreviewexception =By.XPath("//a[contains(text(),'Review Exceptions')]");
        
        //Salesrep Realignment
        public By lnksalesreprealignment =By.XPath("//a[contains(text(),'Sales Rep Realignment')]");

        //Monitoring
        public By lnkMonitoring =By.XPath("//a[contains(text(),'Monitoring')]");
        public By lnkMoniringReviewQueue =By.XPath(" //a[contains(text(),'Monitoring Review Queue')]");
        public By lnkRegionalPreview =By.XPath("//a[contains(text(),'Region Preview')]");
       

        //Program Info
        public By lnkprograminfo =By.XPath("//a[contains(text(),'Program Info')]");
              

        //Reports
        public By lnkReports =By.XPath("//a[contains(text(),'Reports')]");
        
        public By lnkChangeClient =By.XPath("//button[@class='nav-link dropdown-toggle btn btn-link']");
        public By lnkChangeclient1 =By.XPath("//a[contains(text(),'Change Client')]");

        //Administration/Search Notifications:
        public By lnkAdministration =By.XPath("//a[contains(text(),'Administration')]");
        public By lnksearchnotifications =By.XPath("//a[contains(text(),'Search Notifications')]");

        //Administration/Client Management
        public By lnkClientmanagement =By.XPath("//a[contains(text(),'Client Management')]");
       
       
        //Administration/Dashboard Management 
        public By lnkDashboardmanagement =By.XPath("//a[contains(text(),'Dashboard Management')]");
       
        //Administration/Partner Group Management 
        public By lnkPartnergrpmngmt =By.XPath("//a[contains(text(),'Partner Group Mngmt.')]");
        
        //Administration/Search Management 
        public By lnkSearchmngmt =By.XPath("//a[contains(text(),'Search Management')]");
        
        //Administration/Enter Program 
        public By lnkEnterprgm =By.XPath("//a[contains(text(),'Enter Program')]");
        
        //Administration/Batch Management 
        public By lnkBatchmngmt =By.XPath("//a[contains(text(),'Batch Management')]");
        public By btnSubmit3 =By.XPath("//input[@id='ctl00_ctl00_MainContent_btnSubmit']");        
        
        //Administration/Policy Management 
        public By lnkPolicymngmt =By.XPath("//a[contains(text(),'Policy Management')]");
       
        //Administration/Manage Metrics
        public By lnkManagemetrics =By.XPath("//a[contains(text(),'Manage Metrics')]");
        
        //Administration/Manage Messages
        public By lnkManagemessages =By.XPath("//a[contains(text(),'Manage Messages')]");
        
        //Administration/Media
        public By lnkMedia =By.XPath("//a[@class='nav-link'][contains(text(),'Media')]");
        
        //Administration/Manage Baselines
        public By lnkManagebaselines =By.XPath("//a[contains(text(),'Manage Baselines')]");
        
        //Administration/Manage Promotions
        public By lnkManagepromotionss =By.XPath("//a[contains(text(),'Manage Promotions')]");
       
        //Administration/User Registraion Management
        public By lnkUserregmnmgmt =By.XPath("//a[contains(text(),'User Registration Management')]");
       
        //Administration/Manage Fixed Currency
        public By lnkManagefxdcurrency =By.XPath("//a[contains(text(),'Manage Fixed Currency Rates')]");
     
        //Administration/User Management
        public By lnkUsermngmt =By.XPath("//a[contains(text(),'User Management')]");
       
        public By btnSubmit4 =By.XPath("//input[@id='ctl00_MainContent_btnUserSearch']");
        
        //Administration/Group Management
        public By lnkGroupmngmt =By.XPath("//a[contains(text(),'Group Management')]");
        public By btnSubmit5 =By.XPath("//input[@id='ctl00_ctl00_MainContent_btnSubmit']");
        
        //Administration/Manage Terms and Translations
        public By lnkMngtersmntrans =By.XPath("//ul[@class='dropdown-menu show']//a[@class='nav-link'][contains(text(),'Manage Terms and Translations')]");
       
        //Administration/Manage Leads Custom Data
        public By lnkMngldscustomdata =By.XPath("//a[contains(text(),'Manage Leads Custom Data')]");
       
        //Administration/Scheduler Admin
        public By lnkScheduleradmin =By.XPath("//a[contains(text(),'Scheduler Admin')]");


        //Funds
        public By lnkFunds =By.XPath("//a[@class='dropdown-toggle h-100 d-block nav-link'][contains(text(),'Funds')]");
        public By lnkSearchFunds =By.XPath("//a[contains(text(),'Search Funds')]");

        public By btnSubmit1 =By.XPath("//input[@id='ctl00_ctl00_MainContent_btnSubmit']");
        public By lnkEnterFunds =By.XPath("//a[contains(text(),'Enter Account')]");

        //Funds/Accounts
        public By lnksearchAccounts =By.XPath("//a[contains(text(),'Search Accounts')]");
        public By legendSearchAccounts1 = By.XPath("//legend[contains(text(),'Search Accounts')]");
        public By btnSubmit =By.XPath("//button[@id='btnSubmit']");

        public By lnkEnterAccounts =By.XPath("//a[contains(text(),'Enter Account')]");
        public By legendEnterAccounts =By.XPath("//div[@class='pnlPageTitleSearch']");
        public By lnkSearchTransactions =By.XPath("//a[contains(text(),'Search Transactions')]");
        public By legendSearchTransactions = By.XPath("//legend[contains(text(),'Search Transactions')]");

        //Funds/Allocations
        public By lnkAllocate =By.XPath("//a[contains(text(),'Allocate')]");
        public By legendAllocation =By.XPath("//div[@class='pnlPageTitleSearch']");
        //Funds/Adjust
        public By lnkAdjust =By.XPath("//a[contains(text(),'Adjust $')]");
        public By legenAdjust =By.XPath("//div[@class='pnlPageTitleSearch']");
        //Funds/Transfer
        public By lnkTransfer =By.XPath("//a[contains(text(),'Transfer $')]");
        public By legentransfer =By.XPath("//legend[contains(text(),'Transfer Entry Profile')]");
        //Funds/Offers
        public By lnkOffer =By.XPath("//a[contains(text(),'Offers')]");
        public By legendoffers =By.XPath("//div[@class='legend-lg']");

        //Commitments
        public By txtClaims1 = By.LinkText("Claims");
        public By lnkCommitmets =By.XPath("//a[@class='dropdown-toggle h-100 d-block nav-link'][contains(text(),'Commitments')]");
        //ActivityCenter        
        public By lnkActivityCenter =By.XPath("//a[contains(text(),'Activity Center')]");
        public By TblActivityCenter1 = By.XPath("//div[@class='dataCenter-heading']");
        //Search Commitments
        public By lnkSearchCommitmnets =By.XPath("//a[contains(text(),'Search Commitments')]");
        public By legendSearchCommitments = By.XPath("//legend[contains(text(),'Search Commitments')]");
        //Enter Commitments
        public By lnkenterCommitmnets =By.XPath("//a[contains(text(),'Enter Commitments')]");
        public By legendCommitmentsenrty = By.XPath("//div[@class='legend-lg']");
        //Approve Commitments
        public By lnkapproveCommitmnets =By.XPath("//a[contains(text(),'Approve Commitments')]");
        public By legendapproveCommitments1 = By.XPath("//div[@class='pnlPageTitleSearch']");
        //Lead Center
        public By lnkleadcenter =By.XPath("//a[contains(text(),'Leads Center')]");
        public By legendleadcenter1 = By.XPath("//h3[@class='pageHeader']");


        //Pre-approvals
        public By lnkPreapprovals =By.XPath("//a[@class='dropdown-toggle h-100 d-block nav-link'][contains(text(),'Pre-Approvals')]");
        //Pre-aproval center
        public By lnkPreapprovalcenter =By.XPath("//a[contains(text(),'Pre-Approval Center')]");
        public By legendpreapprovalcenter1 =By.XPath("//div[@class='dataCenter-heading']");
        //Enter-Pre approvals
        public By lnkenterpreapprovals =By.XPath("//a[contains(text(),'Enter Pre-Approvals')]");
        public By legendenterpreapprovals =By.XPath("//div[@class='legend-lg']");
        //Review-pre approvals
        public By lnkreviewpreapprovals =By.XPath("//a[contains(text(),'Review Pre-Approvals')]");
        public By legendreviewpreapprovals =By.XPath("//legend[contains(text(),'Pre-Approval Review List')]");



        // monitoring
        public By lnkMonitorig = By.LinkText("Monitoring");
            //FindByXpath("//a[contains(@class,'dropdown-toggle'][contains(text(),'Monitoring')]");
        public By lnkMonitorigReviewQueue =By.XPath("//a[contains(text(),'Monitoring Review Queue')]");
        public By lnkRegionPreview =By.XPath("//a[contains(text(),'Region Preview')]");
        public By lnkMonitoringCenter =By.XPath("//a[contains(text(),'Monitoring Center')]");
        public By lnkSubmitMonitor => By.LinkText("Submit Monitor");
            //FindByXpath("//a[contains(text(),'Submit Monitor')]");
        public By lnkPublishApproval =By.XPath("//a[contains(text(),'Publish Approval')]");
        public By lnkPartnerHistory =By.XPath("//a[contains(text(),'Partner History')]");
        public By lnkResetQueue =By.XPath("//a[contains(text(),'Reset Queue')]");
        //Monitoring Text comapers
        public By hdMonitoringReview =By.XPath("//h3[contains(text(),'Monitoring')]");
        public By hdRegionPreview =By.XPath("//h3[@id='regionalPreviewHeader']");
        public By hdMonitoringCenter =By.XPath("//h3[contains(text(),'Monitoring')]");
        public By hdSubmitMonitor =By.XPath("//h3[@id='monitorHeader']");
        public By hdPublishApproval =By.XPath("//h3[@id='publishApprovalHeader']");
        public By hdPartnerHistory =By.XPath("//h3[@id='partnerHistoryHeader']");
        public By hdResetQueue =By.XPath("//h3[@id='resetHeader']");


        //Claims
        public By lnkClaims =By.XPath("//a[@class='dropdown-toggle h-100 d-block nav-link'][contains(text(),'Claims')]");
        public By lnkClaimCenter =By.XPath("//a[contains(text(),'Claim Center')]");
        public By TblClaimsCenter = By.XPath("//div[@class='dataCenter-heading']");
        //Search Claims
        public By lnkSearchClaims =By.XPath("//a[contains(text(),'Search Claims')]");
        public By legendSearchClaims1 = By.XPath("//legend[contains(text(),'Search Claims')]");
        //Enter Claims
        public By lnkenterClaim =By.XPath("//a[contains(text(),'Enter Claim')]");
        public By TblenterClaims1 = By.XPath("//div[@class='legend-lg']");
        //Pre-audit Claim
        public By lnkpreautidtClaim =By.XPath("//a[contains(text(),'Pre-Audit Claims')]");
        public By TblpreauditClaims1 =By.XPath("//div[@class='pnlPageTitleSearch']");
        //Audit Activity
        public By lnkpreautidtactivity =By.XPath("//a[contains(text(),'Pre-Audit Activities')]");
        public By Tblpreauditsctivity1 =By.XPath("//legend[contains(text(),'Pre-Audit Entry')]");

        //Audit Claim
        public By lnkauditclaims =By.XPath("//li[@id='navAuditClaim']//a[@class='nav-link'][contains(text(),'Audit Claims')]");
        public By TblauditClaims1 = By.XPath("//div[@class='card-header']");

        //Payment Center
        public By lnkpaymentcenter =By.XPath("//a[contains(text(),'Payment Center')]");
        public By Tblpaymentcenter1 =By.XPath("//div[@class='pnlPageTitleSearch']");

        //Process Claims
        public By lnkprocessclaims =By.XPath("//a[contains(text(),'Process Claims')]");
        public By Tblprocessclaims1 =By.XPath("//div[@class='pnlPageTitleSearch']");

        //Provide Followup metrics
        public By lnkprovidemetrics =By.XPath("//a[contains(text(),'Provide Follow-Up Metrics')]");
        public By Tblprovidemetrics1 =By.XPath("//legend[contains(text(),'Search Claims')]");

        //Approve Claims
        public By lnkapproveclaims =By.XPath("//a[contains(text(),'Approve Claims')]");
        public By Tblapproveclaims1 = By.XPath("//legend[contains(text(),'Approve Claims')]");

        //Claim File upload
        public By lnkclaimfileupload =By.XPath("//a[contains(text(),'Claim File Upload')]");
        public By Tblclaimfileupload1 = By.XPath("//div[@class='dataCenter-heading']//div[contains(text(),'Claim File Upload')]");





    }
}
