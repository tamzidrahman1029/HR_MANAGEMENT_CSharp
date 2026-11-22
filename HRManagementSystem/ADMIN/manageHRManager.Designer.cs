namespace HRManagementSystem.ADMIN
{
    partial class manageHRManager
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.salaryBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateL = new System.Windows.Forms.Label();
            this.idL = new System.Windows.Forms.Label();
            this.emailL = new System.Windows.Forms.Label();
            this.passwordL = new System.Windows.Forms.Label();
            this.phoneL = new System.Windows.Forms.Label();
            this.nameL = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.femaleRB = new System.Windows.Forms.RadioButton();
            this.maleRB = new System.Windows.Forms.RadioButton();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.HRMDGV = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HRMDGV)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.7894F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.21061F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.17158F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.82842F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1361, 579);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.deleteButton);
            this.panel1.Controls.Add(this.updateButton);
            this.panel1.Controls.Add(this.refreshButton);
            this.panel1.Controls.Add(this.backButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(903, 70);
            this.panel1.TabIndex = 5;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(731, 12);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(146, 49);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(495, 10);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(146, 49);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "UPDATE";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.Location = new System.Drawing.Point(249, 11);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(146, 49);
            this.refreshButton.TabIndex = 1;
            this.refreshButton.Text = "REFRESH";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(19, 11);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(146, 49);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(912, 79);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(446, 497);
            this.panel4.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel6.Controls.Add(this.salaryBox);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.dateTimePicker1);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.dateL);
            this.panel6.Controls.Add(this.idL);
            this.panel6.Controls.Add(this.emailL);
            this.panel6.Controls.Add(this.passwordL);
            this.panel6.Controls.Add(this.phoneL);
            this.panel6.Controls.Add(this.nameL);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.phoneBox);
            this.panel6.Controls.Add(this.passwordBox);
            this.panel6.Controls.Add(this.emailBox);
            this.panel6.Controls.Add(this.nameBox);
            this.panel6.Controls.Add(this.idBox);
            this.panel6.Controls.Add(this.clearButton);
            this.panel6.Controls.Add(this.addButton);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(444, 495);
            this.panel6.TabIndex = 7;
            // 
            // salaryBox
            // 
            this.salaryBox.Location = new System.Drawing.Point(134, 269);
            this.salaryBox.Multiline = true;
            this.salaryBox.Name = "salaryBox";
            this.salaryBox.Size = new System.Drawing.Size(287, 32);
            this.salaryBox.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "SALARY";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(138, 398);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(283, 22);
            this.dateTimePicker1.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "GENDER";
            // 
            // dateL
            // 
            this.dateL.AutoSize = true;
            this.dateL.Location = new System.Drawing.Point(29, 397);
            this.dateL.Name = "dateL";
            this.dateL.Size = new System.Drawing.Size(77, 16);
            this.dateL.TabIndex = 32;
            this.dateL.Text = "JOIN DATE";
            // 
            // idL
            // 
            this.idL.AutoSize = true;
            this.idL.Location = new System.Drawing.Point(38, 5);
            this.idL.Name = "idL";
            this.idL.Size = new System.Drawing.Size(20, 16);
            this.idL.TabIndex = 31;
            this.idL.Text = "ID";
            // 
            // emailL
            // 
            this.emailL.AutoSize = true;
            this.emailL.Location = new System.Drawing.Point(60, 101);
            this.emailL.Name = "emailL";
            this.emailL.Size = new System.Drawing.Size(46, 16);
            this.emailL.TabIndex = 30;
            this.emailL.Text = "EMAIL";
            // 
            // passwordL
            // 
            this.passwordL.AutoSize = true;
            this.passwordL.Location = new System.Drawing.Point(29, 165);
            this.passwordL.Name = "passwordL";
            this.passwordL.Size = new System.Drawing.Size(86, 16);
            this.passwordL.TabIndex = 29;
            this.passwordL.Text = "PASSWORD";
            // 
            // phoneL
            // 
            this.phoneL.AutoSize = true;
            this.phoneL.Location = new System.Drawing.Point(51, 213);
            this.phoneL.Name = "phoneL";
            this.phoneL.Size = new System.Drawing.Size(55, 16);
            this.phoneL.TabIndex = 28;
            this.phoneL.Text = "PHONE";
            // 
            // nameL
            // 
            this.nameL.AutoSize = true;
            this.nameL.Location = new System.Drawing.Point(60, 46);
            this.nameL.Name = "nameL";
            this.nameL.Size = new System.Drawing.Size(46, 16);
            this.nameL.TabIndex = 27;
            this.nameL.Text = "NAME";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.femaleRB);
            this.panel7.Controls.Add(this.maleRB);
            this.panel7.Location = new System.Drawing.Point(134, 327);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(217, 64);
            this.panel7.TabIndex = 26;
            // 
            // femaleRB
            // 
            this.femaleRB.AutoSize = true;
            this.femaleRB.Location = new System.Drawing.Point(113, 4);
            this.femaleRB.Name = "femaleRB";
            this.femaleRB.Size = new System.Drawing.Size(81, 20);
            this.femaleRB.TabIndex = 1;
            this.femaleRB.TabStop = true;
            this.femaleRB.Text = "FEMALE";
            this.femaleRB.UseVisualStyleBackColor = true;
            // 
            // maleRB
            // 
            this.maleRB.AutoSize = true;
            this.maleRB.Location = new System.Drawing.Point(4, 4);
            this.maleRB.Name = "maleRB";
            this.maleRB.Size = new System.Drawing.Size(64, 20);
            this.maleRB.TabIndex = 0;
            this.maleRB.TabStop = true;
            this.maleRB.Text = "MALE";
            this.maleRB.UseVisualStyleBackColor = true;
            // 
            // phoneBox
            // 
            this.phoneBox.Location = new System.Drawing.Point(138, 213);
            this.phoneBox.Multiline = true;
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(287, 32);
            this.phoneBox.TabIndex = 24;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(134, 165);
            this.passwordBox.Multiline = true;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(287, 32);
            this.passwordBox.TabIndex = 23;
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(134, 101);
            this.emailBox.Multiline = true;
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(287, 32);
            this.emailBox.TabIndex = 22;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(134, 46);
            this.nameBox.Multiline = true;
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(287, 32);
            this.nameBox.TabIndex = 21;
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(134, 5);
            this.idBox.Multiline = true;
            this.idBox.Name = "idBox";
            this.idBox.ReadOnly = true;
            this.idBox.Size = new System.Drawing.Size(217, 32);
            this.idBox.TabIndex = 20;
            this.idBox.Text = "AUTO GENERATED";
            this.idBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(264, 448);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(143, 39);
            this.clearButton.TabIndex = 19;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(41, 448);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(146, 39);
            this.addButton.TabIndex = 18;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.HRMDGV);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 79);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(903, 497);
            this.panel3.TabIndex = 2;
            // 
            // HRMDGV
            // 
            this.HRMDGV.AllowUserToAddRows = false;
            this.HRMDGV.AllowUserToDeleteRows = false;
            this.HRMDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.HRMDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HRMDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HRMDGV.Location = new System.Drawing.Point(0, 0);
            this.HRMDGV.Name = "HRMDGV";
            this.HRMDGV.ReadOnly = true;
            this.HRMDGV.RowHeadersWidth = 51;
            this.HRMDGV.RowTemplate.Height = 24;
            this.HRMDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.HRMDGV.Size = new System.Drawing.Size(901, 495);
            this.HRMDGV.TabIndex = 8;
            this.HRMDGV.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HRMDGV_CellContentDoubleClick);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(912, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(446, 70);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(444, 68);
            this.panel5.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANAGE HR MANAGER";
            // 
            // manageHRManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 579);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "manageHRManager";
            this.Text = "manageHRManager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HRMDGV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView HRMDGV;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label dateL;
        private System.Windows.Forms.Label idL;
        private System.Windows.Forms.Label emailL;
        private System.Windows.Forms.Label passwordL;
        private System.Windows.Forms.Label phoneL;
        private System.Windows.Forms.Label nameL;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.RadioButton femaleRB;
        private System.Windows.Forms.RadioButton maleRB;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox salaryBox;
        private System.Windows.Forms.Label label3;
    }
}