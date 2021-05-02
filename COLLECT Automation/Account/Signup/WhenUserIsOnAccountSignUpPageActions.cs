using COLLECT_Automation.Helpers;
using COLLECT_Automation.Model.AccountPages;
using COLLECT_Automation.Model.AccountSignupPages;
using COLLECT_Automation.Verification;
using COLLECTAutomation.TestSetup;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace COLLECT_Automation.Account.Signup
{
    [TestClass]
    public class WhenUserIsOnAccountSignUpPageActions : TestCaseSetup
    {
        private TestUser _user = new TestUser();
        
        #region TestSetup

        [ClassInitialize]
        public static void ClassInitialize(TestContext t)
        {
            TestFixtureSetup();
        }

        [TestInitialize]
        public void TestInitialize()
        {
            InitializeTest();
        }

        [TestCleanup]
        public void TestCleanup()
        {

        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            TestFixtureCleanup();
        }

        #endregion

        #region Actions_MainBody

        #region Sign Up Page Buttons Work Correctly

        [TestMethod]
        [TestCategory("COLLECT_Account_Signup_Actions_MainBody"), TestCategory("COLLECT_Account_Signup_Actions"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_Signup_Actions_MainBody_01_WhenUserClickOnSignInWithGoogleButtonThenUserIsNavigatedToNewWindowUserSigninPage()
        {
            var accountSignupPage = new AccountSignupPage(Driver);
            var googleAccountPage = new GoogleAccountPage(Driver);

            accountSignupPage
                .Open()
                .ClickOnGoogleSignButton();

            googleAccountPage.SwitchToNewGoogleWindow();

            Verify.IsTrue(googleAccountPage.AmIOnGoogleAccountPage, "User is not navigated to google account page");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_Signup_Actions_MainBody"), TestCategory("COLLECT_Account_Signup_Actions"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_Signup_Actions_MainBody_02_WhenUserClickOnDialCodeLinkThenAllCountryListShouldBeDisplayed()
        {
            var accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                .Open()
                .ClickOnCountryCodeButton();
                
           Verify.IsTrue(accountSignupPage.CountryListExists, "Country list is not present on the page after clicking the dial code button");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_Signup_Actions_MainBody"), TestCategory("COLLECT_Account_Signup_Actions"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_Signup_Actions_MainBody_03_WhenUserClickOnDialCodeLinkThenUserShouldBeAbleToSelectAnyOneCountry()
        {
            var accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                .Open()
                .ClickOnCountryCodeButton()
                .SelectOneCountry();

            Verify.IsTrue(accountSignupPage.DidUserAbleToSelectOneCountry, "User is not able to select the country from drop down list");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_Signup_Actions_MainBody"), TestCategory("COLLECT_Account_Signup_Actions"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_Signup_Actions_MainBody_04_WhenAllRequiredFieldsAreFilledThenSignUpSucceedsAndUserRedirectedToFormsPage()
        {  
            _user.UserName = "AutomationTester";
            _user.OrganizationName = "TestingCompany";

            _user.Country = "Canada";
            _user.PhoneNumber = "1234567890";

            _user.Email = "AutomationTesting@testing.com";
            _user.Password = "testpass";
            var accountSignupPage = new AccountSignupPage(Driver);
            var createFormPage = accountSignupPage
                                    .SignUp(_user.UserName, _user.OrganizationName , 
                                            _user.Country, _user.PhoneNumber,
                                             _user.Email , _user.Password);          

            Verify.IsTrue(createFormPage.AmIOnCreateFormPage, "User is not present on create form page");
        }

        #endregion Sign Up Page Buttons Work Correctly

        #region Link Actions

        #region Terms of Service Link Work Correctly

        [TestMethod]
        [TestCategory("COLLECT_Account_Signup_Actions_MainBody"), TestCategory("COLLECT_Account_Signup_Actions"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_Signup_Actions_MainBody_01_WhenUserClicksOnTermsOfServicesLinkThenLicenseAgreementPDFOpenedInNewTab()
        {
            var accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                .Open()
                .ClickOnTermsOfServiceLink()
                .SwitchToNewTab();

            Verify.IsTrue(accountSignupPage.AmIOnTermsOfServicePage, "User is not present on Terms of Service page");
        }

        #endregion Terms of Service Link Work Correctly

        #region Privacy Policy Link Work Correctly

        [TestMethod]
        [TestCategory("COLLECT_Account_Signup_Actions_MainBody"), TestCategory("COLLECT_Account_Signup_Actions"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_Signup_Actions_MainBody_01_WhenUserClicksOnPrivacyPolicyLinkThenPrivacyPolicyPDFOpenedInNewTab()
        {
            var accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                .Open()
                .ClickOnPrivacyPolicyLink()
                .SwitchToNewTab();

            Verify.IsTrue(accountSignupPage.AmIOnPrivacyPolicyPage, "User is not present on Privacy Policy page");
        }

        #endregion Privacy Policy Link Work Correctly

        #region Login Link Work Correctly

        [TestMethod]
        [TestCategory("COLLECT_Account_Signup_Actions_MainBody"), TestCategory("COLLECT_Account_Signup_Actions"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_Signup_Actions_MainBody_01_WhenUserNavigatedToLogonPageSuccessfully()
        {
            var accountSignupPage = new AccountSignupPage(Driver);
            var accountLoginPage = accountSignupPage
                                            .Open()
                                            .ClickOnLoginLink();

            Verify.IsTrue(accountLoginPage.AmIOnAccountLoginPage, "User is not navigated to login page");
        }

        #endregion Login Link Work Correctly

        #region Much more Link Work Correctly

        [TestMethod]
        [TestCategory("COLLECT_Account_Signup_Actions_MainBody"), TestCategory("COLLECT_Account_Signup_Actions"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_Signup_Actions_MainBody_01_WhenUserClicksOnMuchMoreLinkThenUserNavigatedToMobileDataCollectionAppPage()
        {
            var accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                      .Open()
                      .ClickOnMuchMoreHyperLink();

            Verify.IsTrue(accountSignupPage.AmIOnMobileDataAppPage, "User is not navigated to Mobile Data App page after clicking on much more link");
        }

        #endregion Much more Link Work Correctly

        #endregion Link Actions

        #region Empty Field Validations

        [TestMethod]
        [TestCategory("COLLECT_Account_Signup_Actions_MainBody"), TestCategory("COLLECT_Account_Signup_Actions"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_Signup_Actions_MainBody_01_WhenUserAttemptsToSignupWithEmptyUserNameFieldThenErrorMessageShouldBeDisplayed()
        {
            _user.UserName = "";
            _user.OrganizationName = "TestingCompany";

            _user.Country = "Canada";
            _user.PhoneNumber = "1234567890";

            _user.Email = "AutomationTesting1@testing.com";
            _user.Password = "testpass";
            var accountSignupPage = new AccountSignupPage(Driver);
             accountSignupPage
                        .SignUp(_user.UserName, _user.OrganizationName,
                                            _user.Country, _user.PhoneNumber,
                                             _user.Email, _user.Password);

            Verify.IsTrue(accountSignupPage.AmIOnAccountSignupPage, "User is not present on sign up page");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_Signup_Actions_MainBody"), TestCategory("COLLECT_Account_Signup_Actions"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_Signup_Actions_MainBody_02_WhenUserAttemptsToSignupWithEmptyOrganizationFieldThenErrorMessageShouldBeDisplayed()
        {
            _user.UserName = "Tester1";
            _user.OrganizationName = "";

            _user.Country = "Canada";
            _user.PhoneNumber = "1234567890";

            _user.Email = "AutomationTesting1@testing.com";
            _user.Password = "testpass";
            var accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                       .SignUp(_user.UserName, _user.OrganizationName,
                                           _user.Country, _user.PhoneNumber,
                                            _user.Email, _user.Password);

            Verify.IsTrue(accountSignupPage.AmIOnAccountSignupPage, "User is not present on sign up page");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_Signup_Actions_MainBody"), TestCategory("COLLECT_Account_Signup_Actions"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_Signup_Actions_MainBody_03_WhenUserAttemptsToSignupWithEmptyPhoneNumberFieldThenErrorMessageShouldBeDisplayed()
        {
            _user.UserName = "Tester1";
            _user.OrganizationName = "TestingCompany";

            _user.Country = "Canada";
            _user.PhoneNumber = "";

            _user.Email = "AutomationTesting1@testing.com";
            _user.Password = "testpass";
            var accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                       .SignUp(_user.UserName, _user.OrganizationName,
                                           _user.Country, _user.PhoneNumber,
                                            _user.Email, _user.Password);

            Verify.IsTrue(accountSignupPage.AmIOnAccountSignupPage, "User is not present on sign up page");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_Signup_Actions_MainBody"), TestCategory("COLLECT_Account_Signup_Actions"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_Signup_Actions_MainBody_04_WhenUserAttemptsToSignupWithEmptyEmailFieldThenErrorMessageShouldBeDisplayed()
        {
            _user.UserName = "Tester1";
            _user.OrganizationName = "TestingCompany";

            _user.Country = "Canada";
            _user.PhoneNumber = "1234567890";

            _user.Email = "";
            _user.Password = "testpass";
            var accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                       .SignUp(_user.UserName, _user.OrganizationName,
                                           _user.Country, _user.PhoneNumber,
                                            _user.Email, _user.Password);

            Verify.IsTrue(accountSignupPage.AmIOnAccountSignupPage, "User is not present on sign up page");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_Signup_Actions_MainBody"), TestCategory("COLLECT_Account_Signup_Actions"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_Signup_Actions_MainBody_05_WhenUserAttemptsToSignupWithEmptyPasswordFieldThenErrorMessageShouldBeDisplayed()
        {
            _user.UserName = "Tester1";
            _user.OrganizationName = "TestingCompany";

            _user.Country = "Canada";
            _user.PhoneNumber = "1234567890";

            _user.Email = "AutomationTesting1@testing.com";
            _user.Password = "";
            var accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                       .SignUp(_user.UserName, _user.OrganizationName,
                                           _user.Country, _user.PhoneNumber,
                                            _user.Email, _user.Password);

            Verify.IsTrue(accountSignupPage.AmIOnAccountSignupPage, "User is not present on sign up page");
        }

        #endregion Empty Field Validations

        #region Invalid Field Validations

        [TestMethod]
        [TestCategory("COLLECT_Account_Signup_Actions_MainBody"), TestCategory("COLLECT_Account_Signup_Actions"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_Signup_Actions_MainBody_01_WhenUserAttemptsToSignupWithInvalidEmailFieldThenErrorMessageShouldBeDisplayed()
        {
            _user.UserName = "Automation";
            _user.OrganizationName = "TestingCompany";

            _user.Country = "Canada";
            _user.PhoneNumber = "1234567890";

            _user.Email = "AutomationTesting1";
            _user.Password = "testpass";
            var accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                       .SignUp(_user.UserName, _user.OrganizationName,
                                           _user.Country, _user.PhoneNumber,
                                            _user.Email, _user.Password);
            var actualErrorText = accountSignupPage.InvalidEmailErrorText;
            Verify.VerifyFieldUsingConst(actualErrorText, "Please enter a valid email address.", "Invalid email error text is not correct");
        }

        #endregion Invalid Field Validations

        #endregion Actions_MainBody

    }
}
