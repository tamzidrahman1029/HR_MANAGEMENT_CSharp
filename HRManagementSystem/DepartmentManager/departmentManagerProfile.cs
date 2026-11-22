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

namespace HRManagementSystem.DepartmentManager
{
    public partial class departmentManagerProfile : Form
    {
        private string email;
        private string password;
        private string radioButtonValue;
        public departmentManagerProfile()
        {
            InitializeComponent();
        }
        public departmentManagerProfile(string email,string password,string radioButtonValue)
        {
            this.email = email;
            this.password = password;
            this.radioButtonValue = radioButtonValue;
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if(radioButtonValue == "Dept Manager")
            {
                new departmentManagerDashboard().Show();
                this.Hide();
            }
            else
            {
                new Form1().Show();
                this.Hide();
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            var id = idBox.Text;

            if (nameBox.Text == "" || emailBox.Text == "" || passwordBox.Text == "" || genderBox.Text == "" || phoneBox.Text == "")
            {

                MessageBox.Show("Please Fill All The Fields");
            }

            else
            {
                try
                {
                    var name = nameBox.Text;
                    var email = emailBox.Text;
                    var password = passwordBox.Text;
                    var phone = phoneBox.Text;
                    var gender = genderBox.Text;
                    var deptID = idBox.Text;


                    SqlConnection connection = new SqlConnection("Data Source=WIN-K77493C2S8N\\SQLEXPRESS01;Initial Catalog=mainProject;Integrated Security=True;TrustServerCertificate=True");
                    connection.Open();

                    string query = "UPDATE departmentManager SET dm_name='" + name +
                                   "', dm_email='" + email +
                                   "', dm_password='" + password +
                                   "', dm_phone='" + phone +
                                   "', dm_gender='" + gender +
                                   "' WHERE id='" + deptID + "'";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("UPDATED");
                    nameBox.Text = "";
                    passwordBox.Text = "";
                    phoneBox.Text = "";
                    genderBox.Text = "";
                    idBox.Text = "";
                    emailBox.Text = "";
                    return;
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Error: " + exception.Message);
                }
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            string dmName = "";
            string dmEmail = email;
            string dmPassword = "";
            string dmPhone = "";
            string dmGender = "";
            string dmId = "";

            using (SqlConnection connection = new SqlConnection(
                "Data Source=WIN-K77493C2S8N\\SQLEXPRESS01;Initial Catalog=mainProject;Integrated Security=True;TrustServerCertificate=True"))
            {
                connection.Open();

                string query = "SELECT id, dm_name, dm_email, dm_password, dm_phone, dm_gender " +
                               "FROM departmentManager WHERE dm_email = '" + email + "'";

                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    dmName = reader["dm_name"].ToString();
                    dmEmail = reader["dm_email"].ToString();
                    dmPassword = reader["dm_password"].ToString();
                    dmPhone = reader["dm_phone"].ToString();
                    dmGender = reader["dm_gender"].ToString();
                    dmId = reader["id"].ToString();

                    idBox.Text = dmId;
                    nameBox.Text = dmName;
                    emailBox.Text = dmEmail;
                    passwordBox.Text = dmPassword;
                    phoneBox.Text = dmPhone;
                    genderBox.Text = dmGender;



                }

                reader.Close();
            }
        }
    }
}
