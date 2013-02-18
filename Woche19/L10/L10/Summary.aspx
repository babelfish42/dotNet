<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Summary.aspx.cs" Inherits="L10.Summary" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" style="font-weight: 700" Text="Summary"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="txtFirstname" runat="server" ReadOnly="True"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox ID="txtLastname" runat="server" ReadOnly="True"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox ID="txtDate" runat="server" ReadOnly="True"></asp:TextBox>
    
    </div>
    </form>
</body>
</html>
