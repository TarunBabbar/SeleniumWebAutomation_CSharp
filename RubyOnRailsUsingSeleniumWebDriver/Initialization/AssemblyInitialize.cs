using Microsoft.VisualStudio.TestTools.UnitTesting;
using RubyOnRailsUsingSeleniumWebDriver.SeleniumWebDriver;

namespace RubyOnRailsUsingSeleniumWebDriver.Initialization
{
    [TestClass]
    public class AssemblySetUp
    {
        public static string DeploymentDirectory;
        protected static TestContext TestContext;
        protected static WebDriver SeleniumDriver = new WebDriver();

        [AssemblyInitialize]
        public static void Setup(TestContext testContext)
        {
            DeploymentDirectory = testContext.DeploymentDirectory;
            TestContext = testContext;
        }

        [TestInitialize]
        public void TestInitialize()
        {
            SeleniumDriver.LaunchBrowser(Browsers.Chrome);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            SeleniumDriver.QuitAndCloseWebDriver();
        }
    }
}
