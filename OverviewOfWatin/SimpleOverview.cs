using NUnit.Framework;
using WatiN.Core;

namespace OverviewOfWatin
{
    [TestFixture]
    public class SimpleOverview
    {
        [Test]
        public void WatinOverview()
        {
            using (var ie = new IE())
            {
                ie.BringToFrontForDemo();
                ie.AutoClose = false;

                // Navigate
                ie.GoTo("http://localhost:62988/Register.aspx");

                // Finding a HTML element by id
                var passwordTextBox = ie.TextField(Find.ById("Password"));

                // Typing text
                passwordTextBox.TypeText("Hello World");

                // Clicking a button
                ie.Button(Find.ById("DoRegister")).Click();
            }
        }
    }
}
