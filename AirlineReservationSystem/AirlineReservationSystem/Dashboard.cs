using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineReservationSystem
{
    public partial class Dashboard : Form
    {
        string flag = "AIRPORT";
        string flagForDeleteUpdate = "";
        string id = "";
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-UUG2AVV;Initial Catalog=AirlineReservationSystem;Integrated Security=True");
        public Dashboard()
        {
            InitializeComponent();
            populateGrid();
            this.selectAttribute.Visible = false;
            this.label1.Visible = false;
            this.newValueBox.Visible = false;
            this.deleteIDTextBox.Visible = false;
            this.deletePromptLabel.Visible = false;
            this.deleteButtonCon.Visible = false;
        }

       

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }


        private void viewCarGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void populateGrid()
        {
            tableNameHeader.Text = flag;
            if (flag == "AIRPORT")
            {
                con.Open();
                viewGrid.Columns[0].Visible = true;
                viewGrid.Columns[1].Visible = true;
                viewGrid.Columns[2].Visible = true;
                viewGrid.Columns[3].Visible = true;
                viewGrid.Columns[0].HeaderText = "Airport_ID";
                viewGrid.Columns[1].HeaderText = "Airport_Name";
                viewGrid.Columns[2].HeaderText = "City";
                viewGrid.Columns[3].HeaderText = "Country";
                viewGrid.Columns[4].Visible = false;
                viewGrid.Columns[5].Visible = false;
                viewGrid.Columns[6].Visible = false;
                viewGrid.Columns[7].Visible = false;
                SqlCommand cmd = new SqlCommand("Select * from airport", con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                viewGrid.Rows.Clear();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    string id = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                    string name = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                    string city = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                    string country = ds.Tables[0].Rows[i].ItemArray[3].ToString();

                    DataGridViewRow dataPush = new DataGridViewRow();
                    dataPush.CreateCells(viewGrid);
                    dataPush.Cells[0].Value = id;
                    dataPush.Cells[1].Value = name;
                    dataPush.Cells[2].Value = city;
                    dataPush.Cells[3].Value = country;
                    viewGrid.Rows.Add(dataPush);
                }
                con.Close();
            }
            else if (flag == "AIRLINE")
            {
                con.Open();
                viewGrid.Columns[0].Visible = true;
                viewGrid.Columns[1].Visible = true;
                viewGrid.Columns[2].Visible = true;
                viewGrid.Columns[0].HeaderText = "Airline_ID";
                viewGrid.Columns[1].HeaderText = "Airline_Name";
                viewGrid.Columns[2].HeaderText = "Airplanes";
                viewGrid.Columns[3].Visible = false;
                viewGrid.Columns[4].Visible = false;
                viewGrid.Columns[5].Visible = false;
                viewGrid.Columns[6].Visible = false;
                viewGrid.Columns[7].Visible = false;
                SqlCommand cmd = new SqlCommand("Select * from AIRLINE", con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                viewGrid.Rows.Clear();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    string id = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                    string name = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                    string airplanes = ds.Tables[0].Rows[i].ItemArray[2].ToString();

                    DataGridViewRow dataPush = new DataGridViewRow();
                    dataPush.CreateCells(viewGrid);
                    dataPush.Cells[0].Value = id;
                    dataPush.Cells[1].Value = name;
                    dataPush.Cells[2].Value = airplanes;
                    viewGrid.Rows.Add(dataPush);
                }
                con.Close();
                
            }
            else if (flag == "AIRPLANE")
            {
                con.Open();
                viewGrid.Columns[0].Visible = true;
                viewGrid.Columns[1].Visible = true;
                viewGrid.Columns[2].Visible = true;
                viewGrid.Columns[3].Visible = true;
                viewGrid.Columns[4].Visible = true;
                viewGrid.Columns[5].Visible = false;
                viewGrid.Columns[6].Visible = false;
                viewGrid.Columns[7].Visible = false;
                viewGrid.Columns[3].HeaderText = "Airline_ID";
                viewGrid.Columns[0].HeaderText = "Airplane_ID";
                viewGrid.Columns[1].HeaderText = "Reg Number";
                viewGrid.Columns[2].HeaderText = "Seats";
                viewGrid.Columns[4].HeaderText = "Category";
                SqlCommand cmd = new SqlCommand("Select * from AIRPLANE", con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                
                viewGrid.Rows.Clear();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {

                    string airline_ID = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                    string id = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                    string reg = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                    string seats = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                    string category = ds.Tables[0].Rows[i].ItemArray[4].ToString();

                    DataGridViewRow dataPush = new DataGridViewRow();
                    dataPush.CreateCells(viewGrid);
                    dataPush.Cells[0].Value = id;
                    dataPush.Cells[1].Value = reg;
                    dataPush.Cells[2].Value = seats;
                    dataPush.Cells[3].Value = airline_ID;
                    dataPush.Cells[4].Value = category;
                    viewGrid.Rows.Add(dataPush);
                }
                con.Close();
            }
            else if (flag == "FLIGHT")
            {
                con.Open();

                viewGrid.Columns[0].Visible = true;
                viewGrid.Columns[1].Visible = true;
                viewGrid.Columns[2].Visible = true;
                viewGrid.Columns[3].Visible = true;
                viewGrid.Columns[4].Visible = true;
                viewGrid.Columns[5].Visible = true;
                viewGrid.Columns[6].Visible = true;
                viewGrid.Columns[7].Visible = true;
                viewGrid.Columns[0].HeaderText = "Flight_ID";
                viewGrid.Columns[1].HeaderText = "Airplane_ID";
                viewGrid.Columns[2].HeaderText = "Departure_City";
                viewGrid.Columns[3].HeaderText = "Arrival_City";
                viewGrid.Columns[4].HeaderText = "Departure_Time";
                viewGrid.Columns[5].HeaderText = "Arrival_Time";
                viewGrid.Columns[6].HeaderText = "Departure_Date";
                viewGrid.Columns[7].HeaderText = "Arrival_Date";
                SqlCommand cmd = new SqlCommand("Select * from FLIGHT", con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);


                viewGrid.Rows.Clear();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {

                    string f_id = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                    string a_id = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                    string d_city = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                    string a_city = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                    string d_t = ds.Tables[0].Rows[i].ItemArray[4].ToString();
                    string a_t = ds.Tables[0].Rows[i].ItemArray[5].ToString(); 
                    string d_d = ds.Tables[0].Rows[i].ItemArray[6].ToString(); 
                    string a_d = ds.Tables[0].Rows[i].ItemArray[7].ToString();



                    DataGridViewRow dataPush = new DataGridViewRow();
                    dataPush.CreateCells(viewGrid);
                    dataPush.Cells[0].Value = f_id;
                    dataPush.Cells[1].Value = a_id;
                    dataPush.Cells[2].Value = d_city;
                    dataPush.Cells[3].Value = a_city; 
                    dataPush.Cells[4].Value = d_t;
                    dataPush.Cells[5].Value = a_t;
                    dataPush.Cells[6].Value = d_d;
                    dataPush.Cells[7].Value = a_d;
                    viewGrid.Rows.Add(dataPush);
                }
                con.Close();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            airport();
        }

        public void airport()
        {
            flag = "AIRPORT";
            tableNameHeader.Text = "Airport";
            populateGrid();
            setID();
        }

        public void airline()
        {
            flag = "AIRLINE";
            tableNameHeader.Text = "Airline";
            populateGrid();
            setID();
        }

        public void airplane()
        {
            flag = "AIRPLANE";
            tableNameHeader.Text = "Airport";
            populateGrid();
            setID();
        }
        public void flight()
        {
            flag = "FLIGHT";
            tableNameHeader.Text = "Airport";
            populateGrid();
            setID();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            airport();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            airline();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            airline();
        }

        private void airplaneImage_Click(object sender, EventArgs e)
        {
            airplane();
        }

        private void airplaneButton_Click(object sender, EventArgs e)
        {
            airplane();
        }

        private void flightButton_Click(object sender, EventArgs e)
        {
            flight();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            this.selectAttribute.Visible = false;
            this.label1.Visible = false;
            this.newValueBox.Visible = false;
            this.deleteIDTextBox.Visible = true;
            this.deletePromptLabel.Visible = true;
            this.deleteButtonCon.Visible = true;
            this.deleteButtonCon.Text = "Delete";
            flagForDeleteUpdate = "Delete";
        }

        private void deleteButtonCon_Click(object sender, EventArgs e)
        {
            if (flagForDeleteUpdate == "Delete")
            {
                deleteRecords();
            }
            else if(flagForDeleteUpdate == "Update")
            {
                editRecords();
            }
        }

        private void deleteRecords()
        {
            setID();
            con.Open();
            string valueTo = deleteIDTextBox.Text;
            if (flag=="AIRLINE")
            {
                SqlCommand cmd1 = new SqlCommand("Select Airplane_ID from AIRPLANE where Airline_ID=@a", con);
                cmd1.Parameters.AddWithValue("@a", valueTo);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd1);
                DataSet ds1 = new DataSet();
                adapter.Fill(ds1);
                for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
                {
                    string found = ds1.Tables[0].Rows[i].ItemArray[0].ToString();
                    SqlCommand cmd3 = new SqlCommand("delete from  FLIGHT  where Airplane_ID=@aaa", con);
                    cmd3.Parameters.AddWithValue("@aaa", found);
                    cmd3.ExecuteNonQuery();
                    SqlCommand cmd4 = new SqlCommand("delete from  Airplane  where Airplane_ID=@aa1", con);
                    cmd4.Parameters.AddWithValue("@aa1", found);
                    cmd4.ExecuteNonQuery();
                }
                MessageBox.Show("Deleted");
                SqlCommand cmd = new SqlCommand("delete from " + flag + " where " + id + "=@a", con);
                cmd.Parameters.AddWithValue("@a", valueTo);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Deleted");
            con.Close();
            populateGrid();
            deleteIDTextBox.Text = "";
        }

        public void setID()
        {
            if (flag == "AIRPORT")
            {
                id = "Airport_ID";
                this.selectAttribute.Items.Clear();
                this.selectAttribute.Items.AddRange(new object[] {
            "Airport_Name",
            "City",
            "Country"});
            }
            else if (flag == "AIRPLANE")
            {
                id = "Airplane_ID";
                this.selectAttribute.Items.Clear();
                this.selectAttribute.Items.AddRange(new object[] {
            "Reg_Number",
                "Seats",
                "Category"});
            }
            if (flag == "AIRLINE")
            {
                id = "Airline_ID";
                this.selectAttribute.Items.Clear();
                this.selectAttribute.Items.AddRange(new object[] {
            "Airline_Name",
            "Airplanes"});
            }
            if (flag == "FLIGHT")
            {
                id = "Flight_ID";
                this.selectAttribute.Items.Clear();
                this.selectAttribute.Items.AddRange(new object[] {
            "Departure_City",
            "Arrival_City",
            "Departure_Time",
            "Arrival_Time",
            "Departure_Date",
            "Arrival_Date"
            });
            }
        }

        public void editRecords()
        {
            con.Open();
            setID();
            string idToUpdated = deleteIDTextBox.Text;
            string newValue = newValueBox.Text;
            string att = selectAttribute.Text;

            SqlCommand cmd = new SqlCommand("update " + flag + " set " + att + "=@newVal where " +id+"=@IDUPDate", con);
            cmd.Parameters.AddWithValue("newVal", newValue);
            cmd.Parameters.AddWithValue("IDUPDate", idToUpdated);

            cmd.ExecuteNonQuery();

            MessageBox.Show("The Record has been updated!");
            con.Close();
            populateGrid();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            setID();
            this.selectAttribute.Visible = true;
            this.label1.Visible = true;
            this.newValueBox.Visible = true;
            this.deleteIDTextBox.Visible = true;
            this.deletePromptLabel.Visible = true;
            this.deleteButtonCon.Visible = true;
            this.deleteButtonCon.Text = "Update";
            flagForDeleteUpdate = "Update";
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (flag == "AIRPORT")
            {
                new Form1().Show();
                this.Hide();
            }
            else if(flag== "AIRLINE")
            {
                new Form2().Show();
                this.Hide();
            }
            else if (flag == "AIRPLANE")
            {
                new Form3().Show();
                this.Hide();
            }
            else  if (flag == "FLIGHT")
            {
                new Form4().Show();
                this.Hide();
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

