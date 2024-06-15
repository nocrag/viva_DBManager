using System;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WorkoutApp
{
    public partial class frmLogin : Form
    {
        private DataTable _usersTable;

        public frmLogin()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            _usersTable = GetUsers();
        }

        public static DataTable GetUsers()
        {
            DataTable dt = new DataTable();
            string connectionString = ConfigurationManager.ConnectionStrings["GymAppConnString"].ConnectionString;
            string sqlQueryText = "SELECT UserID, Username, Password FROM [User];";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(sqlQueryText, connection))
                {
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        dt.Load(reader);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while fetching user data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            return dt;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateChildren())
                {
                    string username = txtUsername.Text.Trim();
                    string password = txtPassword.Text.Trim();

                    bool isValidCredentials = CheckCredentials(username, password);

                    if (isValidCredentials)
                    {
                        frmMDIParent mainForm = new frmMDIParent();
                        mainForm.Show();
                        this.Hide(); // Hide the login form instead of closing it
                    }
                    else
                    {
                        MessageBox.Show("Wrong username and password or user does not exist.", "Invalid credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        private bool CheckCredentials(string username, string password)
        {
            foreach (DataRow row in _usersTable.Rows)
            {
                if (row["Username"].ToString() == username && row["Password"].ToString() == password)
                {
                    return true; // Username and password combination exists
                }
            }
            return false; // Username and password combination does not exist
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            string? txtBoxName = txt.Tag.ToString();
            string errMsg = string.Empty;
            bool failedValidation = false;

            if (txt.Text == string.Empty)
            {
                errMsg = $"{txtBoxName} is required";
                failedValidation = true;
            }

            e.Cancel = failedValidation;

            errorProvider.SetError(txt, errMsg);
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !(chkShowPassword.Checked);
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
    }
}
