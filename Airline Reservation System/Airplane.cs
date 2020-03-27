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
    public partial class Airplane : Form
    {        //Connection with database
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-UUG2AVV;Initial Catalog=AirlineReservationSystem;Integrated Security=True");

        public Airplane()
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

        private void Airplane_Load(object sender, EventArgs e)
        {
           this.addAirplanePanel.Visible = true;
           this.updateAirplanePanel.Visible = false;
           this.deleteAirplanePanel.Visible = false;
        }


        private void addAirplaneButton_Click(object sender, EventArgs e)
        {
            this.addAirplanePanel.Visible = true;
            this.updateAirplanePanel.Visible = false;
            this.deleteAirplanePanel.Visible = false;
        }

        private void updateAirplaneButton_Click(object sender, EventArgs e)
        {
            this.addAirplanePanel.Visible = false;
            deleteAirplanePanel.Visible = false;
            this.updateAirplanePanel.Visible = true;
            viewData();
        }

        //To select delete panel
        private void deleteAirplaneButton_Click(object sender, EventArgs e)
        {
            deleteAirplanePanel.Visible = true;
            updateAirplanePanel.Visible = false;
            addAirplanePanel.Visible = false;
            viewDataInDeletePanel();
        }




        //Event to save data about airport into the database
        private void saveAirplaneIntoDatabase_Click(object sender, EventArgs e)
        {
            string airlineID = airlineIDBox.Text;
            string airplaneID = airplaneIDBox.Text;
            string regNo = regNumberBox.Text;
            string seats = seatsBox.Text;
            string cat = categoryBox.Text;
            bool flag1 = false;
            bool flag2 = false;
            if(check(airlineID, "AIRPLANE", "Airplane_ID"))
            {
                flag1 = true;
            }
            else
            {
                msgLabel.Text = "Airplane ID is already present in the table!";
            }
            if (check(airlineID, "AIRLINE", "Airline_ID")==false)
            {
                flag2 = true;
            }
            else
            {
                errorMsg.Text = "Airline ID does not exist in Airline table!";
            }
            if (flag1 == true && flag2 == true)
            {
                con.Open(); //opening connection
                string query = "insert into Airplane (Airplane_ID, Airplane_ID, Reg_Number, Seats, Category) values(@id, @id1, @rg, @seat, @cat)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", airlineID);
                cmd.Parameters.AddWithValue("@id1", airplaneID);
                cmd.Parameters.AddWithValue("@rg", regNo);
                cmd.Parameters.AddWithValue("@seat", seats);
                cmd.Parameters.AddWithValue("@cat", cat);
                cmd.ExecuteNonQuery();
                con.Close();
                msgLabel.Text = "Data saved successfuly😊";
                airlineIDBox.Text = "";
                airplaneIDBox.Text = "";
                regNumberBox.Text = "";
                seatsBox.Text = "";
                categoryBox.Text = "";
                errorMsg.Text = "";
                msgLabel.Text = "";
            }
        }

        private void updateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            miniUpdatePanel.Visible = true;
            propertyLabel.Text = "";
            airplaneID_InputBox.Text = "";
            property_Box.Text = "";
            propertyLabel.Text = updateComboBox.Text;

        }

        private void updateSubmission_Button_Click(object sender, EventArgs e)
        {
            string airplaneID = airplaneID_InputBox.Text;
            string prop = property_Box.Text;
            string attributeName = updateComboBox.Text;
            if (check(airplaneID,"AIRPLANE","Airplane_ID"))
            {
                updateAirplane(attributeName, prop, airplaneID);
            }
            else
            {
                msgAlert.Text = "Error!! No such record exists";
                viewData();
            }
        }

        //Function to update data of airport table
        private void updateAirplane(string attributeName, string propertyValue, string ID)
        {
            con.Open();
            string query = "update AIRPLANE set " + attributeName + " =@propertyValue where Airplane_ID=@ID";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@propertyValue", propertyValue);
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.ExecuteNonQuery();
            con.Close();
            viewData();
            msgAlert.Text="Record Updated successfuly😊";
            miniUpdatePanel.Visible = false;
        }

        //Retrieving data from database
        private void viewData()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from AIRPLANE", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet data = new DataSet();
            adapter.Fill(data);

            airplaneUpdationGrid.Rows.Clear();
            for (int i = 0; i < data.Tables[0].Rows.Count; i++)
            {
                string ID = data.Tables[0].Rows[i].ItemArray[0].ToString();
                string AID = data.Tables[0].Rows[i].ItemArray[1].ToString();
                string rg = data.Tables[0].Rows[i].ItemArray[2].ToString();
                string seats = data.Tables[0].Rows[i].ItemArray[3].ToString();
                string cap = data.Tables[0].Rows[i].ItemArray[4].ToString();


                DataGridViewRow dataPush = new DataGridViewRow();
                dataPush.CreateCells(airplaneUpdationGrid);
                dataPush.Cells[0].Value = ID;
                dataPush.Cells[1].Value = AID;
                dataPush.Cells[2].Value = rg;
                dataPush.Cells[3].Value = seats;
                dataPush.Cells[4].Value = cap;
                airplaneUpdationGrid.Rows.Add(dataPush);
            }
            con.Close();
        }

        //Function to view data after deletion in grid
        private void viewDataInDeletePanel()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from AIRPLANE", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet data = new DataSet();
            adapter.Fill(data);

            deleteAirplaneGrid.Rows.Clear();
            for (int i = 0; i < data.Tables[0].Rows.Count; i++)
            {
                string ID = data.Tables[0].Rows[i].ItemArray[0].ToString();
                string AID = data.Tables[0].Rows[i].ItemArray[1].ToString();
                string rg = data.Tables[0].Rows[i].ItemArray[2].ToString();
                string seats = data.Tables[0].Rows[i].ItemArray[3].ToString();
                string cap = data.Tables[0].Rows[i].ItemArray[4].ToString();


                DataGridViewRow dataPush = new DataGridViewRow();
                dataPush.CreateCells(deleteAirplaneGrid);
                dataPush.Cells[0].Value = ID;
                dataPush.Cells[1].Value = AID;
                dataPush.Cells[2].Value = rg;
                dataPush.Cells[3].Value = seats;
                dataPush.Cells[4].Value = cap;
                deleteAirplaneGrid.Rows.Add(dataPush);
            }
            con.Close();
        }

        //Function to delete airport
        private void deleteAirplane()
        {
            con.Open();
            string id = airplaneIDDeleteBox.Text;
            SqlCommand cmd = new SqlCommand("delete from AIRPLANE where Airplane_ID=@a", con);
            cmd.Parameters.AddWithValue("@a", id);
            cmd.ExecuteNonQuery();
            con.Close();
            viewDataInDeletePanel();
            errorLabel.Text="Record deleted Successfully";
        }

        //To confirm deletion
        private void deleteAirplaneConfrmButton_Click(object sender, EventArgs e)
        {
            string value = airplaneIDDeleteBox.Text;
            if (check(value,"AIRPLANE","Airplane_ID"))
            {
                deleteAirplane();
                airplaneIDDeleteBox.Text = "";
            }
            else
            {
                errorLabel.Text = "Error!! No such record exists";
                viewDataInDeletePanel();
            }
        }

        //Function to check whether the record exists in database

        private bool check(string value, string tableName, string attribute)
        {
            bool flag = false;
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from "+tableName+"  where "+attribute+"=@id", con);
            cmd.Parameters.AddWithValue("@id", value);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet data = new DataSet();
            adapter.Fill(data);

            if (data.Tables[0].Rows.Count > 0)
            {
                flag = true;
            }
            con.Close();
            return flag;
        }

    }
}
