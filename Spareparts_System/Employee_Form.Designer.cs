namespace Spareparts_System
{
    partial class Employee_Form
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aCTIONSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grpbx_gsm_module = new System.Windows.Forms.GroupBox();
            this.lbl_to_gsm = new System.Windows.Forms.Label();
            this.lbl_admin_number = new System.Windows.Forms.Label();
            this.bttn_applynumber = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbobx_admin_name = new System.Windows.Forms.ComboBox();
            this.grpbx_addnewitem = new System.Windows.Forms.GroupBox();
            this.txtbx_add_password = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.bttn_add_add = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbx_add_username = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbx_add_quantity = new System.Windows.Forms.TextBox();
            this.txtbx_add_productname = new System.Windows.Forms.TextBox();
            this.txtbx_add_amount = new System.Windows.Forms.TextBox();
            this.grpbx_updateitem = new System.Windows.Forms.GroupBox();
            this.txtbx_update_password = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtbx_update_lastname = new System.Windows.Forms.TextBox();
            this.lbl_update_currentstock = new System.Windows.Forms.Label();
            this.lbl_update_productname = new System.Windows.Forms.Label();
            this.bttn_update_subtract = new System.Windows.Forms.Button();
            this.bttn_update_add = new System.Windows.Forms.Button();
            this.txtbx_update_firstame = new System.Windows.Forms.TextBox();
            this.txtbx_update_username = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbx_update_addquantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer_sync = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dtgrd_stocks = new System.Windows.Forms.DataGridView();
            this.bttn_refresh = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grpbx_gsm_module.SuspendLayout();
            this.grpbx_addnewitem.SuspendLayout();
            this.grpbx_updateitem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrd_stocks)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aCTIONSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1904, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aCTIONSToolStripMenuItem
            // 
            this.aCTIONSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.aCTIONSToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aCTIONSToolStripMenuItem.Name = "aCTIONSToolStripMenuItem";
            this.aCTIONSToolStripMenuItem.Size = new System.Drawing.Size(89, 22);
            this.aCTIONSToolStripMenuItem.Text = "ACTIONS";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.reportToolStripMenuItem.Text = "Report";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.logOutToolStripMenuItem.Text = "Log-Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 26);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grpbx_gsm_module);
            this.splitContainer1.Panel1.Controls.Add(this.grpbx_addnewitem);
            this.splitContainer1.Panel1.Controls.Add(this.grpbx_updateitem);
            this.splitContainer1.Panel1.Controls.Add(this.timer_sync);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label17);
            this.splitContainer1.Panel2.Controls.Add(this.dtgrd_stocks);
            this.splitContainer1.Panel2.Controls.Add(this.bttn_refresh);
            this.splitContainer1.Size = new System.Drawing.Size(1904, 1015);
            this.splitContainer1.SplitterDistance = 444;
            this.splitContainer1.TabIndex = 1;
            // 
            // grpbx_gsm_module
            // 
            this.grpbx_gsm_module.Controls.Add(this.lbl_to_gsm);
            this.grpbx_gsm_module.Controls.Add(this.lbl_admin_number);
            this.grpbx_gsm_module.Controls.Add(this.bttn_applynumber);
            this.grpbx_gsm_module.Controls.Add(this.label11);
            this.grpbx_gsm_module.Controls.Add(this.cmbobx_admin_name);
            this.grpbx_gsm_module.Location = new System.Drawing.Point(12, 637);
            this.grpbx_gsm_module.Name = "grpbx_gsm_module";
            this.grpbx_gsm_module.Size = new System.Drawing.Size(409, 366);
            this.grpbx_gsm_module.TabIndex = 7;
            this.grpbx_gsm_module.TabStop = false;
            this.grpbx_gsm_module.Text = "Update GSM-Module";
            // 
            // lbl_to_gsm
            // 
            this.lbl_to_gsm.AutoSize = true;
            this.lbl_to_gsm.Location = new System.Drawing.Point(6, 138);
            this.lbl_to_gsm.Name = "lbl_to_gsm";
            this.lbl_to_gsm.Size = new System.Drawing.Size(0, 18);
            this.lbl_to_gsm.TabIndex = 4;
            this.lbl_to_gsm.Visible = false;
            // 
            // lbl_admin_number
            // 
            this.lbl_admin_number.AutoSize = true;
            this.lbl_admin_number.Location = new System.Drawing.Point(6, 91);
            this.lbl_admin_number.Name = "lbl_admin_number";
            this.lbl_admin_number.Size = new System.Drawing.Size(0, 18);
            this.lbl_admin_number.TabIndex = 3;
            this.lbl_admin_number.Visible = false;
            // 
            // bttn_applynumber
            // 
            this.bttn_applynumber.Location = new System.Drawing.Point(148, 80);
            this.bttn_applynumber.Name = "bttn_applynumber";
            this.bttn_applynumber.Size = new System.Drawing.Size(75, 41);
            this.bttn_applynumber.TabIndex = 2;
            this.bttn_applynumber.Text = "Apply";
            this.bttn_applynumber.UseVisualStyleBackColor = true;
            this.bttn_applynumber.Click += new System.EventHandler(this.bttn_applynumber_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 18);
            this.label11.TabIndex = 1;
            this.label11.Text = "Select Admin:";
            // 
            // cmbobx_admin_name
            // 
            this.cmbobx_admin_name.FormattingEnabled = true;
            this.cmbobx_admin_name.Location = new System.Drawing.Point(124, 48);
            this.cmbobx_admin_name.Name = "cmbobx_admin_name";
            this.cmbobx_admin_name.Size = new System.Drawing.Size(204, 26);
            this.cmbobx_admin_name.TabIndex = 0;
            this.cmbobx_admin_name.SelectedIndexChanged += new System.EventHandler(this.cmbobx_admin_name_SelectedIndexChanged);
            // 
            // grpbx_addnewitem
            // 
            this.grpbx_addnewitem.Controls.Add(this.txtbx_add_password);
            this.grpbx_addnewitem.Controls.Add(this.label13);
            this.grpbx_addnewitem.Controls.Add(this.bttn_add_add);
            this.grpbx_addnewitem.Controls.Add(this.label10);
            this.grpbx_addnewitem.Controls.Add(this.label9);
            this.grpbx_addnewitem.Controls.Add(this.txtbx_add_username);
            this.grpbx_addnewitem.Controls.Add(this.label8);
            this.grpbx_addnewitem.Controls.Add(this.label7);
            this.grpbx_addnewitem.Controls.Add(this.txtbx_add_quantity);
            this.grpbx_addnewitem.Controls.Add(this.txtbx_add_productname);
            this.grpbx_addnewitem.Controls.Add(this.txtbx_add_amount);
            this.grpbx_addnewitem.Location = new System.Drawing.Point(12, 385);
            this.grpbx_addnewitem.Name = "grpbx_addnewitem";
            this.grpbx_addnewitem.Size = new System.Drawing.Size(409, 246);
            this.grpbx_addnewitem.TabIndex = 6;
            this.grpbx_addnewitem.TabStop = false;
            this.grpbx_addnewitem.Text = "Add New Item";
            // 
            // txtbx_add_password
            // 
            this.txtbx_add_password.Location = new System.Drawing.Point(124, 162);
            this.txtbx_add_password.Name = "txtbx_add_password";
            this.txtbx_add_password.Size = new System.Drawing.Size(204, 26);
            this.txtbx_add_password.TabIndex = 14;
            this.txtbx_add_password.UseSystemPasswordChar = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 165);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 18);
            this.label13.TabIndex = 13;
            this.label13.Text = "Password:";
            // 
            // bttn_add_add
            // 
            this.bttn_add_add.Location = new System.Drawing.Point(148, 194);
            this.bttn_add_add.Name = "bttn_add_add";
            this.bttn_add_add.Size = new System.Drawing.Size(75, 41);
            this.bttn_add_add.TabIndex = 12;
            this.bttn_add_add.Text = "Add";
            this.bttn_add_add.UseVisualStyleBackColor = true;
            this.bttn_add_add.Click += new System.EventHandler(this.bttn_add_add_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 18);
            this.label10.TabIndex = 3;
            this.label10.Text = "Username:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 18);
            this.label9.TabIndex = 2;
            this.label9.Text = "Quantity:";
            // 
            // txtbx_add_username
            // 
            this.txtbx_add_username.Location = new System.Drawing.Point(124, 130);
            this.txtbx_add_username.Name = "txtbx_add_username";
            this.txtbx_add_username.Size = new System.Drawing.Size(204, 26);
            this.txtbx_add_username.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "Amount:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Product Name:";
            // 
            // txtbx_add_quantity
            // 
            this.txtbx_add_quantity.Location = new System.Drawing.Point(124, 98);
            this.txtbx_add_quantity.Name = "txtbx_add_quantity";
            this.txtbx_add_quantity.Size = new System.Drawing.Size(204, 26);
            this.txtbx_add_quantity.TabIndex = 8;
            this.txtbx_add_quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_add_quantity_KeyPress);
            // 
            // txtbx_add_productname
            // 
            this.txtbx_add_productname.Location = new System.Drawing.Point(124, 34);
            this.txtbx_add_productname.Name = "txtbx_add_productname";
            this.txtbx_add_productname.Size = new System.Drawing.Size(204, 26);
            this.txtbx_add_productname.TabIndex = 6;
            // 
            // txtbx_add_amount
            // 
            this.txtbx_add_amount.Location = new System.Drawing.Point(124, 66);
            this.txtbx_add_amount.Name = "txtbx_add_amount";
            this.txtbx_add_amount.Size = new System.Drawing.Size(204, 26);
            this.txtbx_add_amount.TabIndex = 7;
            this.txtbx_add_amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_add_amount_KeyPress);
            // 
            // grpbx_updateitem
            // 
            this.grpbx_updateitem.Controls.Add(this.button1);
            this.grpbx_updateitem.Controls.Add(this.txtbx_update_password);
            this.grpbx_updateitem.Controls.Add(this.label14);
            this.grpbx_updateitem.Controls.Add(this.txtbx_update_lastname);
            this.grpbx_updateitem.Controls.Add(this.lbl_update_currentstock);
            this.grpbx_updateitem.Controls.Add(this.lbl_update_productname);
            this.grpbx_updateitem.Controls.Add(this.bttn_update_subtract);
            this.grpbx_updateitem.Controls.Add(this.bttn_update_add);
            this.grpbx_updateitem.Controls.Add(this.txtbx_update_firstame);
            this.grpbx_updateitem.Controls.Add(this.txtbx_update_username);
            this.grpbx_updateitem.Controls.Add(this.label6);
            this.grpbx_updateitem.Controls.Add(this.label5);
            this.grpbx_updateitem.Controls.Add(this.label4);
            this.grpbx_updateitem.Controls.Add(this.txtbx_update_addquantity);
            this.grpbx_updateitem.Controls.Add(this.label3);
            this.grpbx_updateitem.Controls.Add(this.label2);
            this.grpbx_updateitem.Controls.Add(this.label1);
            this.grpbx_updateitem.Location = new System.Drawing.Point(12, 68);
            this.grpbx_updateitem.Name = "grpbx_updateitem";
            this.grpbx_updateitem.Size = new System.Drawing.Size(409, 311);
            this.grpbx_updateitem.TabIndex = 5;
            this.grpbx_updateitem.TabStop = false;
            this.grpbx_updateitem.Text = "Update Item";
            // 
            // txtbx_update_password
            // 
            this.txtbx_update_password.Location = new System.Drawing.Point(121, 226);
            this.txtbx_update_password.Name = "txtbx_update_password";
            this.txtbx_update_password.Size = new System.Drawing.Size(207, 26);
            this.txtbx_update_password.TabIndex = 15;
            this.txtbx_update_password.UseSystemPasswordChar = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 229);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 18);
            this.label14.TabIndex = 14;
            this.label14.Text = "Password:";
            // 
            // txtbx_update_lastname
            // 
            this.txtbx_update_lastname.Location = new System.Drawing.Point(121, 194);
            this.txtbx_update_lastname.Name = "txtbx_update_lastname";
            this.txtbx_update_lastname.Size = new System.Drawing.Size(207, 26);
            this.txtbx_update_lastname.TabIndex = 5;
            // 
            // lbl_update_currentstock
            // 
            this.lbl_update_currentstock.AutoSize = true;
            this.lbl_update_currentstock.Location = new System.Drawing.Point(124, 69);
            this.lbl_update_currentstock.Name = "lbl_update_currentstock";
            this.lbl_update_currentstock.Size = new System.Drawing.Size(0, 18);
            this.lbl_update_currentstock.TabIndex = 13;
            // 
            // lbl_update_productname
            // 
            this.lbl_update_productname.AutoSize = true;
            this.lbl_update_productname.Location = new System.Drawing.Point(124, 34);
            this.lbl_update_productname.Name = "lbl_update_productname";
            this.lbl_update_productname.Size = new System.Drawing.Size(0, 18);
            this.lbl_update_productname.TabIndex = 12;
            // 
            // bttn_update_subtract
            // 
            this.bttn_update_subtract.Location = new System.Drawing.Point(179, 258);
            this.bttn_update_subtract.Name = "bttn_update_subtract";
            this.bttn_update_subtract.Size = new System.Drawing.Size(75, 41);
            this.bttn_update_subtract.TabIndex = 11;
            this.bttn_update_subtract.Text = "Subtract";
            this.bttn_update_subtract.UseVisualStyleBackColor = true;
            this.bttn_update_subtract.Click += new System.EventHandler(this.bttn_update_subtract_Click);
            // 
            // bttn_update_add
            // 
            this.bttn_update_add.Location = new System.Drawing.Point(93, 258);
            this.bttn_update_add.Name = "bttn_update_add";
            this.bttn_update_add.Size = new System.Drawing.Size(75, 41);
            this.bttn_update_add.TabIndex = 10;
            this.bttn_update_add.Text = "Add";
            this.bttn_update_add.UseVisualStyleBackColor = true;
            this.bttn_update_add.Click += new System.EventHandler(this.bttn_update_add_Click);
            // 
            // txtbx_update_firstame
            // 
            this.txtbx_update_firstame.Location = new System.Drawing.Point(121, 162);
            this.txtbx_update_firstame.Name = "txtbx_update_firstame";
            this.txtbx_update_firstame.Size = new System.Drawing.Size(207, 26);
            this.txtbx_update_firstame.TabIndex = 9;
            // 
            // txtbx_update_username
            // 
            this.txtbx_update_username.Location = new System.Drawing.Point(121, 130);
            this.txtbx_update_username.Name = "txtbx_update_username";
            this.txtbx_update_username.Size = new System.Drawing.Size(207, 26);
            this.txtbx_update_username.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Last Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Username:";
            // 
            // txtbx_update_addquantity
            // 
            this.txtbx_update_addquantity.Location = new System.Drawing.Point(121, 98);
            this.txtbx_update_addquantity.Name = "txtbx_update_addquantity";
            this.txtbx_update_addquantity.Size = new System.Drawing.Size(207, 26);
            this.txtbx_update_addquantity.TabIndex = 3;
            this.txtbx_update_addquantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_update_addquantity_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Quantity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Current Stock:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name:";
            // 
            // timer_sync
            // 
            this.timer_sync.AutoSize = true;
            this.timer_sync.Location = new System.Drawing.Point(12, 9);
            this.timer_sync.Name = "timer_sync";
            this.timer_sync.Size = new System.Drawing.Size(0, 18);
            this.timer_sync.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(226, 504);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 18);
            this.label17.TabIndex = 2;
            this.label17.Visible = false;
            // 
            // dtgrd_stocks
            // 
            this.dtgrd_stocks.AllowUserToAddRows = false;
            this.dtgrd_stocks.AllowUserToDeleteRows = false;
            this.dtgrd_stocks.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgrd_stocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrd_stocks.Location = new System.Drawing.Point(3, 40);
            this.dtgrd_stocks.Name = "dtgrd_stocks";
            this.dtgrd_stocks.ReadOnly = true;
            this.dtgrd_stocks.Size = new System.Drawing.Size(1450, 972);
            this.dtgrd_stocks.TabIndex = 1;
            this.dtgrd_stocks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrd_stocks_CellContentClick);
            // 
            // bttn_refresh
            // 
            this.bttn_refresh.Location = new System.Drawing.Point(3, 3);
            this.bttn_refresh.Name = "bttn_refresh";
            this.bttn_refresh.Size = new System.Drawing.Size(1450, 31);
            this.bttn_refresh.TabIndex = 0;
            this.bttn_refresh.Text = "Refresh";
            this.bttn_refresh.UseVisualStyleBackColor = true;
            this.bttn_refresh.Click += new System.EventHandler(this.bttn_refresh_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(253, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 16;
            this.button1.Text = "Check";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Employee_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Employee_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Viewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Employee_Form_FormClosing);
            this.Load += new System.EventHandler(this.Employee_Form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grpbx_gsm_module.ResumeLayout(false);
            this.grpbx_gsm_module.PerformLayout();
            this.grpbx_addnewitem.ResumeLayout(false);
            this.grpbx_addnewitem.PerformLayout();
            this.grpbx_updateitem.ResumeLayout(false);
            this.grpbx_updateitem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrd_stocks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aCTIONSToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button bttn_refresh;
        private System.Windows.Forms.DataGridView dtgrd_stocks;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Label timer_sync;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox grpbx_addnewitem;
        private System.Windows.Forms.TextBox txtbx_add_password;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button bttn_add_add;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtbx_add_username;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbx_add_quantity;
        private System.Windows.Forms.TextBox txtbx_add_productname;
        private System.Windows.Forms.TextBox txtbx_add_amount;
        private System.Windows.Forms.GroupBox grpbx_updateitem;
        private System.Windows.Forms.TextBox txtbx_update_password;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtbx_update_lastname;
        private System.Windows.Forms.Label lbl_update_currentstock;
        private System.Windows.Forms.Label lbl_update_productname;
        private System.Windows.Forms.Button bttn_update_subtract;
        private System.Windows.Forms.Button bttn_update_add;
        private System.Windows.Forms.TextBox txtbx_update_firstame;
        private System.Windows.Forms.TextBox txtbx_update_username;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbx_update_addquantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox grpbx_gsm_module;
        private System.Windows.Forms.Label lbl_admin_number;
        private System.Windows.Forms.Button bttn_applynumber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbobx_admin_name;
        private System.Windows.Forms.Label lbl_to_gsm;
        private System.Windows.Forms.Button button1;
    }
}