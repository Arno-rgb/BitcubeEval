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
        
            SqlConnection connect = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StudentDB;Integrated Security=True;");
            SqlCommand command;
            SqlDataReader reader;
            command = new SqlCommand();
            connect.Open();
            command.Connection = connect;
            command.CommandText = " select * from Student";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                listBox1.Items.Add(reader["fullName"]);
            }
            connect.Close();
        }
    }
}

