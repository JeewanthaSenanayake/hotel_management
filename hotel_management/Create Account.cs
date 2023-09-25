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
    public partial class Create_Account : Form
    {
        SqlConnection connection;
        public Create_Account(SqlConnection connection)
        {
            this.connection = connection;
            InitializeComponent();
        }

        public Login Login { get; private set; }

        private void back_Click(object sender, EventArgs e)
        {
            Login = new Login();
            this.Hide();
            Login.Show();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            username.Text = string.Empty;
            password.Text = string.Empty;
        }

        private void create_Click(object sender, EventArgs e)
        {

            // SQL query with parameters
            string query = "INSERT INTO Login (username, password, role) VALUES (@Username, @Password, @Role)";
            SqlCommand command = new SqlCommand(query, connection);

            // Add parameters to the command
            command.Parameters.AddWithValue("@Username", username.Text);
            command.Parameters.AddWithValue("@Password", password.Text);
            command.Parameters.AddWithValue("@Role", "user");

            int rowsAffected = command.ExecuteNonQuery();

            Login = new Login();
            this.Hide();
            Login.Show();

        }

        private void Create_Account_Load(object sender, EventArgs e)
        {

        }
    }
}
