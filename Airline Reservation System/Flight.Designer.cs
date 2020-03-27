namespace Airline_Reservation_System
{
    partial class Flight
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
            this.airlineForm = new System.Windows.Forms.Button();
            this.airportForm = new System.Windows.Forms.Button();
            this.airplaneForm = new System.Windows.Forms.Button();
            this.flightForm = new System.Windows.Forms.Button();
            this.addFlightPanel = new System.Windows.Forms.Panel();
            this.errorMsg = new System.Windows.Forms.Label();
            this.msgLabel = new System.Windows.Forms.Label();
            this.departureTimeLabel = new System.Windows.Forms.Label();
            this.arrivalCityLabel = new System.Windows.Forms.Label();
            this.arrivalCityBox = new System.Windows.Forms.TextBox();
            this.saveIntoDatabase = new System.Windows.Forms.Button();
            this.airlineIDLabel = new System.Windows.Forms.Label();
            this.departureCityLabel = new System.Windows.Forms.Label();
            this.airplaneIDLabel = new System.Windows.Forms.Label();
            this.departureCityBox = new System.Windows.Forms.TextBox();
            this.airplaneIDBox = new System.Windows.Forms.TextBox();
            this.airlineIDBox = new System.Windows.Forms.TextBox();
            this.error = new System.Windows.Forms.Label();
            this.flightIDLabel = new System.Windows.Forms.Label();
            this.flightIDBox = new System.Windows.Forms.TextBox();
            this.departureTimeBox = new System.Windows.Forms.TextBox();
            this.arrivalTimeBox = new System.Windows.Forms.TextBox();
            this.arrivalDateLabel = new System.Windows.Forms.Label();
            this.departureDateLabel = new System.Windows.Forms.Label();
            this.arrivalTimeLabel = new System.Windows.Forms.Label();
            this.arrivalDateBox = new System.Windows.Forms.DateTimePicker();
            this.departureDateBox = new System.Windows.Forms.DateTimePicker();
            this.fareLabel = new System.Windows.Forms.Label();
            this.fareBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.addFlightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.airlineForm);
            this.panel1.Controls.Add(this.airportForm);
            this.panel1.Controls.Add(this.airplaneForm);
            this.panel1.Controls.Add(this.flightForm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 787);
            this.panel1.TabIndex = 5;
            // 
            // airlineForm
            // 
            this.airlineForm.Cursor = System.Windows.Forms.Cursors.Default;
            this.airlineForm.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airlineForm.Location = new System.Drawing.Point(1, 130);
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
            this.airportForm.Location = new System.Drawing.Point(0, 91);
            this.airportForm.Name = "airportForm";
            this.airportForm.Size = new System.Drawing.Size(192, 43);
            this.airportForm.TabIndex = 10;
            this.airportForm.Text = "Airports";
            this.airportForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.airportForm.UseVisualStyleBackColor = true;
            this.airportForm.Click += new System.EventHandler(this.airportForm_Click);
            // 
            // airplaneForm
            // 
            this.airplaneForm.Cursor = System.Windows.Forms.Cursors.Default;
            this.airplaneForm.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airplaneForm.Location = new System.Drawing.Point(1, 44);
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
            // addFlightPanel
            // 
            this.addFlightPanel.AutoScroll = true;
            this.addFlightPanel.BackColor = System.Drawing.Color.LightGray;
            this.addFlightPanel.Controls.Add(this.fareLabel);
            this.addFlightPanel.Controls.Add(this.fareBox);
            this.addFlightPanel.Controls.Add(this.departureDateBox);
            this.addFlightPanel.Controls.Add(this.arrivalDateBox);
            this.addFlightPanel.Controls.Add(this.arrivalTimeLabel);
            this.addFlightPanel.Controls.Add(this.departureDateLabel);
            this.addFlightPanel.Controls.Add(this.arrivalDateLabel);
            this.addFlightPanel.Controls.Add(this.arrivalTimeBox);
            this.addFlightPanel.Controls.Add(this.departureTimeBox);
            this.addFlightPanel.Controls.Add(this.flightIDLabel);
            this.addFlightPanel.Controls.Add(this.flightIDBox);
            this.addFlightPanel.Controls.Add(this.errorMsg);
            this.addFlightPanel.Controls.Add(this.msgLabel);
            this.addFlightPanel.Controls.Add(this.departureTimeLabel);
            this.addFlightPanel.Controls.Add(this.arrivalCityLabel);
            this.addFlightPanel.Controls.Add(this.arrivalCityBox);
            this.addFlightPanel.Controls.Add(this.saveIntoDatabase);
            this.addFlightPanel.Controls.Add(this.airlineIDLabel);
            this.addFlightPanel.Controls.Add(this.departureCityLabel);
            this.addFlightPanel.Controls.Add(this.airplaneIDLabel);
            this.addFlightPanel.Controls.Add(this.departureCityBox);
            this.addFlightPanel.Controls.Add(this.airplaneIDBox);
            this.addFlightPanel.Controls.Add(this.airlineIDBox);
            this.addFlightPanel.Controls.Add(this.error);
            this.addFlightPanel.Location = new System.Drawing.Point(262, 12);
            this.addFlightPanel.Name = "addFlightPanel";
            this.addFlightPanel.Size = new System.Drawing.Size(1075, 683);
            this.addFlightPanel.TabIndex = 25;
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
            // msgLabel
            // 
            this.msgLabel.AutoSize = true;
            this.msgLabel.Font = new System.Drawing.Font("Gill Sans MT", 14F, System.Drawing.FontStyle.Bold);
            this.msgLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.msgLabel.Location = new System.Drawing.Point(365, 474);
            this.msgLabel.Name = "msgLabel";
            this.msgLabel.Size = new System.Drawing.Size(0, 39);
            this.msgLabel.TabIndex = 57;
            // 
            // departureTimeLabel
            // 
            this.departureTimeLabel.AutoSize = true;
            this.departureTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.departureTimeLabel.Location = new System.Drawing.Point(207, 307);
            this.departureTimeLabel.Name = "departureTimeLabel";
            this.departureTimeLabel.Size = new System.Drawing.Size(162, 26);
            this.departureTimeLabel.TabIndex = 55;
            this.departureTimeLabel.Text = "Departure Time";
            // 
            // arrivalCityLabel
            // 
            this.arrivalCityLabel.AutoSize = true;
            this.arrivalCityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.arrivalCityLabel.Location = new System.Drawing.Point(207, 267);
            this.arrivalCityLabel.Name = "arrivalCityLabel";
            this.arrivalCityLabel.Size = new System.Drawing.Size(118, 26);
            this.arrivalCityLabel.TabIndex = 54;
            this.arrivalCityLabel.Text = "Arrival City";
            // 
            // arrivalCityBox
            // 
            this.arrivalCityBox.Location = new System.Drawing.Point(393, 267);
            this.arrivalCityBox.Name = "arrivalCityBox";
            this.arrivalCityBox.Size = new System.Drawing.Size(325, 26);
            this.arrivalCityBox.TabIndex = 53;
            // 
            // saveIntoDatabase
            // 
            this.saveIntoDatabase.BackColor = System.Drawing.Color.LimeGreen;
            this.saveIntoDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveIntoDatabase.ForeColor = System.Drawing.Color.White;
            this.saveIntoDatabase.Location = new System.Drawing.Point(393, 532);
            this.saveIntoDatabase.Name = "saveIntoDatabase";
            this.saveIntoDatabase.Size = new System.Drawing.Size(158, 46);
            this.saveIntoDatabase.TabIndex = 52;
            this.saveIntoDatabase.Text = "Save";
            this.saveIntoDatabase.UseVisualStyleBackColor = false;
            // 
            // airlineIDLabel
            // 
            this.airlineIDLabel.AutoSize = true;
            this.airlineIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.airlineIDLabel.Location = new System.Drawing.Point(207, 177);
            this.airlineIDLabel.Name = "airlineIDLabel";
            this.airlineIDLabel.Size = new System.Drawing.Size(101, 26);
            this.airlineIDLabel.TabIndex = 51;
            this.airlineIDLabel.Text = "Airline ID";
            // 
            // departureCityLabel
            // 
            this.departureCityLabel.AutoSize = true;
            this.departureCityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.departureCityLabel.Location = new System.Drawing.Point(207, 220);
            this.departureCityLabel.Name = "departureCityLabel";
            this.departureCityLabel.Size = new System.Drawing.Size(152, 26);
            this.departureCityLabel.TabIndex = 50;
            this.departureCityLabel.Text = "Departure City";
            // 
            // airplaneIDLabel
            // 
            this.airplaneIDLabel.AutoSize = true;
            this.airplaneIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.airplaneIDLabel.Location = new System.Drawing.Point(207, 126);
            this.airplaneIDLabel.Name = "airplaneIDLabel";
            this.airplaneIDLabel.Size = new System.Drawing.Size(120, 26);
            this.airplaneIDLabel.TabIndex = 48;
            this.airplaneIDLabel.Text = "Airplane ID";
            // 
            // departureCityBox
            // 
            this.departureCityBox.Location = new System.Drawing.Point(393, 220);
            this.departureCityBox.Name = "departureCityBox";
            this.departureCityBox.Size = new System.Drawing.Size(325, 26);
            this.departureCityBox.TabIndex = 45;
            // 
            // airplaneIDBox
            // 
            this.airplaneIDBox.Location = new System.Drawing.Point(393, 126);
            this.airplaneIDBox.Name = "airplaneIDBox";
            this.airplaneIDBox.Size = new System.Drawing.Size(325, 26);
            this.airplaneIDBox.TabIndex = 44;
            // 
            // airlineIDBox
            // 
            this.airlineIDBox.Location = new System.Drawing.Point(393, 177);
            this.airlineIDBox.Name = "airlineIDBox";
            this.airlineIDBox.Size = new System.Drawing.Size(325, 26);
            this.airlineIDBox.TabIndex = 43;
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(496, 411);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 25);
            this.error.TabIndex = 25;
            // 
            // flightIDLabel
            // 
            this.flightIDLabel.AutoSize = true;
            this.flightIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.flightIDLabel.Location = new System.Drawing.Point(207, 79);
            this.flightIDLabel.Name = "flightIDLabel";
            this.flightIDLabel.Size = new System.Drawing.Size(93, 26);
            this.flightIDLabel.TabIndex = 60;
            this.flightIDLabel.Text = "Flight ID";
            // 
            // flightIDBox
            // 
            this.flightIDBox.Location = new System.Drawing.Point(393, 79);
            this.flightIDBox.Name = "flightIDBox";
            this.flightIDBox.Size = new System.Drawing.Size(325, 26);
            this.flightIDBox.TabIndex = 59;
            // 
            // departureTimeBox
            // 
            this.departureTimeBox.Location = new System.Drawing.Point(393, 307);
            this.departureTimeBox.Name = "departureTimeBox";
            this.departureTimeBox.Size = new System.Drawing.Size(325, 26);
            this.departureTimeBox.TabIndex = 61;
            // 
            // arrivalTimeBox
            // 
            this.arrivalTimeBox.Location = new System.Drawing.Point(393, 350);
            this.arrivalTimeBox.Name = "arrivalTimeBox";
            this.arrivalTimeBox.Size = new System.Drawing.Size(325, 26);
            this.arrivalTimeBox.TabIndex = 62;
            // 
            // arrivalDateLabel
            // 
            this.arrivalDateLabel.AutoSize = true;
            this.arrivalDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.arrivalDateLabel.Location = new System.Drawing.Point(207, 437);
            this.arrivalDateLabel.Name = "arrivalDateLabel";
            this.arrivalDateLabel.Size = new System.Drawing.Size(126, 26);
            this.arrivalDateLabel.TabIndex = 65;
            this.arrivalDateLabel.Text = "Arrival Date";
            // 
            // departureDateLabel
            // 
            this.departureDateLabel.AutoSize = true;
            this.departureDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.departureDateLabel.Location = new System.Drawing.Point(207, 393);
            this.departureDateLabel.Name = "departureDateLabel";
            this.departureDateLabel.Size = new System.Drawing.Size(160, 26);
            this.departureDateLabel.TabIndex = 66;
            this.departureDateLabel.Text = "Departure Date";
            // 
            // arrivalTimeLabel
            // 
            this.arrivalTimeLabel.AutoSize = true;
            this.arrivalTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.arrivalTimeLabel.Location = new System.Drawing.Point(207, 350);
            this.arrivalTimeLabel.Name = "arrivalTimeLabel";
            this.arrivalTimeLabel.Size = new System.Drawing.Size(128, 26);
            this.arrivalTimeLabel.TabIndex = 67;
            this.arrivalTimeLabel.Text = "Arrival Time";
            // 
            // arrivalDateBox
            // 
            this.arrivalDateBox.CustomFormat = "dd-MM-yyyy";
            this.arrivalDateBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.arrivalDateBox.Location = new System.Drawing.Point(393, 437);
            this.arrivalDateBox.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.arrivalDateBox.Name = "arrivalDateBox";
            this.arrivalDateBox.Size = new System.Drawing.Size(325, 26);
            this.arrivalDateBox.TabIndex = 68;
            // 
            // departureDateBox
            // 
            this.departureDateBox.CustomFormat = "dd-MM-yyyy";
            this.departureDateBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.departureDateBox.Location = new System.Drawing.Point(393, 393);
            this.departureDateBox.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.departureDateBox.Name = "departureDateBox";
            this.departureDateBox.Size = new System.Drawing.Size(325, 26);
            this.departureDateBox.TabIndex = 69;
            this.departureDateBox.Value = new System.DateTime(2020, 3, 27, 0, 9, 14, 0);
            // 
            // fareLabel
            // 
            this.fareLabel.AutoSize = true;
            this.fareLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.fareLabel.Location = new System.Drawing.Point(207, 478);
            this.fareLabel.Name = "fareLabel";
            this.fareLabel.Size = new System.Drawing.Size(56, 26);
            this.fareLabel.TabIndex = 71;
            this.fareLabel.Text = "Fare";
            // 
            // fareBox
            // 
            this.fareBox.Location = new System.Drawing.Point(393, 478);
            this.fareBox.Name = "fareBox";
            this.fareBox.Size = new System.Drawing.Size(325, 26);
            this.fareBox.TabIndex = 70;
            // 
            // Flight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 787);
            this.Controls.Add(this.addFlightPanel);
            this.Controls.Add(this.panel1);
            this.Name = "Flight";
            this.Text = "Flight";
            this.Load += new System.EventHandler(this.Flight_Load);
            this.panel1.ResumeLayout(false);
            this.addFlightPanel.ResumeLayout(false);
            this.addFlightPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button airlineForm;
        private System.Windows.Forms.Button airportForm;
        private System.Windows.Forms.Button airplaneForm;
        private System.Windows.Forms.Button flightForm;
        private System.Windows.Forms.Panel addFlightPanel;
        private System.Windows.Forms.Label arrivalTimeLabel;
        private System.Windows.Forms.Label departureDateLabel;
        private System.Windows.Forms.Label arrivalDateLabel;
        private System.Windows.Forms.TextBox arrivalTimeBox;
        private System.Windows.Forms.TextBox departureTimeBox;
        private System.Windows.Forms.Label flightIDLabel;
        private System.Windows.Forms.TextBox flightIDBox;
        private System.Windows.Forms.Label errorMsg;
        private System.Windows.Forms.Label msgLabel;
        private System.Windows.Forms.Label departureTimeLabel;
        private System.Windows.Forms.Label arrivalCityLabel;
        private System.Windows.Forms.TextBox arrivalCityBox;
        private System.Windows.Forms.Button saveIntoDatabase;
        private System.Windows.Forms.Label airlineIDLabel;
        private System.Windows.Forms.Label departureCityLabel;
        private System.Windows.Forms.Label airplaneIDLabel;
        private System.Windows.Forms.TextBox departureCityBox;
        private System.Windows.Forms.TextBox airplaneIDBox;
        private System.Windows.Forms.TextBox airlineIDBox;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Label fareLabel;
        private System.Windows.Forms.TextBox fareBox;
        private System.Windows.Forms.DateTimePicker departureDateBox;
        private System.Windows.Forms.DateTimePicker arrivalDateBox;
    }
}