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
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-UUG2AVV;Initial Catalog=AirlineReservationSystem;Integrated Security=True");

        public Form3()
        {
            InitializeComponent();
            loadAirlineCompanies();
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

        public void loadAirlineCompanies()
        {
            con.Open();

            this.airlineIDBox.Items.Clear();
            SqlCommand cmd = new SqlCommand("Select Airline_ID from airline", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string id = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                this.airlineIDBox.Items.Add(id);
            }
            con.Close();
        }

        private void airplaneID_TextChanged(object sender, EventArgs e)
        {
           this.msgBox.Text = "";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string A_ID = airplaneID.Text;
            string A_rn = regNumber.Text;
            string A_seats = seats.Text;
            string A_cat = category.Text;
            string A_AID = airlineIDBox.Text;

            con.Open();
            string firstQuery = "INSERT INTO AIRPLANE(Airplane_ID, Airline_ID, Reg_Number, Seats, Category) values(@id, @airlineID, @rg, @seats, @cat)";
            SqlCommand cmd = new SqlCommand(firstQuery, con);
            cmd.Parameters.AddWithValue("@rg", A_rn);
            cmd.Parameters.AddWithValue("@id", A_ID);
            cmd.Parameters.AddWithValue("@seats", A_seats);
            cmd.Parameters.AddWithValue("@cat", A_cat);
            cmd.Parameters.AddWithValue("@airlineID", A_AID);
            cmd.ExecuteNonQuery();
            this.msgBox.Text = "Your Data has been saved😊";
            airplaneID.Text = "";
            regNumber.Text = "";
            seats.Text ="";
            category.Text = "";
            airlineIDBox.Text = "";

            con.Close();
        }
    }
}
