namespace HRManagementSystem.Employee
{
    partial class manageEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.idBox = new System.Windows.Forms.TextBox();
            this.designationBox = new System.Windows.Forms.ComboBox();
            this.id = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.clrButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.female = new System.Windows.Forms.RadioButton();
            this.male = new System.Windows.Forms.RadioButton();
            this.deptBox = new System.Windows.Forms.ComboBox();
            this.salaryBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.joiningdate = new System.Windows.Forms.Label();
            this.salary = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.dept = new System.Windows.Forms.Label();
            this.designation = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.employeeDGV = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.62058F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.37942F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.27586F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.72414F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1207, 582);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.dateTimePicker1);
            this.panel4.Controls.Add(this.idBox);
            this.panel4.Controls.Add(this.designationBox);
            this.panel4.Controls.Add(this.id);
            this.panel4.Controls.Add(this.addButton);
            this.panel4.Controls.Add(this.clrButton);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.deptBox);
            this.panel4.Controls.Add(this.salaryBox);
            this.panel4.Controls.Add(this.passwordBox);
            this.panel4.Controls.Add(this.emailBox);
            this.panel4.Controls.Add(this.nameBox);
            this.panel4.Controls.Add(this.joiningdate);
            this.panel4.Controls.Add(this.salary);
            this.panel4.Controls.Add(this.gender);
            this.panel4.Controls.Add(this.dept);
            this.panel4.Controls.Add(this.designation);
            this.panel4.Controls.Add(this.password);
            this.panel4.Controls.Add(this.email);
            this.panel4.Controls.Add(this.name);
            this.panel4.Location = new System.Drawing.Point(758, 80);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(446, 497);
            this.panel4.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(147, 406);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(249, 22);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(143, 1);
            this.idBox.Multiline = true;
            this.idBox.Name = "idBox";
            this.idBox.ReadOnly = true;
            this.idBox.Size = new System.Drawing.Size(253, 30);
            this.idBox.TabIndex = 15;
            this.idBox.Text = "AUTO GENERATED";
            this.idBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // designationBox
            // 
            this.designationBox.FormattingEnabled = true;
            this.designationBox.Items.AddRange(new object[] {
            "SOFTWARE ENGINEER"});
            this.designationBox.Location = new System.Drawing.Point(143, 256);
            this.designationBox.Name = "designationBox";
            this.designationBox.Size = new System.Drawing.Size(253, 24);
            this.designationBox.TabIndex = 10;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(86, 4);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(20, 16);
            this.id.TabIndex = 14;
            this.id.Text = "ID";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(80, 459);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(131, 30);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // clrButton
            // 
            this.clrButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.clrButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clrButton.Location = new System.Drawing.Point(277, 458);
            this.clrButton.Name = "clrButton";
            this.clrButton.Size = new System.Drawing.Size(119, 32);
            this.clrButton.TabIndex = 1;
            this.clrButton.Text = "CLEAR";
            this.clrButton.UseVisualStyleBackColor = false;
            this.clrButton.Click += new System.EventHandler(this.clrButton_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.female);
            this.panel5.Controls.Add(this.male);
            this.panel5.Location = new System.Drawing.Point(143, 306);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(253, 36);
            this.panel5.TabIndex = 12;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(147, 4);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(81, 20);
            this.female.TabIndex = 1;
            this.female.TabStop = true;
            this.female.Text = "FEMALE";
            this.female.UseVisualStyleBackColor = true;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(4, 4);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(64, 20);
            this.male.TabIndex = 0;
            this.male.TabStop = true;
            this.male.Text = "MALE";
            this.male.UseVisualStyleBackColor = true;
            // 
            // deptBox
            // 
            this.deptBox.FormattingEnabled = true;
            this.deptBox.Items.AddRange(new object[] {
            "ENGINEERING"});
            this.deptBox.Location = new System.Drawing.Point(143, 200);
            this.deptBox.Name = "deptBox";
            this.deptBox.Size = new System.Drawing.Size(253, 24);
            this.deptBox.TabIndex = 11;
            // 
            // salaryBox
            // 
            this.salaryBox.Location = new System.Drawing.Point(143, 361);
            this.salaryBox.Multiline = true;
            this.salaryBox.Name = "salaryBox";
            this.salaryBox.Size = new System.Drawing.Size(253, 30);
            this.salaryBox.TabIndex = 9;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(143, 145);
            this.passwordBox.Multiline = true;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(253, 30);
            this.passwordBox.TabIndex = 7;
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(143, 99);
            this.emailBox.Multiline = true;
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(253, 30);
            this.emailBox.TabIndex = 6;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(143, 47);
            this.nameBox.Multiline = true;
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(253, 30);
            this.nameBox.TabIndex = 5;
            // 
            // joiningdate
            // 
            this.joiningdate.AutoSize = true;
            this.joiningdate.Location = new System.Drawing.Point(29, 413);
            this.joiningdate.Name = "joiningdate";
            this.joiningdate.Size = new System.Drawing.Size(100, 16);
            this.joiningdate.TabIndex = 4;
            this.joiningdate.Text = "JOINING DATE";
            // 
            // salary
            // 
            this.salary.AutoSize = true;
            this.salary.Location = new System.Drawing.Point(64, 364);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(60, 16);
            this.salary.TabIndex = 3;
            this.salary.Text = "SALARY";
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Location = new System.Drawing.Point(64, 306);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(65, 16);
            this.gender.TabIndex = 2;
            this.gender.Text = "GENDER";
            // 
            // dept
            // 
            this.dept.AutoSize = true;
            this.dept.Location = new System.Drawing.Point(27, 200);
            this.dept.Name = "dept";
            this.dept.Size = new System.Drawing.Size(102, 16);
            this.dept.TabIndex = 2;
            this.dept.Text = "DEPARTMENT";
            // 
            // designation
            // 
            this.designation.AutoSize = true;
            this.designation.Location = new System.Drawing.Point(30, 256);
            this.designation.Name = "designation";
            this.designation.Size = new System.Drawing.Size(99, 16);
            this.designation.TabIndex = 2;
            this.designation.Text = "DESIGNATION";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(43, 148);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(86, 16);
            this.password.TabIndex = 2;
            this.password.Text = "PASSWORD";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(83, 99);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(46, 16);
            this.email.TabIndex = 1;
            this.email.Text = "EMAIL";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(83, 50);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(46, 16);
            this.name.TabIndex = 0;
            this.name.Text = "NAME";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(758, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(446, 70);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANAGE EMPLOYEE";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.employeeDGV);
            this.panel2.Location = new System.Drawing.Point(3, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(749, 499);
            this.panel2.TabIndex = 1;
            // 
            // employeeDGV
            // 
            this.employeeDGV.AllowUserToAddRows = false;
            this.employeeDGV.AllowUserToDeleteRows = false;
            this.employeeDGV.AllowUserToResizeColumns = false;
            this.employeeDGV.AllowUserToResizeRows = false;
            this.employeeDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.employeeDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeDGV.Location = new System.Drawing.Point(0, 0);
            this.employeeDGV.Name = "employeeDGV";
            this.employeeDGV.ReadOnly = true;
            this.employeeDGV.RowHeadersWidth = 51;
            this.employeeDGV.RowTemplate.Height = 24;
            this.employeeDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeeDGV.Size = new System.Drawing.Size(747, 497);
            this.employeeDGV.TabIndex = 0;
            this.employeeDGV.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeDGV_CellContentDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Controls.Add(this.refreshBtn);
            this.panel1.Controls.Add(this.removeBtn);
            this.panel1.Controls.Add(this.updatebtn);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 70);
            this.panel1.TabIndex = 0;
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(3, 7);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(147, 42);
            this.backBtn.TabIndex = 4;
            this.backBtn.Text = "BACK";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.refreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.Location = new System.Drawing.Point(196, 7);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(147, 42);
            this.refreshBtn.TabIndex = 1;
            this.refreshBtn.Text = "REFRESH";
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.removeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBtn.Location = new System.Drawing.Point(598, 7);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(147, 42);
            this.removeBtn.TabIndex = 1;
            this.removeBtn.Text = "REMOVE";
            this.removeBtn.UseVisualStyleBackColor = false;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.Location = new System.Drawing.Point(396, 7);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(147, 42);
            this.updatebtn.TabIndex = 3;
            this.updatebtn.Text = "UPDATE";
            this.updatebtn.UseVisualStyleBackColor = false;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click_1);
            // 
            // manageEmployee
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1204, 590);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "manageEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addEmployee";
            this.Load += new System.EventHandler(this.addEmployee_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeeDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label joiningdate;
        private System.Windows.Forms.Label salary;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.Label dept;
        private System.Windows.Forms.Label designation;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.ComboBox designationBox;
        private System.Windows.Forms.TextBox salaryBox;
        private System.Windows.Forms.ComboBox deptBox;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.Button clrButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.DataGridView employeeDGV;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}