<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LogIn.aspx.cs" Inherits="LogIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Log In</title>
    <link rel="stylesheet" type="text/css" href="StaffPage.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <br/>
        <br/>
        <br/>
        <br/>
        <br/>
        <h3><strong>Administrator</strong></h3>
        <br/>
        <br/>
        <br/>
        <asp:Label ID="LabelUserName" runat="server" Text="UserName"></asp:Label>
        <asp:TextBox ID="TextBoxUserName" runat="server" style="margin-left: 6px"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" Text="A1234"></asp:Label>
        <br/>
        <br/>
        <asp:Label ID="LabelPassword" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="TextBoxPassword" runat="server" style="margin-left: 13px" TextMode="Password"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="123456"></asp:Label>
        <br/>
        <br/>
        <br/>
        <asp:Button ID="ButtonLogin" runat="server" Text="Login" OnClick="ButtonLogin_Click" />
    </div>
    </form>
</body>
</html>
