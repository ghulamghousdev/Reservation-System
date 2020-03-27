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

namespace Airline_Reservation_System
{
    public partial class Airport : Form
    {
        //Connection with database
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-UUG2AVV;Initial Catalog=AirlineReservationSystem;Integrated Security=True");


        public Airport()
        {
            InitializeComponent();
        }

        private void flightForm_Click(object sender, EventArgs e)
        {
            new Flight().Show();
            this.Hide();
        }

        private void airplaneForm_Click(object sender, EventArgs e)
        {
            new Airplane().Show();
            this.Hide();
        }

        private void airportForm_Click(object sender, EventArgs e)
        {
            new Airport().Show();
            this.Hide();
        }

        private void airlineForm_Click(object sender, EventArgs e)
        {
            new Airline().Show();
            this.Hide();
        }

        private void scehduleForm_Click(object sender, EventArgs e)
        {
            new Scedule().Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addAirport_button_Click(object sender, EventArgs e)
        {
            this.addAirportPanel.Visible = true;
            this.updateAirportPanel.Visible = false;
            deleteAirportPanel.Visible = false;
        }

        private void updateAirportButton_Click(object sender, EventArgs e)
        {
            this.addAirportPanel.Visible = false;
            deleteAirportPanel.Visible = false;
            this.updateAirportPanel.Visible = true;
            viewData();
        }

        private void Airport_Load(object sender, EventArgs e)
        {
            this.addAirportPanel.Visible = true;
            this.updateAirportPanel.Visible = false;
            deleteAirportPanel.Visible = false;
        }

        //Event to save data about airport into the database
        private void button1_Click(object sender, EventArgs e)
        {
            string airportID = airportID_box.Text;
            string airportName = airportName_box.Text;
            string city = city_box.Text;
            string country = country_box.Text;
            con.Open(); //opening connection
            string query = "insert into Airport (Airport_ID, Airport_Name, City, Country) values(@id, @name, @city, @country)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", airportID);
            cmd.Parameters.AddWithValue("@name", airportName);
            cmd.Parameters.AddWithValue("@city", city);
            cmd.Parameters.AddWithValue("@country", country);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Your Data has been saved successfuly😊");
            con.Close();
        }


        private void updateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            miniUpdatePanel.Visible = true;
            propertyLabel.Text = "";
            airportID_InputBox.Text = "";
            property_Box.Text = "";
            propertyLabel.Text = updateComboBox.Text;

        }

        private void updateSubmission_Button_Click(object sender, EventArgs e)
        {
            string airportID = airportID_InputBox.Text;
            string prop = property_Box.Text;
            string attributeName = updateComboBox.Text;
            if (check(airportID))
            {
                updateAirport(attributeName, prop, airportID);
            }
            else
            {
                errorMsg.Text = "Error!! No such record exists";
                viewData();
            }
        }

        //Function to update data of airport table

        private void updateAirport(string attributeName , string propertyValue, string ID)
        {
            con.Open();
            string query = "update AIRPORT set "+attributeName+" =@propertyValue where Airport_ID=@ID";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@propertyValue", propertyValue);
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.ExecuteNonQuery();
            con.Close();
            viewData();
            MessageBox.Show("Your Data has been Updated successfuly😊");
            miniUpdatePanel.Visible = false;
        }

        //Retrieving data from database
        private void viewData()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from AIRPORT", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet data = new DataSet();
            adapter.Fill(data);

            airportGrid.Rows.Clear();
            for (int i = 0; i < data.Tables[0].Rows.Count; i++)
            {
                string ID = data.Tables[0].Rows[i].ItemArray[0].ToString();
                string Name = data.Tables[0].Rows[i].ItemArray[1].ToString();
                string City = data.Tables[0].Rows[i].ItemArray[2].ToString();
                string Country = data.Tables[0].Rows[i].ItemArray[3].ToString();

                DataGridViewRow dataPush = new DataGridViewRow();
                dataPush.CreateCells(airportGrid);
                dataPush.Cells[0].Value = ID;
                dataPush.Cells[1].Value = Name;
                dataPush.Cells[2].Value = City;
                dataPush.Cells[3].Value = Country;
                airportGrid.Rows.Add(dataPush);
            }
            con.Close();
        }

        //Function to view data after deletion in grid
        private void viewDataInDeletePanel()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from AIRPORT", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet data = new DataSet();
            adapter.Fill(data);

            deleteAirportGrid.Rows.Clear();
            for (int i = 0; i < data.Tables[0].Rows.Count; i++)
            {
                string ID = data.Tables[0].Rows[i].ItemArray[0].ToString();
                string Name = data.Tables[0].Rows[i].ItemArray[1].ToString();
                string City = data.Tables[0].Rows[i].ItemArray[2].ToString();
                string Country = data.Tables[0].Rows[i].ItemArray[3].ToString();

                DataGridViewRow dataPush = new DataGridViewRow();
                dataPush.CreateCells(deleteAirportGrid);
                dataPush.Cells[0].Value = ID;
                dataPush.Cells[1].Value = Name;
                dataPush.Cells[2].Value = City;
                dataPush.Cells[3].Value = Country;
                deleteAirportGrid.Rows.Add(dataPush);
            }
            con.Close();
        }

        //Function to delete airport
        private void deleteAirport()
        {
            con.Open();
            string id =airportIDDeleteBox.Text;
            SqlCommand cmd = new SqlCommand("delete from AIRPORT where Airport_ID=@a", con);
            cmd.Parameters.AddWithValue("@a", id);
            cmd.ExecuteNonQuery();
            con.Close();
            viewDataInDeletePanel();
            MessageBox.Show("Record has been deleted Successfully");
        }

        //To confirm deletion
        private void deleteAirportButton_Click(object sender, EventArgs e)
        {
            string value = airportIDDeleteBox.Text;
            if (check(value))
            {
                deleteAirport();
                airportIDDeleteBox.Text = "";
            }
            else
            {
                errorLabel.Text = "Error!! No such record exists";
                viewDataInDeletePanel();
            }
        }

        //Function to check whether the record exists in database

        private bool check(string value)
        {
            bool var = false;
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from AIRPORT where Airport_ID=@id", con);
            cmd.Parameters.AddWithValue("@id", value);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet data = new DataSet();
            adapter.Fill(data);

            deleteAirportGrid.Rows.Clear();
           if(data.Tables[0].Rows.Count > 0)
            {
                var = true;
            }
            con.Close();
            return var;
        }

        //To select delete panel
        private void deleteButton_Click(object sender, EventArgs e)
        {
            deleteAirportPanel.Visible = true;
            updateAirportPanel.Visible = false;
            addAirportPanel.Visible = false;
            viewDataInDeletePanel();
        }
    }
}
