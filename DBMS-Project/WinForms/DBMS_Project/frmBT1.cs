using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBMS_Project
{
    public partial class frmBT1 : Form
    {
        public frmBT1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtSoA.Text.Trim(), out int soA))
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ cho Số 1!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtSoB.Text.Trim(), out int soB))
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ cho Số 2!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = DBHelper.GetConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_TinhTongHaiSo", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Tên param khớp với SP trong SQL mới
                    cmd.Parameters.AddWithValue("@SoThu1", soA);
                    cmd.Parameters.AddWithValue("@SoThu2", soB);

                    SqlParameter outputParam = new SqlParameter("@TongSo", SqlDbType.Int);
                    outputParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(outputParam);

                    cmd.ExecuteNonQuery();

                    txtKetQua.Text = outputParam.Value.ToString();
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