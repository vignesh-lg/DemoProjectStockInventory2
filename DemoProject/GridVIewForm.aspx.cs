using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Text.RegularExpressions;
using OnlineInventoryAndBilling.BL;
using OnlineInventoryAndBilling.Entity;

namespace DemoProject
{
    public partial class WebForm6 : System.Web.UI.Page
    {

        UserManager userManager = new UserManager();
        public string sqlConnection = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PopulateGridView();
            }
        }
         protected void Search(object sender, EventArgs e)
        {
            User user = new User(txtSearch.Text);
            if (userManager.ToSearch(user).Rows.Count > 0)
            {
                GridView1.DataSource = userManager.ToSearch(user);
                GridView1.DataBind();
            }
        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void PopulateGridView()
        {
           
            if (userManager.ToBind().Rows.Count > 0)
            {
                GridView1.DataSource = userManager.ToBind();
                GridView1.DataBind();
            }
            else if(userManager.ToBind().Rows.Count==0)
            {
                userManager.ToBind().Rows.Add(userManager.ToBind().NewRow());
                GridView1.DataSource = userManager.ToBind();
                GridView1.DataBind();
                GridView1.Rows[0].Cells.Clear();
                GridView1.Rows[0].Cells[0].ColumnSpan = userManager.ToBind().Columns.Count;
                GridView1.Rows[0].Cells[0].Text = "No Data Found";
                GridView1.Rows[0].Cells[0].HorizontalAlign = HorizontalAlign.Center;
            }
        }
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("AddNew"))
            {
                User user = new User((GridView1.FooterRow.FindControl("firstNameFooter") as TextBox).Text.Trim(), (GridView1.FooterRow.FindControl("secondNameFooter") as TextBox).Text.Trim(), (GridView1.FooterRow.FindControl("genderFooter") as TextBox).Text.Trim(), (GridView1.FooterRow.FindControl("stateFooter") as TextBox).Text.Trim(), (GridView1.FooterRow.FindControl("cityFooter") as TextBox).Text.Trim(), (GridView1.FooterRow.FindControl("addressFooter") as TextBox).Text.Trim(), (GridView1.FooterRow.FindControl("pinCodeFooter") as TextBox).Text.Trim(), (GridView1.FooterRow.FindControl("cellNumberFooter") as TextBox).Text.Trim(), (GridView1.FooterRow.FindControl("emailFooter") as TextBox).Text.Trim(), (GridView1.FooterRow.FindControl("dobFooter") as TextBox).Text.Trim(), (GridView1.FooterRow.FindControl("passwordFooter") as TextBox).Text.Trim());

                if (userManager.GetCustomerDetails(user) == true)
                {
                    PopulateGridView();
                    labelsuccess.Text = "New Data Added" ;
                    labelfailure.Text = "";
                }
            }
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            PopulateGridView();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            PopulateGridView();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            User user = new User((GridView1.Rows[e.RowIndex].FindControl("userNameEditor") as TextBox).Text.Trim(), (GridView1.Rows[e.RowIndex].FindControl("firstNameEditor") as TextBox).Text.Trim(), (GridView1.Rows[e.RowIndex].FindControl("secondNameEditor") as TextBox).Text.Trim(), (GridView1.Rows[e.RowIndex].FindControl("genderEditor") as TextBox).Text.Trim(), (GridView1.Rows[e.RowIndex].FindControl("stateEditor") as TextBox).Text.Trim(), (GridView1.Rows[e.RowIndex].FindControl("cityEditor") as TextBox).Text.Trim(), (GridView1.Rows[e.RowIndex].FindControl("addressEditor") as TextBox).Text.Trim(), (GridView1.Rows[e.RowIndex].FindControl("pinCodeEditor") as TextBox).Text.Trim(), (GridView1.Rows[e.RowIndex].FindControl("cellNumberEditor") as TextBox).Text.Trim(), (GridView1.Rows[e.RowIndex].FindControl("emailEditor") as TextBox).Text.Trim(), (GridView1.Rows[e.RowIndex].FindControl("dobEditor") as TextBox).Text.Trim(), (GridView1.Rows[e.RowIndex].FindControl("passwordEditor") as TextBox).Text.Trim(), Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString()));
            if(userManager.UpdateCustomerDetails(user)==true)
            { 
                GridView1.EditIndex = -1;
                PopulateGridView();
                labelsuccess.Text = "New Data Updated ";
                labelfailure.Text = "";
            }

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            User user = new User(Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString()));
            if (userManager.DeleteCustomer(user) == true)
            {
                PopulateGridView();
                labelsuccess.Text = "Row Deleted";
                labelfailure.Text = "";
            }

        }
        protected void OnPageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            PopulateGridView();
        }

       
    }
}