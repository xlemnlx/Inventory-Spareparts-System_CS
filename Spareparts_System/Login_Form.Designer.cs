namespace Spareparts_System
{
    partial class Login_Form
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbx_username = new System.Windows.Forms.TextBox();
            this.txtbx_password = new System.Windows.Forms.TextBox();
            this.bttn_login = new System.Windows.Forms.Button();
            this.bttn_signup = new System.Windows.Forms.Button();
            this.grpbx_signin_employee = new System.Windows.Forms.GroupBox();
            this.grpbx_addnewemployee = new System.Windows.Forms.GroupBox();
            this.lbl_newidnumber = new System.Windows.Forms.Label();
            this.lbl_employee1 = new System.Windows.Forms.Label();
            this.bttn_backtologin = new System.Windows.Forms.Button();
            this.bttn_addnewemployee = new System.Windows.Forms.Button();
            this.txtbx_addnewpassword = new System.Windows.Forms.TextBox();
            this.txtbx_addnewusername = new System.Windows.Forms.TextBox();
            this.txtbx_addnewlastname = new System.Windows.Forms.TextBox();
            this.txtbx_addnewfirstname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpbx_signin_admin = new System.Windows.Forms.GroupBox();
            this.bttn_login_admin = new System.Windows.Forms.Button();
            this.txtbx_adminpassword = new System.Windows.Forms.TextBox();
            this.txtbx_adminusername = new System.Windows.Forms.TextBox();
            this.txtbx_adminidnumber = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rdbttn_employee = new System.Windows.Forms.RadioButton();
            this.rdbttn_admin = new System.Windows.Forms.RadioButton();
            this.timer_sync = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_oldidnumber = new System.Windows.Forms.Label();
            this.grpbx_signin_employee.SuspendLayout();
            this.grpbx_addnewemployee.SuspendLayout();
            this.grpbx_signin_admin.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // txtbx_username
            // 
            this.txtbx_username.Location = new System.Drawing.Point(98, 19);
            this.txtbx_username.Margin = new System.Windows.Forms.Padding(4);
            this.txtbx_username.Name = "txtbx_username";
            this.txtbx_username.Size = new System.Drawing.Size(148, 26);
            this.txtbx_username.TabIndex = 2;
            // 
            // txtbx_password
            // 
            this.txtbx_password.Location = new System.Drawing.Point(98, 53);
            this.txtbx_password.Margin = new System.Windows.Forms.Padding(4);
            this.txtbx_password.Name = "txtbx_password";
            this.txtbx_password.Size = new System.Drawing.Size(148, 26);
            this.txtbx_password.TabIndex = 3;
            this.txtbx_password.UseSystemPasswordChar = true;
            // 
            // bttn_login
            // 
            this.bttn_login.Location = new System.Drawing.Point(46, 101);
            this.bttn_login.Name = "bttn_login";
            this.bttn_login.Size = new System.Drawing.Size(75, 36);
            this.bttn_login.TabIndex = 4;
            this.bttn_login.Text = "Log-In";
            this.bttn_login.UseVisualStyleBackColor = true;
            this.bttn_login.Click += new System.EventHandler(this.bttn_login_Click);
            // 
            // bttn_signup
            // 
            this.bttn_signup.Location = new System.Drawing.Point(135, 101);
            this.bttn_signup.Name = "bttn_signup";
            this.bttn_signup.Size = new System.Drawing.Size(75, 36);
            this.bttn_signup.TabIndex = 5;
            this.bttn_signup.Text = "Sign-Up";
            this.bttn_signup.UseVisualStyleBackColor = true;
            this.bttn_signup.Click += new System.EventHandler(this.bttn_signup_Click);
            // 
            // grpbx_signin_employee
            // 
            this.grpbx_signin_employee.Controls.Add(this.txtbx_username);
            this.grpbx_signin_employee.Controls.Add(this.bttn_signup);
            this.grpbx_signin_employee.Controls.Add(this.label1);
            this.grpbx_signin_employee.Controls.Add(this.bttn_login);
            this.grpbx_signin_employee.Controls.Add(this.label2);
            this.grpbx_signin_employee.Controls.Add(this.txtbx_password);
            this.grpbx_signin_employee.Location = new System.Drawing.Point(12, 90);
            this.grpbx_signin_employee.Name = "grpbx_signin_employee";
            this.grpbx_signin_employee.Size = new System.Drawing.Size(263, 151);
            this.grpbx_signin_employee.TabIndex = 6;
            this.grpbx_signin_employee.TabStop = false;
            // 
            // grpbx_addnewemployee
            // 
            this.grpbx_addnewemployee.Controls.Add(this.lbl_newidnumber);
            this.grpbx_addnewemployee.Controls.Add(this.lbl_employee1);
            this.grpbx_addnewemployee.Controls.Add(this.bttn_backtologin);
            this.grpbx_addnewemployee.Controls.Add(this.bttn_addnewemployee);
            this.grpbx_addnewemployee.Controls.Add(this.txtbx_addnewpassword);
            this.grpbx_addnewemployee.Controls.Add(this.txtbx_addnewusername);
            this.grpbx_addnewemployee.Controls.Add(this.txtbx_addnewlastname);
            this.grpbx_addnewemployee.Controls.Add(this.txtbx_addnewfirstname);
            this.grpbx_addnewemployee.Controls.Add(this.label8);
            this.grpbx_addnewemployee.Controls.Add(this.label7);
            this.grpbx_addnewemployee.Controls.Add(this.label6);
            this.grpbx_addnewemployee.Controls.Add(this.label5);
            this.grpbx_addnewemployee.Controls.Add(this.label4);
            this.grpbx_addnewemployee.Controls.Add(this.label3);
            this.grpbx_addnewemployee.Location = new System.Drawing.Point(12, 90);
            this.grpbx_addnewemployee.Name = "grpbx_addnewemployee";
            this.grpbx_addnewemployee.Size = new System.Drawing.Size(261, 277);
            this.grpbx_addnewemployee.TabIndex = 7;
            this.grpbx_addnewemployee.TabStop = false;
            this.grpbx_addnewemployee.Text = "Add New Employee";
            this.grpbx_addnewemployee.Visible = false;
            // 
            // lbl_newidnumber
            // 
            this.lbl_newidnumber.AutoSize = true;
            this.lbl_newidnumber.Location = new System.Drawing.Point(98, 44);
            this.lbl_newidnumber.Name = "lbl_newidnumber";
            this.lbl_newidnumber.Size = new System.Drawing.Size(0, 18);
            this.lbl_newidnumber.TabIndex = 15;
            // 
            // lbl_employee1
            // 
            this.lbl_employee1.AutoSize = true;
            this.lbl_employee1.Location = new System.Drawing.Point(98, 140);
            this.lbl_employee1.Name = "lbl_employee1";
            this.lbl_employee1.Size = new System.Drawing.Size(96, 18);
            this.lbl_employee1.TabIndex = 14;
            this.lbl_employee1.Text = "Employee_1";
            // 
            // bttn_backtologin
            // 
            this.bttn_backtologin.BackgroundImage = global::Spareparts_System.Properties.Resources.back_button;
            this.bttn_backtologin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_backtologin.Location = new System.Drawing.Point(9, 233);
            this.bttn_backtologin.Name = "bttn_backtologin";
            this.bttn_backtologin.Size = new System.Drawing.Size(66, 36);
            this.bttn_backtologin.TabIndex = 13;
            this.bttn_backtologin.UseVisualStyleBackColor = true;
            this.bttn_backtologin.Click += new System.EventHandler(this.bttn_backtologin_Click);
            // 
            // bttn_addnewemployee
            // 
            this.bttn_addnewemployee.Location = new System.Drawing.Point(101, 233);
            this.bttn_addnewemployee.Name = "bttn_addnewemployee";
            this.bttn_addnewemployee.Size = new System.Drawing.Size(75, 36);
            this.bttn_addnewemployee.TabIndex = 12;
            this.bttn_addnewemployee.Text = "Save";
            this.bttn_addnewemployee.UseVisualStyleBackColor = true;
            this.bttn_addnewemployee.Click += new System.EventHandler(this.bttn_addnewemployee_Click);
            // 
            // txtbx_addnewpassword
            // 
            this.txtbx_addnewpassword.Location = new System.Drawing.Point(101, 201);
            this.txtbx_addnewpassword.Name = "txtbx_addnewpassword";
            this.txtbx_addnewpassword.Size = new System.Drawing.Size(148, 26);
            this.txtbx_addnewpassword.TabIndex = 11;
            this.txtbx_addnewpassword.UseSystemPasswordChar = true;
            // 
            // txtbx_addnewusername
            // 
            this.txtbx_addnewusername.Location = new System.Drawing.Point(101, 169);
            this.txtbx_addnewusername.Name = "txtbx_addnewusername";
            this.txtbx_addnewusername.Size = new System.Drawing.Size(148, 26);
            this.txtbx_addnewusername.TabIndex = 10;
            // 
            // txtbx_addnewlastname
            // 
            this.txtbx_addnewlastname.Location = new System.Drawing.Point(101, 105);
            this.txtbx_addnewlastname.Name = "txtbx_addnewlastname";
            this.txtbx_addnewlastname.Size = new System.Drawing.Size(148, 26);
            this.txtbx_addnewlastname.TabIndex = 8;
            // 
            // txtbx_addnewfirstname
            // 
            this.txtbx_addnewfirstname.Location = new System.Drawing.Point(101, 73);
            this.txtbx_addnewfirstname.Name = "txtbx_addnewfirstname";
            this.txtbx_addnewfirstname.Size = new System.Drawing.Size(148, 26);
            this.txtbx_addnewfirstname.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 18);
            this.label8.TabIndex = 5;
            this.label8.Text = "Password:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "Username:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Position:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID #:";
            // 
            // grpbx_signin_admin
            // 
            this.grpbx_signin_admin.Controls.Add(this.bttn_login_admin);
            this.grpbx_signin_admin.Controls.Add(this.txtbx_adminpassword);
            this.grpbx_signin_admin.Controls.Add(this.txtbx_adminusername);
            this.grpbx_signin_admin.Controls.Add(this.txtbx_adminidnumber);
            this.grpbx_signin_admin.Controls.Add(this.label11);
            this.grpbx_signin_admin.Controls.Add(this.label10);
            this.grpbx_signin_admin.Controls.Add(this.label9);
            this.grpbx_signin_admin.Location = new System.Drawing.Point(12, 90);
            this.grpbx_signin_admin.Name = "grpbx_signin_admin";
            this.grpbx_signin_admin.Size = new System.Drawing.Size(263, 183);
            this.grpbx_signin_admin.TabIndex = 8;
            this.grpbx_signin_admin.TabStop = false;
            this.grpbx_signin_admin.Text = "Admin Log-In";
            this.grpbx_signin_admin.Visible = false;
            // 
            // bttn_login_admin
            // 
            this.bttn_login_admin.Location = new System.Drawing.Point(96, 137);
            this.bttn_login_admin.Name = "bttn_login_admin";
            this.bttn_login_admin.Size = new System.Drawing.Size(75, 36);
            this.bttn_login_admin.TabIndex = 10;
            this.bttn_login_admin.Text = "Log-In";
            this.bttn_login_admin.UseVisualStyleBackColor = true;
            this.bttn_login_admin.Click += new System.EventHandler(this.bttn_login_admin_Click);
            // 
            // txtbx_adminpassword
            // 
            this.txtbx_adminpassword.Location = new System.Drawing.Point(96, 105);
            this.txtbx_adminpassword.Name = "txtbx_adminpassword";
            this.txtbx_adminpassword.Size = new System.Drawing.Size(148, 26);
            this.txtbx_adminpassword.TabIndex = 5;
            this.txtbx_adminpassword.UseSystemPasswordChar = true;
            // 
            // txtbx_adminusername
            // 
            this.txtbx_adminusername.Location = new System.Drawing.Point(96, 73);
            this.txtbx_adminusername.Name = "txtbx_adminusername";
            this.txtbx_adminusername.Size = new System.Drawing.Size(148, 26);
            this.txtbx_adminusername.TabIndex = 4;
            // 
            // txtbx_adminidnumber
            // 
            this.txtbx_adminidnumber.Location = new System.Drawing.Point(96, 41);
            this.txtbx_adminidnumber.Name = "txtbx_adminidnumber";
            this.txtbx_adminidnumber.Size = new System.Drawing.Size(148, 26);
            this.txtbx_adminidnumber.TabIndex = 3;
            this.txtbx_adminidnumber.UseSystemPasswordChar = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 18);
            this.label11.TabIndex = 2;
            this.label11.Text = "Password:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 18);
            this.label10.TabIndex = 1;
            this.label10.Text = "Username:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "ID #:";
            // 
            // rdbttn_employee
            // 
            this.rdbttn_employee.AutoSize = true;
            this.rdbttn_employee.Checked = true;
            this.rdbttn_employee.Location = new System.Drawing.Point(48, 51);
            this.rdbttn_employee.Name = "rdbttn_employee";
            this.rdbttn_employee.Size = new System.Drawing.Size(96, 22);
            this.rdbttn_employee.TabIndex = 9;
            this.rdbttn_employee.TabStop = true;
            this.rdbttn_employee.Text = "Employee";
            this.rdbttn_employee.UseVisualStyleBackColor = true;
            this.rdbttn_employee.CheckedChanged += new System.EventHandler(this.rdbttn_employee_CheckedChanged);
            // 
            // rdbttn_admin
            // 
            this.rdbttn_admin.AutoSize = true;
            this.rdbttn_admin.Location = new System.Drawing.Point(165, 51);
            this.rdbttn_admin.Name = "rdbttn_admin";
            this.rdbttn_admin.Size = new System.Drawing.Size(71, 22);
            this.rdbttn_admin.TabIndex = 10;
            this.rdbttn_admin.Text = "Admin";
            this.rdbttn_admin.UseVisualStyleBackColor = true;
            this.rdbttn_admin.CheckedChanged += new System.EventHandler(this.rdbttn_admin_CheckedChanged);
            // 
            // timer_sync
            // 
            this.timer_sync.AutoSize = true;
            this.timer_sync.Location = new System.Drawing.Point(64, 9);
            this.timer_sync.Name = "timer_sync";
            this.timer_sync.Size = new System.Drawing.Size(0, 18);
            this.timer_sync.TabIndex = 11;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_oldidnumber
            // 
            this.lbl_oldidnumber.AutoSize = true;
            this.lbl_oldidnumber.Location = new System.Drawing.Point(386, 323);
            this.lbl_oldidnumber.Name = "lbl_oldidnumber";
            this.lbl_oldidnumber.Size = new System.Drawing.Size(59, 18);
            this.lbl_oldidnumber.TabIndex = 12;
            this.lbl_oldidnumber.Text = "label12";
            this.lbl_oldidnumber.Visible = false;
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(286, 379);
            this.Controls.Add(this.lbl_oldidnumber);
            this.Controls.Add(this.timer_sync);
            this.Controls.Add(this.rdbttn_admin);
            this.Controls.Add(this.rdbttn_employee);
            this.Controls.Add(this.grpbx_signin_admin);
            this.Controls.Add(this.grpbx_addnewemployee);
            this.Controls.Add(this.grpbx_signin_employee);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_Form_FormClosing);
            this.Load += new System.EventHandler(this.Login_Form_Load);
            this.grpbx_signin_employee.ResumeLayout(false);
            this.grpbx_signin_employee.PerformLayout();
            this.grpbx_addnewemployee.ResumeLayout(false);
            this.grpbx_addnewemployee.PerformLayout();
            this.grpbx_signin_admin.ResumeLayout(false);
            this.grpbx_signin_admin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbx_username;
        private System.Windows.Forms.TextBox txtbx_password;
        private System.Windows.Forms.Button bttn_login;
        private System.Windows.Forms.Button bttn_signup;
        private System.Windows.Forms.GroupBox grpbx_signin_employee;
        private System.Windows.Forms.GroupBox grpbx_addnewemployee;
        private System.Windows.Forms.TextBox txtbx_addnewpassword;
        private System.Windows.Forms.TextBox txtbx_addnewusername;
        private System.Windows.Forms.TextBox txtbx_addnewlastname;
        private System.Windows.Forms.TextBox txtbx_addnewfirstname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bttn_addnewemployee;
        private System.Windows.Forms.Button bttn_backtologin;
        private System.Windows.Forms.GroupBox grpbx_signin_admin;
        private System.Windows.Forms.Button bttn_login_admin;
        private System.Windows.Forms.TextBox txtbx_adminpassword;
        private System.Windows.Forms.TextBox txtbx_adminusername;
        private System.Windows.Forms.TextBox txtbx_adminidnumber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rdbttn_employee;
        private System.Windows.Forms.RadioButton rdbttn_admin;
        private System.Windows.Forms.Label lbl_employee1;
        private System.Windows.Forms.Label timer_sync;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_newidnumber;
        private System.Windows.Forms.Label lbl_oldidnumber;
    }
}

