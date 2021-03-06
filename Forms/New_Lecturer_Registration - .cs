﻿using System;
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
    public partial class New_Lecturer_Registration_Form : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        public New_Lecturer_Registration_Form()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void New_Lecturer_Registration_Form_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }


        private void New_Lecturer_Registration_Form_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void New_Lecturer_Registration_Form_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }
    }
}
