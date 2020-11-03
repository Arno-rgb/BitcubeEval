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
    public partial class Register : Form
    {
        public SqlDataReader dr { get; private set; }

        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-HS8CGAC;Initial Catalog=School;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            cn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtconfirmpassword.Text != string.Empty || txtconfirmpassword.Text != string.Empty || txtusername.Text != string.Empty)
            {
                if (txtconfirmpassword.Text == txtconfirmpassword.Text)
                {
                    SqlConnection cn = null;
                    SqlCommand cmd = new SqlCommand("select * from LoginTable where username='" + txtusername.Text + "'", cn);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dr.Close();
                        cmd = new SqlCommand("insert into LoginTable values(@username,@password)", cn);
                        cmd.Parameters.AddWithValue("username", txtusername.Text);
                        cmd.Parameters.AddWithValue("password", txtconfirmpassword.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter both password same ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
