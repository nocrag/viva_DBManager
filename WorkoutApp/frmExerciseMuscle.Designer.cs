namespace WorkoutApp
{
    partial class frmExerciseMuscle
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
            label3 = new Label();
            label1 = new Label();
            cmbMuscleTitle = new ComboBox();
            cmbExerciseTitle = new ComboBox();
            lblExerciseID = new Label();
            lblMuscleID = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            btnPrevious = new Button();
            btnLast = new Button();
            btnDelete = new Button();
            btnNext = new Button();
            btnUpdate = new Button();
            btnFirst = new Button();
            btnCreate = new Button();
            label4 = new Label();
            lblWorkouts = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(420, 79);
            label3.Name = "label3";
            label3.Size = new Size(31, 21);
            label3.TabIndex = 72;
            label3.Text = "ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(167, 65);
            label1.Name = "label1";
            label1.Size = new Size(31, 21);
            label1.TabIndex = 71;
            label1.Text = "ID:";
            // 
            // cmbMuscleTitle
            // 
            cmbMuscleTitle.FormattingEnabled = true;
            cmbMuscleTitle.Location = new Point(420, 123);
            cmbMuscleTitle.Name = "cmbMuscleTitle";
            cmbMuscleTitle.Size = new Size(214, 23);
            cmbMuscleTitle.TabIndex = 64;
            // 
            // cmbExerciseTitle
            // 
            cmbExerciseTitle.FormattingEnabled = true;
            cmbExerciseTitle.Location = new Point(166, 123);
            cmbExerciseTitle.Name = "cmbExerciseTitle";
            cmbExerciseTitle.Size = new Size(214, 23);
            cmbExerciseTitle.TabIndex = 63;
            // 
            // lblExerciseID
            // 
            lblExerciseID.AutoSize = true;
            lblExerciseID.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblExerciseID.ForeColor = SystemColors.ControlLight;
            lblExerciseID.Location = new Point(457, 82);
            lblExerciseID.Name = "lblExerciseID";
            lblExerciseID.Size = new Size(22, 17);
            lblExerciseID.TabIndex = 62;
            lblExerciseID.Text = "ID";
            // 
            // lblMuscleID
            // 
            lblMuscleID.AutoSize = true;
            lblMuscleID.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMuscleID.ForeColor = SystemColors.ControlLight;
            lblMuscleID.Location = new Point(200, 69);
            lblMuscleID.Name = "lblMuscleID";
            lblMuscleID.Size = new Size(22, 17);
            lblMuscleID.TabIndex = 61;
            lblMuscleID.Text = "ID";
            // 
            // btnCancel
            // 
            btnCancel.CausesValidation = false;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.ButtonHighlight;
            btnCancel.Location = new Point(166, 304);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(468, 43);
            btnCancel.TabIndex = 60;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(35, 35, 35);
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.ForeColor = Color.Cornsilk;
            btnSave.Location = new Point(166, 243);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(468, 43);
            btnSave.TabIndex = 59;
            btnSave.Text = "Save workout";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = Color.FromArgb(66, 135, 245);
            btnPrevious.FlatStyle = FlatStyle.Popup;
            btnPrevious.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnPrevious.ForeColor = SystemColors.ButtonHighlight;
            btnPrevious.Location = new Point(286, 388);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(97, 35);
            btnPrevious.TabIndex = 58;
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
            btnLast.Location = new Point(538, 388);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(97, 35);
            btnLast.TabIndex = 52;
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
            btnDelete.Location = new Point(510, 184);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(124, 35);
            btnDelete.TabIndex = 53;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(66, 135, 245);
            btnNext.FlatStyle = FlatStyle.Popup;
            btnNext.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnNext.ForeColor = SystemColors.ButtonHighlight;
            btnNext.Location = new Point(413, 388);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(97, 35);
            btnNext.TabIndex = 54;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(66, 135, 245);
            btnUpdate.Enabled = false;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnUpdate.ForeColor = SystemColors.ButtonHighlight;
            btnUpdate.Location = new Point(340, 184);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(124, 35);
            btnUpdate.TabIndex = 55;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnFirst
            // 
            btnFirst.BackColor = Color.FromArgb(66, 135, 245);
            btnFirst.FlatStyle = FlatStyle.Popup;
            btnFirst.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnFirst.ForeColor = SystemColors.ButtonHighlight;
            btnFirst.Location = new Point(167, 388);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(97, 35);
            btnFirst.TabIndex = 56;
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
            btnCreate.Location = new Point(166, 184);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(124, 35);
            btnCreate.TabIndex = 57;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlLight;
            label4.Location = new Point(420, 100);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 50;
            label4.Tag = " ";
            label4.Text = "Muscle";
            // 
            // lblWorkouts
            // 
            lblWorkouts.AutoSize = true;
            lblWorkouts.Font = new Font("HeadingNow Trial 65 Medium", 17.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblWorkouts.ForeColor = SystemColors.ControlLight;
            lblWorkouts.Location = new Point(200, 9);
            lblWorkouts.Name = "lblWorkouts";
            lblWorkouts.Size = new Size(402, 31);
            lblWorkouts.TabIndex = 51;
            lblWorkouts.Text = "Exercise Muscles Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(167, 90);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 49;
            label2.Tag = " ";
            label2.Text = "Exercise";
            // 
            // frmExerciseMuscle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            ClientSize = new Size(800, 517);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(cmbMuscleTitle);
            Controls.Add(cmbExerciseTitle);
            Controls.Add(lblExerciseID);
            Controls.Add(lblMuscleID);
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
            Name = "frmExerciseMuscle";
            Text = "ExerciseMuscle";
            Load += frmExerciseMuscle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label1;
        private ComboBox cmbMuscleTitle;
        private ComboBox cmbExerciseTitle;
        private Label lblExerciseID;
        private Label lblMuscleID;
        private Button btnCancel;
        private Button btnSave;
        private Button btnPrevious;
        private Button btnLast;
        private Button btnDelete;
        private Button btnNext;
        private Button btnUpdate;
        private Button btnFirst;
        private Button btnCreate;
        private Label label4;
        private Label lblWorkouts;
        private Label label2;
    }
}