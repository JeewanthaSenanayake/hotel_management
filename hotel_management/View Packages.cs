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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace hotel_management
{
    public partial class View_Packages : Form
    {
        SqlConnection connection;

        public CustomerMainMenu CustomerMainMenu { get; private set; }

        public View_Packages(SqlConnection connection )
        {
            this.connection = connection;
            InitializeComponent();
            table_data();
        }

        private void table_data()
        {
            // Create columns
            dataGridViewPkg.Columns.Add("Column1", "Id");
            dataGridViewPkg.Columns.Add("Column2", "Name");
            dataGridViewPkg.Columns.Add("Column3", "Cost per person");
            dataGridViewPkg.Columns.Add("Column3", "Description");
            dataGridViewPkg.Columns.Add("Column3", "Complementary");

            string query = "SELECT * FROM Manage_Packages";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                
                // Add rows
                dataGridViewPkg.Rows.Add(reader.GetString(1).ToString(), reader.GetString(2).ToString(), reader.GetString(3).ToString(), reader.GetString(4).ToString(), reader.GetString(5).ToString());

            }
            reader.Close(); 

        }

        private void dataGridViewPkg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            if (search.Text == "")
            {
                dataGridViewPkg.Rows.Clear();
                dataGridViewPkg.Columns.Clear();
                table_data();

            }
            else
            {

            
            string query = "SELECT * FROM Manage_Packages WHERE name ='"+ search.Text+ "'";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            dataGridViewPkg.Rows.Clear();
            while (reader.Read())
            {

                // Add rows
                dataGridViewPkg.Rows.Add(reader.GetString(1).ToString(), reader.GetString(2).ToString(), reader.GetString(3).ToString(), reader.GetString(4).ToString(), reader.GetString(5).ToString());

            }

            reader.Close();
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            CustomerMainMenu = new CustomerMainMenu(connection);
            this.Hide();
            CustomerMainMenu.Show();
        }
    }
}
