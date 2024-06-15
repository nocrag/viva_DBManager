using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkoutApp
{
    public partial class frmMDIParent : Form
    {
        public frmMDIParent()
        {
            InitializeComponent();

        }
        private void ShowNewForm(object sender, EventArgs e)
        {
            object? tagSender = null;

            if (sender is Button)
                tagSender = ((Button)sender).Tag;
            else if (sender is ToolStripMenuItem)
                tagSender = ((ToolStripMenuItem)sender).Tag;
            else
                tagSender = ((ToolStripButton)sender).Tag;



            Form childForm = null;

            switch (tagSender.ToString())
            {
                case "Workout":
                    childForm = new frmWorkout();
                    break;
                case "Exercise":
                    childForm = new frmExercise();
                    break;
                case "Muscles":
                    childForm = new frmMuscle();
                    break;
                case "Browse":
                    childForm = new frmWorkoutDetailsBrowser();
                    break;
                case "Workout Details":
                    childForm = new frmWorkoutDetails();
                    break;
                case "Exercise Muscles":
                    childForm = new frmExerciseMuscle();
                    break;
                case "Users":
                    childForm = new frmUser();
                    break;
                case "BrowseAll":
                    childForm = new frmBrowseAll();
                    break;
                default:
                    MessageBox.Show($"I was called by {tagSender}");
                    break;
            }

            if (childForm != null)
            {
                foreach (Form form in this.MdiChildren)
                {
                    if (form.GetType() == childForm.GetType())
                    {
                        form.Activate();
                        return;
                    }
                }

                childForm.MdiParent = this;
                childForm.Show();
            }
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        public void UpdateToolStripStatusLabel(string message)
        {
            toolStripStatusLabel.Text = message;
        }




        public void UpdateProgressBar()
        {
            lblProgressBar.Text = "Processing...";
            progressBar.Value = 0;
            statusStrip.Refresh();

            while (progressBar.Value < progressBar.Maximum)
            {
                Thread.Sleep(10);
                progressBar.Value += 1;
            }

            progressBar.Value = 100;

            lblProgressBar.Text = "";
            progressBar.Value = 0;
        }

        private void maintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MDIParent_Load(object sender, EventArgs e)
        {
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(35, 35, 35);
        }
    }
}
