<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductAdd.aspx.cs" Inherits="ShoppingCart1.ProductAdd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Welcome
            <asp:Label ID="User" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="product name"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="product price"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="product description"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="product sku"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label5" runat="server" Text="product image"></asp:Label>
            <asp:FileUpload ID="FileUpload1" runat="server" />
            <br />
             <asp:Button ID="upload" runat="server" Text="upload" Width="73px"/>
            <br />
            <asp:Label ID="Label6" runat="server" Text="product category"></asp:Label>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ShopCartConnectionString %>" SelectCommand="SELECT [cat_id], [cat_name] FROM [cat_table]"></asp:SqlDataSource>
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="cat_name" DataValueField="cat_id">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="save" runat="server" Text="save" OnClick="save_Click" />
        </div>
    </form>
</body>
</html>
