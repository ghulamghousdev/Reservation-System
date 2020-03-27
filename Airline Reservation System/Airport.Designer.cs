namespace Airline_Reservation_System
{
    partial class Airport
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
            this.addAirportPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.airportName_label = new System.Windows.Forms.Label();
            this.city_label = new System.Windows.Forms.Label();
            this.country_label = new System.Windows.Forms.Label();
            this.airportID_label = new System.Windows.Forms.Label();
            this.country_box = new System.Windows.Forms.TextBox();
            this.city_box = new System.Windows.Forms.TextBox();
            this.airportID_box = new System.Windows.Forms.TextBox();
            this.airportName_box = new System.Windows.Forms.TextBox();
            this.error = new System.Windows.Forms.Label();
            this.updateAirportPanel = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateAirportButton = new System.Windows.Forms.Button();
            this.addAirport_button = new System.Windows.Forms.Button();
            this.errorMsg = new System.Windows.Forms.Label();
            this.miniUpdatePanel = new System.Windows.Forms.Panel();
            this.propertyLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.property_Box = new System.Windows.Forms.TextBox();
            this.airportID_InputBox = new System.Windows.Forms.TextBox();
            this.updateSubmission_Button = new System.Windows.Forms.Button();
            this.updateComboBox = new System.Windows.Forms.ComboBox();
            this.ask_Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.airportGrid = new System.Windows.Forms.DataGridView();
            this.AirportID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.airportName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.airportCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.airportCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteAirportPanel = new System.Windows.Forms.Panel();
            this.errorLabel = new System.Windows.Forms.Label();
            this.airportIDDeleteBox = new System.Windows.Forms.TextBox();
            this.deleteAirportButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.deleteLabel = new System.Windows.Forms.Label();
            this.deleteAirportGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.airlineForm = new System.Windows.Forms.Button();
            this.airportForm = new System.Windows.Forms.Button();
            this.scehduleForm = new System.Windows.Forms.Button();
            this.airplaneForm = new System.Windows.Forms.Button();
            this.flightForm = new System.Windows.Forms.Button();
            this.addAirportPanel.SuspendLayout();
            this.updateAirportPanel.SuspendLayout();
            this.miniUpdatePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.airportGrid)).BeginInit();
            this.deleteAirportPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteAirportGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addAirportPanel
            // 
            this.addAirportPanel.AutoScroll = true;
            this.addAirportPanel.Controls.Add(this.button1);
            this.addAirportPanel.Controls.Add(this.airportName_label);
            this.addAirportPanel.Controls.Add(this.city_label);
            this.addAirportPanel.Controls.Add(this.country_label);
            this.addAirportPanel.Controls.Add(this.airportID_label);
            this.addAirportPanel.Controls.Add(this.country_box);
            this.addAirportPanel.Controls.Add(this.city_box);
            this.addAirportPanel.Controls.Add(this.airportID_box);
            this.addAirportPanel.Controls.Add(this.airportName_box);
            this.addAirportPanel.Controls.Add(this.error);
            this.addAirportPanel.Location = new System.Drawing.Point(240, 12);
            this.addAirportPanel.Name = "addAirportPanel";
            this.addAirportPanel.Size = new System.Drawing.Size(1061, 633);
            this.addAirportPanel.TabIndex = 22;
            this.addAirportPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(359, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 46);
            this.button1.TabIndex = 52;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // airportName_label
            // 
            this.airportName_label.AutoSize = true;
            this.airportName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.airportName_label.Location = new System.Drawing.Point(194, 260);
            this.airportName_label.Name = "airportName_label";
            this.airportName_label.Size = new System.Drawing.Size(141, 26);
            this.airportName_label.TabIndex = 51;
            this.airportName_label.Text = "Airport Name";
            // 
            // city_label
            // 
            this.city_label.AutoSize = true;
            this.city_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.city_label.Location = new System.Drawing.Point(194, 303);
            this.city_label.Name = "city_label";
            this.city_label.Size = new System.Drawing.Size(50, 26);
            this.city_label.TabIndex = 50;
            this.city_label.Text = "City";
            // 
            // country_label
            // 
            this.country_label.AutoSize = true;
            this.country_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.country_label.Location = new System.Drawing.Point(194, 348);
            this.country_label.Name = "country_label";
            this.country_label.Size = new System.Drawing.Size(88, 26);
            this.country_label.TabIndex = 49;
            this.country_label.Text = "Country";
            // 
            // airportID_label
            // 
            this.airportID_label.AutoSize = true;
            this.airportID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.airportID_label.Location = new System.Drawing.Point(194, 209);
            this.airportID_label.Name = "airportID_label";
            this.airportID_label.Size = new System.Drawing.Size(104, 26);
            this.airportID_label.TabIndex = 48;
            this.airportID_label.Text = "Airport ID";
            // 
            // country_box
            // 
            this.country_box.Location = new System.Drawing.Point(350, 350);
            this.country_box.Name = "country_box";
            this.country_box.Size = new System.Drawing.Size(325, 26);
            this.country_box.TabIndex = 47;
            // 
            // city_box
            // 
            this.city_box.Location = new System.Drawing.Point(350, 305);
            this.city_box.Name = "city_box";
            this.city_box.Size = new System.Drawing.Size(325, 26);
            this.city_box.TabIndex = 45;
            // 
            // airportID_box
            // 
            this.airportID_box.Location = new System.Drawing.Point(350, 211);
            this.airportID_box.Name = "airportID_box";
            this.airportID_box.Size = new System.Drawing.Size(325, 26);
            this.airportID_box.TabIndex = 44;
            // 
            // airportName_box
            // 
            this.airportName_box.Location = new System.Drawing.Point(350, 262);
            this.airportName_box.Name = "airportName_box";
            this.airportName_box.Size = new System.Drawing.Size(325, 26);
            this.airportName_box.TabIndex = 43;
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
            // updateAirportPanel
            // 
            this.updateAirportPanel.Controls.Add(this.errorMsg);
            this.updateAirportPanel.Controls.Add(this.miniUpdatePanel);
            this.updateAirportPanel.Controls.Add(this.updateSubmission_Button);
            this.updateAirportPanel.Controls.Add(this.updateComboBox);
            this.updateAirportPanel.Controls.Add(this.ask_Label);
            this.updateAirportPanel.Controls.Add(this.label1);
            this.updateAirportPanel.Controls.Add(this.airportGrid);
            this.updateAirportPanel.Location = new System.Drawing.Point(221, 9);
            this.updateAirportPanel.Name = "updateAirportPanel";
            this.updateAirportPanel.Size = new System.Drawing.Size(1023, 633);
            this.updateAirportPanel.TabIndex = 25;
            this.updateAirportPanel.Visible = false;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.LimeGreen;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(6, 362);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(187, 46);
            this.deleteButton.TabIndex = 29;
            this.deleteButton.Text = "Delete Airport";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateAirportButton
            // 
            this.updateAirportButton.BackColor = System.Drawing.Color.LimeGreen;
            this.updateAirportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateAirportButton.ForeColor = System.Drawing.Color.White;
            this.updateAirportButton.Location = new System.Drawing.Point(3, 272);
            this.updateAirportButton.Name = "updateAirportButton";
            this.updateAirportButton.Size = new System.Drawing.Size(186, 46);
            this.updateAirportButton.TabIndex = 28;
            this.updateAirportButton.Text = "Update Airport";
            this.updateAirportButton.UseVisualStyleBackColor = false;
            this.updateAirportButton.Click += new System.EventHandler(this.updateAirportButton_Click);
            // 
            // addAirport_button
            // 
            this.addAirport_button.BackColor = System.Drawing.Color.LimeGreen;
            this.addAirport_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAirport_button.ForeColor = System.Drawing.Color.White;
            this.addAirport_button.Location = new System.Drawing.Point(4, 317);
            this.addAirport_button.Name = "addAirport_button";
            this.addAirport_button.Size = new System.Drawing.Size(187, 46);
            this.addAirport_button.TabIndex = 27;
            this.addAirport_button.Text = "Add Airport";
            this.addAirport_button.UseVisualStyleBackColor = false;
            this.addAirport_button.Click += new System.EventHandler(this.addAirport_button_Click);
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
            this.miniUpdatePanel.Controls.Add(this.airportID_InputBox);
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
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "AirportID";
            // 
            // property_Box
            // 
            this.property_Box.Location = new System.Drawing.Point(131, 105);
            this.property_Box.Name = "property_Box";
            this.property_Box.Size = new System.Drawing.Size(205, 26);
            this.property_Box.TabIndex = 1;
            // 
            // airportID_InputBox
            // 
            this.airportID_InputBox.Location = new System.Drawing.Point(131, 60);
            this.airportID_InputBox.Name = "airportID_InputBox";
            this.airportID_InputBox.Size = new System.Drawing.Size(205, 26);
            this.airportID_InputBox.TabIndex = 0;
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
            "Airport_Name",
            "City",
            "Country"});
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
            this.label1.Size = new System.Drawing.Size(206, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Update Airport";
            // 
            // airportGrid
            // 
            this.airportGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.airportGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AirportID,
            this.airportName,
            this.airportCity,
            this.airportCountry});
            this.airportGrid.Location = new System.Drawing.Point(352, 47);
            this.airportGrid.Name = "airportGrid";
            this.airportGrid.RowHeadersWidth = 62;
            this.airportGrid.RowTemplate.Height = 28;
            this.airportGrid.Size = new System.Drawing.Size(668, 582);
            this.airportGrid.TabIndex = 0;
            // 
            // AirportID
            // 
            this.AirportID.HeaderText = "AirportID";
            this.AirportID.MinimumWidth = 8;
            this.AirportID.Name = "AirportID";
            this.AirportID.Width = 150;
            // 
            // airportName
            // 
            this.airportName.HeaderText = "Airport Name";
            this.airportName.MinimumWidth = 8;
            this.airportName.Name = "airportName";
            this.airportName.Width = 150;
            // 
            // airportCity
            // 
            this.airportCity.HeaderText = "City";
            this.airportCity.MinimumWidth = 8;
            this.airportCity.Name = "airportCity";
            this.airportCity.Width = 150;
            // 
            // airportCountry
            // 
            this.airportCountry.HeaderText = "Country";
            this.airportCountry.MinimumWidth = 8;
            this.airportCountry.Name = "airportCountry";
            this.airportCountry.Width = 150;
            // 
            // deleteAirportPanel
            // 
            this.deleteAirportPanel.Controls.Add(this.errorLabel);
            this.deleteAirportPanel.Controls.Add(this.airportIDDeleteBox);
            this.deleteAirportPanel.Controls.Add(this.deleteAirportButton);
            this.deleteAirportPanel.Controls.Add(this.label5);
            this.deleteAirportPanel.Controls.Add(this.deleteLabel);
            this.deleteAirportPanel.Controls.Add(this.deleteAirportGrid);
            this.deleteAirportPanel.Location = new System.Drawing.Point(229, 15);
            this.deleteAirportPanel.Name = "deleteAirportPanel";
            this.deleteAirportPanel.Size = new System.Drawing.Size(1044, 635);
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
            // airportIDDeleteBox
            // 
            this.airportIDDeleteBox.Location = new System.Drawing.Point(22, 247);
            this.airportIDDeleteBox.Name = "airportIDDeleteBox";
            this.airportIDDeleteBox.Size = new System.Drawing.Size(272, 26);
            this.airportIDDeleteBox.TabIndex = 30;
            // 
            // deleteAirportButton
            // 
            this.deleteAirportButton.BackColor = System.Drawing.Color.LimeGreen;
            this.deleteAirportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAirportButton.ForeColor = System.Drawing.Color.White;
            this.deleteAirportButton.Location = new System.Drawing.Point(35, 357);
            this.deleteAirportButton.Name = "deleteAirportButton";
            this.deleteAirportButton.Size = new System.Drawing.Size(187, 46);
            this.deleteAirportButton.TabIndex = 29;
            this.deleteAirportButton.Text = "Delete";
            this.deleteAirportButton.UseVisualStyleBackColor = false;
            this.deleteAirportButton.Click += new System.EventHandler(this.deleteAirportButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(293, 28);
            this.label5.TabIndex = 27;
            this.label5.Text = "Airport ID Want to Delete";
            // 
            // deleteLabel
            // 
            this.deleteLabel.AutoSize = true;
            this.deleteLabel.Font = new System.Drawing.Font("Myriad Pro", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteLabel.Location = new System.Drawing.Point(329, 7);
            this.deleteLabel.Name = "deleteLabel";
            this.deleteLabel.Size = new System.Drawing.Size(195, 35);
            this.deleteLabel.TabIndex = 26;
            this.deleteLabel.Text = "Delete Airport";
            // 
            // deleteAirportGrid
            // 
            this.deleteAirportGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deleteAirportGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.deleteAirportGrid.Location = new System.Drawing.Point(364, 54);
            this.deleteAirportGrid.Name = "deleteAirportGrid";
            this.deleteAirportGrid.RowHeadersWidth = 62;
            this.deleteAirportGrid.RowTemplate.Height = 28;
            this.deleteAirportGrid.Size = new System.Drawing.Size(668, 582);
            this.deleteAirportGrid.TabIndex = 25;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "AirportID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Airport Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "City";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Country";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.updateAirportButton);
            this.panel1.Controls.Add(this.deleteButton);
            this.panel1.Controls.Add(this.addAirport_button);
            this.panel1.Controls.Add(this.airlineForm);
            this.panel1.Controls.Add(this.airportForm);
            this.panel1.Controls.Add(this.scehduleForm);
            this.panel1.Controls.Add(this.airplaneForm);
            this.panel1.Controls.Add(this.flightForm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 645);
            this.panel1.TabIndex = 26;
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
            // Airport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 645);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.updateAirportPanel);
            this.Controls.Add(this.deleteAirportPanel);
            this.Controls.Add(this.addAirportPanel);
            this.Name = "Airport";
            this.Text = "Airport";
            this.Load += new System.EventHandler(this.Airport_Load);
            this.addAirportPanel.ResumeLayout(false);
            this.addAirportPanel.PerformLayout();
            this.updateAirportPanel.ResumeLayout(false);
            this.updateAirportPanel.PerformLayout();
            this.miniUpdatePanel.ResumeLayout(false);
            this.miniUpdatePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.airportGrid)).EndInit();
            this.deleteAirportPanel.ResumeLayout(false);
            this.deleteAirportPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteAirportGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel addAirportPanel;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.TextBox country_box;
        private System.Windows.Forms.TextBox city_box;
        private System.Windows.Forms.TextBox airportID_box;
        private System.Windows.Forms.TextBox airportName_box;
        private System.Windows.Forms.Label airportID_label;
        private System.Windows.Forms.Label airportName_label;
        private System.Windows.Forms.Label city_label;
        private System.Windows.Forms.Label country_label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel updateAirportPanel;
        private System.Windows.Forms.DataGridView airportGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn AirportID;
        private System.Windows.Forms.DataGridViewTextBoxColumn airportName;
        private System.Windows.Forms.DataGridViewTextBoxColumn airportCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn airportCountry;
        private System.Windows.Forms.ComboBox updateComboBox;
        private System.Windows.Forms.Label ask_Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel miniUpdatePanel;
        private System.Windows.Forms.Label propertyLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox property_Box;
        private System.Windows.Forms.TextBox airportID_InputBox;
        private System.Windows.Forms.Button updateSubmission_Button;
        private System.Windows.Forms.Panel deleteAirportPanel;
        private System.Windows.Forms.TextBox airportIDDeleteBox;
        private System.Windows.Forms.Button deleteAirportButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label deleteLabel;
        private System.Windows.Forms.DataGridView deleteAirportGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label errorMsg;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateAirportButton;
        private System.Windows.Forms.Button addAirport_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button airlineForm;
        private System.Windows.Forms.Button airportForm;
        private System.Windows.Forms.Button scehduleForm;
        private System.Windows.Forms.Button airplaneForm;
        private System.Windows.Forms.Button flightForm;
    }
}