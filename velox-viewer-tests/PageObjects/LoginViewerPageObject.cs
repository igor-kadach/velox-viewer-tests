using OpenQA.Selenium.Appium.Windows;
using velox_viewer_tests.Utils;

namespace velox_viewer_tests
{
    public class LoginViewerPageObject : BaseTest
    {
        public LoginViewerPageObject() : base()
        {
        }

        public WindowsElement _passwordField => _veloxViewerSession.FindElementByAccessibilityId("pbPassword");
        public WindowsElement _buttonLogin => _veloxViewerSession.FindElementByAccessibilityId("btnLogin");


        public void EnterPassword()
        {
            Helpers.SwitchWindow();
            _passwordField.SendKeys("12345678Qq");
            _buttonLogin.Click();
        }
    }
}