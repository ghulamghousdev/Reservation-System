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
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-UUG2AVV;Initial Catalog=AirlineReservationSystem;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void signup_button_Click(object sender, EventArgs e)
        {
            new signup_form().Show();
            this.Hide();
        }

        private void signin_button_Click(object sender, EventArgs e)
        {
            con.Open();

            string username = username_box.Text;
            string password = password_box.Text;
            string firstQuery = "select * from PASSENGER_LOGIN_DETAILS where Username=@user AND P_Password=@pass";

            SqlCommand cmd = new SqlCommand(firstQuery, con);

            cmd.Parameters.AddWithValue("@user", username);
            cmd.Parameters.AddWithValue("@pass", password);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                new options().Show();
                this.Hide();
            }
            else
            {
                error.Text = "Invalid password or username";
                username_box.Text = "";
                password_box.Text = "";
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AdminControls().Show();
            this.Hide();
        }
    }
}
