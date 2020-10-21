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
    public partial class New_Student_Registration_Form : Form
    {

        public New_Student_Registration_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void New_Student_Registration_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schoolDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.schoolDataSet.Student);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private static void main(string[] args)
        {
            Application.Run(new New_Student_Registration_Form());
        }
    }
}
