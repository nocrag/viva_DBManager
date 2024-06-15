namespace WorkoutApp
{
    partial class frmUser
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
            lblUserID = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            btnPrevious = new Button();
            btnLast = new Button();
            btnDelete = new Button();
            btnNext = new Button();
            btnUpdate = new Button();
            btnFirst = new Button();
            btnCreate = new Button();
            lblWorkouts = new Label();
            lblID = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            label1 = new Label();
            txtPassword = new TextBox();
            errorProvider = new ErrorProvider(components);
            chkShowPassword = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserID.ForeColor = SystemColors.ControlLight;
            lblUserID.Location = new Point(123, 85);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(32, 25);
            lblUserID.TabIndex = 42;
            lblUserID.Text = "ID";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(31, 31, 31);
            btnCancel.CausesValidation = false;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.ButtonHighlight;
            btnCancel.Location = new Point(123, 388);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(599, 43);
            btnCancel.TabIndex = 41;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(31, 31, 31);
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.ForeColor = Color.Cornsilk;
            btnSave.Location = new Point(123, 327);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(599, 43);
            btnSave.TabIndex = 40;
            btnSave.Text = "Save new user";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = Color.FromArgb(66, 135, 245);
            btnPrevious.FlatStyle = FlatStyle.Popup;
            btnPrevious.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnPrevious.ForeColor = SystemColors.ButtonHighlight;
            btnPrevious.Location = new Point(304, 468);
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
            btnLast.Location = new Point(556, 468);
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
            btnDelete.Location = new Point(534, 269);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(188, 35);
            btnDelete.TabIndex = 34;
            btnDelete.Text = "Delete Current User";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(66, 135, 245);
            btnNext.FlatStyle = FlatStyle.Popup;
            btnNext.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnNext.ForeColor = SystemColors.ButtonHighlight;
            btnNext.Location = new Point(431, 468);
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
            btnUpdate.Location = new Point(318, 269);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(194, 35);
            btnUpdate.TabIndex = 36;
            btnUpdate.Text = "Update Current User";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnFirst
            // 
            btnFirst.BackColor = Color.FromArgb(66, 135, 245);
            btnFirst.FlatStyle = FlatStyle.Popup;
            btnFirst.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnFirst.ForeColor = SystemColors.ButtonHighlight;
            btnFirst.Location = new Point(185, 468);
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
            btnCreate.Location = new Point(123, 269);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(168, 35);
            btnCreate.TabIndex = 38;
            btnCreate.Text = "Create New User";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // lblWorkouts
            // 
            lblWorkouts.AutoSize = true;
            lblWorkouts.Font = new Font("HeadingNow Trial 65 Medium", 17.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblWorkouts.ForeColor = SystemColors.ControlLight;
            lblWorkouts.Location = new Point(295, 9);
            lblWorkouts.Name = "lblWorkouts";
            lblWorkouts.Size = new Size(256, 31);
            lblWorkouts.TabIndex = 31;
            lblWorkouts.Text = "Users Management";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblID.ForeColor = SystemColors.ControlLight;
            lblID.Location = new Point(123, 54);
            lblID.Name = "lblID";
            lblID.Size = new Size(59, 20);
            lblID.TabIndex = 30;
            lblID.Tag = " ";
            lblID.Text = "User ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(123, 123);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 29;
            label2.Tag = " ";
            label2.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(123, 146);
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(599, 27);
            txtUsername.TabIndex = 32;
            txtUsername.Tag = "Title";
            txtUsername.Validating += txt_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(123, 181);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 29;
            label1.Tag = " ";
            label1.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(123, 204);
            txtPassword.Name = "txtPassword";
            txtPassword.ReadOnly = true;
            txtPassword.Size = new Size(599, 27);
            txtPassword.TabIndex = 32;
            txtPassword.Tag = "Title";
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.Validating += txt_Validating;
            // 
            // errorProvider
            // 
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider.ContainerControl = this;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.ForeColor = SystemColors.ControlLight;
            chkShowPassword.Location = new Point(123, 237);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(108, 19);
            chkShowPassword.TabIndex = 43;
            chkShowPassword.Text = "Show Password";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // frmUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            ClientSize = new Size(845, 561);
            Controls.Add(chkShowPassword);
            Controls.Add(lblUserID);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnPrevious);
            Controls.Add(btnLast);
            Controls.Add(btnDelete);
            Controls.Add(btnNext);
            Controls.Add(btnUpdate);
            Controls.Add(btnFirst);
            Controls.Add(btnCreate);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Controls.Add(lblWorkouts);
            Controls.Add(label2);
            Controls.Add(lblID);
            Name = "frmUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Users Management";
            FormClosing += frmUser_FormClosing;
            Load += frmUser_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUserID;
        private Button btnCancel;
        private Button btnSave;
        private Button btnPrevious;
        private Button btnLast;
        private Button btnDelete;
        private Button btnNext;
        private Button btnUpdate;
        private Button btnFirst;
        private Button btnCreate;
        private Label lblWorkouts;
        private Label lblID;
        private Label label2;
        private TextBox txtUsername;
        private Label label1;
        private TextBox txtPassword;
        private ErrorProvider errorProvider;
        private CheckBox chkShowPassword;
    }
}