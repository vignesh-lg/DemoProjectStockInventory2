using System;
using OnlineInventoryAndBilling.BL;
using OnlineInventoryAndBilling.DAL;
using OnlineInventoryAndBilling.Entity;
using System.Configuration;

namespace DemoProject
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        UserManager userManager = new UserManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Register_Button(object sender, EventArgs e)
        {
            
            User user  = new User(cfname.Text,csname.Text,gender.Text,state.Text,city.Text,address.Text,pincode.Text,cellNumber.Text,email.Text,dob.Text,password.Text);
            if( userManager.GetCustomerDetails(user)==true)
            {
                Response.Write("<script LANGUAGE='JavaScript' >alert('Registration Successful')</script>");
            }
            else
            {
                Response.Write("<script LANGUAGE='JavaScript' >alert('Registration Fails')</script>");
            }
        
        }
    }
}