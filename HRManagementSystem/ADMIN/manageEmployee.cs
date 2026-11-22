using HRManagementSystem.HR_MANAGER;
using HRManagementSystem;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using HRManagementSystem.HRManager;

namespace HRManagementSystem.Employee
{
    public partial class manageEmployee : Form
    {
        private string loginemail;
        private string loginpassword;
        private string radioButtonValue;
        public manageEmployee()
        {
            InitializeComponent();
        }

        public manageEmployee(string loginemail, string loginpassword,string radioButtonValue)
        {
            this.loginemail = loginemail;
            this.loginpassword = loginpassword;
            this.radioButtonValue = radioButtonValue;
            InitializeComponent();
        }


        public void clearAll()
        {
            idBox.Text = "AUTO GENERATED";
            nameBox.Text = null;
            emailBox.Text = null;
            passwordBox.Text = null;
            designationBox.Text = "";
            deptBox.Text = null;
            male.Checked = false;
            female.Checked = false;
            salaryBox.Text = null;
            dateTimePicker1.Value = DateTime.Now;
        }

        public void loadingDesignationBox()
        {
            SqlConnection con = new SqlConnection("Data Source=WIN-K77493C2S8N\\SQLEXPRESS01;Initial Catalog=mainProject;Integrated Security=True;TrustServerCertificate=True");
            con.Open();

            string query = "select designation_name from designation";

            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataAdapter SDA = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            SDA.Fill(dt);

            designationBox.DataSource = dt;
            designationBox.DisplayMember = "designation_name";
        }

        public void loadingDept()
        {
            SqlConnection con = new SqlConnection("Data Source=WIN-K77493C2S8N\\SQLEXPRESS01;Initial Catalog=mainProject;Integrated Security=True;TrustServerCertificate=True");
            con.Open();

            string query = "select * from department";
            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            deptBox.DataSource = dt;
            deptBox.DisplayMember = "department_name";
            
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
          loadingDesignationBox();
          loadingDept();
         clearAll();

            try
            {
                SqlConnection connection = new SqlConnection("Data Source=WIN-K77493C2S8N\\SQLEXPRESS01;Initial Catalog=mainProject;Integrated Security=True;TrustServerCertificate=True");
                connection.Open();

                string query = "select * from employee";

                SqlDataAdapter sda = new SqlDataAdapter(query, connection);

                DataSet dataset = new DataSet();

                sda.Fill(dataset);

                DataTable dataTable = dataset.Tables[0];

                employeeDGV.DataSource = dataTable;
                employeeDGV.Refresh();
                employeeDGV.ClearSelection();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void employeeDGV_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = employeeDGV.Rows[e.RowIndex].Cells[0].Value.ToString();
            idBox.Text = id;

            var name = employeeDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            nameBox.Text = name;

            var email = employeeDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
            emailBox.Text = email;

            var password = employeeDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
            passwordBox.Text = password;

            var designation = employeeDGV.Rows[e.RowIndex].Cells[4].Value;
            designationBox.Text = designation.ToString();

            var department = employeeDGV.Rows[e.RowIndex].Cells[5].Value;
            deptBox.Text = department.ToString();

            var gender = employeeDGV.Rows[e.RowIndex].Cells[6].Value.ToString();
            if (gender == "Male")
            {
                male.Checked = true;
            }
            else
            {
                female.Checked = false;
            }
            var salary = employeeDGV.Rows[e.RowIndex].Cells[7].Value.ToString();
            salaryBox.Text = salary;

            var joining_Date = employeeDGV.Rows[e.RowIndex].Cells[8].Value.ToString();
            dateTimePicker1.Text = joining_Date;

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var id = idBox.Text;
            if (id != "AUTO GENERATED")
            {
                MessageBox.Show("Employee Already Exists");return;
            }
            else if (nameBox.Text == "" || emailBox.Text == "" || passwordBox.Text == "" || designationBox.SelectedItem == null || deptBox.SelectedItem == null || male.Checked == false && female.Checked == false || salaryBox.Text == "" || dateTimePicker1.Value == null)
            {

                MessageBox.Show("Please Fill All The Fields");return;
            }

            else
            {
                try
                {
                    var name = nameBox.Text;
                    var email = emailBox.Text;
                    var password = passwordBox.Text;
                    var designation = designationBox.Text;
                    var department = deptBox.Text;
                    string gender;
                    if (male.Checked == true)
                    {
                        gender = "Male";
                    }
                    else
                    {
                        gender = "Female";
                    }
                    var salary = int.Parse(salaryBox.Text);
                    var joining_Date = dateTimePicker1.Value.ToString();

                    if (!email.EndsWith("@gmail.com"))
                    {
                        MessageBox.Show("Invalid Email"); return;
                    }
                    if(password.Length < 8)
                    {
                        MessageBox.Show("Password must be at least 8 characters long"); return;
                    }

                    // MessageBox.Show(name,email,password,designation,department,gender,salary,joining_Date);


                    SqlConnection connection = new SqlConnection("Data Source=WIN-K77493C2S8N\\SQLEXPRESS01;Initial Catalog=mainProject;Integrated Security=True;TrustServerCertificate=True");
                    connection.Open();

                    string q = "INSERT INTO employee " +
             "(name, email, password,designation,department, gender, salary,joining_date) VALUES ('"
             + name + "','"
             + email + "','"
             + password + "','"
             + designation + "','"
             + department + "','"
             + gender + "','"
                          + salary + "','"
             + joining_Date + "')";



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

        private void clrButton_Click(object sender, EventArgs e)
        {
            clearAll();
           
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if(radioButtonValue == "Admin")
            {
                new HR_MANAGER.Employee(loginemail, loginpassword, radioButtonValue).Show();
                this.Hide();
                return;
            }
            else if(radioButtonValue == "HR Manager")
            {
                new HRManagerDashboard(emailBox.Text, passwordBox.Text, radioButtonValue);
                this.Hide();
            }
            else
            {
                new Form1().Show();
                this.Hide();
            }
           
        }

        private void updatebtn_Click_1(object sender, EventArgs e)
        {
            var id = idBox.Text;

            if (nameBox.Text == "" || emailBox.Text == "" || passwordBox.Text == "" || designationBox.SelectedItem == null || deptBox.SelectedItem == null || male.Checked == false && female.Checked == false || salaryBox.Text == "" || dateTimePicker1.Value == null)
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
                    var designation = designationBox.Text;
                    var department = deptBox.Text;
                    string gender;
                    if (male.Checked == true)
                    {
                        gender = "Male";
                    }
                    else
                    {
                        gender = "Female";
                    }
                    var salary = int.Parse(salaryBox.Text);
                    var joining_Date = dateTimePicker1.Value;

                    // MessageBox.Show(name,email,password,designation,department,gender,salary,joining_Date);


                    SqlConnection connection = new SqlConnection("Data Source=WIN-K77493C2S8N\\SQLEXPRESS01;Initial Catalog=mainProject;Integrated Security=True;TrustServerCertificate=True");
                    connection.Open();

                    string query = "UPDATE employee SET name='" + name + "', email='" + email + "', password='" + password + "', designation='" + designation + "', department='" + department + "', gender='" + gender + "', salary='" + salary + "', joining_date='" + joining_Date + "' WHERE id='" + id + "'";

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

        private void removeBtn_Click(object sender, EventArgs e)
        {
            var id = idBox.Text;
            if (id != "AUTO GENERATED")
            {
                string query = "DELETE FROM employee WHERE id='" + id + "'";
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
                MessageBox.Show("Please Select An Employee To Remove");
            }
        }

        private void addEmployee_Load(object sender, EventArgs e)
        {
         //  loadingDept();
           // loadingDesignationBox();
        }
    }

    }
            
    

