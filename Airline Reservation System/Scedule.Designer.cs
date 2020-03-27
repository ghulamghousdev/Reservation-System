namespace Airline_Reservation_System
{
    partial class Scedule
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
            this.scehduleForm = new System.Windows.Forms.Button();
            this.airplaneForm = new System.Windows.Forms.Button();
            this.flightForm = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.airlineForm);
            this.panel1.Controls.Add(this.airportForm);
            this.panel1.Controls.Add(this.scehduleForm);
            this.panel1.Controls.Add(this.airplaneForm);
            this.panel1.Controls.Add(this.flightForm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 543);
            this.panel1.TabIndex = 4;
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
            // Scedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 543);
            this.Controls.Add(this.panel1);
            this.Name = "Scedule";
            this.Text = "Scedule";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button airlineForm;
        private System.Windows.Forms.Button airportForm;
        private System.Windows.Forms.Button scehduleForm;
        private System.Windows.Forms.Button airplaneForm;
        private System.Windows.Forms.Button flightForm;
    }
}