<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Update.aspx.cs" Inherits="Update" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Update</title>
    <link rel="stylesheet" type="text/css" href="StaffPage.css" />
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
    <h1><strong>Update</strong></h1>
        <div>
          <br/>
          <br/>
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br/>
        <asp:Label ID="LabelStaffNubmer" runat="server" Text="Staff Number" Width="100px"></asp:Label>
        <asp:TextBox ID="TextBoxStaffNubmer" runat="server"></asp:TextBox>
        <br/>
        <br/>
        <asp:Label ID="LabelFirstName" runat="server" Text="First Name" Width="100px"></asp:Label>
        <asp:TextBox ID="TextBoxFirstName" runat="server"></asp:TextBox>
        <br/>
        <br/>
        <asp:Label ID="LabelLastName" runat="server" Text="Last Name" Width="100px"></asp:Label>
        <asp:TextBox ID="TextBoxLastName" runat="server"></asp:TextBox>
        <br/>
        <br/>
        <asp:Label ID="LabelGender" runat="server" Text="Gender" Width="100px"></asp:Label>
        <asp:TextBox ID="TextBoxGender" runat="server"></asp:TextBox>
        <br/>
        <br/>
        <asp:Label ID="LabelPosition" runat="server" Text="Position" Width="100px"></asp:Label>
        <asp:TextBox ID="TextBoxPosition" runat="server"></asp:TextBox>
        <br/>
        <br/>
        <asp:Label ID="LabelPassword" runat="server" Text="Password" Width="100px"></asp:Label>
        <asp:TextBox ID="TextBoxPassword" runat="server"></asp:TextBox>
        <br/>
        <br/>
        <asp:Label ID="LabelAttendence" runat="server" Text="Attendence" Width="100px"></asp:Label>
        <asp:TextBox ID="TextBoxAttendence" runat="server"></asp:TextBox>
        <br/>
        <br/>
        <asp:Label ID="LabelAddress" runat="server" Text="Address" Width="100px"></asp:Label>
        <asp:TextBox ID="TextBoxAddress" runat="server" TextMode="MultiLine" Height="58px"></asp:TextBox>
        <br />
        <br/>
        <asp:Label ID="LabelPhoneNumber" runat="server" Text="PhoneNumber" Width="100px"></asp:Label>
        <asp:TextBox ID="TextBoxPhoneNumber" runat="server"></asp:TextBox>
        <br/>
        <br/>
        <asp:Button ID="ButtonUpdate" runat="server" Text="Update" OnClick="ButtonUpdate_Click" />
    </div>
    </form>
</body>
</html>
