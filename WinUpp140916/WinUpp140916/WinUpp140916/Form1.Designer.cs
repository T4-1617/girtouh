namespace WinUpp140916
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
            this.Carlist = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InfoField = new System.Windows.Forms.Panel();
            this.Reglbl = new System.Windows.Forms.Label();
            this.Colourlbl = new System.Windows.Forms.Label();
            this.EditBtn = new System.Windows.Forms.Button();
            this.Carnamelbl = new System.Windows.Forms.Label();
            this.Addbtn = new System.Windows.Forms.Button();
            this.EditField = new System.Windows.Forms.Panel();
            this.Regtxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Colourtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Savebtn = new System.Windows.Forms.Button();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.Typetxt = new System.Windows.Forms.TextBox();
            this.InfoField.SuspendLayout();
            this.EditField.SuspendLayout();
            this.SuspendLayout();
            // 
            // Carlist
            // 
            this.Carlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Carlist.FormattingEnabled = true;
            this.Carlist.ItemHeight = 29;
            this.Carlist.Location = new System.Drawing.Point(52, 66);
            this.Carlist.Name = "Carlist";
            this.Carlist.Size = new System.Drawing.Size(174, 236);
            this.Carlist.TabIndex = 0;
            this.Carlist.SelectedIndexChanged += new System.EventHandler(this.Carlist_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bilar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "Clock on a car for details, \r\nor press add to add one.";
            // 
            // InfoField
            // 
            this.InfoField.Controls.Add(this.Reglbl);
            this.InfoField.Controls.Add(this.Colourlbl);
            this.InfoField.Controls.Add(this.EditBtn);
            this.InfoField.Controls.Add(this.Carnamelbl);
            this.InfoField.Location = new System.Drawing.Point(354, 66);
            this.InfoField.Name = "InfoField";
            this.InfoField.Size = new System.Drawing.Size(200, 236);
            this.InfoField.TabIndex = 3;
            // 
            // Reglbl
            // 
            this.Reglbl.AutoSize = true;
            this.Reglbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reglbl.Location = new System.Drawing.Point(13, 59);
            this.Reglbl.Name = "Reglbl";
            this.Reglbl.Size = new System.Drawing.Size(70, 25);
            this.Reglbl.TabIndex = 3;
            this.Reglbl.Text = "label7";
            // 
            // Colourlbl
            // 
            this.Colourlbl.AutoSize = true;
            this.Colourlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Colourlbl.Location = new System.Drawing.Point(13, 34);
            this.Colourlbl.Name = "Colourlbl";
            this.Colourlbl.Size = new System.Drawing.Size(70, 25);
            this.Colourlbl.TabIndex = 2;
            this.Colourlbl.Text = "label6";
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(18, 194);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(75, 23);
            this.EditBtn.TabIndex = 1;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // Carnamelbl
            // 
            this.Carnamelbl.AutoSize = true;
            this.Carnamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Carnamelbl.Location = new System.Drawing.Point(13, 9);
            this.Carnamelbl.Name = "Carnamelbl";
            this.Carnamelbl.Size = new System.Drawing.Size(104, 25);
            this.Carnamelbl.TabIndex = 0;
            this.Carnamelbl.Text = "Add a car";
            // 
            // Addbtn
            // 
            this.Addbtn.Location = new System.Drawing.Point(52, 348);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(75, 23);
            this.Addbtn.TabIndex = 4;
            this.Addbtn.Text = "Add car";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // EditField
            // 
            this.EditField.Controls.Add(this.Regtxt);
            this.EditField.Controls.Add(this.label5);
            this.EditField.Controls.Add(this.Colourtxt);
            this.EditField.Controls.Add(this.label4);
            this.EditField.Controls.Add(this.label3);
            this.EditField.Controls.Add(this.Savebtn);
            this.EditField.Controls.Add(this.Cancelbtn);
            this.EditField.Controls.Add(this.Typetxt);
            this.EditField.Location = new System.Drawing.Point(7, 12);
            this.EditField.Name = "EditField";
            this.EditField.Size = new System.Drawing.Size(649, 414);
            this.EditField.TabIndex = 6;
            // 
            // Regtxt
            // 
            this.Regtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regtxt.Location = new System.Drawing.Point(128, 92);
            this.Regtxt.Name = "Regtxt";
            this.Regtxt.Size = new System.Drawing.Size(100, 26);
            this.Regtxt.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Reg. Number";
            // 
            // Colourtxt
            // 
            this.Colourtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Colourtxt.Location = new System.Drawing.Point(128, 57);
            this.Colourtxt.Name = "Colourtxt";
            this.Colourtxt.Size = new System.Drawing.Size(100, 26);
            this.Colourtxt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Colour";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Type";
            // 
            // Savebtn
            // 
            this.Savebtn.Location = new System.Drawing.Point(57, 315);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(75, 23);
            this.Savebtn.TabIndex = 2;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.Location = new System.Drawing.Point(319, 316);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(75, 23);
            this.Cancelbtn.TabIndex = 1;
            this.Cancelbtn.Text = "Cancel";
            this.Cancelbtn.UseVisualStyleBackColor = true;
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // Typetxt
            // 
            this.Typetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Typetxt.Location = new System.Drawing.Point(128, 22);
            this.Typetxt.Name = "Typetxt";
            this.Typetxt.Size = new System.Drawing.Size(100, 26);
            this.Typetxt.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 438);
            this.Controls.Add(this.EditField);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.InfoField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Carlist);
            this.Name = "Form1";
            this.Text = "Form1";
            this.InfoField.ResumeLayout(false);
            this.InfoField.PerformLayout();
            this.EditField.ResumeLayout(false);
            this.EditField.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Carlist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel InfoField;
        private System.Windows.Forms.Label Carnamelbl;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Label Reglbl;
        private System.Windows.Forms.Label Colourlbl;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Panel EditField;
        private System.Windows.Forms.TextBox Regtxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Colourtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Button Cancelbtn;
        private System.Windows.Forms.TextBox Typetxt;
    }
}

