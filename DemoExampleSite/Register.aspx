<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="DemoExampleSite.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sign Up</title>
    <link href="Styles/Site.css" rel="stylesheet" />
    <script src="Scripts/jquery-2.0.3.js"></script>
     <script>
         $(document).ready(function () {            

             $('#Password').keypress( function () {
                 var password = $(this).val(); 
                 UpdatePassStrength(password);                 
             });

         });
         
         function UpdatePassStrength(password) {
             var strength = "Awesome";

             if (password.length < 5) {
                 strength = "Poor";
             } else if (password.length < 10) {
                 strength = "Average";
             }

             $("#PasswordStrength").text(strength);
         }
</script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <h1>Sign Up</h1>
        <div id="validationErrorContainer" class="error">
            <asp:BulletedList runat="server" ID="ValidationErrorList"/>
        </div>
        <fieldset>
            <legend>New Account Details</legend>
            
            <label for="UserName">User Name</label>
            <asp:TextBox runat="server" ID="UserName"/>
            
            <label for="EmailAddress">Email Address</label>
            <asp:TextBox runat="server" ID="EmailAddress"/>

            <label for="Password">Password</label>
            <asp:TextBox runat="server" ID="Password"/>
            <div id="PasswordStrength"></div>

            <label for="ConfirmPassword">Confirm Password</label>
            <asp:TextBox runat="server" ID="ConfirmPassword"/>
        </fieldset>
        
      
       
        
        <asp:Button runat="server" ID="DoRegister" Text="Register Now!" OnClick="DoRegister_OnClick"></asp:Button>

    </div>
    </form>
</body>
</html>
