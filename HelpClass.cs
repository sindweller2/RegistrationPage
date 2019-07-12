using System;
namespace RegistrationPage
{
    public class HelpClass
    {
        public System.Data.SqlClient.SqlConnection SqlConnection;
        public System.Data.SqlClient.SqlCommand SqlCommand;
        public System.Data.SqlClient.SqlDataAdapter SqlDataAdapter;
        public String Query;

        public String AzureDataBaseConnectionString()
        {
                String x = "Server=tcp:sindweller2appserver.database.windows.net;Database=sindweller2db;User ID=sindweller2;Password=Ad852046;Trusted_Connection=False;";
                return x;
        }

        public void Alert(String Message)
        {
                System.Web.HttpContext.Current.Response.Write("<script>alert('" + Message + "');</script>");
        }

        public void InsertUserData(String Name, String Email, String Job)
        {
                this.Query = "INSERT INTO [dbo].[User] VALUES('" + Name + "','" + Email + "','" + Job + "','" + String.Format("{0:yyyy-MM-dd}", DateTime.Now) + "')";
                this.SqlConnection = new System.Data.SqlClient.SqlConnection(this.AzureDataBaseConnectionString());
                this.SqlCommand = new System.Data.SqlClient.SqlCommand(this.Query, this.SqlConnection);
                this.SqlConnection.Open();
                this.SqlCommand.ExecuteNonQuery();
                this.SqlConnection.Close();
        }

        public System.Data.DataTable SelectUserData()
        {
                this.Query = "SELECT Name,Email,Job,convert(varchar, Date, 6) as Date FROM [dbo].[User]";
                this.SqlConnection = new System.Data.SqlClient.SqlConnection(this.AzureDataBaseConnectionString());
                this.SqlConnection.Open();
                this.SqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Query, this.SqlConnection);
                System.Data.DataTable DataTable = new System.Data.DataTable();
                this.SqlDataAdapter.Fill(DataTable);
                this.SqlConnection.Close();
                return DataTable;
        }
    }
}
