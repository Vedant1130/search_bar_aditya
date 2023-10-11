<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="search_bar_page.aspx.cs" Inherits="search_bar.search_bar_page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Search kro veere</title>
    <link rel="stylesheet" href="mystylr.css" />
</head>
<body>
    <form id="form1" runat="server">
        <nav>
            <div>
                <asp:TextBox placeholder="Search all Products" ID="TextBox1"
                    CssClass="txtbx" runat="server" Height="25px" Width="350px" Rows="0" OnTextChanged="TextBox1_TextChanged">

                </asp:TextBox>
                <asp:Button ID="Button1" CssClass="bttn" runat="server"
                    BackColor="#CCCC00" BorderColor="#CCCC00" BorderWidth="1px" Font-Names="Arial Rounded MT Bold"
                    Height="25px" Text="Search" Width="105px" OnClick="Button1_Click" />
            </div>
        </nav>
    </form>
</body>
</html>
