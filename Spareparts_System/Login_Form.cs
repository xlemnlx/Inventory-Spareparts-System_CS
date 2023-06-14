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
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            //things to load when the form is load

            //timer1.Start();
            //generatenewidnumber();
        }

        private void bttn_signup_Click(object sender, EventArgs e)
        {
            grpbx_addnewemployee.Visible = true;
            grpbx_signin_employee.Visible = false;
            grpbx_signin_admin.Visible = false;
            rdbttn_admin.Visible = false;
            rdbttn_employee.Visible = false;

            generatenewidnumber();
        }

        private void bttn_backtologin_Click(object sender, EventArgs e)
        {
            grpbx_addnewemployee.Visible = false;
            grpbx_signin_employee.Visible = true;
            grpbx_signin_admin.Visible = false;
            rdbttn_admin.Visible = true;
            rdbttn_employee.Visible = true;
        }

        private void rdbttn_employee_CheckedChanged(object sender, EventArgs e)
        {
            grpbx_signin_employee.Visible = true;
            grpbx_signin_admin.Visible = false;
            grpbx_addnewemployee.Visible = false;
        }

        private void rdbttn_admin_CheckedChanged(object sender, EventArgs e)
        {
            grpbx_signin_employee.Visible = false;
            grpbx_signin_admin.Visible = true;
            grpbx_addnewemployee.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime pcdatetime = DateTime.Now;
            timer_sync.Text = pcdatetime.ToString();
        }

        private void bttn_addnewemployee_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                 * this part is for inserting the values in the database.....
                 */
                string SQLConnect = "data source = localhost; database = spareparts_system; integrated security = true;";
                string Query = "Insert into accounts_employee (ID_Number, FName, LName, Position, username, password) values (@idnumber, @fname, @lname, @position, @username, @password);";
                SqlConnection SQLDatabase = new SqlConnection(SQLConnect);
                SqlCommand SQLCommand = new SqlCommand(Query, SQLDatabase);
                SQLDatabase.Open();

                SQLCommand.Parameters.AddWithValue("@idnumber", lbl_newidnumber.Text).ToString();
                SQLCommand.Parameters.AddWithValue("@fname", txtbx_addnewfirstname.Text).ToString();
                SQLCommand.Parameters.AddWithValue("@lname", txtbx_addnewlastname.Text).ToString();
                SQLCommand.Parameters.AddWithValue("@position", lbl_employee1.Text).ToString();
                SQLCommand.Parameters.AddWithValue("@username", txtbx_addnewusername.Text).ToString();
                SQLCommand.Parameters.AddWithValue("@password", txtbx_addnewpassword.Text).ToString();

                SQLCommand.ExecuteNonQuery();

                SQLDatabase.Close();

                MessageBox.Show("SAVED!");

                generatenewidnumber();

                txtbx_addnewfirstname.Text = null;
                txtbx_addnewlastname.Text = null;
                txtbx_addnewusername.Text = null;
                txtbx_addnewpassword.Text = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void generatenewidnumber()
        {
            try
            {
                /*
                 * this part is for determining the last id number in the database and will increment for the new employee....
                 */
                string SQLConnect = "data source = localhost; database = spareparts_system; integrated security = true;";
                string Query = "Select ID_Number from accounts_employee;";
                SqlConnection SQLDatabase = new SqlConnection(SQLConnect);
                SqlCommand SQLCommand = new SqlCommand(Query, SQLDatabase);

                SQLDatabase.Open();

                SqlDataReader SQLReader = SQLCommand.ExecuteReader();

                while (SQLReader.Read())
                {
                    lbl_oldidnumber.Text = SQLReader.GetValue(0).ToString();
                }

                SQLDatabase.Close();

                lbl_oldidnumber.Text = (int.Parse(lbl_oldidnumber.Text) + 1).ToString();

                lbl_newidnumber.Text = lbl_oldidnumber.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bttn_login_Click(object sender, EventArgs e)
        {
            try
            {
                string SQLConnect = "data source = localhost; database = spareparts_system; integrated security = true;";
                string Query = "select username, password from accounts_employee where username = @username and password = @password;";
                SqlConnection SQLDatabase = new SqlConnection(SQLConnect);
                SqlCommand SQLCommand = new SqlCommand(Query, SQLDatabase);
                SQLDatabase.Open();

                SQLCommand.Parameters.AddWithValue("@username", txtbx_username.Text).ToString();
                SQLCommand.Parameters.AddWithValue("@password", txtbx_password.Text).ToString();

                SqlDataReader SQLReader = SQLCommand.ExecuteReader();

                int count = 0;

                while (SQLReader.Read())
                {
                    count = count + 1;
                }

                if (count == 1)
                {
                    MessageBox.Show("Username and Password is CORRECT!");
                    Hide();
                    Employee_Form employee = new Employee_Form();
                    employee.Show();
                }

                else
                    MessageBox.Show("Username or Password is incorrect!");

                SQLDatabase.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bttn_login_admin_Click(object sender, EventArgs e)
        {
            try
            {
                string SQLConnect = "data source = localhost; database = spareparts_system; integrated security = true;";
                string Query = "select ID_Number, username, password from accounts_admin where ID_Number = @key and username = @username and password = @password;";
                SqlConnection SQLDatabase = new SqlConnection(SQLConnect);
                SqlCommand SQLCommand = new SqlCommand(Query, SQLDatabase);
                SQLDatabase.Open();

                SQLCommand.Parameters.AddWithValue("@key", txtbx_adminidnumber.Text).ToString();
                SQLCommand.Parameters.AddWithValue("@username", txtbx_adminusername.Text).ToString();
                SQLCommand.Parameters.AddWithValue("@password", txtbx_adminpassword.Text).ToString();

                SqlDataReader SQLReader = SQLCommand.ExecuteReader();

                int count = 0;

                while (SQLReader.Read())
                {
                    count = count + 1;
                }

                if (count == 1)
                {
                    MessageBox.Show("Username and Password is CORRECT!");
                    Hide();
                    Admin_Form admin = new Admin_Form();
                    admin.Show();
                }

                else
                    MessageBox.Show("Username or Password is incorrect!");

                SQLDatabase.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Login_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
