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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HRManagementSystem.EMPLOYEE
{
    public partial class employeeDashboard : Form
    {
        private string email;
        private string password;
        private string radioButtonValue;
        public employeeDashboard()
        {
            InitializeComponent();
        }
        public employeeDashboard(string email, string password, string radioButtonValue)
        {
            this.email = email;
            this.password = password;
            this.radioButtonValue = radioButtonValue;
            InitializeComponent();
        }

        private void employeeDashboard_Load(object sender, EventArgs e)
        {
            var employeeName = "";
            using (SqlConnection connection = new SqlConnection(
                "Data Source=WIN-K77493C2S8N\\SQLEXPRESS01;Initial Catalog=mainProject;Integrated Security=True;TrustServerCertificate=True"))
            {
                connection.Open();

                string query = "SELECT id, name, email, password, designation, department, joining_date " +
               "FROM employee WHERE email = '" + email + "'";


                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    employeeName = reader["name"].ToString();
                    var employeeEmail = reader["email"].ToString();
                    var employeePassword = reader["password"].ToString();
                    var employeeDesignation = reader["designation"].ToString();
                    var employeeDepartment = reader["department"].ToString();
                    var employeeJoiningDate = reader["joining_date"].ToString();
                    var Id = reader["id"].ToString();

                    label2.Text = employeeName;
                    idLabel.Text = Id;
                    textBox1.Text = employeeName;
                    textBox2.Text = employeeDepartment;
                    textBox3.Text = employeeDesignation;
                    textBox4.Text = employeeEmail;
                    textBox5.Text = employeePassword;
                    dateLabel.Text = employeeJoiningDate;
                    connection.Close();
                }
            }
            using (SqlConnection connection = new SqlConnection(
               "Data Source=WIN-K77493C2S8N\\SQLEXPRESS01;Initial Catalog=mainProject;Integrated Security=True;TrustServerCertificate=True"))
            {
                connection.Open();

                string query = "SELECT project_name , due_date " +
               "FROM employeeProject WHERE Employee_Name = '" + employeeName + "'";


                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    var propject_name = reader["project_name"].ToString();
                    var deadline = reader["due_date"].ToString();
                   
             
                        label11.Text = propject_name;
                        dateBox.Text = deadline;
                    
                        connection.Close();

                }
                else
                {
                    label11.Text = "No project assigned";
                    dateBox.Text = "N/A";
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //update
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {

                MessageBox.Show("Please Fill All The Fields");
            }
            else if(textBox5.Text.Length < 8)
            {
                MessageBox.Show("Password Must be 8 characters long"); return;
            }
            else
            {
                var employeeName = textBox1.Text;
                var employeeEmail = textBox4.Text;
                var employeePassword = textBox5.Text;

                SqlConnection connection = new SqlConnection("Data Source=WIN-K77493C2S8N\\SQLEXPRESS01;Initial Catalog=mainProject;Integrated Security=True;TrustServerCertificate=True");
                connection.Open();

                string q = "UPDATE employee SET name='" + employeeName +
                           "', email='" + employeeEmail +
                           "', password='" + employeePassword +
                           "' WHERE email='" + employeeEmail + "'";

                SqlCommand cmd = new SqlCommand(q, connection);

                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("UPDATED");
                textBox1.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //update table employeeProject
            SqlConnection connection = new SqlConnection("Data Source=WIN-K77493C2S8N\\SQLEXPRESS01;Initial Catalog=mainProject;Integrated Security=True;TrustServerCertificate=True");
            connection.Open();

            var status = "assigned";
            if (radioButton1.Checked)
            {
                status = "Done";
            }
            else if (radioButton2.Checked) status = "Ongoing";
            else if (radioButton3.Checked) status = "Incomplete";
            else
            {
                MessageBox.Show("Please select a status");
                return;
            }

                string q = "UPDATE employeeProject SET status ='" + status+
                           "' WHERE Employee_Name='" + textBox1.Text +"'";
            SqlCommand cmd = new SqlCommand(q, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Status Updated to "+ status);

        }
    }

}