using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using OpenQA.Selenium.Appium.Windows;
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
            BaseTest.GetDriver();
        }

        [Test(Author = "Igor_Kadach")]
        [Category("Login")]
        [Description("LoginTest")]
        [AllureTag("NUnit", "Debug")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureFeature("Core")]
        public void LoginTest()
        {
            _loginViewer.EnterPassword();

            var actualResult = _checkUserPreferences.CheckUser();
            var expectedResult = true;

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}