namespace WorkoutApp
{
    partial class frmMuscle
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
            lblID = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            btnPrevious = new Button();
            btnLast = new Button();
            btnDelete = new Button();
            btnNext = new Button();
            btnUpdate = new Button();
            btnFirst = new Button();
            btnCreate = new Button();
            txtMuscleTitle = new TextBox();
            lblWorkouts = new Label();
            label2 = new Label();
            label1 = new Label();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblID.ForeColor = SystemColors.ControlLight;
            lblID.Location = new Point(166, 103);
            lblID.Name = "lblID";
            lblID.Size = new Size(32, 25);
            lblID.TabIndex = 42;
            lblID.Text = "ID";
            // 
            // btnCancel
            // 
            btnCancel.CausesValidation = false;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.ButtonHighlight;
            btnCancel.Location = new Point(166, 345);
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
            btnSave.Location = new Point(166, 284);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(468, 43);
            btnSave.TabIndex = 40;
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
            btnPrevious.Location = new Point(291, 422);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(97, 35);
            btnPrevious.TabIndex = 39;
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
            btnLast.Location = new Point(537, 422);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(97, 35);
            btnLast.TabIndex = 33;
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
            btnDelete.Location = new Point(510, 232);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(124, 35);
            btnDelete.TabIndex = 34;
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
            btnNext.Location = new Point(412, 422);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(97, 35);
            btnNext.TabIndex = 35;
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
            btnUpdate.Location = new Point(340, 232);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(124, 35);
            btnUpdate.TabIndex = 36;
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
            btnFirst.Location = new Point(166, 422);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(97, 35);
            btnFirst.TabIndex = 37;
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
            btnCreate.Location = new Point(166, 232);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(124, 35);
            btnCreate.TabIndex = 38;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtMuscleTitle
            // 
            txtMuscleTitle.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMuscleTitle.Location = new Point(166, 185);
            txtMuscleTitle.Name = "txtMuscleTitle";
            txtMuscleTitle.ReadOnly = true;
            txtMuscleTitle.Size = new Size(468, 27);
            txtMuscleTitle.TabIndex = 32;
            txtMuscleTitle.Tag = "Title";
            txtMuscleTitle.Validating += txtMuscleTitle_Validating;
            // 
            // lblWorkouts
            // 
            lblWorkouts.AutoSize = true;
            lblWorkouts.Font = new Font("HeadingNow Trial 65 Medium", 17.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblWorkouts.ForeColor = SystemColors.ControlLightLight;
            lblWorkouts.Location = new Point(234, 24);
            lblWorkouts.Name = "lblWorkouts";
            lblWorkouts.Size = new Size(288, 31);
            lblWorkouts.TabIndex = 31;
            lblWorkouts.Text = "Muscles Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(166, 156);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 29;
            label2.Tag = " ";
            label2.Text = "Muscle Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(166, 72);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 30;
            label1.Tag = " ";
            label1.Text = "Muscle ID";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // frmMuscle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            ClientSize = new Size(800, 508);
            Controls.Add(lblID);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnPrevious);
            Controls.Add(btnLast);
            Controls.Add(btnDelete);
            Controls.Add(btnNext);
            Controls.Add(btnUpdate);
            Controls.Add(btnFirst);
            Controls.Add(btnCreate);
            Controls.Add(txtMuscleTitle);
            Controls.Add(lblWorkouts);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmMuscle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Muscle Management";
            FormClosing += frmMuscle_FormClosing;
            Load += frmMuscle_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblID;
        private Button btnCancel;
        private Button btnSave;
        private Button btnPrevious;
        private Button btnLast;
        private Button btnDelete;
        private Button btnNext;
        private Button btnUpdate;
        private Button btnFirst;
        private Button btnCreate;
        private TextBox txtMuscleTitle;
        private Label lblWorkouts;
        private Label label2;
        private Label label1;
        private ErrorProvider errorProvider;
    }
}