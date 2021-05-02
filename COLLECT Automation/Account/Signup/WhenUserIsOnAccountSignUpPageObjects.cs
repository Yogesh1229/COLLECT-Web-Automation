using COLLECT_Automation.Model.AccountSignupPages;
using COLLECT_Automation.Verification;
using COLLECTAutomation.TestSetup;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace COLLECT
{
    [TestClass]
    public class WhenUserIsOnAccountAccountSignupPageObjects : TestCaseSetup
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

        #region objects

        #region Url Is Correct

        [TestMethod]
        [TestCategory("COLLECT_Account_SignUp_Objects_Url"), TestCategory("COLLECT_Account_SignUp_Objects"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_SignUp_Objects_Url_01_ThenCollectUrlForPageIsCorrect()
        {
            AccountSignupPage accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                .Open();

            Verify.IsTrue(accountSignupPage.AmIOnAccountSignupPage, "I am not correctly on the Signup Page");

        }

        #endregion Url Is Correct

        #region Main Body LeftPane Objects Existence

        [TestMethod]
        [TestCategory("COLLECT_Account_SignUp_Objects_MainBody_LeftPane_Existence"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody_LeftPane"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody"), TestCategory("COLLECT_Account_SignUp_Objects"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_SignUp_Objects_MainBody_LeftPane_Existence_01_ThenCollectLogoExists()
        {
            AccountSignupPage accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                .Open();

            Verify.IsTrue(accountSignupPage.CollectLogoExists, "Collect logo is not present on the page");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_SignUp_Objects_MainBody_LeftPane_Existence"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody_LeftPane"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody"), TestCategory("COLLECT_Account_SignUp_Objects"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_SignUp_Objects_MainBody_LeftPane_Existence_02_ThenStartYour7DayFreeTrialTextExists()
        {
            AccountSignupPage accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                .Open();

            Verify.IsTrue(accountSignupPage.SevenDayFreeTrialTextExists, "Seven day free trial text is not present on the page");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_SignUp_Objects_MainBody_LeftPane_Existence"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody_LeftPane"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody"), TestCategory("COLLECT_Account_SignUp_Objects"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_SignUp_Objects_MainBody_LeftPane_Existence_03_ThenNoCreditCardRequiredTextsExists()
        {
            AccountSignupPage accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                .Open();

            Verify.IsTrue(accountSignupPage.NoCreditCardRequiredTextExists, "No Credit card require text is not present on the page");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_SignUp_Objects_MainBody_LeftPane_Existence"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody_LeftPane"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody"), TestCategory("COLLECT_Account_SignUp_Objects"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_SignUp_Objects_MainBody_LeftPane_Existence_04_ThenMainHeaderOfDataCollectionTextExists()
        {
            AccountSignupPage accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                .Open();

            Verify.IsTrue(accountSignupPage.InstantDataCollectionTextExists, "Instant data collection text is not present on the page");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_SignUp_Objects_MainBody_LeftPane_Existence"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody_LeftPane"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody"), TestCategory("COLLECT_Account_SignUp_Objects"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_SignUp_Objects_MainBody_LeftPane_Existence_05_ThenFormsCreationInLanguageClassExists()
        {
            AccountSignupPage accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                .Open();

            Verify.IsTrue(accountSignupPage.FormCreationInAnyLanuageTextExists, "Form creation in any language text is not present on the page");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_SignUp_Objects_MainBody_LeftPane_Existence"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody_LeftPane"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody"), TestCategory("COLLECT_Account_SignUp_Objects"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_SignUp_Objects_MainBody_LeftPane_Existence_06_ThenCollectDataWithoutInternetClassExists()
        {
            AccountSignupPage accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                .Open();

            Verify.IsTrue(accountSignupPage.collectDataWithoutInternetTextExists, "Collect data without internet text is not present on the page");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_SignUp_Objects_MainBody_LeftPane_Existence"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody_LeftPane"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody"), TestCategory("COLLECT_Account_SignUp_Objects"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_SignUp_Objects_MainBody_LeftPane_Existence_07_ThenDataAnalysisTextClassExists()
        {
            AccountSignupPage accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                .Open();

            Verify.IsTrue(accountSignupPage.DataAnalyzationTextExists, "Data analyzation text is not present on the page");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_SignUp_Objects_MainBody_LeftPane_Existence"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody_LeftPane"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody"), TestCategory("COLLECT_Account_SignUp_Objects"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_SignUp_Objects_MainBody_LeftPane_Existence_08_ThenWhatOtherUsersAreSayingExists()
        {
            AccountSignupPage accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                .Open();

            Verify.IsTrue(accountSignupPage.WhatOtherUsersSayTextExists, "What other users say text is not present on the page");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_SignUp_Objects_MainBody_LeftPane_Existence"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody_LeftPane"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody"), TestCategory("COLLECT_Account_SignUp_Objects"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_SignUp_Objects_MainBody_LeftPane_Existence_09_ThenUserCommentsSectionExists()
        {
            AccountSignupPage accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                .Open();

            Verify.IsTrue(accountSignupPage.UserCommentsSlider, "User comments slider is not present on the page");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_SignUp_Objects_MainBody_LeftPane_Existence"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody_LeftPane"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody"), TestCategory("COLLECT_Account_SignUp_Objects"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_SignUp_Objects_MainBody_LeftPane_Existence_10_ThencarouselIndicatorsExists()
        {
            AccountSignupPage accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                .Open();

            Verify.IsTrue(accountSignupPage.CarouselIndicatorsExists, "Carousel indicators are not present on the page");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_SignUp_Objects_MainBody_LeftPane_Existence"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody_LeftPane"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody"), TestCategory("COLLECT_Account_SignUp_Objects"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_SignUp_Objects_MainBody_LeftPane_Existence_11_ThenPoweredByGoDaddyImageExists()
        {
            AccountSignupPage accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                .Open();

            Verify.IsTrue(accountSignupPage.PoweredByGoDaddyImageExists, "Powered by Go Daddy image is not present on the page");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_SignUp_Objects_MainBody_LeftPane_Existence"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody_LeftPane"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody"), TestCategory("COLLECT_Account_SignUp_Objects"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_SignUp_Objects_MainBody_LeftPane_Existence_12_ThenPoweredByCloudFareImageExists()
        {
            AccountSignupPage accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                .Open();

            Verify.IsTrue(accountSignupPage.CloudFlareImageExists, "Cloud fare image is not present on the page");
        }

        #endregion Main Body LeftPane Objects Existence

        #region Main Body LeftPane Objects Images Src and Alt Text Are Correct

        [TestMethod]
        [TestCategory("COLLECT_Account_SignUp_Objects_MainBody_LeftPane_Images_SrcAndAltTextVerification"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody_LeftPane"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody"), TestCategory("COLLECT_Account_SignUp_Objects"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_SignUp_Objects_MainBody_LeftPane_Images_SrcAndAltTextVerification_01_ThenCollectLogoSrcIsCorrect()
        {
            AccountSignupPage accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                .Open();

            Verify.EqualOrMatch(accountSignupPage.CollectLogoSrcIsCorrect, "https://collect.socialcops.com/assets/img/collect_logo_2.svg",
                "The COLLECT Logo in the Main Menu of the Sign up Page does not contain the correct SRC information.");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_SignUp_Objects_MainBody_LeftPane_Images_SrcAndAltTextVerification"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody_LeftPane"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody"), TestCategory("COLLECT_Account_SignUp_Objects"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_SignUp_Objects_MainBody_LeftPane_Images_SrcAndAltTextVerification_02_ThenCollectLogoAltTextIsCorrect()
        {
            AccountSignupPage AccountSignupPage = new AccountSignupPage(Driver);
            AccountSignupPage
                .Open();

            Verify.EqualOrMatch(AccountSignupPage.CollectLogoAltTextIsCorrect, ".",
                "The COLLECT Logo in the Main Menu of the Sign up Page does not contain the correct Alt text information.");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_SignUp_Objects_MainBody_LeftPane_Images_SrcAndAltTextVerification"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody_LeftPane"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody"), TestCategory("COLLECT_Account_SignUp_Objects"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_SignUp_Objects_MainBody_LeftPane_Images_SrcAndAltTextVerification_03_ThenPoweredByGoDaddySrcIsCorrect()
        {
            AccountSignupPage accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                .Open();

            Verify.EqualOrMatch(accountSignupPage.PoweredByGoDaddySrcIsCorrect, "https://collect.socialcops.com/assets/img/godaddy-en-ssl.svg",
                "The Powered By Go Daddy Image in the Main Menu of the Sign up Page does not contain the correct SRC information.");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_SignUp_Objects_MainBody_LeftPane_Images_SrcAndAltTextVerification"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody_LeftPane"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody"), TestCategory("COLLECT_Account_SignUp_Objects"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_SignUp_Objects_MainBody_LeftPane_Images_SrcAndAltTextVerification_04_ThenPoweredByGoDaddyAltTextIsCorrect()
        {
            AccountSignupPage accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                .Open();

            Verify.EqualOrMatch(accountSignupPage.PoweredByGoDaddyAltTextIsCorrect, "Godaddy seal",
                "The Powered By Go Daddy Image in the Main Menu of the Sign up Page does not contain the correct Alt text information.");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_SignUp_Objects_MainBody_LeftPane_Images_SrcAndAltTextVerification"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody_LeftPane"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody"), TestCategory("COLLECT_Account_SignUp_Objects"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]
        public void COLLECT_Account_SignUp_Objects_MainBody_LeftPane_Images_SrcAndAltTextVerification_05_ThenPoweredByCloudFareSrcIsCorrect()
        {
            AccountSignupPage accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                .Open();

            Verify.EqualOrMatch(accountSignupPage.CloudFareSrcIsCorrect, "https://collect.socialcops.com/assets/img/cloudflare-seal.png",
                "The Powered By Cloud Fare Image in the Main Menu of the Sign up Page does not contain the correct SRC information.");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_SignUp_Objects_MainBody_LeftPane_Images_SrcAndAltTextVerification"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody_LeftPane"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody"), TestCategory("COLLECT_Account_SignUp_Objects"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_SignUp_Objects_MainBody_LeftPane_Images_SrcAndAltTextVerification_06_ThenPoweredByCloudFareAltTextIsCorrect()
        {
            AccountSignupPage accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                .Open();

            Verify.EqualOrMatch(accountSignupPage.CloudFareAltTextIsCorrect, "Cloudflare seal",
                "The Powered By Cloud Fare Image in the Main Menu of the Sign up Page does not contain the correct Alt text information.");
        }


        #endregion Main Body LeftPane Objects Images Src and Alt Text Are Correct

        #region Main Body LeftPane Objects Text Is Correct

        [TestMethod]
        [TestCategory("COLLECT_Account_SignUp_Objects_MainBody_LeftPane_TextVerification"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody_LeftPane"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody"), TestCategory("COLLECT_Account_SignUp_Objects"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_SignUp_Objects_MainBody_LeftPane_TextVerification_01_ThenStartYour7DayFreeTrialTextIsCorrect()
        {
            AccountSignupPage accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                .Open();

            Verify.VerifyFieldUsingConst(accountSignupPage.SevenDayFreeTrialText, "Start your 7-Day free trial",
                "The Seven day free trial text actual value did not match with the expected value.");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_SignUp_Objects_MainBody_LeftPane_TextVerification"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody_LeftPane"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody"), TestCategory("COLLECT_Account_SignUp_Objects"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_SignUp_Objects_MainBody_LeftPane_TextVerification_02_ThenNoCreditCardRequiredTextIsCorrect()
        {
            AccountSignupPage accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                .Open();

            Verify.VerifyFieldUsingConst(accountSignupPage.NoCreditCardRequiredText, "No Credit Card Required",
                "The No credit card text actual value did not match with the expected value.");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_SignUp_Objects_MainBody_LeftPane_TextVerification"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody_LeftPane"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody"), TestCategory("COLLECT_Account_SignUp_Objects"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_SignUp_Objects_MainBody_LeftPane_TextVerification_03_ThenMainHeaderOfDataCollectionTextIsCorrect()
        {
            AccountSignupPage accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                .Open();

            Verify.VerifyFieldUsingConst(accountSignupPage.InstantDataCollectionText, "Start collecting data instantly!",
                "The instant data collection text actual value did not match with the expected value.");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_SignUp_Objects_MainBody_LeftPane_TextVerification"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody_LeftPane"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody"), TestCategory("COLLECT_Account_SignUp_Objects"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_SignUp_Objects_MainBody_LeftPane_TextVerification_04_ThenFormsCreationInLanuageTextIsCorrect()
        {
            AccountSignupPage accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                .Open();

            Verify.VerifyFieldUsingConst(accountSignupPage.FormCreationInAnyLanuageText, "Create forms in any language",
                "The form creation in any language text actual value did not match with the expected value.");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_SignUp_Objects_MainBody_LeftPane_TextVerification"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody_LeftPane"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody"), TestCategory("COLLECT_Account_SignUp_Objects"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_SignUp_Objects_MainBody_LeftPane_TextVerification_05_ThenCollectDataWithoutInternetTextIsCorrect()
        {
            AccountSignupPage accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                .Open();

            Verify.VerifyFieldUsingConst(accountSignupPage.collectDataWithoutInternetText, "Collect data without internet",
                "The collect data without internet text actual value did not match with the expected value.");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_SignUp_Objects_MainBody_LeftPane_TextVerification"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody_LeftPane"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody"), TestCategory("COLLECT_Account_SignUp_Objects"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_SignUp_Objects_MainBody_LeftPane_TextVerification_06_ThenDataAnalysisTextIsCorrect()
        {
            AccountSignupPage accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                .Open();

            Verify.VerifyFieldUsingConst(accountSignupPage.DataAnalyzationText, "Analyze your data effortlessly and much more",
                "The analyze your data text actual value did not match with the expected value.");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_SignUp_Objects_MainBody_LeftPane_TextVerification"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody_LeftPane"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody"), TestCategory("COLLECT_Account_SignUp_Objects"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_SignUp_Objects_MainBody_LeftPane_TextVerification_07_ThenWhatOtherUsersAreSayingTextIsCorrect()
        {
            AccountSignupPage accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                .Open();

            Verify.VerifyFieldUsingConst(accountSignupPage.WhatOtherUsersSayText, "What our users are saying",
                "The what other users say text actual value did not match with the expected value.");
        }

        #endregion Main Body LeftPane Objects Text Is Correct

        #region Main Body RightPane Objects Existence

        [TestMethod]
        [TestCategory("COLLECT_Account_SignUp_Objects_MainBody_RightPane_Existence"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody_RightPane"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody"), TestCategory("COLLECT_Account_SignUp_Objects"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_SignUp_Objects_MainBody_RightPane_Existence_01_ThenGoogleSignInButtonExists()
        {
            AccountSignupPage accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                .Open();

            Verify.IsTrue(accountSignupPage.GoogleSignInButtonExists, "Google Sign in button is not present on the page");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_SignUp_Objects_MainBody_RightPane_Existence"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody_RightPane"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody"), TestCategory("COLLECT_Account_SignUp_Objects"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_SignUp_Objects_MainBody_RightPane_Existence_02_ThenUserNameTextExists()
        {
            AccountSignupPage accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                .Open();

            Verify.IsTrue(accountSignupPage.UserNameTextExists, "User name text is not present on the page");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_SignUp_Objects_MainBody_RightPane_Existence"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody_RightPane"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody"), TestCategory("COLLECT_Account_SignUp_Objects"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_SignUp_Objects_MainBody_RightPane_Existence_03_ThenUserNameTextBoxLabelExists()
        {
            AccountSignupPage accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                .Open();

            Verify.IsTrue(accountSignupPage.UserNameLabelExists, "User name text box label is not present on the page");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_SignUp_Objects_MainBody_RightPane_Existence"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody_RightPane"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody"), TestCategory("COLLECT_Account_SignUp_Objects"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_SignUp_Objects_MainBody_RightPane_Existence_04_ThenOrganizationNameTextExists()
        {
            AccountSignupPage accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                .Open();

            Verify.IsTrue(accountSignupPage.OrganizationNameTextExists, "Organization name text is not present on the page");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_SignUp_Objects_MainBody_RightPane_Existence"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody_RightPane"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody"), TestCategory("COLLECT_Account_SignUp_Objects"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_SignUp_Objects_MainBody_RightPane_Existence_05_ThenOrganizationNameTextBoxLabelExists()
        {
            AccountSignupPage accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                .Open();

            Verify.IsTrue(accountSignupPage.OrganizationNameLabelExists, "Organization name text box label is not present on the page");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_SignUp_Objects_MainBody_RightPane_Existence"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody_RightPane"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody"), TestCategory("COLLECT_Account_SignUp_Objects"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_SignUp_Objects_MainBody_RightPane_Existence_06_ThenIndianFlagExists()
        {
            AccountSignupPage accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                .Open();

            Verify.IsTrue(accountSignupPage.IndianFlagExists, "Indian Flag is not present on the page");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_SignUp_Objects_MainBody_RightPane_Existence"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody_RightPane"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody"), TestCategory("COLLECT_Account_SignUp_Objects"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_SignUp_Objects_MainBody_RightPane_Existence_07_ThenCountryCodeOptionExists()
        {
            AccountSignupPage accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                .Open();

            Verify.IsTrue(accountSignupPage.CountryCodeExists, "Country code is not present on the page");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_SignUp_Objects_MainBody_RightPane_Existence"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody_RightPane"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody"), TestCategory("COLLECT_Account_SignUp_Objects"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_SignUp_Objects_MainBody_RightPane_Existence_08_ThenCountryCodeButtonOptionExists()
        {
            AccountSignupPage accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                .Open();

            Verify.IsTrue(accountSignupPage.CountryCodeDropDownButtonExists, "Country code is not present on the page");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_SignUp_Objects_MainBody_RightPane_Existence"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody_RightPane"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody"), TestCategory("COLLECT_Account_SignUp_Objects"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_SignUp_Objects_MainBody_RightPane_Existence_09_ThenPhoneNumberTextExists()
        {
            AccountSignupPage accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                .Open();

            Verify.IsTrue(accountSignupPage.PhoneNumberTextExists, "Phone number text is not present on the page");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_SignUp_Objects_MainBody_RightPane_Existence"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody_RightPane"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody"), TestCategory("COLLECT_Account_SignUp_Objects"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_SignUp_Objects_MainBody_RightPane_Existence_10_ThenPhoneNumberTextBoxLabelExists()
        {
            AccountSignupPage accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                .Open();

            Verify.IsTrue(accountSignupPage.PhoneNumberLabelExists, "Phone number text box label is not present on the page");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_SignUp_Objects_MainBody_RightPane_Existence"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody_RightPane"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody"), TestCategory("COLLECT_Account_SignUp_Objects"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_SignUp_Objects_MainBody_RightPane_Existence_11_ThenEmailTextExists()
        {
            AccountSignupPage accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                .Open();

            Verify.IsTrue(accountSignupPage.EmailTextExists, "Email text is not present on the page");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_SignUp_Objects_MainBody_RightPane_Existence"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody_RightPane"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody"), TestCategory("COLLECT_Account_SignUp_Objects"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_SignUp_Objects_MainBody_RightPane_Existence_12_ThenEmailTextBoxLabelExists()
        {
            AccountSignupPage accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                .Open();

            Verify.IsTrue(accountSignupPage.EmailLabelExists, "Email text box label is not present on the page");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_SignUp_Objects_MainBody_RightPane_Existence"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody_RightPane"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody"), TestCategory("COLLECT_Account_SignUp_Objects"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_SignUp_Objects_MainBody_RightPane_Existence_13_ThenPasswordTextExists()
        {
            AccountSignupPage accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                .Open();

            Verify.IsTrue(accountSignupPage.PasswordTextExists, "Password text is not present on the page");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_SignUp_Objects_MainBody_RightPane_Existence"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody_RightPane"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody"), TestCategory("COLLECT_Account_SignUp_Objects"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_SignUp_Objects_MainBody_RightPane_Existence_14_ThenPasswordTextBoxLabelExists()
        {
            AccountSignupPage accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                .Open();

            Verify.IsTrue(accountSignupPage.PasswordLabelExists, "Password text box label is not present on the page");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_SignUp_Objects_MainBody_RightPane_Existence"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody_RightPane"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody"), TestCategory("COLLECT_Account_SignUp_Objects"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_SignUp_Objects_MainBody_RightPane_Existence_15_ThenShowPasswordButtonExists()
        {
            AccountSignupPage accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                .Open();

            Verify.IsTrue(accountSignupPage.ShowPasswordButtonExists, "Show password button is not present on the page");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_SignUp_Objects_MainBody_RightPane_Existence"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody_RightPane"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody"), TestCategory("COLLECT_Account_SignUp_Objects"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_SignUp_Objects_MainBody_RightPane_Existence_16_ThenMinimumCharacterExists()
        {
            AccountSignupPage accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                .Open();

            Verify.IsTrue(accountSignupPage.PasswordCharacterLimitTextExists, "Password character limit text is not present on the page");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_SignUp_Objects_MainBody_RightPane_Existence"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody_RightPane"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody"), TestCategory("COLLECT_Account_SignUp_Objects"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_SignUp_Objects_MainBody_RightPane_Existence_17_ThenFreeTrialButtonExists()
        {
            AccountSignupPage accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                .Open();

            Verify.IsTrue(accountSignupPage.TrialForFreeButtonExists, "Start your free trial button is not present on the page");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_SignUp_Objects_MainBody_RightPane_Existence"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody_RightPane"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody"), TestCategory("COLLECT_Account_SignUp_Objects"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_SignUp_Objects_MainBody_RightPane_Existence_18_ThenStartYourFreeTrialTextExists()
        {
            AccountSignupPage accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                .Open();

            Verify.IsTrue(accountSignupPage.FreeTrialTextExists, "Start your free trial text is not present on the page");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_SignUp_Objects_MainBody_RightPane_Existence"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody_RightPane"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody"), TestCategory("COLLECT_Account_SignUp_Objects"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_SignUp_Objects_MainBody_RightPane_Existence_19_ThenTermsOfServiceLinkExists()
        {
            AccountSignupPage accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                .Open();

            Verify.IsTrue(accountSignupPage.TermsOfServiceLinkExists, "Terms of Service link is not present on the page");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_SignUp_Objects_MainBody_RightPane_Existence"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody_RightPane"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody"), TestCategory("COLLECT_Account_SignUp_Objects"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_SignUp_Objects_MainBody_RightPane_Existence_20_ThenPrivacyPolicyLinkExists()
        {
            AccountSignupPage accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                .Open();

            Verify.IsTrue(accountSignupPage.PrivatePolicyLinkExists, "Privacy policy link is not present on the page");
        }

        #endregion Main Body RightPane Objects Existence

        #region region Main Body RightPane Objects Text Is Correct

        [TestMethod]
        [TestCategory("COLLECT_Account_SignUp_Objects_MainBody_RightPane_TextVerification"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody_RightPane"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody"), TestCategory("COLLECT_Account_SignUp_Objects"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_SignUp_Objects_MainBody_RightPane_TextVerification_01_ThenGoogleSignInButtonTextIsCorrect()
        {
            AccountSignupPage accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                .Open();

            Verify.VerifyFieldUsingConst(accountSignupPage.GoogleSignInButtonText, "Sign in with Google",
                "The google sign in button text actual value did not match with the expected value.");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_SignUp_Objects_MainBody_RightPane_TextVerification"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody_RightPane"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody"), TestCategory("COLLECT_Account_SignUp_Objects"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_SignUp_Objects_MainBody_RightPane_TextVerification_02_ThenUserNameLabelTextIsCorrect()
        {
            AccountSignupPage accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                .Open();

            Verify.VerifyFieldUsingConst(accountSignupPage.UserNameText, "Your Full Name *",
                "The user name text actual value did not match with the expected value.");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_SignUp_Objects_MainBody_RightPane_TextVerification"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody_RightPane"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody"), TestCategory("COLLECT_Account_SignUp_Objects"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_SignUp_Objects_MainBody_RightPane_TextVerification_03_ThenOrganizationNameLabelTextIsCorrect()
        {
            AccountSignupPage accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                .Open();

            Verify.VerifyFieldUsingConst(accountSignupPage.OrganizationNameText, "Organization Name or Individual *",
                "The organization name text actual value did not match with the expected value.");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_SignUp_Objects_MainBody_RightPane_TextVerification"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody_RightPane"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody"), TestCategory("COLLECT_Account_SignUp_Objects"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_SignUp_Objects_MainBody_RightPane_TextVerification_04_ThenPhoneNumberLabelTextIsCorrect()
        {
            AccountSignupPage accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                .Open();

            Verify.VerifyFieldUsingConst(accountSignupPage.PhoneNumberText, "Phone Number *",
                "The phone number name text actual value did not match with the expected value.");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_SignUp_Objects_MainBody_RightPane_TextVerification"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody_RightPane"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody"), TestCategory("COLLECT_Account_SignUp_Objects"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_SignUp_Objects_MainBody_RightPane_TextVerification_05_ThenEmailLabelTextIsCorrect()
        {
            AccountSignupPage accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                .Open();

            Verify.VerifyFieldUsingConst(accountSignupPage.EmailText, "Email *",
                "The email text actual value did not match with the expected value.");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_SignUp_Objects_MainBody_RightPane_TextVerification"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody_RightPane"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody"), TestCategory("COLLECT_Account_SignUp_Objects"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_SignUp_Objects_MainBody_RightPane_TextVerification_06_ThenPasswordLabelTextIsCorrect()
        {
            AccountSignupPage accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                .Open();

            Verify.VerifyFieldUsingConst(accountSignupPage.PasswordText, "Set Password *",
                "The password text actual value did not match with the expected value.");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_SignUp_Objects_MainBody_RightPane_TextVerification"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody_RightPane"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody"), TestCategory("COLLECT_Account_SignUp_Objects"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_SignUp_Objects_MainBody_RightPane_TextVerification_07_ThenMinimumSixCharactersTextIsCorrect()
        {
            AccountSignupPage accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                .Open();

            Verify.VerifyFieldUsingConst(accountSignupPage.MinimumSixCharactersLimitText, "Minimum 6 characters",
                "The six characters limit text actual value did not match with the expected value.");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_SignUp_Objects_MainBody_RightPane_TextVerification"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody_RightPane"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody"), TestCategory("COLLECT_Account_SignUp_Objects"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_SignUp_Objects_MainBody_RightPane_TextVerification_08_ThenFreeTrialButtonTextIsCorrect()
        {
            AccountSignupPage accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                .Open();

            Verify.VerifyFieldUsingConst(accountSignupPage.FreeTrialButtonText, "Start your free trial",
                "The free trial button text actual value did not match with the expected value.");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_SignUp_Objects_MainBody_RightPane_TextVerification"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody_RightPane"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody"), TestCategory("COLLECT_Account_SignUp_Objects"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_SignUp_Objects_MainBody_RightPane_TextVerification_09_ThenTermsOfServiceLinkTextIsCorrect()
        {
            AccountSignupPage accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                .Open();

            Verify.VerifyFieldUsingConst(accountSignupPage.TermsOfServiceLinkText, "Terms of Service",
                "The terms of service link text actual value did not match with the expected value.");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_SignUp_Objects_MainBody_RightPane_TextVerification"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody_RightPane"), TestCategory("COLLECT_Account_SignUp_Objects_MainBody"), TestCategory("COLLECT_Account_SignUp_Objects"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_SignUp_Objects_MainBody_RightPane_TextVerification_10_ThenPrivacyPolicyLinkTextIsCorrect()
        {
            AccountSignupPage accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                .Open();

            Verify.VerifyFieldUsingConst(accountSignupPage.PrivacyPolicyLinkText, "Privacy Policy",
                "The privacy policy link text actual value did not match with the expected value.");
        }

        #endregion region Main Body RightPane Objects Text Is Correct

        #region Footer Objects Existence

        [TestMethod]
        [TestCategory("COLLECT_Account_SignUp_Objects_Footer_Existence"), TestCategory("COLLECT_Account_SignUp_Objects_Footer"), TestCategory("COLLECT_Account_SignUp_Objects"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_SignUp_Objects_Footer_Existence_01_ThenAlreadyHaveAnAccountTextExists()
        {
            AccountSignupPage accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                .Open();

            Verify.IsTrue(accountSignupPage.AlreadyMemberTextExists, "Already have an account text is not present on the page");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_SignUp_Objects_Footer_Existence"), TestCategory("COLLECT_Account_SignUp_Objects_Footer"), TestCategory("COLLECT_Account_SignUp_Objects"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_SignUp_Objects_Footer_Existence_02_ThenLoginLinkExists()
        {
            AccountSignupPage accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                .Open();

            Verify.IsTrue(accountSignupPage.LoginLinkExists, "Login Link is not present on the page");
        }

        #endregion Footer Objects Existence

        #region Footer Objects Text Is Correct

        [TestMethod]
        [TestCategory("COLLECT_Account_SignUp_Objects_Footer_TextVerification"), TestCategory("COLLECT_Account_SignUp_Objects_Footer"), TestCategory("COLLECT_Account_SignUp_Objects"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_SignUp_Objects_Footer_TextVerification_01_ThenAlreadyHaveAnAccountTextIsCorrect()
        {
            AccountSignupPage accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                .Open();

            Verify.VerifyFieldUsingConst(accountSignupPage.AlreadyHaveAnAccountText, "Already have an account?",
                "The already have an account text actual value did not match with the expected value.");
        }

        [TestMethod]
        [TestCategory("COLLECT_Account_SignUp_Objects_Footer_TextVerification"), TestCategory("COLLECT_Account_SignUp_Objects_Footer"), TestCategory("COLLECT_Account_SignUp_Objects"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_SignUp_Objects_Footer_TextVerification_02_ThenLoginLinkTextIsCorrect()
        {
            AccountSignupPage accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                .Open();

            Verify.VerifyFieldUsingConst(accountSignupPage.LoginLinkText, "Log in",
                "The Login link text actual value did not match with the expected value.");
        }

        #endregion Footer Objects Text Is Correct

        #region SideBar Objects Existence

        [TestMethod]
        [TestCategory("COLLECT_Account_SignUp_Objects_SideBar_Existence"), TestCategory("COLLECT_Account_SignUp_Objects_SideBar"), TestCategory("COLLECT_Account_SignUp_Objects"), TestCategory("COLLECT_Account_SignUp"), TestCategory("COLLECT_Account"), TestCategory("COLLECT_Regression")]

        public void COLLECT_Account_SignUp_Objects_SideBar_Existence_01_ThenChatIconExists()
        {
            AccountSignupPage accountSignupPage = new AccountSignupPage(Driver);
            accountSignupPage
                .Open()
                .WaitToRenderAnElement();

            Verify.IsTrue(accountSignupPage.ChatIconExists, "Chat Icon is not present on the page");
        }

        #endregion SideBar Objects Existence

        #endregion objects


    }
}
