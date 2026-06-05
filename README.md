# 📚 DBMS Project — Stored Procedures, Triggers & Functions

> **Môn học:** Database Management Systems (DBMS) — Chương 3: Database Programming  
> **Nhóm:** 4 thành viên | **Hạn nộp:** 15/06/2026  
> **Repo:** https://github.com/franz08hmt/DBMS

---

## 👥 Thành viên nhóm

| Thành viên | Vai trò | Phần phụ trách |
|---|---|---|
| **Tài** | Leader | BT1 + BT2 + Giao diện WinForms chính + Tổng hợp |
| **Toàn** | Thành viên | BT3 + BT4a + BT4c |
| **Khang** | Thành viên | BT4d + BT4e |
| **Dương** | Thành viên | BT5 (Triggers) + BT6 (Functions) |

---

## 📁 Cấu trúc thư mục

```
DBMS-Project/
├── 📁 SQL/
│   └── BT_Trigger_ThuTuc_Ham_DBMS.sql   ← Toàn bộ SQL: SP + Trigger + Function + dữ liệu mẫu
├── 📁 WinForms/
│   ├── DBMS_Project.sln                 ← Solution C# WinForms
│   ├── Forms/
│   │   ├── frmMain.cs                   ← Giao diện chính (7 nút)
│   │   ├── frmBT1.cs                    ← BT1: sp_TinhTong
│   │   ├── frmBT2.cs                    ← BT2: sp_ThongtinDausach
│   │   ├── frmBT3.cs                    ← BT3: fn_TinhTuoi
│   │   ├── frmBT4.cs                    ← BT4: các SP thư viện
│   │   ├── frmBT5.cs                    ← BT5: Triggers
│   │   └── frmBT6.cs                    ← BT6: Functions CSDL Đề Án
│   └── Helpers/
│       └── DBHelper.cs                  ← Class kết nối SQL Server dùng chung
└── 📁 Docs/
    ├── PhanCong_DBMS_Nhom4.docx
    └── BaoCao_CuoiKy.docx               ← P1 báo cáo cá nhân (nộp sau)
```

---

## ⚙️ Yêu cầu cài đặt

| Công cụ | Phiên bản | Ghi chú |
|---|---|---|
| SQL Server | 2019 trở lên | Express hoặc Developer edition đều được |
| SSMS | 18+ | SQL Server Management Studio |
| Visual Studio | 2019/2022 | Community edition |
| .NET Framework | 4.7.2+ | Đã có sẵn khi cài Visual Studio |

---

## 🚀 Hướng dẫn chạy lần đầu

### Bước 1 — Chạy file SQL

1. Mở **SQL Server Management Studio (SSMS)**
2. Kết nối đến SQL Server instance của bạn
3. Mở file `SQL/BT_Trigger_ThuTuc_Ham_DBMS.sql`
4. Nhấn **F5** hoặc nút **Execute** để chạy toàn bộ

> ✅ File chạy 1 lượt từ đầu đến cuối — tự động tạo 2 database, bảng, dữ liệu mẫu, SP, Trigger, Function và kiểm tra từng phần.

Sau khi chạy xong, kiểm tra trong SSMS:
- Database **QuanLyThuVien** — chứa BT1 đến BT5
- Database **DeAn** — chứa BT6

### Bước 2 — Mở project WinForms

1. Mở file `WinForms/DBMS_Project.sln` bằng Visual Studio
2. Mở file `Helpers/DBHelper.cs`, cập nhật connection string:

```csharp
private static string connectionString =
    "Server=TEN_MAY_TINH\\SQLEXPRESS;Database=QuanLyThuVien;Trusted_Connection=True;";
```

> Thay `TEN_MAY_TINH\\SQLEXPRESS` bằng tên SQL Server instance trên máy bạn.  
> Thường là `localhost` hoặc `.\SQLEXPRESS` hoặc `TenMay\SQLEXPRESS`.

3. Nhấn **F5** để chạy

---

## 📋 Nội dung các bài tập

| Bài | Tên | Database | Loại |
|---|---|---|---|
| BT1 | `sp_TinhTong` | QuanLyThuVien | Stored Procedure |
| BT2 | `sp_ThongtinDausach` | QuanLyThuVien | Stored Procedure |
| BT3 | `fn_TinhTuoi` | QuanLyThuVien | Scalar Function |
| BT4a | `sp_ThongtinDocGia` | QuanLyThuVien | Stored Procedure |
| BT4c | `sp_ThongtinNguoilonDangmuon` | QuanLyThuVien | Stored Procedure |
| BT4d | `sp_ThongtinNguoilonQuahan` | QuanLyThuVien | Stored Procedure |
| BT4e | `sp_DocGiaCoTreEmMuon` | QuanLyThuVien | Stored Procedure |
| BT5.1 | `tg_delMuon` | QuanLyThuVien | Trigger AFTER DELETE |
| BT5.2 | `tg_insMuon` | QuanLyThuVien | Trigger AFTER INSERT |
| BT5.3 | `tg_updCuonSach` | QuanLyThuVien | Trigger AFTER UPDATE |
| BT5.4 | `tg_InfThongBao` | QuanLyThuVien | Trigger AFTER INSERT/UPDATE |
| BT6.1 | `fn_LuongTBPhong` | DeAn | Scalar Function |
| BT6.2 | `fn_TongLuongNVTheoDA` | DeAn | Scalar Function |
| BT6.3 | `fn_LuongTBTatCaPhong` | DeAn | Scalar Function |
| BT6.4 | `fn_TienThuongTheoGio` | DeAn | Scalar Function |
| BT6.5 | `fn_TongSoDATheoPhong` | DeAn | Scalar Function |
| BT6.6a | `fn_ThongTinNhanVien_Inline` | DeAn | Inline Table-Valued Function |
| BT6.6b | `fn_ThongTinNhanVien_Multi` | DeAn | Multistatement Table-Valued Function |

---

## 🌿 Quy tắc Git

### Branch của từng người

```
main                          ← branch chính, chỉ merge khi hoàn thành
├── feature/tai-bt1-bt2-winforms
├── feature/toan-bt3-bt4ac
├── feature/khang-bt4de
└── feature/duong-bt5-bt6
```

### Quy trình làm việc

```bash
# 1. Clone repo về máy (lần đầu)
git clone https://github.com/franz08hmt/DBMS.git

# 2. Checkout sang branch của mình
git checkout feature/ten-branch-cua-ban

# 3. Làm việc, sau đó commit
git add .
git commit -m "feat: mô tả ngắn việc vừa làm"

# 4. Push lên repo
git push origin feature/ten-branch-cua-ban

# 5. Khi xong → tạo Pull Request về main trên GitHub
```

### Quy tắc commit message

| Prefix | Dùng khi |
|---|---|
| `feat:` | Thêm tính năng mới (SP, Trigger, Function, Form) |
| `fix:` | Sửa lỗi |
| `docs:` | Cập nhật tài liệu |
| `refactor:` | Chỉnh code không thay đổi chức năng |

Ví dụ: `feat: tao sp_TinhTong va ket noi WinForms BT1`

> 💡 Dùng **GitHub Desktop** nếu chưa quen CLI — giao diện click chuột, không cần nhớ lệnh.

---

## 📅 Lịch làm việc

| Thời gian | Việc cần làm |
|---|---|
| 06/6 | Cả nhóm chạy file SQL, kiểm tra không lỗi. Tài setup WinForms chính. |
| 07–08/6 | Mỗi người viết nút WinForms phần mình. |
| 09–11/6 | Tự viết lại code SQL từ đầu không nhìn file (chuẩn bị vấn đáp mức 3). |
| 12/6 | Test tích hợp, fix lỗi, ôn tập. Cả nhóm hỏi thử nhau. |
| 15/6 | **Deadline** — nộp P1 (.docx) + P2 (WinForms + SQL) trước 23:59. |

---

## ❓ Lưu ý vấn đáp

Thầy vấn đáp theo **3 mức**:

1. **Hiểu** — Giải thích được SP/Trigger/Function là gì, logic phần mình làm
2. **Đọc code** — Xem đoạn code và giải thích tác dụng từng dòng
3. **Tự viết lại** — Xóa code rồi tự gõ lại từ đầu trên SSMS

> Mục tiêu: mỗi người làm được ít nhất 50% số bài tự viết thành công không cần nhìn tài liệu.
