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
    public partial class signup_form : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-UUG2AVV;Initial Catalog=AirlineReservationSystem;Integrated Security=True");
        public signup_form()
        {
            InitializeComponent();
        }

        private void signup_form_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void saveData()
        {
            string firstName = firstName_box.Text;
            string lastName= lastName_box.Text;
            string passengerID= passengerID_box.Text;
            string dob= dob_box.Text;
            string gender= gender_box.Text;
            string nationality= nationality_box.Text;
            string phoneNumber= phone_box.Text;
            string phoneOptional= phone_optional_box.Text;
            string email= email_box.Text;
            string country= country_box.Text;
            string city= city_box.Text;
            string state= state_box.Text;
            string house= house_box.Text;
            string street = street_box.Text;
            string postalCode = postal_box.Text;
            string username = username_box.Text;
            string password = password_box.Text;
            string password_confirm = passwordConfirm_box.Text;

            con.Open();

            string firstQuery = "insert into PASSENGER(First_Name,Last_Name,Passenger_ID,Sex,Date_Of_birth) values(@fname, @lname, @passID,@gender,@dob)";
            string secondQuery = "insert into PASSENGER_CONTACT_DETAILS(Passenger_ID,Contact_Number,Email) Values(@passengerID, @phone, @email)";
            string thirdQuery = "insert into PASSENGER_ADDRESS (Passenger_ID,Zip_Code,Street,City,Passenger_State,Country,House_No) values(@pid,@postalCode,@street,@city,@state,@country,@house)";
            string fourthQuery = "insert into PASSENGER_LOGIN_DETAILS (Passenger_ID,Username,P_Password) values(@pp,@user,@pass)";
            SqlCommand cmd = new SqlCommand(firstQuery, con);
            SqlCommand cmd1 = new SqlCommand(secondQuery, con);
            SqlCommand cmd2 = new SqlCommand(thirdQuery, con);
            SqlCommand cmd3 = new SqlCommand(fourthQuery, con);

            cmd.Parameters.AddWithValue("@fname", firstName);
            cmd.Parameters.AddWithValue("@lname", lastName);
            cmd1.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@passID", passengerID);
            cmd1.Parameters.AddWithValue("@passengerID", passengerID);
            cmd2.Parameters.AddWithValue("@pid", passengerID);
            cmd3.Parameters.AddWithValue("@pp", passengerID);
            cmd.Parameters.AddWithValue("@dob", dob);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@nationality", nationality);
            cmd1.Parameters.AddWithValue("@phone", phoneNumber);
            cmd.Parameters.AddWithValue("@phoneO", phoneOptional);
            cmd2.Parameters.AddWithValue("@country", country);
            cmd2.Parameters.AddWithValue("@city", city);
            cmd2.Parameters.AddWithValue("@state", state);
            cmd2.Parameters.AddWithValue("@house", house);
            cmd2.Parameters.AddWithValue("@street", street);
            cmd2.Parameters.AddWithValue("@postalCode", postalCode);
            cmd3.Parameters.AddWithValue("@user", username);
            cmd3.Parameters.AddWithValue("@pass", password);
            cmd.Parameters.AddWithValue("@paconfirm", password_confirm);
            cmd.ExecuteNonQuery();
            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            cmd3.ExecuteNonQuery();
            MessageBox.Show("Your Data has been saved😊");
            con.Close();
        }

        private void signup_button_Click(object sender, EventArgs e)
        {
            saveData();
        }

        private void login_button_signup_form_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
