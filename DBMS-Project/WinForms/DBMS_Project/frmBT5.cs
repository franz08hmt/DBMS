using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DBMS_Project
{
    public partial class frmBT5 : Form
    {
        public frmBT5()
        {
            InitializeComponent();
        }

        // ── Hàm dùng chung: load lại bảng kết quả sau mỗi thao tác ──
        private void LoadKetQua(string isbn, string maCuon)
        {
            try
            {
                using (SqlConnection conn = DBHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"
                        SELECT
                            cs.isbn          AS [ISBN],
                            cs.ma_cuonsach   AS [Mã cuốn],
                            cs.tinhtrang     AS [Tình trạng cuốn],
                            ds.trangthai     AS [Trạng thái đầu sách]
                        FROM Cuonsach cs
                        JOIN Dausach  ds ON ds.isbn = cs.isbn
                        WHERE cs.isbn = @isbn";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    da.SelectCommand.Parameters.AddWithValue("@isbn", isbn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvKetQua.DataSource = dt;
                    dgvKetQua.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                    // Highlight dòng vừa thao tác
                    foreach (DataGridViewRow row in dgvKetQua.Rows)
                    {
                        if (row.Cells["Mã cuốn"].Value?.ToString() == maCuon)
                        {
                            row.DefaultCellStyle.BackColor = Color.LightYellow;
                            row.DefaultCellStyle.Font = new Font(dgvKetQua.Font, FontStyle.Bold);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load kết quả: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ══════════════════════════════════════════
        // TRIGGER 1 — tg_insMuon
        // ══════════════════════════════════════════
        private void btnInsMuon_Click(object sender, EventArgs e)
        {
            string isbn = txtISBN_Ins.Text.Trim();
            string maCuon = txtMaCuon_Ins.Text.Trim();
            string maDocGia = txtMaDocGia_Ins.Text.Trim();

            if (string.IsNullOrEmpty(isbn) ||
                string.IsNullOrEmpty(maCuon) ||
                string.IsNullOrEmpty(maDocGia))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ ISBN, Mã cuốn, Mã độc giả!",
                    "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = DBHelper.GetConnection())
                {
                    conn.Open();

                    // Kiểm tra cuốn sách có sẵn sàng không
                    SqlCommand checkCmd = new SqlCommand(@"
                        SELECT tinhtrang FROM Cuonsach
                        WHERE isbn = @isbn AND ma_cuonsach = @maCuon", conn);
                    checkCmd.Parameters.AddWithValue("@isbn", isbn);
                    checkCmd.Parameters.AddWithValue("@maCuon", maCuon);

                    object tinhTrang = checkCmd.ExecuteScalar();
                    if (tinhTrang == null)
                    {
                        MessageBox.Show("Không tìm thấy cuốn sách với ISBN và Mã cuốn này!",
                            "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (tinhTrang.ToString() == "no")
                    {
                        MessageBox.Show("Cuốn sách này đang được mượn, không thể thêm phiếu mượn mới!",
                            "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    DateTime ngayMuon = DateTime.Today;
                    DateTime ngayHetHan = DateTime.Today.AddDays(14);

                    SqlCommand cmd = new SqlCommand(@"
                        INSERT INTO Muon (isbn, ma_cuonsach, ma_DocGia, ngay_muon, ngay_hethan)
                        VALUES (@isbn, @maCuon, @maDocGia, @ngayMuon, @ngayHetHan)", conn);
                    cmd.Parameters.AddWithValue("@isbn", isbn);
                    cmd.Parameters.AddWithValue("@maCuon", maCuon);
                    cmd.Parameters.AddWithValue("@maDocGia", maDocGia);
                    cmd.Parameters.AddWithValue("@ngayMuon", ngayMuon);
                    cmd.Parameters.AddWithValue("@ngayHetHan", ngayHetHan);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show(
                        $"Đã thêm phiếu mượn thành công!\n" +
                        $"Ngày mượn: {ngayMuon:dd/MM/yyyy} — Hạn trả: {ngayHetHan:dd/MM/yyyy}\n" +
                        $"[tg_insMuon] Tình trạng cuốn sách → \"no\"",
                        "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadKetQua(isbn, maCuon);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi kết nối",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ══════════════════════════════════════════
        // TRIGGER 2 — tg_delMuon
        // ══════════════════════════════════════════
        private void btnDelMuon_Click(object sender, EventArgs e)
        {
            string isbn = txtISBN_Del.Text.Trim();
            string maCuon = txtMaCuon_Del.Text.Trim();
            string maDocGia = txtMaDocGia_Del.Text.Trim();

            if (string.IsNullOrEmpty(isbn) ||
                string.IsNullOrEmpty(maCuon) ||
                string.IsNullOrEmpty(maDocGia))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ ISBN, Mã cuốn, Mã độc giả!",
                    "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = DBHelper.GetConnection())
                {
                    conn.Open();

                    SqlCommand checkCmd = new SqlCommand(@"
                        SELECT COUNT(*) FROM Muon
                        WHERE isbn = @isbn AND ma_cuonsach = @maCuon AND ma_DocGia = @maDocGia", conn);
                    checkCmd.Parameters.AddWithValue("@isbn", isbn);
                    checkCmd.Parameters.AddWithValue("@maCuon", maCuon);
                    checkCmd.Parameters.AddWithValue("@maDocGia", maDocGia);

                    if ((int)checkCmd.ExecuteScalar() == 0)
                    {
                        MessageBox.Show("Không tìm thấy phiếu mượn tương ứng!",
                            "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    SqlCommand cmd = new SqlCommand(@"
                        DELETE FROM Muon
                        WHERE isbn = @isbn AND ma_cuonsach = @maCuon AND ma_DocGia = @maDocGia", conn);
                    cmd.Parameters.AddWithValue("@isbn", isbn);
                    cmd.Parameters.AddWithValue("@maCuon", maCuon);
                    cmd.Parameters.AddWithValue("@maDocGia", maDocGia);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show(
                        "[tg_delMuon] Đã xóa phiếu mượn thành công!\n" +
                        "Tình trạng cuốn sách → \"yes\" (sẵn sàng)",
                        "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadKetQua(isbn, maCuon);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi kết nối",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ══════════════════════════════════════════
        // TRIGGER 3 — tg_updCuonSach
        // ══════════════════════════════════════════
        private void btnUpdCuonSach_Click(object sender, EventArgs e)
        {
            string isbn = txtISBN_Upd.Text.Trim();
            string maCuon = txtMaCuon_Upd.Text.Trim();
            string tinhTrang = txtTinhTrang_Upd.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(isbn) ||
                string.IsNullOrEmpty(maCuon) ||
                string.IsNullOrEmpty(tinhTrang))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ ISBN, Mã cuốn, Tình trạng!",
                    "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tinhTrang != "yes" && tinhTrang != "no")
            {
                MessageBox.Show("Tình trạng chỉ được nhập \"yes\" hoặc \"no\"!",
                    "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = DBHelper.GetConnection())
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(@"
                        UPDATE Cuonsach
                        SET tinhtrang = @tinhTrang
                        WHERE isbn = @isbn AND ma_cuonsach = @maCuon", conn);
                    cmd.Parameters.AddWithValue("@tinhTrang", tinhTrang);
                    cmd.Parameters.AddWithValue("@isbn", isbn);
                    cmd.Parameters.AddWithValue("@maCuon", maCuon);

                    int rows = cmd.ExecuteNonQuery();
                    if (rows == 0)
                    {
                        MessageBox.Show("Không tìm thấy cuốn sách với ISBN và Mã cuốn này!",
                            "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    MessageBox.Show(
                        $"[tg_updCuonSach] Đã cập nhật tình trạng cuốn sách → \"{tinhTrang}\"\n" +
                        $"Trạng thái đầu sách (Dausach) đã được cập nhật tự động.",
                        "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadKetQua(isbn, maCuon);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi kết nối",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ══════════════════════════════════════════
        // TRIGGER 4 — tg_InfThongBao
        // ══════════════════════════════════════════
        private void btnInfThongBao_Click(object sender, EventArgs e)
        {
            string maTuaSach = txtMaTuaSach.Text.Trim();
            string tenTuaSach = txtTenTuaSach.Text.Trim();
            string tacGia = txtTacGia.Text.Trim();

            if (string.IsNullOrEmpty(maTuaSach))
            {
                MessageBox.Show("Vui lòng nhập Mã tựa sách!",
                    "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(tenTuaSach))
            {
                MessageBox.Show("Vui lòng nhập tên tựa sách!",
                    "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = DBHelper.GetConnection())
                {
                    conn.Open();

                    SqlCommand checkCmd = new SqlCommand(
                        "SELECT COUNT(*) FROM Tuasach WHERE ma_tuasach = @maTuaSach", conn);
                    checkCmd.Parameters.AddWithValue("@maTuaSach", maTuaSach);
                    int exists = (int)checkCmd.ExecuteScalar();

                    SqlCommand cmd;
                    string action;

                    if (exists == 0)
                    {
                        // INSERT mới — tacgia để NULL nếu không nhập
                        cmd = new SqlCommand(@"
                            INSERT INTO Tuasach (ma_tuasach, tuasach, tacgia, tomtat)
                            VALUES (@maTuaSach, @tenTuaSach, @tacGia, N'Chưa cập nhật')", conn);
                        cmd.Parameters.AddWithValue("@maTuaSach", maTuaSach);
                        cmd.Parameters.AddWithValue("@tenTuaSach", tenTuaSach);
                        cmd.Parameters.AddWithValue("@tacGia",
                            string.IsNullOrEmpty(tacGia) ? (object)DBNull.Value : tacGia);
                        action = "INSERT";
                    }
                    else
                    {
                        // UPDATE — chỉ cập nhật tacgia nếu người dùng có nhập
                        if (string.IsNullOrEmpty(tacGia))
                        {
                            cmd = new SqlCommand(@"
                                UPDATE Tuasach
                                SET tuasach = @tenTuaSach
                                WHERE ma_tuasach = @maTuaSach", conn);
                        }
                        else
                        {
                            cmd = new SqlCommand(@"
                                UPDATE Tuasach
                                SET tuasach = @tenTuaSach,
                                    tacgia  = @tacGia
                                WHERE ma_tuasach = @maTuaSach", conn);
                            cmd.Parameters.AddWithValue("@tacGia", tacGia);
                        }
                        cmd.Parameters.AddWithValue("@tenTuaSach", tenTuaSach);
                        cmd.Parameters.AddWithValue("@maTuaSach", maTuaSach);
                        action = "UPDATE";
                    }

                    cmd.ExecuteNonQuery();

                    MessageBox.Show(
                        $"[tg_InfThongBao] Thao tác {action} thành công!\n" +
                        $"Trigger đã in: \"Đã thêm mới tựa sách\"",
                        "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Load lại bảng Tuasach vào dgvKetQua
                    SqlDataAdapter da = new SqlDataAdapter(@"
                        SELECT
                            ma_tuasach  AS [Mã tựa sách],
                            tuasach     AS [Tựa sách],
                            tacgia      AS [Tác giả]
                        FROM Tuasach
                        ORDER BY ma_tuasach", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvKetQua.DataSource = dt;
                    dgvKetQua.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                    // Highlight dòng vừa thao tác
                    foreach (DataGridViewRow row in dgvKetQua.Rows)
                    {
                        if (row.Cells["Mã tựa sách"].Value?.ToString() == maTuaSach)
                        {
                            row.DefaultCellStyle.BackColor = Color.LightYellow;
                            row.DefaultCellStyle.Font = new Font(dgvKetQua.Font, FontStyle.Bold);
                        }
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
    }
}