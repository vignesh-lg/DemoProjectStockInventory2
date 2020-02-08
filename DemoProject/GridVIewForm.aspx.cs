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

namespace DemoProject
{
    public partial class WebForm6 : System.Web.UI.Page
    {
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
            DataTable dataTable = new DataTable();
            using (SqlConnection myConnection = new SqlConnection(sqlConnection))
            {
                myConnection.Open();
                string sql = "User_Procedure_Search";
                SqlCommand sqlCommand = new SqlCommand(sql, myConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@id", txtSearch.Text);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dataTable);
            }
            if (dataTable.Rows.Count > 0)
            {
                GridView1.DataSource = dataTable;
                GridView1.DataBind();
            }
        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void PopulateGridView()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection myConnection = new SqlConnection(sqlConnection))
            {
                myConnection.Open();
                string sql = "User_Procedure";
                SqlCommand sqlCommand = new SqlCommand(sql, myConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dataTable);
            }
            if (dataTable.Rows.Count > 0)
            {
                GridView1.DataSource = dataTable;
                GridView1.DataBind();
            }
            else if(dataTable.Rows.Count==0)
            {
                dataTable.Rows.Add(dataTable.NewRow());
                GridView1.DataSource = dataTable;
                GridView1.DataBind();
                GridView1.Rows[0].Cells.Clear();
                GridView1.Rows[0].Cells[0].ColumnSpan = dataTable.Columns.Count;
                GridView1.Rows[0].Cells[0].Text = "No Data Found";
                GridView1.Rows[0].Cells[0].HorizontalAlign = HorizontalAlign.Center;

            }
        }
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("AddNew"))
            {
                using (SqlConnection myConnection = new SqlConnection(sqlConnection))
                {
                    myConnection.Open();
                    string sql = "UserData_Procedure";
                    SqlCommand sqlCommand = new SqlCommand(sql, myConnection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@CustomerFirstName", (GridView1.FooterRow.FindControl("firstNameFooter") as TextBox).Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@CustomerSecondName", (GridView1.FooterRow.FindControl("secondNameFooter") as TextBox).Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@Gender", (GridView1.FooterRow.FindControl("genderFooter") as TextBox).Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@State", (GridView1.FooterRow.FindControl("stateFooter") as TextBox).Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@City", (GridView1.FooterRow.FindControl("cityFooter") as TextBox).Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@PermenantAddress", (GridView1.FooterRow.FindControl("addressFooter") as TextBox).Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@PinCode", (GridView1.FooterRow.FindControl("pinCodeFooter") as TextBox).Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@CellNumber", (GridView1.FooterRow.FindControl("cellNumberFooter") as TextBox).Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@Email", (GridView1.FooterRow.FindControl("emailFooter") as TextBox).Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@DateOfBirth", (GridView1.FooterRow.FindControl("dobFooter") as TextBox).Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@RegistrationNumber", (GridView1.FooterRow.FindControl("regNumFooter") as TextBox).Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@Password", (GridView1.FooterRow.FindControl("passwordFooter") as TextBox).Text.Trim());
                    sqlCommand.ExecuteNonQuery();

                    PopulateGridView();
                    labelsuccess.Text = "New Data Added";
                    labelfailure.Text = "";
                    //return true;



                    // return false;

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

            using (SqlConnection myConnection = new SqlConnection(sqlConnection))
            {
                myConnection.Open();
                string sql = "UserData_Procedure_Update";
                SqlCommand sqlCommand = new SqlCommand(sql, myConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@UserName", (GridView1.Rows[e.RowIndex].FindControl("userNameEditor") as TextBox).Text.Trim());
                sqlCommand.Parameters.AddWithValue("@CustomerFirstName", (GridView1.Rows[e.RowIndex].FindControl("firstNameEditor") as TextBox).Text.Trim());
                sqlCommand.Parameters.AddWithValue("@CustomerSecondName", (GridView1.Rows[e.RowIndex].FindControl("secondNameEditor") as TextBox).Text.Trim());
                sqlCommand.Parameters.AddWithValue("@Gender", (GridView1.Rows[e.RowIndex].FindControl("genderEditor") as TextBox).Text.Trim());
                sqlCommand.Parameters.AddWithValue("@State", (GridView1.Rows[e.RowIndex].FindControl("stateEditor") as TextBox).Text.Trim());
                sqlCommand.Parameters.AddWithValue("@City", (GridView1.Rows[e.RowIndex].FindControl("cityEditor") as TextBox).Text.Trim());
                sqlCommand.Parameters.AddWithValue("@PermenantAddress", (GridView1.Rows[e.RowIndex].FindControl("addressEditor") as TextBox).Text.Trim());
                sqlCommand.Parameters.AddWithValue("@PinCode", (GridView1.Rows[e.RowIndex].FindControl("pinCodeEditor") as TextBox).Text.Trim());
                sqlCommand.Parameters.AddWithValue("@CellNumber", (GridView1.Rows[e.RowIndex].FindControl("cellNumberEditor") as TextBox).Text.Trim());
                sqlCommand.Parameters.AddWithValue("@Email", (GridView1.Rows[e.RowIndex].FindControl("emailEditor") as TextBox).Text.Trim());
                sqlCommand.Parameters.AddWithValue("@DateOfBirth", (GridView1.Rows[e.RowIndex].FindControl("dobEditor") as TextBox).Text.Trim());
                sqlCommand.Parameters.AddWithValue("@RegistrationNumber", (GridView1.Rows[e.RowIndex].FindControl("regNumEditor") as TextBox).Text.Trim());
                sqlCommand.Parameters.AddWithValue("@Password", (GridView1.Rows[e.RowIndex].FindControl("passwordEditor") as TextBox).Text.Trim());
                sqlCommand.Parameters.AddWithValue("@id", Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString()));
                sqlCommand.ExecuteNonQuery();
                GridView1.EditIndex = -1;
                PopulateGridView();
                labelsuccess.Text = "New Data Updated ";
                labelfailure.Text = "";
            }

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            using (SqlConnection myConnection = new SqlConnection(sqlConnection))
            {
                myConnection.Open();
                string sql = "UserData_Procedure_Delete";
                SqlCommand sqlCommand = new SqlCommand(sql, myConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@id", Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString()));
                sqlCommand.ExecuteNonQuery();
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