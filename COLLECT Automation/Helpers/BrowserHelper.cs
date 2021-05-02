using COLLECTAutomation.Enums;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace COLLECTAutomation.Helpers
{
    public static class BrowserHelper
    {
        public static IWebDriver GetLocalBrowser(BrowserByTheNameOf browserName = BrowserByTheNameOf.Chrome, int implicitWaitTimeMilliseconds = 20000, bool maximizeWindow = true)
        {
            IWebDriver browser;

            switch (browserName)
            {
                case BrowserByTheNameOf.Chrome:
                    browser = new ChromeDriver();

                    break;

                default:
                    browser = new ChromeDriver();
                    break;

            }

            browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(implicitWaitTimeMilliseconds);
            if (maximizeWindow) browser.Manage().Window.Maximize();

            return browser;
        }
    }
}
