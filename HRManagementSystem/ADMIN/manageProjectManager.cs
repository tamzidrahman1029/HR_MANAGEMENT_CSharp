using HRManagementSystem.HR_MANAGER;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HRManagementSystem.ADMIN
{
    public partial class manageProjectManager : Form
    {
        private string email;
        private string password;
        private string radioButtonValue;
        public manageProjectManager()
        {
            InitializeComponent();
        }
        public manageProjectManager(string email, string password,string radioButtonValue)
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

        private void backButton_Click(object sender, EventArgs e)
        {
          new HR_MANAGER.Employee(email, password, radioButtonValue).Show();
            this.Hide();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            clearAll();

            try
            {
                SqlConnection connection = new SqlConnection("Data Source=WIN-K77493C2S8N\\SQLEXPRESS01;Initial Catalog=mainProject;Integrated Security=True;TrustServerCertificate=True");
                connection.Open();

                string query = "select * from projectManager";

                SqlDataAdapter sda = new SqlDataAdapter(query, connection);

                DataSet dataset = new DataSet();

                sda.Fill(dataset);

                DataTable dataTable = dataset.Tables[0];

                PMDGV.DataSource = dataTable;
                PMDGV.Refresh();
                PMDGV.ClearSelection();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var id = idBox.Text;
            var phoneNumber = phoneBox.Text.Trim();

            //if (!Regex.IsMatch(phoneNumber, @"^01[3-9]\d{8}$"))
            //{
            //    MessageBox.Show("Please enter a valid 11-digit mobile number");
            //    return;
            //}

            if (id != "AUTO GENERATED")
            {
                MessageBox.Show("Employee Already Exists"); return;
            }
            if (passwordBox.Text.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long");
                return;
            }

            else if (nameBox.Text == "" || salaryBox.Text==""|| emailBox.Text == "" || passwordBox.Text == "" || phoneBox.Text ==""|| maleRB.Checked == false && femaleRB.Checked == false || dateTimePicker1.Value == null)
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

                    // MessageBox.Show(name,email,password,designation,department,gender,salary,joining_Date);


                    SqlConnection connection = new SqlConnection("Data Source=WIN-K77493C2S8N\\SQLEXPRESS01;Initial Catalog=mainProject;Integrated Security=True;TrustServerCertificate=True");
                    connection.Open();

                    string q = "INSERT INTO projectManager " +
             "(pm_name, pm_email, pm_password,pm_phone,pm_gender,join_date,salary) VALUES ('"
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

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var id = idBox.Text;
            if (id != "AUTO GENERATED")
            {
                string query = "DELETE FROM projectManager WHERE id='" + id + "'";
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
                MessageBox.Show("Please Select A Project Manager To Remove");
            }
        }

        private void PMDGV_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = PMDGV.Rows[e.RowIndex].Cells[0].Value.ToString();
            idBox.Text = id;

            var name = PMDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            nameBox.Text = name;

            var email = PMDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
            emailBox.Text = email;

            var password = PMDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
            passwordBox.Text = password;
            var phone = PMDGV.Rows[e.RowIndex].Cells[4].Value.ToString();
            phoneBox.Text = phone;

            var gender = PMDGV.Rows[e.RowIndex].Cells[5].Value.ToString();
            if (gender == "Male")
            {
                maleRB.Checked = true;
            }
            else
            {
                femaleRB.Checked = false;
            }

            var joining_Date = PMDGV.Rows[e.RowIndex].Cells[6].Value.ToString();
            dateTimePicker1.Text = joining_Date;
            var salary = PMDGV.Rows[e.RowIndex].Cells[7].Value.ToString();
            salaryBox.Text = salary;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            var id = idBox.Text;

            if (passwordBox.Text.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long");
                return;
            }


            if (nameBox.Text == "" ||salaryBox.Text==""|| emailBox.Text == "" || passwordBox.Text == "" || phoneBox.Text == null || maleRB.Checked == false && femaleRB.Checked == false || dateTimePicker1.Value == null)
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

                    string query = "UPDATE projectManager SET " +
                                   "pm_name='" + name + "', " +
                                   "pm_email='" + email + "', " +
                                   "pm_password='" + password + "', " +
                                   "pm_phone='" + phone + "', " +
                                   "pm_gender='" + gender + "', " +
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
    }
}
