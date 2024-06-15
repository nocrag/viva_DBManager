namespace WorkoutApp
{
    partial class frmWorkoutDetailsBrowser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvWorkoutDetails = new DataGridView();
            cmbWorkout = new ComboBox();
            btnShowAll = new Button();
            label1 = new Label();
            cmbExercises = new ComboBox();
            label2 = new Label();
            cmbMuscleID = new ComboBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvWorkoutDetails).BeginInit();
            SuspendLayout();
            // 
            // dgvWorkoutDetails
            // 
            dgvWorkoutDetails.AllowUserToAddRows = false;
            dgvWorkoutDetails.AllowUserToDeleteRows = false;
            dgvWorkoutDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvWorkoutDetails.Location = new Point(12, 112);
            dgvWorkoutDetails.Name = "dgvWorkoutDetails";
            dgvWorkoutDetails.ReadOnly = true;
            dgvWorkoutDetails.Size = new Size(1206, 414);
            dgvWorkoutDetails.TabIndex = 0;
            // 
            // cmbWorkout
            // 
            cmbWorkout.FormattingEnabled = true;
            cmbWorkout.Location = new Point(12, 75);
            cmbWorkout.Name = "cmbWorkout";
            cmbWorkout.Size = new Size(298, 23);
            cmbWorkout.TabIndex = 1;
            cmbWorkout.SelectionChangeCommitted += cmbWorkout_SelectionChangeCommitted;
            // 
            // btnShowAll
            // 
            btnShowAll.BackColor = Color.FromArgb(66, 135, 245);
            btnShowAll.FlatStyle = FlatStyle.Popup;
            btnShowAll.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowAll.ForeColor = SystemColors.ControlLight;
            btnShowAll.Location = new Point(1004, 66);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(214, 34);
            btnShowAll.TabIndex = 2;
            btnShowAll.Text = "Show all workouts";
            btnShowAll.UseVisualStyleBackColor = false;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 51);
            label1.Name = "label1";
            label1.Size = new Size(154, 21);
            label1.TabIndex = 3;
            label1.Text = "Browse By Workout";
            // 
            // cmbExercises
            // 
            cmbExercises.FormattingEnabled = true;
            cmbExercises.Location = new Point(338, 75);
            cmbExercises.Name = "cmbExercises";
            cmbExercises.Size = new Size(298, 23);
            cmbExercises.TabIndex = 1;
            cmbExercises.SelectionChangeCommitted += cmbExercises_SelectionChangeCommitted;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(338, 51);
            label2.Name = "label2";
            label2.Size = new Size(149, 21);
            label2.TabIndex = 3;
            label2.Text = "Browse By Exercise";
            // 
            // cmbMuscleID
            // 
            cmbMuscleID.FormattingEnabled = true;
            cmbMuscleID.Location = new Point(666, 77);
            cmbMuscleID.Name = "cmbMuscleID";
            cmbMuscleID.Size = new Size(298, 23);
            cmbMuscleID.TabIndex = 1;
            cmbMuscleID.SelectionChangeCommitted += cmbMuscleID_SelectionChangeCommitted;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(666, 53);
            label3.Name = "label3";
            label3.Size = new Size(142, 21);
            label3.TabIndex = 3;
            label3.Text = "Browse By Muscle";
            // 
            // frmWorkoutDetailsBrowser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            ClientSize = new Size(1230, 666);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnShowAll);
            Controls.Add(cmbMuscleID);
            Controls.Add(cmbExercises);
            Controls.Add(cmbWorkout);
            Controls.Add(dgvWorkoutDetails);
            Name = "frmWorkoutDetailsBrowser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Browse Workouts";
            Load += workoutBrowser_Load;
            ((System.ComponentModel.ISupportInitialize)dgvWorkoutDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvWorkoutDetails;
        private ComboBox cmbWorkout;
        private Button btnShowAll;
        private Label label1;
        private ComboBox cmbExercises;
        private Label label2;
        private ComboBox cmbMuscleID;
        private Label label3;
    }
}