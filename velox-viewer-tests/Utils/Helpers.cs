using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace velox_viewer_tests.Utils
{
    public class Helpers : BaseTest
    {
        public Helpers() : base()
        {
        }

        public static void SwitchWindow()
        {
            if (_veloxViewerSession.CurrentWindowHandle != _veloxViewerSession.WindowHandles.Last())
            {
                _veloxViewerSession.SwitchTo().Window(_veloxViewerSession.WindowHandles.Last());
            }
        }
    }
}