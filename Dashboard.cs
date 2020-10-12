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
            using (student_registration_form student_res=  new Student_Management_System.student_registration_form())
            {
                student_res.ShowDialog();
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
    }
}
