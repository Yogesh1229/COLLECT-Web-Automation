using OpenQA.Selenium;
using System;

namespace COLLECT_Automation.Model.Forms

{
    class CreateFormPage : AbstractPage
    {
        private const string Url = "/create/";
        public CreateFormPage(IWebDriver browser) : base(browser)
        {

        }

        #region BooleanChecks

        public bool AmIOnCreateFormPage => new Uri(Browser.Url).AbsolutePath == Url;


        #endregion BooleanChecks
    }
}
