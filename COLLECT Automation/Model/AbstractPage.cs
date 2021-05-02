using OpenQA.Selenium;
using System;
using System.Configuration;

namespace COLLECT_Automation.Model
{
    public abstract class AbstractPage
    {
        protected readonly IWebDriver Browser;

        protected AbstractPage(IWebDriver browser)
        {
            Browser = browser;
        }

        private string BaseUrl = ConfigurationManager.AppSettings["URL"].ToString();
        public virtual void Open(string relativeUrl)
        {
            Browser.Url = BaseUrl + relativeUrl;
            Browser.Manage().Window.Maximize();
        }

        public string SrcLocationOfImageElement(IWebElement element)
        {
            // All we need to find is the Attribute Tag of: 'src'
            return element.GetAttribute("src");
        }

        public string AltTagOfImageElement(IWebElement element)
        {
            // All we need to find is the Attribute Tag of: 'alt'
            return element.GetAttribute("alt");
        }

        public void SwitchToNewWindow()
        {
            var winHandles = Browser.WindowHandles;
            string firstWinHandle = Browser.CurrentWindowHandle;
            foreach (var handle in winHandles)
            {
                if (handle != firstWinHandle)
                {
                    Browser.SwitchTo().Window(handle);
                }
            }
        }

        public void ImplicitWaitToRenderAnElement(int implicitWaitTimeMilliseconds = 5000)
        {
            Browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(implicitWaitTimeMilliseconds);
        }

    }
}
