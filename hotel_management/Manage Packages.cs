using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace hotel_management
{
    public partial class Manage_Packages : Form
    {
        public AdminMainMenu AdminMainMenu { get; private set; }
        public All_Packages All_Packages { get; private set; }

        SqlConnection connection;
        public Manage_Packages(SqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        private void textId_TextChanged(object sender, EventArgs e)
        {

        }

        private void reset_Click(object sender, EventArgs e)
        {
            textId.Text = string.Empty;
            name.Text = string.Empty;
            costPerPerson.Text = string.Empty;
            description.Text = string.Empty;
            complementary.Text = string.Empty;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            AdminMainMenu = new AdminMainMenu(connection);
            this.Hide();
            AdminMainMenu.Show();
        }

        private void Manage_Packages_Load(object sender, EventArgs e)
        {

        }

        private void create_Click(object sender, EventArgs e)
        {
            // SQL query with parameters
            string query = "INSERT INTO Manage_Packages (mid, name, costPerPerson, description, complementary) VALUES (@Mid, @Name, @CostPerPerson, @Description, @Complementary)";
            SqlCommand command = new SqlCommand(query, connection);

            // Add parameters to the command
            command.Parameters.AddWithValue("@Mid", textId.Text);
            command.Parameters.AddWithValue("@Name", name.Text);
            command.Parameters.AddWithValue("@CostPerPerson", costPerPerson.Text);
            command.Parameters.AddWithValue("@Description", description.Text);
            command.Parameters.AddWithValue("@Complementary", complementary.Text);
            

            int rowsAffected = command.ExecuteNonQuery();

            textId.Text = string.Empty;
            name.Text = string.Empty;
            costPerPerson.Text = string.Empty;
            description.Text = string.Empty;
            complementary.Text = string.Empty;
        }

        private void viewAllPackages_Click(object sender, EventArgs e)
        {
            All_Packages = new All_Packages(connection);
            this.Hide();
            All_Packages.Show();
        }
    }
}
