using System;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace DemoProject
{
    public class Class1 : WebForm2
    {
        public SqlConnection GetMyConnection()
        {
            using (SqlConnection myConnection = new SqlConnection(sqlConnection))
            {
                myConnection.Open();
                if (myConnection != null && myConnection.State == ConnectionState.Closed)
                {
                    Console.WriteLine("Connection is not present");
                    return myConnection;

                }
                else
                {
                    Console.WriteLine("Connection Established");
                    return myConnection;
                }
            }
        }
        public bool GetAndUpdateCustomerDetails( string name, string cfname,string  csname,string genders ,string States,string Cities, string permenantaddress, string PinCode,string cellNumber,string Email, string dateofBirth,string regnum,string Password)
        {
            using (SqlConnection myConnection = new SqlConnection(sqlConnection))
            {
                myConnection.Open();
                string sql = "UserData_Procedure";
                SqlCommand sqlCommand = new SqlCommand(sql, myConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                //int action = 1;
                //sqlCommand.Parameters.Add(new SqlParameter("@Action", action));
                sqlCommand.Parameters.Add(new SqlParameter("@UserName", name));
                sqlCommand.Parameters.Add(new SqlParameter("@CustomerFirstName", cfname));
                sqlCommand.Parameters.AddWithValue("@CustomerSecondName", csname);
                sqlCommand.Parameters.AddWithValue("@Gender", genders);
                sqlCommand.Parameters.AddWithValue("@State", States);
                sqlCommand.Parameters.AddWithValue("@City", Cities);
                sqlCommand.Parameters.AddWithValue("@PermenantAddress", permenantaddress);
                sqlCommand.Parameters.AddWithValue("@PinCode", PinCode);
                sqlCommand.Parameters.AddWithValue("@CellNumber", cellNumber);
                sqlCommand.Parameters.AddWithValue("@Email", Email);
                sqlCommand.Parameters.AddWithValue("@DateOfBirth", dateofBirth);
                sqlCommand.Parameters.AddWithValue("@RegistrationNumber", regnum);
                sqlCommand.Parameters.AddWithValue("@Password", Password);
                int limit = sqlCommand.ExecuteNonQuery();
                if (limit >= 1)
                {
                    return true;
                   
                }
                else
                {
                    return false;
                }
            }

        }
        public bool ToLogin(string name,string Password)
        {
            using (SqlConnection myConnection = new SqlConnection(sqlConnection))
            {
                myConnection.Open();
                string query = "User_Procedure_Login";
                SqlCommand sqlCommand = new SqlCommand(query, myConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@UserName1", name);
                sqlCommand.Parameters.AddWithValue("@Password1", Password);
                sqlCommand.Parameters.Add("@Error", SqlDbType.VarChar, 100);
                sqlCommand.Parameters["@Error"].Direction = ParameterDirection.Output;
                DataTable dataTable = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dataTable);
               if (dataTable.Rows.Count == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}