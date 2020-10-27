using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
{
    class DataAccess
    {
        public static string stringConnection = "Data Source=DESKTOP-HS8CGAC; Initial Catalog=School;Integrated Security = True";

        public static DataTable executeSQL(string sql)
        {
            SqlConnection connection = new SqlConnection();
            SqlDataAdapter adapter = default(SqlDataAdapter);
            DataTable dt = new DataTable();

            try
            {
                connection.ConnectionString = stringConnection;
                connection.Open();

                adapter = new SqlDataAdapter(sql, connection);
                adapter.Fill(dt);

                connection.Close();
                connection = null;

                return dt;

            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("An error has occured: " + ex.Message,
                    "SQL Server Connection Failed : Student Management System",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                dt = null;
            }
            return dt;
        }
    }
}
