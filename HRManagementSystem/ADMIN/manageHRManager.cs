using HRManagementSystem.HR_MANAGER;
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
    public partial class manageHRManager : Form
    {
        private string email;
        private string password;
        private string radioButtonValue;
        public manageHRManager()
        {
            InitializeComponent();
        }
        public manageHRManager(string email, string password, string radioButtonValue)
        {
            this.email = email;
            this.password = password;
            this.radioButtonValue = radioButtonValue;
            InitializeComponent();
        }
        public void clearAll()
        {
            idBox.Text = "AUTO GENERATED";
            nameBox.Text = null;
            emailBox.Text = null;
            phoneBox.Text = null;
            passwordBox.Text = null;
            maleRB.Checked = false;
            femaleRB.Checked = false;
            salaryBox.Text = "";
            dateTimePicker1.Value = DateTime.Now;
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            clearAll();
            try
            {
                SqlConnection connection = new SqlConnection("Data Source=WIN-K77493C2S8N\\SQLEXPRESS01;Initial Catalog=mainProject;Integrated Security=True;TrustServerCertificate=True");
                connection.Open();

                string query = "select * from HRManager";

                SqlDataAdapter sda = new SqlDataAdapter(query, connection);

                DataSet dataset = new DataSet();

                sda.Fill(dataset);

                DataTable dataTable = dataset.Tables[0];

                HRMDGV.DataSource = dataTable;
                HRMDGV.Refresh();
                HRMDGV.ClearSelection();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            new HR_MANAGER.Employee(email, password, radioButtonValue).Show();
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var id = idBox.Text;
            if (passwordBox.Text.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long");
                return;
            }

            if (id != "AUTO GENERATED")
            {
                MessageBox.Show("Manager Already Exists");
            }
            else if (nameBox.Text == "" || salaryBox.Text==""|| emailBox.Text == "" || passwordBox.Text == "" || phoneBox.Text == "" || maleRB.Checked == false && femaleRB.Checked == false || dateTimePicker1.Value == null)
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
                    var salary = salaryBox.Text;
                    string gender;
                    if (maleRB.Checked == true)
                    {
                        gender = "Male";
                    }
                    else
                    {
                        gender = "Female";
                    }

                    string joining_Date = dateTimePicker1.Value.ToString();

                    SqlConnection connection = new SqlConnection("Data Source=WIN-K77493C2S8N\\SQLEXPRESS01;Initial Catalog=mainProject;Integrated Security=True;TrustServerCertificate=True");
                    connection.Open();

                    string q = "INSERT INTO HRManager " +
             "(hr_name, hr_email, hr_password,hr_phone,hr_gender,join_date,salary) VALUES ('"
             + name + "','"
             + email + "','"
             + password + "','"
             + phone + "','"
             + gender + "','"
             + joining_Date + "','"
             + salary + "')";

                    SqlCommand cmd = new SqlCommand(q, connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("ADDED");
                    clearAll();
                    return;

                }
                catch (Exception exception)
                {
                    MessageBox.Show("Error: " + exception.Message);
                }
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            var id = idBox.Text;
            if (passwordBox.Text.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long");
                return;
            }


            if (nameBox.Text == "" || salaryBox.Text==""|| emailBox.Text == "" || passwordBox.Text == "" || phoneBox.Text == null || maleRB.Checked == false && femaleRB.Checked == false || dateTimePicker1.Value ==null )
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
                    var salary = salaryBox.Text;
                    string gender;
                    if (maleRB.Checked == true)
                    {
                        gender = "Male";
                    }
                    else
                    {
                        gender = "Female";
                    }
                    var joining_Date = dateTimePicker1.Value.ToString();

                    SqlConnection connection = new SqlConnection("Data Source=WIN-K77493C2S8N\\SQLEXPRESS01;Initial Catalog=mainProject;Integrated Security=True;TrustServerCertificate=True");
                    connection.Open();

                    string query = "UPDATE HRManager SET " +
                                   "hr_name='" + name + "', " +
                                   "hr_email='" + email + "', " +
                                   "hr_password='" + password + "', " +
                                   "hr_phone='" + phone + "', " +
                                   "hr_gender='" + gender + "', " +
                                   "join_date='" + joining_Date + "', " +
                                   "salary='" + salary + "' " +
                                   "WHERE id='" + id + "'";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();


                    MessageBox.Show("UPDATED");
                    clearAll();


                    return;


                }
                catch (Exception exception)
                {
                    MessageBox.Show("Error: " + exception.Message);
                }

            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var id = idBox.Text;
            if (id != "AUTO GENERATED")
            {
                string query = "DELETE FROM HRManager WHERE id='" + id + "'";
                SqlConnection connection = new SqlConnection("Data Source=WIN-K77493C2S8N\\SQLEXPRESS01;Initial Catalog=mainProject;Integrated Security=True;TrustServerCertificate=True");
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("DELETED");
                clearAll();
                return;

            }

            else
            {
                MessageBox.Show("Please Select A HR Manager To Remove");
            }
        }

        private void HRMDGV_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = HRMDGV.Rows[e.RowIndex].Cells[0].Value.ToString();
            idBox.Text = id;

            var name = HRMDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            nameBox.Text = name;

            var email = HRMDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
            emailBox.Text = email;

            var password = HRMDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
            passwordBox.Text = password;
            var phone = HRMDGV.Rows[e.RowIndex].Cells[4].Value.ToString();
            phoneBox.Text = phone;

            var gender = HRMDGV.Rows[e.RowIndex].Cells[5].Value.ToString();
            if (gender == "Male")
            {
                maleRB.Checked = true;
            }
            else
            {
                femaleRB.Checked = false;
            }

            var joining_Date = HRMDGV.Rows[e.RowIndex].Cells[6].Value.ToString();
            dateTimePicker1.Text = joining_Date;
            var salary  = HRMDGV.Rows[e.RowIndex].Cells[7].Value.ToString();
            salaryBox.Text = salary; ;

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
