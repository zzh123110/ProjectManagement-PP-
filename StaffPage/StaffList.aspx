<%@ Page Title="" Language="C#" MasterPageFile="~/Staff.master" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="StaffList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
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
</asp:Content>

