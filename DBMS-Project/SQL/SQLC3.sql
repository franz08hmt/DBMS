-- ============================================================
-- SQL SCRIPT — SQL Server (T-SQL / SSMS)
-- Subject  : Database Management Systems (DBMS)
-- Topic    : Bài tập Stored Procedures, Triggers, Functions
-- Database : QuanLyThuVienMoi (BT1 – BT5)
-- Date     : 2026-06-10
-- ============================================================


-- ============================================================
-- BÀI TẬP 1: STORED PROCEDURE TÍNH TỔNG 2 SỐ NGUYÊN
-- ============================================================

USE master;
GO

IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'QuanLyThuVienMoi')
BEGIN
    CREATE DATABASE QuanLyThuVienMoi;
END
GO

USE QuanLyThuVienMoi;
GO

-- -----------------------------------------------
-- BT1: sp_TinhTongHaiSo — Tính tổng 2 số nguyên
-- -----------------------------------------------
IF OBJECT_ID('sp_TinhTongHaiSo', 'P') IS NOT NULL
    DROP PROCEDURE sp_TinhTongHaiSo;
GO

CREATE PROCEDURE sp_TinhTongHaiSo
    @SoThu1  INT,
    @SoThu2  INT,
    @TongSo  INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    SET @TongSo = @SoThu1 + @SoThu2;
    PRINT N'Kết quả: ' + CAST(@SoThu1 AS NVARCHAR) + N' + '
        + CAST(@SoThu2 AS NVARCHAR) + N' = ' + CAST(@TongSo AS NVARCHAR);
END;
GO

-- Kiểm tra BT1:
DECLARE @Tong INT;
EXEC sp_TinhTongHaiSo @SoThu1 = 42, @SoThu2 = 58, @TongSo = @Tong OUTPUT;
SELECT @Tong AS TongHaiSo;

DECLARE @Tong2 INT;
EXEC sp_TinhTongHaiSo @SoThu1 = 100, @SoThu2 = 235, @TongSo = @Tong2 OUTPUT;
SELECT @Tong2 AS TongHaiSo;
GO


-- ============================================================
-- BÀI TẬP 2 – 5: CSDL QUẢN LÝ THƯ VIỆN MỚI
-- ============================================================

USE QuanLyThuVienMoi;
GO

-- ============================================================
-- SECTION 1: TẠO CÁC BẢNG
-- ============================================================

-- Xóa bảng cũ (nếu có) theo thứ tự phụ thuộc khóa ngoại
IF OBJECT_ID('QuaTrinhMuon', 'U') IS NOT NULL DROP TABLE QuaTrinhMuon;
IF OBJECT_ID('Muon',         'U') IS NOT NULL DROP TABLE Muon;
IF OBJECT_ID('DangKy',       'U') IS NOT NULL DROP TABLE DangKy;
IF OBJECT_ID('Cuonsach',     'U') IS NOT NULL DROP TABLE Cuonsach;
IF OBJECT_ID('Dausach',      'U') IS NOT NULL DROP TABLE Dausach;
IF OBJECT_ID('Tuasach',      'U') IS NOT NULL DROP TABLE Tuasach;
IF OBJECT_ID('Treem',        'U') IS NOT NULL DROP TABLE Treem;
IF OBJECT_ID('Nguoilon',     'U') IS NOT NULL DROP TABLE Nguoilon;
IF OBJECT_ID('DocGia',       'U') IS NOT NULL DROP TABLE DocGia;
GO

-- Bảng DocGia (Độc giả)
CREATE TABLE DocGia (
    ma_DocGia   VARCHAR(10)  NOT NULL,
    ho          NVARCHAR(30) NOT NULL,
    tenlot      NVARCHAR(30) NULL,
    ten         NVARCHAR(20) NOT NULL,
    ngaysinh    DATE         NULL,
    CONSTRAINT PK_DocGia PRIMARY KEY (ma_DocGia)
);
GO

CREATE TABLE Nguoilon (
    ma_DocGia   VARCHAR(10)  NOT NULL,
    sonha       NVARCHAR(10) NULL,
    duong       NVARCHAR(50) NULL,
    quan        NVARCHAR(30) NULL,
    dienthoai   VARCHAR(15)  NULL,
    han_sd      DATE         NULL,
    CONSTRAINT PK_Nguoilon  PRIMARY KEY (ma_DocGia),
    CONSTRAINT FK_NL_DocGia FOREIGN KEY (ma_DocGia) REFERENCES DocGia(ma_DocGia)
);
GO

CREATE TABLE Treem (
    ma_DocGia           VARCHAR(10) NOT NULL,
    ma_DocGia_nguoilon  VARCHAR(10) NOT NULL,
    CONSTRAINT PK_Treem      PRIMARY KEY (ma_DocGia),
    CONSTRAINT FK_TE_DocGia  FOREIGN KEY (ma_DocGia)          REFERENCES DocGia(ma_DocGia),
    CONSTRAINT FK_TE_NL      FOREIGN KEY (ma_DocGia_nguoilon) REFERENCES Nguoilon(ma_DocGia)
);
GO

CREATE TABLE Tuasach (
    ma_tuasach  VARCHAR(10)   NOT NULL,
    tuasach     NVARCHAR(100) NOT NULL,
    tacgia      NVARCHAR(80)  NULL,
    tomtat      NVARCHAR(500) NULL,
    CONSTRAINT PK_Tuasach PRIMARY KEY (ma_tuasach)
);
GO

-- trangthai: 'yes' = còn sách chưa mượn, 'no' = hết sách
CREATE TABLE Dausach (
    isbn        VARCHAR(20)  NOT NULL,
    ma_tuasach  VARCHAR(10)  NOT NULL,
    ngonngu     NVARCHAR(30) NULL,
    bia         NVARCHAR(10) NULL,
    trangthai   CHAR(3)      NOT NULL DEFAULT 'yes',
    CONSTRAINT PK_Dausach       PRIMARY KEY (isbn),
    CONSTRAINT FK_DS_Tuasach    FOREIGN KEY (ma_tuasach) REFERENCES Tuasach(ma_tuasach),
    CONSTRAINT CK_DS_TrangThai  CHECK (trangthai IN ('yes','no'))
);
GO

-- tinhtrang: 'yes' = sẵn sàng (chưa mượn), 'no' = đang được mượn
CREATE TABLE Cuonsach (
    isbn        VARCHAR(20) NOT NULL,
    ma_cuonsach VARCHAR(10) NOT NULL,
    tinhtrang   CHAR(3)     NOT NULL DEFAULT 'yes',
    CONSTRAINT PK_Cuonsach      PRIMARY KEY (isbn, ma_cuonsach),
    CONSTRAINT FK_CS_Dausach    FOREIGN KEY (isbn) REFERENCES Dausach(isbn),
    CONSTRAINT CK_CS_TinhTrang  CHECK (tinhtrang IN ('yes','no'))
);
GO

CREATE TABLE DangKy (
    isbn        VARCHAR(20)   NOT NULL,
    ma_DocGia   VARCHAR(10)   NOT NULL,
    ngay_dk     DATE          NOT NULL,
    ghichu      NVARCHAR(200) NULL,
    CONSTRAINT PK_DangKy     PRIMARY KEY (isbn, ma_DocGia),
    CONSTRAINT FK_DK_Dausach FOREIGN KEY (isbn)      REFERENCES Dausach(isbn),
    CONSTRAINT FK_DK_DocGia  FOREIGN KEY (ma_DocGia) REFERENCES DocGia(ma_DocGia)
);
GO

CREATE TABLE Muon (
    isbn          VARCHAR(20) NOT NULL,
    ma_cuonsach   VARCHAR(10) NOT NULL,
    ma_DocGia     VARCHAR(10) NOT NULL,
    ngay_muon     DATE        NOT NULL,
    ngay_hethan   DATE        NOT NULL,
    CONSTRAINT PK_Muon       PRIMARY KEY (isbn, ma_cuonsach, ma_DocGia),
    CONSTRAINT FK_M_Cuonsach FOREIGN KEY (isbn, ma_cuonsach) REFERENCES Cuonsach(isbn, ma_cuonsach),
    CONSTRAINT FK_M_DocGia   FOREIGN KEY (ma_DocGia)         REFERENCES DocGia(ma_DocGia)
);
GO

CREATE TABLE QuaTrinhMuon (
    isbn          VARCHAR(20)   NOT NULL,
    ma_cuonsach   VARCHAR(10)   NOT NULL,
    ngay_muon     DATE          NOT NULL,
    ma_DocGia     VARCHAR(10)   NOT NULL,
    ngay_hethan   DATE          NOT NULL,
    ngay_tra      DATE          NULL,
    tien_muon     DECIMAL(10,2) NULL,
    tien_datra    DECIMAL(10,2) NULL,
    tien_datcoc   DECIMAL(10,2) NULL,
    ghichu        NVARCHAR(200) NULL,
    CONSTRAINT PK_QTM        PRIMARY KEY (isbn, ma_cuonsach, ngay_muon, ma_DocGia),
    CONSTRAINT FK_QTM_DocGia FOREIGN KEY (ma_DocGia) REFERENCES DocGia(ma_DocGia),
    CONSTRAINT FK_QTM_Cuonsach FOREIGN KEY (isbn, ma_cuonsach)  
        REFERENCES Cuonsach(isbn, ma_cuonsach)
);
GO


-- ============================================================
-- SECTION 2: DỮ LIỆU MẪU (khác hoàn toàn với bản gốc)
-- ============================================================

-- *** Độc giả ***
INSERT INTO DocGia VALUES
    ('DG101', N'Võ',     N'Thanh',   N'Hải',   '1982-06-10'),
    ('DG102', N'Đinh',   N'Thị',     N'Ngọc',  '1994-02-28'),
    ('DG103', N'Bùi',    N'Quốc',    N'Tuấn',  '2014-08-17'),
    ('DG104', N'Ngô',    N'Minh',    N'Khoa',  '2016-12-01'),
    ('DG105', N'Dương',  N'Thị',     N'Thanh', '1975-05-20'),
    ('DG106', N'Trịnh',  N'Văn',     N'Hùng',  '1988-10-03');
GO

-- *** Người lớn ***
INSERT INTO Nguoilon VALUES
    ('DG101', '23',  N'Điện Biên Phủ',  N'Bình Thạnh', '0931111222', '2028-03-31'),
    ('DG102', '7',   N'Cách Mạng Tháng 8', N'Quận 10', '0942222333', '2027-09-15'),
    ('DG105', '55',  N'Nguyễn Đình Chiểu', N'Quận 3',  '0953333444', '2026-12-31'),
    ('DG106', '101', N'Lý Thường Kiệt', N'Quận 11',    '0964444555', '2029-06-30');
GO

-- *** Trẻ em (DG103 do DG101 bảo lãnh, DG104 do DG102 bảo lãnh) ***
INSERT INTO Treem VALUES
    ('DG103', 'DG101'),
    ('DG104', 'DG102');
GO

-- *** Tựa sách ***
INSERT INTO Tuasach VALUES
    ('TS101', N'Nhập môn Python',                  N'Mark Lutz',          N'Học Python từ đầu cho người mới'),
    ('TS102', N'Kiến trúc phần mềm hiện đại',      N'Robert C. Martin',   N'Clean Architecture và SOLID'),
    ('TS103', N'Trí tuệ nhân tạo cơ bản',          N'Stuart Russell',     N'AI và Machine Learning nhập môn'),
    ('TS104', N'Hệ điều hành',                     N'Abraham Silberschatz',N'Nguyên lý hệ điều hành'),
    ('TS105', N'Toán rời rạc cho tin học',         N'Kenneth Rosen',      N'Nền tảng toán học cho lập trình');
GO

-- *** Đầu sách ***
INSERT INTO Dausach VALUES
    ('ISBN-PY01', 'TS101', N'Tiếng Anh',  N'Bìa mềm', 'yes'),
    ('ISBN-SA01', 'TS102', N'Tiếng Việt', N'Bìa cứng','yes'),
    ('ISBN-AI01', 'TS103', N'Tiếng Anh',  N'Bìa cứng','no'),
    ('ISBN-OS01', 'TS104', N'Tiếng Việt', N'Bìa mềm', 'yes'),
    ('ISBN-DM01', 'TS105', N'Tiếng Việt', N'Bìa mềm', 'yes');
GO

-- *** Cuốn sách ***
INSERT INTO Cuonsach VALUES
    ('ISBN-PY01','CS-A01','yes'),
    ('ISBN-PY01','CS-A02','no'),   -- đang được mượn
    ('ISBN-PY01','CS-A03','yes'),
    ('ISBN-SA01','CS-B01','yes'),
    ('ISBN-SA01','CS-B02','yes'),
    ('ISBN-AI01','CS-C01','no'),   -- đang được mượn
    ('ISBN-AI01','CS-C02','no'),   -- đang được mượn
    ('ISBN-OS01','CS-D01','yes'),
    ('ISBN-OS01','CS-D02','no'),   -- đang được mượn
    ('ISBN-DM01','CS-E01','yes'),
    ('ISBN-DM01','CS-E02','yes');
GO

-- *** Đăng ký mượn ***
INSERT INTO DangKy VALUES
    ('ISBN-PY01','DG105','2026-06-01', N'Ưu tiên'),
    ('ISBN-OS01','DG106','2026-06-05', NULL);
GO

-- *** Phiếu mượn hiện tại ***
INSERT INTO Muon VALUES
    -- DG101 mượn Python CS-A02, quá hạn ~50 ngày
    ('ISBN-PY01','CS-A02','DG101','2026-03-15','2026-03-29'),
    -- DG102 mượn AI CS-C01, quá hạn 3 ngày
    ('ISBN-AI01','CS-C01','DG102','2026-05-22','2026-06-05'),
    -- DG103 trẻ em mượn AI CS-C02
    ('ISBN-AI01','CS-C02','DG103','2026-05-28','2026-06-11'),
    -- DG106 mượn OS CS-D02, chưa quá hạn
    ('ISBN-OS01','CS-D02','DG106','2026-06-03','2026-06-17');
GO


-- ============================================================
-- BÀI TẬP 2: STORED PROCEDURE — THÔNG TIN ĐẦU SÁCH
-- sp_ThongtinDausach
-- ============================================================

IF OBJECT_ID('sp_ThongtinDausach', 'P') IS NOT NULL
    DROP PROCEDURE sp_ThongtinDausach;
GO

CREATE PROCEDURE sp_ThongtinDausach
    @isbn VARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;

    -- Kiểm tra đầu sách tồn tại
    IF NOT EXISTS (SELECT 1 FROM Dausach WHERE isbn = @isbn)
    BEGIN
        PRINT N'Không tìm thấy đầu sách với ISBN: ' + @isbn;
        RETURN;
    END

    -- Trả về thông tin đầu sách, tựa sách và số cuốn chưa mượn
    SELECT
        d.isbn                              AS [ISBN],
        t.tuasach                           AS [Tựa sách],
        t.tacgia                            AS [Tác giả],
        t.tomtat                            AS [Tóm tắt],
        d.ngonngu                           AS [Ngôn ngữ],
        d.bia                               AS [Bìa],
        d.trangthai                         AS [Trạng thái đầu sách],
        (
            SELECT COUNT(*)
            FROM Cuonsach cs
            WHERE cs.isbn = d.isbn
              AND cs.tinhtrang = 'yes'
        )                                   AS [Số cuốn chưa mượn]
    FROM Dausach d
    JOIN Tuasach t ON t.ma_tuasach = d.ma_tuasach
    WHERE d.isbn = @isbn;
END;
GO

-- Kiểm tra BT2:
EXEC sp_ThongtinDausach @isbn = 'ISBN-PY01';   -- Có cuốn chưa mượn
EXEC sp_ThongtinDausach @isbn = 'ISBN-AI01';   -- Hết sách (trangthai = no)
EXEC sp_ThongtinDausach @isbn = 'ISBN-XXXX';   -- Không tồn tại
GO


-- ============================================================
-- BÀI TẬP 3: HÀM TÍNH TUỔI THEO NĂM SINH
-- fn_TinhTuoi
-- ============================================================

IF OBJECT_ID('fn_TinhTuoi', 'FN') IS NOT NULL
    DROP FUNCTION fn_TinhTuoi;
GO

CREATE FUNCTION fn_TinhTuoi
(
    @NamSinh INT
)
RETURNS INT
AS
BEGIN
    DECLARE @Tuoi INT;
    -- Tính đơn giản: năm hiện tại trừ năm sinh
    SET @Tuoi = YEAR(GETDATE()) - @NamSinh;
    RETURN @Tuoi;
END;
GO

-- Kiểm tra BT3:
SELECT dbo.fn_TinhTuoi(1995) AS [Tuổi (sinh 1995)];
SELECT dbo.fn_TinhTuoi(2005) AS [Tuổi (sinh 2005)];
SELECT dbo.fn_TinhTuoi(1975) AS [Tuổi (sinh 1975)];

-- Áp dụng vào bảng DocGia:
SELECT
    ma_DocGia,
    ho + N' ' + ISNULL(tenlot + N' ', '') + ten      AS [Họ và tên],
    ngaysinh,
    dbo.fn_TinhTuoi(YEAR(ngaysinh))                   AS [Tuổi]
FROM DocGia;
GO


-- ============================================================
-- BÀI TẬP 5: TRIGGERS — CSDL THƯ VIỆN
-- ============================================================

-- -----------------------------------------------
-- 5.1. tg_delMuon
-- Khi XÓA phiếu mượn → cập nhật tinhtrang cuốn sách = 'yes'
-- -----------------------------------------------
IF OBJECT_ID('tg_delMuon', 'TR') IS NOT NULL
    DROP TRIGGER tg_delMuon;
GO

CREATE TRIGGER tg_delMuon
ON Muon
AFTER DELETE
AS
BEGIN
    SET NOCOUNT ON;

    -- Mỗi cuốn sách bị xóa khỏi Muon → đặt lại tình trạng = sẵn sàng
    UPDATE Cuonsach
    SET tinhtrang = 'yes'
    FROM Cuonsach cs
    JOIN DELETED d ON d.isbn = cs.isbn
                  AND d.ma_cuonsach = cs.ma_cuonsach;

    PRINT N'[tg_delMuon] Đã cập nhật tình trạng cuốn sách thành "yes" (sẵn sàng).';
END;
GO

-- Kiểm tra 5.1 (rollback để không thay đổi dữ liệu thật):
BEGIN TRAN;
    DELETE FROM Muon
    WHERE isbn = 'ISBN-PY01'
      AND ma_cuonsach = 'CS-A02'
      AND ma_DocGia   = 'DG101';

    -- Kỳ vọng: CS-A02 chuyển về 'yes'
    SELECT isbn, ma_cuonsach, tinhtrang
    FROM Cuonsach
    WHERE isbn = 'ISBN-PY01';
ROLLBACK;
GO


-- -----------------------------------------------
-- 5.2. tg_insMuon
-- Khi THÊM phiếu mượn → cập nhật tinhtrang cuốn sách = 'no'
-- -----------------------------------------------
IF OBJECT_ID('tg_insMuon', 'TR') IS NOT NULL
    DROP TRIGGER tg_insMuon;
GO

CREATE TRIGGER tg_insMuon
ON Muon
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Cuonsach
    SET tinhtrang = 'no'
    FROM Cuonsach cs
    JOIN INSERTED i ON i.isbn = cs.isbn
                   AND i.ma_cuonsach = cs.ma_cuonsach;

    PRINT N'[tg_insMuon] Đã cập nhật tình trạng cuốn sách thành "no" (đang mượn).';
END;
GO

-- Kiểm tra 5.2:
BEGIN TRAN;
    -- DG105 mượn cuốn DM CS-E01 (đang sẵn sàng)
    INSERT INTO Muon VALUES ('ISBN-DM01','CS-E01','DG105','2026-06-10','2026-06-24');

    -- Kỳ vọng: CS-E01 chuyển sang 'no'
    SELECT isbn, ma_cuonsach, tinhtrang
    FROM Cuonsach
    WHERE isbn = 'ISBN-DM01';
ROLLBACK;
GO


-- -----------------------------------------------
-- 5.3. tg_updCuonSach
-- Khi cập nhật tinhtrang Cuonsach → cập nhật trangthai Dausach
-- Logic: nếu còn ít nhất 1 cuốn 'yes' → trangthai = 'yes'; ngược lại = 'no'
-- -----------------------------------------------
IF OBJECT_ID('tg_updCuonSach', 'TR') IS NOT NULL
    DROP TRIGGER tg_updCuonSach;
GO

CREATE TRIGGER tg_updCuonSach
ON Cuonsach
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    IF NOT UPDATE(tinhtrang) RETURN;

    DECLARE @isbn VARCHAR(20);

    DECLARE cur_isbn CURSOR FOR
        SELECT DISTINCT isbn FROM INSERTED;

    OPEN cur_isbn;
    FETCH NEXT FROM cur_isbn INTO @isbn;

    WHILE @@FETCH_STATUS = 0
    BEGIN
        DECLARE @SoCuonSan INT;
        SELECT @SoCuonSan = COUNT(*)
        FROM Cuonsach
        WHERE isbn = @isbn AND tinhtrang = 'yes';

        IF @SoCuonSan > 0
            UPDATE Dausach SET trangthai = 'yes' WHERE isbn = @isbn;
        ELSE
            UPDATE Dausach SET trangthai = 'no'  WHERE isbn = @isbn;

        PRINT N'[tg_updCuonSach] Đã cập nhật trangthai Dausach cho ISBN: ' + @isbn;

        FETCH NEXT FROM cur_isbn INTO @isbn;
    END;

    CLOSE cur_isbn;
    DEALLOCATE cur_isbn;
END;
GO

-- Kiểm tra 5.3:
BEGIN TRAN;
    -- Đặt toàn bộ cuốn ISBN-DM01 thành 'no'
    UPDATE Cuonsach SET tinhtrang = 'no' WHERE isbn = 'ISBN-DM01';

    -- Kỳ vọng: trangthai Dausach ISBN-DM01 chuyển sang 'no'
    SELECT isbn, trangthai FROM Dausach WHERE isbn = 'ISBN-DM01';
ROLLBACK;
GO

BEGIN TRAN;
    -- Trả lại 1 cuốn ISBN-AI01 → 'yes'
    UPDATE Cuonsach SET tinhtrang = 'yes'
    WHERE isbn = 'ISBN-AI01' AND ma_cuonsach = 'CS-C01';

    -- Kỳ vọng: trangthai Dausach ISBN-AI01 chuyển sang 'yes'
    SELECT isbn, trangthai FROM Dausach WHERE isbn = 'ISBN-AI01';
ROLLBACK;
GO


-- -----------------------------------------------
-- 5.4. tg_InfThongBao
-- Khi INSERT hoặc UPDATE tên tác giả / tựa sách trên bảng Tuasach
-- → In câu thông báo tiếng Việt
-- -----------------------------------------------
IF OBJECT_ID('tg_InfThongBao', 'TR') IS NOT NULL
    DROP TRIGGER tg_InfThongBao;
GO

CREATE TRIGGER tg_InfThongBao
ON Tuasach
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (SELECT 1 FROM INSERTED)
    BEGIN
        IF EXISTS (SELECT 1 FROM DELETED)
        BEGIN
            -- Trường hợp UPDATE: kiểm tra tựa sách hoặc tác giả có thay đổi
            IF UPDATE(tuasach) OR UPDATE(tacgia)
                PRINT N'Đã thêm mới tựa sách';
        END
        ELSE
        BEGIN
            -- Trường hợp INSERT mới
            PRINT N'Đã thêm mới tựa sách';
        END
    END
END;
GO

-- Kiểm tra 5.4:
BEGIN TRAN;
    -- INSERT tựa sách mới
    INSERT INTO Tuasach VALUES
        ('TS106', N'Bảo mật hệ thống thông tin', N'William Stallings', N'An ninh mạng và mã hóa');

    -- UPDATE tên tác giả
    UPDATE Tuasach
    SET tacgia = N'Lê Anh Tuấn'
    WHERE ma_tuasach = 'TS101';

    -- UPDATE tựa sách
    UPDATE Tuasach
    SET tuasach = N'Nhập môn Python (Tái bản lần 3)'
    WHERE ma_tuasach = 'TS101';
ROLLBACK;
GO


-- ============================================================
-- END OF SCRIPT
-- ============================================================