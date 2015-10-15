using System;
using TechTalk.SpecFlow;

namespace DemoExampleSite.specs
{
    using ImpromptuInterface.InvokeExt;

    using NUnit.Core;

    using TechTalk.SpecFlow.Assist;

    [Binding]
    public class DataTableSteps
    {
        private dynamic _instance;

        [When(@"I create a dynamic instance from this table")]
        public void CreateDynamicInstanceFromTable(Table table)
        {
            _instance = table.CreateDynamicInstance();
        }

        [Then(@"the Name property should equal '(.*)'")]
        public void NameShouldBe(string expectedValue)
        {
            NUnitFramework.Assert.AreEqual((string)_instance.Name, expectedValue);
        }
    }
}
