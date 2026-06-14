using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DBMS_Project
{
    public partial class frmBT3 : Form
    {
        public frmBT3()
        {
            InitializeComponent();
        }

        private void btnTinhTuoi_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNamSinh.Text.Trim(), out int namSinh))
            {
                MessageBox.Show("Vui lòng nhập năm sinh là số nguyên hợp lệ!",
                    "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int namHienTai = DateTime.Now.Year;
            if (namSinh < 1900 || namSinh > namHienTai)
            {
                MessageBox.Show($"Năm sinh phải từ 1900 đến {namHienTai}!",
                    "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = DBHelper.GetConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(
                        "SELECT dbo.fn_TinhTuoi(@NamSinh)", conn);
                    cmd.Parameters.AddWithValue("@NamSinh", namSinh);

                    int tuoi = Convert.ToInt32(cmd.ExecuteScalar());
                    txtKetQua.Text = tuoi + " tuổi";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi kết nối",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}