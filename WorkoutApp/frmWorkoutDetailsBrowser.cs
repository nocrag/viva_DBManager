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
    public partial class frmWorkoutDetailsBrowser : Form
    {
        DataTable dtWorkoutDetails = new DataTable();
        DataTable dtWorkouts = new DataTable();
        DataTable dtExercises = new DataTable();
        DataTable dtMuscles = new DataTable();
        public frmWorkoutDetailsBrowser()
        {
            InitializeComponent();
        }

        private void workoutBrowser_Load(object sender, EventArgs e)
        {
            dtWorkoutDetails = frmWorkoutDetails.GetWorkoutDetails();
            dtWorkouts = frmWorkout.GetWorkouts();
            dtExercises = frmExercise.GetExercises();
            dtMuscles = frmMuscle.GetMuscles();

            UIUtilities.FillListControl(cmbWorkout, "WorkoutTitle", "WorkoutID", dtWorkouts, true, "Select a workout");
            UIUtilities.FillListControl(cmbExercises, "ExerciseTitle", "ExerciseID", dtExercises, true, "Select an exercise");
            UIUtilities.FillListControl(cmbMuscleID, "MuscleTitle", "MuscleID", dtMuscles, true, "Select a muscle");

        }
        private void GetDetailsByWorkoutID()
        {
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
                        ExercisesReps,
                        ExerciseMuscle.MuscleID,
                        MuscleTitle
                    FROM 
                        Workout 
                    INNER JOIN WorkoutExercise
                        ON Workout.WorkoutID = WorkoutExercise.WorkoutID 
                    INNER JOIN Exercise
                        ON WorkoutExercise.ExerciseID = Exercise.ExerciseID
                    INNER JOIN ExerciseMuscle
                        ON Exercise.ExerciseID = ExerciseMuscle.ExerciseID
                    INNER JOIN Muscle
                        ON ExerciseMuscle.MuscleID = Muscle.MuscleID
                    WHERE Workout.WorkoutID = {cmbWorkout.SelectedValue}
                    ORDER BY 
                        WorkoutTitle ASC;
                     ");

                dtWorkoutDetails = DataAccess.GetData(sqlQueryText);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void GetDetailsByExerciseID()
        {
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
                        CAST(ExerciseWeight AS VARCHAR(10)) + 'kg' AS ExerciseWeight,
                        ExerciseSets,
                        ExercisesReps,
                        ExerciseMuscle.MuscleID,
                        MuscleTitle
                    FROM 
                        Workout 
                    INNER JOIN WorkoutExercise
                        ON Workout.WorkoutID = WorkoutExercise.WorkoutID 
                    INNER JOIN Exercise
                        ON WorkoutExercise.ExerciseID = Exercise.ExerciseID
                    INNER JOIN ExerciseMuscle
                        ON Exercise.ExerciseID = ExerciseMuscle.ExerciseID
                    INNER JOIN Muscle
                        ON ExerciseMuscle.MuscleID = Muscle.MuscleID
                    WHERE Exercise.ExerciseID = {cmbExercises.SelectedValue}
                    ORDER BY 
                        WorkoutTitle ASC;
                     ");

                dtWorkoutDetails = DataAccess.GetData(sqlQueryText);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void GetDetailsByMuscleID()
        {
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
                        CAST(ExerciseWeight AS VARCHAR(10)) + 'kg' AS ExerciseWeight,
                        ExerciseSets,
                        ExercisesReps,
                        ExerciseMuscle.MuscleID,
                        MuscleTitle
                    FROM 
                        Workout 
                    INNER JOIN WorkoutExercise
                        ON Workout.WorkoutID = WorkoutExercise.WorkoutID 
                    INNER JOIN Exercise
                        ON WorkoutExercise.ExerciseID = Exercise.ExerciseID
                    INNER JOIN ExerciseMuscle
                        ON Exercise.ExerciseID = ExerciseMuscle.ExerciseID
                    INNER JOIN Muscle
                        ON ExerciseMuscle.MuscleID = Muscle.MuscleID
                    WHERE Muscle.MuscleID = {cmbMuscleID.SelectedValue}
                    ORDER BY 
                        WorkoutTitle ASC;
                     ");

                dtWorkoutDetails = DataAccess.GetData(sqlQueryText);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void GetAll()
        {
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
                        CAST(ExerciseWeight AS VARCHAR(10)) + 'kg' AS ExerciseWeight,
                        ExerciseSets,
                        ExercisesReps,
                        ExerciseMuscle.MuscleID,
                        MuscleTitle
                    FROM 
                        Workout 
                    INNER JOIN WorkoutExercise
                        ON Workout.WorkoutID = WorkoutExercise.WorkoutID 
                    INNER JOIN Exercise
                        ON WorkoutExercise.ExerciseID = Exercise.ExerciseID
                    INNER JOIN ExerciseMuscle
                        ON Exercise.ExerciseID = ExerciseMuscle.ExerciseID
                    INNER JOIN Muscle
                        ON ExerciseMuscle.MuscleID = Muscle.MuscleID
                    ORDER BY 
                        WorkoutTitle ASC;
                     ");

                dtWorkoutDetails = DataAccess.GetData(sqlQueryText);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void PopulateTable()
        {
            if (dtWorkoutDetails.Rows.Count > 0)
            {
                dtWorkoutDetails.Columns["WorkoutID"].ColumnName = "Workout ID";
                dtWorkoutDetails.Columns["ExerciseID"].ColumnName = "Exercise ID";
                dtWorkoutDetails.Columns["WorkoutTitle"].ColumnName = "Workout Name";
                dtWorkoutDetails.Columns["ExerciseTitle"].ColumnName = "Exercise Name";
                dtWorkoutDetails.Columns["ExerciseDescription"].ColumnName = "Description";
                dtWorkoutDetails.Columns["ExerciseInstructions"].ColumnName = "Instructions";
                dtWorkoutDetails.Columns["ExerciseWeight"].ColumnName = "Workout Weight";
                dtWorkoutDetails.Columns["ExerciseSets"].ColumnName = "Workout Sets";
                dtWorkoutDetails.Columns["ExercisesReps"].ColumnName = "Workout Reps";

                dgvWorkoutDetails.DataSource = dtWorkoutDetails;

                dgvWorkoutDetails.AutoResizeColumns();

                foreach (DataGridViewColumn column in dgvWorkoutDetails.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    column.HeaderCell.Style.WrapMode = DataGridViewTriState.False;
                }

                dgvWorkoutDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            }
            else
            {
                MessageBox.Show("There are no records");
                cmbWorkout.SelectedIndex = 0;
            }
        }

        private void cmbWorkout_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbWorkout.SelectedIndex == 0)
                return;
            else
            {
                GetDetailsByWorkoutID();
                PopulateTable();
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            GetAll();
            PopulateTable();
        }

        private void cmbExercises_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbExercises.SelectedIndex == 0)
                return;
            else
            {
                GetDetailsByExerciseID();
                PopulateTable();
            }
        }

        private void cmbMuscleID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbMuscleID.SelectedIndex == 0)
                return;
            else
            {
                GetDetailsByMuscleID();
                PopulateTable();
            }
        }
    }
}
