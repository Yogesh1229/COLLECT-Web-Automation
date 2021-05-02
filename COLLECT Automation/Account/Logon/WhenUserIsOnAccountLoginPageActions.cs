using COLLECT_Automation.Helpers;
using COLLECT_Automation.Model.AccountPages;
using COLLECT_Automation.Verification;
using COLLECTAutomation.TestSetup;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace COLLECT
{
    [TestClass]
    public class WhenUserIsOnAccountLoginPageActions : TestCaseSetup
    {
        TestUser _user = new TestUser();

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

        #region Actions

        #region Button And Links Works Correctly

        [TestMethod]
        [TestCategory("COLLECT_Account_Login_Actions_MainBody"), TestCategory("COLLECT_Account_Login_Actions"), TestCategory("COLLECT_Account_Login"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_Login_Actions_MainBody_01_WhenBothUserNameAndPasswordFieldsAreFilledInThenLoginSucceeds()
        {
            AccountLoginPage accountLoginPage = new AccountLoginPage(Driver);
            var createFormPage = accountLoginPage
                                        .SignInFully("Automationtesting505@gmail.com", "#Y12ogesh$"); //Later these hard coded values will be stored into database

            Verify.IsTrue(createFormPage.AmIOnCreateFormPage, "I am not correctly on the create form page.");

        }

        [TestMethod]
        [TestCategory("COLLECT_Account_Login_Actions_MainBody"), TestCategory("COLLECT_Account_Login_Actions"), TestCategory("COLLECT_Account_Login"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_Login_Actions_MainBody_02_WhenUserClickOnForgotPasswordLinkThenUserShouldBeNavigatedToForgotPasswordPage()
        {
            AccountLoginPage accountLoginPage = new AccountLoginPage(Driver);
            var forgotPasswordPage = accountLoginPage
                                            .ClickOnForgotPasswordLink();

            Verify.IsTrue(forgotPasswordPage.AmIOnforgotPasswordPage, "I am not correctly on the forgot password page.");

        }

        [TestMethod]
        [TestCategory("COLLECT_Account_Login_Actions_MainBody"), TestCategory("COLLECT_Account_Login_Actions"), TestCategory("COLLECT_Account_Login"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_Login_Actions_MainBody_03_WhenUserClickOnSignupLinkThenUserShouldBeNavigatedToSignupPage()
        {
            AccountLoginPage AccountLoginPage = new AccountLoginPage(Driver);
            var signupPage = AccountLoginPage
                                    .ClickOnSignupLink();

            Verify.IsTrue(signupPage.AmIOnAccountSignupPage, "I am not correctly on the sign up page.");

        }

        #endregion Button And Links Works Correctly

        #region Fields Validation

        #region Empty Fields Validation

        [TestMethod]
        [TestCategory("COLLECT_Account_Login_Actions_MainBody_EmptyField"), TestCategory("COLLECT_Account_Login_Actions_MainBody"), TestCategory("COLLECT_Account_Login_Actions"), TestCategory("COLLECT_Account_Login"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_Login_Actions_MainBody_EmptyField_01_WhenUserNameFieldIsEmptyThenLoginFails()
        {
            _user.Email = "";
            _user.Password = "#I12ndia$";
            AccountLoginPage accountLoginPage = new AccountLoginPage(Driver);
            accountLoginPage
                .SignInFully(_user.Email, _user.Password);

            Verify.IsTrue(accountLoginPage.AmIOnAccountLoginPage, "I am not correctly on the Login Page");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_Login_Actions_MainBody_EmptyField"), TestCategory("COLLECT_Account_Login_Actions_MainBody"), TestCategory("COLLECT_Account_Login_Actions"), TestCategory("COLLECT_Account_Login"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_Login_Actions_MainBody_EmptyField_02_WhenPasswordFieldIsEmptyThenLoginFails()
        {
            _user.Email = "Automationtesting505@gmail.com";
            _user.Password = "";
            AccountLoginPage accountLoginPage = new AccountLoginPage(Driver);
            accountLoginPage
                .SignInFully(_user.Email, _user.Password);

            Verify.IsTrue(accountLoginPage.AmIOnAccountLoginPage, "I am not correctly on the Login Page");
        }

        #endregion Empty Fields Validation

        #region Invalid Fields Validation

        [TestMethod]
        [TestCategory("COLLECT_Account_Login_Actions_MainBody_InvalidField"), TestCategory("COLLECT_Account_Login_Actions_MainBody"), TestCategory("COLLECT_Account_Login_Actions"), TestCategory("COLLECT_Account_Login"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_Login_Actions_MainBody_InvalidField_01_WhenUserNameFieldIsInvalidThenLoginFails()
        {
            _user.Email = "test";
            _user.Password = "#I12ndia$";
            AccountLoginPage accountLoginPage = new AccountLoginPage(Driver);
            accountLoginPage
                .SignInFully(_user.Email, _user.Password);

            Verify.IsTrue(accountLoginPage.AmIOnAccountLoginPage, "I am not correctly on the Login Page");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_Login_Actions_MainBody_InvalidField"), TestCategory("COLLECT_Account_Login_Actions_MainBody"), TestCategory("COLLECT_Account_Login_Actions"), TestCategory("COLLECT_Account_Login"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_Login_Actions_MainBody_InvalidField_02_WhenPasswordFieldIsInvalidThenLoginFails()
        {
            _user.Email = "Automationtesting505@gmail.com";
            _user.Password = "#I12";
            AccountLoginPage accountLoginPage = new AccountLoginPage(Driver);
            accountLoginPage
                .SignInFully(_user.Email, _user.Password);

            Verify.IsTrue(accountLoginPage.AmIOnAccountLoginPage, "I am not correctly on the Login Page");
        }

        #endregion Invalid Fields Validation

        #endregion Fields Validation

        #endregion Actions


    }
}
