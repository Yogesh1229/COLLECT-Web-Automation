using OpenQA.Selenium;
using System;
using System.Linq;

namespace COLLECT_Automation.Extensions
{
    public static class WebDriverExtensions
    {
        public static bool IsElementPresent(this IWebDriver driver, By locatorKey)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(500);
            return driver.FindElements(locatorKey).Any();
        }
    }
}
