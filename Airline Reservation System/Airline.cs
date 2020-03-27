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
    public partial class Airline : Form
    {  
        //Connection with database
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-UUG2AVV;Initial Catalog=AirlineReservationSystem;Integrated Security=True");

        public Airline()
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

        private void Airline_Load(object sender, EventArgs e)
        {
            this.addAirportPanel.Visible = true;
            this.updateAirportPanel.Visible = false;
            deleteAirportPanel.Visible = false;
        }



        private void addAirlineButton_Click(object sender, EventArgs e)
        {
            this.addAirportPanel.Visible = true;
            this.updateAirportPanel.Visible = false;
            deleteAirportPanel.Visible = false;
        }

        private void updateAirlineButton_Click(object sender, EventArgs e)
        {
            this.addAirportPanel.Visible = false;
            deleteAirportPanel.Visible = false;
            this.updateAirportPanel.Visible = true;
            viewData();
        }

        //To select delete panel
        private void deleteAirlineButton_Click(object sender, EventArgs e)
        {
            deleteAirportPanel.Visible = true;
            updateAirportPanel.Visible = false;
            addAirportPanel.Visible = false;
            viewDataInDeletePanel();
        }

        //Event to save data about airport into the database
        private void saveAirlineIntoDatabase_Click(object sender, EventArgs e)
        {
            string airlineID = airlineIDBox.Text;
            string airlineName = airlineNameBox.Text;
            string noOfAirplanes = noOfAirplanesBox.Text;
            con.Open(); //opening connection
            string query = "insert into Airline (Airline_ID, Airline_Name, Airplanes) values(@id, @name, @airplanes)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", airlineID);
            cmd.Parameters.AddWithValue("@name", airlineName);
            cmd.Parameters.AddWithValue("@airplanes", noOfAirplanes);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Your Data has been saved successfuly😊");
            airlineIDBox.Text = "";
            airlineNameBox.Text = "";
            noOfAirplanesBox.Text = "";
        }


        private void updateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            miniUpdatePanel.Visible = true;
            propertyLabel.Text = "";
            airlineID_InputBox.Text = "";
            property_Box.Text = "";
            propertyLabel.Text = updateComboBox.Text;

        }

        private void updateSubmission_Button_Click(object sender, EventArgs e)
        {
            string airlineID = airlineID_InputBox.Text;
            string prop = property_Box.Text;
            string attributeName = updateComboBox.Text;
            if (check(airlineID))
            {
                updateAirline(attributeName, prop, airlineID);
            }
            else
            {
                errorMsg.Text = "Error!! No such record exists";
                viewData();
            }
        }

        //Function to update data of airport table
        private void updateAirline(string attributeName, string propertyValue, string ID)
        {
            con.Open();
            string query = "update AIRLINE set " + attributeName + " =@propertyValue where Airline_ID=@ID";
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
            SqlCommand cmd = new SqlCommand("Select * from AIRLINE", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet data = new DataSet();
            adapter.Fill(data);

            airlineUpdationGrid.Rows.Clear();
            for (int i = 0; i < data.Tables[0].Rows.Count; i++)
            {
                string ID = data.Tables[0].Rows[i].ItemArray[0].ToString();
                string Name = data.Tables[0].Rows[i].ItemArray[1].ToString();
                string Quantity = data.Tables[0].Rows[i].ItemArray[2].ToString();

                DataGridViewRow dataPush = new DataGridViewRow();
                dataPush.CreateCells(airlineUpdationGrid);
                dataPush.Cells[0].Value = ID;
                dataPush.Cells[1].Value = Name;
                dataPush.Cells[2].Value = Quantity;
                airlineUpdationGrid.Rows.Add(dataPush);
            }
            con.Close();
        }

        //Function to view data after deletion in grid
        private void viewDataInDeletePanel()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from AIRLINE", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet data = new DataSet();
            adapter.Fill(data);

            deleteAirlineGrid.Rows.Clear();
            for (int i = 0; i < data.Tables[0].Rows.Count; i++)
            {
                string ID = data.Tables[0].Rows[i].ItemArray[0].ToString();
                string Name = data.Tables[0].Rows[i].ItemArray[1].ToString();
                string Quantity = data.Tables[0].Rows[i].ItemArray[2].ToString();

                DataGridViewRow dataPush = new DataGridViewRow();
                dataPush.CreateCells(deleteAirlineGrid);
                dataPush.Cells[0].Value = ID;
                dataPush.Cells[1].Value = Name;
                dataPush.Cells[2].Value = Quantity;
                deleteAirlineGrid.Rows.Add(dataPush);
            }
            con.Close();
        }

        //Function to delete airport
        private void deleteAirline()
        {
            con.Open();
            string id = airlineIDDeleteBox.Text;
            SqlCommand cmd = new SqlCommand("delete from AIRLINE where Airline_ID=@a", con);
            cmd.Parameters.AddWithValue("@a", id);
            cmd.ExecuteNonQuery();
            con.Close();
            viewDataInDeletePanel();
            MessageBox.Show("Record has been deleted Successfully");
        }

        //To confirm deletion
        private void deleteAirlineConfrmButton_Click(object sender, EventArgs e)
        {
            string value = airlineIDDeleteBox.Text;
            if (check(value))
            {
                deleteAirline();
                airlineIDDeleteBox.Text = "";
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
            SqlCommand cmd = new SqlCommand("Select * from AIRLINE where Airline_ID=@id", con);
            cmd.Parameters.AddWithValue("@id", value);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet data = new DataSet();
            adapter.Fill(data);

            deleteAirlineGrid.Rows.Clear();
            if (data.Tables[0].Rows.Count > 0)
            {
                var = true;
            }
            con.Close();
            return var;
        }


    }
}
