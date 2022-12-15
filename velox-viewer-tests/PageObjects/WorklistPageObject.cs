using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Html5;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using velox_viewer_tests.Utils;

namespace velox_viewer_tests.PageObjects
{
    public class WorklistPageObject : BaseTest
    {
        public WorklistPageObject() : base()
        {
        }

        public WindowsElement _userPreferences => _veloxViewerSession.FindElementByName("Igor Kadach (ytest.KadacI)");




        public bool CheckUser()
        {
            Helpers.SwitchWindow();
            ElementsWaiter.isWaitElement("Igor Kadach (ytest.KadacI)", 10);
            var isUserNameAppeares = _userPreferences.Displayed;
            return isUserNameAppeares;
        }




    }
}