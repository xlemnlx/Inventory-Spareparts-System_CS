using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Spareparts_System
{
    public partial class Employee_Form : Form
    {
        public Employee_Form()
        {
            InitializeComponent();
        }

        void load_inventory_dbase_to_datagrid()
        {
            try
            {
                string SQLConnect = "data source = localhost; database = spareparts_system; integrated security = true;";
                string Query = "select * from stock_inventory;";
                SqlConnection SQLDatabase = new SqlConnection(SQLConnect);
                SqlCommand SQLCommand = new SqlCommand(Query, SQLDatabase);
                SQLDatabase.Open();

                SqlDataAdapter SQLAdapter = new SqlDataAdapter();
                SQLAdapter.SelectCommand = SQLCommand;
                DataTable SQLTable = new DataTable();
                SQLAdapter.Fill(SQLTable);
                BindingSource SQLBindSource = new BindingSource();

                SQLBindSource.DataSource = SQLTable;
                dtgrd_stocks.DataSource = SQLBindSource;
                SQLAdapter.Update(SQLTable);

                SQLDatabase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            dtgrd_stocks.Columns[0].HeaderText = "Product Name";
            dtgrd_stocks.Columns[1].HeaderText = "Amount";
            dtgrd_stocks.Columns[2].HeaderText = "Quantity";
            dtgrd_stocks.Columns[3].HeaderText = "Date Added";

        }

        void gsm_chan()
        {
            try
            {
                if (String.IsNullOrEmpty((string)lbl_update_currentstock.Text))
                {
                    //MessageBox.Show("no selected stock");
                }
                else if (int.Parse(lbl_update_currentstock.Text) <= 75)
                {
                    MessageBox.Show("please call for ambulance");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Employee_Form_Load(object sender, EventArgs e)
        {
            //things to load when the form is load

            timer1.Start();
            load_inventory_dbase_to_datagrid();
            fillcombo();
            display_default_gsmnumber_to_label();

            /*
             * gawa ka nlng ng void master para sa pag trigger ng gsm...
             * tapos call mo nalang dito para sa tuwing konti nalang ung stock,
             * kusang trigger na si gsm. :)
             * bali ang name ng label ng pagkukuhanan mo ng number master ay
             * "lbl_to_gsm" :)
             */

            gsm_chan();
        }

        private void Employee_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime pcdatetime = DateTime.Now;
            timer_sync.Text = pcdatetime.ToString();
        }

        private void bttn_refresh_Click(object sender, EventArgs e)
        {
            load_inventory_dbase_to_datagrid();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Log-Out?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Hide();
                Login_Form loginform = new Login_Form();
                loginform.Show();
            }
            else
            {
                Show();
            }
        }

        private void bttn_add_add_Click(object sender, EventArgs e)
        {
            login_add_admin();

            load_inventory_dbase_to_datagrid();

            txtbx_add_productname.Text = null;
            txtbx_add_amount.Text = null;
            txtbx_add_quantity.Text = null;
            txtbx_add_username.Text = null;
            txtbx_add_password.Text = null;
        }

        void login_add_admin()
        {
            string SQLConnect = "data source = localhost; database = spareparts_system; integrated security = true;";
            string Query = "select username, password from accounts_employee where username = @username and password = @password;";
            SqlConnection SQLDatabase = new SqlConnection(SQLConnect);
            SqlCommand SQLCommand = new SqlCommand(Query, SQLDatabase);
            SQLDatabase.Open();
            try
            {
                SQLCommand.Parameters.AddWithValue("@username", txtbx_add_username.Text).ToString();
                //SQLCommand.Parameters.AddWithValue("@fname", txtbx_add_firstname.Text).ToString();
                //SQLCommand.Parameters.AddWithValue("@lname", txtbx_add_lastname.Text).ToString();
                SQLCommand.Parameters.AddWithValue("@password", txtbx_add_password.Text).ToString();

                SqlDataReader SQLReader = SQLCommand.ExecuteReader();

                int count = 0;

                while (SQLReader.Read())
                {
                    count = count + 1;
                }

                if (count == 1)
                {
                    insert_to_invetory_dbase();

                    MessageBox.Show("SAVED!");
                    //label15.Text = txtbx_add_firstname.Text;
                    //label16.Text = txtbx_add_lastname.Text;
                }

                else
                {
                    MessageBox.Show("Username or Password is incorrect!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            SQLDatabase.Close();
        }

        void insert_to_invetory_dbase()
        {
            string SQLConnect = "data source = localhost; database = spareparts_system; integrated security = true;";
            string Query = "insert into stock_inventory (product_name, product_amount, product_quantity, product_date_added) values (@name, @amount, @quantity, @dateadded);";
            SqlConnection SQLDatabase = new SqlConnection(SQLConnect);
            SqlCommand SQLCommand = new SqlCommand(Query, SQLDatabase);
            SQLDatabase.Open();
            try
            {
                SQLCommand.Parameters.AddWithValue("@name", txtbx_add_productname.Text).ToString();
                SQLCommand.Parameters.AddWithValue("@amount", txtbx_add_amount.Text).ToString();
                SQLCommand.Parameters.AddWithValue("@quantity", txtbx_add_quantity.Text).ToString();
                SQLCommand.Parameters.AddWithValue("@dateadded", timer_sync.Text).ToString();

                SQLCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            SQLDatabase.Close();
        }

        private void dtgrd_stocks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow Row = dtgrd_stocks.Rows[e.RowIndex];

                    lbl_update_productname.Text = Row.Cells["product_name"].Value.ToString();
                    lbl_update_currentstock.Text = Row.Cells["product_quantity"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bttn_update_add_Click(object sender, EventArgs e)
        {
            label17.Text = (int.Parse(lbl_update_currentstock.Text) + int.Parse(txtbx_update_addquantity.Text)).ToString();

            login_updateadd_admin();
            
            load_inventory_dbase_to_datagrid();

            lbl_update_productname.Text = null;
            lbl_update_currentstock.Text = null;
            txtbx_update_addquantity.Text = null;
            txtbx_update_username.Text = null;
            txtbx_update_firstame.Text = null;
            txtbx_update_lastname.Text = null;
            txtbx_update_password.Text = null;
        }

        private void bttn_update_subtract_Click(object sender, EventArgs e)
        {
            label17.Text = (int.Parse(lbl_update_currentstock.Text) - int.Parse(txtbx_update_addquantity.Text)).ToString();

            login_updateadd_admin();
            
            load_inventory_dbase_to_datagrid();

            lbl_update_productname.Text = null;
            lbl_update_currentstock.Text = null;
            txtbx_update_addquantity.Text = null;
            txtbx_update_username.Text = null;
            txtbx_update_firstame.Text = null;
            txtbx_update_lastname.Text = null;
            txtbx_update_password.Text = null;
        }

        void login_updateadd_admin()
        {
            string SQLConnect = "data source = localhost; database = spareparts_system; integrated security = true;";
            string Query = "select FName, LName, username, password from accounts_employee where FName = @fname and LName = @lname and username = @username and password = @password;";
            SqlConnection SQLDatabase = new SqlConnection(SQLConnect);
            SqlCommand SQLCommand = new SqlCommand(Query, SQLDatabase);
            SQLDatabase.Open();
            try
            {
                SQLCommand.Parameters.AddWithValue("@username", txtbx_update_username.Text).ToString();
                SQLCommand.Parameters.AddWithValue("@fname", txtbx_update_firstame.Text).ToString();
                SQLCommand.Parameters.AddWithValue("@lname", txtbx_update_lastname.Text).ToString();
                SQLCommand.Parameters.AddWithValue("@password", txtbx_update_password.Text).ToString();

                SqlDataReader SQLReader = SQLCommand.ExecuteReader();

                int count = 0;

                while (SQLReader.Read())
                {
                    count = count + 1;
                }

                if (count == 1)
                {
                    insert_to_archive_dbase();
                    update_changed_inventory_dbase();
                    MessageBox.Show("UPDATED!");
                    //label15.Text = txtbx_update_firstame.Text;
                    //label16.Text = txtbx_update_lastname.Text;
                }

                else
                {
                    MessageBox.Show("Username or Password is incorrect!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            SQLDatabase.Close();
        }

        void insert_to_archive_dbase()
        {
            string SQLConnect = "data source = localhost; database = spareparts_system; integrated security = true;";
            string Query = "insert into stock_changes (product_name, product_quantity, date_of_change, fname_of_changer, lname_of_changer) values (@name, @quantity, @datechanged, @fname, @lname);";
            SqlConnection SQLDatabase = new SqlConnection(SQLConnect);
            SqlCommand SQLCommand = new SqlCommand(Query, SQLDatabase);
            SQLDatabase.Open();
            try
            {
                SQLCommand.Parameters.AddWithValue("@name", lbl_update_productname.Text).ToString();
                SQLCommand.Parameters.AddWithValue("@quantity", label17.Text).ToString();
                SQLCommand.Parameters.AddWithValue("@datechanged", timer_sync.Text).ToString();
                SQLCommand.Parameters.AddWithValue("@fname", txtbx_update_firstame.Text).ToString();
                SQLCommand.Parameters.AddWithValue("@lname", txtbx_update_lastname.Text).ToString();

                SQLCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            SQLDatabase.Close();
        }

        void update_changed_inventory_dbase()
        {
            string SQLConnect = "data source = localhost; database = spareparts_system; integrated security = true;";
            string Query = "update stock_inventory set product_quantity = @newquantity where product_name = @name and product_quantity = @oldquantity;";
            SqlConnection SQLDatabase = new SqlConnection(SQLConnect);
            SqlCommand SQLCommand = new SqlCommand(Query, SQLDatabase);
            SQLDatabase.Open();
            try
            {
                SQLCommand.Parameters.AddWithValue("@newquantity", label17.Text).ToString();
                SQLCommand.Parameters.AddWithValue("@name", lbl_update_productname.Text).ToString();
                SQLCommand.Parameters.AddWithValue("@oldquantity", lbl_update_currentstock.Text).ToString();

                SqlDataReader SQLReader = SQLCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            SQLDatabase.Close();
        }

        private void txtbx_update_addquantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch))
            {
                e.Handled = true;
            }
        }

        private void txtbx_add_quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch))
            {
                e.Handled = true;
            }
        }

        private void txtbx_add_amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch))
            {
                e.Handled = true;
            }
        }

        void fillcombo()
        {
            string SQLConnect = "data source = localhost; database = spareparts_system; integrated security = true;";
            string Query = "select * from accounts_admin;";
            SqlConnection SQLDatabase = new SqlConnection(SQLConnect);
            SqlCommand SQLCommand = new SqlCommand(Query, SQLDatabase);
            SQLDatabase.Open();
            try
            {
                SqlDataReader SQLReader = SQLCommand.ExecuteReader();

                while (SQLReader.Read())
                {
                    string admin_name = SQLReader.GetString(1);
                    cmbobx_admin_name.Items.Add(admin_name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            SQLDatabase.Close();
        }

        private void cmbobx_admin_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SQLConnect = "data source = localhost; database = spareparts_system; integrated security = true;";
            string Query = "select * from accounts_admin where FName = @name;";
            SqlConnection SQLDatabase = new SqlConnection(SQLConnect);
            SqlCommand SQLCommand = new SqlCommand(Query, SQLDatabase);
            SQLDatabase.Open();
            try
            {
                SQLCommand.Parameters.AddWithValue("@name", cmbobx_admin_name.Text).ToString();

                SqlDataReader SQLReader = SQLCommand.ExecuteReader();

                while (SQLReader.Read())
                {
                    string cellnumber = SQLReader.GetString(6);
                    lbl_admin_number.Text = cellnumber;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            SQLDatabase.Close();
        }

        private void bttn_applynumber_Click(object sender, EventArgs e)
        {
            apply_number_to_gsm();

            MessageBox.Show("SAVED!");
        }

        void apply_number_to_gsm()
        {
            string SQLConnect = "data source = localhost; database = spareparts_system; integrated security = true;";
            string Query = "update GSM_default_number set to_number = @number where admin = @admin";
            SqlConnection SQLDatabase = new SqlConnection(SQLConnect);
            SqlCommand SQLCommand = new SqlCommand(Query, SQLDatabase);
            SQLDatabase.Open();
            try
            {
                SQLCommand.Parameters.AddWithValue("@number", lbl_admin_number.Text).ToString();
                SQLCommand.Parameters.AddWithValue("@admin", label11.Text).ToString();

                SqlDataReader SQLReader = SQLCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void display_default_gsmnumber_to_label()
        {
            string SQLConnect = "data source = localhost; database = spareparts_system; integrated security = true;";
            string Query = "select * from GSM_default_number";
            SqlConnection SQLDatabase = new SqlConnection(SQLConnect);
            SqlCommand SQLCommand = new SqlCommand(Query, SQLDatabase);
            SQLDatabase.Open();
            try
            {
                SqlDataReader SQLReader = SQLCommand.ExecuteReader();

                while (SQLReader.Read())
                {
                    lbl_to_gsm.Text = SQLReader.GetValue(0).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }

        private void ExportToExcel()
        {
            //Creating Excel object.......
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            try
            {

                worksheet = workbook.ActiveSheet;

                worksheet.Name = "Spareparts Stocks";

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                //Loop... through each row and read the value from each column...
                for (int i = 0; i < dtgrd_stocks.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dtgrd_stocks.Columns.Count; j++)
                    {
                        //Excel index starts from (1,1). As first Row would have the Column headers, adding a condition check.
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dtgrd_stocks.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dtgrd_stocks.Rows[i].Cells[j].Value.ToString();
                        }
                        cellColumnIndex++;
                    }
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }

                //save location,.,.,.,.,.,.,.,.
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 2;

                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("Export Successful");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gsm_chan();
        }
    }
}
