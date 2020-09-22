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
    public partial class Form6 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-UUG2AVV;Initial Catalog=AirlineReservationSystem;Integrated Security=True");

        public Form6()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
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
            string firstQuery = "INSERT INTO ADMIN(First_Name, Last_Name, Admin_ID, Username, Admin_Password, Email, Contact, Admin_Address ) values(@a, @b, @c, @d, @e, @f, @g, @h)";
            SqlCommand cmd = new SqlCommand(firstQuery, con);
            cmd.Parameters.AddWithValue("@a", firstName);
            cmd.Parameters.AddWithValue("@b", lastName);
            cmd.Parameters.AddWithValue("@c", adminID);
            cmd.Parameters.AddWithValue("@d", userName);
            cmd.Parameters.AddWithValue("@e", password);
            cmd.Parameters.AddWithValue("@f", email);
            cmd.Parameters.AddWithValue("@g", contact);
            cmd.Parameters.AddWithValue("@h", address);
            cmd.ExecuteNonQuery();
            con.Close();

            new Form5().Show();
            this.Hide();
        }
    }
}
