using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineReservationSystem
{
    public partial class Form5 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-UUG2AVV;Initial Catalog=AirlineReservationSystem;Integrated Security=True");
        public Form5()
        {
            InitializeComponent();
        }



        private void exitBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void logBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            string user,  pass;
            user = namBox.Text;
            pass = passBox.Text;

            string logQuery = "select * from ADMIN_CREDIENTIALS where Username = @id and  Password= @pin";

            SqlCommand logCmd = new SqlCommand(logQuery, con);
            logCmd.Parameters.AddWithValue("@id", user);
            logCmd.Parameters.AddWithValue("@pin", pass);

            SqlDataAdapter LogAdpater = new SqlDataAdapter(logCmd);
            DataSet LogSet = new DataSet();
            LogAdpater.Fill(LogSet);

            if ((LogSet.Tables[0].Rows.Count) > 0)
            {
                new Dashboard().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Credientials are incorrect. Try Again :)");
                namBox.Text = "";
                passBox.Text = "";
            }

            con.Close();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}




