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
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\arnom\Source\Repos\Student_Management_System\Test1.mdf;Integrated Security=True";

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
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

    }
}
