using TechTalk.SpecFlow;

namespace DemoExampleSite.specs
{
    [Binding]
    internal class ScenarioBeforeAndAfter
    {
        [BeforeScenario]
        public static void Before()
        {
            // Runs before each scenario and scenario outline example          
        }

        [AfterScenario]
        public static void After()
        {
            WebBrowser.Current.Dispose();
        }
    }
}
