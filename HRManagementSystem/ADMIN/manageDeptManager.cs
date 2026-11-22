using HRManagementSystem.HR_MANAGER;
using HRManagementSystem.ADMIN;
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
    public partial class manageDeptManager : Form
    {
        private string email;
        private string password;
        private string radioButtonValue;
        public manageDeptManager()
        {
            InitializeComponent();
        }

        public manageDeptManager(string email, string password,string radioButtonValue)
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
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var id = idBox.Text;

            if(passwordBox.Text.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long");
                return;
            }

            if (id != "AUTO GENERATED")
            {
                MessageBox.Show("Manager Already Exists");
            }
            else if (nameBox.Text == "" ||salaryBox.Text==""|| emailBox.Text == "" || passwordBox.Text == "" || phoneBox.Text == "" || maleRB.Checked == false && femaleRB.Checked == false)
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

                    string q = "INSERT INTO departmentManager " +
             "(dm_name, dm_email, dm_password,dm_phone,dm_gender,join_date,salary) VALUES ('"
             + name + "','"
             + email + "','"
             + password + "','"
              + phone + "','"
             + gender + "','"
              + joining_Date + "','"
             + salary+ "')";



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
                string query = "DELETE FROM departmentManager WHERE id='" + id + "'";
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
                MessageBox.Show("Please Select A Department Manager To Remove");
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            clearAll();

            try
            {
                SqlConnection connection = new SqlConnection("Data Source=WIN-K77493C2S8N\\SQLEXPRESS01;Initial Catalog=mainProject;Integrated Security=True;TrustServerCertificate=True");
                connection.Open();

                string query = "select * from departmentManager";

                SqlDataAdapter sda = new SqlDataAdapter(query, connection);

                DataSet dataset = new DataSet();

                sda.Fill(dataset);

                DataTable dataTable = dataset.Tables[0];

                DMDGV.DataSource = dataTable;
                DMDGV.Refresh();
                DMDGV.ClearSelection();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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


            if (nameBox.Text == "" || salaryBox.Text == "" ||emailBox.Text == "" || passwordBox.Text == "" || phoneBox.Text == null || maleRB.Checked == false && femaleRB.Checked == false || dateTimePicker1.Value == null)
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

                    //string query = "UPDATE departmentManager SET dm_name='" + name + "', dm_email='" + email + "', dm_password='" + password + "',dm_phone ='" + phone + "', dm_gender='" + gender + "', join_date='" + joining_Date + "' WHERE id='" + id + "'";

                    string query = "UPDATE departmentManager SET " +
               "dm_name='" + name + "', " +
               "dm_email='" + email + "', " +
               "dm_password='" + password + "', " +
               "dm_phone='" + phone + "', " +
               "dm_gender='" + gender + "', " +
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

        private void DMDGV_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = DMDGV.Rows[e.RowIndex].Cells[0].Value.ToString();
            idBox.Text = id;

            var name = DMDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            nameBox.Text = name;

            var email = DMDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
            emailBox.Text = email;

            var password = DMDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
            passwordBox.Text = password;
            var phone = DMDGV.Rows[e.RowIndex].Cells[4].Value.ToString();
            phoneBox.Text = phone;

            var gender = DMDGV.Rows[e.RowIndex].Cells[5].Value.ToString();
            if (gender == "Male")
            {
                maleRB.Checked = true;
            }
            else
            {
                femaleRB.Checked = false;
            }

            var joining_Date = DMDGV.Rows[e.RowIndex].Cells[6].Value.ToString();
            dateTimePicker1.Text = joining_Date.ToString();
            var salary = DMDGV.Rows[e.RowIndex].Cells[7].Value.ToString();
            salaryBox.Text = salary;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clearAll();
        }
    }
    }

