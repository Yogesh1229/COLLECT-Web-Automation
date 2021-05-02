using System;
using COLLECT_Automation.Extensions;
using COLLECT_Automation.Model.AccountSignupPages;
using COLLECT_Automation.Model.Forms;
using OpenQA.Selenium;

namespace COLLECT_Automation.Model.AccountPages
{
    class AccountLoginPage : AbstractPage
    {
        public const string Url = "/login/";

        private readonly By _leftBlockWrapper = By.Id("left-block-wrapper");
        private readonly By _collectLogo = By.Id("collect-logo");
        private readonly By _welcomeBack = By.CssSelector(".text-center._400.text-website.m-b-md");
        private readonly By _oRText = By.XPath("//hr[@class = 'style-or white text m-t-md text-muted']");
        private readonly By _googleSignInButton = By.Id("google-sign-in");
        private readonly By _enterYourEmailLabel = By.CssSelector("label[for = 'email']");
        private readonly By _enterYourEmail = By.Id("email");
        private readonly By _enterYourPasswordLabel = By.CssSelector("label[for = 'password']");
        private readonly By _enterYourPassword = By.Id("password");
        private readonly By _showPasswordButton = By.CssSelector("#button-show-password");
        private readonly By _forgotYourPassword = By.Id("forgot-password");
        private readonly By _loginButton = By.Id("login-button");
        private readonly By _doNotHaveAnAccount = By.CssSelector("div[class$='text-muted-08 text-center'] span");
        private readonly By _signUp = By.Id("signup");

        //SideBar Objects

        private readonly By _chatIcon = By.CssSelector(".chat-content i[class='icon-ic_chat_icon']");

        public AccountLoginPage(IWebDriver browser) : base(browser)
        {

        }

        #region BooleanChecks

        public bool AmIOnAccountLoginPage => new Uri(Browser.Url).AbsolutePath == Url;

        public bool LeftBlockWrapperExists => Browser.IsElementPresent(_leftBlockWrapper);

        public bool CollectLogoExists => Browser.IsElementPresent(_collectLogo);

        public bool WelcomeBackTextExists => Browser.IsElementPresent(_welcomeBack);

        public bool ORTextExists => Browser.IsElementPresent(_oRText);

        public bool GoogleSignInButtonExists => Browser.IsElementPresent(_googleSignInButton);

        public bool EnterYourEmailLabelExists => Browser.IsElementPresent(_enterYourEmailLabel);

        public bool EmailTextExists => Browser.IsElementPresent(_enterYourEmail);

        public bool EnterYourPasswordLabelExists => Browser.IsElementPresent(_enterYourPasswordLabel);

        public bool PasswordTextExists => Browser.IsElementPresent(_enterYourPassword);

        public bool ShowPasswordButtonExists => Browser.IsElementPresent(_showPasswordButton);

        public bool ForgotYourPasswordLinkExists => Browser.IsElementPresent(_forgotYourPassword);

        public bool LoginButtonExists => Browser.IsElementPresent(_loginButton);

        public bool DoNotHaveAnAccountTextExists => Browser.IsElementPresent(_doNotHaveAnAccount);

        public bool SignUpLinkExists => Browser.IsElementPresent(_signUp);

        //SideBar

        public bool ChatIconExists => Browser.IsElementPresent(_chatIcon);

        #endregion BooleanChecks

        #region Gets

        public string CollectLogoSrcIsCorrect => SrcLocationOfImageElement(Browser.FindElement(_collectLogo));

        public string CollectLogoAltTextIsCorrect => AltTagOfImageElement(Browser.FindElement(_collectLogo));

        public string WelcomeBackTextIsCorrect => Browser.FindElement(_welcomeBack).Text;

        public string EnterYourEmailLabelIsCorrect => Browser.FindElement(_enterYourEmailLabel).Text;

        public string EnterYourPasswordLabelIsCorrect => Browser.FindElement(_enterYourPasswordLabel).Text;

        public string DonNotHaveAnAccountTextIsCorrect => Browser.FindElement(_doNotHaveAnAccount).Text;

        #endregion Gets

        #region Actions

        public AccountLoginPage Open()
        {
            base.Open(Url);
            return this;
        }

        public CreateFormPage SignInFully(string userName = "", string password = "")
        {
            Open()
                .SendUserId(userName)
                .SendPassword(password)
                .ClickSignIn();

            return new CreateFormPage(Browser);
        }

        public AccountLoginPage SendUserId(string userName = "")
        {
            var emailField = Browser.FindElement(_enterYourEmail);
            emailField.SendKeys(userName);
            return this;
        }

        public AccountLoginPage SendPassword(string password = "")
        {
            var passwordField = Browser.FindElement(_enterYourPassword);
            passwordField.SendKeys(password);
            return this;
        }

        public void ClickSignIn()
        {
            var logOnButton = Browser.FindElement(_loginButton);
            logOnButton.Click();
        }

        public AccountLoginPage WaitToRenderAnElement(int WaitTimeMilliseconds = 5000)
        {
            ImplicitWaitToRenderAnElement(WaitTimeMilliseconds);
            return this;

        }

        public ForgotPasswordPage ClickOnForgotPasswordLink()
        {
            var forgotPasswordLink = Browser.FindElement(_forgotYourPassword);
            forgotPasswordLink.Click();

            return new ForgotPasswordPage(Browser);
        }

        public AccountSignupPage ClickOnSignupLink()
        {
            var signupLink = Browser.FindElement(_signUp);
            signupLink.Click();

            return new AccountSignupPage(Browser);
        }

        #endregion Actions
    }
}
