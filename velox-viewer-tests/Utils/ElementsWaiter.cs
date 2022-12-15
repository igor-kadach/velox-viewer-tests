using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Appium.Windows;
using System.Diagnostics;
using velox_viewer_tests.PageObjects;

namespace velox_viewer_tests.Utils
{
    public  class ElementsWaiter
    {
        public  WindowsDriver<WindowsElement> _veloxViewerSession;

        public  bool isWaitElement(string element, int timeout)
        {
            Stopwatch s = Stopwatch.StartNew();

            do
            {
                if (IsElementPresent(element))
                {
                    return true;
                }
                Thread.Sleep(500);
                s.Stop();
            }
            while (s.Elapsed.Seconds == timeout);

            return false;
        }

        public  bool IsElementPresent(string myElement)
        {
            Helpers.SwitchWindow();

       //    WindowsElement _userPreferences1 = _veloxViewerSession.FindElementByName(myElement);

            if (WorklistPageObject._userPreferences != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

















        // private static TimeSpan _elementTimeOut;

        //private static readonly WindowsDriver<WindowsElement> _veloxViewerSession;

        //public static void WaitElementToBeExist()
        //{

        // //   var Driver = new WindowsDriver<WindowsElement>();

        //    new WebDriverWait(_veloxViewerSession, TimeSpan.FromSeconds(30)).Until(d => d.FindElements(By.Name("someName")).Count > 0);
        //}

        //public static IWebElement WaitElementIsVisible(this By locator, IWebDriver driver, int timeout = 10)
        //{
        //    WebDriverWait wait = new WebDriverWait(WindowsDriver<WindowsElement>, TimeSpan.FromSeconds(10));
        //    wait.Until(ExpectedConditions.ElementExists(By.Id("id")));
        //}


    }
}