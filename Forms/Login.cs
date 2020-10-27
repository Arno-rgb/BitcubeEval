using ImTools;
using Student_Management_System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Student_Management_System
{
    public partial class Login : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);


        public Login()
        {
            InitializeComponent();
            List<string> People_text = new List<string> { "Lecturer", "Student", "Admin" };
            for (int x = 0; x < People_text.Count; x++)
            {
                listBox1.Items.Add(People_text[x]);

            }
           
            /*string var1 = "Lecturer";
            string var2 = "Student";
            string var3 = "Admin";
            listBox1.Items.Add(var1);
            listBox1.Items.Add(var2);
            listBox1.Items.Add(var3);
            */
        }
        private void Login_Load(object sender, EventArgs e)
        {
            usernameTextBox.Select();
        }

 
        private void Login_btn_Click(object sender, EventArgs e)
        {

            if(!string.IsNullOrEmpty(usernameTextBox.Text)&&
                !string.IsNullOrEmpty(passwordTextBox.Text))
            {
                string mySql = string.Empty;

                mySql += "SELECT * FROM Lecturer01";
                mySql += "WHERE Username, = '" + usernameTextBox.Text + "'";
                mySql += "AND Password = '" + passwordTextBox.Text + "'";

                DataTable userData = DataAccess.executeSQL(mySql);

                if(userData.Rows.Count > 0)
                {
                    usernameTextBox.Clear();
                    passwordTextBox.Clear();
                    showPasswordCheckBox.Checked = false;

                    this.Hide();

                    Login login = new Login();
                    login.ShowDialog();
                    login = null;

                    this.Show();
                    this.usernameTextBox.SelectAll();

                }
                else
                {
                    MessageBox.Show("Username and or Password is incorrect. Try again",
                        "C# login form", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    usernameTextBox.Focus();
                    usernameTextBox.SelectAll();
                }
            }
            else
            {
                MessageBox.Show("Please enter username and password.","C# login Form" ,MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                usernameTextBox.Select();

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        //moveable borderless window
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


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (Register register = new Student_Management_System.Register())
            {
                register.ShowDialog();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(showPasswordCheckBox.Checked == true)
            {
                passwordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordTextBox.UseSystemPasswordChar = true;
            }
        }
    }
}
/*if (listBox1.SelectedItem == "Lecturer")
{

using (Dashboard dash = new Dashboard())
    {
        {
            dash.ShowDialog();
        }
    }
}
else if (listBox1.SelectedItem == "Student")
{
    using (Student_form student = new Student_Management_System.Student_form())

    {
        student.ShowDialog();
    }
}*/
