using COLLECT_Automation.Model.AccountPages;
using COLLECT_Automation.Verification;
using COLLECTAutomation.TestSetup;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace COLLECT
{
    [TestClass]
    public class WhenUserIsOnAccountLoginPageObjects : TestCaseSetup
    {
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

        #region Objects

        #region URL Is Correct

        [TestMethod]
        [TestCategory("COLLECT_Account_Login_Objects_Url"), TestCategory("COLLECT_Account_Login_Objects"), TestCategory("COLLECT_Account_Login"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_Login_Objects_Url_01_ThenCollectURLForPageIsCorrect()
        {
            AccountLoginPage accountLoginPage = new AccountLoginPage(Driver);
            accountLoginPage
                .Open();

            Verify.IsTrue(accountLoginPage.AmIOnAccountLoginPage, "I am not correctly on the Account Login Page");

        }

        #endregion URL Is Correct

        #region Main Body LeftPane Objects Existence

        [TestMethod]
        [TestCategory("COLLECT_Account_Login_Objects_MainBody_LeftPane_Existence"), TestCategory("COLLECT_Account_Login_Objects_MainBody_LeftPane"), TestCategory("COLLECT_Account_Login_Objects_MainBody"), TestCategory("COLLECT_Account_Login_Objects"), TestCategory("COLLECT_Account_Login"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_Login_Objects_MainBody_LeftPane_Existence_01_ThenLeftBlockWrapperExists()
        {
            AccountLoginPage accountLoginPage = new AccountLoginPage(Driver);
            accountLoginPage
                .Open();

            Verify.IsTrue(accountLoginPage.LeftBlockWrapperExists, "Left block wrapper exists on login Page");
        }

        #endregion Main Body LeftPane Objects Existence

        #region Main Body RightPane Objects Existence

        [TestMethod]
        [TestCategory("COLLECT_Account_Login_Objects_MainBody_RightPane_Existence"), TestCategory("COLLECT_Account_Login_Objects_MainBody_RightPane"), TestCategory("COLLECT_Account_Login_Objects_MainBody"), TestCategory("COLLECT_Account_Login_Objects"), TestCategory("COLLECT_Account_Login"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_Login_Objects_MainBody_RightPane_Existence_01_ThenCollectLogoExists()
        {
            AccountLoginPage accountLoginPage = new AccountLoginPage(Driver);
            accountLoginPage
                .Open();

            Verify.IsTrue(accountLoginPage.CollectLogoExists, "Collect logo doesn't exist on login page.");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_Login_Objects_MainBody_RightPane_Existence"), TestCategory("COLLECT_Account_Login_Objects_MainBody_RightPane"), TestCategory("COLLECT_Account_Login_Objects_MainBody"), TestCategory("COLLECT_Account_Login_Objects"), TestCategory("COLLECT_Account_Login"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_Login_Objects_MainBody_RightPane_Existence_02_ThenWelcomeBackTextExists()
        {
            AccountLoginPage accountLoginPage = new AccountLoginPage(Driver);
            accountLoginPage
                .Open();

            Verify.IsTrue(accountLoginPage.WelcomeBackTextExists, "Welcome Back doesn't exist on login page.");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_Login_Objects_MainBody_RightPane_Existence"), TestCategory("COLLECT_Account_Login_Objects_MainBody_RightPane"), TestCategory("COLLECT_Account_Login_Objects_MainBody"), TestCategory("COLLECT_Account_Login_Objects"), TestCategory("COLLECT_Account_Login"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_Login_Objects_MainBody_RightPane_Existence_03_ThenGoogleSignInButtonExists()
        {
            AccountLoginPage accountLoginPage = new AccountLoginPage(Driver);
            accountLoginPage
                .Open();

            Verify.IsTrue(accountLoginPage.GoogleSignInButtonExists, "Google sign in button doesn't exist on login page.");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_Login_Objects_MainBody_RightPane_Existence"), TestCategory("COLLECT_Account_Login_Objects_MainBody_RightPane"), TestCategory("COLLECT_Account_Login_Objects_MainBody"), TestCategory("COLLECT_Account_Login_Objects"), TestCategory("COLLECT_Account_Login"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_Login_Objects_MainBody_RightPane_Existence_04_ThenUserNameTextBoxLabelExists()
        {
            AccountLoginPage accountLoginPage = new AccountLoginPage(Driver);
            accountLoginPage
                .Open();

            Verify.IsTrue(accountLoginPage.EnterYourEmailLabelExists, "Enter your email label doesn't exist on login Page.");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_Login_Objects_MainBody_RightPane_Existence"), TestCategory("COLLECT_Account_Login_Objects_MainBody_RightPane"), TestCategory("COLLECT_Account_Login_Objects_MainBody"), TestCategory("COLLECT_Account_Login_Objects"), TestCategory("COLLECT_Account_Login"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_Login_Objects_MainBody_RightPane_Existence_05_ThenUserNameTextBoxExists()
        {
            AccountLoginPage accountLoginPage = new AccountLoginPage(Driver);
            accountLoginPage
                .Open();

            Verify.IsTrue(accountLoginPage.EmailTextExists, "Email text box doesn't exist on login page.");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_Login_Objects_MainBody_RightPane_Existence"), TestCategory("COLLECT_Account_Login_Objects_MainBody_RightPane"), TestCategory("COLLECT_Account_Login_Objects_MainBody"), TestCategory("COLLECT_Account_Login_Objects"), TestCategory("COLLECT_Account_Login"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_Login_Objects_MainBody_RightPane_Existence_06_ThenPasswordTextBoxLabelExists()
        {
            AccountLoginPage accountLoginPage = new AccountLoginPage(Driver);
            accountLoginPage
                .Open();

            Verify.IsTrue(accountLoginPage.EnterYourPasswordLabelExists, "Enter your password label doesn't exist on login page.");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_Login_Objects_MainBody_RightPane_Existence"), TestCategory("COLLECT_Account_Login_Objects_MainBody_RightPane"), TestCategory("COLLECT_Account_Login_Objects_MainBody"), TestCategory("COLLECT_Account_Login_Objects"), TestCategory("COLLECT_Account_Login"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_Login_Objects_MainBody_RightPane_Existence_07_ThenPasswordTextBoxExists()
        {
            AccountLoginPage accountLoginPage = new AccountLoginPage(Driver);
            accountLoginPage
                .Open();

            Verify.IsTrue(accountLoginPage.PasswordTextExists, "Password text box doesn't exist on login page.");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_Login_Objects_MainBody_RightPane_Existence"), TestCategory("COLLECT_Account_Login_Objects_MainBody_RightPane"), TestCategory("COLLECT_Account_Login_Objects_MainBody"), TestCategory("COLLECT_Account_Login_Objects"), TestCategory("COLLECT_Account_Login"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_Login_Objects_MainBody_RightPane_Existence_08_ThenShowButtonExists()
        {
            AccountLoginPage accountLoginPage = new AccountLoginPage(Driver);
            accountLoginPage
                .Open();

            Verify.IsTrue(accountLoginPage.ShowPasswordButtonExists, "Show password button doesn't exist on login page.");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_Login_Objects_MainBody_RightPane_Existence"), TestCategory("COLLECT_Account_Login_Objects_MainBody_RightPane"), TestCategory("COLLECT_Account_Login_Objects_MainBody"), TestCategory("COLLECT_Account_Login_Objects"), TestCategory("COLLECT_Account_Login"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_Login_Objects_MainBody_RightPane_Existence_09_ThenLoginButtonExists()
        {
            AccountLoginPage accountLoginPage = new AccountLoginPage(Driver);
            accountLoginPage
                .Open();

            Verify.IsTrue(accountLoginPage.LoginButtonExists, "Login button doesn't exist on login page.");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_Login_Objects_MainBody_RightPane_Existence"), TestCategory("COLLECT_Account_Login_Objects_MainBody_RightPane"), TestCategory("COLLECT_Account_Login_Objects_MainBody"), TestCategory("COLLECT_Account_Login_Objects"), TestCategory("COLLECT_Account_Login"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_Login_Objects_MainBody_RightPane_Existence_10_ThenDoNotHaveAnAccountTextExists()
        {
            AccountLoginPage accountLoginPage = new AccountLoginPage(Driver);
            accountLoginPage
                .Open();

            Verify.IsTrue(accountLoginPage.DoNotHaveAnAccountTextExists, "Do not have an account doesn't exist on login page.");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_Login_Objects_MainBody_RightPane_Existence"), TestCategory("COLLECT_Account_Login_Objects_MainBody_RightPane"), TestCategory("COLLECT_Account_Login_Objects_MainBody"), TestCategory("COLLECT_Account_Login_Objects"), TestCategory("COLLECT_Account_Login"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_Login_Objects_MainBody_RightPane_Existence_11_ThenSignupLinkExists()
        {
            AccountLoginPage accountLoginPage = new AccountLoginPage(Driver);
            accountLoginPage
                .Open();

            Verify.IsTrue(accountLoginPage.SignUpLinkExists, "Signup link doesn't exist on login Page");
        }

        #endregion Main Body RightPane Objects Existence

        #region Main Body RightPane Objects Images Src and Alt Text Are Correct

        [TestMethod]
        [TestCategory("COLLECT_Account_Login_Objects_MainBody_RightPane_Images_SrcAndAltTextVerification"), TestCategory("COLLECT_Account_Login_Objects_MainBody_RightPane"), TestCategory("COLLECT_Account_Login_Objects_MainBody"), TestCategory("COLLECT_Account_Login_Objects"), TestCategory("COLLECT_Account_Login"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_Login_Objects_MainBody_RightPane_Images_SrcAndAltTextVerification_01_ThenCollectLogoSrcIsCorrect()
        {
            AccountLoginPage accountLoginPage = new AccountLoginPage(Driver);
            accountLoginPage
                .Open();

            Verify.EqualOrMatch(accountLoginPage.CollectLogoSrcIsCorrect, "https://collect.socialcops.com/assets/img/collect_logo_2.svg",
                "The COLLECT Logo in the Main Menu of the Login Page does not contain the correct SRC information.");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_Login_Objects_MainBody_RightPane_Images_SrcAndAltTextVerification"), TestCategory("COLLECT_Account_Login_Objects_MainBody_RightPane"), TestCategory("COLLECT_Account_Login_Objects_MainBody"), TestCategory("COLLECT_Account_Login_Objects"), TestCategory("COLLECT_Account_Login"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_Login_Objects_MainBody_RightPane_Images_SrcAndAltTextVerification_02_ThenCollectLogoAltTextIsCorrect()
        {
            AccountLoginPage accountLoginPage = new AccountLoginPage(Driver);
            accountLoginPage
                .Open();

            Verify.EqualOrMatch(accountLoginPage.CollectLogoAltTextIsCorrect,".", 
                "The COLLECT Logo in the Main Menu of the Login Page does not contain the correct Alt text information.");
        }

        #endregion Main Body RightPane Objects Images Src and Alt Text Are Correct

        #region Main Body RightPane Objects Text Is Correct

        [TestMethod]
        [TestCategory("COLLECT_Account_Login_Objects_MainBody_RightPane_TextVerification"), TestCategory("COLLECT_Account_Login_Objects_MainBody_RightPane"), TestCategory("COLLECT_Account_Login_Objects_MainBody"), TestCategory("COLLECT_Account_Login_Objects"), TestCategory("COLLECT_Account_Login"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_Login_Objects_MainBody_RightPane_TextVerification_01_ThenWelcomeBackTextTextIsCorrect()
        {
            AccountLoginPage accountLoginPage = new AccountLoginPage(Driver);
            accountLoginPage
                .Open();

            Verify.VerifyFieldUsingConst(accountLoginPage.WelcomeBackTextIsCorrect, "Welcome back!",
                "Welcome back text actual value did not match with the expected value.");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_Login_Objects_MainBody_RightPane_TextVerification"), TestCategory("COLLECT_Account_Login_Objects_MainBody_RightPane"), TestCategory("COLLECT_Account_Login_Objects_MainBody"), TestCategory("COLLECT_Account_Login_Objects"), TestCategory("COLLECT_Account_Login"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_Login_Objects_MainBody_RightPane_TextVerification_02_ThenUserNameTextBoxLabelTextIsCorrect()
        {
            AccountLoginPage accountLoginPage = new AccountLoginPage(Driver);
            accountLoginPage
                .Open();

            Verify.VerifyFieldUsingConst(accountLoginPage.EnterYourEmailLabelIsCorrect, "Enter your email",
                "Enter your email text actual value did not match with the expected value.");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_Login_Objects_MainBody_RightPane_TextVerification"), TestCategory("COLLECT_Account_Login_Objects_MainBody_RightPane"), TestCategory("COLLECT_Account_Login_Objects_MainBody"), TestCategory("COLLECT_Account_Login_Objects"), TestCategory("COLLECT_Account_Login"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_Login_Objects_MainBody_RightPane_TextVerification_03_ThenPasswordTextBoxLabelTextIsCorrect()
        {
            AccountLoginPage accountLoginPage = new AccountLoginPage(Driver);
            accountLoginPage
                .Open();

            Verify.VerifyFieldUsingConst(accountLoginPage.EnterYourPasswordLabelIsCorrect, "Enter your password",
                "Enter your password text actual value did not match with the expected value.");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_Login_Objects_MainBody_RightPane_TextVerification"), TestCategory("COLLECT_Account_Login_Objects_MainBody_RightPane"), TestCategory("COLLECT_Account_Login_Objects_MainBody"), TestCategory("COLLECT_Account_Login_Objects"), TestCategory("COLLECT_Account_Login"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_Login_Objects_MainBody_RightPane_TextVerification_04_ThenDoNotHaveAnAccountTextTextIsCorrect()
        {
            AccountLoginPage accountLoginPage = new AccountLoginPage(Driver);
            accountLoginPage
                .Open();

            Verify.VerifyFieldUsingConst(accountLoginPage.DonNotHaveAnAccountTextIsCorrect, "Don't have an account? ",
                "Don't have an account? text actual value did not match with the expected value.");
        }

        #endregion Main Body RightPane Objects Text Is Correct

        #region SideBar Objects Existence

        [TestMethod]
        [TestCategory("COLLECT_Account_Login_Objects_SideBar_Existence"), TestCategory("COLLECT_Account_Login_Objects_SideBar"), TestCategory("COLLECT_Account_Login_Objects"), TestCategory("COLLECT_Account_Login"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_SignUp_Objects_SideBar_Existence_01_ThenChatIconExists()
        {
            AccountLoginPage accountLoginPage = new AccountLoginPage(Driver);
            accountLoginPage
                .Open()
                .WaitToRenderAnElement();

            Verify.IsTrue(accountLoginPage.ChatIconExists, "Chat Icon is not present on the page");
        }

        #endregion SideBar Objects Existence

        #endregion Objects

    }
}
