using COLLECTAutomation.Helpers;
using OpenQA.Selenium;

namespace COLLECTAutomation.TestSetup
{
    public abstract class TestCaseSetup
    {

        protected static IWebDriver Driver;
        protected static void TestFixtureSetup()
        {
            Driver = BrowserHelper.GetLocalBrowser();

        }

        public static void InitializeTest()
        {
            //Will need to add methods to get data from database in future
        }

        protected static void TestFixtureCleanup()
        {
            Driver.Quit();
        }
    }
}
