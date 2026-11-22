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

namespace HRManagementSystem.ADMIN
{
    public partial class adminProfile : Form
    {
        private string email;
        private string password;
        private string radioButtonValue;

        public adminProfile()
        {
            InitializeComponent();
        }
        public adminProfile(string email,string password, string radioButtonValue)
        {
            this.email = email;
            this.password = password;
            this.radioButtonValue = radioButtonValue;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //update er kaj
            if (nameBox.Text == "" || emailBox.Text == "" || passwordBox.Text == "")
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
                    var id = idBox.Text;


                    SqlConnection connection = new SqlConnection("Data Source=WIN-K77493C2S8N\\SQLEXPRESS01;Initial Catalog=mainProject;Integrated Security=True;TrustServerCertificate=True");
                    connection.Open();

                    string query = "UPDATE admin SET name='" + name +
                                   "',email='" + email +
                                   "', password='" + password +
                                   "' WHERE id='" + id + "'";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("UPDATED");
                    nameBox.Text = "";
                    passwordBox.Text = "";
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

        private void button2_Click(object sender, EventArgs e)
        {
            // database theke data anbo tarpor show
            string adminName = "";
            string adminEmail = email;
            string adminPassword = "";
            string adminID = "";

            using (SqlConnection connection = new SqlConnection(
                "Data Source=WIN-K77493C2S8N\\SQLEXPRESS01;Initial Catalog=mainProject;Integrated Security=True;TrustServerCertificate=True"))
            {
                connection.Open();

                string query = "SELECT id, name, email, password "+
                               " FROM admin WHERE email = '" + email + "'";

                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    adminID = reader["id"].ToString();
                    adminName = reader["name"].ToString();
                    adminEmail = reader["email"].ToString();
                    adminPassword = reader["password"].ToString();

                    idBox.Text = adminID;
                    nameBox.Text = adminName;
                    emailBox.Text = adminEmail;
                    passwordBox.Text = adminPassword;

                }

                reader.Close();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            HR_MANAGER.Employee adm = new HR_MANAGER.Employee(emailBox.Text, passwordBox.Text, radioButtonValue);
            adm.Show();
            this.Hide();
        }

        private void adminProfile_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(
              "Data Source=WIN-K77493C2S8N\\SQLEXPRESS01;Initial Catalog=mainProject;Integrated Security=True;TrustServerCertificate=True"))
            {
                connection.Open();

                string query = "SELECT name" +
                               " FROM admin WHERE email = '" + email + "'";

                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    var name = reader["name"].ToString();
                    label5.Text = name;

                }

                reader.Close();
            }
        }
    }
}
