using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Student_Management_System
{
    public partial class student_registration_form : Form
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StudentDB;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public student_registration_form()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (New_Student_Registration_Form nwe=new Student_Management_System.New_Student_Registration_Form())
            {
                nwe.ShowDialog();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select * FROM Student", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill((DataTable)dtbl);

                dataGridView1.DataSource = dtbl;


            }

            /*SqlConnection connect = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StudentDB;Integrated Security=True;");
            SqlCommand command;
            SqlDataReader reader;
            command = new SqlCommand();
            connect.Open();
            command.Connection = connect;
            command.CommandText = " select * from Student";
            DataTable dtbs = new DataTable();
            sqlDaStudent.Fill((DataTable)dtbs);
            reader = command.ExecuteReader();
            sqlDaStudent.Fill((DataTable)dtbs);

            dataGridView1.DataSource = dtbs;
            
            connect.Close();*/
        }
    

private void student_registration_form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schoolDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.schoolDataSet.Student);

        }
    }
}

