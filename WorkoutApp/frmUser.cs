using System.Data;
using System.Windows.Forms;

namespace WorkoutApp
{
    public partial class frmUser : Form
    {

        int _currentRecord = 0;
        DataTable dtUsers = new DataTable();
        private frmMDIParent _mdiParent;
        private int _rowsAffected;

        public frmUser()
        {
            InitializeComponent();
        }
        private void frmUser_Load(object sender, EventArgs e)
        {

            _mdiParent = this.MdiParent as frmMDIParent;

            dtUsers = frmLogin.GetUsers();

            NavigationBtnState();

            if (dtUsers.Rows.Count == 0)
            {
                NoRecordsAlert();
                return;
            }
            else
            {
                PopulateFormFields(_currentRecord);
                txtUsername.ReadOnly = true;
                btnSave.Enabled = false;
                btnCancel.Enabled = false;
                SetBtnColor();
            }
        }

        private void CreateUser()
        {
            try
            {
                string sqlQueryText =
                    @$"
                    INSERT INTO 
                        [User] (Username, Password) 
                    VALUES 
                    (
                        '{DataAccess.SQLFix(txtUsername.Text)}', 
                        '{DataAccess.SQLFix(txtPassword.Text)}'
                    );";

                sqlQueryText = DataAccess.SQLCleaner(sqlQueryText);
                _rowsAffected = DataAccess.SendData(sqlQueryText);

                DbInteractionFeedback("created");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void UpdateUser()
        {
            try
            {
                string sqlQueryText =
                 @$"
                    UPDATE [User]
                    SET 
	                    Username = '{DataAccess.SQLFix(txtUsername.Text)}',
                        Password = '{DataAccess.SQLFix(txtPassword.Text)}'
                    WHERE 
                       UserID = {lblUserID.Text};
                 ";

                sqlQueryText = DataAccess.SQLCleaner(sqlQueryText);

                _rowsAffected = DataAccess.SendData(sqlQueryText);

                DbInteractionFeedback("updated");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void DeleteUser()
        {
            try
            {
                string sqlQueryText = $"DELETE FROM [User] WHERE UserID = {lblUserID.Text};";

                sqlQueryText = DataAccess.SQLCleaner(sqlQueryText);

                _rowsAffected = DataAccess.SendData(sqlQueryText);

                DbInteractionFeedback("deleted");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void DbInteractionFeedback(string message)
        {
            if (_rowsAffected == 1)
                MessageBox.Show($"User with username {txtUsername.Text} {message} successfully!");
            else
                MessageBox.Show("The DB reports no rows affected, please check the output with you DBAdmin.");
            return;
        }

        private void PopulateFormFields(int index)
        {
            lblUserID.Text = dtUsers.Rows[index]["UserID"].ToString();
            txtUsername.Text = dtUsers.Rows[index]["Username"].ToString();
            txtPassword.Text = dtUsers.Rows[index]["Password"].ToString();
            _mdiParent.UpdateToolStripStatusLabel($"Showing record {_currentRecord + 1} of {dtUsers.Rows.Count}");

            lblUserID.Visible = true;
        }

        private void ClearFormFields()
        {
            lblUserID.Visible = false;
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void CRUDBtnState(bool enableState)
        {
            btnCreate.Enabled = enableState;
            btnUpdate.Enabled = enableState;
            btnDelete.Enabled = enableState;
        }

        private void NoRecordsAlert()
        {
            MessageBox.Show("There are no users to be displayed, please add a user.");
            btnCreate_Click(this, EventArgs.Empty);

        }

        private void NavigationBtnState(bool toggleOff = false)
        {

            if (dtUsers.Rows.Count == 0 || dtUsers.Rows.Count == 1 || toggleOff == true)
            {
                btnPrevious.Enabled = false;
                btnFirst.Enabled = false;
                btnNext.Enabled = false;
                btnLast.Enabled = false;
            }
            else
            {
                if (_currentRecord == dtUsers.Rows.Count - 1)
                {
                    btnPrevious.Enabled = true;
                    btnFirst.Enabled = true;
                    btnNext.Enabled = false;
                    btnLast.Enabled = false;
                }
                else if (_currentRecord == 0)
                {
                    btnPrevious.Enabled = false;
                    btnFirst.Enabled = false;
                    btnNext.Enabled = true;
                    btnLast.Enabled = true;
                }
                else
                {
                    btnPrevious.Enabled = true;
                    btnFirst.Enabled = true;
                    btnNext.Enabled = true;
                    btnLast.Enabled = true;
                }
            }
        }

        private void SetBtnColor()
        {
            UIUtilities.BtnColorChange(66, 135, 245, btnNext,
                btnLast, btnPrevious, btnFirst, btnCreate, btnUpdate, btnCancel);

            UIUtilities.BtnColorChange(224, 63, 27, btnDelete);

            UIUtilities.BtnColorChange(34, 139, 34, btnSave);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            ClearFormFields();
            CRUDBtnState(false);
            NavigationBtnState(true);

            txtUsername.ReadOnly = false;
            txtPassword.ReadOnly = false;

            if (dtUsers.Rows.Count == 0)
                btnCancel.Enabled = false;
            else
                btnCancel.Enabled = true;

            btnSave.Enabled = true;
            btnSave.Text = "Save user";
            SetBtnColor();

            lblID.Visible = false;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _mdiParent.UpdateProgressBar();
            DeleteUser();
            dtUsers = frmLogin.GetUsers();

            if (_currentRecord >= dtUsers.Rows.Count)
                _currentRecord--;

            if (dtUsers.Rows.Count == 0)
            {
                NoRecordsAlert();
                return;
            }

            PopulateFormFields(_currentRecord);
            NavigationBtnState();
            SetBtnColor();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _currentRecord++;
            if (_currentRecord == dtUsers.Rows.Count - 1)
            {
                _mdiParent.UpdateToolStripStatusLabel("Showing last record.");

                NavigationBtnState();
                PopulateFormFields(_currentRecord);
                SetBtnColor();
            }
            else
            {
                PopulateFormFields(_currentRecord);
                NavigationBtnState();
                SetBtnColor();
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            _currentRecord = dtUsers.Rows.Count - 1;
            PopulateFormFields(_currentRecord);

            _mdiParent.UpdateToolStripStatusLabel("Showing last record.");

            NavigationBtnState();
            SetBtnColor();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            _currentRecord = 0;
            PopulateFormFields(_currentRecord);
            _mdiParent.UpdateToolStripStatusLabel("Showing first record.");
            NavigationBtnState();
            SetBtnColor();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            _currentRecord--;
            if (_currentRecord == 0)
            {
                _mdiParent.UpdateToolStripStatusLabel("Showing first record.");
                NavigationBtnState();
                PopulateFormFields(_currentRecord);
                SetBtnColor();
            }
            else
            {
                PopulateFormFields(_currentRecord);
                NavigationBtnState();
                SetBtnColor();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtUsername.ReadOnly = false;
            txtPassword.ReadOnly = false;
            CRUDBtnState(false);
            NavigationBtnState(true);

            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            btnSave.Text = "Save changes";
            SetBtnColor();


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    txtUsername.ReadOnly = true;
                    txtPassword.ReadOnly = true;
                    txtPassword.UseSystemPasswordChar = true;
                    CRUDBtnState(true);
                    _mdiParent.UpdateProgressBar();


                    if (lblUserID.Visible == false)
                        CreateUser();

                    else
                        UpdateUser();

                    _currentRecord = 0;
                    NavigationBtnState();
                    dtUsers = frmLogin.GetUsers();
                    PopulateFormFields(_currentRecord);
                    SetBtnColor();
                    lblID.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            PopulateFormFields(_currentRecord);
            txtUsername.ReadOnly = true;
            txtPassword.UseSystemPasswordChar= true;
            CRUDBtnState(true);
            NavigationBtnState();

            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            SetBtnColor();
        }

        private void txt_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            string? txtBoxName = txt.Tag.ToString();
            string errMsg = string.Empty;
            bool failedValidation = false;

            if (txt.Text.Trim() == string.Empty)
            {
                errMsg = $"{txtBoxName} is required";
                failedValidation = true;
            }

            e.Cancel = failedValidation;

            errorProvider.SetError(txt, errMsg);
        }

        private void frmUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;

        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !(chkShowPassword.Checked);
        }
    }
}
