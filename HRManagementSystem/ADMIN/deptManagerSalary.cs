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
    public partial class deptManagerSalary : Form
    {
        private string email;
        private string password;
        private string radioButtonValue;
        public deptManagerSalary()
        {
            InitializeComponent();

        }
        public deptManagerSalary(string email, string password, string radioButtonValue)
        {

            this.email = email;
            this.password = password;
            this.radioButtonValue = radioButtonValue;
            InitializeComponent();

        }

        public void loadManagers()
        {
            SqlConnection con = new SqlConnection("Data Source=WIN-K77493C2S8N\\SQLEXPRESS01;Initial Catalog=mainProject;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT id, dm_name, salary FROM departmentManager", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            deptManagerCombobox.DataSource = dt;
            deptManagerCombobox.DisplayMember = "dm_name";
            deptManagerCombobox.SelectedIndex = -1;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double allowance = allowanceBox.Text == "" ? 0 : Convert.ToDouble(allowanceBox.Text);
            double ded = deductionBox.Text == "" ? 0 : Convert.ToDouble(deductionBox.Text);
            double basic = basicSalaryBox.Text == "" ? 0 : Convert.ToDouble(basicSalaryBox.Text);
            double totalSalary = (basic + allowance) - ded;
            MessageBox.Show("Total Salary: " + totalSalary.ToString());
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (deptManagerCombobox.SelectedIndex == -1 || statusComboBox.Text == "" ||
      basicSalaryBox.Text == "" ||
      dateTimePicker1.Text == "")
            {
                MessageBox.Show("Please Fill All The Fields");
                return;
            }

            if (idBox.Text == "AUTO GENERATED")
            {
                try
                {
                    var empName = deptManagerCombobox.Text;
                    var basicSalary = int.Parse(basicSalaryBox.Text);
                    var allowance = allowanceBox.Text == "" ? 0 : int.Parse(allowanceBox.Text);
                    var deduction = deductionBox.Text == "" ? 0 : int.Parse(deductionBox.Text);
                    var salaryMonth = dateTimePicker1.Text.ToString();
                    var status = statusComboBox.Text;

                    SqlConnection con = new SqlConnection(
                        "Data Source=WIN-K77493C2S8N\\SQLEXPRESS01;Initial Catalog=mainProject;Integrated Security=True;TrustServerCertificate=True");
                    con.Open();

                    string query =
                        "INSERT INTO DeptManagerSalary (Dept_Manager_Name,SalaryMonth, BasicSalary, Allowance, Deduction,Status) VALUES ('"
                                               + empName + "','"
                        + salaryMonth + "','"
                        + basicSalary + "','"
                        + allowance + "','"
                        + deduction + "','"
                        + status + "')";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Salary Added Successfully");

                    deptManagerCombobox.SelectedIndex = -1;
                    basicSalaryBox.Text = "";
                    allowanceBox.Text = "";
                    deductionBox.Text = "";
                    dateTimePicker1.Text = "";
                    statusComboBox.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Record Already Exists. Cannot Add Again.");
            }
        }

        private void deptManagerSalary_Load(object sender, EventArgs e)
        {
            loadManagers();
        }

        private void deptManagerCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (deptManagerCombobox.SelectedIndex == -1)
            {
                basicSalaryBox.Text = "";
                return;
            }

            string name = deptManagerCombobox.Text;
            loadManagerBasicSalary(name);
            loadHRManagerSalaryID(name);
        }

        private void loadHRManagerSalaryID(string name)
        {
            using (SqlConnection con = new SqlConnection(
                        "Data Source=WIN-K77493C2S8N\\SQLEXPRESS01;Initial Catalog=mainProject;Integrated Security=True;TrustServerCertificate=True"))
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT DeptManagerSalaryId FROM DeptManagerSalary WHERE Dept_Manager_Name = @name", con);

                cmd.Parameters.AddWithValue("@name", name);

                con.Open();
                object result = cmd.ExecuteScalar();
                con.Close();

                if (result != null)
                {
                    idBox.Text = result.ToString();
                }
                else
                {
                    idBox.Text = "AUTO GENERATED";
                }
            }
        }

        private void loadManagerBasicSalary(string name)
        {
            using (SqlConnection con = new SqlConnection(
               "Data Source=WIN-K77493C2S8N\\SQLEXPRESS01;Initial Catalog=mainProject;Integrated Security=True;TrustServerCertificate=True"))
            {
                SqlCommand cmd = new SqlCommand("SELECT salary FROM departmentManager WHERE dm_name = @name", con);

                cmd.Parameters.AddWithValue("@name", name);

                con.Open();
                object result = cmd.ExecuteScalar();
                con.Close();

                if (result != null)
                {
                    basicSalaryBox.Text = result.ToString();
                }
                else
                {
                    basicSalaryBox.Text = "";
                }
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection("Data Source=WIN-K77493C2S8N\\SQLEXPRESS01;Initial Catalog=mainProject;Integrated Security=True;TrustServerCertificate=True");
                connection.Open();

                string q = "select * from DeptManagerSalary";
                SqlCommand cmd = new SqlCommand(q, connection);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                sda.Fill(ds);

                DataTable dt = ds.Tables[0];


                DMDGV.DataSource = dt;
                DMDGV.Refresh();
                DMDGV.ClearSelection();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (deptManagerCombobox.SelectedIndex == -1 || statusComboBox.Text == "" ||
            basicSalaryBox.Text == "" ||
            dateTimePicker1.Text == "")
            {
                MessageBox.Show("Please Fill All The Fields");
            }
            else if (idBox.Text == "AUTO GENERATED")
            {
                MessageBox.Show("Please Select a Salary Record to Update");
            }
            else
            {
                try
                {
                    var id = idBox.Text;
                    var managerName = deptManagerCombobox.Text;
                    var basicSalary = int.Parse(basicSalaryBox.Text);
                    var allowance = allowanceBox.Text == "" ? 0 : int.Parse(allowanceBox.Text);
                    var deduction = deductionBox.Text == "" ? 0 : int.Parse(deductionBox.Text);
                    var salaryMonth = dateTimePicker1.Text.ToString();
                    var status = statusComboBox.Text;

                    SqlConnection con = new SqlConnection(
                        "Data Source=WIN-K77493C2S8N\\SQLEXPRESS01;Initial Catalog=mainProject;Integrated Security=True;TrustServerCertificate=True");
                    con.Open();

                    string query = "UPDATE DeptManagerSalary SET " +
                                  "Dept_Manager_Name = '" + managerName + "', " +
                                  "SalaryMonth = '" + salaryMonth + "', " +
                                  "BasicSalary = '" + basicSalary + "', " +
                                  "Allowance = '" + allowance + "', " +
                                  "Deduction = '" + deduction + "', " +
                                  "Status = '" + status + "' " +
                                  "WHERE Dept_Manager_Name = '" + managerName + "'";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Salary Record Updated Successfully");

                    idBox.Text = "AUTO GENERATED";
                    deptManagerCombobox.SelectedIndex = -1;
                    basicSalaryBox.Text = "";
                    allowanceBox.Text = "";
                    deductionBox.Text = "";
                    dateTimePicker1.Text = "";
                    statusComboBox.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (idBox.Text == "AUTO GENERATED" || idBox.Text == "")
            {
                MessageBox.Show("Please Select a Salary Record to Delete");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this salary record?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.No)
                return;

            try
            {
                var id = idBox.Text;

                SqlConnection con = new SqlConnection(
                    "Data Source=WIN-K77493C2S8N\\SQLEXPRESS01;Initial Catalog=mainProject;Integrated Security=True;TrustServerCertificate=True");
                con.Open();

                string query = "DELETE FROM DeptManagerSalary WHERE DeptManagerSalaryId='" + id + "'";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Salary Record Deleted Successfully");

                idBox.Text = "AUTO GENERATED";
                deptManagerCombobox.SelectedIndex = -1;
                basicSalaryBox.Text = "";
                allowanceBox.Text = "";
                deductionBox.Text = "";
                dateTimePicker1.Text = "";
                statusComboBox.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void DMDGV_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = DMDGV.Rows[e.RowIndex].Cells[0].Value.ToString();
            idBox.Text = id;
            var name = DMDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            deptManagerCombobox.Text = name;
            var date = DMDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
            dateTimePicker1.Text = date;
            var bs = DMDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
            basicSalaryBox.Text = bs;
            var a = DMDGV.Rows[e.RowIndex].Cells[4].Value.ToString().ToUpper();
            allowanceBox.Text = a;
            var d = DMDGV.Rows[e.RowIndex].Cells[5].Value.ToString().ToUpper();
            deductionBox.Text = d;
            var s = DMDGV.Rows[e.RowIndex].Cells[6].Value.ToString();
            statusComboBox.Text = s;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            idBox.Text = "AUTO GENERATED";
            deptManagerCombobox.SelectedIndex = -1;
            dateTimePicker1.Text = "";
            basicSalaryBox.Text = "";
            allowanceBox.Text = "";
            deductionBox.Text = "";
            statusComboBox.SelectedIndex = -1;
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            new HR_MANAGER.Employee(email, password, radioButtonValue).Show();
            this.Hide();
        }

      
    }
}
