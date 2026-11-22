using Employee_management;
using HRManagementSystem.ADMIN;
using HRManagementSystem.DepartmentManager;
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

namespace HRManagementSystem.HR_MANAGER
{
    public partial class Employee : Form
    {
        private string email;
        private string password;
        private string radioButtonValue;
        public Employee()
        {
            InitializeComponent();
        }
     
        public Employee(string email,string password,string radioButtonValue)
        {
            this.email = email;
            this.password = password;
            this.radioButtonValue = radioButtonValue;
            InitializeComponent();
        }

        private void addEmpButton_Click(object sender, EventArgs e)
        {
             new manageEmployee(email,password,radioButtonValue).Show();
            this.Hide();
        }


        private void manageHrBtn_Click(object sender, EventArgs e)
        {
            new manageHRManager(email,password,radioButtonValue).Show();
            this.Hide();
        }

        private void managePMButton_Click(object sender, EventArgs e)
        {
            new manageProjectManager(email, password, radioButtonValue).Show();
            this.Hide();
        }

        private void manageDMButton_Click(object sender, EventArgs e)
        {
            new manageDeptManager(email,password, radioButtonValue).Show();
            this.Hide();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }
        private void manageProjectBtn_Click(object sender, EventArgs e)
        {
            new projectManage(email, password,radioButtonValue).Show(); this.Hide();

        }

        private void manageDeptBtn_Click(object sender, EventArgs e)
        {
            new manageDepartment(email,password,radioButtonValue).Show();
            this.Hide();
        }

        private void manageDesignationBtn_Click(object sender, EventArgs e)
        {
            new manageDesignation(email,password,radioButtonValue).Show();
            this.Hide();
        }

        private void manageSalaryButton_Click(object sender, EventArgs e)
        {
            new manageSalary(email,password, radioButtonValue).Show();
            this.Hide();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            new adminProfile(email,password,radioButtonValue).Show();this.Hide();
        }

        private void hrManagerSalaryButton_Click(object sender, EventArgs e)
        {
            new HRManagerSalary(email, password, radioButtonValue).Show();
            this.Hide();
        }

        private void deptManagerSalaryButton_Click(object sender, EventArgs e)
        {
            new deptManagerSalary(email, password, radioButtonValue).Show();this.Hide();
        }

        private void projectManagerSalaryButton_Click(object sender, EventArgs e)
        {
            new projectManagerSalary().Show();this.Hide();
        }
    }
}
