using Student_Management_System.Degrees;
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
    public partial class Courses : Form
    {
        public Courses()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Degrees.Criminology criminology = new Student_Management_System.Degrees.Criminology())
            {
                criminology.ShowDialog();
            }
        }

            private void button2_Click(object sender, EventArgs e)
        {
            using (Degrees.Accounting accounting = new Student_Management_System.Degrees.Accounting())
            {
                accounting.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (Degrees.Computer_Science computer = new Student_Management_System.Degrees.Computer_Science())
            {
                computer.ShowDialog();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (Degrees.Biology biology = new Student_Management_System.Degrees.Biology())
            {
                biology.ShowDialog();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (Degrees.Economy economy = new Student_Management_System.Degrees.Economy())
            {
                economy.ShowDialog();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (Degrees.Law law = new Student_Management_System.Degrees.Law())
            {
                law.ShowDialog();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (Degrees.Maths math = new Student_Management_System.Degrees.Maths())
            {
                math.ShowDialog();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            using (Degrees.Psychology pshy = new Student_Management_System.Degrees.Psychology())
            {
                pshy.ShowDialog();
            }
        }
    }
}
