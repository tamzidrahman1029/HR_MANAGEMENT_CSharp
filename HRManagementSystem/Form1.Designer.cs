namespace HRManagementSystem
{
    partial class Form1
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
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.adminRB = new System.Windows.Forms.RadioButton();
            this.hrManagerRB = new System.Windows.Forms.RadioButton();
            this.deptManagerRB = new System.Windows.Forms.RadioButton();
            this.projectManagerRB = new System.Windows.Forms.RadioButton();
            this.employeeRB = new System.Windows.Forms.RadioButton();
            this.rbPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginPanel.SuspendLayout();
            this.rbPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.LoginPanel.Controls.Add(this.LoginLabel);
            this.LoginPanel.Location = new System.Drawing.Point(0, 0);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(1000, 68);
            this.LoginPanel.TabIndex = 0;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.Location = new System.Drawing.Point(417, 19);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(262, 32);
            this.LoginLabel.TabIndex = 0;
            this.LoginLabel.Text = "Login Credientials";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(595, 109);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(73, 27);
            this.emailLabel.TabIndex = 1;
            this.emailLabel.Text = "Email";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(546, 206);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(122, 27);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password";
            // 
            // emailBox
            // 
            this.emailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBox.Location = new System.Drawing.Point(692, 109);
            this.emailBox.Multiline = true;
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(290, 38);
            this.emailBox.TabIndex = 3;
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.Location = new System.Drawing.Point(692, 209);
            this.passwordBox.Multiline = true;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(290, 38);
            this.passwordBox.TabIndex = 4;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(692, 423);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(290, 45);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // adminRB
            // 
            this.adminRB.AutoSize = true;
            this.adminRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminRB.Location = new System.Drawing.Point(3, 3);
            this.adminRB.Name = "adminRB";
            this.adminRB.Size = new System.Drawing.Size(71, 20);
            this.adminRB.TabIndex = 6;
            this.adminRB.TabStop = true;
            this.adminRB.Text = "Admin";
            this.adminRB.UseVisualStyleBackColor = true;
            // 
            // hrManagerRB
            // 
            this.hrManagerRB.AutoSize = true;
            this.hrManagerRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hrManagerRB.Location = new System.Drawing.Point(175, 3);
            this.hrManagerRB.Name = "hrManagerRB";
            this.hrManagerRB.Size = new System.Drawing.Size(115, 20);
            this.hrManagerRB.TabIndex = 7;
            this.hrManagerRB.TabStop = true;
            this.hrManagerRB.Text = "HR Manager";
            this.hrManagerRB.UseVisualStyleBackColor = true;
            // 
            // deptManagerRB
            // 
            this.deptManagerRB.AutoSize = true;
            this.deptManagerRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deptManagerRB.Location = new System.Drawing.Point(3, 40);
            this.deptManagerRB.Name = "deptManagerRB";
            this.deptManagerRB.Size = new System.Drawing.Size(126, 20);
            this.deptManagerRB.TabIndex = 8;
            this.deptManagerRB.TabStop = true;
            this.deptManagerRB.Text = "Dept Manager";
            this.deptManagerRB.UseVisualStyleBackColor = true;
            // 
            // projectManagerRB
            // 
            this.projectManagerRB.AutoSize = true;
            this.projectManagerRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectManagerRB.Location = new System.Drawing.Point(175, 40);
            this.projectManagerRB.Name = "projectManagerRB";
            this.projectManagerRB.Size = new System.Drawing.Size(142, 20);
            this.projectManagerRB.TabIndex = 9;
            this.projectManagerRB.TabStop = true;
            this.projectManagerRB.Text = "Project Manager";
            this.projectManagerRB.UseVisualStyleBackColor = true;
            // 
            // employeeRB
            // 
            this.employeeRB.AutoSize = true;
            this.employeeRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeRB.Location = new System.Drawing.Point(90, 77);
            this.employeeRB.Name = "employeeRB";
            this.employeeRB.Size = new System.Drawing.Size(98, 20);
            this.employeeRB.TabIndex = 10;
            this.employeeRB.TabStop = true;
            this.employeeRB.Text = "Employee";
            this.employeeRB.UseVisualStyleBackColor = true;
            // 
            // rbPanel
            // 
            this.rbPanel.Controls.Add(this.adminRB);
            this.rbPanel.Controls.Add(this.employeeRB);
            this.rbPanel.Controls.Add(this.hrManagerRB);
            this.rbPanel.Controls.Add(this.projectManagerRB);
            this.rbPanel.Controls.Add(this.deptManagerRB);
            this.rbPanel.Location = new System.Drawing.Point(692, 290);
            this.rbPanel.Name = "rbPanel";
            this.rbPanel.Size = new System.Drawing.Size(329, 100);
            this.rbPanel.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(496, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Logging in As";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 515);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbPanel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.LoginPanel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.rbPanel.ResumeLayout(false);
            this.rbPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.RadioButton adminRB;
        private System.Windows.Forms.RadioButton hrManagerRB;
        private System.Windows.Forms.RadioButton deptManagerRB;
        private System.Windows.Forms.RadioButton projectManagerRB;
        private System.Windows.Forms.RadioButton employeeRB;
        private System.Windows.Forms.Panel rbPanel;
        private System.Windows.Forms.Label label1;
    }
}

