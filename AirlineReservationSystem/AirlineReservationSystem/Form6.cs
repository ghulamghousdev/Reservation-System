using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineReservationSystem
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            string firstName = firstNameBox.Text;
            string lastName = lastNameBox.Text;
            string adminID = adminBox.Text;
            string userName = namBox.Text;
            string password = passBox.Text;
            string email = emailBox.Text;
            string contact = contactBox.Text;
            string address = addressBox.Text;


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
    }
}
