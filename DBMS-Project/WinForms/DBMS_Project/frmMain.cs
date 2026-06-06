using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_Project
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnKetNoi_Click(object sender, EventArgs e)
        {
            if (DBHelper.TestConnection())
            {
                lblStatus.Text = "Trạng thái: ✅ Kết nối CSDL thành công!";
                lblStatus.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblStatus.Text = "Trạng thái: ❌ Kết nối thất bại — kiểm tra SQL Server!";
                lblStatus.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void btnBT1_Click(object sender, EventArgs e)
        {
            frmBT1 frm = new frmBT1();
            frm.ShowDialog();
        }
        private void btnBT2_Click(object sender, EventArgs e)
        {
            frmBT2 frm = new frmBT2();
            frm.ShowDialog();
        }
        private void btnBT3_Click(object sender, EventArgs e) { }
        private void btnBT4_Click(object sender, EventArgs e) { }
        private void btnBT5_Click(object sender, EventArgs e) { }
        private void btnBT6_Click(object sender, EventArgs e) { }
    }
}