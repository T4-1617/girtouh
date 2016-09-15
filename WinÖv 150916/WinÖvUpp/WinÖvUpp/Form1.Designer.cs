namespace WinÖvUpp
{
    partial class Form1
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
            this.FirstNametxt = new System.Windows.Forms.TextBox();
            this.LastNametxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Customerradbtn = new System.Windows.Forms.RadioButton();
            this.Employeeradbtn = new System.Windows.Forms.RadioButton();
            this.Addbtn = new System.Windows.Forms.Button();
            this.CustomerlistBox = new System.Windows.Forms.ListBox();
            this.EmployeelistBox = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FirstNametxt
            // 
            this.FirstNametxt.Location = new System.Drawing.Point(129, 12);
            this.FirstNametxt.Name = "FirstNametxt";
            this.FirstNametxt.Size = new System.Drawing.Size(100, 20);
            this.FirstNametxt.TabIndex = 0;
            // 
            // LastNametxt
            // 
            this.LastNametxt.Location = new System.Drawing.Point(313, 12);
            this.LastNametxt.Name = "LastNametxt";
            this.LastNametxt.Size = new System.Drawing.Size(100, 20);
            this.LastNametxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "FirstName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "LastName";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Employeeradbtn);
            this.groupBox1.Controls.Add(this.Customerradbtn);
            this.groupBox1.Location = new System.Drawing.Point(72, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 38);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // Customerradbtn
            // 
            this.Customerradbtn.AutoSize = true;
            this.Customerradbtn.Location = new System.Drawing.Point(6, 15);
            this.Customerradbtn.Name = "Customerradbtn";
            this.Customerradbtn.Size = new System.Drawing.Size(69, 17);
            this.Customerradbtn.TabIndex = 0;
            this.Customerradbtn.TabStop = true;
            this.Customerradbtn.Text = "Customer";
            this.Customerradbtn.UseVisualStyleBackColor = true;
            // 
            // Employeeradbtn
            // 
            this.Employeeradbtn.AutoSize = true;
            this.Employeeradbtn.Location = new System.Drawing.Point(114, 15);
            this.Employeeradbtn.Name = "Employeeradbtn";
            this.Employeeradbtn.Size = new System.Drawing.Size(71, 17);
            this.Employeeradbtn.TabIndex = 1;
            this.Employeeradbtn.TabStop = true;
            this.Employeeradbtn.Text = "Employee";
            this.Employeeradbtn.UseVisualStyleBackColor = true;
            // 
            // Addbtn
            // 
            this.Addbtn.Location = new System.Drawing.Point(313, 81);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(75, 23);
            this.Addbtn.TabIndex = 5;
            this.Addbtn.Text = "Add";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // CustomerlistBox
            // 
            this.CustomerlistBox.FormattingEnabled = true;
            this.CustomerlistBox.Location = new System.Drawing.Point(72, 128);
            this.CustomerlistBox.Name = "CustomerlistBox";
            this.CustomerlistBox.Size = new System.Drawing.Size(316, 147);
            this.CustomerlistBox.TabIndex = 6;
            // 
            // EmployeelistBox
            // 
            this.EmployeelistBox.FormattingEnabled = true;
            this.EmployeelistBox.Location = new System.Drawing.Point(72, 329);
            this.EmployeelistBox.Name = "EmployeelistBox";
            this.EmployeelistBox.Size = new System.Drawing.Size(316, 147);
            this.EmployeelistBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 540);
            this.Controls.Add(this.EmployeelistBox);
            this.Controls.Add(this.CustomerlistBox);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LastNametxt);
            this.Controls.Add(this.FirstNametxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstNametxt;
        private System.Windows.Forms.TextBox LastNametxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Employeeradbtn;
        private System.Windows.Forms.RadioButton Customerradbtn;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.ListBox CustomerlistBox;
        private System.Windows.Forms.ListBox EmployeelistBox;
    }
}

