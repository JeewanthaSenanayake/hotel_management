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
    public partial class View_All_Staff : Form
    {
        SqlConnection connection;
        private string samount = "";
        private string editedData ="";
        public View_All_Staff(SqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
            table_data();
            drop_down_data();
            departmentList.Visible = false;


        }

        public Manage_Staff Manage_Staff { get; private set; }

        private void Back_Click(object sender, EventArgs e)
        {
            Manage_Staff = new Manage_Staff(connection);
            this.Hide();
            Manage_Staff.Show();

        }
        private void drop_down_data()
        {
            List<string> ColumnItems = new List<string>
            {
                "Name",
                "Gender",
                "Department",
                "Address",
                "Contact number",
                "Email address"
            };
            List<string> DepartmentItems = new List<string>
            {
                "Maintenance",
                "Kitchen",
                "Housekeeping",
                "Banquets"
            };

            departmentList.DataSource = DepartmentItems;

            column_name.DataSource = ColumnItems;

        }
        private void table_data()
        {
            // Create columns
            dataGridViewStf.Columns.Add("Column1", "Id");
            dataGridViewStf.Columns.Add("Column2", "Name");
            dataGridViewStf.Columns.Add("Column3", "Gender");
            dataGridViewStf.Columns.Add("Column3", "Department");
            dataGridViewStf.Columns.Add("Column4", "Address");
            dataGridViewStf.Columns.Add("Column5", "Contact number");
            dataGridViewStf.Columns.Add("Column6", "Email address");
            dataGridViewStf.Columns.Add("Column7", "Salary");


            string query = "SELECT * FROM Manage_Staff";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

                dataGridViewStf.Rows.Add(reader.GetString(1).ToString(), reader.GetString(2).ToString(), reader.GetString(3).ToString(), reader.GetString(4).ToString(), reader.GetString(5).ToString(), reader.GetString(6).ToString(), reader.GetString(7).ToString(), reader.GetString(8).ToString());

            }
            reader.Close();

        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Manage_Staff WHERE msid = '" + delete.Text + "'";
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            dataGridViewStf.Columns.Clear();
            dataGridViewStf.Rows.Clear();
            delete.Text = string.Empty;
            table_data();
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            if (editedData!="")
            {
                string colName = "";
                if (column_name.Text == "Name")
                {
                    colName = "name";
                }
                else if (column_name.Text == "Gender")
                {
                    colName = "gender";
                }
                else if (column_name.Text == "Department")
                {
                    colName = "department";
                }
                else if (column_name.Text == "Address")
                {
                    colName = "address";
                }
                else if (column_name.Text == "Contact number")
                {
                    colName = "contactNumber";
                }
                else if (column_name.Text == "Email address")
                {
                    colName = "emailAddress";
                }

                string query;
                if (value.Visible)
                {
                    query = "UPDATE Manage_Staff SET " + colName + "='" + value.Text + "' WHERE msid='" + edit.Text + "'";
                }
                else
                {
                    query = "UPDATE Manage_Staff SET " + colName + "='" + departmentList.Text+ "' , salary = '"+ samount + "' WHERE msid='" + edit.Text + "'";
                }

                
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                dataGridViewStf.Columns.Clear();
                dataGridViewStf.Rows.Clear();
                delete.Text = string.Empty;
                edit.Text = string.Empty;
                column_name.Text = string.Empty;
                value.Text = string.Empty;
                table_data();


            }
        }

        private void column_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(column_name.Text== "Department")
            {
                value.Visible=false;
                departmentList.Visible=true;
                String dep = departmentList.SelectedItem.ToString();
                
                if (dep == "Maintenance")
                {
                    samount = "Rs.45000";
                }
                else if (dep == "Kitchen")
                {
                    samount = "Rs.50000";
                }
                else if (dep == "Housekeeping")
                {
                    samount = "Rs.35000";
                }
                else if (dep == "Banquets")
                {
                    samount = "Rs.60000";
                }
            }
            else
            {
                value.Visible=true;
                departmentList.Visible = false;
                
            }
        }

        private void value_TextChanged(object sender, EventArgs e)
        {
            editedData = value.Text;
        }

        private void departmentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            editedData = departmentList.Text;
        }
    }
}
