using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoExampleSite
{
    public partial class Register : System.Web.UI.Page
    {
        private readonly List<string> _validationErrors = new List<string>();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DoRegister_OnClick(object sender, EventArgs e)
        {
            ValidateMatchingPasswords();
            ValidateEmailFormat();
            ValidateUserName();

            if (!_validationErrors.Any())
            {
                Session["UserName"] = UserName.Text;

                Response.Redirect("RegistrationComplete.aspx");
            }
        }

        private void ValidateUserName()
        {
            if (UserName.Text == "MrAwesome")
            {
                _validationErrors.Add("Sorry, that username is already in use");
            }
        }

        private void ValidateEmailFormat()
        {
            if (!EmailAddress.Text.Contains("@"))
            {
                _validationErrors.Add("Invalid email address");
            }
        }

        private void ValidateMatchingPasswords()
        {
            if (Password.Text != ConfirmPassword.Text)
            {
                _validationErrors.Add("Passwords don't match");
            }
        }

        protected override void OnPreRender(EventArgs e)
        {
            ShowErrors();
        }

        private void ShowErrors()
        {
            ValidationErrorList.DataSource = _validationErrors;
            ValidationErrorList.DataBind();
        }
    }
}