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

namespace HRManagementSystem.ProjectManager
{
    public partial class projectManagerProfile : Form
    {
        private string email;
        private string password;
        private string radioButtonValue;
        public projectManagerProfile()
        {
            InitializeComponent();
        }
        public projectManagerProfile(string email, string password, string radioButtonValue)
        {
            this.email = email;
            this.password = password;
            this.radioButtonValue = radioButtonValue;
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if(radioButtonValue == "Project Manager")
            {
                new projectManagerDashboard(email, password, radioButtonValue).Show();
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
                    var hrID = idBox.Text;


                    SqlConnection connection = new SqlConnection("Data Source=WIN-K77493C2S8N\\SQLEXPRESS01;Initial Catalog=mainProject;Integrated Security=True;TrustServerCertificate=True");
                    connection.Open();

                    string query = "UPDATE projectManager SET pm_name='" + name +
                                   "', pm_email='" + email +
                                   "', pm_password='" + password +
                                   "', pm_gender='" + gender +
                                   "', pm_phone='" + phone +
                                   "' WHERE id='" + hrID + "'";

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
            string pmName = "";
            string pmEmail = email;
            string pmPassword = "";
            string pmPhone = "";
            string pmGender = "";
            string pmId = "";

            using (SqlConnection connection = new SqlConnection(
                "Data Source=WIN-K77493C2S8N\\SQLEXPRESS01;Initial Catalog=mainProject;Integrated Security=True;TrustServerCertificate=True"))
            {
                connection.Open();

                string query = "SELECT id, pm_name, pm_email, pm_password, pm_phone, pm_gender " +
                               "FROM projectManager WHERE pm_email = '" + email + "'";

                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    pmName = reader["pm_name"].ToString();
                    pmEmail = reader["pm_email"].ToString();
                    pmPassword = reader["pm_password"].ToString();
                    pmPhone = reader["pm_phone"].ToString();
                    pmGender = reader["pm_gender"].ToString();
                    pmId = reader["id"].ToString();

                    idBox.Text = pmId;
                    nameBox.Text = pmName;
                    emailBox.Text = pmEmail;
                    passwordBox.Text = pmPassword;
                    phoneBox.Text = pmPhone;
                    genderBox.Text = pmGender;



                }

                reader.Close();
            }
        }
    }
}
