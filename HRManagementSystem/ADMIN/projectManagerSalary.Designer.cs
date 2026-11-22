namespace HRManagementSystem.ADMIN
{
    partial class projectManagerSalary
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.PMSDGV = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backbutton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.deductionBox = new System.Windows.Forms.TextBox();
            this.allowanceBox = new System.Windows.Forms.TextBox();
            this.basicSalaryBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pmCombobox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PMSDGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.7457F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.2543F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1347, 582);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.PMSDGV);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 373);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1341, 206);
            this.panel2.TabIndex = 1;
            // 
            // PMSDGV
            // 
            this.PMSDGV.AllowUserToAddRows = false;
            this.PMSDGV.AllowUserToDeleteRows = false;
            this.PMSDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PMSDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PMSDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PMSDGV.Location = new System.Drawing.Point(0, 0);
            this.PMSDGV.Name = "PMSDGV";
            this.PMSDGV.ReadOnly = true;
            this.PMSDGV.RowHeadersWidth = 51;
            this.PMSDGV.RowTemplate.Height = 24;
            this.PMSDGV.Size = new System.Drawing.Size(1341, 206);
            this.PMSDGV.TabIndex = 0;
            this.PMSDGV.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PMSDGV_CellContentDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.backbutton);
            this.panel1.Controls.Add(this.deleteButton);
            this.panel1.Controls.Add(this.updateButton);
            this.panel1.Controls.Add(this.clearButton);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.idBox);
            this.panel1.Controls.Add(this.refreshButton);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.statusComboBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.calculateButton);
            this.panel1.Controls.Add(this.deductionBox);
            this.panel1.Controls.Add(this.allowanceBox);
            this.panel1.Controls.Add(this.basicSalaryBox);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.pmCombobox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1341, 364);
            this.panel1.TabIndex = 0;
            // 
            // backbutton
            // 
            this.backbutton.Location = new System.Drawing.Point(9, 8);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(75, 23);
            this.backbutton.TabIndex = 64;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(1009, 329);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(172, 29);
            this.deleteButton.TabIndex = 63;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(726, 294);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(172, 29);
            this.updateButton.TabIndex = 62;
            this.updateButton.Text = "UPDATE";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(1009, 294);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(172, 29);
            this.clearButton.TabIndex = 61;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(447, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 16);
            this.label7.TabIndex = 60;
            this.label7.Text = "PROJECT Manager Salary ID";
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(670, 51);
            this.idBox.Name = "idBox";
            this.idBox.ReadOnly = true;
            this.idBox.Size = new System.Drawing.Size(228, 22);
            this.idBox.TabIndex = 59;
            this.idBox.Text = " AUTO GENERATED";
            this.idBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(726, 329);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(172, 30);
            this.refreshButton.TabIndex = 58;
            this.refreshButton.Text = "REFRESH";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(564, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 57;
            this.label6.Text = "Status";
            // 
            // statusComboBox
            // 
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Pending ",
            "Paid"});
            this.statusComboBox.Location = new System.Drawing.Point(670, 264);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(228, 24);
            this.statusComboBox.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(564, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 55;
            this.label5.Text = "Deduction";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(563, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 54;
            this.label4.Text = "Allowance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(549, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 53;
            this.label3.Text = "Basic Salary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(546, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 52;
            this.label2.Text = "Choose Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(513, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 51;
            this.label1.Text = "Choose Manager";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(516, 329);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(172, 30);
            this.saveButton.TabIndex = 50;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(516, 294);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(172, 29);
            this.calculateButton.TabIndex = 49;
            this.calculateButton.Text = "CALCULATE";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // deductionBox
            // 
            this.deductionBox.Location = new System.Drawing.Point(670, 220);
            this.deductionBox.Name = "deductionBox";
            this.deductionBox.Size = new System.Drawing.Size(228, 22);
            this.deductionBox.TabIndex = 48;
            // 
            // allowanceBox
            // 
            this.allowanceBox.Location = new System.Drawing.Point(670, 176);
            this.allowanceBox.Name = "allowanceBox";
            this.allowanceBox.Size = new System.Drawing.Size(228, 22);
            this.allowanceBox.TabIndex = 47;
            // 
            // basicSalaryBox
            // 
            this.basicSalaryBox.Location = new System.Drawing.Point(670, 133);
            this.basicSalaryBox.Name = "basicSalaryBox";
            this.basicSalaryBox.ReadOnly = true;
            this.basicSalaryBox.Size = new System.Drawing.Size(228, 22);
            this.basicSalaryBox.TabIndex = 46;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(670, 85);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(228, 22);
            this.dateTimePicker1.TabIndex = 45;
            this.dateTimePicker1.Value = new System.DateTime(2026, 1, 19, 14, 57, 57, 0);
            // 
            // pmCombobox
            // 
            this.pmCombobox.FormattingEnabled = true;
            this.pmCombobox.Location = new System.Drawing.Point(670, 5);
            this.pmCombobox.Name = "pmCombobox";
            this.pmCombobox.Size = new System.Drawing.Size(228, 24);
            this.pmCombobox.TabIndex = 44;
            this.pmCombobox.SelectedIndexChanged += new System.EventHandler(this.pmCombobox_SelectedIndexChanged);
            // 
            // projectManagerSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 582);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "projectManagerSalary";
            this.Text = "projectManagerSalary";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.projectManagerSalary_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PMSDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox deductionBox;
        private System.Windows.Forms.TextBox allowanceBox;
        private System.Windows.Forms.TextBox basicSalaryBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox pmCombobox;
        private System.Windows.Forms.DataGridView PMSDGV;
    }
}