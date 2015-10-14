using System;

namespace DemoExampleSite
{
    public partial class RegistrationComplete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            NewUserName.InnerText = (string) Session["UserName"];
        }
    }
}