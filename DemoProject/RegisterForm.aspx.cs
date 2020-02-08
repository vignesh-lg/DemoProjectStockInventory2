using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace DemoProject
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        public string sqlConnection = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void button1(object sender, EventArgs e)
        {
            Class1 class1 = new Class1();
            string name = uname1.Text,cfname=uname2.Text,csname=uname3.Text,genders = gender.Text,States=State.Text,Cities=City.Text,permenantaddress=address.Text,PinCode=pincode.Text,cellNumber=CellNumber.Text,Email=email1.Text,dateofBirth=dob.Text,regnum=rnum.Text,Password=password.Text;
            if( class1.GetAndUpdateCustomerDetails(name,cfname,csname,genders,States,Cities,permenantaddress,PinCode,cellNumber,Email,dateofBirth,regnum,Password)==true)
            {
                Response.Write("<script LANGUAGE='JavaScript' >alert('Registration Successful')</script>");
            }
            else
            {
                Response.Write("<script LANGUAGE='JavaScript' >alert('Registration Fails')</script>");
            }
            Response.Redirect("WebForm3.aspx");
        }
    }
}