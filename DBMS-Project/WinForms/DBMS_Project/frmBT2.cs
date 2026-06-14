using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBMS_Project
{
    public partial class frmBT2 : Form
    {
        public frmBT2()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string isbn = txtISBN.Text.Trim();
            if (string.IsNullOrEmpty(isbn))
            {
                MessageBox.Show("Vui lòng nhập ISBN!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = DBHelper.GetConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_ThongtinDausach", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@isbn", isbn);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy đầu sách với ISBN: " + isbn,
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvKetQua.DataSource = null;
                    }
                    else
                    {
                        dgvKetQua.DataSource = dt;
                    }
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

        private void lblISBN_Click(object sender, EventArgs e)
        {

        }

        private void txtISBN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}