<%@ Page Language="C#" MasterPageFile="~/OSIBSMaster.Master" AutoEventWireup="true" CodeBehind="RegisterForm.aspx.cs" Inherits="DemoProject.WebForm2" %>


<asp:Content ID="contentHead" runat="server" ContentPlaceHolderID="head">
</asp:Content>
<asp:Content ID="contentPlaceHolderLogin" runtat="server" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <div class="SignUp">
        <table border="0">
           <%-- <tr>
                <td>Username</td>
                <td>
                    <asp:TextBox ID="uname" placeholder="Enter Username" runat="server"></asp:TextBox></td>
            </tr>--%>
            <tr>
                <td>Customer First Name</td>
                <td>
                    <asp:TextBox ID="cfname" placeholder="Enter CustomerFirst Name" runat="server" required=""></asp:TextBox>
                    <asp:RegularExpressionValidator Display="Dynamic" ID="regularValidateName" runat="server" ControlToValidate="cfname" ErrorMessage="Enter valid name" Style="color: red" ValidationExpression="[A-Z][a-z-A-Z]+$"></asp:RegularExpressionValidator>
                    <asp:RegularExpressionValidator Display="Dynamic" ControlToValidate="cfname" ID="regularValidateNameSize" ValidationExpression="^[\s\S]{5,8}$" runat="server" ErrorMessage="Minimum 5 and Maximum 8 characters required."></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>Customer Second Name</td>
                <td>
                    <asp:TextBox ID="csname" placeholder="Enter Customer Second Name" runat="server" required=""></asp:TextBox>
                    <asp:RegularExpressionValidator Display="Dynamic" ID="RegularExpressionValidatorName" runat="server" ControlToValidate="csname" ErrorMessage="Enter valid name" Style="color: red" ValidationExpression="[A-Z][a-z-A-Z]+$"></asp:RegularExpressionValidator>
                    <asp:RegularExpressionValidator Display="Dynamic" ControlToValidate="csname" ID="RegularExpressionValidatorSize" ValidationExpression="^[\s\S]{5,8}$" runat="server" ErrorMessage="Minimum 5 and Maximum 8 characters required."></asp:RegularExpressionValidator>

                </td>
            </tr>
            <tr>
                <td>Email</td>
                <td>
                    <asp:TextBox ID="email" placeholder="Enter Mail" runat="server" TextMode="Email" required=""></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidatorEMail" runat="server" ControlToValidate="email"
                        ErrorMessage="Please enter valid email" Display="Dynamic" ForeColor="Red" ValidationExpression="^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$">  
                    </asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>Gender</td>
                <td>
                    <asp:RadioButtonList ID="gender" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem>Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                        <asp:ListItem>Other</asp:ListItem>
                    </asp:RadioButtonList></td>
            </tr>
            <tr>
                <td>State </td>
                <td>
                    <asp:DropDownList ID="state" runat="server">
                        <asp:ListItem Value="Tamil Nadu">Tamil Nadu</asp:ListItem>
                        <asp:ListItem Value="Andhra Pradesh">Andhra Pradesh</asp:ListItem>
                        <asp:ListItem Value="Kerala">Kerala</asp:ListItem>
                        <asp:ListItem Value="Karnataka">Karnataka</asp:ListItem>
                        <asp:ListItem Value="Telungana">Telungana</asp:ListItem>
                    </asp:DropDownList></td>
            </tr>
            <tr>
                <td>City  </td>
                <td>
                    <asp:DropDownList ID="city" runat="server">
                        <asp:ListItem Value="Chennai">Chennai</asp:ListItem>
                        <asp:ListItem Value="Hyberabad">Hyberabad</asp:ListItem>
                        <asp:ListItem Value="Kochin">Kochin</asp:ListItem>
                        <asp:ListItem Value="Banglore">Banglore</asp:ListItem>
                        <asp:ListItem Value="Secundrabad">Secundrabad</asp:ListItem>
                    </asp:DropDownList></td>
            </tr>
            <tr>
                <td>Address</td>
                <td>
                    <asp:TextBox ID="address" placeholder="Enter Address" runat="server" required=""></asp:TextBox>
                <asp:RegularExpressionValidator Display="Dynamic" ControlToValidate="address" ID="RegularExpressionValidator1" ValidationExpression="^[\w-\.,-/]{10,50}$" runat="server" ErrorMessage="Minimum 5 and Maximum 8 characters required."></asp:RegularExpressionValidator>
           </td>
                    </tr>
            <tr>
                <td>PinCode</td>
                <td>
                    <asp:TextBox ID="pincode" placeholder="Enter Pincode" runat="server" required=""></asp:TextBox>
                    <asp:RegularExpressionValidator  Display="Dynamic" ID="YourRegularExpressionValidator" runat="server" 
                                ControlToValidate="pincode" 
                                ErrorMessage="Your TextBox must have exactly 6 digits."  
                                ValidationExpression="^\d{6}$">
</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>CellNumber</td>
                <td>
                    <asp:TextBox ID="cellNumber" placeholder="Enter CellNumber" runat="server" required=""></asp:TextBox>
                    <asp:RegularExpressionValidator Display="Dynamic" ID="RegularExpressionValidatorNumber" runat="server"  
ControlToValidate="cellNumber" ErrorMessage="Invalid Mobile Number"  
ValidationExpression="[6789]\d{9}"></asp:RegularExpressionValidator>  
                </td>
            </tr>
            <tr>
                <td>Date of Birth</td>
                <td>
                    <asp:TextBox ID="dob" runat="server" TextMode="Date" required=""></asp:TextBox></td>
            </tr>
            <tr>
                <td>Registration Number</td>
                <td>
                    <asp:TextBox ID="rnum" placeholder="Enter RegNum" runat="server" required=""></asp:TextBox>
                    <asp:RegularExpressionValidator Display="Dynamic" ControlToValidate="rnum" ID="RegularExpressionValidator2" ValidationExpression="^[\w-\.]{5,15}$" runat="server" ErrorMessage="Minimum 5 and Maximum 8 characters required."></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>Password</td>
                <td>
                    <asp:TextBox ID="password" placeholder="Enter password" runat="server" TextMode="Password" required=""></asp:TextBox>
                     <asp:RegularExpressionValidator Display="Dynamic" ControlToValidate="password" ID="RegularExpressionValidator3" ValidationExpression="([0-9-A-Z-a-z-!@#$%^&*()_+=\[{\]};:<>|./?,-].{8,15})" runat="server" ErrorMessage="Password must contain a number,special character,uppercase, lowercase"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>Retype Password</td>
                <td>
                    <asp:TextBox ID="confirmpassword" placeholder="ReEnter password" runat="server" TextMode="Password" required=""></asp:TextBox></td>
            </tr>
            <tr>
                <td>Our <a href="index.html">terms and conditions</a>,click Yes to Continue</td>
                <td>
                    <asp:CheckBoxList runat="server" ID="checkbox" RepeatDirection="Horizontal">
                        <asp:ListItem Value="Yes">Yes</asp:ListItem>
                        <asp:ListItem Value="No">No</asp:ListItem>
                    </asp:CheckBoxList></td>
            </tr>
        </table>
        <asp:Button ID="button" Text="Register" runat="server" OnClick="Register_Button" />
     </div>
</asp:Content>
