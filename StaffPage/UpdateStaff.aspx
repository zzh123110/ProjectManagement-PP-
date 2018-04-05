<%@ Page Title="" Language="C#" MasterPageFile="~/Staff.master" AutoEventWireup="true" CodeFile="UpdateStaff.aspx.cs" Inherits="UpdateStaff" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div>
            <h1><strong>Student Information</strong></h1>
          <br/>
          <br/>
        <asp:Label ID="lblError" runat="server" Text="Label"></asp:Label>
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
</asp:Content>

