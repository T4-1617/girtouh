namespace WinUpp_160916
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
            this.CarAvaiblelbl = new System.Windows.Forms.Label();
            this.Showcarbtn = new System.Windows.Forms.Button();
            this.Addcarbtn = new System.Windows.Forms.Button();
            this.Returncarbtn = new System.Windows.Forms.Button();
            this.Availablecarpnl = new System.Windows.Forms.Panel();
            this.Bookbtn = new System.Windows.Forms.Button();
            this.Avaiblecarlst = new System.Windows.Forms.ListBox();
            this.Addcarpnl = new System.Windows.Forms.Panel();
            this.Canceladdbtn = new System.Windows.Forms.Button();
            this.Confirmaddcarbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CarNumbertxt = new System.Windows.Forms.TextBox();
            this.CarColourtxt = new System.Windows.Forms.TextBox();
            this.CarModeltxt = new System.Windows.Forms.TextBox();
            this.CarMakertxt = new System.Windows.Forms.TextBox();
            this.Responselbl = new System.Windows.Forms.Label();
            this.Returncarpnl = new System.Windows.Forms.Panel();
            this.Carreturnlst = new System.Windows.Forms.ListBox();
            this.Cancelbtn2 = new System.Windows.Forms.Button();
            this.Returnconfirmbtn = new System.Windows.Forms.Button();
            this.Responselbl2 = new System.Windows.Forms.Label();
            this.lbldebug = new System.Windows.Forms.Label();
            this.ConfirmBookpnl = new System.Windows.Forms.Panel();
            this.FirstNametxt = new System.Windows.Forms.TextBox();
            this.LastNametxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ConfirmBookbtn = new System.Windows.Forms.Button();
            this.Cancelbtn3 = new System.Windows.Forms.Button();
            this.Availablecarpnl.SuspendLayout();
            this.Addcarpnl.SuspendLayout();
            this.Returncarpnl.SuspendLayout();
            this.ConfirmBookpnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // CarAvaiblelbl
            // 
            this.CarAvaiblelbl.AutoSize = true;
            this.CarAvaiblelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarAvaiblelbl.Location = new System.Drawing.Point(37, 20);
            this.CarAvaiblelbl.Name = "CarAvaiblelbl";
            this.CarAvaiblelbl.Size = new System.Drawing.Size(284, 29);
            this.CarAvaiblelbl.TabIndex = 0;
            this.CarAvaiblelbl.Text = "We have 3 cars available.";
            // 
            // Showcarbtn
            // 
            this.Showcarbtn.Location = new System.Drawing.Point(42, 82);
            this.Showcarbtn.Name = "Showcarbtn";
            this.Showcarbtn.Size = new System.Drawing.Size(138, 62);
            this.Showcarbtn.TabIndex = 1;
            this.Showcarbtn.Text = "Show cars";
            this.Showcarbtn.UseVisualStyleBackColor = true;
            this.Showcarbtn.Click += new System.EventHandler(this.Showcarbtn_Click);
            // 
            // Addcarbtn
            // 
            this.Addcarbtn.Location = new System.Drawing.Point(186, 82);
            this.Addcarbtn.Name = "Addcarbtn";
            this.Addcarbtn.Size = new System.Drawing.Size(138, 62);
            this.Addcarbtn.TabIndex = 2;
            this.Addcarbtn.Text = "Add car";
            this.Addcarbtn.UseVisualStyleBackColor = true;
            this.Addcarbtn.Click += new System.EventHandler(this.Addcarbtn_Click);
            // 
            // Returncarbtn
            // 
            this.Returncarbtn.Location = new System.Drawing.Point(330, 82);
            this.Returncarbtn.Name = "Returncarbtn";
            this.Returncarbtn.Size = new System.Drawing.Size(138, 62);
            this.Returncarbtn.TabIndex = 3;
            this.Returncarbtn.Text = "Return Car";
            this.Returncarbtn.UseVisualStyleBackColor = true;
            this.Returncarbtn.Click += new System.EventHandler(this.Returncarbtn_Click);
            // 
            // Availablecarpnl
            // 
            this.Availablecarpnl.Controls.Add(this.Bookbtn);
            this.Availablecarpnl.Controls.Add(this.Avaiblecarlst);
            this.Availablecarpnl.Location = new System.Drawing.Point(59, 178);
            this.Availablecarpnl.Name = "Availablecarpnl";
            this.Availablecarpnl.Size = new System.Drawing.Size(426, 300);
            this.Availablecarpnl.TabIndex = 4;
            // 
            // Bookbtn
            // 
            this.Bookbtn.Location = new System.Drawing.Point(4, 269);
            this.Bookbtn.Name = "Bookbtn";
            this.Bookbtn.Size = new System.Drawing.Size(131, 23);
            this.Bookbtn.TabIndex = 1;
            this.Bookbtn.Text = "Book";
            this.Bookbtn.UseVisualStyleBackColor = true;
            this.Bookbtn.Click += new System.EventHandler(this.Bookbtn_Click);
            // 
            // Avaiblecarlst
            // 
            this.Avaiblecarlst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Avaiblecarlst.FormattingEnabled = true;
            this.Avaiblecarlst.ItemHeight = 20;
            this.Avaiblecarlst.Location = new System.Drawing.Point(3, 11);
            this.Avaiblecarlst.Name = "Avaiblecarlst";
            this.Avaiblecarlst.Size = new System.Drawing.Size(420, 244);
            this.Avaiblecarlst.TabIndex = 0;
            // 
            // Addcarpnl
            // 
            this.Addcarpnl.Controls.Add(this.Canceladdbtn);
            this.Addcarpnl.Controls.Add(this.Confirmaddcarbtn);
            this.Addcarpnl.Controls.Add(this.label4);
            this.Addcarpnl.Controls.Add(this.label3);
            this.Addcarpnl.Controls.Add(this.label2);
            this.Addcarpnl.Controls.Add(this.label1);
            this.Addcarpnl.Controls.Add(this.CarNumbertxt);
            this.Addcarpnl.Controls.Add(this.CarColourtxt);
            this.Addcarpnl.Controls.Add(this.CarModeltxt);
            this.Addcarpnl.Controls.Add(this.CarMakertxt);
            this.Addcarpnl.Location = new System.Drawing.Point(62, 184);
            this.Addcarpnl.Name = "Addcarpnl";
            this.Addcarpnl.Size = new System.Drawing.Size(420, 297);
            this.Addcarpnl.TabIndex = 0;
            // 
            // Canceladdbtn
            // 
            this.Canceladdbtn.Location = new System.Drawing.Point(288, 225);
            this.Canceladdbtn.Name = "Canceladdbtn";
            this.Canceladdbtn.Size = new System.Drawing.Size(75, 41);
            this.Canceladdbtn.TabIndex = 9;
            this.Canceladdbtn.Text = "Cancel";
            this.Canceladdbtn.UseVisualStyleBackColor = true;
            this.Canceladdbtn.Click += new System.EventHandler(this.Canceladdbtn_Click);
            // 
            // Confirmaddcarbtn
            // 
            this.Confirmaddcarbtn.Location = new System.Drawing.Point(51, 225);
            this.Confirmaddcarbtn.Name = "Confirmaddcarbtn";
            this.Confirmaddcarbtn.Size = new System.Drawing.Size(75, 41);
            this.Confirmaddcarbtn.TabIndex = 8;
            this.Confirmaddcarbtn.Text = "Add car";
            this.Confirmaddcarbtn.UseVisualStyleBackColor = true;
            this.Confirmaddcarbtn.Click += new System.EventHandler(this.Confirmaddcarbtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Colour";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Model";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Maker";
            // 
            // CarNumbertxt
            // 
            this.CarNumbertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarNumbertxt.Location = new System.Drawing.Point(108, 144);
            this.CarNumbertxt.Name = "CarNumbertxt";
            this.CarNumbertxt.Size = new System.Drawing.Size(100, 26);
            this.CarNumbertxt.TabIndex = 3;
            // 
            // CarColourtxt
            // 
            this.CarColourtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarColourtxt.Location = new System.Drawing.Point(108, 112);
            this.CarColourtxt.Name = "CarColourtxt";
            this.CarColourtxt.Size = new System.Drawing.Size(100, 26);
            this.CarColourtxt.TabIndex = 2;
            // 
            // CarModeltxt
            // 
            this.CarModeltxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarModeltxt.Location = new System.Drawing.Point(108, 80);
            this.CarModeltxt.Name = "CarModeltxt";
            this.CarModeltxt.Size = new System.Drawing.Size(100, 26);
            this.CarModeltxt.TabIndex = 1;
            // 
            // CarMakertxt
            // 
            this.CarMakertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarMakertxt.Location = new System.Drawing.Point(108, 48);
            this.CarMakertxt.Name = "CarMakertxt";
            this.CarMakertxt.Size = new System.Drawing.Size(100, 26);
            this.CarMakertxt.TabIndex = 0;
            // 
            // Responselbl
            // 
            this.Responselbl.AutoSize = true;
            this.Responselbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Responselbl.Location = new System.Drawing.Point(494, 218);
            this.Responselbl.Name = "Responselbl";
            this.Responselbl.Size = new System.Drawing.Size(51, 20);
            this.Responselbl.TabIndex = 5;
            this.Responselbl.Text = "label1";
            // 
            // Returncarpnl
            // 
            this.Returncarpnl.Controls.Add(this.Carreturnlst);
            this.Returncarpnl.Controls.Add(this.Cancelbtn2);
            this.Returncarpnl.Controls.Add(this.Returnconfirmbtn);
            this.Returncarpnl.Location = new System.Drawing.Point(62, 184);
            this.Returncarpnl.Name = "Returncarpnl";
            this.Returncarpnl.Size = new System.Drawing.Size(426, 300);
            this.Returncarpnl.TabIndex = 5;
            // 
            // Carreturnlst
            // 
            this.Carreturnlst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Carreturnlst.FormattingEnabled = true;
            this.Carreturnlst.ItemHeight = 20;
            this.Carreturnlst.Location = new System.Drawing.Point(3, 11);
            this.Carreturnlst.Name = "Carreturnlst";
            this.Carreturnlst.Size = new System.Drawing.Size(420, 244);
            this.Carreturnlst.TabIndex = 0;
            // 
            // Cancelbtn2
            // 
            this.Cancelbtn2.Location = new System.Drawing.Point(268, 271);
            this.Cancelbtn2.Name = "Cancelbtn2";
            this.Cancelbtn2.Size = new System.Drawing.Size(131, 23);
            this.Cancelbtn2.TabIndex = 2;
            this.Cancelbtn2.Text = "Cancel";
            this.Cancelbtn2.UseVisualStyleBackColor = true;
            this.Cancelbtn2.Click += new System.EventHandler(this.Cancelbtn2_Click);
            // 
            // Returnconfirmbtn
            // 
            this.Returnconfirmbtn.Location = new System.Drawing.Point(4, 269);
            this.Returnconfirmbtn.Name = "Returnconfirmbtn";
            this.Returnconfirmbtn.Size = new System.Drawing.Size(131, 23);
            this.Returnconfirmbtn.TabIndex = 1;
            this.Returnconfirmbtn.Text = "Return";
            this.Returnconfirmbtn.UseVisualStyleBackColor = true;
            this.Returnconfirmbtn.Click += new System.EventHandler(this.Returnconfirmbtn_Click);
            // 
            // Responselbl2
            // 
            this.Responselbl2.AutoSize = true;
            this.Responselbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Responselbl2.Location = new System.Drawing.Point(494, 198);
            this.Responselbl2.Name = "Responselbl2";
            this.Responselbl2.Size = new System.Drawing.Size(51, 20);
            this.Responselbl2.TabIndex = 6;
            this.Responselbl2.Text = "label1";
            // 
            // lbldebug
            // 
            this.lbldebug.AutoSize = true;
            this.lbldebug.Location = new System.Drawing.Point(509, 35);
            this.lbldebug.Name = "lbldebug";
            this.lbldebug.Size = new System.Drawing.Size(35, 13);
            this.lbldebug.TabIndex = 7;
            this.lbldebug.Text = "label5";
            // 
            // ConfirmBookpnl
            // 
            this.ConfirmBookpnl.Controls.Add(this.Cancelbtn3);
            this.ConfirmBookpnl.Controls.Add(this.ConfirmBookbtn);
            this.ConfirmBookpnl.Controls.Add(this.label7);
            this.ConfirmBookpnl.Controls.Add(this.label6);
            this.ConfirmBookpnl.Controls.Add(this.label5);
            this.ConfirmBookpnl.Controls.Add(this.LastNametxt);
            this.ConfirmBookpnl.Controls.Add(this.FirstNametxt);
            this.ConfirmBookpnl.Location = new System.Drawing.Point(59, 178);
            this.ConfirmBookpnl.Name = "ConfirmBookpnl";
            this.ConfirmBookpnl.Size = new System.Drawing.Size(420, 292);
            this.ConfirmBookpnl.TabIndex = 2;
            // 
            // FirstNametxt
            // 
            this.FirstNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNametxt.Location = new System.Drawing.Point(127, 83);
            this.FirstNametxt.Name = "FirstNametxt";
            this.FirstNametxt.Size = new System.Drawing.Size(165, 29);
            this.FirstNametxt.TabIndex = 0;
            // 
            // LastNametxt
            // 
            this.LastNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNametxt.Location = new System.Drawing.Point(127, 126);
            this.LastNametxt.Name = "LastNametxt";
            this.LastNametxt.Size = new System.Drawing.Size(165, 29);
            this.LastNametxt.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Firstname";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "Lastname";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(85, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "Please enter your name";
            // 
            // ConfirmBookbtn
            // 
            this.ConfirmBookbtn.Location = new System.Drawing.Point(44, 217);
            this.ConfirmBookbtn.Name = "ConfirmBookbtn";
            this.ConfirmBookbtn.Size = new System.Drawing.Size(94, 38);
            this.ConfirmBookbtn.TabIndex = 5;
            this.ConfirmBookbtn.Text = "Confirm";
            this.ConfirmBookbtn.UseVisualStyleBackColor = true;
            this.ConfirmBookbtn.Click += new System.EventHandler(this.ConfirmBookbtn_Click);
            // 
            // Cancelbtn3
            // 
            this.Cancelbtn3.Location = new System.Drawing.Point(191, 217);
            this.Cancelbtn3.Name = "Cancelbtn3";
            this.Cancelbtn3.Size = new System.Drawing.Size(94, 38);
            this.Cancelbtn3.TabIndex = 6;
            this.Cancelbtn3.Text = "Cancel";
            this.Cancelbtn3.UseVisualStyleBackColor = true;
            this.Cancelbtn3.Click += new System.EventHandler(this.Cancelbtn3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 532);
            this.Controls.Add(this.ConfirmBookpnl);
            this.Controls.Add(this.lbldebug);
            this.Controls.Add(this.Responselbl2);
            this.Controls.Add(this.Responselbl);
            this.Controls.Add(this.Returncarbtn);
            this.Controls.Add(this.Addcarbtn);
            this.Controls.Add(this.Showcarbtn);
            this.Controls.Add(this.CarAvaiblelbl);
            this.Controls.Add(this.Availablecarpnl);
            this.Controls.Add(this.Addcarpnl);
            this.Controls.Add(this.Returncarpnl);
            this.Name = "Form1";
            this.Text = "ACME CARS";
            this.Availablecarpnl.ResumeLayout(false);
            this.Addcarpnl.ResumeLayout(false);
            this.Addcarpnl.PerformLayout();
            this.Returncarpnl.ResumeLayout(false);
            this.ConfirmBookpnl.ResumeLayout(false);
            this.ConfirmBookpnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CarAvaiblelbl;
        private System.Windows.Forms.Button Showcarbtn;
        private System.Windows.Forms.Button Addcarbtn;
        private System.Windows.Forms.Button Returncarbtn;
        private System.Windows.Forms.Panel Availablecarpnl;
        private System.Windows.Forms.Button Bookbtn;
        private System.Windows.Forms.ListBox Avaiblecarlst;
        private System.Windows.Forms.Panel Addcarpnl;
        private System.Windows.Forms.Label Responselbl;
        private System.Windows.Forms.Button Canceladdbtn;
        private System.Windows.Forms.Button Confirmaddcarbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CarNumbertxt;
        private System.Windows.Forms.TextBox CarColourtxt;
        private System.Windows.Forms.TextBox CarModeltxt;
        private System.Windows.Forms.TextBox CarMakertxt;
        private System.Windows.Forms.Panel Returncarpnl;
        private System.Windows.Forms.Button Cancelbtn2;
        private System.Windows.Forms.Button Returnconfirmbtn;
        private System.Windows.Forms.ListBox Carreturnlst;
        private System.Windows.Forms.Label Responselbl2;
        private System.Windows.Forms.Label lbldebug;
        private System.Windows.Forms.Panel ConfirmBookpnl;
        private System.Windows.Forms.Button Cancelbtn3;
        private System.Windows.Forms.Button ConfirmBookbtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox LastNametxt;
        private System.Windows.Forms.TextBox FirstNametxt;
    }
}

