using Student_Management_System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Student_form student=  new Student_Management_System.Student_form())
            {
                student.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using(Lecturer_registration_form lecturer_res = new Student_Management_System.Lecturer_registration_form())
            {
                lecturer_res.ShowDialog();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (Courses courses_res = new Student_Management_System.Courses())
            {
                courses_res.ShowDialog();
            }
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login fl = new Login();
            fl.Show();
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
