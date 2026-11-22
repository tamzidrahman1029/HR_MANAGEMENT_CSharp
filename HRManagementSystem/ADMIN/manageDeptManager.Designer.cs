namespace HRManagementSystem.ADMIN
{
    partial class manageDeptManager
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.salaryBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateL = new System.Windows.Forms.Label();
            this.idL = new System.Windows.Forms.Label();
            this.emailL = new System.Windows.Forms.Label();
            this.passwordL = new System.Windows.Forms.Label();
            this.phoneL = new System.Windows.Forms.Label();
            this.nameL = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.femaleRB = new System.Windows.Forms.RadioButton();
            this.maleRB = new System.Windows.Forms.RadioButton();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.DMDGV = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DMDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.51917F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.48083F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.DMDGV, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.00843F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.99157F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1360, 596);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(907, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 83);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANAGE DEPARTMENT MANAGER";
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
            this.panel1.Size = new System.Drawing.Size(898, 83);
            this.panel1.TabIndex = 4;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(728, 16);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(156, 56);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(476, 16);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(168, 56);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "UPDATE";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.Location = new System.Drawing.Point(225, 16);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(165, 55);
            this.refreshButton.TabIndex = 1;
            this.refreshButton.Text = "REFRESH";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(19, 16);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(143, 55);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.salaryBox);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.dateL);
            this.panel3.Controls.Add(this.idL);
            this.panel3.Controls.Add(this.emailL);
            this.panel3.Controls.Add(this.passwordL);
            this.panel3.Controls.Add(this.phoneL);
            this.panel3.Controls.Add(this.nameL);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.phoneBox);
            this.panel3.Controls.Add(this.passwordBox);
            this.panel3.Controls.Add(this.emailBox);
            this.panel3.Controls.Add(this.nameBox);
            this.panel3.Controls.Add(this.idBox);
            this.panel3.Controls.Add(this.clearButton);
            this.panel3.Controls.Add(this.addButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(907, 92);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(450, 501);
            this.panel3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "SALARY";
            // 
            // salaryBox
            // 
            this.salaryBox.Location = new System.Drawing.Point(134, 273);
            this.salaryBox.Multiline = true;
            this.salaryBox.Name = "salaryBox";
            this.salaryBox.Size = new System.Drawing.Size(287, 32);
            this.salaryBox.TabIndex = 35;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(134, 398);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(287, 22);
            this.dateTimePicker1.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "GENDER";
            // 
            // dateL
            // 
            this.dateL.AutoSize = true;
            this.dateL.Location = new System.Drawing.Point(47, 398);
            this.dateL.Name = "dateL";
            this.dateL.Size = new System.Drawing.Size(77, 16);
            this.dateL.TabIndex = 32;
            this.dateL.Text = "JOIN DATE";
            // 
            // idL
            // 
            this.idL.AutoSize = true;
            this.idL.Location = new System.Drawing.Point(86, 5);
            this.idL.Name = "idL";
            this.idL.Size = new System.Drawing.Size(20, 16);
            this.idL.TabIndex = 31;
            this.idL.Text = "ID";
            // 
            // emailL
            // 
            this.emailL.AutoSize = true;
            this.emailL.Location = new System.Drawing.Point(69, 102);
            this.emailL.Name = "emailL";
            this.emailL.Size = new System.Drawing.Size(46, 16);
            this.emailL.TabIndex = 30;
            this.emailL.Text = "EMAIL";
            // 
            // passwordL
            // 
            this.passwordL.AutoSize = true;
            this.passwordL.Location = new System.Drawing.Point(38, 163);
            this.passwordL.Name = "passwordL";
            this.passwordL.Size = new System.Drawing.Size(86, 16);
            this.passwordL.TabIndex = 29;
            this.passwordL.Text = "PASSWORD";
            // 
            // phoneL
            // 
            this.phoneL.AutoSize = true;
            this.phoneL.Location = new System.Drawing.Point(69, 219);
            this.phoneL.Name = "phoneL";
            this.phoneL.Size = new System.Drawing.Size(55, 16);
            this.phoneL.TabIndex = 28;
            this.phoneL.Text = "PHONE";
            // 
            // nameL
            // 
            this.nameL.AutoSize = true;
            this.nameL.Location = new System.Drawing.Point(60, 49);
            this.nameL.Name = "nameL";
            this.nameL.Size = new System.Drawing.Size(46, 16);
            this.nameL.TabIndex = 27;
            this.nameL.Text = "NAME";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.femaleRB);
            this.panel5.Controls.Add(this.maleRB);
            this.panel5.Location = new System.Drawing.Point(134, 327);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(217, 64);
            this.panel5.TabIndex = 26;
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
            this.phoneBox.Location = new System.Drawing.Point(134, 219);
            this.phoneBox.Multiline = true;
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(287, 32);
            this.phoneBox.TabIndex = 24;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(134, 163);
            this.passwordBox.Multiline = true;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(287, 32);
            this.passwordBox.TabIndex = 23;
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(134, 102);
            this.emailBox.Multiline = true;
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(287, 32);
            this.emailBox.TabIndex = 22;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(131, 46);
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
            this.clearButton.Location = new System.Drawing.Point(282, 444);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(139, 48);
            this.clearButton.TabIndex = 19;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(52, 444);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(143, 51);
            this.addButton.TabIndex = 18;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // DMDGV
            // 
            this.DMDGV.AllowUserToAddRows = false;
            this.DMDGV.AllowUserToDeleteRows = false;
            this.DMDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DMDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DMDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DMDGV.Location = new System.Drawing.Point(3, 92);
            this.DMDGV.Name = "DMDGV";
            this.DMDGV.ReadOnly = true;
            this.DMDGV.RowHeadersWidth = 51;
            this.DMDGV.RowTemplate.Height = 24;
            this.DMDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DMDGV.Size = new System.Drawing.Size(898, 501);
            this.DMDGV.TabIndex = 7;
            this.DMDGV.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DMDGV_CellContentDoubleClick);
            // 
            // manageDeptManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 596);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "manageDeptManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "manageDeptManager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DMDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label dateL;
        private System.Windows.Forms.Label idL;
        private System.Windows.Forms.Label emailL;
        private System.Windows.Forms.Label passwordL;
        private System.Windows.Forms.Label phoneL;
        private System.Windows.Forms.Label nameL;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton femaleRB;
        private System.Windows.Forms.RadioButton maleRB;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView DMDGV;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox salaryBox;
    }
}