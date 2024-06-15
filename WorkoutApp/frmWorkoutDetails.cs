using System;
using System.Data;
using System.Windows.Forms;

namespace WorkoutApp
{
    public partial class frmWorkoutDetails : Form
    {
        DataTable dtWorkoutDetails = new DataTable();
        DataTable dtWorkout = new DataTable();
        DataTable dtExercise = new DataTable();
        private frmMDIParent _mdiParent;
        private int _currentRecord = 0;
        private int _selectedWorkoutID;
        private int _selectedExerciseID;
        private int _initialWorkoutID;
        private int _initialExerciseID;
        private int _rowsAffected;


        public frmWorkoutDetails()
        {
            InitializeComponent();
        }

        private void frmWorkoutExercises_Load(object sender, EventArgs e)
        {

            _mdiParent = this.MdiParent as frmMDIParent;

            dtWorkoutDetails = GetWorkoutDetails();

            dtWorkout = frmWorkout.GetWorkouts();
            dtExercise = frmExercise.GetExercises();

            NavigationBtnState();

            if (dtWorkoutDetails.Rows.Count == 0)
            {
                NoRecordsAlert();
                btnCreate_Click(this, EventArgs.Empty);
            }
            else
            {
                PopulateFormFields(_currentRecord);
                txtReps.ReadOnly = true;
                txtSets.ReadOnly = true;
                txtWeight.ReadOnly = true;
                btnSave.Enabled = false;
                btnCancel.Enabled = false;
                SetBtnColor();
                cmbWorkoutTitle.Enabled = false;
                cmbExerciseTitle.Enabled = false;
            }

            UIUtilities.FillListControl(cmbWorkoutTitle, "WorkoutTitle", "WorkoutID", dtWorkout);
            UIUtilities.FillListControl(cmbExerciseTitle, "ExerciseTitle", "ExerciseID", dtExercise);
        }

        public static DataTable GetWorkoutDetails()
        {
            DataTable dt = new DataTable();
            try
            {
                string sqlQueryText = (
                    @$"
                        SELECT 
                            Workout.WorkoutID,
                            WorkoutTitle,
                            Exercise.ExerciseID,
                            ExerciseTitle,
	                        ExerciseDescription,
	                        ExerciseInstructions,
                            ExerciseWeight,
                            ExerciseSets,
                            ExercisesReps
                        FROM 
                            Workout INNER JOIN WorkoutExercise
                                ON Workout.WorkoutID = WorkoutExercise.WorkoutID 
                            INNER JOIN Exercise
                                ON WorkoutExercise.ExerciseID = Exercise.ExerciseID
                        ORDER BY WorkoutTitle ASC;
                     ");

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
                     INSERT INTO WorkoutExercise(
	                    WorkoutID, ExerciseID, ExerciseWeight,
	                    ExerciseSets, ExercisesReps
                    ) VALUES (
	                    {_selectedWorkoutID}, {_selectedExerciseID}, {txtWeight.Text},
                        {txtSets.Text}, {txtReps.Text}
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
        private void UpdateWorkout()
        {
            try
            {
                string sqlQueryText =
                 @$"
                    UPDATE 
                        WorkoutExercise
                    SET 
                        WorkoutID = {_selectedWorkoutID},
                        ExerciseID = {_selectedExerciseID},
	                    ExerciseWeight = {txtWeight.Text},
	                    ExerciseSets = {txtSets.Text},
	                    ExercisesReps = {txtReps.Text}
                   WHERE
                        WorkoutID = {_initialWorkoutID} AND ExerciseID = {_initialExerciseID};
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
                string sqlQueryText = $"DELETE FROM WorkoutExercise WHERE WorkoutID = {cmbWorkoutTitle.SelectedValue};";

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
                MessageBox.Show($"Workout {cmbWorkoutTitle.SelectedValue} {message} successfully!");
            else
                MessageBox.Show("The DB reports no rows affected, please check the output with you DBAdmin.");
            return;
        }

        private void PopulateFormFields(int index)
        {


            lblWorkoutID.Text = dtWorkoutDetails.Rows[index]["WorkoutID"].ToString();
            lblExerciseID.Text = dtWorkoutDetails.Rows[index]["ExerciseID"].ToString();

            cmbWorkoutTitle.SelectedValue = dtWorkoutDetails.Rows[index]["WorkoutID"];
            cmbExerciseTitle.SelectedValue = dtWorkoutDetails.Rows[index]["ExerciseID"];

            txtReps.Text = dtWorkoutDetails.Rows[index]["ExercisesReps"].ToString();
            txtSets.Text = dtWorkoutDetails.Rows[index]["ExerciseSets"].ToString();
            txtWeight.Text = dtWorkoutDetails.Rows[index]["ExerciseWeight"].ToString();

            _mdiParent.UpdateToolStripStatusLabel($"Showing record {_currentRecord + 1} of {dtWorkoutDetails.Rows.Count}");

        }

        private void ClearFormFields()
        {
            lblWorkoutID.Visible = false;
            lblExerciseID.Visible = false;

            txtReps.Clear();
            txtSets.Clear();
            txtWeight.Clear();

            cmbWorkoutTitle.SelectedIndex = -1;
            cmbExerciseTitle.SelectedIndex = -1;
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
            //this.Close();
        }

        private void NavigationBtnState(bool toggleOff = false)
        {

            if (dtWorkoutDetails.Rows.Count == 0 || dtWorkoutDetails.Rows.Count == 1 || toggleOff == true)
            {
                btnPrevious.Enabled = false;
                btnFirst.Enabled = false;
                btnNext.Enabled = false;
                btnLast.Enabled = false;
            }
            else
            {
                if (_currentRecord == dtWorkoutDetails.Rows.Count - 1)
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
            CRUDBtnState(false);
            NavigationBtnState(true);

            txtReps.ReadOnly = false;
            txtSets.ReadOnly = false;
            txtWeight.ReadOnly = false;

            if (dtWorkoutDetails.Rows.Count == 0)
                btnCancel.Enabled = false;
            else
                btnCancel.Enabled = true;

            btnSave.Enabled = true;
            btnSave.Text = "Save Workout";
            SetBtnColor();

            cmbExerciseTitle.Enabled = true;
            cmbWorkoutTitle.Enabled = true;
            UIUtilities.FillListControl(cmbWorkoutTitle, "WorkoutTitle", "WorkoutID", dtWorkout);
            UIUtilities.FillListControl(cmbExerciseTitle, "ExerciseTitle", "ExerciseID", dtExercise);
            ClearFormFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _mdiParent.UpdateProgressBar();
            DeleteWorkout();
            dtWorkoutDetails = GetWorkoutDetails();

            if (_currentRecord >= dtWorkoutDetails.Rows.Count)
                _currentRecord--;

            if (dtWorkoutDetails.Rows.Count == 0)
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

            if (_currentRecord == dtWorkoutDetails.Rows.Count - 1)
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
            _currentRecord = dtWorkoutDetails.Rows.Count - 1;
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

            _initialExerciseID = (int)cmbExerciseTitle.SelectedValue;
            _initialWorkoutID = (int)cmbWorkoutTitle.SelectedValue;

            txtReps.ReadOnly = false;
            txtSets.ReadOnly = false;
            txtWeight.ReadOnly = false;

            CRUDBtnState(false);
            NavigationBtnState(true);

            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            cmbExerciseTitle.Enabled = true;
            cmbWorkoutTitle.Enabled = true;

            btnSave.Text = "Save changes";
            SetBtnColor();


            UIUtilities.FillListControl(cmbWorkoutTitle, "WorkoutTitle", "WorkoutID", dtWorkout);
            UIUtilities.FillListControl(cmbExerciseTitle, "ExerciseTitle", "ExerciseID", dtExercise);

            cmbWorkoutTitle.SelectedValue = _initialWorkoutID;
            cmbExerciseTitle.SelectedValue = _initialExerciseID;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    _mdiParent.UpdateProgressBar();
                    if (lblWorkoutID.Visible == false)
                    {
                        _selectedExerciseID = (int)cmbExerciseTitle.SelectedValue;
                        _selectedWorkoutID = (int)cmbWorkoutTitle.SelectedValue;
                        CreateWorkout();
                        dtWorkoutDetails = GetWorkoutDetails();
                        _currentRecord = dtWorkoutDetails.Rows.Count - 1;
                        PopulateFormFields(_currentRecord);
                    }
                    else
                    {
                        _selectedExerciseID = (int)cmbExerciseTitle.SelectedValue;
                        _selectedWorkoutID = (int)cmbWorkoutTitle.SelectedValue;
                        UpdateWorkout();
                        dtWorkoutDetails = GetWorkoutDetails();
                        PopulateFormFields(_currentRecord);
                    }

                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;

                    txtReps.ReadOnly = true;
                    txtSets.ReadOnly = true;
                    txtWeight.ReadOnly = true;


                    CRUDBtnState(true);

                    NavigationBtnState();
                    SetBtnColor();

                    cmbWorkoutTitle.Enabled = false;
                    cmbExerciseTitle.Enabled = false;

                    lblWorkoutID.Visible = true;
                    lblExerciseID.Visible = true;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //private void txtWorkoutTitle_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    TextBox txt = (TextBox)sender;
        //    string? txtBoxName = txt.Tag.ToString();
        //    string errMsg = string.Empty;
        //    bool failedValidation = false;

        //    if (txt.Text == string.Empty)
        //    {
        //        errMsg = $"{txtBoxName} is required";
        //        failedValidation = true;
        //    }

        //    e.Cancel = failedValidation;

        //    errorProvider.SetError(txt, errMsg);
        //}

        private void frmWorkout_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            PopulateFormFields(_currentRecord);

            txtReps.ReadOnly = true;
            txtSets.ReadOnly = true;
            txtWeight.ReadOnly = true;

            CRUDBtnState(true);
            NavigationBtnState();

            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            SetBtnColor();

            cmbExerciseTitle.Enabled = false;
            cmbWorkoutTitle.Enabled = false;

            lblWorkoutID.Visible = true;
            lblExerciseID.Visible = true;
        }

        private void txtReps_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

    }
}
