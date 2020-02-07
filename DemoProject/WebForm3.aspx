<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="DemoProject.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
    <link rel="stylesheet" type="text/css" href="FullStyle.css" />
  <div class="a">
<span class="b">
<h1><marquee>Online Stock Inventory and Billing System</h1></marquee>
</span>
</div> 
</head>
<body>

    <form id="form1" class="box" runat="server">

        <table>
            <tr>
                <td>Username</td>
                <td>
                   <asp:TextBox ID="uname1" placeholder="Enter Username" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Password</td>
                <td>
                    <asp:TextBox ID="password" placeholder="Enter password" runat="server" TextMode="Password"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Button runat="server" Text="Login" ID="Login" OnClick="Login_Button" />
                    <asp:Button runat="server" Text="Register" ID="register" OnClick="Register_Buton" /></td>
            </tr>
        </table>
    </form>
</body>
</html>
