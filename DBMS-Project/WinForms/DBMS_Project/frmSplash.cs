using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace DBMS_Project
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
            LoadLogo();
        }

        private void LoadLogo()
        {
            picLogo.Image = DBMS_Project.Properties.Resources.Logo_HCM_UTE_2;
        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();
            this.Hide();
        }

        private void picLogo_Click(object sender, EventArgs e)
        {

        }
    }
}