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

namespace hotel_management
{
    public partial class CustomerMainMenu : Form
    {
        public Manage_Reservations ManageReservations { get; private set; }
        public View_Packages View_Packages { get; private set; }
        public Login Login { get; private set; }

        SqlConnection connection;
        public CustomerMainMenu(SqlConnection connection)
        {
            this.connection = connection;
            InitializeComponent();
        }

        private void reservations_Click(object sender, EventArgs e)
        {
            ManageReservations = new Manage_Reservations(connection);
            this.Hide();
            ManageReservations.Show();
        }

        private void packages_Click(object sender, EventArgs e)
        {
            View_Packages = new View_Packages(connection);
            this.Hide();
            View_Packages.Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Login = new Login();
            this.Hide();
            Login.Show();
        }
    }
}
