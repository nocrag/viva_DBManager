using System.Data;
using System.Windows.Forms;

namespace WorkoutApp
{
    public partial class frmMuscle : Form
    {

        int _currentRecord = 0;
        DataTable dtMuscles = new DataTable();
        private frmMDIParent _mdiParent;
        private int _rowsAffected;

        public frmMuscle()
        {
            InitializeComponent();
        }

        private void frmMuscle_Load(object sender, EventArgs e)
        {

            _mdiParent = this.MdiParent as frmMDIParent;

            dtMuscles = GetMuscles();

            NavigationBtnState();

            if (dtMuscles.Rows.Count == 0)
            {
                NoRecordsAlert();
                return;
            }
            else
            {
                PopulateFormFields(_currentRecord);
                txtMuscleTitle.ReadOnly = true;
                btnSave.Enabled = false;
                btnCancel.Enabled = false;
                SetBtnColor();
            }

        }

        public static DataTable GetMuscles()
        {
            DataTable dt = new DataTable();
            try
            {
                string sqlQueryText = ("SELECT MuscleID, MuscleTitle FROM Muscle;");

                dt = DataAccess.GetData(sqlQueryText);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dt;
        }
        private void CreateMuscle()
        {
            try
            {
                string sqlQueryText =
                    @$"
                    INSERT INTO 
                        Muscle (MuscleTitle) 
                    VALUES 
                    (
                        '{DataAccess.SQLFix(txtMuscleTitle.Text)}'
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
        private void UpdateMuscle()
        {
            try
            {
                string sqlQueryText =
                 @$"
                    UPDATE Muscle
                    SET 
	                    MuscleTitle = '{DataAccess.SQLFix(txtMuscleTitle.Text)}'
                    WHERE 
                       MuscleID = {lblID.Text};
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
        private void DeleteMuscle()
        {
            try
            {
                string sqlQueryText = $"DELETE FROM Muscle WHERE MuscleID = {lblID.Text};";

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
                MessageBox.Show($"Muscle {txtMuscleTitle.Text} {message} successfully!");
            else
                MessageBox.Show("The DB reports no rows affected, please check the output with you DBAdmin.");
            return;
        }

        private void PopulateFormFields(int index)
        {
            lblID.Text = dtMuscles.Rows[index]["MuscleID"].ToString();
            txtMuscleTitle.Text = dtMuscles.Rows[index]["MuscleTitle"].ToString();
            _mdiParent.UpdateToolStripStatusLabel($"Showing record {_currentRecord + 1} of {dtMuscles.Rows.Count}");
        }

        private void ClearFormFields()
        {
            lblID.Visible = false;
            txtMuscleTitle.Clear();
        }

        private void CRUDBtnState(bool enableState)
        {
            btnCreate.Enabled = enableState;
            btnUpdate.Enabled = enableState;
            btnDelete.Enabled = enableState;
        }

        private void NoRecordsAlert()
        {
            MessageBox.Show("There are no muscles to be displayed, please add a Muscle.");
            btnCreate_Click(this, EventArgs.Empty);

        }

        private void NavigationBtnState(bool toggleOff = false)
        {

            if (dtMuscles.Rows.Count == 0 || dtMuscles.Rows.Count == 1 || toggleOff == true)
            {
                btnPrevious.Enabled = false;
                btnFirst.Enabled = false;
                btnNext.Enabled = false;
                btnLast.Enabled = false;
            }
            else
            {
                if (_currentRecord == dtMuscles.Rows.Count - 1)
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

            txtMuscleTitle.ReadOnly = false;

            if (dtMuscles.Rows.Count == 0)
                btnCancel.Enabled = false;
            else
                btnCancel.Enabled = true;

            btnSave.Enabled = true;
            btnSave.Text = "Save Muscle";
            SetBtnColor();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _mdiParent.UpdateProgressBar();
            DeleteMuscle();
            dtMuscles = GetMuscles();

            if (_currentRecord >= dtMuscles.Rows.Count)
                _currentRecord--;

            if (dtMuscles.Rows.Count == 0)
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
            if (_currentRecord == dtMuscles.Rows.Count - 1)
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
            _currentRecord = dtMuscles.Rows.Count - 1;
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
            txtMuscleTitle.ReadOnly = false;
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
                    _mdiParent.UpdateProgressBar();
                    if (lblID.Visible == false)
                    {
                        CreateMuscle();
                        dtMuscles = GetMuscles();
                        _currentRecord = dtMuscles.Rows.Count - 1;
                    }
                    else
                    {
                        UpdateMuscle();
                    }
                    dtMuscles = GetMuscles();

                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    PopulateFormFields(_currentRecord);
                    txtMuscleTitle.ReadOnly = true;


                    CRUDBtnState(true);

                    NavigationBtnState();
                    SetBtnColor();
                   lblID.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtMuscleTitle_Validating(object sender, System.ComponentModel.CancelEventArgs e)
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

        private void frmMuscle_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            PopulateFormFields(_currentRecord);
            txtMuscleTitle.ReadOnly = true;
            CRUDBtnState(true);
            NavigationBtnState();

            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            SetBtnColor();


        }
    }
}
