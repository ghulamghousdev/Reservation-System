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
        string query = "";
   
        public Form1()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            //Setting the position of the signin panel
            signInPanel.Location = new Point(433, 180);
            selectorPanel.Location = new Point(433, 180);
        }
       
        //This event handles the visibility of panels
        private void Form1_Load(object sender, EventArgs e)
        {
            onFormLoad();    
        }


        private void credientialsCheck(object sender, EventArgs e, string query)
        {
            string username = usernameBox.Text;
            string password = passwordBox.Text;
            if(username.Length > 8)
            {
                if(password.Length > 5)
                {
                    try
                    {
                        con.Open();

                        SqlCommand cmd = new SqlCommand(query, con);

                        cmd.Parameters.AddWithValue("@user", username);
                        cmd.Parameters.AddWithValue("@pass", password);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);

                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            if (userLabel.Text == "Admin")
                            {
                                new AdminControls().Show();
                                this.Hide();
                            }
                            else
                            {
                                new options().Show();
                                this.Hide();
                            }
                            
                        }
                        else
                        {
                            errorLabel.Text = "Invalid Credientials";
                            usernameBox.Text = "";
                            passwordBox.Text = "";
                        }
                        con.Close();

                    }
                    catch
                    {
                        MessageBox.Show("Connection Error");
                        this.Close();
                    }
                }
                else
                {
                    usernameBox.Text = "";
                    passwordBox.Text = "";
                    errorLabel.Text = "Invalid Password";
                }
            }
            else
            {
                usernameBox.Text = "";
                passwordBox.Text = "";
                errorLabel.Text = "Invalid UserName";
            }
            
        }


        //This Function manages the visibility of the panels
        private void onFormLoad()
        {
            signInPanel.Visible = false;
            selectorPanel.Visible = true;
        }

        private void adminPicture_Click(object sender, EventArgs e)
        {
            selectorPanel.Visible = false;
            signInPanel.Visible = true;
            userLabel.Text = "Admin";
        }

        private void adminLink_Click(object sender, EventArgs e)
        {
            selectorPanel.Visible = false;
            signInPanel.Visible = true;
            userLabel.Text = "Admin";
        }

        private void customerPicture_Click(object sender, EventArgs e)
        {
            selectorPanel.Visible = false;
            signInPanel.Visible = true;
            userLabel.Text = "Customer";
        }

        private void customerButton_Click(object sender, EventArgs e)
        {
            selectorPanel.Visible = false;
            signInPanel.Visible = true;
            userLabel.Text = "Customer";
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            if(userLabel.Text == "Customer")
            {
                query = "SELECT * FROM PASSENGER_CREDIENTIALS where Username=@user AND Password=@pass";
            }
            else
            {
                query = "SELECT * FROM ADMIN_CREDIENTIALS where Username=@user AND Password=@pass";
            }
            credientialsCheck(sender, e, query);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AdminControls().Show();
            this.Hide();
        }
    }
}
