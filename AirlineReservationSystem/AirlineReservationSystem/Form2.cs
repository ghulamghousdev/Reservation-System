using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineReservationSystem
{
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-UUG2AVV;Initial Catalog=AirlineReservationSystem;Integrated Security=True");

        public Form2()
        {
            InitializeComponent();
            this.msgBox.Text = "";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            save();
        }

        public void save()
        {
            string A_ID = airlineID.Text;
            string A_Name = airlineName.Text;
            string A_Crafts = crafts.Text;

            con.Open();
            string firstQuery = "INSERT INTO AIRLINE(Airline_ID, Airline_Name, Airplanes) values(@id, @name, @crft)";
            SqlCommand cmd = new SqlCommand(firstQuery, con);
            cmd.Parameters.AddWithValue("@name", A_Name);
            cmd.Parameters.AddWithValue("@id", A_ID);
            cmd.Parameters.AddWithValue("@crft", A_Crafts);
            cmd.ExecuteNonQuery();
            this.msgBox.Text = "Your Data has been saved😊";
            airlineID.Text = "";
            airlineName.Text = "";
            crafts.Text = "";

            con.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            backToHome();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            backToHome();
        }

        public void backToHome()
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            backToHome();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void airlineID_Click(object sender, EventArgs e)
        {
            this.msgBox.Text = "";
        }
    }
}
