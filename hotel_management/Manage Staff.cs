using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace hotel_management
{
    public partial class Manage_Staff : Form
    {
        public AdminMainMenu AdminMainMenu { get; private set; }
        public View_All_Staff View_All_Staff { get; private set; }

        SqlConnection connection;
        public Manage_Staff(SqlConnection connection)
        {
            InitializeComponent();
            DropDownLoad();
            this.connection = connection;
        }

        private void DropDownLoad()
        {
            List<string> GenderItems = new List<string>
            {
                "Male",
                "Female"
            };

            List<string> DepartmentItems = new List<string>
            {
                "Maintenance",
                "Kitchen",
                "Housekeeping",
                "Banquets"
            };

            genderList.DataSource = GenderItems;
            departmentList.DataSource = DepartmentItems;
        }

        private void viewAllStaff_Click(object sender, EventArgs e)
        {
            View_All_Staff = new View_All_Staff(connection);
            this.Hide();
            View_All_Staff.Show();
        }

        private void Manage_Staff_Load(object sender, EventArgs e)
        {

        }

        private void cancle_Click(object sender, EventArgs e)
        {
            AdminMainMenu = new AdminMainMenu(connection);
            this.Hide();
            AdminMainMenu.Show();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            sId.Text = string.Empty;
            name.Text = string.Empty;
            genderList.Text = string.Empty;
            departmentList.Text = string.Empty;
            address.Text = string.Empty;
            number.Text = string.Empty;
            email.Text = string.Empty;
            samount.Text = string.Empty;
        }

        private void departmentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            String dep = departmentList.SelectedItem.ToString();
            if (dep== "Maintenance")
            {
                samount.Text = "Rs.45000";
            }else if (dep == "Kitchen")
            {
                samount.Text = "Rs.50000";
            }
            else if (dep == "Housekeeping")
            {
                samount.Text = "Rs.35000";
            }
            else if (dep == "Banquets")
            {
                samount.Text = "Rs.60000";
            }
        }

        private void create_Click(object sender, EventArgs e)
        {
            // SQL query with parameters
            string query = "INSERT INTO Manage_Staff (msid, name, gender, department, address, contactNumber, emailAddress, salary) VALUES (@Msid, @Name, @Gender, @Department, @Address, @ContactNumber, @EmailAddress, @Salary)";
            SqlCommand command = new SqlCommand(query, connection);


            // Add parameters to the command
            command.Parameters.AddWithValue("@Msid", sId.Text);
            command.Parameters.AddWithValue("@Name", name.Text);
            command.Parameters.AddWithValue("@Gender", genderList.Text);
            command.Parameters.AddWithValue("@Department", departmentList.Text);
            command.Parameters.AddWithValue("@Address", address.Text);
            command.Parameters.AddWithValue("@ContactNumber", number.Text);
            command.Parameters.AddWithValue("@EmailAddress", email.Text);
            command.Parameters.AddWithValue("@Salary", samount.Text);

            int rowsAffected = command.ExecuteNonQuery();

            sId.Text = string.Empty;
            name.Text = string.Empty;
            genderList.Text = string.Empty;
            departmentList.Text = string.Empty;
            address.Text = string.Empty;
            number.Text = string.Empty;
            email.Text = string.Empty;
            samount.Text = string.Empty;
        }
    }
}
