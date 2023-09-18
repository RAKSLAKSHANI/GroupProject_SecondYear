namespace CarRadProject
{
    partial class Rental
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rental));
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RentDGV = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.IdTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FeesTb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CarRegCb = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CustNameTb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.CustCb = new System.Windows.Forms.ComboBox();
            this.RentDate1 = new System.Windows.Forms.TextBox();
            this.ReturnDate1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RentDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.guna2CirclePictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1153, 100);
            this.panel1.TabIndex = 4;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(14, 20);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(106, 73);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 15;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Font = new System.Drawing.Font("Rockwell Extra Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1096, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 35);
            this.label2.TabIndex = 6;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell Extra Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(525, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 35);
            this.label5.TabIndex = 5;
            this.label5.Text = " Rental";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(399, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 49);
            this.label1.TabIndex = 3;
            this.label1.Text = "Car Rental System";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 406);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 38);
            this.label6.TabIndex = 66;
            this.label6.Text = "Rental Date";
            // 
            // RentDGV
            // 
            this.RentDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RentDGV.Location = new System.Drawing.Point(499, 183);
            this.RentDGV.Name = "RentDGV";
            this.RentDGV.RowHeadersWidth = 51;
            this.RentDGV.RowTemplate.Height = 24;
            this.RentDGV.Size = new System.Drawing.Size(630, 426);
            this.RentDGV.TabIndex = 65;
            this.RentDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RentDGV_CellContentClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(145, 615);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(152, 37);
            this.button4.TabIndex = 64;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(304, 572);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 37);
            this.button3.TabIndex = 63;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(145, 572);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 37);
            this.button2.TabIndex = 62;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(14, 572);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 37);
            this.button1.TabIndex = 61;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IdTb
            // 
            this.IdTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTb.Location = new System.Drawing.Point(249, 186);
            this.IdTb.Name = "IdTb";
            this.IdTb.Size = new System.Drawing.Size(180, 30);
            this.IdTb.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 38);
            this.label3.TabIndex = 59;
            this.label3.Text = "Id";
            // 
            // FeesTb
            // 
            this.FeesTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeesTb.Location = new System.Drawing.Point(249, 522);
            this.FeesTb.Name = "FeesTb";
            this.FeesTb.Size = new System.Drawing.Size(180, 30);
            this.FeesTb.TabIndex = 58;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 522);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 38);
            this.label8.TabIndex = 56;
            this.label8.Text = "Fees";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 38);
            this.label7.TabIndex = 55;
            this.label7.Text = "CustId";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell Extra Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(695, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 35);
            this.label4.TabIndex = 68;
            this.label4.Text = "Cars on Rent";
            // 
            // CarRegCb
            // 
            this.CarRegCb.ForeColor = System.Drawing.Color.SkyBlue;
            this.CarRegCb.FormattingEnabled = true;
            this.CarRegCb.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.CarRegCb.Location = new System.Drawing.Point(249, 235);
            this.CarRegCb.Name = "CarRegCb";
            this.CarRegCb.Size = new System.Drawing.Size(180, 24);
            this.CarRegCb.TabIndex = 69;
            this.CarRegCb.SelectionChangeCommitted += new System.EventHandler(this.CarRegCb_SelectionChangeCommitted);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 38);
            this.label9.TabIndex = 70;
            this.label9.Text = "Car Reg";
            // 
            // CustNameTb
            // 
            this.CustNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustNameTb.Location = new System.Drawing.Point(249, 336);
            this.CustNameTb.Name = "CustNameTb";
            this.CustNameTb.Size = new System.Drawing.Size(180, 30);
            this.CustNameTb.TabIndex = 72;
            this.CustNameTb.TextChanged += new System.EventHandler(this.CustNameTb_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 336);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 38);
            this.label10.TabIndex = 71;
            this.label10.Text = "Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(23, 465);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(195, 38);
            this.label11.TabIndex = 74;
            this.label11.Text = "Return Date";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // CustCb
            // 
            this.CustCb.ForeColor = System.Drawing.Color.SkyBlue;
            this.CustCb.FormattingEnabled = true;
            this.CustCb.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.CustCb.Location = new System.Drawing.Point(249, 285);
            this.CustCb.Name = "CustCb";
            this.CustCb.Size = new System.Drawing.Size(180, 24);
            this.CustCb.TabIndex = 76;
            this.CustCb.SelectionChangeCommitted += new System.EventHandler(this.CustCb_SelectionChangeCommitted);
            // 
            // RentDate1
            // 
            this.RentDate1.Location = new System.Drawing.Point(249, 419);
            this.RentDate1.Name = "RentDate1";
            this.RentDate1.Size = new System.Drawing.Size(187, 22);
            this.RentDate1.TabIndex = 77;
            // 
            // ReturnDate1
            // 
            this.ReturnDate1.Location = new System.Drawing.Point(249, 481);
            this.ReturnDate1.Name = "ReturnDate1";
            this.ReturnDate1.Size = new System.Drawing.Size(187, 22);
            this.ReturnDate1.TabIndex = 78;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(249, 400);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 16);
            this.label12.TabIndex = 79;
            this.label12.Text = "MM.DD.YYYY";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(249, 462);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 16);
            this.label13.TabIndex = 80;
            this.label13.Text = "MM.DD.YYYY";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 664);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1153, 26);
            this.panel2.TabIndex = 81;
            // 
            // Rental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 690);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ReturnDate1);
            this.Controls.Add(this.RentDate1);
            this.Controls.Add(this.CustCb);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.CustNameTb);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CarRegCb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RentDGV);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.IdTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FeesTb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rental";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rental";
            this.Load += new System.EventHandler(this.Rental_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RentDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView RentDGV;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox IdTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FeesTb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CarRegCb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox CustNameTb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CustCb;
        private System.Windows.Forms.TextBox RentDate1;
        private System.Windows.Forms.TextBox ReturnDate1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel2;
    }
}