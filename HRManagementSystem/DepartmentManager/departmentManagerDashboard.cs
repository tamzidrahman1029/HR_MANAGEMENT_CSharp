using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRManagementSystem.DepartmentManager
{
    public partial class departmentManagerDashboard : Form
    {
        private string email;
        private string password;
        private string radioButtonValue;
        public departmentManagerDashboard()
        {
            InitializeComponent();
        }

        public departmentManagerDashboard(string email, string password, string radioButtonValue)
        {
            this.email = email;
            this.password = password;
            this.radioButtonValue = radioButtonValue;
            InitializeComponent();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            new departmentManagerProfile(email, password, radioButtonValue).Show();
            this.Hide();
        }

        private void manageDeptButton_Click(object sender, EventArgs e)
        {
            new manageDepartment(email,password, radioButtonValue).Show();
            this.Hide();
        }

        private void manageDesignationButton_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            new Form1().Show(); this.Hide();

        }

      
    }
}
