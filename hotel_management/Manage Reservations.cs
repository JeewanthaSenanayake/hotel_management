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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace hotel_management
{
    public partial class Manage_Reservations : Form
    {
        public CustomerMainMenu CustomerMainMenu { get; private set; }
        SqlConnection connection;
        public Manage_Reservations(SqlConnection connection)
        {
            this.connection = connection;
            InitializeComponent();
        }

        private void textId_TextChanged(object sender, EventArgs e)
        {

        }

        private void reset_Click(object sender, EventArgs e)
        {
            textId.Text = string.Empty;
            fName.Text = string.Empty;
            address.Text = string.Empty;
            mobile.Text = string.Empty;
            dateTimePicker.Text = string.Empty;
            noOfPax.Text = string.Empty;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            CustomerMainMenu = new CustomerMainMenu(connection);
            this.Hide();
            CustomerMainMenu.Show();
        }

        private void noOfPax_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int noOfPaxCount = int.Parse(noOfPax.Text);
                if (noOfPaxCount == 0)
                {
                    tcost.Text = "Rs.0";
                }
                else if (noOfPaxCount <= 5)
                {
                    tcost.Text = "Rs.3000";
                }
                else if (noOfPaxCount <= 20)
                {
                    tcost.Text = "Rs.2500";
                }
                else if (noOfPaxCount <= 50)
                {
                    tcost.Text = "Rs.1500";
                }
                else
                {
                    tcost.Text = "Rs.1000";
                }
            }
            catch 
            {
                tcost.Text = "Rs.0";
                noOfPax.Text = "";
            }
        }

        private void create_Click(object sender, EventArgs e)
        {
            // SQL query with parameters
            string query = "INSERT INTO Manage_Reservations (uid, fname, address, mobile, date, pax, cost) VALUES (@Uid, @Fname, @Address, @Mobile, @Date, @Pax, @Cost)";
            SqlCommand command = new SqlCommand(query, connection);

            // Add parameters to the command
            command.Parameters.AddWithValue("@Uid", textId.Text);
            command.Parameters.AddWithValue("@Fname", fName.Text);
            command.Parameters.AddWithValue("@Address", address.Text);
            command.Parameters.AddWithValue("@Mobile", mobile.Text);
            command.Parameters.AddWithValue("@Date", dateTimePicker.Text);
            command.Parameters.AddWithValue("@Pax", noOfPax.Text);
            command.Parameters.AddWithValue("@Cost", tcost.Text);
             
            int rowsAffected = command.ExecuteNonQuery();

            textId.Text = string.Empty;
            fName.Text = string.Empty;
            address.Text = string.Empty;
            mobile.Text = string.Empty;
            dateTimePicker.Text = string.Empty;
            noOfPax.Text = string.Empty;

        }
    }
}
