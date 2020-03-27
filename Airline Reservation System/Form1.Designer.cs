namespace Airline_Reservation_System
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
            this.components = new System.ComponentModel.Container();
            this.signin_button = new System.Windows.Forms.Button();
            this.signup_button = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.great_label = new System.Windows.Forms.Label();
            this.title_label = new System.Windows.Forms.Label();
            this.username_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.password_box = new System.Windows.Forms.TextBox();
            this.username_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // signin_button
            // 
            this.signin_button.BackColor = System.Drawing.Color.LimeGreen;
            this.signin_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signin_button.ForeColor = System.Drawing.Color.White;
            this.signin_button.Location = new System.Drawing.Point(255, 280);
            this.signin_button.Name = "signin_button";
            this.signin_button.Size = new System.Drawing.Size(107, 46);
            this.signin_button.TabIndex = 0;
            this.signin_button.Text = "Sign In";
            this.signin_button.UseVisualStyleBackColor = false;
            this.signin_button.Click += new System.EventHandler(this.signin_button_Click);
            // 
            // signup_button
            // 
            this.signup_button.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_button.Location = new System.Drawing.Point(427, 280);
            this.signup_button.Name = "signup_button";
            this.signup_button.Size = new System.Drawing.Size(177, 46);
            this.signup_button.TabIndex = 1;
            this.signup_button.Text = "Register Now";
            this.signup_button.UseVisualStyleBackColor = true;
            this.signup_button.Click += new System.EventHandler(this.signup_button_Click);
            // 
            // great_label
            // 
            this.great_label.AutoSize = true;
            this.great_label.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.great_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.great_label.Location = new System.Drawing.Point(303, 72);
            this.great_label.Name = "great_label";
            this.great_label.Size = new System.Drawing.Size(239, 29);
            this.great_label.TabIndex = 2;
            this.great_label.Text = "Great People to Fly With";
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.title_label.Location = new System.Drawing.Point(227, 19);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(434, 37);
            this.title_label.TabIndex = 3;
            this.title_label.Text = "Airline Reservation System";
            // 
            // username_box
            // 
            this.username_box.Location = new System.Drawing.Point(348, 144);
            this.username_box.Name = "username_box";
            this.username_box.Size = new System.Drawing.Size(251, 26);
            this.username_box.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 5;
            // 
            // password_box
            // 
            this.password_box.Location = new System.Drawing.Point(348, 191);
            this.password_box.Name = "password_box";
            this.password_box.Size = new System.Drawing.Size(251, 26);
            this.password_box.TabIndex = 6;
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label.ForeColor = System.Drawing.Color.Blue;
            this.username_label.Location = new System.Drawing.Point(230, 144);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(99, 23);
            this.username_label.TabIndex = 7;
            this.username_label.Text = "Username";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.ForeColor = System.Drawing.Color.Blue;
            this.password_label.Location = new System.Drawing.Point(230, 191);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(98, 23);
            this.password_label.TabIndex = 8;
            this.password_label.Text = "Password";
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(344, 231);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 25);
            this.error.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(22, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 46);
            this.button1.TabIndex = 10;
            this.button1.Text = "Admin Control";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(792, 419);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.error);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.password_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.username_box);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.great_label);
            this.Controls.Add(this.signup_button);
            this.Controls.Add(this.signin_button);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signin_button;
        private System.Windows.Forms.Button signup_button;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label great_label;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.TextBox username_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Button button1;
    }
}

