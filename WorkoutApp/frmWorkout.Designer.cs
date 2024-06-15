namespace WorkoutApp
{
    partial class frmWorkout
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblID = new Label();
            label2 = new Label();
            lblWorkouts = new Label();
            txtWorkoutTitle = new TextBox();
            btnSave = new Button();
            btnPrevious = new Button();
            btnLast = new Button();
            btnDelete = new Button();
            btnNext = new Button();
            btnUpdate = new Button();
            btnFirst = new Button();
            btnCreate = new Button();
            errorProvider = new ErrorProvider(components);
            btnCancel = new Button();
            lblWorkoutIDDisplay = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblID.ForeColor = SystemColors.ControlLight;
            lblID.Location = new Point(149, 126);
            lblID.Name = "lblID";
            lblID.Size = new Size(88, 20);
            lblID.TabIndex = 1;
            lblID.Tag = " ";
            lblID.Text = "Workout ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(149, 210);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 1;
            label2.Tag = " ";
            label2.Text = "Workout Title";
            // 
            // lblWorkouts
            // 
            lblWorkouts.AutoSize = true;
            lblWorkouts.Font = new Font("HeadingNow Trial 65 Medium", 17.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblWorkouts.Location = new Point(344, 54);
            lblWorkouts.Name = "lblWorkouts";
            lblWorkouts.Size = new Size(289, 31);
            lblWorkouts.TabIndex = 3;
            lblWorkouts.Text = "Workout Management";
            // 
            // txtWorkoutTitle
            // 
            txtWorkoutTitle.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtWorkoutTitle.Location = new Point(149, 239);
            txtWorkoutTitle.Name = "txtWorkoutTitle";
            txtWorkoutTitle.ReadOnly = true;
            txtWorkoutTitle.Size = new Size(599, 27);
            txtWorkoutTitle.TabIndex = 5;
            txtWorkoutTitle.Tag = "Title";
            txtWorkoutTitle.Validating += txtWorkoutTitle_Validating;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(31, 31, 31);
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.ForeColor = Color.Cornsilk;
            btnSave.Location = new Point(149, 353);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(599, 43);
            btnSave.TabIndex = 26;
            btnSave.Text = "Save new workout";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = Color.FromArgb(66, 135, 245);
            btnPrevious.FlatStyle = FlatStyle.Popup;
            btnPrevious.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnPrevious.ForeColor = SystemColors.ButtonHighlight;
            btnPrevious.Location = new Point(330, 494);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(97, 35);
            btnPrevious.TabIndex = 25;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnLast
            // 
            btnLast.BackColor = Color.FromArgb(66, 135, 245);
            btnLast.FlatStyle = FlatStyle.Popup;
            btnLast.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnLast.ForeColor = SystemColors.ButtonHighlight;
            btnLast.Location = new Point(582, 494);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(97, 35);
            btnLast.TabIndex = 19;
            btnLast.Text = "Last";
            btnLast.UseVisualStyleBackColor = false;
            btnLast.Click += btnLast_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(66, 135, 245);
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(560, 295);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(188, 35);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Delete Current Workout";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(66, 135, 245);
            btnNext.FlatStyle = FlatStyle.Popup;
            btnNext.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnNext.ForeColor = SystemColors.ButtonHighlight;
            btnNext.Location = new Point(457, 494);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(97, 35);
            btnNext.TabIndex = 21;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(66, 135, 245);
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnUpdate.ForeColor = SystemColors.ButtonHighlight;
            btnUpdate.Location = new Point(344, 295);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(194, 35);
            btnUpdate.TabIndex = 22;
            btnUpdate.Text = "Update Current Workout";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnFirst
            // 
            btnFirst.BackColor = Color.FromArgb(66, 135, 245);
            btnFirst.FlatStyle = FlatStyle.Popup;
            btnFirst.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnFirst.ForeColor = SystemColors.ButtonHighlight;
            btnFirst.Location = new Point(211, 494);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(97, 35);
            btnFirst.TabIndex = 23;
            btnFirst.Text = "First";
            btnFirst.UseVisualStyleBackColor = false;
            btnFirst.Click += btnFirst_Click;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.FromArgb(66, 135, 245);
            btnCreate.FlatStyle = FlatStyle.Popup;
            btnCreate.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnCreate.ForeColor = SystemColors.ButtonHighlight;
            btnCreate.Location = new Point(149, 295);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(168, 35);
            btnCreate.TabIndex = 24;
            btnCreate.Text = "Create New Workout";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // errorProvider
            // 
            errorProvider.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            errorProvider.ContainerControl = this;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(31, 31, 31);
            btnCancel.CausesValidation = false;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.ButtonHighlight;
            btnCancel.Location = new Point(149, 414);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(599, 43);
            btnCancel.TabIndex = 27;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblWorkoutIDDisplay
            // 
            lblWorkoutIDDisplay.AutoSize = true;
            lblWorkoutIDDisplay.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWorkoutIDDisplay.Location = new Point(149, 157);
            lblWorkoutIDDisplay.Name = "lblWorkoutIDDisplay";
            lblWorkoutIDDisplay.Size = new Size(32, 25);
            lblWorkoutIDDisplay.TabIndex = 28;
            lblWorkoutIDDisplay.Text = "ID";
            // 
            // frmWorkout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            ClientSize = new Size(925, 624);
            Controls.Add(lblWorkoutIDDisplay);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnPrevious);
            Controls.Add(btnLast);
            Controls.Add(btnDelete);
            Controls.Add(btnNext);
            Controls.Add(btnUpdate);
            Controls.Add(btnFirst);
            Controls.Add(btnCreate);
            Controls.Add(txtWorkoutTitle);
            Controls.Add(lblWorkouts);
            Controls.Add(label2);
            Controls.Add(lblID);
            ForeColor = SystemColors.ControlLightLight;
            Name = "frmWorkout";
            StartPosition = FormStartPosition.CenterScreen;
            Tag = " ";
            Text = "Workout Management";
            FormClosing += frmWorkout_FormClosing;
            Load += frmWorkout_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblID;
        private Label label2;
        private Label lblWorkouts;
        private TextBox txtWorkoutTitle;
        private Button btnSave;
        private Button btnPrevious;
        private Button btnLast;
        private Button btnDelete;
        private Button btnNext;
        private Button btnUpdate;
        private Button btnFirst;
        private Button btnCreate;
        private ErrorProvider errorProvider;
        private Button btnCancel;
        private Label lblWorkoutIDDisplay;
    }
}
