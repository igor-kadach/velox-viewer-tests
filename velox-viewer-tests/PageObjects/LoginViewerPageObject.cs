using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Interfaces;
using OpenQA.Selenium.Appium.PageObjects.Attributes;
using OpenQA.Selenium.Appium.PageObjects.Attributes.Abstract;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Internal;
using SeleniumExtras.PageObjects;
using velox_viewer_tests.Utils;

namespace velox_viewer_tests
{
    public class LoginViewerPageObject : BaseTest
    {

        public LoginViewerPageObject() : base()
        {
        }

        //public LoginViewerPageObject(WindowsDriver<WindowsElement> veloxViewerSession) => _veloxViewerSession = veloxViewerSession;
        //public LoginViewerPageObject(WindowsDriver<WindowsElement> _driver)
        //{
        //    PageFactory.InitElements(_driver, this);
        //}

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