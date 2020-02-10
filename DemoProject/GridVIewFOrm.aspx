<%@ Page Title="" Language="C#" MasterPageFile="~/OSIBSMaster.Master" AutoEventWireup="true" CodeBehind="GridVIewForm.aspx.cs" Inherits="DemoProject.WebForm6" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="name">
    <center>   Search : <asp:TextBox ID="txtSearch" runat="server" />
<asp:Button Text="Search" runat="server" OnClick="Search" /></center>
<hr />
        <asp:GridView ID="GridView1" ShowHeaderWhenEmpty="true" DataKeyNames="Personid" EmptyDataText="No Records Found" runat ="server" AutoGenerateColumns="false" ShowFooter="true" AllowPaging="true"  OnPageIndexChanging="OnPageIndexChanging" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
                OnRowCommand="GridView1_RowCommand" OnRowEditing="GridView1_RowEditing" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowUpdating="GridView1_RowUpdating" OnRowDeleting="GridView1_RowDeleting">
            <Columns>
                <asp:BoundField DataField="Personid"
                    HeaderText="User ID"
                    ReadOnly="true"/>
                
                <asp:TemplateField HeaderText="User Name">
                    <ItemTemplate>
                        <asp:Label Text='<%# Eval("UserName") %>' runat="server" />
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="userNameEditor" Text='<%# Eval("UserName") %>' required="" placeHolder="UserName" runat="server" />
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:label Text="AutoUserName" runat="server" />
                    </FooterTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="First Name">
                    <ItemTemplate>
                        <asp:Label Text='<%# Eval("CustomerFirstName") %>' runat="server" />
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="firstNameEditor" required="" placeHolder="CustomerFirstName"  Text='<%# Eval("CustomerFirstName") %>' runat="server" />
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="firstNameFooter"  placeHolder="CustomerFirstName"  runat="server" />
                    </FooterTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Second Name">
                    <ItemTemplate>
                        <asp:Label Text='<%# Eval("CustomerSecondName") %>' runat="server" />
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="secondNameEditor" required="" placeHolder="CustomerSecondName"  Text='<%# Eval("CustomerSecondName") %>' runat="server" />
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="secondNameFooter"  placeHolder="CustomerSecondName"  runat="server" />
                    </FooterTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Gender">
                    <ItemTemplate>
                        <asp:Label Text='<%# Eval("gender") %>'  runat="server" />
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="genderEditor" required="" placeHolder="gender" Text='<%# Eval("gender") %>' runat="server" />
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="genderFooter"  placeHolder="gender"  runat="server" />
                    </FooterTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="State">
                    <ItemTemplate>
                        <asp:Label Text='<%# Eval("States") %>'  runat="server" />
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="stateEditor" required="" placeHolder="States"  Text='<%# Eval("States") %>' runat="server" />
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="stateFooter"  placeHolder="States"  runat="server" />
                    </FooterTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="City">
                    <ItemTemplate>
                        <asp:Label Text='<%# Eval("City") %>' runat="server" />
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="cityEditor"  required="" placeHolder="City"  Text='<%# Eval("City") %>' runat="server" />
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="cityFooter"  placeHolder="City"  runat="server" />
                    </FooterTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Permenant Address">
                    <ItemTemplate>
                        <asp:Label Text='<%# Eval("PermenantAddress") %>' runat="server" />
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="addressEditor" required="" placeHolder="PermenantAddress"  Text='<%# Eval("PermenantAddress") %>' runat="server" />
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="addressFooter"  placeHolder="PermenantAddress"  runat="server" />
                    </FooterTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Pin Code">
                    <ItemTemplate>
                        <asp:Label Text='<%# Eval("PinCode") %>' runat="server" />
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="pinCodeEditor" required="" placeHolder="PinCode" Text='<%# Eval("PinCode") %>' runat="server" />
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="pinCodeFooter" placeHolder="PinCode"  runat="server" />
                    </FooterTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Cell Number">
                    <ItemTemplate>
                        <asp:Label Text='<%# Eval("CellNumber") %>'   runat="server" />
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="cellNumberEditor" Text='<%# Eval("CellNumber") %>' required="" placeHolder="CellNumber"  runat="server" />
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="cellNumberFooter" placeHolder="CellNumber"  runat="server" />
                    </FooterTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="E-Mail">
                    <ItemTemplate>
                        <asp:Label Text='<%# Eval("Email") %>'   runat="server" />
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="emailEditor" Text='<%# Eval("Email") %>' required="" placeHolder="Email"  runat="server" />
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="emailFooter"  placeHolder="Email"  runat="server" />
                    </FooterTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Date Of Birth">
                    <ItemTemplate>
                        <asp:Label Text='<%# Eval("DateOfBirth") %>' runat="server" />
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="dobEditor" Text='<%# Eval("DateOfBirth") %>' required="" placeHolder="DateOfBirth"  runat="server" />
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="dobFooter"  placeHolder="DateOfBirth"  runat="server" />
                    </FooterTemplate>
                </asp:TemplateField>
               <%-- <asp:TemplateField HeaderText="Registration Number">
                    <ItemTemplate>
                        <asp:Label Text='<%# Eval("RegistrationNumber") %>' runat="server" />
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="regNumEditor" Text='<%# Eval("RegistrationNumber") %>' required="" placeHolder="RegistrationNumber"  runat="server" />
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="regNumFooter" placeHolder="UserName"  runat="server" />
                    </FooterTemplate>
                </asp:TemplateField>--%>
                 <asp:BoundField DataField="RegistrationNumber"
                    HeaderText="Registration Number"
                    ReadOnly="true"/>
                <asp:TemplateField HeaderText="Password">
                    <ItemTemplate>
                        <asp:Label Text='<%# Eval("Passwords") %>' runat="server" />
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="passwordEditor" Text='<%# Eval("Passwords") %>' required="" placeHolder="Passwords"  runat="server" />
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="passwordFooter" placeHolder="Passwords" runat="server" />
                    </FooterTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:ImageButton ImageUrl="~/Images/edit.png" runat="server" CommandName="Edit" ToolTip="Edit" Width="20px" Height="20px" />
                        <asp:ImageButton ImageUrl="~/Images/delete.png" runat="server" CommandName="Delete" ToolTip="Delete" Width="20px" Height="20px" />
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:ImageButton ImageUrl="~/Images/save.png" runat="server" CommandName="Update" ToolTip="Update" Width="20px" Height="20px" />
                        <asp:ImageButton ImageUrl="~/Images/cancel.png" runat="server" CommandName="Cancel" ToolTip="Cancel" Width="20px" Height="20px" />
                    </EditItemTemplate>
                    <FooterTemplate>
                         <asp:ImageButton ImageUrl="~/Images/addnew.png" runat="server" CommandName="AddNew" ToolTip="AddNew" Width="20px" Height="20px" />
                    </FooterTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <br/>
        <asp:Label ID="labelsuccess" runat="server" foreColor="Green" text="" />
         <br/>
        <asp:Label ID="labelfailure" runat="server" foreColor="red" text="" />
        </div>
</asp:Content>
