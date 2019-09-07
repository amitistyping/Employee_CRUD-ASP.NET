<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ShoppingCart1.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
&nbsp;
        <asp:TextBox ID="unameText" runat="server"></asp:TextBox>
&nbsp;<div>
            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
&nbsp;
            <asp:TextBox ID="passwordTxt" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="sendCookie" runat="server" Text="Submit" OnClick="sendCookie_Click" />
        </div>
    </form>
</body>
</html>
