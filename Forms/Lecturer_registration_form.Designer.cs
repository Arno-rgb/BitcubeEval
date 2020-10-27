namespace Student_Management_System
{
    partial class Lecturer_registration_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lecturer_registration_form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.update_emp = new System.Windows.Forms.Button();
            this.add_emp = new System.Windows.Forms.Button();
            this.dlt_emp = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1333, 60);
            this.panel1.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SteelBlue;
            this.panel5.Location = new System.Drawing.Point(5, 88);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1325, 3);
            this.panel5.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(515, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lecturer Record";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1292, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 722);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1333, 5);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 662);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SteelBlue;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1328, 60);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 662);
            this.panel4.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.SteelBlue;
            this.panel6.Location = new System.Drawing.Point(5, 186);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1325, 3);
            this.panel6.TabIndex = 6;
            // 
            // update_emp
            // 
            this.update_emp.BackColor = System.Drawing.Color.SteelBlue;
            this.update_emp.FlatAppearance.BorderSize = 2;
            this.update_emp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.update_emp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_emp.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_emp.ForeColor = System.Drawing.Color.White;
            this.update_emp.Image = ((System.Drawing.Image)(resources.GetObject("update_emp.Image")));
            this.update_emp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.update_emp.Location = new System.Drawing.Point(391, 97);
            this.update_emp.Name = "update_emp";
            this.update_emp.Size = new System.Drawing.Size(300, 59);
            this.update_emp.TabIndex = 7;
            this.update_emp.Text = "       Update Employee";
            this.update_emp.UseVisualStyleBackColor = false;
            // 
            // add_emp
            // 
            this.add_emp.BackColor = System.Drawing.Color.SteelBlue;
            this.add_emp.FlatAppearance.BorderSize = 2;
            this.add_emp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.add_emp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_emp.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_emp.ForeColor = System.Drawing.Color.White;
            this.add_emp.Image = ((System.Drawing.Image)(resources.GetObject("add_emp.Image")));
            this.add_emp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add_emp.Location = new System.Drawing.Point(85, 97);
            this.add_emp.Name = "add_emp";
            this.add_emp.Size = new System.Drawing.Size(300, 59);
            this.add_emp.TabIndex = 8;
            this.add_emp.Text = "Add  New Employee";
            this.add_emp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add_emp.UseVisualStyleBackColor = false;
            this.add_emp.Click += new System.EventHandler(this.button2_Click);
            // 
            // dlt_emp
            // 
            this.dlt_emp.BackColor = System.Drawing.Color.SteelBlue;
            this.dlt_emp.FlatAppearance.BorderSize = 2;
            this.dlt_emp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.dlt_emp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dlt_emp.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dlt_emp.ForeColor = System.Drawing.Color.White;
            this.dlt_emp.Image = ((System.Drawing.Image)(resources.GetObject("dlt_emp.Image")));
            this.dlt_emp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dlt_emp.Location = new System.Drawing.Point(697, 97);
            this.dlt_emp.Name = "dlt_emp";
            this.dlt_emp.Size = new System.Drawing.Size(300, 59);
            this.dlt_emp.TabIndex = 9;
            this.dlt_emp.Text = "     Delete Employee";
            this.dlt_emp.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.SteelBlue;
            this.button5.FlatAppearance.BorderSize = 2;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(1003, 97);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(116, 59);
            this.button5.TabIndex = 10;
            this.button5.Text = "Print";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.UseWaitCursor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 196);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1308, 519);
            this.dataGridView1.TabIndex = 11;
            // 
            // Lecturer_registration_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 727);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dlt_emp);
            this.Controls.Add(this.add_emp);
            this.Controls.Add(this.update_emp);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Lecturer_registration_form";
            this.Text = "Lecturer_registration_form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button update_emp;
        private System.Windows.Forms.Button add_emp;
        private System.Windows.Forms.Button dlt_emp;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}