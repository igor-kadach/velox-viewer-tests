using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Support.UI;
using System.Drawing.Text;
using velox_viewer_tests.PageObjects;
using velox_viewer_tests.Utils;

namespace velox_viewer_tests.Tests
{
    [TestFixture]
    [AllureNUnit]

    public class Tests
    {
        private readonly WindowsDriver<WindowsElement> _veloxViewerSession;

        private LoginViewerPageObject _loginViewer;

        private WorklistPageObject _checkUserPreferences;

        public Tests()
        {
            _loginViewer = new LoginViewerPageObject();
            _checkUserPreferences = new WorklistPageObject();
        }

        [SetUp]
        public void Setup()
        {
            //  WindowsDriver<WindowsElement> _veloxViewerSession;

            BaseTest.GetDriver();

            //AppiumOptions desiredCapabilities = new AppiumOptions();
            //desiredCapabilities.AddAdditionalCapability("app", @"C:\Velox\Exe\VeloxViewer\current\VeloxViewer.exe");

            //_veloxViewerSession = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), desiredCapabilities);
            //_veloxViewerSession.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //if (_veloxViewerSession == null)
            //{
            //    Console.WriteLine("VeloxViewer is not started.");
            //    return;
            //}
        }

        [Test(Author = "Igor_Kadach")]
        [Category("Login")]
        [Description("LoginTest")]
        [AllureTag("NUnit", "Debug")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureFeature("Core")]
        public void LoginTest()
        {
           // var loginViewerPageObject = new LoginViewerPageObject();

            _loginViewer.EnterPassword();
            //_veloxViewerSession.is
            //         Thread.Sleep(8000);
            //  _veloxViewerSession.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);

            // var checkUserPreferences = new WorklistPageObject();
            //var Driver = new WindowsDriver<WindowsElement>();

          //  new WebDriverWait(_veloxViewerSession, TimeSpan.FromSeconds(15)).Until(ExpectedConditions.ElementToBeClickable(_checkUserPreferences._userPreferences));

         //    new WebDriverWait(_veloxViewerSession, TimeSpan.FromSeconds(15));

            var actualResult = _checkUserPreferences.CheckUser();
            var expectedResult = true;

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}