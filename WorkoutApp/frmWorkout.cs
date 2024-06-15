using System.Data;
using System.Windows.Forms;

namespace WorkoutApp
{
    public partial class frmWorkout : Form
    {
        
        int _currentRecord = 0;
        DataTable dtWorkouts = new DataTable();
        private frmMDIParent _mdiParent;
        private int _rowsAffected;

        public frmWorkout()
        {
            InitializeComponent();
        }

        private void frmWorkout_Load(object sender, EventArgs e)
        {

            _mdiParent = this.MdiParent as frmMDIParent;

            dtWorkouts = GetWorkouts();

            NavigationBtnState();

            if (dtWorkouts.Rows.Count == 0)
            {
                NoRecordsAlert();
                return;
            }
            else
            {
                PopulateFormFields(_currentRecord);
                txtWorkoutTitle.ReadOnly = true;
                btnSave.Enabled = false;
                btnCancel.Enabled = false;
                SetBtnColor();
            }

        }

        public static DataTable GetWorkouts()
        {
            DataTable dt = new DataTable();
            try
            {
                
                string sqlQueryText = ("SELECT WorkoutID, WorkoutTitle FROM Workout ORDER BY WorkoutTitle;");
                dt = DataAccess.GetData(sqlQueryText);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
            return dt;
        }
        private void CreateWorkout()
        {
            try
            {
                string sqlQueryText =
                    @$"
                    INSERT INTO 
                        Workout (UserID, WorkoutTitle) 
                    VALUES ( 1, '{DataAccess.SQLFix(txtWorkoutTitle.Text)}');";

                sqlQueryText = DataAccess.SQLCleaner(sqlQueryText);
                _rowsAffected = DataAccess.SendData(sqlQueryText);

                DbInteractionFeedback("created");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void UpdateWorkout()
        {
            try
            {
                string sqlQueryText =
                 @$"
                    UPDATE Workout
                    SET 
	                    WorkoutTitle = '{DataAccess.SQLFix(txtWorkoutTitle.Text)}'
                    WHERE 
                       WorkoutID = {lblWorkoutIDDisplay.Text};
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
        private void DeleteWorkout()
        {
            try
            {
                string sqlQueryText = $"DELETE FROM Workout WHERE WorkoutID = {lblWorkoutIDDisplay.Text};";

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
                MessageBox.Show($"Workout {txtWorkoutTitle.Text} {message} successfully!");
            else
                MessageBox.Show("The DB reports no rows affected, please check the output with you DBAdmin.");
            return;
        }

        private void PopulateFormFields(int index)
        {
            lblWorkoutIDDisplay.Text = dtWorkouts.Rows[index]["WorkoutID"].ToString();
            txtWorkoutTitle.Text = dtWorkouts.Rows[index]["WorkoutTitle"].ToString();
            _mdiParent.UpdateToolStripStatusLabel($"Showing record {_currentRecord + 1} of {dtWorkouts.Rows.Count}");

            lblWorkoutIDDisplay.Visible = true;
        }

        private void ClearFormFields()
        {
            lblWorkoutIDDisplay.Visible = false;
            txtWorkoutTitle.Clear();
        }

        private void CRUDBtnState(bool enableState)
        {
            btnCreate.Enabled = enableState;
            btnUpdate.Enabled = enableState;
            btnDelete.Enabled = enableState;
        }

        private void NoRecordsAlert()
        {
            MessageBox.Show("There are no workouts to be displayed, please add a workout.");
            btnCreate_Click(this, EventArgs.Empty);
            
        }

        private void NavigationBtnState(bool toggleOff = false)
        {

            if (dtWorkouts.Rows.Count == 0 || dtWorkouts.Rows.Count == 1 || toggleOff == true)
            {
                btnPrevious.Enabled = false;
                btnFirst.Enabled = false;
                btnNext.Enabled = false;
                btnLast.Enabled = false;
            }
            else
            {
                if (_currentRecord == dtWorkouts.Rows.Count - 1)
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

            txtWorkoutTitle.ReadOnly = false;

            if (dtWorkouts.Rows.Count == 0)
                btnCancel.Enabled = false;
            else
                btnCancel.Enabled = true;

            btnSave.Enabled = true;
            btnSave.Text = "Save Workout";
            SetBtnColor();

            lblID.Visible = false;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _mdiParent.UpdateProgressBar();
            DeleteWorkout();
            dtWorkouts = GetWorkouts();

            if (_currentRecord >= dtWorkouts.Rows.Count)
                _currentRecord--;

            if (dtWorkouts.Rows.Count == 0)
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
            if (_currentRecord == dtWorkouts.Rows.Count - 1)
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
            _currentRecord = dtWorkouts.Rows.Count - 1;
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
            txtWorkoutTitle.ReadOnly = false;
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
                    txtWorkoutTitle.ReadOnly = true;
                    CRUDBtnState(true);
                    _mdiParent.UpdateProgressBar();


                    if (lblWorkoutIDDisplay.Visible == false)
                        CreateWorkout();
                        
                    else
                        UpdateWorkout();

                    _currentRecord = 0;
                    NavigationBtnState();
                    dtWorkouts = GetWorkouts();
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

        private void txtWorkoutTitle_Validating(object sender, System.ComponentModel.CancelEventArgs e)
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

        private void frmWorkout_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            PopulateFormFields(_currentRecord);
            txtWorkoutTitle.ReadOnly = true;
            CRUDBtnState(true);
            NavigationBtnState();

            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            SetBtnColor();


        }
        
    }
} 
