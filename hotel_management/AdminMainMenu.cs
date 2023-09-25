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
    public partial class AdminMainMenu : Form
    {
        public Login Form1 { get; }
        public Manage_Packages Manage_Packages { get; private set; }
        public Manage_Staff Manage_Staff { get; private set; }
        public Login Login { get; private set; }

        SqlConnection connection;
        public AdminMainMenu(SqlConnection connection)
        {
            this.connection = connection;
            InitializeComponent();
        }

        private void staff_Click(object sender, EventArgs e)
        {
            Manage_Staff = new Manage_Staff(connection);
            this.Hide();
            Manage_Staff.Show();

        }

        private void packages_Click(object sender, EventArgs e)
        {
            Manage_Packages = new Manage_Packages(connection);
            this.Hide();
            Manage_Packages.Show();
        }

        private void AdminMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            Login = new Login();
            this.Hide();
            Login.Show();
        }
    }
}
