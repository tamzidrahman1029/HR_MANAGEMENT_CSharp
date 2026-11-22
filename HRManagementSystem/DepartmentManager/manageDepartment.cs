using HRManagementSystem.ADMIN;
using HRManagementSystem.HRManager;
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

namespace HRManagementSystem.DepartmentManager
{
    public partial class manageDepartment : Form
    {
        private string email;
        private string password;
        private string radioButtonValue;
        public manageDepartment()
        {
            InitializeComponent();
        }
        public manageDepartment(string email, string password, string radioButtonValue)
        {
            this.email = email;
            this.password = password;
            this.radioButtonValue = radioButtonValue;
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if(radioButtonValue == "Dept Manager")
            {
                new departmentManagerDashboard(email, password, radioButtonValue).Show();
                this.Hide();
            }
            else
            {
                new HR_MANAGER.Employee(email, password, radioButtonValue).Show();
                this.Hide();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {

            bool exists = false; 

            var name2 = nameBox.Text;
            SqlConnection connection2 = new SqlConnection("Data Source=WIN-K77493C2S8N\\SQLEXPRESS01;Initial Catalog=mainProject;Integrated Security=True;TrustServerCertificate=True");
            connection2.Open();

            string query = "select * from department where department_name = '" + name2 + "'";
            SqlCommand cmd = new SqlCommand(query, connection2);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                exists = true;
                MessageBox.Show("Department Already Exists");
                connection2.Close();
                return;
            }


            ///////////////////////////
            if (idbox.Text != "AUTO GENERATED")
            {
                MessageBox.Show("Department Already Exists");
                return;
            }
            else if(!exists)
            {
                var name = nameBox.Text;
                var date = dateTimePicker1.Value.ToString("yyyy-mm-dd");
                SqlConnection connection = new SqlConnection("Data Source=WIN-K77493C2S8N\\SQLEXPRESS01;Initial Catalog=mainProject;Integrated Security=True;TrustServerCertificate=True");
                connection.Open();
                string q = "INSERT INTO department " +
       "(department_name,date_created) VALUES ('"
       + name + "','"
       + date + "')";

                SqlCommand cmd2 = new SqlCommand(q, connection);
                cmd2.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("ADDED");
                return;

            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            idbox.Text = "AUTO GENERATED";
            nameBox.Text = "";
        }

        private void DDGV_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = DDGV.Rows[e.RowIndex].Cells[0].Value.ToString();  
            idbox.Text = id;

            var date = DDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
            dateTimePicker1.Text = date;

            var name = DDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            nameBox.Text = name;

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection("Data Source=WIN-K77493C2S8N\\SQLEXPRESS01;Initial Catalog=mainProject;Integrated Security=True;TrustServerCertificate=True");
                connection.Open();

                string query = "select * from department";

                SqlDataAdapter sda = new SqlDataAdapter(query, connection);

                DataSet dataset = new DataSet();

                sda.Fill(dataset);

                DataTable dataTable = dataset.Tables[0];

                DDGV.DataSource = dataTable;
                DDGV.Refresh();
                DDGV.ClearSelection();
                connection.Close();
            
        }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
}

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var id = idbox.Text;
            if (id != "AUTO GENERATED")
            {
                string query = "DELETE FROM department WHERE id='" + id + "'";
                SqlConnection connection = new SqlConnection("Data Source=WIN-K77493C2S8N\\SQLEXPRESS01;Initial Catalog=mainProject;Integrated Security=True;TrustServerCertificate=True");
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("DELETED");
                idbox.Text = "AUTO GENERATED";
                nameBox.Text = "";


                return;

            }

            else
            {
                MessageBox.Show("Please Select A Department To Remove");

            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            var id = idbox.Text;
            var date = dateTimePicker1.Value.ToString();
            var name = nameBox.Text;

            if(id ==  "AUTO GENERATED")
            {
                MessageBox.Show("Choose One Department To Delete"); return;
            }
            else
            {
                SqlConnection connection = new SqlConnection("Data Source=WIN-K77493C2S8N\\SQLEXPRESS01;Initial Catalog=mainProject;Integrated Security=True;TrustServerCertificate=True");
                connection.Open();

                string query = "UPDATE department SET " +
           "department_name='" + name + "', " +
           "date_created ='" + date + "' " +
           "WHERE id='" + id + "'";


                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();


                MessageBox.Show("UPDATED");
                return;
            }
        }
    }
}
