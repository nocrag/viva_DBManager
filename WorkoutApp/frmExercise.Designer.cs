namespace WorkoutApp
{
    partial class frmExercise
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
            btnLast = new Button();
            btnDelete = new Button();
            btnNext = new Button();
            btnUpdate = new Button();
            btnFirst = new Button();
            btnCreate = new Button();
            lblExerciseTitle = new Label();
            label1 = new Label();
            txtExerciseInstructions = new TextBox();
            lblExerciseDescription = new Label();
            lblExerciseInstructions = new Label();
            txtExerciseDescription = new TextBox();
            txtExerciseTitle = new TextBox();
            btnPrevious = new Button();
            btnSave = new Button();
            errorProvider = new ErrorProvider(components);
            btnCancel = new Button();
            lblExerciseID = new Label();
            lblWorkouts = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // btnLast
            // 
            btnLast.BackColor = Color.FromArgb(66, 135, 245);
            btnLast.FlatStyle = FlatStyle.Popup;
            btnLast.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnLast.ForeColor = SystemColors.ButtonHighlight;
            btnLast.Location = new Point(580, 469);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(106, 35);
            btnLast.TabIndex = 7;
            btnLast.Text = "Last";
            btnLast.UseVisualStyleBackColor = false;
            btnLast.Click += btnLast_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(66, 135, 245);
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(292, 195);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(108, 35);
            btnDelete.TabIndex = 8;
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
            btnNext.Location = new Point(432, 469);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(106, 35);
            btnNext.TabIndex = 9;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(66, 135, 245);
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnUpdate.ForeColor = SystemColors.ButtonHighlight;
            btnUpdate.Location = new Point(161, 195);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(108, 35);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnFirst
            // 
            btnFirst.BackColor = Color.FromArgb(66, 135, 245);
            btnFirst.FlatStyle = FlatStyle.Popup;
            btnFirst.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnFirst.ForeColor = SystemColors.ButtonHighlight;
            btnFirst.Location = new Point(156, 469);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(106, 35);
            btnFirst.TabIndex = 11;
            btnFirst.Text = "First";
            btnFirst.UseVisualStyleBackColor = false;
            btnFirst.Click += btnFirst_Click;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.FromArgb(66, 135, 245);
            btnCreate.FlatStyle = FlatStyle.Popup;
            btnCreate.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnCreate.ForeColor = SystemColors.ButtonHighlight;
            btnCreate.Location = new Point(31, 195);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(108, 35);
            btnCreate.TabIndex = 12;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // lblExerciseTitle
            // 
            lblExerciseTitle.AutoSize = true;
            lblExerciseTitle.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblExerciseTitle.ForeColor = SystemColors.ControlLight;
            lblExerciseTitle.Location = new Point(28, 125);
            lblExerciseTitle.Name = "lblExerciseTitle";
            lblExerciseTitle.Size = new Size(97, 20);
            lblExerciseTitle.TabIndex = 5;
            lblExerciseTitle.Tag = " ";
            lblExerciseTitle.Text = "Exercise Title";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(31, 58);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 6;
            label1.Tag = " ";
            label1.Text = "Exercise ID";
            // 
            // txtExerciseInstructions
            // 
            txtExerciseInstructions.Location = new Point(449, 264);
            txtExerciseInstructions.Multiline = true;
            txtExerciseInstructions.Name = "txtExerciseInstructions";
            txtExerciseInstructions.Size = new Size(369, 89);
            txtExerciseInstructions.TabIndex = 3;
            txtExerciseInstructions.Tag = "Instructions";
            txtExerciseInstructions.Validating += txt_Validating;
            // 
            // lblExerciseDescription
            // 
            lblExerciseDescription.AutoSize = true;
            lblExerciseDescription.BackColor = Color.Transparent;
            lblExerciseDescription.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblExerciseDescription.ForeColor = SystemColors.ControlLight;
            lblExerciseDescription.Location = new Point(448, 113);
            lblExerciseDescription.Name = "lblExerciseDescription";
            lblExerciseDescription.Size = new Size(146, 20);
            lblExerciseDescription.TabIndex = 6;
            lblExerciseDescription.Tag = " ";
            lblExerciseDescription.Text = "Exercise Description";
            // 
            // lblExerciseInstructions
            // 
            lblExerciseInstructions.AutoSize = true;
            lblExerciseInstructions.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblExerciseInstructions.ForeColor = SystemColors.ControlLight;
            lblExerciseInstructions.Location = new Point(447, 241);
            lblExerciseInstructions.Name = "lblExerciseInstructions";
            lblExerciseInstructions.Size = new Size(147, 20);
            lblExerciseInstructions.TabIndex = 5;
            lblExerciseInstructions.Tag = " ";
            lblExerciseInstructions.Text = "Exercise Instructions";
            // 
            // txtExerciseDescription
            // 
            txtExerciseDescription.Location = new Point(449, 136);
            txtExerciseDescription.Multiline = true;
            txtExerciseDescription.Name = "txtExerciseDescription";
            txtExerciseDescription.Size = new Size(369, 89);
            txtExerciseDescription.TabIndex = 15;
            txtExerciseDescription.Tag = "Description";
            txtExerciseDescription.Validating += txt_Validating;
            // 
            // txtExerciseTitle
            // 
            txtExerciseTitle.Location = new Point(31, 148);
            txtExerciseTitle.Name = "txtExerciseTitle";
            txtExerciseTitle.Size = new Size(368, 23);
            txtExerciseTitle.TabIndex = 16;
            txtExerciseTitle.Tag = "Title";
            txtExerciseTitle.Validating += txt_Validating;
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = Color.FromArgb(66, 135, 245);
            btnPrevious.FlatStyle = FlatStyle.Popup;
            btnPrevious.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnPrevious.ForeColor = SystemColors.ButtonHighlight;
            btnPrevious.Location = new Point(293, 469);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(106, 35);
            btnPrevious.TabIndex = 17;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(31, 31, 31);
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.ButtonHighlight;
            btnSave.Location = new Point(51, 253);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(331, 43);
            btnSave.TabIndex = 18;
            btnSave.Text = "Save new exercise";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // errorProvider
            // 
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider.ContainerControl = this;
            // 
            // btnCancel
            // 
            btnCancel.CausesValidation = false;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.ForeColor = SystemColors.ButtonHighlight;
            btnCancel.Location = new Point(51, 313);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(331, 43);
            btnCancel.TabIndex = 28;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblExerciseID
            // 
            lblExerciseID.AutoSize = true;
            lblExerciseID.BackColor = Color.Transparent;
            lblExerciseID.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExerciseID.ForeColor = SystemColors.ButtonHighlight;
            lblExerciseID.Location = new Point(51, 83);
            lblExerciseID.Name = "lblExerciseID";
            lblExerciseID.Size = new Size(0, 25);
            lblExerciseID.TabIndex = 29;
            // 
            // lblWorkouts
            // 
            lblWorkouts.AutoSize = true;
            lblWorkouts.Font = new Font("HeadingNow Trial 65 Medium", 17.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblWorkouts.ForeColor = SystemColors.ButtonHighlight;
            lblWorkouts.Location = new Point(298, 18);
            lblWorkouts.Name = "lblWorkouts";
            lblWorkouts.Size = new Size(240, 31);
            lblWorkouts.TabIndex = 30;
            lblWorkouts.Text = "Manage Exercises";
            // 
            // frmExercise
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            ClientSize = new Size(871, 570);
            Controls.Add(lblWorkouts);
            Controls.Add(lblExerciseID);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnPrevious);
            Controls.Add(txtExerciseTitle);
            Controls.Add(txtExerciseDescription);
            Controls.Add(btnLast);
            Controls.Add(btnDelete);
            Controls.Add(btnNext);
            Controls.Add(btnUpdate);
            Controls.Add(btnFirst);
            Controls.Add(btnCreate);
            Controls.Add(lblExerciseInstructions);
            Controls.Add(lblExerciseTitle);
            Controls.Add(lblExerciseDescription);
            Controls.Add(label1);
            Controls.Add(txtExerciseInstructions);
            Name = "frmExercise";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Exercise";
            FormClosing += frmExercise_FormClosing;
            Load += frmExercise_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLast;
        private Button btnDelete;
        private Button btnNext;
        private Button btnUpdate;
        private Button btnFirst;
        private Button btnCreate;
        private Label lblExerciseTitle;
        private Label label1;
        private TextBox txtExerciseInstructions;
        private Label lblExerciseDescription;
        private Label lblExerciseInstructions;
        private TextBox txtExerciseDescription;
        private TextBox txtExerciseTitle;
        private Button btnPrevious;
        private Button btnSave;
        private ErrorProvider errorProvider;
        private Button btnCancel;
        private Label lblExerciseID;
        private Label lblWorkouts;
    }
}