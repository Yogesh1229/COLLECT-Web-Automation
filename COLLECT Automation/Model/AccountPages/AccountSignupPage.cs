using COLLECT_Automation.Extensions;
using COLLECT_Automation.Model.AccountPages;
using COLLECT_Automation.Model.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace COLLECT_Automation.Model.AccountSignupPages
{
    class AccountSignupPage : AbstractPage
    {
        public const string _signUpPageUrl = "/";
        public const string _termsOfServicePageUrl = "/assets/docs/eula-socialcops.pdf";
        public const string _privacyPolicyPageUrl = "/assets/docs/privacy-policy-socialcops.pdf";
        public const string _MobileDataCollectionAppUrl = "/collect/";

        //Left Pane Objects

        private readonly By _collectLogo = By.CssSelector(".row-eq-height.b-b.b-sc.p-y.p-x-md div img");
        private readonly By _sevenDayFreeTrial = By.CssSelector("._700.text-muted-08.p-b-xs.m-b-0.p-l");
        private readonly By _noCreditCardRequired = By.CssSelector("._600.text-muted.p-l.m-b-0");
        private readonly By _instantlyDataCollection = By.CssSelector("._700.m-b.text-muted-08");
        private readonly By _muchMore = By.PartialLinkText("much more");
        private readonly By _formCreationInAnyLanguage = By.XPath("//div[@class = 'col-xs-12 egister-icon-fix-width']/p[1]");
        private readonly By _collectDataWithoutInternet = By.XPath("//div[@class = 'col-xs-12 egister-icon-fix-width']/p[2]");
        private readonly By _dataAnalyze = By.XPath("//div[@class = 'col-xs-12 egister-icon-fix-width']/p[3]");
        private readonly By _otherUsersSay = By.CssSelector("._700.m-b-0.p-b.text-muted-08");
        private readonly By _carouselSlider = By.CssSelector(".carousel.slide.m-t-0.sc-light.p-x-md");
        private readonly By _carouselIndicators = By.CssSelector(".carousel-indicators");
        private readonly By _poweredByGoDaddyImage = By.XPath("//div[@class = 'col-xs-12 p-x-md m-t-md p-y-sm']/img[1]");
        private readonly By _cloudFlareImage = By.XPath("//div[@class = 'col-xs-12 p-x-md m-t-md p-y-sm']/img[2]");
        
        //Right Pane Objects

        private readonly By _googleSignInButton = By.CssSelector("#google-sign-up");
        private readonly By _userNameLabel = By.XPath("//label[@for = 'user-name']");
        private readonly By _userName = By.CssSelector("#user-name");
        private readonly By _organizationNameLabel = By.XPath("//label[@for = 'organization-name']");
        private readonly By _organizationName = By.CssSelector("#organization-name");
        private readonly By _indianFlag = By.CssSelector(".selected-flag div[class='iti-flag in']");
        private readonly By _countryCode = By.CssSelector(".selected-flag div[class='selected-dial-code']");
        private readonly By _countryCodeArrow = By.CssSelector(".selected-flag div[class='iti-arrow']");
        private readonly By _countryList = By.CssSelector("ul[aria-expanded='true'][id='country-listbox']");
        private readonly By _oneCountrySelected = By.CssSelector("ul[aria-expanded='true'][id='country-listbox'] li:nth-of-type(39)");
        private readonly By _verifyCountrySelection = By.CssSelector("div[class='selected-flag'][title='Canada: +1']");
        private readonly By _phoneNumberLabel = By.XPath("//label[@for = 'user-phone-number']");
        private readonly By _phoneNumber = By.CssSelector("#user-phone-number");
        private readonly By _emailLabel = By.XPath("//label[@for = 'user-email']");
        private readonly By _email = By.CssSelector("#user-email");
        private readonly By _passwordLabel = By.XPath("//label[@for = 'user-password']");
        private readonly By _password = By.CssSelector("#user-password");
        private readonly By _showPasswordButton = By.CssSelector("#button-show-password");
        private readonly By _passwordCharacterLimit = By.CssSelector("#password-character-limit");
        private readonly By _trialForFreeButton = By.CssSelector("#button-register");
        private readonly By _freeTrial = By.XPath("//p[@class = 'm-b-0 p-t pointer register-input-text-label']");
        private readonly By _termsOfService = By.XPath("//a[@href = '/assets/docs/eula-socialcops.pdf']");
        private readonly By _privatePolicy = By.XPath("//a[@href = '/assets/docs/privacy-policy-socialcops.pdf']");

        private readonly By _invalidEmailError = By.CssSelector("#error-user-email");

        //Footer Objects

        private readonly By _alreadyMember = By.XPath("//div[@id = 'wrapper-link-login']/div[1]/span");
        private readonly By _loginLink = By.XPath("//a[@href = '/login']");

        //SideBar Objects

        private readonly By _chatIcon = By.CssSelector(".chat-content i[class='icon-ic_chat_icon']");

        private readonly By _chooseAnAccount = By.CssSelector(".jXeDnc h1[class = 'y77zqe'] content");


        public AccountSignupPage(IWebDriver browser) : base(browser)
        {

        }

        #region BooleanChecks

        //Url

        public bool AmIOnAccountSignupPage => new Uri(Browser.Url).AbsolutePath == _signUpPageUrl;

        public bool AmIOnTermsOfServicePage => new Uri(Browser.Url).AbsolutePath == _termsOfServicePageUrl;

        public bool AmIOnPrivacyPolicyPage => new Uri(Browser.Url).AbsolutePath == _privacyPolicyPageUrl;

        public bool AmIOnMobileDataAppPage => new Uri(Browser.Url).AbsolutePath == _MobileDataCollectionAppUrl;



        //Main Body Left Pain

        public bool CollectLogoExists => Browser.IsElementPresent(_collectLogo);

        public bool SevenDayFreeTrialTextExists => Browser.IsElementPresent(_sevenDayFreeTrial);

        public bool NoCreditCardRequiredTextExists => Browser.IsElementPresent(_noCreditCardRequired);

        public bool InstantDataCollectionTextExists => Browser.IsElementPresent(_instantlyDataCollection);

        public bool FormCreationInAnyLanuageTextExists => Browser.IsElementPresent(_formCreationInAnyLanguage);

        public bool collectDataWithoutInternetTextExists => Browser.IsElementPresent(_collectDataWithoutInternet);

        public bool DataAnalyzationTextExists => Browser.IsElementPresent(_dataAnalyze);

        public bool WhatOtherUsersSayTextExists => Browser.IsElementPresent(_otherUsersSay);

        public bool UserCommentsSlider => Browser.IsElementPresent(_carouselSlider);

        public bool CarouselIndicatorsExists => Browser.IsElementPresent(_carouselIndicators);

        public bool PoweredByGoDaddyImageExists => Browser.IsElementPresent(_poweredByGoDaddyImage);

        public bool CloudFlareImageExists => Browser.IsElementPresent(_cloudFlareImage);

        //Main Body Right Pain

        public bool GoogleSignInButtonExists => Browser.IsElementPresent(_googleSignInButton);

        public bool UserNameLabelExists => Browser.IsElementPresent(_userNameLabel);

        public bool UserNameTextExists => Browser.IsElementPresent(_userName);

        public bool OrganizationNameLabelExists => Browser.IsElementPresent(_organizationNameLabel);

        public bool OrganizationNameTextExists => Browser.IsElementPresent(_organizationName);

        public bool IndianFlagExists => Browser.IsElementPresent(_indianFlag);

        public bool CountryCodeExists => Browser.IsElementPresent(_countryCode);

        public bool CountryCodeDropDownButtonExists => Browser.IsElementPresent(_countryCodeArrow);

        public bool CountryListExists => Browser.IsElementPresent(_countryList);

        public bool DidUserAbleToSelectOneCountry => Browser.IsElementPresent(_verifyCountrySelection);

        public bool PhoneNumberLabelExists => Browser.IsElementPresent(_phoneNumberLabel);

        public bool PhoneNumberTextExists => Browser.IsElementPresent(_phoneNumber);

        public bool EmailLabelExists => Browser.IsElementPresent(_emailLabel);

        public bool EmailTextExists => Browser.IsElementPresent(_email);

        public bool PasswordLabelExists => Browser.IsElementPresent(_passwordLabel);

        public bool PasswordTextExists => Browser.IsElementPresent(_password);

        public bool ShowPasswordButtonExists => Browser.IsElementPresent(_showPasswordButton);

        public bool PasswordCharacterLimitTextExists => Browser.IsElementPresent(_passwordCharacterLimit);

        public bool TrialForFreeButtonExists => Browser.IsElementPresent(_trialForFreeButton);

        public bool FreeTrialTextExists => Browser.IsElementPresent(_freeTrial);

        public bool TermsOfServiceLinkExists => Browser.IsElementPresent(_termsOfService);

        public bool PrivatePolicyLinkExists => Browser.IsElementPresent(_privatePolicy);

        //Footer

        public bool AlreadyMemberTextExists => Browser.IsElementPresent(_alreadyMember);

        public bool LoginLinkExists => Browser.IsElementPresent(_loginLink);

        //SideBar

        public bool ChatIconExists => Browser.IsElementPresent(_chatIcon);

        public bool ChooseAnAccountTextExists => Browser.IsElementPresent(_chooseAnAccount);
  
        #endregion BooleanChecks

        #region Gets

        //Main Body Left Pane

        public string CollectLogoSrcIsCorrect => SrcLocationOfImageElement(Browser.FindElement(_collectLogo));

        public string CollectLogoAltTextIsCorrect => AltTagOfImageElement(Browser.FindElement(_collectLogo));

        public string PoweredByGoDaddySrcIsCorrect => SrcLocationOfImageElement(Browser.FindElement(_poweredByGoDaddyImage));

        public string PoweredByGoDaddyAltTextIsCorrect => AltTagOfImageElement(Browser.FindElement(_poweredByGoDaddyImage));

        public string CloudFareSrcIsCorrect => SrcLocationOfImageElement(Browser.FindElement(_cloudFlareImage));

        public string CloudFareAltTextIsCorrect => AltTagOfImageElement(Browser.FindElement(_cloudFlareImage));

        public string SevenDayFreeTrialText => Browser.FindElement(_sevenDayFreeTrial).Text;

        public string NoCreditCardRequiredText => Browser.FindElement(_noCreditCardRequired).Text;

        public string InstantDataCollectionText => Browser.FindElement(_instantlyDataCollection).Text;

        public string FormCreationInAnyLanuageText => Browser.FindElement(_formCreationInAnyLanguage).Text;

        public string collectDataWithoutInternetText => Browser.FindElement(_collectDataWithoutInternet).Text;

        public string DataAnalyzationText => Browser.FindElement(_dataAnalyze).Text;

        public string WhatOtherUsersSayText => Browser.FindElement(_otherUsersSay).Text;

        //Main Body Right Pane

        public string GoogleSignInButtonText => Browser.FindElement(_googleSignInButton).Text;

        public string UserNameText => Browser.FindElement(_userNameLabel).Text;

        public string OrganizationNameText => Browser.FindElement(_organizationNameLabel).Text;

        public string PhoneNumberText => Browser.FindElement(_phoneNumberLabel).Text;

        public string EmailText => Browser.FindElement(_emailLabel).Text;

        public string InvalidEmailErrorText => Browser.FindElement(_invalidEmailError).Text;

        public string PasswordText => Browser.FindElement(_passwordLabel).Text;

        public string MinimumSixCharactersLimitText => Browser.FindElement(_passwordCharacterLimit).Text;

        public string FreeTrialButtonText => Browser.FindElement(_trialForFreeButton).Text;

        public string TermsOfServiceLinkText => Browser.FindElement(_termsOfService).Text;

        public string PrivacyPolicyLinkText => Browser.FindElement(_privatePolicy).Text;

        //Footer Objects

        public string AlreadyHaveAnAccountText => Browser.FindElement(_alreadyMember).Text;

        public string LoginLinkText => Browser.FindElement(_loginLink).Text;


        #endregion Gets

        #region Actions

        public AccountSignupPage SendUserName(string userName = "")
        {
            var userNameField = Browser.FindElement(_userName);
            userNameField.SendKeys(userName);
            return this;
        }

        public AccountSignupPage SendOrganizationName(string organizationName = "")
        {
            var organizationNameField = Browser.FindElement(_organizationName);
            organizationNameField.SendKeys(organizationName);
            return this;
        }

        //public AccountSignupPage SendCountry(string country = "")
        //{
        //    var countryToSelect = country;
        //    if(country == "India")
        //        return this;
        //    else
        //    {
        //        var countryCodeField = Browser.FindElement(_countryCode);
        //        countryCodeField.Click();

        //    }
            
        //    return this;
        //}

        public AccountSignupPage SendPhoneNumber(string phoneNumber = "")
        {
            var phoneNumberField = Browser.FindElement(_phoneNumber);
            phoneNumberField.SendKeys(phoneNumber);
            return this;
        }

        public AccountSignupPage SendEmail(string email = "")
        {
            var emailField = Browser.FindElement(_email);
            emailField.SendKeys(email);
            return this;
        }

        public AccountSignupPage SendPassword(string password = "")
        {
            var passwordField = Browser.FindElement(_password);
            passwordField.SendKeys(password);
            return this;
        }

        public void ClickStartYourFreeTrialButton()
        {
            var freeTrialButton = Browser.FindElement(_trialForFreeButton);
            freeTrialButton.Click();
        }

        public AccountSignupPage Open()
        {
            base.Open(_signUpPageUrl);
            return this;
        }

        public AccountSignupPage ClickOnGoogleSignButton()
        {
            var googleSignInButton = Browser.FindElement(_googleSignInButton);
            googleSignInButton.Click();
            return this;
        }

        public AccountSignupPage ClickOnTermsOfServiceLink()
        {
            var termsOfServiceLink = Browser.FindElement(_termsOfService);
            termsOfServiceLink.Click();
            return this;
        }

        public AccountSignupPage ClickOnPrivacyPolicyLink()
        {
            var privacyPolicyLink = Browser.FindElement(_privatePolicy);
            privacyPolicyLink.Click();
            return this;
        }

        public AccountLoginPage ClickOnLoginLink()
        {
            var loginLink = Browser.FindElement(_loginLink);
            loginLink.Click();
            return new AccountLoginPage(Browser);
        }

        public AccountSignupPage ClickOnMuchMoreHyperLink()
        {
            var muchMoreHyperLink = Browser.FindElement(_muchMore);
            muchMoreHyperLink.Click();
            SwitchToNewWindow();
            return this;
        }

        public AccountSignupPage ClickOnCountryCodeButton()
        {
            var countryCodeButton = Browser.FindElement(_countryCode);
            countryCodeButton.Click();

            return this;
        }

        public AccountSignupPage SelectOneCountry()
        {
            var oneCountrySelected = Browser.FindElement(_oneCountrySelected);
            oneCountrySelected.Click();

            return this;
        }

        public AccountSignupPage SwitchToNewTab()
        {
            SwitchToNewWindow();
            return this;

        }

        public AccountSignupPage WaitToRenderAnElement(int WaitTimeMilliseconds = 5000)
        {
            ImplicitWaitToRenderAnElement(WaitTimeMilliseconds);
            return this;

        }

        //public CreateFormPage SignUp
        //    (
        //    string username = "AutomationTester", string organizationName = "TestingCompany", 
        //    string country = "Canada", string phoneNmber = "1234567890", string email = "AutomationTesting@testing.com",
        //    string password = "testpass"
        //    )
        //{
        //    Open()
        //        .SendUserName(username)
        //        .SendOrganizationName(organizationName)
        //        .SendPhoneNumber(phoneNmber)
        //        .SendEmail(email)
        //        .SendPassword(password)
        //        .ClickStartYourFreeTrialButton();

        //    return new CreateFormPage(Browser);
        //}

        public CreateFormPage SignUp
            (
                string username = "", string organizationName = "",
    string country = "", string phoneNmber = "", string email = "",
    string password = ""
    )
        {
            Open()
                .SendUserName(username)
                .SendOrganizationName(organizationName)
                .SendPhoneNumber(phoneNmber)
                .SendEmail(email)
                .SendPassword(password)
                .ClickStartYourFreeTrialButton();

            return new CreateFormPage(Browser);
        }



        #endregion Actions

    }
}
