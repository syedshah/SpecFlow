<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrationComplete.aspx.cs" Inherits="DemoExampleSite.RegistrationComplete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration Complete</title>
    <link href="Styles/Site.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Congratulations!</h1>
        <p>Your new username is: <span runat="server" ID="NewUserName"></span></p>
    </div>
    </form>
</body>
</html>
