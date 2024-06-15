namespace WorkoutApp
{
    partial class frmSplash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            lblProductName = new Label();
            lblVersion = new Label();
            lblCreator = new Label();
            progressBarSplash = new ProgressBar();
            timerProgressBar = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            SuspendLayout();
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductName.Location = new Point(71, 52);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(0, 30);
            lblProductName.TabIndex = 1;
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVersion.Location = new Point(71, 126);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(0, 30);
            lblVersion.TabIndex = 1;
            // 
            // lblCreator
            // 
            lblCreator.AutoSize = true;
            lblCreator.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreator.Location = new Point(48, 340);
            lblCreator.Name = "lblCreator";
            lblCreator.Size = new Size(0, 30);
            lblCreator.TabIndex = 1;
            // 
            // progressBarSplash
            // 
            progressBarSplash.Location = new Point(48, 397);
            progressBarSplash.Name = "progressBarSplash";
            progressBarSplash.Size = new Size(625, 23);
            progressBarSplash.TabIndex = 2;
            // 
            // timerProgressBar
            // 
            timerProgressBar.Enabled = true;
            timerProgressBar.Interval = 50;
            timerProgressBar.Tick += timerProgressBar_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Doctor Glitch", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(324, 440);
            label1.Name = "label1";
            label1.Size = new Size(159, 16);
            label1.TabIndex = 3;
            label1.Text = "No Pain No Gain";
            // 
            // frmSplash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(861, 474);
            Controls.Add(label1);
            Controls.Add(progressBarSplash);
            Controls.Add(lblCreator);
            Controls.Add(lblVersion);
            Controls.Add(lblProductName);
            Name = "frmSplash";
            Text = "GymApp Management";
            Load += frmSplash_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblProductName;
        private Label lblVersion;
        private Label lblCreator;
        private ProgressBar progressBarSplash;
        private System.Windows.Forms.Timer timerProgressBar;
        private Label label1;
    }
}