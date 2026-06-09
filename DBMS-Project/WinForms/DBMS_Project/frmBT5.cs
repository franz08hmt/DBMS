using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBMS_Project
{
    public partial class frmBT5 : Form
    {
        public frmBT5()
        {
            InitializeComponent();
        }

        private void Log(string msg)
        {
            txtResult.AppendText(msg + "\r\n");
        }

        private void ClearLog()
        {
            txtResult.Clear();
        }

        // ── tg_insMuon: INSERT vào Muon ───────────────────
        private void btnInsert_Click(object sender, EventArgs e)
        {
            ClearLog();
            try
            {
                using (SqlConnection conn = DBHelper.GetConnection())
                {
                    conn.Open();

                    // Lấy tinhtrang TRƯỚC khi INSERT
                    string ttTruoc = GetTinhTrang(conn, txtInsISBN.Text, txtInsCS.Text);
                    Log("[TRUOC INSERT] Cuonsach " + txtInsISBN.Text + "/" + txtInsCS.Text
                        + " — tinhtrang = " + ttTruoc);

                    // INSERT phiếu mượn — trigger tg_insMuon tự chạy
                    string sql = @"INSERT INTO Muon(isbn, ma_cuonsach, ma_DocGia, ngay_muon, ngay_hethan)
                                   VALUES(@isbn, @cs, @dg, GETDATE(), DATEADD(DAY,14,GETDATE()))";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@isbn", txtInsISBN.Text.Trim());
                    cmd.Parameters.AddWithValue("@cs", txtInsCS.Text.Trim());
                    cmd.Parameters.AddWithValue("@dg", txtInsDG.Text.Trim());
                    cmd.ExecuteNonQuery();

                    // Lấy tinhtrang SAU INSERT
                    string ttSau = GetTinhTrang(conn, txtInsISBN.Text, txtInsCS.Text);
                    Log("[SAU INSERT]  Cuonsach " + txtInsISBN.Text + "/" + txtInsCS.Text
                        + " — tinhtrang = " + ttSau);
                    Log("=> Trigger tg_insMuon da cap nhat tinhtrang: " + ttTruoc + " -> " + ttSau);
                }
            }
            catch (Exception ex)
            {
                Log("[LOI] " + ex.Message);
            }
        }

        // ── tg_delMuon: DELETE khỏi Muon ─────────────────
        private void btnDelete_Click(object sender, EventArgs e)
        {
            ClearLog();
            try
            {
                using (SqlConnection conn = DBHelper.GetConnection())
                {
                    conn.Open();

                    string ttTruoc = GetTinhTrang(conn, txtDelISBN.Text, txtDelCS.Text);
                    Log("[TRUOC DELETE] Cuonsach " + txtDelISBN.Text + "/" + txtDelCS.Text
                        + " — tinhtrang = " + ttTruoc);

                    string sql = @"DELETE FROM Muon
                                   WHERE isbn=@isbn AND ma_cuonsach=@cs AND ma_DocGia=@dg";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@isbn", txtDelISBN.Text.Trim());
                    cmd.Parameters.AddWithValue("@cs", txtDelCS.Text.Trim());
                    cmd.Parameters.AddWithValue("@dg", txtDelDG.Text.Trim());
                    int rows = cmd.ExecuteNonQuery();

                    if (rows == 0)
                    {
                        Log("[CANH BAO] Khong tim thay phieu muon de xoa.");
                        return;
                    }

                    string ttSau = GetTinhTrang(conn, txtDelISBN.Text, txtDelCS.Text);
                    Log("[SAU DELETE]  Cuonsach " + txtDelISBN.Text + "/" + txtDelCS.Text
                        + " — tinhtrang = " + ttSau);
                    Log("=> Trigger tg_delMuon da cap nhat tinhtrang: " + ttTruoc + " -> " + ttSau);
                }
            }
            catch (Exception ex)
            {
                Log("[LOI] " + ex.Message);
            }
        }

        // ── tg_updCuonSach: UPDATE Cuonsach ──────────────
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ClearLog();
            try
            {
                using (SqlConnection conn = DBHelper.GetConnection())
                {
                    conn.Open();

                    string ttTruocCS = GetTinhTrang(conn, txtUpdISBN.Text, txtUpdCS.Text);
                    string ttTruocDS = GetTrangThaiDausach(conn, txtUpdISBN.Text);
                    Log("[TRUOC UPDATE] Cuonsach tinhtrang = " + ttTruocCS);
                    Log("[TRUOC UPDATE] Dausach trangthai  = " + ttTruocDS);

                    string sql = "UPDATE Cuonsach SET tinhtrang=@tt WHERE isbn=@isbn AND ma_cuonsach=@cs";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@tt", cmbUpdTT.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@isbn", txtUpdISBN.Text.Trim());
                    cmd.Parameters.AddWithValue("@cs", txtUpdCS.Text.Trim());
                    cmd.ExecuteNonQuery();

                    string ttSauCS = GetTinhTrang(conn, txtUpdISBN.Text, txtUpdCS.Text);
                    string ttSauDS = GetTrangThaiDausach(conn, txtUpdISBN.Text);
                    Log("[SAU UPDATE]  Cuonsach tinhtrang = " + ttSauCS);
                    Log("[SAU UPDATE]  Dausach trangthai  = " + ttSauDS);
                    Log("=> Trigger tg_updCuonSach da cap nhat trangthai Dausach: "
                        + ttTruocDS + " -> " + ttSauDS);
                }
            }
            catch (Exception ex)
            {
                Log("[LOI] " + ex.Message);
            }
        }

        // ── tg_InfThongBao: INSERT Tuasach ────────────────
        private void btnTBInsert_Click(object sender, EventArgs e)
        {
            ClearLog();
            try
            {
                using (SqlConnection conn = DBHelper.GetConnection())
                {
                    conn.Open();
                    string sql = @"INSERT INTO Tuasach(ma_tuasach, tuasach, tacgia)
                                   VALUES(@ma, @ten, N'Tac gia mau')";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ma", txtTBMa.Text.Trim());
                    cmd.Parameters.AddWithValue("@ten", txtTBTen.Text.Trim());
                    cmd.ExecuteNonQuery();
                    Log("[INSERT Tuasach] Ma: " + txtTBMa.Text + " — Ten: " + txtTBTen.Text);
                    Log("=> Trigger tg_InfThongBao da chay — 'Da them moi tua sach'");
                }
            }
            catch (Exception ex) { Log("[LOI] " + ex.Message); }
        }

        // ── tg_InfThongBao: UPDATE Tuasach ───────────────
        private void btnTBUpdate_Click(object sender, EventArgs e)
        {
            ClearLog();
            try
            {
                using (SqlConnection conn = DBHelper.GetConnection())
                {
                    conn.Open();
                    string sql = "UPDATE Tuasach SET tuasach=@ten WHERE ma_tuasach=@ma";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ma", txtTBMa.Text.Trim());
                    cmd.Parameters.AddWithValue("@ten", txtTBTen.Text.Trim());
                    int rows = cmd.ExecuteNonQuery();
                    if (rows == 0) { Log("[CANH BAO] Khong tim thay ma tua sach: " + txtTBMa.Text); return; }
                    Log("[UPDATE Tuasach] Ma: " + txtTBMa.Text + " — Ten moi: " + txtTBTen.Text);
                    Log("=> Trigger tg_InfThongBao da chay — 'Da them moi tua sach'");
                }
            }
            catch (Exception ex) { Log("[LOI] " + ex.Message); }
        }

        private void btnQuayLai_Click(object sender, EventArgs e) { this.Close(); }

        // ── Helper methods ────────────────────────────────
        private string GetTinhTrang(SqlConnection conn, string isbn, string maCS)
        {
            SqlCommand cmd = new SqlCommand(
                "SELECT tinhtrang FROM Cuonsach WHERE isbn=@isbn AND ma_cuonsach=@cs", conn);
            cmd.Parameters.AddWithValue("@isbn", isbn.Trim());
            cmd.Parameters.AddWithValue("@cs", maCS.Trim());
            object val = cmd.ExecuteScalar();
            return val != null ? val.ToString() : "KHONG TIM THAY";
        }

        private string GetTrangThaiDausach(SqlConnection conn, string isbn)
        {
            SqlCommand cmd = new SqlCommand(
                "SELECT trangthai FROM Dausach WHERE isbn=@isbn", conn);
            cmd.Parameters.AddWithValue("@isbn", isbn.Trim());
            object val = cmd.ExecuteScalar();
            return val != null ? val.ToString() : "KHONG TIM THAY";
        }
    }
}