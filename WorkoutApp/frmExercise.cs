using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkoutApp
{
    public partial class frmExercise : Form
    {
        private int _currentRecord = 0;
        DataTable dtExercises;
        private frmMDIParent _mdiParent;
        private int _rowsAffected;
        private string _exerciseTitle;
        private string _exerciseDescription;
        private string _exerciseInstruction;
        public frmExercise()
        {
            InitializeComponent();
        }

        private void frmExercise_Load(object sender, EventArgs e)
        {
            _mdiParent = this.MdiParent as frmMDIParent;

            dtExercises = GetExercises();

            if (dtExercises.Rows.Count == 0)
            {
                NoRecordsAlert();
                return;
            }
            else
            {
                PopulateFormFields(_currentRecord);
                txtExerciseTitle.Enabled = false;
                txtExerciseDescription.Enabled = false;
                txtExerciseInstructions.Enabled = false;
                btnSave.Enabled = false;
                btnCancel.Enabled = false;
                SetBtnColor();
            }

            NavigationBtnState();
        }

        public static DataTable GetExercises()
        {
            DataTable dt = new DataTable();
            try
            {
                string sqlQueryText =
                @"
                 SELECT 
                    ExerciseID, ExerciseTitle, 
                    ExerciseDescription, ExerciseInstructions 
                FROM Exercise
                ORDER BY ExerciseTitle ASC;";

                dt = DataAccess.GetData(sqlQueryText);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        private void CreateExercise()
        {
            try
            {
                string sqlQueryText =
                @$"
                    INSERT INTO 
                    Exercise 
                        (ExerciseTitle, ExerciseDescription, ExerciseInstructions)
                    VALUES
                    (
                        '{DataAccess.SQLFix(_exerciseTitle)}', 
                        '{DataAccess.SQLFix(_exerciseDescription)}', 
                        '{DataAccess.SQLFix(_exerciseInstruction)}'
                    );";

                _rowsAffected = DataAccess.SendData(sqlQueryText);

                DbInteractionFeedback("created");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void UpdateExercise()
        {
            try
            {
                string sqlQueryText =
               @$"
                UPDATE Exercise
                 SET 
                     ExerciseTitle = '{DataAccess.SQLFix(_exerciseTitle)}', 
                     ExerciseDescription = '{DataAccess.SQLFix(_exerciseDescription)}', 
                     ExerciseInstructions = '{DataAccess.SQLFix(txtExerciseInstructions.Text)}'
                 WHERE 
                    ExerciseID = {lblExerciseID.Text};";

                sqlQueryText = DataAccess.SQLCleaner(sqlQueryText);

                _rowsAffected = DataAccess.SendData(sqlQueryText);

                DbInteractionFeedback("updated");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void DeleteExercise()
        {
            try
            {
                string sqlQueryText = $"DELETE FROM Exercise WHERE ExerciseID = {lblExerciseID.Text};";

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
                MessageBox.Show($"Exercise {_exerciseTitle} {message} successfully!");
            else
                MessageBox.Show("The DB reports no rows affected, please check the output with you DBAdmin.");
            return;
        }

        private void PopulateFormFields(int index)
        {
            lblExerciseID.Text = dtExercises.Rows[index]["ExerciseID"].ToString();
            _exerciseTitle = dtExercises.Rows[index]["ExerciseTitle"].ToString();
            _exerciseDescription = dtExercises.Rows[index]["ExerciseDescription"].ToString();
            _exerciseInstruction = dtExercises.Rows[index]["ExerciseInstructions"].ToString();

            _mdiParent.UpdateToolStripStatusLabel($"Showing record {_currentRecord + 1} of {dtExercises.Rows.Count}");

            lblExerciseID.Visible = true;

            txtExerciseTitle.Text = _exerciseTitle;
            txtExerciseDescription.Text = _exerciseDescription;
            txtExerciseInstructions.Text = _exerciseInstruction;
        }
        private void ClearFormFields()
        {
            txtExerciseTitle.Clear();
            txtExerciseDescription.Clear();
            txtExerciseInstructions.Clear();
            lblExerciseID.Visible = false;
        }

        private void CRUDBtnState(bool enableState)
        {
            btnCreate.Enabled = enableState;
            btnUpdate.Enabled = enableState;
            btnDelete.Enabled = enableState;
        }

        private void NoRecordsAlert()
        {
            MessageBox.Show("There are no exercises to be displayed, please add an exercise.");
            btnCreate_Click(this, EventArgs.Empty);

        }

        private void NavigationBtnState(bool toggleOff = false)
        {

            if (dtExercises.Rows.Count == 0 || dtExercises.Rows.Count == 1 || toggleOff == true)
            {
                btnPrevious.Enabled = false;
                btnFirst.Enabled = false;
                btnNext.Enabled = false;
                btnLast.Enabled = false;
            }
            else
            {
                if (_currentRecord == dtExercises.Rows.Count - 1)
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

            txtExerciseTitle.Enabled = true;
            txtExerciseDescription.Enabled = true;
            txtExerciseInstructions.Enabled = true;

            if (dtExercises.Rows.Count == 0)
                btnCancel.Enabled = false;
            else
                btnCancel.Enabled = true;

            btnSave.Enabled = true;
            btnSave.Text = "Save Exercise";

            SetBtnColor();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _mdiParent.UpdateProgressBar();
            DeleteExercise();
            dtExercises = GetExercises();

            if (_currentRecord >= dtExercises.Rows.Count)
                _currentRecord--;

            if (dtExercises.Rows.Count == 0)
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
            if (_currentRecord == dtExercises.Rows.Count - 1)
            {
                _mdiParent.UpdateToolStripStatusLabel("Showing last record.");

                NavigationBtnState();
                SetBtnColor();
                PopulateFormFields(_currentRecord);

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

            _currentRecord = dtExercises.Rows.Count - 1;
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
            txtExerciseTitle.Enabled = true;
            txtExerciseDescription.Enabled = true;
            txtExerciseInstructions.Enabled = true;
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
                    txtExerciseTitle.Enabled = false;
                    txtExerciseDescription.Enabled = false;
                    txtExerciseInstructions.Enabled = false;
                    CRUDBtnState(true);
                    _mdiParent.UpdateProgressBar();

                    if (lblExerciseID.Visible == false)
                        CreateExercise();
                    else
                        UpdateExercise();

                    _currentRecord = 0;
                    NavigationBtnState();
                    dtExercises = GetExercises();
                    PopulateFormFields(_currentRecord);
                    SetBtnColor();
                }
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_Validating(object sender, CancelEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            string? txtBoxName = txt.Tag.ToString();
            string errMsg = string.Empty;
            bool failedValidation = false;


            switch (txtBoxName)
            {
                case "Title":
                    _exerciseTitle = txt.Text.Trim();
                    txt.Text = _exerciseTitle;

                    break;

                case"Description":
                    _exerciseDescription = txt.Text.Trim();
                    txt.Text = _exerciseDescription;
                    break;

                case "Instructions":
                    _exerciseInstruction = txt.Text.Trim();
                    txt.Text = _exerciseInstruction;
                    break;
                    
            }

            if (txt.Text == string.Empty)
            {
                errMsg = $"{txtBoxName} is required";
                failedValidation = true;
            }

            e.Cancel = failedValidation;

            errorProvider.SetError(txt, errMsg);
        }

        private void frmExercise_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            PopulateFormFields(_currentRecord);
            txtExerciseTitle.Enabled = false;
            txtExerciseDescription.Enabled = false;
            txtExerciseInstructions.Enabled = false;

            CRUDBtnState(true);
            NavigationBtnState();

            btnCancel.Enabled = false;
            btnSave.Enabled = false;

            SetBtnColor();

        }
    }
}
