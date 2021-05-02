using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace COLLECT_Automation.Model.AccountPages
{
    class ForgotPasswordPage : AbstractPage
    {
        private const string Url = "/forgot/";

        public ForgotPasswordPage(IWebDriver browser) : base(browser)
        {
        }

        #region Boolean Checks

        public bool AmIOnforgotPasswordPage => new Uri(Browser.Url).AbsolutePath == Url;



        #endregion Boolean Checks

        
    }
}
