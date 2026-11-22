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

namespace HRManagementSystem.DepartmentManager
{
    public partial class manageDesignation : Form
    {
        private string email;
        private string password;
        private string radioButtonValue;
        private int departmentid;

        public void setId(int departmentid)
        {
         this.departmentid = departmentid;
        }

        public int getid()
        {
            return this.departmentid;
        }
        public manageDesignation()
        {
            InitializeComponent();
        }
        public manageDesignation(string email,string password,string radioButtonValue)
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
                new departmentManagerDashboard(email,password,radioButtonValue).Show();
                this.Hide();
            }
            else
            {
                new HR_MANAGER.Employee(email,password,radioButtonValue).Show();
                this.Hide();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {

            bool exists = false;

            var name2 = nameBox.Text;
            SqlConnection connection2 = new SqlConnection("Data Source=WIN-K77493C2S8N\\SQLEXPRESS01;Initial Catalog=mainProject;Integrated Security=True;TrustServerCertificate=True");
            connection2.Open();

            string query = "select * from designation where designation_name = '" + name2 + "'";
            SqlCommand cmd = new SqlCommand(query, connection2);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                exists = true;
                MessageBox.Show("Designation Already Exists");
                connection2.Close();
                return;
            }


            if (!exists) {

                var id = idbox.Text;
                var name = nameBox.Text;
                var date = dateTimePicker1.Value.ToString("yyyy-mm-dd");
                var belongs = belongsToComboBox.Text;
                var departmentInsertId = getid();


                if (id != "AUTO GENERATED")
                {
                    MessageBox.Show("Designation Already Exists");
                    return;
                }
                else
                {
                    SqlConnection connection = new SqlConnection("Data Source=WIN-K77493C2S8N\\SQLEXPRESS01;Initial Catalog=mainProject;Integrated Security=True;TrustServerCertificate=True");
                    connection.Open();
                    string q = "INSERT INTO designation " +
           "(designation_name,date_created,department_id) VALUES ('"
           + name + "','"
                  + date + "','"
           + departmentInsertId + "')";

                    SqlCommand cmd2 = new SqlCommand(q, connection);
                    cmd2.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("ADDED");
                    return;
                }
            }



     }

        public void getDeptID(string dept)
        {
            var departmentID = dept;

            SqlConnection connection = new SqlConnection("Data Source=WIN-K77493C2S8N\\SQLEXPRESS01;Initial Catalog=mainProject;Integrated Security=True;TrustServerCertificate=True"); 
            connection.Open();
            string query = "SELECT id FROM department WHERE department_name = '" + departmentID + "'";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                var deptID = reader["id"];
                //MessageBox.Show(deptID.ToString());
                setId(Convert.ToInt32(deptID));

            }

        }

        private void belongsToComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var choosenDept = belongsToComboBox.Text;
            getDeptID(choosenDept);
        }

        private void manageDesignation_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=WIN-K77493C2S8N\\SQLEXPRESS01;Initial Catalog=mainProject;Integrated Security=True;TrustServerCertificate=True");
            con.Open();

            string query = "select * from department";
            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            belongsToComboBox.DataSource = dt;
            belongsToComboBox.DisplayMember = "department_name";
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection("Data Source=WIN-K77493C2S8N\\SQLEXPRESS01;Initial Catalog=mainProject;Integrated Security=True;TrustServerCertificate=True");
                connection.Open();

                string query = "select * from designation";

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

        private void updateButton_Click(object sender, EventArgs e)
        {
            var id = idbox.Text;
            var date = dateTimePicker1.Value.ToString("yyyy-mm-dd");
            var name = nameBox.Text;
            var departmentInsertId = getid();

            if (id == "AUTO GENERATED")
            {
                MessageBox.Show("Choose One Designation To Delete"); return;
            }
            else
            {
                SqlConnection connection = new SqlConnection("Data Source=WIN-K77493C2S8N\\SQLEXPRESS01;Initial Catalog=mainProject;Integrated Security=True;TrustServerCertificate=True");
                connection.Open();

                string query = "UPDATE designation SET " +
         "designation_name='" + name + "', " +
         "date_created ='" + date + "', " +
         "department_id ='" + departmentInsertId + "' " +
         "WHERE id='" + id + "'";


                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();


                MessageBox.Show("UPDATED");
                return;
            }
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

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var id = idbox.Text;
            if (id != "AUTO GENERATED")
            {
                string query = "DELETE FROM designation WHERE id='" + id + "'";
                SqlConnection connection = new SqlConnection("Data Source=WIN-K77493C2S8N\\SQLEXPRESS01;Initial Catalog=mainProject;Integrated Security=True;TrustServerCertificate=True");
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("DELETED");
                idbox.Text = "AUTO GENERATED";
                nameBox.Text = "";
                belongsToComboBox.SelectedIndex = -1;
                return;

            }
        }
    }
    
}
