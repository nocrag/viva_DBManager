namespace WorkoutApp
{
    partial class frmBrowseAll
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
            dgvShowAll = new DataGridView();
            btnShowWorkouts = new Button();
            btnShowExercises = new Button();
            btnShowMuscles = new Button();
            btnShowUsers = new Button();
            lblTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvShowAll).BeginInit();
            SuspendLayout();
            // 
            // dgvShowAll
            // 
            dgvShowAll.AllowUserToAddRows = false;
            dgvShowAll.AllowUserToDeleteRows = false;
            dgvShowAll.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShowAll.Location = new Point(23, 170);
            dgvShowAll.Name = "dgvShowAll";
            dgvShowAll.ReadOnly = true;
            dgvShowAll.Size = new Size(1051, 448);
            dgvShowAll.TabIndex = 1;
            // 
            // btnShowWorkouts
            // 
            btnShowWorkouts.BackColor = Color.FromArgb(66, 135, 245);
            btnShowWorkouts.FlatStyle = FlatStyle.Popup;
            btnShowWorkouts.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowWorkouts.ForeColor = SystemColors.ControlLight;
            btnShowWorkouts.Location = new Point(23, 117);
            btnShowWorkouts.Name = "btnShowWorkouts";
            btnShowWorkouts.Size = new Size(243, 32);
            btnShowWorkouts.TabIndex = 2;
            btnShowWorkouts.Text = "Show all workouts";
            btnShowWorkouts.UseVisualStyleBackColor = false;
            btnShowWorkouts.Click += btnShowWorkouts_Click;
            // 
            // btnShowExercises
            // 
            btnShowExercises.BackColor = Color.FromArgb(66, 135, 245);
            btnShowExercises.FlatStyle = FlatStyle.Popup;
            btnShowExercises.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowExercises.ForeColor = SystemColors.ControlLight;
            btnShowExercises.Location = new Point(293, 117);
            btnShowExercises.Name = "btnShowExercises";
            btnShowExercises.Size = new Size(243, 32);
            btnShowExercises.TabIndex = 3;
            btnShowExercises.Text = "Show all exercises";
            btnShowExercises.UseVisualStyleBackColor = false;
            btnShowExercises.Click += btnShowExercises_Click;
            // 
            // btnShowMuscles
            // 
            btnShowMuscles.BackColor = Color.FromArgb(66, 135, 245);
            btnShowMuscles.FlatStyle = FlatStyle.Popup;
            btnShowMuscles.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnShowMuscles.ForeColor = SystemColors.ControlLight;
            btnShowMuscles.Location = new Point(831, 117);
            btnShowMuscles.Name = "btnShowMuscles";
            btnShowMuscles.Size = new Size(243, 32);
            btnShowMuscles.TabIndex = 4;
            btnShowMuscles.Text = "Show all muscles";
            btnShowMuscles.UseVisualStyleBackColor = false;
            btnShowMuscles.Click += btnShowMuscles_Click;
            // 
            // btnShowUsers
            // 
            btnShowUsers.BackColor = Color.FromArgb(66, 135, 245);
            btnShowUsers.FlatStyle = FlatStyle.Popup;
            btnShowUsers.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnShowUsers.ForeColor = SystemColors.ControlLight;
            btnShowUsers.Location = new Point(558, 117);
            btnShowUsers.Name = "btnShowUsers";
            btnShowUsers.Size = new Size(243, 32);
            btnShowUsers.TabIndex = 5;
            btnShowUsers.Text = "Show all users";
            btnShowUsers.UseVisualStyleBackColor = false;
            btnShowUsers.Click += btnShowUsers_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblTitle.ForeColor = SystemColors.ControlLight;
            lblTitle.Location = new Point(424, 44);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(161, 32);
            lblTitle.TabIndex = 6;
            lblTitle.Text = "Select a table";
            // 
            // frmBrowseAll
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            ClientSize = new Size(1118, 640);
            Controls.Add(lblTitle);
            Controls.Add(btnShowUsers);
            Controls.Add(btnShowMuscles);
            Controls.Add(btnShowExercises);
            Controls.Add(btnShowWorkouts);
            Controls.Add(dgvShowAll);
            Name = "frmBrowseAll";
            StartPosition = FormStartPosition.CenterScreen;
            Tag = "";
            Text = "Browse all records";
            Load += frmExercisesBrowser_Load;
            ((System.ComponentModel.ISupportInitialize)dgvShowAll).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvShowAll;
        private Button btnShowWorkouts;
        private Button btnShowExercises;
        private Button btnShowMuscles;
        private Button btnShowUsers;
        private Label lblTitle;
    }
}