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
                        <a href="update.html">Update</a>
                    </li>
                    <li>
                        <a href="Search.html">Search</a>
                    </li>
                </ul>
            </nav>
     </nav>
    <form id="form1" runat="server">
    <div>
        <br/>
        <asp:ListBox ID="lstStaffs" runat="server" Height="240px" Width="339px"></asp:ListBox>
    </div>
    </form>
</body>
</html>
