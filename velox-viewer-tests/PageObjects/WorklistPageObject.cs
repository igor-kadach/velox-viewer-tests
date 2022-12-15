using OpenQA.Selenium.Appium.Windows;
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