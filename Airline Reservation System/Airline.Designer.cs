namespace Airline_Reservation_System
{
    partial class Airline
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
            this.deleteAirlineButton = new System.Windows.Forms.Button();
            this.airlineForm = new System.Windows.Forms.Button();
            this.airportForm = new System.Windows.Forms.Button();
            this.updateAirlineButton = new System.Windows.Forms.Button();
            this.addAirlineButton = new System.Windows.Forms.Button();
            this.scehduleForm = new System.Windows.Forms.Button();
            this.airplaneForm = new System.Windows.Forms.Button();
            this.flightForm = new System.Windows.Forms.Button();
            this.addAirportPanel = new System.Windows.Forms.Panel();
            this.saveIntoDatabase = new System.Windows.Forms.Button();
            this.airlineNameLabel = new System.Windows.Forms.Label();
            this.noOfAirplanesLabel = new System.Windows.Forms.Label();
            this.airlineIDLabel = new System.Windows.Forms.Label();
            this.noOfAirplanesBox = new System.Windows.Forms.TextBox();
            this.airlineIDBox = new System.Windows.Forms.TextBox();
            this.airlineNameBox = new System.Windows.Forms.TextBox();
            this.error = new System.Windows.Forms.Label();
            this.deleteAirportPanel = new System.Windows.Forms.Panel();
            this.errorLabel = new System.Windows.Forms.Label();
            this.airlineIDDeleteBox = new System.Windows.Forms.TextBox();
            this.deleteAirlineConfrmButton = new System.Windows.Forms.Button();
            this.airlineLabel = new System.Windows.Forms.Label();
            this.deleteLabel = new System.Windows.Forms.Label();
            this.deleteAirlineGrid = new System.Windows.Forms.DataGridView();
            this.airlineID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.airlineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Airplanes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateAirportPanel = new System.Windows.Forms.Panel();
            this.errorMsg = new System.Windows.Forms.Label();
            this.miniUpdatePanel = new System.Windows.Forms.Panel();
            this.propertyLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.property_Box = new System.Windows.Forms.TextBox();
            this.airlineID_InputBox = new System.Windows.Forms.TextBox();
            this.updateSubmission_Button = new System.Windows.Forms.Button();
            this.updateComboBox = new System.Windows.Forms.ComboBox();
            this.ask_Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.airlineUpdationGrid = new System.Windows.Forms.DataGridView();
            this.AirportID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.airportName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.airportCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.addAirportPanel.SuspendLayout();
            this.deleteAirportPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteAirlineGrid)).BeginInit();
            this.updateAirportPanel.SuspendLayout();
            this.miniUpdatePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.airlineUpdationGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.deleteAirlineButton);
            this.panel1.Controls.Add(this.airlineForm);
            this.panel1.Controls.Add(this.airportForm);
            this.panel1.Controls.Add(this.updateAirlineButton);
            this.panel1.Controls.Add(this.addAirlineButton);
            this.panel1.Controls.Add(this.scehduleForm);
            this.panel1.Controls.Add(this.airplaneForm);
            this.panel1.Controls.Add(this.flightForm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 630);
            this.panel1.TabIndex = 3;
            // 
            // deleteAirlineButton
            // 
            this.deleteAirlineButton.BackColor = System.Drawing.Color.LimeGreen;
            this.deleteAirlineButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.deleteAirlineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAirlineButton.ForeColor = System.Drawing.Color.White;
            this.deleteAirlineButton.Location = new System.Drawing.Point(0, 328);
            this.deleteAirlineButton.Name = "deleteAirlineButton";
            this.deleteAirlineButton.Size = new System.Drawing.Size(187, 46);
            this.deleteAirlineButton.TabIndex = 25;
            this.deleteAirlineButton.Text = "Delete Airline";
            this.deleteAirlineButton.UseVisualStyleBackColor = false;
            this.deleteAirlineButton.Click += new System.EventHandler(this.deleteAirlineButton_Click);
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
            // updateAirlineButton
            // 
            this.updateAirlineButton.BackColor = System.Drawing.Color.LimeGreen;
            this.updateAirlineButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.updateAirlineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateAirlineButton.ForeColor = System.Drawing.Color.White;
            this.updateAirlineButton.Location = new System.Drawing.Point(1, 286);
            this.updateAirlineButton.Name = "updateAirlineButton";
            this.updateAirlineButton.Size = new System.Drawing.Size(186, 46);
            this.updateAirlineButton.TabIndex = 24;
            this.updateAirlineButton.Text = "Update Airline";
            this.updateAirlineButton.UseVisualStyleBackColor = false;
            this.updateAirlineButton.Click += new System.EventHandler(this.updateAirlineButton_Click);
            // 
            // addAirlineButton
            // 
            this.addAirlineButton.BackColor = System.Drawing.Color.LimeGreen;
            this.addAirlineButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.addAirlineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAirlineButton.ForeColor = System.Drawing.Color.White;
            this.addAirlineButton.Location = new System.Drawing.Point(3, 244);
            this.addAirlineButton.Name = "addAirlineButton";
            this.addAirlineButton.Size = new System.Drawing.Size(187, 46);
            this.addAirlineButton.TabIndex = 22;
            this.addAirlineButton.Text = "Add Airline";
            this.addAirlineButton.UseVisualStyleBackColor = false;
            this.addAirlineButton.Click += new System.EventHandler(this.addAirlineButton_Click);
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
            // addAirportPanel
            // 
            this.addAirportPanel.AutoScroll = true;
            this.addAirportPanel.Controls.Add(this.saveIntoDatabase);
            this.addAirportPanel.Controls.Add(this.airlineNameLabel);
            this.addAirportPanel.Controls.Add(this.noOfAirplanesLabel);
            this.addAirportPanel.Controls.Add(this.airlineIDLabel);
            this.addAirportPanel.Controls.Add(this.noOfAirplanesBox);
            this.addAirportPanel.Controls.Add(this.airlineIDBox);
            this.addAirportPanel.Controls.Add(this.airlineNameBox);
            this.addAirportPanel.Controls.Add(this.error);
            this.addAirportPanel.Location = new System.Drawing.Point(201, 6);
            this.addAirportPanel.Name = "addAirportPanel";
            this.addAirportPanel.Size = new System.Drawing.Size(900, 630);
            this.addAirportPanel.TabIndex = 23;
            // 
            // saveIntoDatabase
            // 
            this.saveIntoDatabase.BackColor = System.Drawing.Color.LimeGreen;
            this.saveIntoDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveIntoDatabase.ForeColor = System.Drawing.Color.White;
            this.saveIntoDatabase.Location = new System.Drawing.Point(340, 394);
            this.saveIntoDatabase.Name = "saveIntoDatabase";
            this.saveIntoDatabase.Size = new System.Drawing.Size(158, 46);
            this.saveIntoDatabase.TabIndex = 52;
            this.saveIntoDatabase.Text = "Save";
            this.saveIntoDatabase.UseVisualStyleBackColor = false;
            this.saveIntoDatabase.Click += new System.EventHandler(this.saveAirlineIntoDatabase_Click);
            // 
            // airlineNameLabel
            // 
            this.airlineNameLabel.AutoSize = true;
            this.airlineNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.airlineNameLabel.Location = new System.Drawing.Point(177, 262);
            this.airlineNameLabel.Name = "airlineNameLabel";
            this.airlineNameLabel.Size = new System.Drawing.Size(138, 26);
            this.airlineNameLabel.TabIndex = 51;
            this.airlineNameLabel.Text = "Airline Name";
            // 
            // noOfAirplanesLabel
            // 
            this.noOfAirplanesLabel.AutoSize = true;
            this.noOfAirplanesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.noOfAirplanesLabel.Location = new System.Drawing.Point(177, 305);
            this.noOfAirplanesLabel.Name = "noOfAirplanesLabel";
            this.noOfAirplanesLabel.Size = new System.Drawing.Size(161, 26);
            this.noOfAirplanesLabel.TabIndex = 50;
            this.noOfAirplanesLabel.Text = "No of Airplanes";
            // 
            // airlineIDLabel
            // 
            this.airlineIDLabel.AutoSize = true;
            this.airlineIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.airlineIDLabel.Location = new System.Drawing.Point(177, 211);
            this.airlineIDLabel.Name = "airlineIDLabel";
            this.airlineIDLabel.Size = new System.Drawing.Size(101, 26);
            this.airlineIDLabel.TabIndex = 48;
            this.airlineIDLabel.Text = "Airline ID";
            // 
            // noOfAirplanesBox
            // 
            this.noOfAirplanesBox.Location = new System.Drawing.Point(350, 305);
            this.noOfAirplanesBox.Name = "noOfAirplanesBox";
            this.noOfAirplanesBox.Size = new System.Drawing.Size(325, 26);
            this.noOfAirplanesBox.TabIndex = 45;
            // 
            // airlineIDBox
            // 
            this.airlineIDBox.Location = new System.Drawing.Point(350, 211);
            this.airlineIDBox.Name = "airlineIDBox";
            this.airlineIDBox.Size = new System.Drawing.Size(325, 26);
            this.airlineIDBox.TabIndex = 44;
            // 
            // airlineNameBox
            // 
            this.airlineNameBox.Location = new System.Drawing.Point(350, 262);
            this.airlineNameBox.Name = "airlineNameBox";
            this.airlineNameBox.Size = new System.Drawing.Size(325, 26);
            this.airlineNameBox.TabIndex = 43;
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(504, 435);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 25);
            this.error.TabIndex = 25;
            // 
            // deleteAirportPanel
            // 
            this.deleteAirportPanel.Controls.Add(this.errorLabel);
            this.deleteAirportPanel.Controls.Add(this.airlineIDDeleteBox);
            this.deleteAirportPanel.Controls.Add(this.deleteAirlineConfrmButton);
            this.deleteAirportPanel.Controls.Add(this.airlineLabel);
            this.deleteAirportPanel.Controls.Add(this.deleteLabel);
            this.deleteAirportPanel.Controls.Add(this.deleteAirlineGrid);
            this.deleteAirportPanel.Location = new System.Drawing.Point(241, 0);
            this.deleteAirportPanel.Name = "deleteAirportPanel";
            this.deleteAirportPanel.Size = new System.Drawing.Size(897, 618);
            this.deleteAirportPanel.TabIndex = 25;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(42, 312);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 23);
            this.errorLabel.TabIndex = 31;
            // 
            // airlineIDDeleteBox
            // 
            this.airlineIDDeleteBox.Location = new System.Drawing.Point(22, 247);
            this.airlineIDDeleteBox.Name = "airlineIDDeleteBox";
            this.airlineIDDeleteBox.Size = new System.Drawing.Size(272, 26);
            this.airlineIDDeleteBox.TabIndex = 30;
            // 
            // deleteAirlineConfrmButton
            // 
            this.deleteAirlineConfrmButton.BackColor = System.Drawing.Color.LimeGreen;
            this.deleteAirlineConfrmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAirlineConfrmButton.ForeColor = System.Drawing.Color.White;
            this.deleteAirlineConfrmButton.Location = new System.Drawing.Point(35, 357);
            this.deleteAirlineConfrmButton.Name = "deleteAirlineConfrmButton";
            this.deleteAirlineConfrmButton.Size = new System.Drawing.Size(187, 46);
            this.deleteAirlineConfrmButton.TabIndex = 29;
            this.deleteAirlineConfrmButton.Text = "Delete";
            this.deleteAirlineConfrmButton.UseVisualStyleBackColor = false;
            this.deleteAirlineConfrmButton.Click += new System.EventHandler(this.deleteAirlineConfrmButton_Click);
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
            this.deleteLabel.Size = new System.Drawing.Size(195, 35);
            this.deleteLabel.TabIndex = 26;
            this.deleteLabel.Text = "Delete Airport";
            // 
            // deleteAirlineGrid
            // 
            this.deleteAirlineGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deleteAirlineGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.airlineID,
            this.airlineName,
            this.Airplanes});
            this.deleteAirlineGrid.Location = new System.Drawing.Point(339, 54);
            this.deleteAirlineGrid.Name = "deleteAirlineGrid";
            this.deleteAirlineGrid.RowHeadersWidth = 62;
            this.deleteAirlineGrid.RowTemplate.Height = 28;
            this.deleteAirlineGrid.Size = new System.Drawing.Size(539, 564);
            this.deleteAirlineGrid.TabIndex = 25;
            // 
            // airlineID
            // 
            this.airlineID.HeaderText = "AirlineID";
            this.airlineID.MinimumWidth = 8;
            this.airlineID.Name = "airlineID";
            this.airlineID.Width = 150;
            // 
            // airlineName
            // 
            this.airlineName.HeaderText = "Airline Name";
            this.airlineName.MinimumWidth = 8;
            this.airlineName.Name = "airlineName";
            this.airlineName.Width = 150;
            // 
            // Airplanes
            // 
            this.Airplanes.HeaderText = "No of Airplanes";
            this.Airplanes.MinimumWidth = 8;
            this.Airplanes.Name = "Airplanes";
            this.Airplanes.Width = 150;
            // 
            // updateAirportPanel
            // 
            this.updateAirportPanel.Controls.Add(this.errorMsg);
            this.updateAirportPanel.Controls.Add(this.miniUpdatePanel);
            this.updateAirportPanel.Controls.Add(this.updateSubmission_Button);
            this.updateAirportPanel.Controls.Add(this.updateComboBox);
            this.updateAirportPanel.Controls.Add(this.ask_Label);
            this.updateAirportPanel.Controls.Add(this.label1);
            this.updateAirportPanel.Controls.Add(this.airlineUpdationGrid);
            this.updateAirportPanel.Location = new System.Drawing.Point(221, 3);
            this.updateAirportPanel.Name = "updateAirportPanel";
            this.updateAirportPanel.Size = new System.Drawing.Size(880, 586);
            this.updateAirportPanel.TabIndex = 25;
            this.updateAirportPanel.Visible = false;
            // 
            // errorMsg
            // 
            this.errorMsg.AutoSize = true;
            this.errorMsg.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMsg.ForeColor = System.Drawing.Color.Red;
            this.errorMsg.Location = new System.Drawing.Point(59, 454);
            this.errorMsg.Name = "errorMsg";
            this.errorMsg.Size = new System.Drawing.Size(0, 28);
            this.errorMsg.TabIndex = 26;
            // 
            // miniUpdatePanel
            // 
            this.miniUpdatePanel.Controls.Add(this.propertyLabel);
            this.miniUpdatePanel.Controls.Add(this.label2);
            this.miniUpdatePanel.Controls.Add(this.property_Box);
            this.miniUpdatePanel.Controls.Add(this.airlineID_InputBox);
            this.miniUpdatePanel.Location = new System.Drawing.Point(7, 183);
            this.miniUpdatePanel.Name = "miniUpdatePanel";
            this.miniUpdatePanel.Size = new System.Drawing.Size(339, 184);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(7, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "AirlineID";
            // 
            // property_Box
            // 
            this.property_Box.Location = new System.Drawing.Point(131, 105);
            this.property_Box.Name = "property_Box";
            this.property_Box.Size = new System.Drawing.Size(205, 26);
            this.property_Box.TabIndex = 1;
            // 
            // airlineID_InputBox
            // 
            this.airlineID_InputBox.Location = new System.Drawing.Point(131, 60);
            this.airlineID_InputBox.Name = "airlineID_InputBox";
            this.airlineID_InputBox.Size = new System.Drawing.Size(205, 26);
            this.airlineID_InputBox.TabIndex = 0;
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
            "Airline_Name",
            "No of Airplanes"});
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myriad Pro", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Update Airline";
            // 
            // airlineUpdationGrid
            // 
            this.airlineUpdationGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.airlineUpdationGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AirportID,
            this.airportName,
            this.airportCity});
            this.airlineUpdationGrid.Location = new System.Drawing.Point(352, 47);
            this.airlineUpdationGrid.Name = "airlineUpdationGrid";
            this.airlineUpdationGrid.RowHeadersWidth = 62;
            this.airlineUpdationGrid.RowTemplate.Height = 28;
            this.airlineUpdationGrid.Size = new System.Drawing.Size(509, 527);
            this.airlineUpdationGrid.TabIndex = 0;
            // 
            // AirportID
            // 
            this.AirportID.HeaderText = "AirlineID";
            this.AirportID.MinimumWidth = 8;
            this.AirportID.Name = "AirportID";
            this.AirportID.Width = 150;
            // 
            // airportName
            // 
            this.airportName.HeaderText = "Airline Name";
            this.airportName.MinimumWidth = 8;
            this.airportName.Name = "airportName";
            this.airportName.Width = 150;
            // 
            // airportCity
            // 
            this.airportCity.HeaderText = "No of Airplanes";
            this.airportCity.MinimumWidth = 8;
            this.airportCity.Name = "airportCity";
            this.airportCity.Width = 150;
            // 
            // Airline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 630);
            this.Controls.Add(this.addAirportPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.updateAirportPanel);
            this.Controls.Add(this.deleteAirportPanel);
            this.Name = "Airline";
            this.Text = "Airline";
            this.Load += new System.EventHandler(this.Airline_Load);
            this.panel1.ResumeLayout(false);
            this.addAirportPanel.ResumeLayout(false);
            this.addAirportPanel.PerformLayout();
            this.deleteAirportPanel.ResumeLayout(false);
            this.deleteAirportPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteAirlineGrid)).EndInit();
            this.updateAirportPanel.ResumeLayout(false);
            this.updateAirportPanel.PerformLayout();
            this.miniUpdatePanel.ResumeLayout(false);
            this.miniUpdatePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.airlineUpdationGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button deleteAirlineButton;
        private System.Windows.Forms.Button updateAirlineButton;
        private System.Windows.Forms.Button addAirlineButton;
        private System.Windows.Forms.Button airlineForm;
        private System.Windows.Forms.Button airportForm;
        private System.Windows.Forms.Button scehduleForm;
        private System.Windows.Forms.Button airplaneForm;
        private System.Windows.Forms.Button flightForm;
        private System.Windows.Forms.Panel addAirportPanel;
        private System.Windows.Forms.Button saveIntoDatabase;
        private System.Windows.Forms.Panel deleteAirportPanel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Panel updateAirportPanel;
        private System.Windows.Forms.Label errorMsg;
        private System.Windows.Forms.Panel miniUpdatePanel;
        private System.Windows.Forms.Label propertyLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox property_Box;
        private System.Windows.Forms.TextBox airlineID_InputBox;
        private System.Windows.Forms.Button updateSubmission_Button;
        private System.Windows.Forms.ComboBox updateComboBox;
        private System.Windows.Forms.Label ask_Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView airlineUpdationGrid;
        private System.Windows.Forms.TextBox airlineIDDeleteBox;
        private System.Windows.Forms.Button deleteAirlineConfrmButton;
        private System.Windows.Forms.Label airlineLabel;
        private System.Windows.Forms.Label deleteLabel;
        private System.Windows.Forms.DataGridView deleteAirlineGrid;
        private System.Windows.Forms.Label airlineNameLabel;
        private System.Windows.Forms.Label noOfAirplanesLabel;
        private System.Windows.Forms.Label airlineIDLabel;
        private System.Windows.Forms.TextBox noOfAirplanesBox;
        private System.Windows.Forms.TextBox airlineIDBox;
        private System.Windows.Forms.TextBox airlineNameBox;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.DataGridViewTextBoxColumn airlineID;
        private System.Windows.Forms.DataGridViewTextBoxColumn airlineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Airplanes;
        private System.Windows.Forms.DataGridViewTextBoxColumn AirportID;
        private System.Windows.Forms.DataGridViewTextBoxColumn airportName;
        private System.Windows.Forms.DataGridViewTextBoxColumn airportCity;
    }
}