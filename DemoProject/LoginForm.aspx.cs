using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoProject
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        protected void Register_Buton(object sender, EventArgs e)
        {
            Response.Redirect("WebForm2.aspx");
        }

        protected void Login_Button(object sender, EventArgs e)
        {
            string name = uname1.Text, Password = password.Text;
            Class1 class1 = new Class1();
           if( class1.ToLogin(name, Password)==true)
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