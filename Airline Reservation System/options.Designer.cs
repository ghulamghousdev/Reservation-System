namespace Airline_Reservation_System
{
    partial class options
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
            this.bookedTickets_button = new System.Windows.Forms.Button();
            this.modify_button = new System.Windows.Forms.Button();
            this.availableFlights_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.searchFlight_button = new System.Windows.Forms.Button();
            this.logout_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bookedTickets_button);
            this.panel1.Controls.Add(this.modify_button);
            this.panel1.Controls.Add(this.availableFlights_button);
            this.panel1.Controls.Add(this.cancel_button);
            this.panel1.Controls.Add(this.searchFlight_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 647);
            this.panel1.TabIndex = 0;
            // 
            // bookedTickets_button
            // 
            this.bookedTickets_button.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookedTickets_button.Location = new System.Drawing.Point(0, 150);
            this.bookedTickets_button.Name = "bookedTickets_button";
            this.bookedTickets_button.Size = new System.Drawing.Size(192, 43);
            this.bookedTickets_button.TabIndex = 8;
            this.bookedTickets_button.Text = "Bookings";
            this.bookedTickets_button.UseVisualStyleBackColor = true;
            // 
            // modify_button
            // 
            this.modify_button.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modify_button.Location = new System.Drawing.Point(0, 38);
            this.modify_button.Name = "modify_button";
            this.modify_button.Size = new System.Drawing.Size(192, 40);
            this.modify_button.TabIndex = 7;
            this.modify_button.Text = "Modify Bookings";
            this.modify_button.UseVisualStyleBackColor = true;
            // 
            // availableFlights_button
            // 
            this.availableFlights_button.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableFlights_button.Location = new System.Drawing.Point(0, 112);
            this.availableFlights_button.Name = "availableFlights_button";
            this.availableFlights_button.Size = new System.Drawing.Size(192, 43);
            this.availableFlights_button.TabIndex = 6;
            this.availableFlights_button.Text = "Available Flights";
            this.availableFlights_button.UseVisualStyleBackColor = true;
            // 
            // cancel_button
            // 
            this.cancel_button.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_button.Location = new System.Drawing.Point(0, 72);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(192, 43);
            this.cancel_button.TabIndex = 5;
            this.cancel_button.Text = "Cancel Flight";
            this.cancel_button.UseVisualStyleBackColor = true;
            // 
            // searchFlight_button
            // 
            this.searchFlight_button.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchFlight_button.Location = new System.Drawing.Point(0, 0);
            this.searchFlight_button.Name = "searchFlight_button";
            this.searchFlight_button.Size = new System.Drawing.Size(192, 43);
            this.searchFlight_button.TabIndex = 4;
            this.searchFlight_button.Text = "Search Flight";
            this.searchFlight_button.UseVisualStyleBackColor = true;
            // 
            // logout_button
            // 
            this.logout_button.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_button.Location = new System.Drawing.Point(941, 0);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(139, 43);
            this.logout_button.TabIndex = 9;
            this.logout_button.Text = "Log Out";
            this.logout_button.UseVisualStyleBackColor = true;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 647);
            this.Controls.Add(this.logout_button);
            this.Controls.Add(this.panel1);
            this.Name = "options";
            this.Text = "options";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bookedTickets_button;
        private System.Windows.Forms.Button modify_button;
        private System.Windows.Forms.Button availableFlights_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button searchFlight_button;
        private System.Windows.Forms.Button logout_button;
    }
}