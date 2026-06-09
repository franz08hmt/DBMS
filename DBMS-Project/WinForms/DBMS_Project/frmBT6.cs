using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBMS_Project
{
    public partial class frmBT6 : Form
    {
        public frmBT6()
        {
            InitializeComponent();
        }

        // ── fn_LuongTBPhong ───────────────────────────────
        private void btnF1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = DBHelper.GetConnection("DeAn"))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(
                        "SELECT dbo.fn_LuongTBPhong(@MaPB)", conn);
                    cmd.Parameters.AddWithValue("@MaPB", txtF1MaPB.Text.Trim());
                    object val = cmd.ExecuteScalar();
                    lblF1Result.Text = "Ket qua: " +
                        (val != DBNull.Value ? string.Format("{0:N0} VND", val) : "0 VND");
                }
            }
            catch (Exception ex) { lblF1Result.Text = "Loi: " + ex.Message; }
        }

        // ── fn_TongLuongNVTheoDA ──────────────────────────
        private void btnF2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = DBHelper.GetConnection("DeAn"))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(
                        "SELECT dbo.fn_TongLuongNVTheoDA(@MaNV, @MaDA)", conn);
                    cmd.Parameters.AddWithValue("@MaNV", txtF2MaNV.Text.Trim());
                    cmd.Parameters.AddWithValue("@MaDA", txtF2MaDA.Text.Trim());
                    object val = cmd.ExecuteScalar();
                    lblF2Result.Text = "Ket qua: " +
                        (val != DBNull.Value ? string.Format("{0:N0} VND", val) : "0 VND");
                }
            }
            catch (Exception ex) { lblF2Result.Text = "Loi: " + ex.Message; }
        }

        // ── fn_LuongTBTatCaPhong ──────────────────────────
        private void btnF3_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = DBHelper.GetConnection("DeAn"))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(
                        "SELECT dbo.fn_LuongTBTatCaPhong()", conn);
                    object val = cmd.ExecuteScalar();
                    lblF3Result.Text = "Ket qua: " +
                        (val != DBNull.Value ? string.Format("{0:N0} VND", val) : "0 VND");
                }
            }
            catch (Exception ex) { lblF3Result.Text = "Loi: " + ex.Message; }
        }

        // ── fn_TienThuongTheoGio ──────────────────────────
        private void btnF4_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtF4Gio.Text.Trim(), out decimal gio))
            {
                lblF4Result.Text = "Loi: Nhap so gio hop le!";
                return;
            }
            try
            {
                using (SqlConnection conn = DBHelper.GetConnection("DeAn"))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(
                        "SELECT dbo.fn_TienThuongTheoGio(@Gio)", conn);
                    cmd.Parameters.AddWithValue("@Gio", gio);
                    object val = cmd.ExecuteScalar();
                    lblF4Result.Text = "Tien thuong: $" +
                        (val != DBNull.Value ? val.ToString() : "0");
                }
            }
            catch (Exception ex) { lblF4Result.Text = "Loi: " + ex.Message; }
        }

        // ── fn_TongSoDATheoPhong ──────────────────────────
        private void btnF5_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = DBHelper.GetConnection("DeAn"))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(
                        "SELECT dbo.fn_TongSoDATheoPhong(@MaPB)", conn);
                    cmd.Parameters.AddWithValue("@MaPB", txtF5MaPB.Text.Trim());
                    object val = cmd.ExecuteScalar();
                    lblF5Result.Text = "So du an: " +
                        (val != DBNull.Value ? val.ToString() : "0");
                }
            }
            catch (Exception ex) { lblF5Result.Text = "Loi: " + ex.Message; }
        }

        // ── fn_ThongTinNhanVien_Inline ────────────────────
        private void btnF6Inline_Click(object sender, EventArgs e)
        {
            LoadTVF("fn_ThongTinNhanVien_Inline");
        }

        // ── fn_ThongTinNhanVien_Multi ─────────────────────
        private void btnF6Multi_Click(object sender, EventArgs e)
        {
            LoadTVF("fn_ThongTinNhanVien_Multi");
        }

        private void LoadTVF(string funcName)
        {
            try
            {
                using (SqlConnection conn = DBHelper.GetConnection("DeAn"))
                {
                    conn.Open();
                    string maPB = string.IsNullOrWhiteSpace(txtF6MaPB.Text)
                        ? "NULL" : "'" + txtF6MaPB.Text.Trim() + "'";
                    string sql = "SELECT * FROM dbo." + funcName + "(" + maPB + ")";
                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvF6.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message, "Loi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e) { this.Close(); }
    }
}