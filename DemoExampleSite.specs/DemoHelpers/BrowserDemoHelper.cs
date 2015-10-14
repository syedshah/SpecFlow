using WatiN.Core;
using WatiN.Core.Native.Windows;

namespace DemoExampleSite.specs.DemoHelpers
{
    internal static class BrowserDemoHelper
    {
        public static void BringToFrontForDemo(this Browser browser)
        {
            browser.ShowWindow(NativeMethods.WindowShowStyle.Minimize);
            browser.ShowWindow(NativeMethods.WindowShowStyle.Maximize);
        }
    }
}
