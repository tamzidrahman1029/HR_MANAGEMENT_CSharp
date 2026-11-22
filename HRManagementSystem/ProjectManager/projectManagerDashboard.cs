using Employee_management;
using HRManagementSystem.ADMIN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRManagementSystem.ProjectManager
{
    public partial class projectManagerDashboard : Form
    {
        private string email;
        private string password;
        private string radioButtonValue;
        public projectManagerDashboard()
        {
            InitializeComponent();
        }
        public projectManagerDashboard(string email,string password,string radioButtonValue)
        {
            this.email = email;
            this.password = password;
            this.radioButtonValue = radioButtonValue;
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if(radioButtonValue == "Project Manager")
            {
                new Form1().Show();
                this.Hide();
            }
            else
            {
                new Form1().Show();
                this.Hide();
            }
        }

        private void manageProjectButton_Click(object sender, EventArgs e)
        {
            new projectManage(email, password, radioButtonValue).Show();
            this.Hide();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            new projectManagerProfile(email, password, radioButtonValue).Show();
            this.Hide();
        }
    }
}
