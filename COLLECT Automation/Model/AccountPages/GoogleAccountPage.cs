using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System.Net.Sockets;

namespace COLLECT_Automation.Model.AccountPages
{
    class GoogleAccountPage : AbstractPage
    {
        public const string newWindowURL = "/signin/oauth/identifier";

        #region BooleanChecks

        public bool AmIOnGoogleAccountPage => new Uri(Browser.Url).AbsolutePath == newWindowURL;
        //public bool AmIOnGoogleAccountPage => Browser.Url.Contains(newWindowURL);

        #endregion BooleanChecks

        public GoogleAccountPage(IWebDriver browser) : base(browser)
        {

        }

        public GoogleAccountPage SwitchToNewGoogleWindow()
        {
            SwitchToNewWindow();
            return this;
        }

        
    }
}
