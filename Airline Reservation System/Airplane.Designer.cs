namespace Airline_Reservation_System
{
    partial class Airplane
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.deleteAirplaneButton = new System.Windows.Forms.Button();
            this.airlineForm = new System.Windows.Forms.Button();
            this.airportForm = new System.Windows.Forms.Button();
            this.updateAirplaneButton = new System.Windows.Forms.Button();
            this.addAirplaneButton = new System.Windows.Forms.Button();
            this.scehduleForm = new System.Windows.Forms.Button();
            this.airplaneForm = new System.Windows.Forms.Button();
            this.flightForm = new System.Windows.Forms.Button();
            this.addAirplanePanel = new System.Windows.Forms.Panel();
            this.saveIntoDatabase = new System.Windows.Forms.Button();
            this.airlineIDLabel = new System.Windows.Forms.Label();
            this.noOfAirplanesLabel = new System.Windows.Forms.Label();
            this.airplaneIDLabel = new System.Windows.Forms.Label();
            this.regNumberBox = new System.Windows.Forms.TextBox();
            this.airplaneIDBox = new System.Windows.Forms.TextBox();
            this.airlineIDBox = new System.Windows.Forms.TextBox();
            this.error = new System.Windows.Forms.Label();
            this.seatsLabel = new System.Windows.Forms.Label();
            this.seatsBox = new System.Windows.Forms.TextBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.msgLabel = new System.Windows.Forms.Label();
            this.errorMsg = new System.Windows.Forms.Label();
            this.updateAirplanePanel = new System.Windows.Forms.Panel();
            this.msgAlert = new System.Windows.Forms.Label();
            this.miniUpdatePanel = new System.Windows.Forms.Panel();
            this.propertyLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.property_Box = new System.Windows.Forms.TextBox();
            this.airplaneID_InputBox = new System.Windows.Forms.TextBox();
            this.updateSubmission_Button = new System.Windows.Forms.Button();
            this.updateComboBox = new System.Windows.Forms.ComboBox();
            this.ask_Label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.airplaneUpdationGrid = new System.Windows.Forms.DataGridView();
            this.AirportID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.airportName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.airportCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteAirplanePanel = new System.Windows.Forms.Panel();
            this.errorLabel = new System.Windows.Forms.Label();
            this.airplaneIDDeleteBox = new System.Windows.Forms.TextBox();
            this.deleteAirplaneConfrmButton = new System.Windows.Forms.Button();
            this.airlineLabel = new System.Windows.Forms.Label();
            this.deleteLabel = new System.Windows.Forms.Label();
            this.deleteAirplaneGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.addAirplanePanel.SuspendLayout();
            this.updateAirplanePanel.SuspendLayout();
            this.miniUpdatePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.airplaneUpdationGrid)).BeginInit();
            this.deleteAirplanePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteAirplaneGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.deleteAirplaneButton);
            this.panel1.Controls.Add(this.airlineForm);
            this.panel1.Controls.Add(this.airportForm);
            this.panel1.Controls.Add(this.updateAirplaneButton);
            this.panel1.Controls.Add(this.addAirplaneButton);
            this.panel1.Controls.Add(this.scehduleForm);
            this.panel1.Controls.Add(this.airplaneForm);
            this.panel1.Controls.Add(this.flightForm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 646);
            this.panel1.TabIndex = 4;
            // 
            // deleteAirplaneButton
            // 
            this.deleteAirplaneButton.BackColor = System.Drawing.Color.LimeGreen;
            this.deleteAirplaneButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.deleteAirplaneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAirplaneButton.ForeColor = System.Drawing.Color.White;
            this.deleteAirplaneButton.Location = new System.Drawing.Point(0, 328);
            this.deleteAirplaneButton.Name = "deleteAirplaneButton";
            this.deleteAirplaneButton.Size = new System.Drawing.Size(187, 46);
            this.deleteAirplaneButton.TabIndex = 25;
            this.deleteAirplaneButton.Text = "Delete Airplane";
            this.deleteAirplaneButton.UseVisualStyleBackColor = false;
            this.deleteAirplaneButton.Click += new System.EventHandler(this.deleteAirplaneButton_Click);
            // 
            // airlineForm
            // 
            this.airlineForm.Cursor = System.Windows.Forms.Cursors.Default;
            this.airlineForm.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airlineForm.Location = new System.Drawing.Point(0, 133);
            this.airlineForm.Name = "airlineForm";
            this.airlineForm.Size = new System.Drawing.Size(192, 43);
            this.airlineForm.TabIndex = 11;
            this.airlineForm.Text = "Airlines";
            this.airlineForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.airlineForm.UseVisualStyleBackColor = true;
            this.airlineForm.Click += new System.EventHandler(this.airlineForm_Click);
            // 
            // airportForm
            // 
            this.airportForm.Cursor = System.Windows.Forms.Cursors.Default;
            this.airportForm.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airportForm.Location = new System.Drawing.Point(-1, 91);
            this.airportForm.Name = "airportForm";
            this.airportForm.Size = new System.Drawing.Size(192, 43);
            this.airportForm.TabIndex = 10;
            this.airportForm.Text = "Airports";
            this.airportForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.airportForm.UseVisualStyleBackColor = true;
            this.airportForm.Click += new System.EventHandler(this.airportForm_Click);
            // 
            // updateAirplaneButton
            // 
            this.updateAirplaneButton.BackColor = System.Drawing.Color.LimeGreen;
            this.updateAirplaneButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.updateAirplaneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateAirplaneButton.ForeColor = System.Drawing.Color.White;
            this.updateAirplaneButton.Location = new System.Drawing.Point(1, 286);
            this.updateAirplaneButton.Name = "updateAirplaneButton";
            this.updateAirplaneButton.Size = new System.Drawing.Size(186, 46);
            this.updateAirplaneButton.TabIndex = 24;
            this.updateAirplaneButton.Text = "Update Airplane";
            this.updateAirplaneButton.UseVisualStyleBackColor = false;
            this.updateAirplaneButton.Click += new System.EventHandler(this.updateAirplaneButton_Click);
            // 
            // addAirplaneButton
            // 
            this.addAirplaneButton.BackColor = System.Drawing.Color.LimeGreen;
            this.addAirplaneButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.addAirplaneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAirplaneButton.ForeColor = System.Drawing.Color.White;
            this.addAirplaneButton.Location = new System.Drawing.Point(3, 244);
            this.addAirplaneButton.Name = "addAirplaneButton";
            this.addAirplaneButton.Size = new System.Drawing.Size(187, 46);
            this.addAirplaneButton.TabIndex = 22;
            this.addAirplaneButton.Text = "Add Airplane";
            this.addAirplaneButton.UseVisualStyleBackColor = false;
            this.addAirplaneButton.Click += new System.EventHandler(this.addAirplaneButton_Click);
            // 
            // scehduleForm
            // 
            this.scehduleForm.Cursor = System.Windows.Forms.Cursors.Default;
            this.scehduleForm.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scehduleForm.Location = new System.Drawing.Point(0, 176);
            this.scehduleForm.Name = "scehduleForm";
            this.scehduleForm.Size = new System.Drawing.Size(192, 43);
            this.scehduleForm.TabIndex = 8;
            this.scehduleForm.Text = "Flight Scehdules";
            this.scehduleForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.scehduleForm.UseVisualStyleBackColor = true;
            this.scehduleForm.Click += new System.EventHandler(this.scehduleForm_Click);
            // 
            // airplaneForm
            // 
            this.airplaneForm.Cursor = System.Windows.Forms.Cursors.Default;
            this.airplaneForm.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airplaneForm.Location = new System.Drawing.Point(-1, 44);
            this.airplaneForm.Name = "airplaneForm";
            this.airplaneForm.Size = new System.Drawing.Size(192, 47);
            this.airplaneForm.TabIndex = 7;
            this.airplaneForm.Text = "Airplanes";
            this.airplaneForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.airplaneForm.UseVisualStyleBackColor = true;
            this.airplaneForm.Click += new System.EventHandler(this.airplaneForm_Click);
            // 
            // flightForm
            // 
            this.flightForm.Cursor = System.Windows.Forms.Cursors.Default;
            this.flightForm.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightForm.Location = new System.Drawing.Point(0, 0);
            this.flightForm.Name = "flightForm";
            this.flightForm.Size = new System.Drawing.Size(192, 43);
            this.flightForm.TabIndex = 4;
            this.flightForm.Text = "Flights";
            this.flightForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.flightForm.UseVisualStyleBackColor = true;
            this.flightForm.Click += new System.EventHandler(this.flightForm_Click);
            // 
            // addAirplanePanel
            // 
            this.addAirplanePanel.AutoScroll = true;
            this.addAirplanePanel.Controls.Add(this.errorMsg);
            this.addAirplanePanel.Controls.Add(this.msgLabel);
            this.addAirplanePanel.Controls.Add(this.categoryBox);
            this.addAirplanePanel.Controls.Add(this.CategoryLabel);
            this.addAirplanePanel.Controls.Add(this.seatsLabel);
            this.addAirplanePanel.Controls.Add(this.seatsBox);
            this.addAirplanePanel.Controls.Add(this.saveIntoDatabase);
            this.addAirplanePanel.Controls.Add(this.airlineIDLabel);
            this.addAirplanePanel.Controls.Add(this.noOfAirplanesLabel);
            this.addAirplanePanel.Controls.Add(this.airplaneIDLabel);
            this.addAirplanePanel.Controls.Add(this.regNumberBox);
            this.addAirplanePanel.Controls.Add(this.airplaneIDBox);
            this.addAirplanePanel.Controls.Add(this.airlineIDBox);
            this.addAirplanePanel.Controls.Add(this.error);
            this.addAirplanePanel.Location = new System.Drawing.Point(199, 0);
            this.addAirplanePanel.Name = "addAirplanePanel";
            this.addAirplanePanel.Size = new System.Drawing.Size(1040, 631);
            this.addAirplanePanel.TabIndex = 24;
            // 
            // saveIntoDatabase
            // 
            this.saveIntoDatabase.BackColor = System.Drawing.Color.LimeGreen;
            this.saveIntoDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveIntoDatabase.ForeColor = System.Drawing.Color.White;
            this.saveIntoDatabase.Location = new System.Drawing.Point(389, 356);
            this.saveIntoDatabase.Name = "saveIntoDatabase";
            this.saveIntoDatabase.Size = new System.Drawing.Size(158, 46);
            this.saveIntoDatabase.TabIndex = 52;
            this.saveIntoDatabase.Text = "Save";
            this.saveIntoDatabase.UseVisualStyleBackColor = false;
            this.saveIntoDatabase.Click += new System.EventHandler(this.saveAirplaneIntoDatabase_Click);
            // 
            // airlineIDLabel
            // 
            this.airlineIDLabel.AutoSize = true;
            this.airlineIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.airlineIDLabel.Location = new System.Drawing.Point(203, 133);
            this.airlineIDLabel.Name = "airlineIDLabel";
            this.airlineIDLabel.Size = new System.Drawing.Size(101, 26);
            this.airlineIDLabel.TabIndex = 51;
            this.airlineIDLabel.Text = "Airline ID";
            // 
            // noOfAirplanesLabel
            // 
            this.noOfAirplanesLabel.AutoSize = true;
            this.noOfAirplanesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.noOfAirplanesLabel.Location = new System.Drawing.Point(203, 176);
            this.noOfAirplanesLabel.Name = "noOfAirplanesLabel";
            this.noOfAirplanesLabel.Size = new System.Drawing.Size(136, 26);
            this.noOfAirplanesLabel.TabIndex = 50;
            this.noOfAirplanesLabel.Text = "Reg Number";
            // 
            // airplaneIDLabel
            // 
            this.airplaneIDLabel.AutoSize = true;
            this.airplaneIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.airplaneIDLabel.Location = new System.Drawing.Point(203, 82);
            this.airplaneIDLabel.Name = "airplaneIDLabel";
            this.airplaneIDLabel.Size = new System.Drawing.Size(120, 26);
            this.airplaneIDLabel.TabIndex = 48;
            this.airplaneIDLabel.Text = "Airplane ID";
            // 
            // regNumberBox
            // 
            this.regNumberBox.Location = new System.Drawing.Point(389, 176);
            this.regNumberBox.Name = "regNumberBox";
            this.regNumberBox.Size = new System.Drawing.Size(325, 26);
            this.regNumberBox.TabIndex = 45;
            // 
            // airplaneIDBox
            // 
            this.airplaneIDBox.Location = new System.Drawing.Point(389, 82);
            this.airplaneIDBox.Name = "airplaneIDBox";
            this.airplaneIDBox.Size = new System.Drawing.Size(325, 26);
            this.airplaneIDBox.TabIndex = 44;
            // 
            // airlineIDBox
            // 
            this.airlineIDBox.Location = new System.Drawing.Point(389, 133);
            this.airlineIDBox.Name = "airlineIDBox";
            this.airlineIDBox.Size = new System.Drawing.Size(325, 26);
            this.airlineIDBox.TabIndex = 43;
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(492, 367);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 25);
            this.error.TabIndex = 25;
            // 
            // seatsLabel
            // 
            this.seatsLabel.AutoSize = true;
            this.seatsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.seatsLabel.Location = new System.Drawing.Point(203, 230);
            this.seatsLabel.Name = "seatsLabel";
            this.seatsLabel.Size = new System.Drawing.Size(68, 26);
            this.seatsLabel.TabIndex = 54;
            this.seatsLabel.Text = "Seats";
            // 
            // seatsBox
            // 
            this.seatsBox.Location = new System.Drawing.Point(389, 230);
            this.seatsBox.Name = "seatsBox";
            this.seatsBox.Size = new System.Drawing.Size(325, 26);
            this.seatsBox.TabIndex = 53;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.CategoryLabel.Location = new System.Drawing.Point(203, 280);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(100, 26);
            this.CategoryLabel.TabIndex = 55;
            this.CategoryLabel.Text = "Category";
            // 
            // categoryBox
            // 
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Items.AddRange(new object[] {
            "Scehduled",
            "Chartered"});
            this.categoryBox.Location = new System.Drawing.Point(389, 282);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(325, 28);
            this.categoryBox.TabIndex = 56;
            // 
            // msgLabel
            // 
            this.msgLabel.AutoSize = true;
            this.msgLabel.Font = new System.Drawing.Font("Gill Sans MT", 14F, System.Drawing.FontStyle.Bold);
            this.msgLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.msgLabel.Location = new System.Drawing.Point(361, 430);
            this.msgLabel.Name = "msgLabel";
            this.msgLabel.Size = new System.Drawing.Size(0, 39);
            this.msgLabel.TabIndex = 57;
            // 
            // errorMsg
            // 
            this.errorMsg.AutoSize = true;
            this.errorMsg.Font = new System.Drawing.Font("Gill Sans MT", 14F, System.Drawing.FontStyle.Bold);
            this.errorMsg.ForeColor = System.Drawing.Color.Red;
            this.errorMsg.Location = new System.Drawing.Point(361, 478);
            this.errorMsg.Name = "errorMsg";
            this.errorMsg.Size = new System.Drawing.Size(0, 39);
            this.errorMsg.TabIndex = 58;
            // 
            // updateAirplanePanel
            // 
            this.updateAirplanePanel.Controls.Add(this.deleteAirplanePanel);
            this.updateAirplanePanel.Controls.Add(this.msgAlert);
            this.updateAirplanePanel.Controls.Add(this.miniUpdatePanel);
            this.updateAirplanePanel.Controls.Add(this.updateSubmission_Button);
            this.updateAirplanePanel.Controls.Add(this.updateComboBox);
            this.updateAirplanePanel.Controls.Add(this.ask_Label);
            this.updateAirplanePanel.Controls.Add(this.label6);
            this.updateAirplanePanel.Controls.Add(this.airplaneUpdationGrid);
            this.updateAirplanePanel.Location = new System.Drawing.Point(239, 12);
            this.updateAirplanePanel.Name = "updateAirplanePanel";
            this.updateAirplanePanel.Size = new System.Drawing.Size(962, 609);
            this.updateAirplanePanel.TabIndex = 26;
            this.updateAirplanePanel.Visible = false;
            // 
            // msgAlert
            // 
            this.msgAlert.AutoSize = true;
            this.msgAlert.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.msgAlert.ForeColor = System.Drawing.Color.Green;
            this.msgAlert.Location = new System.Drawing.Point(59, 454);
            this.msgAlert.Name = "msgAlert";
            this.msgAlert.Size = new System.Drawing.Size(0, 31);
            this.msgAlert.TabIndex = 26;
            // 
            // miniUpdatePanel
            // 
            this.miniUpdatePanel.Controls.Add(this.propertyLabel);
            this.miniUpdatePanel.Controls.Add(this.label5);
            this.miniUpdatePanel.Controls.Add(this.property_Box);
            this.miniUpdatePanel.Controls.Add(this.airplaneID_InputBox);
            this.miniUpdatePanel.Location = new System.Drawing.Point(7, 183);
            this.miniUpdatePanel.Name = "miniUpdatePanel";
            this.miniUpdatePanel.Size = new System.Drawing.Size(379, 184);
            this.miniUpdatePanel.TabIndex = 24;
            this.miniUpdatePanel.Visible = false;
            // 
            // propertyLabel
            // 
            this.propertyLabel.AutoSize = true;
            this.propertyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.propertyLabel.Location = new System.Drawing.Point(10, 106);
            this.propertyLabel.Name = "propertyLabel";
            this.propertyLabel.Size = new System.Drawing.Size(0, 25);
            this.propertyLabel.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(7, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "AirplaneID";
            // 
            // property_Box
            // 
            this.property_Box.Location = new System.Drawing.Point(162, 104);
            this.property_Box.Name = "property_Box";
            this.property_Box.Size = new System.Drawing.Size(205, 26);
            this.property_Box.TabIndex = 1;
            // 
            // airplaneID_InputBox
            // 
            this.airplaneID_InputBox.Location = new System.Drawing.Point(162, 59);
            this.airplaneID_InputBox.Name = "airplaneID_InputBox";
            this.airplaneID_InputBox.Size = new System.Drawing.Size(205, 26);
            this.airplaneID_InputBox.TabIndex = 0;
            // 
            // updateSubmission_Button
            // 
            this.updateSubmission_Button.BackColor = System.Drawing.Color.LimeGreen;
            this.updateSubmission_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateSubmission_Button.ForeColor = System.Drawing.Color.White;
            this.updateSubmission_Button.Location = new System.Drawing.Point(64, 389);
            this.updateSubmission_Button.Name = "updateSubmission_Button";
            this.updateSubmission_Button.Size = new System.Drawing.Size(187, 46);
            this.updateSubmission_Button.TabIndex = 23;
            this.updateSubmission_Button.Text = "Update";
            this.updateSubmission_Button.UseVisualStyleBackColor = false;
            this.updateSubmission_Button.Click += new System.EventHandler(this.updateSubmission_Button_Click);
            // 
            // updateComboBox
            // 
            this.updateComboBox.FormattingEnabled = true;
            this.updateComboBox.Items.AddRange(new object[] {
            "Reg_Number",
            "Seats",
            "Category"});
            this.updateComboBox.Location = new System.Drawing.Point(22, 149);
            this.updateComboBox.Name = "updateComboBox";
            this.updateComboBox.Size = new System.Drawing.Size(266, 28);
            this.updateComboBox.TabIndex = 4;
            this.updateComboBox.SelectedIndexChanged += new System.EventHandler(this.updateComboBox_SelectedIndexChanged);
            // 
            // ask_Label
            // 
            this.ask_Label.AutoSize = true;
            this.ask_Label.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ask_Label.Location = new System.Drawing.Point(11, 95);
            this.ask_Label.Name = "ask_Label";
            this.ask_Label.Size = new System.Drawing.Size(290, 28);
            this.ask_Label.TabIndex = 2;
            this.ask_Label.Text = "Attribute Want to Change";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Myriad Pro", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(317, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(237, 35);
            this.label6.TabIndex = 1;
            this.label6.Text = "Update Airplanee";
            // 
            // airplaneUpdationGrid
            // 
            this.airplaneUpdationGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.airplaneUpdationGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AirportID,
            this.airportName,
            this.airportCity,
            this.seats,
            this.Category});
            this.airplaneUpdationGrid.Location = new System.Drawing.Point(392, 111);
            this.airplaneUpdationGrid.Name = "airplaneUpdationGrid";
            this.airplaneUpdationGrid.RowHeadersWidth = 62;
            this.airplaneUpdationGrid.RowTemplate.Height = 28;
            this.airplaneUpdationGrid.Size = new System.Drawing.Size(562, 489);
            this.airplaneUpdationGrid.TabIndex = 0;
            // 
            // AirportID
            // 
            this.AirportID.HeaderText = "Airplane ID";
            this.AirportID.MinimumWidth = 8;
            this.AirportID.Name = "AirportID";
            this.AirportID.Width = 150;
            // 
            // airportName
            // 
            this.airportName.HeaderText = "Airline ID";
            this.airportName.MinimumWidth = 8;
            this.airportName.Name = "airportName";
            this.airportName.Width = 150;
            // 
            // airportCity
            // 
            this.airportCity.HeaderText = "Reg Number";
            this.airportCity.MinimumWidth = 8;
            this.airportCity.Name = "airportCity";
            this.airportCity.Width = 150;
            // 
            // seats
            // 
            this.seats.HeaderText = "Seats";
            this.seats.MinimumWidth = 4;
            this.seats.Name = "seats";
            this.seats.Width = 150;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 8;
            this.Category.Name = "Category";
            this.Category.Width = 150;
            // 
            // deleteAirplanePanel
            // 
            this.deleteAirplanePanel.Controls.Add(this.deleteAirplaneGrid);
            this.deleteAirplanePanel.Controls.Add(this.errorLabel);
            this.deleteAirplanePanel.Controls.Add(this.airplaneIDDeleteBox);
            this.deleteAirplanePanel.Controls.Add(this.deleteAirplaneConfrmButton);
            this.deleteAirplanePanel.Controls.Add(this.airlineLabel);
            this.deleteAirplanePanel.Controls.Add(this.deleteLabel);
            this.deleteAirplanePanel.Location = new System.Drawing.Point(536, 32);
            this.deleteAirplanePanel.Name = "deleteAirplanePanel";
            this.deleteAirplanePanel.Size = new System.Drawing.Size(987, 631);
            this.deleteAirplanePanel.TabIndex = 27;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(46, 412);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 23);
            this.errorLabel.TabIndex = 31;
            // 
            // airplaneIDDeleteBox
            // 
            this.airplaneIDDeleteBox.Location = new System.Drawing.Point(22, 247);
            this.airplaneIDDeleteBox.Name = "airplaneIDDeleteBox";
            this.airplaneIDDeleteBox.Size = new System.Drawing.Size(272, 26);
            this.airplaneIDDeleteBox.TabIndex = 30;
            // 
            // deleteAirplaneConfrmButton
            // 
            this.deleteAirplaneConfrmButton.BackColor = System.Drawing.Color.LimeGreen;
            this.deleteAirplaneConfrmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAirplaneConfrmButton.ForeColor = System.Drawing.Color.White;
            this.deleteAirplaneConfrmButton.Location = new System.Drawing.Point(35, 317);
            this.deleteAirplaneConfrmButton.Name = "deleteAirplaneConfrmButton";
            this.deleteAirplaneConfrmButton.Size = new System.Drawing.Size(187, 46);
            this.deleteAirplaneConfrmButton.TabIndex = 29;
            this.deleteAirplaneConfrmButton.Text = "Delete";
            this.deleteAirplaneConfrmButton.UseVisualStyleBackColor = false;
            this.deleteAirplaneConfrmButton.Click += new System.EventHandler(this.deleteAirplaneConfrmButton_Click);
            // 
            // airlineLabel
            // 
            this.airlineLabel.AutoSize = true;
            this.airlineLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airlineLabel.Location = new System.Drawing.Point(21, 203);
            this.airlineLabel.Name = "airlineLabel";
            this.airlineLabel.Size = new System.Drawing.Size(287, 28);
            this.airlineLabel.TabIndex = 27;
            this.airlineLabel.Text = "Airline ID Want to Delete";
            // 
            // deleteLabel
            // 
            this.deleteLabel.AutoSize = true;
            this.deleteLabel.Font = new System.Drawing.Font("Myriad Pro", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteLabel.Location = new System.Drawing.Point(277, 16);
            this.deleteLabel.Name = "deleteLabel";
            this.deleteLabel.Size = new System.Drawing.Size(211, 35);
            this.deleteLabel.TabIndex = 26;
            this.deleteLabel.Text = "Delete Airplane";
            // 
            // deleteAirplaneGrid
            // 
            this.deleteAirplaneGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deleteAirplaneGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.deleteAirplaneGrid.Location = new System.Drawing.Point(367, 111);
            this.deleteAirplaneGrid.Name = "deleteAirplaneGrid";
            this.deleteAirplaneGrid.RowHeadersWidth = 62;
            this.deleteAirplaneGrid.RowTemplate.Height = 28;
            this.deleteAirplaneGrid.Size = new System.Drawing.Size(591, 505);
            this.deleteAirplaneGrid.TabIndex = 32;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Airplane ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Airline ID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Reg Number";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Seats";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 4;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Category";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // Airplane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 646);
            this.Controls.Add(this.updateAirplanePanel);
            this.Controls.Add(this.addAirplanePanel);
            this.Controls.Add(this.panel1);
            this.Name = "Airplane";
            this.Text = "Airplane";
            this.Load += new System.EventHandler(this.Airplane_Load);
            this.Click += new System.EventHandler(this.scehduleForm_Click);
            this.panel1.ResumeLayout(false);
            this.addAirplanePanel.ResumeLayout(false);
            this.addAirplanePanel.PerformLayout();
            this.updateAirplanePanel.ResumeLayout(false);
            this.updateAirplanePanel.PerformLayout();
            this.miniUpdatePanel.ResumeLayout(false);
            this.miniUpdatePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.airplaneUpdationGrid)).EndInit();
            this.deleteAirplanePanel.ResumeLayout(false);
            this.deleteAirplanePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteAirplaneGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button deleteAirplaneButton;
        private System.Windows.Forms.Button airlineForm;
        private System.Windows.Forms.Button airportForm;
        private System.Windows.Forms.Button updateAirplaneButton;
        private System.Windows.Forms.Button addAirplaneButton;
        private System.Windows.Forms.Button scehduleForm;
        private System.Windows.Forms.Button airplaneForm;
        private System.Windows.Forms.Button flightForm;
        private System.Windows.Forms.Panel addAirplanePanel;
        private System.Windows.Forms.Button saveIntoDatabase;
        private System.Windows.Forms.Label airlineIDLabel;
        private System.Windows.Forms.Label noOfAirplanesLabel;
        private System.Windows.Forms.Label airplaneIDLabel;
        private System.Windows.Forms.TextBox regNumberBox;
        private System.Windows.Forms.TextBox airplaneIDBox;
        private System.Windows.Forms.TextBox airlineIDBox;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.ComboBox categoryBox;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label seatsLabel;
        private System.Windows.Forms.TextBox seatsBox;
        private System.Windows.Forms.Label errorMsg;
        private System.Windows.Forms.Label msgLabel;
        private System.Windows.Forms.Panel updateAirplanePanel;
        private System.Windows.Forms.Label msgAlert;
        private System.Windows.Forms.Panel miniUpdatePanel;
        private System.Windows.Forms.Label propertyLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox property_Box;
        private System.Windows.Forms.TextBox airplaneID_InputBox;
        private System.Windows.Forms.Button updateSubmission_Button;
        private System.Windows.Forms.ComboBox updateComboBox;
        private System.Windows.Forms.Label ask_Label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView airplaneUpdationGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn AirportID;
        private System.Windows.Forms.DataGridViewTextBoxColumn airportName;
        private System.Windows.Forms.DataGridViewTextBoxColumn airportCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn seats;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.Panel deleteAirplanePanel;
        private System.Windows.Forms.DataGridView deleteAirplaneGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.TextBox airplaneIDDeleteBox;
        private System.Windows.Forms.Button deleteAirplaneConfrmButton;
        private System.Windows.Forms.Label airlineLabel;
        private System.Windows.Forms.Label deleteLabel;
    }
}