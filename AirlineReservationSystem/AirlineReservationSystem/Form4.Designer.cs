namespace AirlineReservationSystem
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.toCity = new System.Windows.Forms.ComboBox();
            this.airplaneIDBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.msgBox = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableNameHeader = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.deletePanel = new System.Windows.Forms.Panel();
            this.DM = new System.Windows.Forms.TextBox();
            this.DH = new System.Windows.Forms.TextBox();
            this.AM = new System.Windows.Forms.TextBox();
            this.AH = new System.Windows.Forms.TextBox();
            this.dateA = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dateD = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.h = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.fromCity = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.flightID = new System.Windows.Forms.TextBox();
            this.label111 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.deletePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // toCity
            // 
            this.toCity.FormattingEnabled = true;
            this.toCity.Items.AddRange(new object[] {
            "Scheduled",
            "Chartered"});
            this.toCity.Location = new System.Drawing.Point(245, 364);
            this.toCity.Name = "toCity";
            this.toCity.Size = new System.Drawing.Size(288, 28);
            this.toCity.TabIndex = 96;
            // 
            // airplaneIDBox
            // 
            this.airplaneIDBox.FormattingEnabled = true;
            this.airplaneIDBox.Items.AddRange(new object[] {
            "AirlineID"});
            this.airplaneIDBox.Location = new System.Drawing.Point(248, 205);
            this.airplaneIDBox.Name = "airplaneIDBox";
            this.airplaneIDBox.Size = new System.Drawing.Size(288, 28);
            this.airplaneIDBox.TabIndex = 95;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Fax", 8F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(242, 395);
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
            this.label11.Location = new System.Drawing.Point(59, 362);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 27);
            this.label11.TabIndex = 90;
            this.label11.Text = "To";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(60, 207);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 27);
            this.label12.TabIndex = 89;
            this.label12.Text = "Airplane ID";
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
            this.panel1.TabIndex = 76;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Controls.Add(this.label6);
            this.panel7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel7.Location = new System.Drawing.Point(0, 205);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(201, 220);
            this.panel7.TabIndex = 39;
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
            this.panel2.TabIndex = 77;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Fax", 8F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(245, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(233, 18);
            this.label7.TabIndex = 97;
            this.label7.Text = "*Select from above options*";
            // 
            // msgBox
            // 
            this.msgBox.AutoSize = true;
            this.msgBox.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.msgBox.ForeColor = System.Drawing.Color.White;
            this.msgBox.Location = new System.Drawing.Point(429, 584);
            this.msgBox.Name = "msgBox";
            this.msgBox.Size = new System.Drawing.Size(0, 27);
            this.msgBox.TabIndex = 88;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(59, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 27);
            this.label4.TabIndex = 76;
            this.label4.Text = "From";
            // 
            // tableNameHeader
            // 
            this.tableNameHeader.AutoSize = true;
            this.tableNameHeader.Font = new System.Drawing.Font("Arial", 21F);
            this.tableNameHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            this.tableNameHeader.Location = new System.Drawing.Point(640, 148);
            this.tableNameHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tableNameHeader.Name = "tableNameHeader";
            this.tableNameHeader.Size = new System.Drawing.Size(340, 47);
            this.tableNameHeader.TabIndex = 78;
            this.tableNameHeader.Text = "Add A New Flight";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(202, 131);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(94, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 80;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this.panel3.Location = new System.Drawing.Point(202, 200);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1320, 8);
            this.panel3.TabIndex = 79;
            // 
            // deletePanel
            // 
            this.deletePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this.deletePanel.Controls.Add(this.DM);
            this.deletePanel.Controls.Add(this.DH);
            this.deletePanel.Controls.Add(this.AM);
            this.deletePanel.Controls.Add(this.AH);
            this.deletePanel.Controls.Add(this.dateA);
            this.deletePanel.Controls.Add(this.label14);
            this.deletePanel.Controls.Add(this.label17);
            this.deletePanel.Controls.Add(this.dateD);
            this.deletePanel.Controls.Add(this.label1);
            this.deletePanel.Controls.Add(this.h);
            this.deletePanel.Controls.Add(this.label19);
            this.deletePanel.Controls.Add(this.label8);
            this.deletePanel.Controls.Add(this.fromCity);
            this.deletePanel.Controls.Add(this.label15);
            this.deletePanel.Controls.Add(this.label16);
            this.deletePanel.Controls.Add(this.label18);
            this.deletePanel.Controls.Add(this.label7);
            this.deletePanel.Controls.Add(this.toCity);
            this.deletePanel.Controls.Add(this.airplaneIDBox);
            this.deletePanel.Controls.Add(this.label9);
            this.deletePanel.Controls.Add(this.label11);
            this.deletePanel.Controls.Add(this.label12);
            this.deletePanel.Controls.Add(this.msgBox);
            this.deletePanel.Controls.Add(this.label10);
            this.deletePanel.Controls.Add(this.flightID);
            this.deletePanel.Controls.Add(this.label4);
            this.deletePanel.Controls.Add(this.label111);
            this.deletePanel.Controls.Add(this.saveButton);
            this.deletePanel.Location = new System.Drawing.Point(192, 208);
            this.deletePanel.Name = "deletePanel";
            this.deletePanel.Size = new System.Drawing.Size(1329, 632);
            this.deletePanel.TabIndex = 81;
            // 
            // DM
            // 
            this.DM.Location = new System.Drawing.Point(1036, 202);
            this.DM.Name = "DM";
            this.DM.Size = new System.Drawing.Size(55, 26);
            this.DM.TabIndex = 127;
            // 
            // DH
            // 
            this.DH.Location = new System.Drawing.Point(906, 200);
            this.DH.Name = "DH";
            this.DH.Size = new System.Drawing.Size(55, 26);
            this.DH.TabIndex = 126;
            // 
            // AM
            // 
            this.AM.Location = new System.Drawing.Point(1036, 123);
            this.AM.Name = "AM";
            this.AM.Size = new System.Drawing.Size(55, 26);
            this.AM.TabIndex = 125;
            // 
            // AH
            // 
            this.AH.Location = new System.Drawing.Point(906, 121);
            this.AH.Name = "AH";
            this.AH.Size = new System.Drawing.Size(55, 26);
            this.AH.TabIndex = 124;
            // 
            // dateA
            // 
            this.dateA.CustomFormat = "dd-MM-yyyy";
            this.dateA.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateA.Location = new System.Drawing.Point(906, 366);
            this.dateA.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dateA.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateA.Name = "dateA";
            this.dateA.Size = new System.Drawing.Size(146, 26);
            this.dateA.TabIndex = 123;
            this.dateA.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(694, 363);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(158, 27);
            this.label14.TabIndex = 122;
            this.label14.Text = "Arrival Date";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(694, 282);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(200, 27);
            this.label17.TabIndex = 121;
            this.label17.Text = "Departure Date";
            // 
            // dateD
            // 
            this.dateD.CustomFormat = "dd-MM-yyyy";
            this.dateD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateD.Location = new System.Drawing.Point(906, 287);
            this.dateD.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dateD.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateD.Name = "dateD";
            this.dateD.Size = new System.Drawing.Size(146, 26);
            this.dateD.TabIndex = 118;
            this.dateD.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 8F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1042, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 18);
            this.label1.TabIndex = 117;
            this.label1.Text = "Min";
            // 
            // h
            // 
            this.h.AutoSize = true;
            this.h.Font = new System.Drawing.Font("Lucida Fax", 8F);
            this.h.ForeColor = System.Drawing.Color.White;
            this.h.Location = new System.Drawing.Point(919, 234);
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(34, 18);
            this.h.TabIndex = 114;
            this.h.Text = "HH";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Lucida Fax", 8F);
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(1042, 152);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(38, 18);
            this.label19.TabIndex = 113;
            this.label19.Text = "Min";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Fax", 8F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(240, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(233, 18);
            this.label8.TabIndex = 109;
            this.label8.Text = "*Select from above options*";
            // 
            // fromCity
            // 
            this.fromCity.FormattingEnabled = true;
            this.fromCity.Items.AddRange(new object[] {
            "AirlineID"});
            this.fromCity.Location = new System.Drawing.Point(243, 285);
            this.fromCity.Name = "fromCity";
            this.fromCity.Size = new System.Drawing.Size(288, 28);
            this.fromCity.TabIndex = 108;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Lucida Fax", 8F);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(919, 153);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 18);
            this.label15.TabIndex = 105;
            this.label15.Text = "HH";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(694, 202);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(163, 27);
            this.label16.TabIndex = 101;
            this.label16.Text = "Arrival Time";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(694, 121);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(205, 27);
            this.label18.TabIndex = 99;
            this.label18.Text = "Departure Time";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Fax", 8F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(242, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(294, 18);
            this.label10.TabIndex = 85;
            this.label10.Text = "*String should have exact length 8*";
            // 
            // flightID
            // 
            this.flightID.Location = new System.Drawing.Point(243, 124);
            this.flightID.Name = "flightID";
            this.flightID.Size = new System.Drawing.Size(292, 26);
            this.flightID.TabIndex = 80;
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.label111.ForeColor = System.Drawing.Color.White;
            this.label111.Location = new System.Drawing.Point(59, 121);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(117, 27);
            this.label111.TabIndex = 74;
            this.label111.Text = "Flight ID";
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.saveButton.ForeColor = System.Drawing.Color.Black;
            this.saveButton.Location = new System.Drawing.Point(561, 509);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(104, 49);
            this.saveButton.TabIndex = 55;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1523, 840);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tableNameHeader);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.deletePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.deletePanel.ResumeLayout(false);
            this.deletePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox toCity;
        private System.Windows.Forms.ComboBox airplaneIDBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label msgBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label tableNameHeader;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel deletePanel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox flightID;
        private System.Windows.Forms.Label label111;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox fromCity;
        private System.Windows.Forms.DateTimePicker dateA;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dateD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label h;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox DM;
        private System.Windows.Forms.TextBox DH;
        private System.Windows.Forms.TextBox AM;
        private System.Windows.Forms.TextBox AH;
    }
}