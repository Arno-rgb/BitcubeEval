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



namespace Student_Management_System
{
    public partial class Lecturer_registration_form : Form
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StudentDB;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public Lecturer_registration_form()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (New_Lecturer_Registration_Form reg_lecturer = new Student_Management_System.New_Lecturer_Registration_Form())
            {
                reg_lecturer.ShowDialog();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select * FROM Lecturer", sqlCon);
                DataTable dtbl1 = new DataTable();
                sqlDa.Fill((DataTable)dtbl1);

                dataGridView1.DataSource = dtbl1;


            }
        }
    }
}
