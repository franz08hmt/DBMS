-- ============================================================
-- SQL SCRIPT — SQL Server (T-SQL / SSMS)
-- Subject  : Database Management Systems (DBMS)
-- Topic    : Bài tập Stored Procedures, Triggers, Functions
-- Database : QuanLyThuVien (BT1–BT5) | DeAn (BT6)
-- Date     : 2026-06-05
-- ============================================================


-- ============================================================
-- BÀI TẬP 1: STORED PROCEDURE TÍNH TỔNG 2 SỐ NGUYÊN
-- ============================================================

USE master;
GO

-- Dùng database QuanLyThuVien làm nơi chứa BT1
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'QuanLyThuVien')
BEGIN
    CREATE DATABASE QuanLyThuVien;
END
GO

USE QuanLyThuVien;
GO

-- -----------------------------------------------
-- BT1: sp_TinhTong — Tính tổng 2 số nguyên
-- -----------------------------------------------
IF OBJECT_ID('sp_TinhTong', 'P') IS NOT NULL
    DROP PROCEDURE sp_TinhTong;
GO

CREATE PROCEDURE sp_TinhTong
    @SoA INT,
    @SoB INT,
    @KetQua INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    SET @KetQua = @SoA + @SoB;
    PRINT N'Tổng của ' + CAST(@SoA AS NVARCHAR) + N' và ' + CAST(@SoB AS NVARCHAR)
        + N' = ' + CAST(@KetQua AS NVARCHAR);
END;
GO

-- Kiểm tra BT1:
DECLARE @Result INT;
EXEC sp_TinhTong @SoA = 15, @SoB = 27, @KetQua = @Result OUTPUT;
SELECT @Result AS TongHaiSo;
GO


-- ============================================================
-- BÀI TẬP 2 – 5: CSDL QUẢN LÝ THƯ VIỆN
-- ============================================================

USE QuanLyThuVien;
GO

-- ============================================================
-- SECTION 1: TẠO CÁC BẢNG
-- ============================================================

-- Bảng DocGia (Độc giả)
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
    isbn        VARCHAR(20)  NOT NULL,
    ma_DocGia   VARCHAR(10)  NOT NULL,
    ngay_dk     DATE         NOT NULL,
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
    CONSTRAINT PK_QTM       PRIMARY KEY (isbn, ma_cuonsach, ngay_muon, ma_DocGia),
    CONSTRAINT FK_QTM_DocGia FOREIGN KEY (ma_DocGia) REFERENCES DocGia(ma_DocGia)
);
GO

-- ============================================================
-- SECTION 2: DỮ LIỆU MẪU
-- ============================================================

-- Độc giả
INSERT INTO DocGia VALUES
    ('DG001', N'Nguyễn',  N'Văn',   N'An',    '1985-03-15'),
    ('DG002', N'Trần',    N'Thị',   N'Bình',  '1990-07-22'),
    ('DG003', N'Lê',      N'Hoàng', N'Cường', '2012-11-05'),
    ('DG004', N'Phạm',    N'Minh',  N'Dũng',  '2015-04-18'),
    ('DG005', N'Hoàng',   N'Thị',   N'Lan',   '1978-09-30');
GO

-- Người lớn
INSERT INTO Nguoilon VALUES
    ('DG001', '12',  N'Lê Lợi',       N'Quận 1',  '0901234567', '2027-12-31'),
    ('DG002', '45',  N'Nguyễn Huệ',   N'Quận 3',  '0912345678', '2026-06-30'),
    ('DG005', '88',  N'Trần Hưng Đạo',N'Quận 5',  '0923456789', '2028-01-15');
GO

-- Trẻ em (DG003 do DG001 bảo lãnh, DG004 do DG002 bảo lãnh)
INSERT INTO Treem VALUES
    ('DG003', 'DG001'),
    ('DG004', 'DG002');
GO

-- Tựa sách
INSERT INTO Tuasach VALUES
    ('TS001', N'Lập trình C# cơ bản',         N'Nguyễn Thành Nhân', N'Giới thiệu C# từ cơ bản'),
    ('TS002', N'Cơ sở dữ liệu quan hệ',       N'Ramez Elmasri',     N'Lý thuyết và thực hành CSDL'),
    ('TS003', N'Giải thuật và lập trình',      N'Lê Minh Hoàng',     N'Thuật toán căn bản'),
    ('TS004', N'Mạng máy tính',                N'Andrew Tanenbaum',  N'Nguyên lý mạng máy tính');
GO

-- Đầu sách
INSERT INTO Dausach VALUES
    ('ISBN001', 'TS001', N'Tiếng Việt', N'Bìa mềm', 'yes'),
    ('ISBN002', 'TS002', N'Tiếng Anh',  N'Bìa cứng','yes'),
    ('ISBN003', 'TS003', N'Tiếng Việt', N'Bìa mềm', 'no'),
    ('ISBN004', 'TS004', N'Tiếng Anh',  N'Bìa cứng','yes');
GO

-- Cuốn sách
INSERT INTO Cuonsach VALUES
    ('ISBN001','CS001','yes'),
    ('ISBN001','CS002','no'),   -- đang được mượn
    ('ISBN002','CS001','yes'),
    ('ISBN003','CS001','no'),   -- đang được mượn
    ('ISBN003','CS002','no'),   -- đang được mượn
    ('ISBN004','CS001','yes'),
    ('ISBN004','CS002','yes');
GO

-- Đăng ký mượn
INSERT INTO DangKy VALUES
    ('ISBN001','DG001','2026-05-01',NULL),
    ('ISBN002','DG002','2026-05-10',NULL);
GO

-- Phiếu mượn hiện tại
INSERT INTO Muon VALUES
    ('ISBN001','CS002','DG001','2026-04-01','2026-04-15'),  -- quá hạn 50+ ngày
    ('ISBN003','CS001','DG002','2026-05-20','2026-06-03'),  -- quá hạn 2 ngày
    ('ISBN003','CS002','DG003','2026-05-25','2026-06-08'),  -- trẻ em đang mượn
    ('ISBN002','CS001','DG005','2026-06-01','2026-06-15');  -- đang mượn, chưa quá hạn
GO


-- ============================================================
-- BÀI TẬP 2: STORED PROCEDURE — LIỆT KÊ THÔNG TIN ĐẦU SÁCH
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

    -- Thông tin đầu sách và tựa sách
    SELECT
        d.isbn,
        t.tuasach           AS [Tựa sách],
        t.tacgia            AS [Tác giả],
        d.ngonngu           AS [Ngôn ngữ],
        d.bia               AS [Bìa],
        d.trangthai         AS [Trạng thái đầu sách],
        -- Số cuốn chưa được mượn (tinhtrang = 'yes')
        (
            SELECT COUNT(*)
            FROM Cuonsach cs
            WHERE cs.isbn = d.isbn
              AND cs.tinhtrang = 'yes'
        )                   AS [Số cuốn chưa mượn]
    FROM Dausach d
    JOIN Tuasach t ON t.ma_tuasach = d.ma_tuasach
    WHERE d.isbn = @isbn;
END;
GO

-- Kiểm tra BT2:
EXEC sp_ThongtinDausach @isbn = 'ISBN001';
EXEC sp_ThongtinDausach @isbn = 'ISBN003';
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
    SET @Tuoi = YEAR(GETDATE()) - @NamSinh;
    RETURN @Tuoi;
END;
GO

-- Kiểm tra BT3:
SELECT dbo.fn_TinhTuoi(2000) AS [Tuoi_2000];
SELECT dbo.fn_TinhTuoi(1990) AS [Tuoi_1990];

-- Áp dụng vào bảng DocGia:
SELECT
    ma_DocGia,
    ho + N' ' + ISNULL(tenlot + N' ', '') + ten  AS [Họ và tên],
    ngaysinh,
    dbo.fn_TinhTuoi(YEAR(ngaysinh))               AS [Tuổi]
FROM DocGia;
GO


-- ============================================================
-- BÀI TẬP 4: CÁC STORED PROCEDURES CSDL THƯ VIỆN
-- ============================================================

-- -----------------------------------------------
-- 4a. sp_ThongtinDocGia
-- Xem thông tin độc giả (người lớn hoặc trẻ em)
-- -----------------------------------------------
IF OBJECT_ID('sp_ThongtinDocGia', 'P') IS NOT NULL
    DROP PROCEDURE sp_ThongtinDocGia;
GO

CREATE PROCEDURE sp_ThongtinDocGia
    @ma_DocGia VARCHAR(10)
AS
BEGIN
    SET NOCOUNT ON;

    -- Kiểm tra độc giả tồn tại
    IF NOT EXISTS (SELECT 1 FROM DocGia WHERE ma_DocGia = @ma_DocGia)
    BEGIN
        PRINT N'Không tìm thấy độc giả: ' + @ma_DocGia;
        RETURN;
    END

    -- [1] Kiểm tra loại độc giả
    IF EXISTS (SELECT 1 FROM Nguoilon WHERE ma_DocGia = @ma_DocGia)
    BEGIN
        -- [2] Người lớn: thông tin DocGia + Nguoilon
        PRINT N'>>> Độc giả NGƯỜI LỚN';
        SELECT
            dg.ma_DocGia,
            dg.ho + N' ' + ISNULL(dg.tenlot + N' ','') + dg.ten AS [Họ và tên],
            dg.ngaysinh             AS [Ngày sinh],
            dbo.fn_TinhTuoi(YEAR(dg.ngaysinh)) AS [Tuổi],
            nl.sonha + N' ' + nl.duong + N', ' + nl.quan AS [Địa chỉ],
            nl.dienthoai            AS [Điện thoại],
            nl.han_sd               AS [Hạn sử dụng thẻ]
        FROM DocGia dg
        JOIN Nguoilon nl ON nl.ma_DocGia = dg.ma_DocGia
        WHERE dg.ma_DocGia = @ma_DocGia;
    END
    ELSE IF EXISTS (SELECT 1 FROM Treem WHERE ma_DocGia = @ma_DocGia)
    BEGIN
        -- [3] Trẻ em: thông tin DocGia + Treem + thông tin người bảo lãnh
        PRINT N'>>> Độc giả TRẺ EM';
        SELECT
            dg.ma_DocGia,
            dg.ho + N' ' + ISNULL(dg.tenlot + N' ','') + dg.ten AS [Họ và tên],
            dg.ngaysinh             AS [Ngày sinh],
            dbo.fn_TinhTuoi(YEAR(dg.ngaysinh)) AS [Tuổi],
            -- Thông tin người bảo lãnh
            te.ma_DocGia_nguoilon   AS [Mã người bảo lãnh],
            dg2.ho + N' ' + ISNULL(dg2.tenlot + N' ','') + dg2.ten AS [Người bảo lãnh]
        FROM DocGia dg
        JOIN Treem  te  ON te.ma_DocGia  = dg.ma_DocGia
        JOIN DocGia dg2 ON dg2.ma_DocGia = te.ma_DocGia_nguoilon
        WHERE dg.ma_DocGia = @ma_DocGia;
    END
    ELSE
    BEGIN
        PRINT N'Độc giả chưa phân loại (không trong Nguoilon lẫn Treem).';
        SELECT * FROM DocGia WHERE ma_DocGia = @ma_DocGia;
    END
END;
GO

-- Kiểm tra 4a:
EXEC sp_ThongtinDocGia @ma_DocGia = 'DG001';  -- Người lớn
EXEC sp_ThongtinDocGia @ma_DocGia = 'DG003';  -- Trẻ em
GO

-- -----------------------------------------------
-- 4b. sp_ThongtinDausach (đã tạo ở BT2)
-- -----------------------------------------------
-- Xem lại ở phần BT2 bên trên.
EXEC sp_ThongtinDausach @isbn = 'ISBN002';
GO

-- -----------------------------------------------
-- 4c. sp_ThongtinNguoilonDangmuon
-- Liệt kê người lớn đang mượn sách
-- -----------------------------------------------
IF OBJECT_ID('sp_ThongtinNguoilonDangmuon', 'P') IS NOT NULL
    DROP PROCEDURE sp_ThongtinNguoilonDangmuon;
GO

CREATE PROCEDURE sp_ThongtinNguoilonDangmuon
AS
BEGIN
    SET NOCOUNT ON;

    SELECT DISTINCT
        dg.ma_DocGia,
        dg.ho + N' ' + ISNULL(dg.tenlot + N' ','') + dg.ten AS [Họ và tên],
        nl.dienthoai        AS [Điện thoại],
        nl.han_sd           AS [Hạn thẻ],
        m.isbn              AS [ISBN đang mượn],
        m.ma_cuonsach       AS [Mã cuốn sách],
        m.ngay_muon         AS [Ngày mượn],
        m.ngay_hethan       AS [Hạn trả]
    FROM Muon m
    JOIN DocGia  dg ON dg.ma_DocGia = m.ma_DocGia
    JOIN Nguoilon nl ON nl.ma_DocGia = dg.ma_DocGia
    ORDER BY dg.ma_DocGia;
END;
GO

-- Kiểm tra 4c:
EXEC sp_ThongtinNguoilonDangmuon;
GO

-- -----------------------------------------------
-- 4d. sp_ThongtinNguoilonQuahan
-- Liệt kê người lớn mượn quá hạn 14 ngày
-- -----------------------------------------------
IF OBJECT_ID('sp_ThongtinNguoilonQuahan', 'P') IS NOT NULL
    DROP PROCEDURE sp_ThongtinNguoilonQuahan;
GO

CREATE PROCEDURE sp_ThongtinNguoilonQuahan
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        dg.ma_DocGia,
        dg.ho + N' ' + ISNULL(dg.tenlot + N' ','') + dg.ten AS [Họ và tên],
        nl.dienthoai            AS [Điện thoại],
        m.isbn                  AS [ISBN],
        m.ma_cuonsach           AS [Mã cuốn],
        m.ngay_muon             AS [Ngày mượn],
        m.ngay_hethan           AS [Hạn trả],
        DATEDIFF(DAY, m.ngay_hethan, GETDATE()) AS [Số ngày quá hạn]
    FROM Muon m
    JOIN DocGia   dg ON dg.ma_DocGia = m.ma_DocGia
    JOIN Nguoilon nl ON nl.ma_DocGia = dg.ma_DocGia
    WHERE DATEDIFF(DAY, m.ngay_hethan, GETDATE()) > 14
    ORDER BY [Số ngày quá hạn] DESC;
END;
GO

-- Kiểm tra 4d:
EXEC sp_ThongtinNguoilonQuahan;
GO

-- -----------------------------------------------
-- 4e. sp_DocGiaCoTreEmMuon
-- Người lớn đang mượn sách có trẻ em cũng đang mượn
-- -----------------------------------------------
IF OBJECT_ID('sp_DocGiaCoTreEmMuon', 'P') IS NOT NULL
    DROP PROCEDURE sp_DocGiaCoTreEmMuon;
GO

CREATE PROCEDURE sp_DocGiaCoTreEmMuon
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        dg_nl.ma_DocGia             AS [Mã người lớn],
        dg_nl.ho + N' ' + ISNULL(dg_nl.tenlot + N' ','') + dg_nl.ten
                                    AS [Người lớn],
        m_nl.isbn                   AS [ISBN người lớn mượn],
        m_nl.ngay_hethan            AS [Hạn trả (người lớn)],
        -- Trẻ em do người lớn bảo lãnh
        dg_te.ma_DocGia             AS [Mã trẻ em],
        dg_te.ho + N' ' + ISNULL(dg_te.tenlot + N' ','') + dg_te.ten
                                    AS [Tên trẻ em],
        m_te.isbn                   AS [ISBN trẻ em mượn],
        m_te.ngay_hethan            AS [Hạn trả (trẻ em)]
    FROM Muon m_nl
    -- Người lớn đang mượn
    JOIN DocGia   dg_nl ON dg_nl.ma_DocGia = m_nl.ma_DocGia
    JOIN Nguoilon nl    ON nl.ma_DocGia    = dg_nl.ma_DocGia
    -- Trẻ em của người lớn này
    JOIN Treem    te    ON te.ma_DocGia_nguoilon = dg_nl.ma_DocGia
    JOIN DocGia   dg_te ON dg_te.ma_DocGia = te.ma_DocGia
    -- Trẻ em cũng đang mượn sách
    JOIN Muon     m_te  ON m_te.ma_DocGia  = dg_te.ma_DocGia
    ORDER BY dg_nl.ma_DocGia;
END;
GO

-- Kiểm tra 4e:
EXEC sp_DocGiaCoTreEmMuon;
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
    -- Mỗi cuốn sách bị xóa khỏi Muon → đánh dấu lại là sẵn sàng
    UPDATE Cuonsach
    SET tinhtrang = 'yes'
    FROM Cuonsach cs
    JOIN DELETED d ON d.isbn = cs.isbn AND d.ma_cuonsach = cs.ma_cuonsach;
    
    PRINT N'[tg_delMuon] Đã cập nhật tình trạng cuốn sách thành "yes" (sẵn sàng).';
END;
GO

-- Kiểm tra 5.1 (dùng BEGIN TRAN để không thay đổi dữ liệu):
BEGIN TRAN;
    DELETE FROM Muon WHERE isbn = 'ISBN001' AND ma_cuonsach = 'CS002' AND ma_DocGia = 'DG001';
    SELECT isbn, ma_cuonsach, tinhtrang FROM Cuonsach WHERE isbn = 'ISBN001';
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
    JOIN INSERTED i ON i.isbn = cs.isbn AND i.ma_cuonsach = cs.ma_cuonsach;

    PRINT N'[tg_insMuon] Đã cập nhật tình trạng cuốn sách thành "no" (đang mượn).';
END;
GO

-- Kiểm tra 5.2:
BEGIN TRAN;
    INSERT INTO Muon VALUES ('ISBN004','CS001','DG005','2026-06-05','2026-06-19');
    SELECT isbn, ma_cuonsach, tinhtrang FROM Cuonsach WHERE isbn = 'ISBN004';
ROLLBACK;
GO

-- -----------------------------------------------
-- 5.3. tg_updCuonSach
-- Khi cập nhật tinhtrang Cuonsach → cập nhật trangthai Dausach
-- Logic: nếu tất cả cuốn đều 'no' → trangthai = 'no'; còn ít nhất 1 cuốn 'yes' → 'yes'
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

    -- Chỉ xử lý khi cột tinhtrang thay đổi
    IF NOT UPDATE(tinhtrang) RETURN;

    -- Lấy danh sách isbn bị ảnh hưởng
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

        -- Nếu còn ít nhất 1 cuốn sẵn sàng → trangthai đầu sách = 'yes'
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
    -- Đặt tất cả cuốn ISBN004 thành 'no'
    UPDATE Cuonsach SET tinhtrang = 'no' WHERE isbn = 'ISBN004';
    SELECT isbn, trangthai FROM Dausach WHERE isbn = 'ISBN004';
ROLLBACK;
GO

-- -----------------------------------------------
-- 5.4. tg_InfThongBao
-- Khi INSERT hoặc UPDATE tên tác giả / tựa sách trên bảng Tuasach
-- → In thông báo tiếng Việt
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
        -- Phân biệt INSERT hay UPDATE
        IF EXISTS (SELECT 1 FROM DELETED)
        BEGIN
            -- UPDATE: kiểm tra tên tác giả hoặc tựa sách có thay đổi không
            IF UPDATE(tuasach) OR UPDATE(tacgia)
                PRINT N'Đã thêm mới tựa sách';
        END
        ELSE
        BEGIN
            -- INSERT mới
            PRINT N'Đã thêm mới tựa sách';
        END
    END
END;
GO

-- Kiểm tra 5.4:
BEGIN TRAN;
    INSERT INTO Tuasach VALUES ('TS005', N'Trí tuệ nhân tạo', N'Stuart Russell', N'AI cơ bản');
    UPDATE Tuasach SET tacgia = N'Nguyễn Văn A' WHERE ma_tuasach = 'TS001';
ROLLBACK;
GO


-- ============================================================
-- BÀI TẬP 6: FUNCTIONS — CSDL ĐỀ ÁN
-- ============================================================

USE master;
GO

IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'DeAn')
BEGIN
    CREATE DATABASE DeAn;
END
GO

USE DeAn;
GO

-- ============================================================
-- SECTION 1: TẠO CÁC BẢNG CSDL ĐỀ ÁN
-- ============================================================

IF OBJECT_ID('PHANCONG',  'U') IS NOT NULL DROP TABLE PHANCONG;
IF OBJECT_ID('NGUOITHAN', 'U') IS NOT NULL DROP TABLE NGUOITHAN;
IF OBJECT_ID('NHANVIEN',  'U') IS NOT NULL DROP TABLE NHANVIEN;
IF OBJECT_ID('DEAN',      'U') IS NOT NULL DROP TABLE DEAN;
IF OBJECT_ID('PHONGBAN',  'U') IS NOT NULL DROP TABLE PHONGBAN;
GO

CREATE TABLE PHONGBAN (
    MaPB    VARCHAR(10)   NOT NULL,
    TenPB   NVARCHAR(50)  NOT NULL,
    CONSTRAINT PK_PHONGBAN PRIMARY KEY (MaPB)
);
GO

CREATE TABLE NHANVIEN (
    MaNV        VARCHAR(10)   NOT NULL,
    HoTen       NVARCHAR(60)  NOT NULL,
    NgaySinh    DATE          NULL,
    Luong       DECIMAL(12,2) NOT NULL DEFAULT 0,
    MaPB        VARCHAR(10)   NOT NULL,
    CONSTRAINT PK_NHANVIEN   PRIMARY KEY (MaNV),
    CONSTRAINT FK_NV_PHONGBAN FOREIGN KEY (MaPB) REFERENCES PHONGBAN(MaPB)
);
GO

CREATE TABLE DEAN (
    MaDA    VARCHAR(10)   NOT NULL,
    TenDA   NVARCHAR(60)  NOT NULL,
    MaPB    VARCHAR(10)   NOT NULL,
    CONSTRAINT PK_DEAN        PRIMARY KEY (MaDA),
    CONSTRAINT FK_DA_PHONGBAN FOREIGN KEY (MaPB) REFERENCES PHONGBAN(MaPB)
);
GO

-- SoGio: số giờ nhân viên tham gia dự án
CREATE TABLE PHANCONG (
    MaNV    VARCHAR(10)   NOT NULL,
    MaDA    VARCHAR(10)   NOT NULL,
    SoGio   DECIMAL(8,2)  NOT NULL DEFAULT 0,
    CONSTRAINT PK_PHANCONG    PRIMARY KEY (MaNV, MaDA),
    CONSTRAINT FK_PC_NHANVIEN FOREIGN KEY (MaNV) REFERENCES NHANVIEN(MaNV),
    CONSTRAINT FK_PC_DEAN     FOREIGN KEY (MaDA) REFERENCES DEAN(MaDA)
);
GO

CREATE TABLE NGUOITHAN (
    MaNV        VARCHAR(10)   NOT NULL,
    TenNT       NVARCHAR(60)  NOT NULL,
    QuanHe      NVARCHAR(20)  NULL,
    CONSTRAINT PK_NGUOITHAN   PRIMARY KEY (MaNV, TenNT),
    CONSTRAINT FK_NT_NHANVIEN FOREIGN KEY (MaNV) REFERENCES NHANVIEN(MaNV)
);
GO

-- ============================================================
-- SECTION 2: DỮ LIỆU MẪU ĐỀ ÁN
-- ============================================================

INSERT INTO PHONGBAN VALUES
    ('PB01', N'Phòng Kỹ thuật'),
    ('PB02', N'Phòng Kinh doanh'),
    ('PB03', N'Phòng Nhân sự');
GO

INSERT INTO NHANVIEN VALUES
    ('NV001', N'Nguyễn Văn An',    '1985-01-10', 15000000, 'PB01'),
    ('NV002', N'Trần Thị Bình',    '1990-05-20', 12000000, 'PB01'),
    ('NV003', N'Lê Văn Cường',     '1988-03-15', 18000000, 'PB02'),
    ('NV004', N'Phạm Minh Dũng',   '1992-07-08', 13500000, 'PB02'),
    ('NV005', N'Hoàng Thị Lan',    '1986-11-25', 16000000, 'PB03'),
    ('NV006', N'Đỗ Quốc Hùng',     '1995-09-12',  9500000, 'PB03'),
    ('NV007', N'Vũ Thị Mai',       '1991-04-30', 14000000, 'PB01'),
    ('NV008', N'Bùi Văn Nam',      '1987-12-03', 20000000, 'PB02');
GO

INSERT INTO DEAN VALUES
    ('DA01', N'Hệ thống quản lý bán hàng',  'PB01'),
    ('DA02', N'Ứng dụng di động thư viện',  'PB01'),
    ('DA03', N'Cổng thông tin nội bộ',       'PB02'),
    ('DA04', N'Hệ thống nhân sự điện tử',   'PB03');
GO

INSERT INTO PHANCONG VALUES
    ('NV001','DA01', 40), ('NV001','DA02', 25),
    ('NV002','DA01', 60), ('NV002','DA03', 20),
    ('NV003','DA03', 80), ('NV003','DA04', 50),
    ('NV004','DA02', 35), ('NV004','DA03', 90),
    ('NV005','DA04',120), ('NV005','DA01', 45),
    ('NV006','DA04', 30), ('NV006','DA02', 15),
    ('NV007','DA01',160), ('NV007','DA02', 55),
    ('NV008','DA03',200);
GO

INSERT INTO NGUOITHAN VALUES
    ('NV001', N'Nguyễn Thị Hoa',   N'Vợ'),
    ('NV001', N'Nguyễn Văn Bảo',   N'Con'),
    ('NV002', N'Trần Văn Long',     N'Chồng'),
    ('NV003', N'Lê Thị Thu',        N'Vợ'),
    ('NV005', N'Hoàng Minh Phúc',   N'Chồng'),
    ('NV007', N'Vũ Văn Đức',        N'Cha'),
    ('NV007', N'Vũ Thị Hồng',       N'Mẹ');
GO

-- ============================================================
-- BÀI TẬP 6: CÁC FUNCTIONS
-- ============================================================

-- -----------------------------------------------
-- 6.1. fn_LuongTBPhong
-- Tổng lương trung bình của một phòng ban (theo MaPB)
-- -----------------------------------------------
IF OBJECT_ID('fn_LuongTBPhong', 'FN') IS NOT NULL
    DROP FUNCTION fn_LuongTBPhong;
GO

CREATE FUNCTION fn_LuongTBPhong
(
    @MaPB VARCHAR(10)
)
RETURNS DECIMAL(12,2)
AS
BEGIN
    DECLARE @LuongTB DECIMAL(12,2);
    SELECT @LuongTB = AVG(Luong)
    FROM NHANVIEN
    WHERE MaPB = @MaPB;
    -- Trả về 0 thay vì NULL nếu không có nhân viên
    IF @LuongTB IS NULL SET @LuongTB = 0;
    RETURN @LuongTB;
END;
GO

-- Kiểm tra 6.1:
SELECT dbo.fn_LuongTBPhong('PB01') AS [Luong TB PB01];
SELECT dbo.fn_LuongTBPhong('PB02') AS [Luong TB PB02];
GO

-- -----------------------------------------------
-- 6.2. fn_TongLuongNVTheoDA
-- Tổng lương nhận được của nhân viên theo dự án
-- (Lương / tổng giờ * giờ dự án này)
-- -----------------------------------------------
IF OBJECT_ID('fn_TongLuongNVTheoDA', 'FN') IS NOT NULL
    DROP FUNCTION fn_TongLuongNVTheoDA;
GO

CREATE FUNCTION fn_TongLuongNVTheoDA
(
    @MaNV VARCHAR(10),
    @MaDA VARCHAR(10)
)
RETURNS DECIMAL(14,2)
AS
BEGIN
    DECLARE @TongLuong  DECIMAL(14,2);
    DECLARE @Luong      DECIMAL(12,2);
    DECLARE @SoGioDA    DECIMAL(8,2);
    DECLARE @TongGio    DECIMAL(10,2);

    -- Lương tháng của nhân viên
    SELECT @Luong = Luong FROM NHANVIEN WHERE MaNV = @MaNV;

    -- Số giờ làm cho dự án cụ thể
    SELECT @SoGioDA = SoGio FROM PHANCONG WHERE MaNV = @MaNV AND MaDA = @MaDA;

    -- Tổng số giờ nhân viên tham gia tất cả dự án
    SELECT @TongGio = SUM(SoGio) FROM PHANCONG WHERE MaNV = @MaNV;

    IF @Luong IS NULL OR @SoGioDA IS NULL OR @TongGio IS NULL OR @TongGio = 0
        SET @TongLuong = 0;
    ELSE
        SET @TongLuong = @Luong * (@SoGioDA / @TongGio);

    RETURN @TongLuong;
END;
GO

-- Kiểm tra 6.2:
SELECT dbo.fn_TongLuongNVTheoDA('NV001','DA01') AS [Luong NV001 theo DA01];
SELECT dbo.fn_TongLuongNVTheoDA('NV007','DA01') AS [Luong NV007 theo DA01];
GO

-- -----------------------------------------------
-- 6.3. fn_LuongTBTatCaPhong
-- Tổng tiền lương trung bình của TẤT CẢ phòng ban
-- -----------------------------------------------
IF OBJECT_ID('fn_LuongTBTatCaPhong', 'FN') IS NOT NULL
    DROP FUNCTION fn_LuongTBTatCaPhong;
GO

CREATE FUNCTION fn_LuongTBTatCaPhong ()
RETURNS DECIMAL(12,2)
AS
BEGIN
    DECLARE @LuongTB DECIMAL(12,2);
    SELECT @LuongTB = AVG(Luong) FROM NHANVIEN;
    IF @LuongTB IS NULL SET @LuongTB = 0;
    RETURN @LuongTB;
END;
GO

-- Kiểm tra 6.3:
SELECT dbo.fn_LuongTBTatCaPhong() AS [Luong TB Toan Cong Ty];
-- So sánh với từng phòng:
SELECT
    pb.MaPB,
    pb.TenPB,
    dbo.fn_LuongTBPhong(pb.MaPB)    AS [Luong TB Phong],
    dbo.fn_LuongTBTatCaPhong()      AS [Luong TB Toan Cong Ty]
FROM PHONGBAN pb;
GO

-- -----------------------------------------------
-- 6.4. fn_TienThuongTheoGio
-- Tổng tiền thưởng theo tổng giờ tham gia dự án
-- -----------------------------------------------
IF OBJECT_ID('fn_TienThuongTheoGio', 'FN') IS NOT NULL
    DROP FUNCTION fn_TienThuongTheoGio;
GO

CREATE FUNCTION fn_TienThuongTheoGio
(
    @Time_Total DECIMAL(10,2)
)
RETURNS DECIMAL(10,2)
AS
BEGIN
    DECLARE @TienThuong DECIMAL(10,2);

    IF      @Time_Total >= 150                           SET @TienThuong = 1600;
    ELSE IF @Time_Total >= 100 AND @Time_Total < 150     SET @TienThuong = 1200;
    ELSE IF @Time_Total > 60  AND @Time_Total < 100      SET @TienThuong = 1000;
    ELSE IF @Time_Total >= 30 AND @Time_Total <= 60      SET @TienThuong =  500;
    ELSE                                                  SET @TienThuong =    0;

    RETURN @TienThuong;
END;
GO

-- Kiểm tra 6.4:
SELECT
    pc.MaNV,
    nv.HoTen,
    SUM(pc.SoGio)                               AS [Tổng giờ],
    dbo.fn_TienThuongTheoGio(SUM(pc.SoGio))     AS [Tiền thưởng ($)]
FROM PHANCONG pc
JOIN NHANVIEN nv ON nv.MaNV = pc.MaNV
GROUP BY pc.MaNV, nv.HoTen
ORDER BY [Tiền thưởng ($)] DESC;
GO

-- -----------------------------------------------
-- 6.5. fn_TongSoDATheoPhong
-- Tổng số dự án theo mỗi phòng ban
-- -----------------------------------------------
IF OBJECT_ID('fn_TongSoDATheoPhong', 'FN') IS NOT NULL
    DROP FUNCTION fn_TongSoDATheoPhong;
GO

CREATE FUNCTION fn_TongSoDATheoPhong
(
    @MaPB VARCHAR(10)
)
RETURNS INT
AS
BEGIN
    DECLARE @SoDA INT;
    SELECT @SoDA = COUNT(*) FROM DEAN WHERE MaPB = @MaPB;
    IF @SoDA IS NULL SET @SoDA = 0;
    RETURN @SoDA;
END;
GO

-- Kiểm tra 6.5:
SELECT
    pb.MaPB,
    pb.TenPB,
    dbo.fn_TongSoDATheoPhong(pb.MaPB) AS [Số dự án]
FROM PHONGBAN pb;
GO

-- -----------------------------------------------
-- 6.6a. fn_ThongTinNhanVien_Inline
-- INLINE Table-Valued Function
-- Trả về: MaNV, HoTen, NgaySinh, NguoiThan, TongLuongTB
-- -----------------------------------------------
IF OBJECT_ID('fn_ThongTinNhanVien_Inline', 'IF') IS NOT NULL
    DROP FUNCTION fn_ThongTinNhanVien_Inline;
GO

CREATE FUNCTION fn_ThongTinNhanVien_Inline
(
    @MaPB VARCHAR(10)   -- Lọc theo phòng ban; truyền NULL để lấy tất cả
)
RETURNS TABLE
AS
RETURN
(
    SELECT
        nv.MaNV,
        nv.HoTen,
        nv.NgaySinh,
        -- Lấy người thân đầu tiên (nếu có)
        (
            SELECT TOP 1 TenNT + N' (' + ISNULL(QuanHe,'') + N')'
            FROM NGUOITHAN nt
            WHERE nt.MaNV = nv.MaNV
            ORDER BY TenNT
        )                                               AS NguoiThan,
        -- Lương trung bình của phòng ban nhân viên đó thuộc về
        dbo.fn_LuongTBPhong(nv.MaPB)                   AS TongLuongTB
    FROM NHANVIEN nv
    WHERE (@MaPB IS NULL OR nv.MaPB = @MaPB)
);
GO

-- -----------------------------------------------
-- 6.6b. fn_ThongTinNhanVien_Multi
-- MULTISTATEMENT Table-Valued Function
-- Cùng kết quả nhưng dùng cú pháp RETURNS @table TABLE(...)
-- -----------------------------------------------
IF OBJECT_ID('fn_ThongTinNhanVien_Multi', 'TF') IS NOT NULL
    DROP FUNCTION fn_ThongTinNhanVien_Multi;
GO

CREATE FUNCTION fn_ThongTinNhanVien_Multi
(
    @MaPB VARCHAR(10)
)
RETURNS @KetQua TABLE
(
    MaNV        VARCHAR(10),
    HoTen       NVARCHAR(60),
    NgaySinh    DATE,
    NguoiThan   NVARCHAR(100),
    TongLuongTB DECIMAL(12,2)
)
AS
BEGIN
    -- Bước 1: Lấy danh sách nhân viên
    INSERT INTO @KetQua (MaNV, HoTen, NgaySinh, TongLuongTB)
    SELECT
        nv.MaNV,
        nv.HoTen,
        nv.NgaySinh,
        dbo.fn_LuongTBPhong(nv.MaPB)
    FROM NHANVIEN nv
    WHERE (@MaPB IS NULL OR nv.MaPB = @MaPB);

    -- Bước 2: Cập nhật thông tin người thân
    UPDATE @KetQua
    SET NguoiThan = (
        SELECT TOP 1 TenNT + N' (' + ISNULL(QuanHe,'') + N')'
        FROM NGUOITHAN nt
        WHERE nt.MaNV = kq.MaNV
        ORDER BY TenNT
    )
    FROM @KetQua kq;

    RETURN;
END;
GO

-- Kiểm tra 6.6:
-- Inline TVF:
SELECT * FROM dbo.fn_ThongTinNhanVien_Inline('PB01');
SELECT * FROM dbo.fn_ThongTinNhanVien_Inline(NULL);   -- Tất cả phòng ban

-- Multistatement TVF:
SELECT * FROM dbo.fn_ThongTinNhanVien_Multi('PB01');
SELECT * FROM dbo.fn_ThongTinNhanVien_Multi(NULL);
GO

-- ============================================================
-- END OF SCRIPT
-- ============================================================
