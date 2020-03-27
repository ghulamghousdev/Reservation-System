using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_Reservation_System
{
    public partial class Scedule : Form
    {
        public Scedule()
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
    }
}
