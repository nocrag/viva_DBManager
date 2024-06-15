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
    public partial class frmBrowseAll : Form
    {
        public frmBrowseAll()
        {
            InitializeComponent();
        }

        private void frmExercisesBrowser_Load(object sender, EventArgs e)
        {


        }

        private void btnShowWorkouts_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtWorkouts = frmWorkout.GetWorkouts();

                if (dtWorkouts.Rows.Count > 0)
                {
                    dtWorkouts.Columns["WorkoutID"].ColumnName = "Workout ID";
                    dtWorkouts.Columns["WorkoutTitle"].ColumnName = "Workout Name";


                    dgvShowAll.DataSource = dtWorkouts;

                    dgvShowAll.AutoResizeColumns();

                    string numRows = dtWorkouts.Rows.Count.ToString();
                    lblTitle.Text = $"Showing all records for workouts";
                }
                else
                    MessageBox.Show("There are no records");
            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.Message);
            }

        }

        private void btnShowExercises_Click(object sender, EventArgs e)
        {
            DataTable dtExercises = frmExercise.GetExercises();
            try
            {
                if (dtExercises.Rows.Count > 0)
                {
                    dtExercises.Columns["ExerciseID"].ColumnName = "Exercise ID";
                    dtExercises.Columns["ExerciseTitle"].ColumnName = "Exercise Name";
                    dtExercises.Columns["ExerciseDescription"].ColumnName = "Description";
                    dtExercises.Columns["ExerciseInstructions"].ColumnName = "Instructions";

                    dgvShowAll.DataSource = dtExercises;

                    dgvShowAll.AutoResizeColumns();

                    string numRows = dtExercises.Rows.Count.ToString();
                    lblTitle.Text = $"Showing all records for exercises";

                }
                else
                {
                    MessageBox.Show("There are no records");
                    lblTitle.Text = $"There are no records for exercises";
                }
                
            }
            catch (Exception ex)
            {

                new ArgumentException(ex.Message);
                lblTitle.Text = $"There are no records for muscles";
            }

        }

        private void btnShowMuscles_Click(object sender, EventArgs e)
        {
            DataTable dtMuscles = frmMuscle.GetMuscles();
            try
            {
                if (dtMuscles.Rows.Count > 0)
                {
                    dtMuscles.Columns["MuscleID"].ColumnName = "MuscleID ID";
                    dtMuscles.Columns["MuscleTitle"].ColumnName = "Muscle Title";

                    dgvShowAll.DataSource = dtMuscles;

                    dgvShowAll.AutoResizeColumns();
                    string numRows = dtMuscles.Rows.Count.ToString();
                    lblTitle.Text = $"Showing all records for muscles";
                }
                else
                {
                    MessageBox.Show("There are no records");
                    lblTitle.Text = $"There are no records for muscles";
                }
                    
            }
            catch (Exception ex)
            {
                new ArgumentException(ex.Message);
            }
        }

        private void btnShowUsers_Click(object sender, EventArgs e)
        {
            DataTable dtUsers = frmLogin.GetUsers();
            try
            {
                if (dtUsers.Rows.Count > 0)
                {
                    dtUsers.Columns["UserID"].ColumnName = "User ID";
                    dtUsers.Columns["Username"].ColumnName = "UserName";
                    dtUsers.Columns["Password"].ColumnName = "Password";

                    dgvShowAll.DataSource = dtUsers;

                    dgvShowAll.AutoResizeColumns();
                    string numRows = dtUsers.Rows.Count.ToString();
                    lblTitle.Text = $"Showing all records for users";
                }
                else
                {
                    MessageBox.Show("There are no records for users");
                    lblTitle.Text = $"There are no records for users";
                }
            }
            catch (Exception ex)
            {
                new ArgumentException(ex.Message);
            }
        }
    }
}
