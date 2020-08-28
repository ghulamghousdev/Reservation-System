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
    public partial class Form4 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-UUG2AVV;Initial Catalog=AirlineReservationSystem;Integrated Security=True");

        public Form4()
        {
            InitializeComponent();
            loadAirplanes();
            loadCities();
        }

        public void loadAirplanes()
        {
            con.Open();

            this.airplaneIDBox.Items.Clear();
            SqlCommand cmd = new SqlCommand("Select Airplane_ID from airplane", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string id = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                this.airplaneIDBox.Items.Add(id);
            }
            con.Close();
        }

        //Getting Cities from Airports table
        public void loadCities()
        {
            con.Open();

            this.fromCity.Items.Clear();
            this.toCity.Items.Clear();
            SqlCommand cmd = new SqlCommand("Select City from airport", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string city = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                this.fromCity.Items.Add(city);
                this.toCity.Items.Add(city);
            }
            con.Close();
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            string A_ID = airplaneIDBox.Text;
            string F_ID = flightID.Text;
            string F_CD = fromCity.Text;
            string F_CA = toCity.Text;
            string DD = dateD.Text;
            string AD = dateA.Text;
 
            string arrivalTime = AH.Text+":"+AM.Text+":00";
            string departureTime = DH.Text + ":" +DM.Text+ ":00";

            con.Open();
            string firstQuery = "INSERT INTO FLIGHT(Flight_ID, Airplane_ID, Departure_City,Arrival_City, Departure_Time, Arrival_Time, Departure_Date, Arrival_Date) values(@fi, @ai, @CF, @CT, @DT, @AT, @DD, @AD)";
            SqlCommand cmd = new SqlCommand(firstQuery, con);
            cmd.Parameters.AddWithValue("@fi", F_ID);
            cmd.Parameters.AddWithValue("@ai", A_ID);
            cmd.Parameters.AddWithValue("@CF", F_CD);
            cmd.Parameters.AddWithValue("@CT", F_CA);
            cmd.Parameters.AddWithValue("@AD", DD);
            cmd.Parameters.AddWithValue("@DD", AD);
            cmd.Parameters.AddWithValue("@AT", arrivalTime);
            cmd.Parameters.AddWithValue("@DT", departureTime);
            cmd.ExecuteNonQuery();
            this.msgBox.Text = "Your Data has been saved😊";


            con.Close();
        }

        public void formatSet(decimal a, string b)
        {
            if ( a < 10)
            {
                b = "0" + b;
            }
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
    }
}
