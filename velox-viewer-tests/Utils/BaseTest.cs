using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;


namespace velox_viewer_tests.Utils
{
    public class BaseTest
    {
        public static WindowsDriver<WindowsElement> _veloxViewerSession;

        public static WindowsDriver<WindowsElement> GetDriver()
        {
            AppiumOptions desiredCapabilities = new AppiumOptions();
            desiredCapabilities.AddAdditionalCapability("app", @"C:\Velox\Exe\VeloxViewer\current\VeloxViewer.exe");

            _veloxViewerSession = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), desiredCapabilities);

            if (_veloxViewerSession == null)
            {
                Console.WriteLine("VeloxViewer is not started.");
                return null;
            }

            return _veloxViewerSession;
        }
    }
}