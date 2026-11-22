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
    public partial class HRManagerSalary : Form
    {
        private string email;
        private string password;
        private string radioButtonValue;
        public HRManagerSalary()
        {
            InitializeComponent();
        }
        public HRManagerSalary(string email,string password,string radioButtonValue)
        {
            this.email = email;
            this.password = password;
            this.radioButtonValue = radioButtonValue;
            InitializeComponent();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            new HR_MANAGER.Employee(email, password, radioButtonValue).Show();
            this.Hide();
        }

        public void loadManager()
        {
            SqlConnection con = new SqlConnection("Data Source=WIN-K77493C2S8N\\SQLEXPRESS01;Initial Catalog=mainProject;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT id, hr_name, salary FROM HRManager", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            hrManagerCombobox.DataSource = dt;
            hrManagerCombobox.DisplayMember = "hr_name";
            hrManagerCombobox.SelectedIndex = -1;
        }

        public void loadManagerBasicSalary(string name)
        {
            using (SqlConnection con = new SqlConnection(
                "Data Source=WIN-K77493C2S8N\\SQLEXPRESS01;Initial Catalog=mainProject;Integrated Security=True;TrustServerCertificate=True"))
            {
                SqlCommand cmd = new SqlCommand("SELECT salary FROM HRManager WHERE hr_name = @name", con);

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

        private void HRManagerSalary_Load(object sender, EventArgs e)
        {
            loadManager();
        }

        public void loadHRManagerSalaryID(string name)
        {
            using (SqlConnection con = new SqlConnection(
                         "Data Source=WIN-K77493C2S8N\\SQLEXPRESS01;Initial Catalog=mainProject;Integrated Security=True;TrustServerCertificate=True"))
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT HRManagerSalaryId FROM HRManagerSalary WHERE HR_Manager_Name = @name", con);

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

        private void hrManagerCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (hrManagerCombobox.SelectedIndex == -1)
            {
                basicSalaryBox.Text = "";
                return;
            }

            string name = hrManagerCombobox.Text;
            loadManagerBasicSalary(name);
            loadHRManagerSalaryID(name);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (hrManagerCombobox.SelectedIndex == -1 || statusComboBox.Text == "" ||
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
                    var empName = hrManagerCombobox.Text;
                    var basicSalary = int.Parse(basicSalaryBox.Text);
                    var allowance = allowanceBox.Text == "" ? 0 : int.Parse(allowanceBox.Text);
                    var deduction = deductionBox.Text == "" ? 0 : int.Parse(deductionBox.Text);
                    var salaryMonth = dateTimePicker1.Text.ToString();
                    var status = statusComboBox.Text;
                    var total =  (allowance + basicSalary ) - deduction;

                    SqlConnection con = new SqlConnection(
                        "Data Source=WIN-K77493C2S8N\\SQLEXPRESS01;Initial Catalog=mainProject;Integrated Security=True;TrustServerCertificate=True");
                    con.Open();

                    string query =
                        "INSERT INTO HRManagerSalary (HR_Manager_Name,SalaryMonth, BasicSalary, Allowance, Deduction,Status) VALUES ('"
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

                    hrManagerCombobox.SelectedIndex = -1;
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

        private void refreshButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection("Data Source=WIN-K77493C2S8N\\SQLEXPRESS01;Initial Catalog=mainProject;Integrated Security=True;TrustServerCertificate=True");
            connection.Open();

                string q = "select * from HRManagerSalary";
                SqlCommand cmd = new SqlCommand(q, connection);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                sda.Fill(ds);

                DataTable dt = ds.Tables[0];


                HRDGV.DataSource = dt;
                HRDGV.Refresh();
                HRDGV.ClearSelection();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void HRDGV_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = HRDGV.Rows[e.RowIndex].Cells[0].Value.ToString();
            idBox.Text = id;
            var name = HRDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            hrManagerCombobox.Text = name;
            var date = HRDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
            dateTimePicker1.Text = date;
            var bs = HRDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
            basicSalaryBox.Text = bs;
            var a = HRDGV.Rows[e.RowIndex].Cells[4].Value.ToString().ToUpper();
            allowanceBox.Text = a;
            var d = HRDGV.Rows[e.RowIndex].Cells[5].Value.ToString().ToUpper();
            deductionBox.Text = d;
            var s = HRDGV.Rows[e.RowIndex].Cells[6].Value.ToString();
            statusComboBox.Text = s;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            idBox.Text = "AUTO GENERATED";
            hrManagerCombobox.SelectedIndex = -1;
            dateTimePicker1.Text = "";
            basicSalaryBox.Text = "";
            allowanceBox.Text = "";
            deductionBox.Text = "";
            statusComboBox.SelectedIndex = -1;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (hrManagerCombobox.SelectedIndex == -1 || statusComboBox.Text == "" ||
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
                    var managerName = hrManagerCombobox.Text;
                    var basicSalary = int.Parse(basicSalaryBox.Text);
                    var allowance = allowanceBox.Text == "" ? 0 : int.Parse(allowanceBox.Text);
                    var deduction = deductionBox.Text == "" ? 0 : int.Parse(deductionBox.Text);
                    var salaryMonth = dateTimePicker1.Text.ToString();
                    var status = statusComboBox.Text;

                    SqlConnection con = new SqlConnection(
                        "Data Source=WIN-K77493C2S8N\\SQLEXPRESS01;Initial Catalog=mainProject;Integrated Security=True;TrustServerCertificate=True");
                    con.Open();

                    string query = "UPDATE HRManagerSalary SET " +
                                  "HR_Manager_Name = '" + managerName + "', " +
                                  "SalaryMonth = '" + salaryMonth + "', " +
                                  "BasicSalary = '" + basicSalary + "', " +
                                  "Allowance = '" + allowance + "', " +
                                  "Deduction = '" + deduction + "', " +
                                  "Status = '" + status + "' " +
                                  "WHERE HR_Manager_Name = '" + managerName + "'";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Salary Record Updated Successfully");

                    idBox.Text = "AUTO GENERATED";
                    hrManagerCombobox.SelectedIndex = -1;
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

                string query = "DELETE FROM HRManagerSalary WHERE HRManagerSalaryId='" + id + "'";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Salary Record Deleted Successfully");

                idBox.Text = "AUTO GENERATED";
                hrManagerCombobox.SelectedIndex = -1;
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

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double allowance = allowanceBox.Text == "" ? 0 : Convert.ToDouble(allowanceBox.Text);
            double ded = deductionBox.Text == "" ? 0 : Convert.ToDouble(deductionBox.Text);
            double basic = basicSalaryBox.Text == "" ? 0 : Convert.ToDouble(basicSalaryBox.Text);
            double totalSalary = (basic + allowance) - ded;
            MessageBox.Show("Total Salary: " + totalSalary.ToString());
        }
    }
}
    
    

