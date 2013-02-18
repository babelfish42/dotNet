<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="L10._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Welcome to ASP.NET!
    </h2>
    <br />
&nbsp;<asp:Label ID="lblFirstname" runat="server" Text="Firstname"></asp:Label>
&nbsp;<asp:TextBox ID="txtFirstname" runat="server"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
        ControlToValidate="txtFirstname" ErrorMessage="Firstname is empty!" 
        style="color: #FF0000"></asp:RequiredFieldValidator>
    <br />
    <br />
&nbsp;<asp:Label ID="lblLastname" runat="server" Text="Lastname"></asp:Label>
&nbsp;<asp:TextBox ID="txtLastname" runat="server"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
        ControlToValidate="txtLastname" ErrorMessage="Lastname is empty!" 
        style="color: #FF0000"></asp:RequiredFieldValidator>
    <br />
    <br />
&nbsp;<asp:Label ID="lblDate" runat="server" Text="Date"></asp:Label>
&nbsp;<asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
&nbsp;<asp:RangeValidator ID="rvDate" runat ="server" ControlToValidate="txtDate" 
        ErrorMessage="Invalid Date" Type="Date" MinimumValue="01/01/1900" 
        MaximumValue="01/01/2100" Display="Dynamic" style="color: #FF0000"></asp:RangeValidator>
<br />
    <br />
    <asp:Button ID="btnSend" runat="server" onclick="btnSend_Click" Text="Do it" />
</asp:Content>
