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
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            lblProductName.Text = Application.ProductName + "Management";
            lblVersion.Text = Application.ProductVersion;
            lblCreator.Text = Application.CompanyName;

        }

        private void mdiClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void timerProgressBar_Tick(object sender, EventArgs e)
        {
            progressBarSplash.Increment(2);

            if(progressBarSplash.Value >= 100 ) 
            {
                timerProgressBar.Enabled = false;

                this.Hide();

                frmLogin login = new frmLogin();
                login.Show();
            
            }
        }
    }
}
