namespace WorkoutApp
{
    partial class frmWorkoutDetails
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
            lblWorkoutID = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnCreate = new Button();
            lblWorkouts = new Label();
            label2 = new Label();
            label4 = new Label();
            lblExerciseID = new Label();
            cmbWorkoutTitle = new ComboBox();
            cmbExerciseTitle = new ComboBox();
            btnFirst = new Button();
            btnNext = new Button();
            btnLast = new Button();
            btnPrevious = new Button();
            txtWeight = new TextBox();
            txtReps = new TextBox();
            txtSets = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            errorProvider = new ErrorProvider(components);
            label1 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // lblWorkoutID
            // 
            lblWorkoutID.AutoSize = true;
            lblWorkoutID.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWorkoutID.ForeColor = SystemColors.ControlLight;
            lblWorkoutID.Location = new Point(205, 142);
            lblWorkoutID.Name = "lblWorkoutID";
            lblWorkoutID.Size = new Size(22, 17);
            lblWorkoutID.TabIndex = 42;
            lblWorkoutID.Text = "ID";
            // 
            // btnCancel
            // 
            btnCancel.CausesValidation = false;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.ButtonHighlight;
            btnCancel.Location = new Point(171, 495);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(468, 43);
            btnCancel.TabIndex = 41;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(35, 35, 35);
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.ForeColor = Color.Cornsilk;
            btnSave.Location = new Point(171, 434);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(468, 43);
            btnSave.TabIndex = 40;
            btnSave.Text = "Save workout";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(66, 135, 245);
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(515, 375);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(124, 35);
            btnDelete.TabIndex = 34;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(66, 135, 245);
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnUpdate.ForeColor = SystemColors.ButtonHighlight;
            btnUpdate.Location = new Point(345, 375);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(124, 35);
            btnUpdate.TabIndex = 36;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.FromArgb(66, 135, 245);
            btnCreate.FlatStyle = FlatStyle.Popup;
            btnCreate.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnCreate.ForeColor = SystemColors.ButtonHighlight;
            btnCreate.Location = new Point(171, 375);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(124, 35);
            btnCreate.TabIndex = 38;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // lblWorkouts
            // 
            lblWorkouts.AutoSize = true;
            lblWorkouts.Font = new Font("HeadingNow Trial 65 Medium", 17.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblWorkouts.ForeColor = SystemColors.ControlLight;
            lblWorkouts.Location = new Point(205, 49);
            lblWorkouts.Name = "lblWorkouts";
            lblWorkouts.Size = new Size(384, 31);
            lblWorkouts.TabIndex = 31;
            lblWorkouts.Text = "Workout Details Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(172, 163);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 29;
            label2.Tag = " ";
            label2.Text = "Workout";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlLight;
            label4.Location = new Point(425, 173);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 29;
            label4.Tag = " ";
            label4.Text = "Exercise";
            // 
            // lblExerciseID
            // 
            lblExerciseID.AutoSize = true;
            lblExerciseID.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblExerciseID.ForeColor = SystemColors.ControlLight;
            lblExerciseID.Location = new Point(462, 155);
            lblExerciseID.Name = "lblExerciseID";
            lblExerciseID.Size = new Size(22, 17);
            lblExerciseID.TabIndex = 42;
            lblExerciseID.Text = "ID";
            // 
            // cmbWorkoutTitle
            // 
            cmbWorkoutTitle.FormattingEnabled = true;
            cmbWorkoutTitle.Location = new Point(171, 196);
            cmbWorkoutTitle.Name = "cmbWorkoutTitle";
            cmbWorkoutTitle.Size = new Size(214, 23);
            cmbWorkoutTitle.TabIndex = 43;
            // 
            // cmbExerciseTitle
            // 
            cmbExerciseTitle.FormattingEnabled = true;
            cmbExerciseTitle.Location = new Point(425, 196);
            cmbExerciseTitle.Name = "cmbExerciseTitle";
            cmbExerciseTitle.Size = new Size(214, 23);
            cmbExerciseTitle.TabIndex = 44;
            // 
            // btnFirst
            // 
            btnFirst.BackColor = Color.FromArgb(66, 135, 245);
            btnFirst.FlatStyle = FlatStyle.Popup;
            btnFirst.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnFirst.ForeColor = SystemColors.ButtonHighlight;
            btnFirst.Location = new Point(172, 579);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(97, 35);
            btnFirst.TabIndex = 37;
            btnFirst.Text = "First";
            btnFirst.UseVisualStyleBackColor = false;
            btnFirst.Click += btnFirst_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(66, 135, 245);
            btnNext.FlatStyle = FlatStyle.Popup;
            btnNext.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnNext.ForeColor = SystemColors.ButtonHighlight;
            btnNext.Location = new Point(418, 579);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(97, 35);
            btnNext.TabIndex = 35;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnLast
            // 
            btnLast.BackColor = Color.FromArgb(66, 135, 245);
            btnLast.FlatStyle = FlatStyle.Popup;
            btnLast.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnLast.ForeColor = SystemColors.ButtonHighlight;
            btnLast.Location = new Point(543, 579);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(97, 35);
            btnLast.TabIndex = 33;
            btnLast.Text = "Last";
            btnLast.UseVisualStyleBackColor = false;
            btnLast.Click += btnLast_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = Color.FromArgb(66, 135, 245);
            btnPrevious.FlatStyle = FlatStyle.Popup;
            btnPrevious.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnPrevious.ForeColor = SystemColors.ButtonHighlight;
            btnPrevious.Location = new Point(291, 579);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(97, 35);
            btnPrevious.TabIndex = 39;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(504, 292);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(135, 23);
            txtWeight.TabIndex = 46;
            // 
            // txtReps
            // 
            txtReps.Location = new Point(172, 292);
            txtReps.Name = "txtReps";
            txtReps.Size = new Size(135, 23);
            txtReps.TabIndex = 45;
            txtReps.Validating += txtReps_Validating;
            // 
            // txtSets
            // 
            txtSets.Location = new Point(341, 292);
            txtSets.Name = "txtSets";
            txtSets.Size = new Size(135, 23);
            txtSets.TabIndex = 46;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ControlLight;
            label5.Location = new Point(172, 269);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 47;
            label5.Text = "Reps";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ControlLight;
            label6.Location = new Point(341, 269);
            label6.Name = "label6";
            label6.Size = new Size(36, 20);
            label6.TabIndex = 47;
            label6.Text = "Sets";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ControlLight;
            label7.Location = new Point(504, 269);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 47;
            label7.Text = "Weight";
            // 
            // errorProvider
            // 
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(172, 138);
            label1.Name = "label1";
            label1.Size = new Size(31, 21);
            label1.TabIndex = 48;
            label1.Text = "ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(425, 152);
            label3.Name = "label3";
            label3.Size = new Size(31, 21);
            label3.TabIndex = 48;
            label3.Text = "ID:";
            // 
            // frmWorkoutDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            ClientSize = new Size(819, 646);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtSets);
            Controls.Add(txtWeight);
            Controls.Add(txtReps);
            Controls.Add(cmbExerciseTitle);
            Controls.Add(cmbWorkoutTitle);
            Controls.Add(lblExerciseID);
            Controls.Add(lblWorkoutID);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnPrevious);
            Controls.Add(btnLast);
            Controls.Add(btnDelete);
            Controls.Add(btnNext);
            Controls.Add(btnUpdate);
            Controls.Add(btnFirst);
            Controls.Add(btnCreate);
            Controls.Add(label4);
            Controls.Add(lblWorkouts);
            Controls.Add(label2);
            Name = "frmWorkoutDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Workout Details Management";
            Load += frmWorkoutExercises_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWorkoutID;
        private Button btnCancel;
        private Button btnSave;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnCreate;
        private Label lblWorkouts;
        private Label label2;
        private Label label4;
        private Label lblExerciseID;
        private ComboBox cmbWorkoutTitle;
        private ComboBox cmbExerciseTitle;
        private Button btnFirst;
        private Button btnNext;
        private Button btnLast;
        private Button btnPrevious;
        private TextBox txtWeight;
        private TextBox txtReps;
        private TextBox txtSets;
        private Label label5;
        private Label label6;
        private Label label7;
        private ErrorProvider errorProvider;
        private Label label3;
        private Label label1;
    }
}