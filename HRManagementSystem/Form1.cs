using HRManagementSystem.HR_MANAGER;
using HRManagementSystem.ADMIN;
using HRManagementSystem.Employee;
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
using Employee_management;
using HRManagementSystem.HRManager;
using HRManagementSystem.EMPLOYEE;
using HRManagementSystem.DepartmentManager;
using HRManagementSystem.ProjectManager;

namespace HRManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string email = emailBox.Text;
            string password = passwordBox.Text;
           // MessageBox.Show(email + " " + password);

            if (email =="" || password =="")
            {
                MessageBox.Show("Please enter both email and password");
                emailBox.Text = "";
                 passwordBox.Text = "";
                return;
            }
            else if (!email.EndsWith("@gmail.com"))
            {
                MessageBox.Show("Invalid Email");
                return;
            }
            else if (hrManagerRB.Checked)
            {
                string radioButtonValue = hrManagerRB.Text;
                //hrmanager database verification
                SqlConnection connection = new SqlConnection("Data Source=WIN-K77493C2S8N\\SQLEXPRESS01;Initial Catalog=mainProject;Integrated Security=True;TrustServerCertificate=True");
                connection.Open();
                string query = "select * from HRManager where hr_email ='" + emailBox.Text + "' and hr_password='" + passwordBox.Text + "'";
                SqlCommand cmd = new SqlCommand(query, connection);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    //new addEmployee(emailBox.Text, passwordBox.Text).Show();
                    new HRManagerDashboard(emailBox.Text, passwordBox.Text, radioButtonValue).Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid email or password");
                    emailBox.Text = "";
                    passwordBox.Text = "";
                }
                connection.Close();
            }
            else if (adminRB.Checked)
            {
                string radioButtonValue = adminRB.Text;

                SqlConnection connection = new SqlConnection("Data Source=WIN-K77493C2S8N\\SQLEXPRESS01;Initial Catalog=mainProject;Integrated Security=True;TrustServerCertificate=True");
                connection.Open();
                string query = "select * from admin where email ='" + emailBox.Text + "' and password='" + passwordBox.Text + "'";
                SqlCommand cmd = new SqlCommand(query, connection);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    HR_MANAGER.Employee adm = new HR_MANAGER.Employee(emailBox.Text, passwordBox.Text, radioButtonValue);
                    adm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid email or password");
                    emailBox.Text = "";
                    passwordBox.Text = "";
                }
                connection.Close();
            }
            else if (deptManagerRB.Checked)
            {
                string radioButtonValue = deptManagerRB.Text;

                //department manager database verification
                SqlConnection connection = new SqlConnection("Data Source=WIN-K77493C2S8N\\SQLEXPRESS01;Initial Catalog=mainProject;Integrated Security=True;TrustServerCertificate=True");
                connection.Open();
                string query = "select * from departmentManager where dm_email ='" + emailBox.Text + "' and dm_password='" + passwordBox.Text + "'";
                SqlCommand cmd = new SqlCommand(query, connection);
                MessageBox.Show(emailBox.Text + " " + passwordBox.Text);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    new departmentManagerDashboard(email,password,radioButtonValue).Show();//// tochange
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid email or password");
                    emailBox.Text = "";
                    passwordBox.Text = "";
                }
                connection.Close();
            }
            else if (employeeRB.Checked)
            {
                //HR manager database verification

                string radioButtonValue = employeeRB.Text;

                SqlConnection connection = new SqlConnection("Data Source=WIN-K77493C2S8N\\SQLEXPRESS01;Initial Catalog=mainProject;Integrated Security=True;TrustServerCertificate=True");
                connection.Open();
                string query = "select * from employee where email ='" + emailBox.Text + "' and password='" + passwordBox.Text + "'";
                SqlCommand cmd = new SqlCommand(query, connection);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    new employeeDashboard(email,password,radioButtonValue).Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid email or password");
                    emailBox.Text = "";
                    passwordBox.Text = "";
                }
                connection.Close();

            }
            else if (projectManagerRB.Checked)
            {
                //project manager database verification
                string radioButtonValue = projectManagerRB.Text;
                MessageBox.Show(radioButtonValue);

                SqlConnection connection = new SqlConnection("Data Source=WIN-K77493C2S8N\\SQLEXPRESS01;Initial Catalog=mainProject;Integrated Security=True;TrustServerCertificate=True");
                connection.Open();
                string query = "select * from projectManager where pm_email ='" + emailBox.Text + "' and pm_password='" + passwordBox.Text + "'";
                SqlCommand cmd = new SqlCommand(query, connection);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    new projectManagerDashboard(email,password,radioButtonValue).Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid email or password");
                    emailBox.Text = "";
                    passwordBox.Text = "";
                }
                connection.Close();


            }
            else
            {
                MessageBox.Show("Please select a role");
            }
        }

      
    }
}
