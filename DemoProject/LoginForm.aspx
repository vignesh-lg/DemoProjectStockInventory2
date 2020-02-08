<%@ Page Language="C#" MasterPageFile="~/OSIBSMaster.Master" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="DemoProject.WebForm3" %>


<asp:Content ID="contentHead" runat="server" ContentPlaceHolderID="head">
</asp:Content>
<asp:Content ID="contentPlaceHolderLogin" runtat="server" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  
    <div class="SignIn">
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
    </div>
</asp:Content>
