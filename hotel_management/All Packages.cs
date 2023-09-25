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
    public partial class All_Packages : Form
    {
        SqlConnection connection;

        public Manage_Packages Manage_Packages { get; private set; }

        public All_Packages(SqlConnection connection)
        {
            this.connection = connection;
            InitializeComponent();
            table_data();
            drop_down_data();
        }

        private void table_data()
        {
            // Create columns
            dataGridViewPkg.Columns.Add("Column1", "Id");
            dataGridViewPkg.Columns.Add("Column2", "Name");
            dataGridViewPkg.Columns.Add("Column3", "Cost per person");
            dataGridViewPkg.Columns.Add("Column4", "Description");
            dataGridViewPkg.Columns.Add("Column5", "Complementary");
            

            string query = "SELECT * FROM Manage_Packages";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                dataGridViewPkg.Rows.Add(reader.GetString(1).ToString(), reader.GetString(2).ToString(), reader.GetString(3).ToString(), reader.GetString(4).ToString(), reader.GetString(5).ToString());
            }
            reader.Close();

        }


        private void back_Click(object sender, EventArgs e)
        {
            Manage_Packages = new Manage_Packages(connection);
            this.Hide();
            Manage_Packages.Show();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Manage_Packages WHERE mid = '"+ delete.Text+"'";
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            dataGridViewPkg.Columns.Clear();
            dataGridViewPkg.Rows.Clear();
            delete.Text=string.Empty;
            table_data();

        }

        private void drop_down_data()
        {
            List<string> ColumnItems = new List<string>
            {
                "Name",
                "Cost per person",
                "Description",
                "Complementary"
            };


            column_name.DataSource = ColumnItems;
            
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            if(edit.Text.Length > 0) 
            {
                string colName="";
                if(column_name.Text== "Name")
                {
                    colName = "name";
                } else if (column_name.Text == "Cost per person")
                {
                    colName = "costPerPerson";
                }
                else if (column_name.Text == "Description")
                {
                    colName = "description";
                }
                else if (column_name.Text == "Complementary")
                {
                    colName = "complementary";
                }


                string query = "UPDATE Manage_Packages SET " + colName + "='" + value.Text + "' WHERE mid='"+ edit.Text + "'";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                dataGridViewPkg.Columns.Clear();
                dataGridViewPkg.Rows.Clear();
                delete.Text = string.Empty;
                edit.Text = string.Empty;
                column_name.Text = string.Empty;
                value.Text = string.Empty;
                table_data();
                

            }
        }
    }
}
