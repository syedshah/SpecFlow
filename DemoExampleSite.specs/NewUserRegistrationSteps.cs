using System;
using System.Linq;
using TechTalk.SpecFlow;
using WatiN.Core;
using NUnit.Framework;

namespace DemoExampleSite.specs
{
    using System.Collections;
    using System.Collections.Generic;

    using TechTalk.SpecFlow.Assist;

    using Table = TechTalk.SpecFlow.Table;

    [Binding]
    public class NewUserRegistrationSteps
    {
        private dynamic _instance;

        [When]
        public void When_I_enter_a_password_of_PASSWORD(string password)
        {
            var p = WebBrowser.Current.Page<RegistrationPage>();

            p.Password = password;

            // WebBrowser.Current.TextField(Find.ById("Password")).TypeText(password);

            // WebBrowser.Current.Eval("$('#Password').keypress()");
        }

        [Then]
        public void Then_the_password_strength_indicator_should_read_STRENGTH(string strength)
        {
            var p = WebBrowser.Current.Page<RegistrationPage>();

            var actualStrength = p.PasswordStrength;


            // var actualStrength = WebBrowser.Current.Div(Find.ById("PasswordStrength")).InnerHtml;

            Assert.AreEqual(strength, actualStrength);            
        }




        [When]
        public void When_I_enter_valid_new_user_details()
        {
            string rndUserName = Guid.NewGuid().ToString().Substring(0, 10);

            var p = WebBrowser.Current.Page<RegistrationPage>();

            p.UserName = rndUserName;
            p.EmailAddress = "mrawesome@jndksadj.com";
            p.Password = "password";
            p.ConfirmPassword = "password";

            // WebBrowser.Current.TextField(Find.ById("UserName")).TypeText(rndUserName);
            // WebBrowser.Current.TextField(Find.ById("EmailAddress")).TypeText("mrawesome@jndksadj.com");
            // WebBrowser.Current.TextField(Find.ById("Password")).TypeText("password");
            // WebBrowser.Current.TextField(Find.ById("ConfirmPassword")).TypeText("password");
        }

        [When]
        public void When_the_user_name_NAME_is_already_taken(string name)
        {
            TestData.CreateUser(name);

            var p = WebBrowser.Current.Page<RegistrationPage>();

            p.UserName = name;

            // WebBrowser.Current.TextField(Find.ById("UserName")).TypeText(name);
        }

        [When]
        public void When_I_try_to_proceed_with_registration()
        {
            var p = WebBrowser.Current.Page<RegistrationPage>();

            p.ClickRegisterButton();

            // WebBrowser.Current.Button(Find.ById("DoRegister")).Click();
        }

        [Then]
        public void Then_I_should_see_an_error_MESSAGE(string message)
        {
            var p = WebBrowser.Current.Page<RegistrationPage>();

            var isMessageDisplayed = p.ValidationErrorListText.Contains(message);

            // var isMessageDisplayed = WebBrowser.Current
            //    .List(Find.ById("ValidationErrorList"))
            //    .Text.Contains(message);

            Assert.IsTrue(isMessageDisplayed, message + " not found in validation errors");
        }

        [When]
        public void When_I_have_not_enter_email_address()
        {
            var p = WebBrowser.Current.Page<RegistrationPage>();
            p.EmailAddress = String.Empty;
        }

        [Then]
        public void Then_I_should_see_an_invalid_email_error_MESSAGE(string message)
        {
            var p = WebBrowser.Current.Page<RegistrationPage>();
            var isMessageDisplayed = p.ValidationErrorListText.Contains(message);
            Assert.IsTrue(isMessageDisplayed);
        }

        [When(@"I enter following new user details")]
        public void WhenIEnterFollowingNewUserDetails(Table table)
        {
            var p = WebBrowser.Current.Page<RegistrationPage>();
            _instance = table.CreateDynamicInstance();
            p.UserName = _instance.UserName;
            p.EmailAddress = _instance.EmailAddress;
            p.Password = _instance.Password;
            p.ConfirmPassword = _instance.ConfirmPassword;
        }

        [Then(@"I should see following username")]
        public void ThenIShouldSeeFollowingUsername(Table table)
        {
            var user = Document.TextField(Find.ById("NewUserName")).Text;
            var p = WebBrowser.Current.Page<RegistrationPage>();
            _instance = table.CreateDynamicInstance();
            Assert.AreEqual(_instance.UserName, p.UserName);
        }


    }
}
