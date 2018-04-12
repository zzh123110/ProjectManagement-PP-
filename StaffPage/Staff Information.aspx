<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Staff Information.aspx.cs" Inherits="Staff_Information" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff Information</title>
    <link rel="stylesheet" type="text/css" href="StaffPage.css" />
    <style type="text/css">
    </style>
</head>
<body>
<nav id="nav">
            <nav id="nav_wrapper">
                <ul>
                    <li>
                        <a href="Staff%20Information.aspx">Staff Information</a>
                    </li>
                    <li>
                        <a href="EnrollStaff.aspx">Enrollment</a>
                    </li>
                    <li>
                        <a href="Update.aspx">Update</a>
                    </li>
                    <li style="float:right"><a href="LogIn.aspx">Log Out</a></li>    
                </ul>
            </nav>
     </nav>
    <form id="form1" runat="server">
    <h1><strong>Staff Information</strong></h1>
    <div>
        <br />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; width: 393px"></asp:Label>

            <br />
            <br />
        <br/>
        <asp:ListBox ID="lstStaffs" runat="server" Height="329px" Width="500px"></asp:ListBox>
        <br/>
        <br/>
        <asp:Button ID="ButtonUpdate" runat="server" Text="Update" OnClick="ButtonUpdate_Click" style="height: 26px" />
    </div>
    </form>
</body>
</html>
