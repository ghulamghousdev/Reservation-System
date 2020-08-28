namespace AirlineReservationSystem
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.msgBox = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.airplaneID = new System.Windows.Forms.TextBox();
            this.tableNameHeader = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.deletePanel = new System.Windows.Forms.Panel();
            this.seats = new System.Windows.Forms.TextBox();
            this.regNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label111 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exitBtn = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.airlineIDBox = new System.Windows.Forms.ComboBox();
            this.category = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.deletePanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // msgBox
            // 
            this.msgBox.AutoSize = true;
            this.msgBox.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.msgBox.ForeColor = System.Drawing.Color.White;
            this.msgBox.Location = new System.Drawing.Point(429, 550);
            this.msgBox.Name = "msgBox";
            this.msgBox.Size = new System.Drawing.Size(0, 27);
            this.msgBox.TabIndex = 88;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            this.label2.Location = new System.Drawing.Point(451, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 36);
            this.label2.TabIndex = 28;
            this.label2.Text = "Management System";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Fax", 8F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(582, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(303, 18);
            this.label8.TabIndex = 87;
            this.label8.Text = "*Enter numeric value of max 3 char*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Fax", 8F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(582, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(294, 18);
            this.label10.TabIndex = 85;
            this.label10.Text = "*String should have exact length 8*";
            // 
            // airplaneID
            // 
            this.airplaneID.Location = new System.Drawing.Point(583, 74);
            this.airplaneID.Name = "airplaneID";
            this.airplaneID.Size = new System.Drawing.Size(292, 26);
            this.airplaneID.TabIndex = 80;
            this.airplaneID.TextChanged += new System.EventHandler(this.airplaneID_TextChanged);
            // 
            // tableNameHeader
            // 
            this.tableNameHeader.AutoSize = true;
            this.tableNameHeader.Font = new System.Drawing.Font("Arial", 21F);
            this.tableNameHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            this.tableNameHeader.Location = new System.Drawing.Point(600, 148);
            this.tableNameHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tableNameHeader.Name = "tableNameHeader";
            this.tableNameHeader.Size = new System.Drawing.Size(388, 47);
            this.tableNameHeader.TabIndex = 72;
            this.tableNameHeader.Text = "Add A New Airplane";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(202, 131);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(94, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 74;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this.panel3.Location = new System.Drawing.Point(202, 200);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1320, 8);
            this.panel3.TabIndex = 73;
            // 
            // deletePanel
            // 
            this.deletePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this.deletePanel.Controls.Add(this.label13);
            this.deletePanel.Controls.Add(this.label7);
            this.deletePanel.Controls.Add(this.category);
            this.deletePanel.Controls.Add(this.airlineIDBox);
            this.deletePanel.Controls.Add(this.label9);
            this.deletePanel.Controls.Add(this.label11);
            this.deletePanel.Controls.Add(this.label12);
            this.deletePanel.Controls.Add(this.msgBox);
            this.deletePanel.Controls.Add(this.label8);
            this.deletePanel.Controls.Add(this.label10);
            this.deletePanel.Controls.Add(this.airplaneID);
            this.deletePanel.Controls.Add(this.seats);
            this.deletePanel.Controls.Add(this.regNumber);
            this.deletePanel.Controls.Add(this.label5);
            this.deletePanel.Controls.Add(this.label4);
            this.deletePanel.Controls.Add(this.label111);
            this.deletePanel.Controls.Add(this.saveButton);
            this.deletePanel.Location = new System.Drawing.Point(192, 208);
            this.deletePanel.Name = "deletePanel";
            this.deletePanel.Size = new System.Drawing.Size(1329, 632);
            this.deletePanel.TabIndex = 75;
            // 
            // seats
            // 
            this.seats.Location = new System.Drawing.Point(583, 237);
            this.seats.Name = "seats";
            this.seats.Size = new System.Drawing.Size(292, 26);
            this.seats.TabIndex = 79;
            // 
            // regNumber
            // 
            this.regNumber.Location = new System.Drawing.Point(585, 155);
            this.regNumber.Name = "regNumber";
            this.regNumber.Size = new System.Drawing.Size(290, 26);
            this.regNumber.TabIndex = 78;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(311, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 27);
            this.label5.TabIndex = 77;
            this.label5.Text = "Reg Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(311, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 27);
            this.label4.TabIndex = 76;
            this.label4.Text = "Seats";
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.label111.ForeColor = System.Drawing.Color.White;
            this.label111.Location = new System.Drawing.Point(311, 74);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(150, 27);
            this.label111.TabIndex = 74;
            this.label111.Text = "Airplane ID";
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.saveButton.ForeColor = System.Drawing.Color.Black;
            this.saveButton.Location = new System.Drawing.Point(556, 474);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(104, 49);
            this.saveButton.TabIndex = 55;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            this.label3.Location = new System.Drawing.Point(335, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(548, 50);
            this.label3.TabIndex = 1;
            this.label3.Text = "Airline Reservation System";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.exitBtn);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(202, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1320, 128);
            this.panel2.TabIndex = 71;
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.Red;
            this.exitBtn.Location = new System.Drawing.Point(1251, 0);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(69, 62);
            this.exitBtn.TabIndex = 37;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox5.Enabled = false;
            this.pictureBox5.Location = new System.Drawing.Point(39, 55);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(106, 60);
            this.pictureBox5.TabIndex = 29;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(22, 155);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 27);
            this.label6.TabIndex = 30;
            this.label6.Text = "Dashboard";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Controls.Add(this.pictureBox5);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel7.Location = new System.Drawing.Point(0, 205);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(201, 220);
            this.panel7.TabIndex = 39;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(46)))), ((int)(((byte)(81)))));
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 840);
            this.panel1.TabIndex = 70;
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backBtn.BackgroundImage")));
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Location = new System.Drawing.Point(0, 0);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(201, 208);
            this.backBtn.TabIndex = 36;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Fax", 8F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(580, 351);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(233, 18);
            this.label9.TabIndex = 93;
            this.label9.Text = "*Select from above options*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(309, 321);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 27);
            this.label11.TabIndex = 90;
            this.label11.Text = "Category";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(309, 403);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 27);
            this.label12.TabIndex = 89;
            this.label12.Text = "Airline ID";
            // 
            // airlineIDBox
            // 
            this.airlineIDBox.FormattingEnabled = true;
            this.airlineIDBox.Items.AddRange(new object[] {
            "AirlineID"});
            this.airlineIDBox.Location = new System.Drawing.Point(585, 398);
            this.airlineIDBox.Name = "airlineIDBox";
            this.airlineIDBox.Size = new System.Drawing.Size(288, 28);
            this.airlineIDBox.TabIndex = 95;
            // 
            // category
            // 
            this.category.FormattingEnabled = true;
            this.category.Items.AddRange(new object[] {
            "Scheduled",
            "Chartered"});
            this.category.Location = new System.Drawing.Point(583, 320);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(288, 28);
            this.category.TabIndex = 96;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Fax", 8F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(582, 429);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(233, 18);
            this.label7.TabIndex = 97;
            this.label7.Text = "*Select from above options*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Fax", 8F);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(582, 184);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(294, 18);
            this.label13.TabIndex = 98;
            this.label13.Text = "*String should have exact length 8*";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1523, 840);
            this.Controls.Add(this.tableNameHeader);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.deletePanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.deletePanel.ResumeLayout(false);
            this.deletePanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label msgBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox airplaneID;
        private System.Windows.Forms.Label tableNameHeader;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel deletePanel;
        private System.Windows.Forms.TextBox seats;
        private System.Windows.Forms.TextBox regNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label111;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.ComboBox airlineIDBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox category;
    }
}