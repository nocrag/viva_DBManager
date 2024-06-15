using System.Data;
using System.Windows.Forms;

namespace WorkoutApp
{
    public partial class frmExerciseMuscle : Form
    {
        DataTable dtExerciseMuscle = new DataTable();
        DataTable dtMuscle = new DataTable();
        DataTable dtExercise = new DataTable();
        private frmMDIParent _mdiParent;
        private int _currentRecord = 0;
        private int _selectedMuscleID;
        private int _selectedExerciseID;
        private int _initialMuscleID;
        private int _initialExerciseID;
        private int _rowsAffected;


        public frmExerciseMuscle()
        {
            InitializeComponent();
        }

        private void frmExerciseMuscle_Load(object sender, EventArgs e)
        {

            _mdiParent = this.MdiParent as frmMDIParent;

            dtExerciseMuscle = GetMuscleDetails();

            dtMuscle = frmMuscle.GetMuscles();
            dtExercise = frmExercise.GetExercises();

            NavigationBtnState();

            if (dtExerciseMuscle.Rows.Count == 0)
            {
                NoRecordsAlert();
                btnCreate_Click(this, EventArgs.Empty);
            }
            else
            {
                PopulateFormFields(_currentRecord);
                btnSave.Enabled = false;
                btnCancel.Enabled = false;
                SetBtnColor();
                cmbExerciseTitle.Enabled = false;
                cmbMuscleTitle.Enabled = false;
            }
            UIUtilities.FillListControl(cmbMuscleTitle, "MuscleTitle", "MuscleID", dtMuscle);
            UIUtilities.FillListControl(cmbExerciseTitle, "ExerciseTitle", "ExerciseID", dtExercise);
        }

        public static DataTable GetMuscleDetails()
        {
            DataTable dt = new DataTable();
            try
            {
                string sqlQueryText = (
                    @$"
                        SELECT
                            ExerciseMuscle.ExerciseID,
                            ExerciseTitle,
                            ExerciseMuscle.MuscleID,
                            MuscleTitle
                            FROM ExerciseMuscle 
                            INNER JOIN Exercise
                                ON ExerciseMuscle.ExerciseID = Exercise.ExerciseID
                            INNER JOIN Muscle 
                                ON ExerciseMuscle.MuscleID = Muscle.MuscleID 
                        ORDER BY 
                            ExerciseTitle ASC;
                     ");

                dt = DataAccess.GetData(sqlQueryText);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            return dt;
        }
        private void CreateExerciseMuscle()
        {
            try
            {
                string sqlQueryText =
                    @$"
                     INSERT INTO ExerciseMuscle(
	                    MuscleID, ExerciseID
                    ) VALUES (
	                    {_selectedMuscleID}, {_selectedExerciseID}
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
        //private void UpdateMuscle()
        //{
        //    try
        //    {
        //        string sqlQueryText =
        //         @$"
        //            UPDATE 
        //                MuscleExercise
        //            SET 
        //                MuscleID = {_selectedMuscleID},
        //                ExerciseID = {_selectedExerciseID}
        //           WHERE
        //                MuscleID = {_initialMuscleID} AND ExerciseID = {_initialExerciseID};
        //         ";

        //        sqlQueryText = DataAccess.SQLCleaner(sqlQueryText);

        //        _rowsAffected = DataAccess.SendData(sqlQueryText);

        //        DbInteractionFeedback("updated");
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message);
        //    }

        //}
        private void DeleteExerciseMuscle()
        {
            try
            {
                string sqlQueryText = $"DELETE FROM ExerciseMuscle WHERE MuscleID = {cmbMuscleTitle.SelectedValue};";

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
                MessageBox.Show($"Muscle {cmbMuscleTitle.SelectedValue} {message} successfully!");
            else
                MessageBox.Show("The DB reports no rows affected, please check the output with you DBAdmin.");
            return;
        }

        private void PopulateFormFields(int index)
        {
            lblMuscleID.Text = dtExerciseMuscle.Rows[index]["MuscleID"].ToString();
            lblExerciseID.Text = dtExerciseMuscle.Rows[index]["ExerciseID"].ToString();

            

            cmbMuscleTitle.SelectedValue = dtExerciseMuscle.Rows[index]["MuscleID"];
            cmbExerciseTitle.SelectedValue = dtExerciseMuscle.Rows[index]["ExerciseID"];

            _mdiParent.UpdateToolStripStatusLabel($"Showing record {_currentRecord + 1} of {dtExerciseMuscle.Rows.Count}");

        }

        private void ClearFormFields()
        {
            lblMuscleID.Visible = false;
            lblExerciseID.Visible = false;

            cmbMuscleTitle.SelectedIndex = -1;
            cmbExerciseTitle.SelectedIndex = -1;
        }

        private void CRUDBtnState(bool enableState)
        {
            btnCreate.Enabled = enableState;
            btnDelete.Enabled = enableState;
        }

        private void NoRecordsAlert()
        {
            MessageBox.Show("There are no Muscles to be displayed, please add a Muscle.");
            //this.Close();
        }

        private void NavigationBtnState(bool toggleOff = false)
        {

            if (dtExerciseMuscle.Rows.Count == 0 || dtExerciseMuscle.Rows.Count == 1 || toggleOff == true)
            {
                btnPrevious.Enabled = false;
                btnFirst.Enabled = false;
                btnNext.Enabled = false;
                btnLast.Enabled = false;
            }
            else
            {
                if (_currentRecord == dtExerciseMuscle.Rows.Count - 1)
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

            if (dtExerciseMuscle.Rows.Count == 0)
                btnCancel.Enabled = false;
            else
                btnCancel.Enabled = true;

            btnSave.Enabled = true;
            btnSave.Text = "Save Muscle";
            SetBtnColor();

            cmbExerciseTitle.Enabled = true;
            cmbMuscleTitle.Enabled = true;
            UIUtilities.FillListControl(cmbMuscleTitle, "MuscleTitle", "MuscleID", dtMuscle);
            UIUtilities.FillListControl(cmbExerciseTitle, "ExerciseTitle", "ExerciseID", dtExercise);
            ClearFormFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _mdiParent.UpdateProgressBar();
            DeleteExerciseMuscle();
            dtExerciseMuscle = GetMuscleDetails();

            if (_currentRecord >= dtExerciseMuscle.Rows.Count)
                _currentRecord--;

            if (dtExerciseMuscle.Rows.Count == 0)
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

            if (_currentRecord == dtExerciseMuscle.Rows.Count - 1)
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
            _currentRecord = dtExerciseMuscle.Rows.Count - 1;
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

        //private void btnUpdate_Click(object sender, EventArgs e)
        //{
        //    //txtMuscleTitle.ReadOnly = false;

        //    _initialExerciseID = (int)cmbExerciseTitle.SelectedValue;
        //    _initialMuscleID = (int)cmbMuscleTitle.SelectedValue;


        //    CRUDBtnState(false);
        //    NavigationBtnState(true);

        //    btnSave.Enabled = true;
        //    btnCancel.Enabled = true;

        //    cmbExerciseTitle.Enabled = true;
        //    cmbMuscleTitle.Enabled = true;

        //    btnSave.Text = "Save changes";
        //    SetBtnColor();


        //    UIUtilities.FillListControl(cmbMuscleTitle, "MuscleTitle", "MuscleID", dtMuscle);
        //    UIUtilities.FillListControl(cmbExerciseTitle, "ExerciseTitle", "ExerciseID", dtExercise);

        //    // Restore the initial selections
        //    cmbMuscleTitle.SelectedValue = _initialMuscleID;
        //    cmbExerciseTitle.SelectedValue = _initialExerciseID;
        //}

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    _mdiParent.UpdateProgressBar();

                    _selectedExerciseID = (int)cmbExerciseTitle.SelectedValue;
                    _selectedMuscleID = (int)cmbMuscleTitle.SelectedValue;
                    CreateExerciseMuscle();
                    dtExerciseMuscle = GetMuscleDetails();
                    _currentRecord = dtExerciseMuscle.Rows.Count - 1;
                    PopulateFormFields(_currentRecord);

                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;

                    CRUDBtnState(true);

                    NavigationBtnState();
                    SetBtnColor();

                    cmbMuscleTitle.Enabled = false;
                    cmbExerciseTitle.Enabled = false;

                    lblMuscleID.Visible = true;
                    lblExerciseID.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //private void txtMuscleTitle_Validating(object sender, System.ComponentModel.CancelEventArgs e)
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

        private void frmMuscle_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            PopulateFormFields(_currentRecord);

            CRUDBtnState(true);
            NavigationBtnState();

            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            SetBtnColor();

            cmbExerciseTitle.Enabled = false;
            cmbMuscleTitle.Enabled = false;

            lblMuscleID.Visible = true;
            lblExerciseID.Visible = true;
        }

        private void txtReps_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

    }
}
