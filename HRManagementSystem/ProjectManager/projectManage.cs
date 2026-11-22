using HRManagementSystem;
using HRManagementSystem.HRManager;
using HRManagementSystem.ProjectManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Employee_management
{
    public partial class projectManage : Form
    {
        private string email;
        private string password;
        private string radioButtonValue;
        public projectManage()
        {
            InitializeComponent();
        }

        public projectManage(string email, string password, string radioButtonValue)
        {
            this.email = email;
            this.password = password;
            this.radioButtonValue = radioButtonValue;
            InitializeComponent();
        }

        private void refreshproject_Click(object sender, EventArgs e)
        {
            clearAll();
            try
            {
                SqlConnection connection = new SqlConnection("Data Source=WIN-K77493C2S8N\\SQLEXPRESS01;Initial Catalog=mainProject;Integrated Security=True;TrustServerCertificate=True");
                connection.Open();

                string query = "select * from EmployeeProject";

                SqlDataAdapter sda = new SqlDataAdapter(query, connection);

                DataSet dataset = new DataSet();

                sda.Fill(dataset);

                DataTable dataTable = dataset.Tables[0];

                EPDGV.DataSource = dataTable;
                EPDGV.Refresh();
                EPDGV.ClearSelection();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void updateproject_Click(object sender, EventArgs e)
        {
            var id = idBox.Text;

            if (projectNameBox.Text == "")
            {

                MessageBox.Show("Please Fill All The Fields");
            }
            else
            {
                try
                {
                    var projectName = projectNameBox.Text;
                    var projectID = idBox.Text;
                    var start_date = dateTimePicker1.Value;
                    var due_date = dateTimePicker2.Value;
                    var assignedEmpName = assignComboBox.Text;

                    string getEmpId = "select id from employee where name='" + assignedEmpName + "'";
                    SqlConnection connection2 = new SqlConnection("Data Source=WIN-K77493C2S8N\\SQLEXPRESS01;Initial Catalog=mainProject;Integrated Security=True;TrustServerCertificate=True");
                    connection2.Open();
                    SqlCommand cmd2 = new SqlCommand(getEmpId, connection2);
                    int empId = Convert.ToInt32(cmd2.ExecuteScalar());

                    SqlConnection connection = new SqlConnection("Data Source=WIN-K77493C2S8N\\SQLEXPRESS01;Initial Catalog=mainProject;Integrated Security=True;TrustServerCertificate=True");
                    connection.Open();

                    string query = "UPDATE EmployeeProject SET Employee_ID ='" + empId 
                        + "', project_id='" + projectID
                        + "', start_date='" + start_date
                        + "', due_date='" + due_date
                         + "', project_name ='" + projectName
                         + "', Employee_Name ='" + assignedEmpName
                        + "' WHERE project_id='" + projectID + "'";

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


        private void deleteproject_Click(object sender, EventArgs e)
        {
            var id = idBox.Text;
     
            if (id != "AUTO GENERATED")
            {
                string query = "DELETE FROM EmployeeProject WHERE project_id ='" + id + "'";
                MessageBox.Show(id);
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
                MessageBox.Show("Please Select A Project To Remove");
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
           
            if (radioButtonValue == "Admin")
            {
                HRManagementSystem.HR_MANAGER.Employee adm = new HRManagementSystem.HR_MANAGER.Employee(email, password, radioButtonValue);
                adm.Show();
                this.Hide();
            }
            else if(radioButtonValue == "Project Manager")
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

        public void loadComboBox()
        {
            SqlConnection con = new SqlConnection("Data Source=WIN-K77493C2S8N\\SQLEXPRESS01;Initial Catalog=mainProject;Integrated Security=True;TrustServerCertificate=True");
            con.Open();

            string query = "select * from employee";
            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            assignComboBox.DataSource = dt;
            assignComboBox.DisplayMember = "name";
        }

        public void clearAll()
        {
            idBox.Text = "AUTO GENERATED";
            projectNameBox.Text = "";
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
            assignComboBox.SelectedIndex = -1;
        }

        private void addproject_Click(object sender, EventArgs e)
        {
            var start_date = dateTimePicker1.Value;
            var due_date = dateTimePicker2.Value;
            if (projectNameBox.Text == "" || assignComboBox.SelectedIndex == -1 || start_date == null || due_date == null)
            {
                MessageBox.Show("Please Fill All The Fields");
                return;
            }
            try
            {
                if (idBox.Text == "AUTO GENERATED")
                {
                    var projectName = projectNameBox.Text;
                    var start_Date = dateTimePicker1.Value;
                    var due_Date = dateTimePicker2.Value;
                    var projectName2 = projectNameBox.Text;
                    var empName = assignComboBox.Text;  
                    MessageBox.Show(start_Date + " " + due_Date);

                    SqlConnection connection = new SqlConnection("Data Source=WIN-K77493C2S8N\\SQLEXPRESS01;Initial Catalog=mainProject;Integrated Security=True;TrustServerCertificate=True");
                    connection.Open();

                    string q = "INSERT INTO project " +
             "(project_name,start_date,due_date) VALUES ('"
             + projectName + "','"
              + start_Date + "','"
             + due_Date + "')";
                    SqlCommand cmd = new SqlCommand(q, connection);
                    cmd.ExecuteNonQuery();

                    string getProjectId = "SELECT SCOPE_IDENTITY()";
                    SqlCommand cmdGetProjectId = new SqlCommand(getProjectId, connection);
                    int projectId = Convert.ToInt32(cmdGetProjectId.ExecuteScalar());

                    connection.Close();
                    MessageBox.Show("PROJECT ADDED");

                    ///

                    var assignedEmpName = assignComboBox.Text;

                    string getEmpId = "select id from employee where name='" + assignedEmpName + "'";
                    SqlConnection connection2 = new SqlConnection("Data Source=WIN-K77493C2S8N\\SQLEXPRESS01;Initial Catalog=mainProject;Integrated Security=True;TrustServerCertificate=True");
                    connection2.Open();
                    SqlCommand cmd2 = new SqlCommand(getEmpId, connection2);

                    int empId = Convert.ToInt32(cmd2.ExecuteScalar());

                    ////

                    string q3 = "INSERT INTO EmployeeProject " +
                   "(Employee_ID, project_id, start_date,due_date,project_name,Employee_Name) VALUES ('" +
                   empId + "','" +
                   projectId + "','" +
                   start_date + "','" +
                     due_date + "','" +
                     projectName2 + "','" +
                   empName + "')";

                    SqlCommand cmd3 = new SqlCommand(q3, connection2);
                    cmd3.ExecuteNonQuery();

                    connection2.Close();
                    MessageBox.Show("PROJECT ADDED AND EMPLOYEE ASSIGNED");

                }
                else
                {
                    MessageBox.Show("Project Already Exists");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error: " + exception.Message);
            }

            ////////////////////////

        }

        private void projectManage_Load(object sender, EventArgs e)
        {
            loadComboBox();
            clearAll();
        }

        private void EPDGV_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            var id = EPDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
            idBox.Text = id;

            var start_Date = EPDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
            dateTimePicker1.Text = start_Date;
            var due_Date = EPDGV.Rows[e.RowIndex].Cells[4].Value.ToString();
            dateTimePicker1.Text = start_Date;

            var projectID = EPDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
            var empID = EPDGV.Rows[e.RowIndex].Cells[1].Value.ToString();


            string getProjectName = "select project_name from project where project_id='" + projectID + "'";
            SqlConnection connection = new SqlConnection("Data Source=WIN-K77493C2S8N\\SQLEXPRESS01;Initial Catalog=mainProject;Integrated Security=True;TrustServerCertificate=True");
            connection.Open();
            SqlCommand cmd = new SqlCommand(getProjectName, connection);
            var projectName = cmd.ExecuteScalar().ToString();
            projectNameBox.Text = projectName;
            connection.Close();

            string getEmpName = "select name from employee where id='" + empID + "'";
            SqlConnection connection2 = new SqlConnection("Data Source=WIN-K77493C2S8N\\SQLEXPRESS01;Initial Catalog=mainProject;Integrated Security=True;TrustServerCertificate=True");
            connection2.Open();
            SqlCommand cmd2 = new SqlCommand(getEmpName, connection2);
            var assignedEmployee = cmd2.ExecuteScalar().ToString();
            assignComboBox.Text = assignedEmployee;
            connection2.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
