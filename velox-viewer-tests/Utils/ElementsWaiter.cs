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

           WindowsElement _userPreferences1 = _veloxViewerSession.FindElementByName(myElement);

            if (WorklistPageObject._userPreferences != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}