using System;
using OnlineInventoryAndBilling.BL;
using OnlineInventoryAndBilling.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoProject
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        UserManager userManager = new UserManager();
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        protected void Register_Buton(object sender, EventArgs e)
        {
            Response.Redirect("WebForm2.aspx");
        }

        protected void Login_Button(object sender, EventArgs e)
        {
            User user = new User(uname.Text, password.Text);
            if (userManager.ToLogin(user) == true)
            {
                Response.Write("<script LANGUAGE='JavaScript'>alert('Login Successful')</script>");
            }
            else
            {
                Response.Redirect("WebForm3.aspx");
            }
        }
    }
}