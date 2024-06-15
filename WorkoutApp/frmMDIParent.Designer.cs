namespace WorkoutApp
{
    partial class frmMDIParent
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMDIParent));
            menuStrip = new MenuStrip();
            maintenanceToolStripMenuItem = new ToolStripMenuItem();
            manageExerciseToolStripMenuItem = new ToolStripMenuItem();
            manageWorkoutsToolStripMenuItem = new ToolStripMenuItem();
            manageMusclesToolStripMenuItem = new ToolStripMenuItem();
            manageMusclesDetailsToolStripMenuItem = new ToolStripMenuItem();
            manageWorkoutDetailsToolStripMenuItem = new ToolStripMenuItem();
            manageUsersToolStripMenuItem = new ToolStripMenuItem();
            browseWorkoutRoutinesToolStripMenuItem = new ToolStripMenuItem();
            browseExercisesToolStripMenuItem = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            lblProgressBar = new ToolStripStatusLabel();
            progressBar = new ToolStripProgressBar();
            toolTip = new ToolTip(components);
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            menuStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { maintenanceToolStripMenuItem, browseWorkoutRoutinesToolStripMenuItem, browseExercisesToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(7, 2, 0, 2);
            menuStrip.Size = new Size(1284, 29);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "MenuStrip";
            // 
            // maintenanceToolStripMenuItem
            // 
            maintenanceToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manageExerciseToolStripMenuItem, manageWorkoutsToolStripMenuItem, manageMusclesToolStripMenuItem, manageMusclesDetailsToolStripMenuItem, manageWorkoutDetailsToolStripMenuItem, manageUsersToolStripMenuItem });
            maintenanceToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            maintenanceToolStripMenuItem.Name = "maintenanceToolStripMenuItem";
            maintenanceToolStripMenuItem.Size = new Size(111, 25);
            maintenanceToolStripMenuItem.Text = "Maintenance";
            maintenanceToolStripMenuItem.Click += maintenanceToolStripMenuItem_Click;
            // 
            // manageExerciseToolStripMenuItem
            // 
            manageExerciseToolStripMenuItem.Name = "manageExerciseToolStripMenuItem";
            manageExerciseToolStripMenuItem.Size = new Size(251, 26);
            manageExerciseToolStripMenuItem.Tag = "Exercise";
            manageExerciseToolStripMenuItem.Text = "Manage Exercises";
            manageExerciseToolStripMenuItem.Click += ShowNewForm;
            // 
            // manageWorkoutsToolStripMenuItem
            // 
            manageWorkoutsToolStripMenuItem.Name = "manageWorkoutsToolStripMenuItem";
            manageWorkoutsToolStripMenuItem.Size = new Size(251, 26);
            manageWorkoutsToolStripMenuItem.Tag = "Workout";
            manageWorkoutsToolStripMenuItem.Text = "Manage Workouts";
            manageWorkoutsToolStripMenuItem.Click += ShowNewForm;
            // 
            // manageMusclesToolStripMenuItem
            // 
            manageMusclesToolStripMenuItem.Name = "manageMusclesToolStripMenuItem";
            manageMusclesToolStripMenuItem.Size = new Size(251, 26);
            manageMusclesToolStripMenuItem.Tag = "Muscles";
            manageMusclesToolStripMenuItem.Text = "Manage Muscles";
            manageMusclesToolStripMenuItem.Click += ShowNewForm;
            // 
            // manageMusclesDetailsToolStripMenuItem
            // 
            manageMusclesDetailsToolStripMenuItem.Name = "manageMusclesDetailsToolStripMenuItem";
            manageMusclesDetailsToolStripMenuItem.Size = new Size(251, 26);
            manageMusclesDetailsToolStripMenuItem.Tag = "Exercise Muscles";
            manageMusclesDetailsToolStripMenuItem.Text = "Manage Muscles Details";
            manageMusclesDetailsToolStripMenuItem.Click += ShowNewForm;
            // 
            // manageWorkoutDetailsToolStripMenuItem
            // 
            manageWorkoutDetailsToolStripMenuItem.Name = "manageWorkoutDetailsToolStripMenuItem";
            manageWorkoutDetailsToolStripMenuItem.Size = new Size(251, 26);
            manageWorkoutDetailsToolStripMenuItem.Tag = "Workout Details";
            manageWorkoutDetailsToolStripMenuItem.Text = "Manage Workout Details";
            manageWorkoutDetailsToolStripMenuItem.Click += ShowNewForm;
            // 
            // manageUsersToolStripMenuItem
            // 
            manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            manageUsersToolStripMenuItem.Size = new Size(251, 26);
            manageUsersToolStripMenuItem.Tag = "Users";
            manageUsersToolStripMenuItem.Text = "Manage Users";
            manageUsersToolStripMenuItem.Click += ShowNewForm;
            // 
            // browseWorkoutRoutinesToolStripMenuItem
            // 
            browseWorkoutRoutinesToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            browseWorkoutRoutinesToolStripMenuItem.Name = "browseWorkoutRoutinesToolStripMenuItem";
            browseWorkoutRoutinesToolStripMenuItem.Size = new Size(188, 25);
            browseWorkoutRoutinesToolStripMenuItem.Tag = "Browse";
            browseWorkoutRoutinesToolStripMenuItem.Text = "Browse Workout Details";
            browseWorkoutRoutinesToolStripMenuItem.Click += ShowNewForm;
            // 
            // browseExercisesToolStripMenuItem
            // 
            browseExercisesToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Underline);
            browseExercisesToolStripMenuItem.Name = "browseExercisesToolStripMenuItem";
            browseExercisesToolStripMenuItem.Size = new Size(155, 25);
            browseExercisesToolStripMenuItem.Tag = "BrowseAll";
            browseExercisesToolStripMenuItem.Text = "Browse All Records";
            browseExercisesToolStripMenuItem.Click += ShowNewForm;
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel, lblProgressBar, progressBar });
            statusStrip.Location = new Point(0, 739);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 16, 0);
            statusStrip.Size = new Size(1284, 22);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(39, 17);
            toolStripStatusLabel.Text = "Status";
            // 
            // lblProgressBar
            // 
            lblProgressBar.Name = "lblProgressBar";
            lblProgressBar.Size = new Size(0, 17);
            // 
            // progressBar
            // 
            progressBar.Margin = new Padding(3, 3, 1, 3);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(100, 16);
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2 });
            toolStrip1.Location = new Point(0, 29);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1284, 33);
            toolStrip1.TabIndex = 5;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Padding = new Padding(5);
            toolStripButton1.Size = new Size(30, 30);
            toolStripButton1.Tag = "BrowseAll";
            toolStripButton1.Text = "Browse All Records";
            toolStripButton1.Click += ShowNewForm;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Padding = new Padding(5);
            toolStripButton2.Size = new Size(30, 30);
            toolStripButton2.Tag = "Workout Details";
            toolStripButton2.Text = "Create Workout";
            toolStripButton2.Click += ShowNewForm;
            // 
            // frmMDIParent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1284, 761);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmMDIParent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " GymApp Management";
            Load += MDIParent_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private ToolStripMenuItem maintenanceToolStripMenuItem;
        private ToolStripMenuItem manageExerciseToolStripMenuItem;
        private ToolStripMenuItem manageWorkoutsToolStripMenuItem;
        private ToolStripProgressBar progressBar;
        private ToolStripStatusLabel lblProgressBar;
        private ToolStripMenuItem manageMusclesToolStripMenuItem;
        private ToolStripMenuItem manageWorkoutDetailsToolStripMenuItem;
        private ToolStripMenuItem manageUsersToolStripMenuItem;
        private ToolStripMenuItem manageMusclesDetailsToolStripMenuItem;
        private ToolStripMenuItem browseWorkoutRoutinesToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripMenuItem browseExercisesToolStripMenuItem;
    }
}



