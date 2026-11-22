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

namespace HRManagementSystem.HRManager
{
    public partial class HRManagerProfile : Form
    {
        private string email;
        private string password;
        private string radioButtonValue;
        public HRManagerProfile()
        {
            InitializeComponent();
        }

      public HRManagerProfile(string email, string password, string radioButtonValue)
        {
            this.email = email;
            this.password = password;
            this.radioButtonValue = radioButtonValue;
            InitializeComponent();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            var id = idBox.Text;

            if (nameBox.Text == "" || emailBox.Text == "" || passwordBox.Text == "" || genderBox.Text == "" || phoneBox.Text=="")
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

                    string query = "UPDATE HRManager SET hr_name='" + name +
                                   "', hr_email='" + email +
                                   "', hr_password='" + password +
                                   "', hr_gender='" + gender +
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

        private void backButton_Click(object sender, EventArgs e)
        {
            if(radioButtonValue == "HR Manager")
            {
                new HRManagerDashboard(email, password, radioButtonValue).Show();
                this.Hide();
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            string hrName = "";
            string hrEmail = email;
            string hrPassword = "";
            string hrPhone = "";
            string hrGender = "";
            string hrId = "";

            using (SqlConnection connection = new SqlConnection(
                "Data Source=WIN-K77493C2S8N\\SQLEXPRESS01;Initial Catalog=mainProject;Integrated Security=True;TrustServerCertificate=True"))
            {
                connection.Open();

                string query = "SELECT id, hr_name, hr_email, hr_password, hr_phone, hr_gender " +
                               "FROM HRManager WHERE hr_email = '" + email + "'";

                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) 
                {
                    hrName = reader["hr_name"].ToString();
                    hrEmail = reader["hr_email"].ToString();
                    hrPassword = reader["hr_password"].ToString();
                    hrPhone = reader["hr_phone"].ToString();
                    hrGender = reader["hr_gender"].ToString();
                    hrId = reader["id"].ToString();

                    idBox.Text = hrId;
                    nameBox.Text = hrName;
                    emailBox.Text = hrEmail;
                    passwordBox.Text = hrPassword;
                    phoneBox.Text = hrPhone;
                    genderBox.Text = hrGender;



                }

                reader.Close();
        }
}
    }
}
