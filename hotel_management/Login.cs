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
    public partial class Login : Form
    {
        public AdminMainMenu AdminMainMenu { get; private set; }
        public CustomerMainMenu CustomerMainMenu { get; private set; }
        public Create_Account Create_Account { get; private set; }

        string connectionString = "Server=localhost\\SQLEXPRESS;Database=HotelDB;Trusted_Connection=True;";
        SqlConnection connection;
        public Login()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT role FROM Login WHERE Username = '"+ textBox1.Text + "' AND Password = '"+ textBox2.Text +"'";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            string userRole ="";
            while (reader.Read())
            {
                userRole = reader.GetString(0).ToString();
                
            }
            reader.Close();

            AdminMainMenu = new AdminMainMenu(connection);
                CustomerMainMenu = new CustomerMainMenu(connection);

            if(userRole == "admin")
            {
               this.Hide();
                AdminMainMenu.Show();
            }else if(userRole == "user") 
            {
               this.Hide();
                CustomerMainMenu.Show();
            }

        }

        private void account_Click(object sender, EventArgs e)
        {
            //label1.Text = "clicked";
            Create_Account = new Create_Account(connection);
            this.Hide();
            Create_Account.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
