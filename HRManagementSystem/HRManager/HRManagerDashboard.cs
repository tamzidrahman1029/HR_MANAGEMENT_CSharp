using HRManagementSystem.ADMIN;
using HRManagementSystem.Employee;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRManagementSystem.HRManager
{
    public partial class HRManagerDashboard : Form
    {
        private string email;
        private string password;
        private string radioButtonValue;
        public HRManagerDashboard()
        {
            InitializeComponent();
        }
        public HRManagerDashboard(string email, string password, string radioButtonValue)
        {
            this.email = email;
            this.password = password;
            this.radioButtonValue = radioButtonValue;
            InitializeComponent();
        }

        private void manageEmpButton_Click(object sender, EventArgs e)
        {
            new manageEmployee(email, password,radioButtonValue).Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void manageSalaryButton_Click(object sender, EventArgs e)
        {
            new manageSalary(email, password, radioButtonValue).Show();
            this.Hide();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            new HRManagerProfile(email,password,radioButtonValue).Show();this.Hide();
        }
    }
}
