use master
go

create database QuanLiHopDong

drop database QuanLiHopDong

use QuanLiHopDong


CREATE TABLE NGUOIDUNG
(
  MaNV NVARCHAR(5) DEFAULT dbo.taoMaNV(), 
  TenDangNhap VARCHAR(50) NOT NULL UNIQUE, -- tên đăng nhập duy nhất
  HoTen NVARCHAR(50) NOT NULL,
  GioiTinh BIT NOT NULL,  --0 nam, 1 nữ
  NgaySinh DATE NOT NULL,	
  MatKhau VARCHAR(20) NOT NULL DEFAULT '12345',
  Mail NVARCHAR(50) NOT NULL,
  VaiTro NVARCHAR(20) NOT NULL,
  SDT NVARCHAR(10) NOT NULL, 
  PhongBan NVARCHAR(20) NOT NULL,
  NgayVaoLam DATE NOT NULL DEFAULT GETDATE(),
  DiaChi NVARCHAR(50) NOT NULL,
  PRIMARY KEY (MaNV)
)
go

---Thêm dữ liệu Super Admin---
insert into NGUOIDUNG(HoTen, TenDangNhap, GioiTinh, NgaySinh, Mail, VaiTro, SDT, PhongBan, DiaChi)
values	('Admin','nguyenvana',0,'1967-02-01','admin@gmail.com','Admin','0912332222','IT','quan 7')

---Thêm dữ liệu nhân viên Sale---
insert into NGUOIDUNG(HoTen, TenDangNhap, GioiTinh, NgaySinh, Mail, VaiTro, SDT, PhongBan, DiaChi)
values	('Sale num0', 'nguyenvanb', 0,'1970-10-22','sale0@gmail.com','Sale','0912332212','Sale','quan 7')

insert into NGUOIDUNG(HoTen, TenDangNhap, GioiTinh, NgaySinh, Mail, VaiTro, SDT, PhongBan, DiaChi)
values	('Sale num1', 'nguyenvanc', 0,'1971-04-22','sale1@gmail.com','Sale','0912332213','Sale','quan 7')

insert into NGUOIDUNG(HoTen, TenDangNhap, GioiTinh, NgaySinh, Mail, VaiTro, SDT, PhongBan, DiaChi)
values ('Sale num2', 'nguyenvand', 1,'1980-01-18','sale2@gmail.com','Sale','0912339213','Sale','quan 7')

insert into NGUOIDUNG(HoTen, TenDangNhap, GioiTinh, NgaySinh, Mail, VaiTro, SDT, PhongBan, DiaChi)
values ('Sale num3','nguyenvane', 1,'2000-11-02','sale3@gmail.com','Sale','0912339523','Sale','quan 7')

insert into NGUOIDUNG(HoTen, TenDangNhap, GioiTinh, NgaySinh, Mail, VaiTro, SDT, PhongBan, DiaChi)
values ('Sale num4', 'nguyenvanf', 1,'1990-09-05','sale4@gmail.com','Sale','0912394323','Sale','quan 7')

---Thêm dữ liệu nhân viên Kế toán---
insert into NGUOIDUNG(HoTen, TenDangNhap, GioiTinh, NgaySinh, Mail, VaiTro, SDT, PhongBan, DiaChi)
values ('Kế toán num0', 'tranvana', 1, '1992-04-04', 'ketoan0@gmail.com', 'Accountant', '0284851679', 'Accountant', 'quan7')

insert into NGUOIDUNG(HoTen, TenDangNhap, GioiTinh, NgaySinh, Mail, VaiTro, SDT, PhongBan, DiaChi)
values ('Kế toán num1', 'tranvanb', 1,'1991-05-29', 'ketoan1@gmail.com', 'Accountant', '0284482679', 'Accountant', 'quan7')

insert into NGUOIDUNG(HoTen, TenDangNhap, GioiTinh, NgaySinh, Mail, VaiTro, SDT, PhongBan, DiaChi)
values ('Kế toán num2', 'tranvanc', 0, '1992-06-24', 'ketoan2@gmail.com', 'Accountant', '0734851139', 'Accountant', 'quan7')

insert into NGUOIDUNG(HoTen, TenDangNhap, GioiTinh, NgaySinh, Mail, VaiTro, SDT, PhongBan, DiaChi)
values ('Kế toán num3', 'tranvand', 1,'1999-05-23', 'ketoan3@gmail.com', 'Accountant', '0284838651', 'Accountant', 'quan7')

insert into NGUOIDUNG(HoTen, TenDangNhap, GioiTinh, NgaySinh, Mail, VaiTro, SDT, PhongBan, DiaChi)
values ('Kế toán num4', 'tranvane', 0,'1991-09-20', 'ketoan4@gmail.com', 'Accountant', '0327451679', 'Accountant', 'quan7')

---Thêm dữ liệu Trưởng phòng Sale---
insert into NGUOIDUNG(HoTen, TenDangNhap, GioiTinh, NgaySinh, Mail, VaiTro, SDT, PhongBan, DiaChi)
values	('Trưởng Sale num0', 'trannguyenvana', 0,'1970-06-23','salemanager0@gmail.com','Sale Manager','0912332212','Sale','quan 7')

---Thêm dữ liệu Trưởng phòng Kế toán---
insert into NGUOIDUNG(HoTen, TenDangNhap, GioiTinh, NgaySinh, Mail, VaiTro, SDT, PhongBan, DiaChi)
values	('Kế toán trưởng num0', 'trannguyenvanb', 1,'1980-05-21','ketoantruong0@gmail.com','Accountant Manager','0921092212','Accountant','quan 7')

---Thêm dữ liệu Giám đốc---
insert into NGUOIDUNG(HoTen, TenDangNhap, GioiTinh, NgaySinh, Mail, VaiTro, SDT, PhongBan, DiaChi)
values	('Giám đốc num0','trannguyenvanc', 0,'1972-11-20','giamdoc0@gmail.com','CEO','0936681910','CEO','quan 7')



select * from NGUOIDUNG where MaNV = '00000' and MatKhau = '12345'

select * from NGUOIDUNG 


CREATE TABLE HOPDONG
(
  MaHD NVARCHAR(5) DEFAULT dbo.taoMaHD() UNIQUE,
  MaNV NVARCHAR(5) NOT NULL, --ma nhan vien tao hop dong
  TenHopDong NVARCHAR(50) NOT NULL,
  TenNguoiDaiDien NVARCHAR(50) NOT NULL,
  NgayBatDau DATE NOT NULL DEFAULT GETDATE(),
  NgayKetThuc DATE NOT NULL, -- ngay ket thuc phai sau ngay bat dau
  GiaTriHD INT NOT NULL,
  MucHoaHong INT NOT NULL DEFAULT 5, --Mặc định ban đầu 5% (Không cho phép người tạo hđ thay đổi- chỉ trưởng Sale được thay đổi)
  ChiaGiaiDoan INT NOT NULL, --Chia theo thời gian thực hiện
  DaThanhToan INT NOT NULL DEFAULT 0, --Trừ số tiền ghi nhận thanh toán
  NoiDungHD NVARCHAR(100) NOT NULL,
  TinhTrangHD NVARCHAR(20) NOT NULL DEFAULT N'Chưa thực hiện', --Chưa thực hiện, đang thực hiện, chờ nghiệm thu, đã xong
  TenNguoiLienHe NVARCHAR(50) NOT NULL, --của người liên hệ
  DiaChi NVARCHAR(50) NOT NULL, --của người liên hệ
  SDT NVARCHAR(10) NOT NULL, --của người liên hệ
  Mail NVARCHAR(50) NOT NULL, --của người liên hệ
  PRIMARY KEY (MaHD, MaNV),
  FOREIGN KEY (MaNV) REFERENCES NGUOIDUNG(MaNV)
)

---Thêm dữ liệu Hợp Đồng---
insert into HOPDONG(MaNV, TenHopDong, TenNguoiDaiDien, NgayBatDau, NgayKetThuc, GiaTriHD, MucHoaHong, ChiaGiaiDoan, DaThanhToan, NoiDungHD, TinhTrangHD, TenNguoiLienHe, DiaChi, SDT, Mail)
values ('00001', 'Quay 50 video','Công ty Milo', '2023-11-21', '2024-10-24', 1768, 5, 2, 0, 'Quay video về abc','Chưa thực hiện', 'Đại sứ Milo', '1 NHT Quận 7', '0936681910', 'abc@gmail.com')
insert into HOPDONG(MaNV, TenHopDong, TenNguoiDaiDien, NgayBatDau, NgayKetThuc, GiaTriHD, MucHoaHong, ChiaGiaiDoan, DaThanhToan, NoiDungHD, TinhTrangHD, TenNguoiLienHe, DiaChi, SDT, Mail)
values ('00003', 'Chụp 5 hình', 'Valhein', '2024-1-2', '2024-5-6', 1231, 5, 2, 0, 'Chụp hình về abc', 'Đang thực hiện', 'Valhein', '1 NHT Quận 7', '0936681911', 'def@gmail.com')
insert into HOPDONG(MaNV, TenHopDong, TenNguoiDaiDien, NgayBatDau, NgayKetThuc, GiaTriHD, MucHoaHong, ChiaGiaiDoan, DaThanhToan, NoiDungHD, TinhTrangHD, TenNguoiLienHe, DiaChi, SDT, Mail)
values ('00002', 'Quay 10 video', 'Công ty Omo', '2024-2-22', '2025-1-3', 7564, 5, 2, 564, 'Quay video về abc', 'Đang thực hiện', 'Đại sứ Omo', '1 NHT Quận 7', '0936681912', 'jkl@gmail.com')
insert into HOPDONG(MaNV, TenHopDong, TenNguoiDaiDien, NgayBatDau, NgayKetThuc, GiaTriHD, MucHoaHong, ChiaGiaiDoan, DaThanhToan, NoiDungHD, TinhTrangHD, TenNguoiLienHe, DiaChi, SDT, Mail)
values ('00005', 'Chụp 10 hình', 'Công ty Asus', '2022-8-6', '2023-7-12', 8764, 5, 2, 8000, 'Chụp hình về abc', 'Chờ nghiệm thu', 'Đại sứ Asus', '1 NHT Quận 7', '0936681913', 'abcd@gmail.com')
insert into HOPDONG(MaNV, TenHopDong, TenNguoiDaiDien, NgayBatDau, NgayKetThuc, GiaTriHD, MucHoaHong, ChiaGiaiDoan, DaThanhToan, NoiDungHD, TinhTrangHD, TenNguoiLienHe, DiaChi, SDT, Mail)
values ('00004', 'Quay 5 video', 'Công ty Grab', '2024-4-3', '2024-8-12', 8143, 5, 2, 8143, 'Quay video về abc', 'Đã xong', 'Đại sứ Grab', '1 NHT Quận 7', '0936681914', 'abcf@gmail.com')
insert into HOPDONG(MaNV, TenHopDong, TenNguoiDaiDien, NgayBatDau, NgayKetThuc, GiaTriHD, MucHoaHong, ChiaGiaiDoan, DaThanhToan, NoiDungHD, TinhTrangHD, TenNguoiLienHe, DiaChi, SDT, Mail)
values ('00002', 'Chụp 15 hình', 'Công ty Foody', '2024-4-3', '2024-4-5', 6523, 5, 2, 0, 'Chụp hình về abc', 'Chưa thực hiện', 'Đại sứ Foody', '1 NHT Quận 7', '0936681915', 'abce@gmail.com')

select * from HOPDONG


CREATE TABLE GIAIDOANTHANHTOAN
(
  MaTienDoTT NVARCHAR(10) DEFAULT dbo.taoMaTienDoTT(),
  MaHD NVARCHAR(5) NOT NULL,
  TenHopDong NVARCHAR(50) NOT NULL,
  GiaiDoan INT NOT NULL,
  NgayThanhToan DATE NOT NULL,
  PhanTramThanhToan INT NOT NULL,
  GiaTriThanhToan INT NOT NULL,
  TrangThaiThanhToan BIT NOT NULL, -- 1 Đã thanh toán, 0 Chờ thanh toán
  NgayNhanThanhToan DATE NULL,
  GhiChu NVARCHAR(100) NULL,
  PRIMARY KEY (MaTienDoTT, MaHD),
  FOREIGN KEY (MaHD) REFERENCES HOPDONG(MaHD)
  FOREIGN KEY (MaThanhToan) REFERENCES HOPDONG(MaHD)
)
select * from TienDoThanhToan 



CREATE TABLE THANHTOAN
(
  MaThanhToan NVARCHAR(5) DEFAULT dbo.taoMaThanhToan(),
  TienThanhToan INT NOT NULL,
  NgayThanhToan DATE NOT NULL DEFAULT GETDATE(),
  PhuongThuc BIT NOT NULL, --0 neu thanh toan bang tien mat, 1 neu chuyen khoan,
  PRIMARY KEY (MaThanhToan)
)

---Thêm dữ liệu Thanh Toán---
insert into THANHTOAN(TienThanhToan, PhuongThuc)
values (564, 0)

insert into THANHTOAN(TienThanhToan, PhuongThuc)
values (8000, 1)

insert into THANHTOAN(TienThanhToan, PhuongThuc)
values (8143, 1)

select * from THANHTOAN




CREATE TABLE TIENDOHOPDONG
(
  MaGiaiDoan NVARCHAR(5) DEFAULT dbo.taoMaGiaiDoan(),
  NgayBatDau DATE NOT NULL,
  NgayKetThuc DATE NOT NULL,
  MaHD NVARCHAR(5) NOT NULL,
  MaNV NVARCHAR(5) NOT NULL,
  NVThucHienCV NVARCHAR(5),
  KhoiLuongCongViec INT NOT NULL,
  TongKhoiLuongCongViec INT NOT NULL,
  PRIMARY KEY (MaGiaiDoan),
  FOREIGN KEY (MaHD, MaNV) REFERENCES HOPDONG(MaHD,MaNV),
)

---Thêm dữ liệu giai đoạn hợp đồng
insert into GIAIDOANHOPDONG(TinhTrangTT, PhanTramHD, NgayBatDau, NgayKetThuc, MaHD, MaThanhToan, MaNV)
values(1, 50, '2024-01-02', '2024-04-02', '00003', '00002', '00005')
insert into GIAIDOANHOPDONG(TinhTrangTT, PhanTramHD, NgayBatDau, NgayKetThuc, MaHD, MaThanhToan, MaNV)
values(1, 50, '2024-04-03', '2024-05-06', '00003', '00002', '00005')
insert into GIAIDOANHOPDONG(TinhTrangTT, PhanTramHD, NgayBatDau, NgayKetThuc, MaHD, MaThanhToan, MaNV)
values(0, 40, '2023-11-21', '2024-02-21', '00001', '00000', '00003')

select * from GIAIDOANHOPDONG

CREATE TABLE TIENDODUAN
(
  MaTienDo NVARCHAR(5) DEFAULT dbo.taoMaTienDo(),
  MucTienDo INT NOT NULL,
  NDCongViec NVARCHAR(50) NOT NULL,
  MaHD NVARCHAR(5) NOT NULL,
  MaNV NVARCHAR(5) NOT NULL,
  PRIMARY KEY (MaTienDo),
  FOREIGN KEY (MaHD, MaNV) REFERENCES HOPDONG(MaHD, MaNV)
)

---Thêm dữ liệu tiến độ dự án---
insert into TIENDODUAN(MucTienDo, NDCongViec, MaHD, MaNV)
values(50, 'Quay video 10 công thức nấu ăn', '00001', '00003')

insert into TIENDODUAN(MucTienDo, NDCongViec, MaHD, MaNV)
values(40, 'Quay video 10 công thức pha Milo', '00000', '00001')

insert into TIENDODUAN(MucTienDo, NDCongViec, MaHD, MaNV)
values(30, 'Quay video công thức đặt Grab', '00004', '00004')

insert into TIENDODUAN(MucTienDo, NDCongViec, MaHD, MaNV)
values(50, 'Quay video công thức đặt Foody', '00005', '00002')

insert into TIENDODUAN(MucTienDo, NDCongViec, MaHD, MaNV)
values(70, 'Quay video cách sử dụng Omo', '00002', '00002')

select * from TIENDODUAN





	--Function tao khoa chinh--

--Tạo mã người dùng--
CREATE FUNCTION taoMaNV()
RETURNS NVARCHAR(5)
AS
BEGIN
    DECLARE @newMaNV NVARCHAR(5)
    DECLARE @maxNumericPart INT

    -- Lấy phần số lớn nhất hiện tại trong mã NV
    SELECT @maxNumericPart = MAX(CAST(MaNV AS INT))
    FROM NGUOIDUNG

    -- Nếu chưa có mã NV nào, bắt đầu từ 00001
    IF @maxNumericPart IS NULL
        SET @maxNumericPart = 0

    -- Tăng phần số lên 1 và tạo mã mới
    SET @newMaNV = RIGHT('00000' + CAST(@maxNumericPart + 1 AS NVARCHAR), 5)

    RETURN @newMaNV
END
GO


-- Tạo mã hợp đồng --
CREATE FUNCTION taoMaHD()
RETURNS NVARCHAR(5)
AS
BEGIN
    DECLARE @newMaHD NVARCHAR(5)
    DECLARE @maxNumericPart INT

    -- Lấy phần số lớn nhất hiện tại trong mã HD
    SELECT @maxNumericPart = MAX(CAST(SUBSTRING(MaHD, 3, 3) AS INT))
    FROM HOPDONG
    WHERE MaHD LIKE 'HD%'

    -- Nếu chưa có mã HD nào, bắt đầu từ HD001
    IF @maxNumericPart IS NULL
        SET @maxNumericPart = 0

    -- Tăng phần số lên 1 và tạo mã mới
    SET @newMaHD = 'HD' + RIGHT('000' + CAST(@maxNumericPart + 1 AS NVARCHAR), 3)

    RETURN @newMaHD
END
GO

-- Tạo mã tiến độ thanh toán --
CREATE FUNCTION taoMaTienDoTT()
RETURNS NVARCHAR(5)
AS
BEGIN
    DECLARE @newMaTienDoTT NVARCHAR(5)
    DECLARE @maxNumericPart INT

    -- Lấy phần số lớn nhất hiện tại trong MaTienDoTT
    SELECT @maxNumericPart = MAX(CAST(MaTienDoTT AS INT))
    FROM TienDoThanhToan

    -- Nếu chưa có mã tiến độ nào, bắt đầu từ 00001
    IF @maxNumericPart IS NULL
        SET @maxNumericPart = 0

    -- Tăng phần số lên 1 và tạo mã mới
    SET @newMaTienDoTT = RIGHT('00000' + CAST(@maxNumericPart + 1 AS NVARCHAR), 5)

    RETURN @newMaTienDoTT
END
GO




CREATE FUNCTION taoMaThanhToan()
RETURNS NVARCHAR(5)
AS
BEGIN
    DECLARE @newMaThanhToan NVARCHAR(5);
    select @newMaThanhToan = max(MaThanhToan) from THANHTOAN
    IF @newMaThanhToan IS NULL
        SET @newMaThanhToan = '00000'; 
	ELSE
		SET @newMaThanhToan = RIGHT('00000' +CAST((CAST(@newMaThanhToan AS INT) + 1) AS NVARCHAR),5);
	RETURN @newMaThanhToan
END
go





CREATE FUNCTION taoMaGiaiDoan()
RETURNS NVARCHAR(5)
AS
BEGIN
    DECLARE @newMaGiaiDoan NVARCHAR(5);
    select @newMaGiaiDoan = max(MaGiaiDoan) from GIAIDOANHOPDONG
    IF @newMaGiaiDoan IS NULL
        SET @newMaGiaiDoan = '00000'; 
	IF (CAST(@newMaGiaiDoan AS INT) > -1)
		SET @newMaGiaiDoan = RIGHT('00000' +CAST((CAST(@newMaGiaiDoan AS INT) + 1) AS NVARCHAR),5);
	RETURN @newMaGiaiDoan
END
go


CREATE FUNCTION taoMaTienDo()
RETURNS NVARCHAR(5)
AS
BEGIN
    DECLARE @newMaTienDo NVARCHAR(5);
    select @newMaTienDo = max(MaTienDo) from TIENDODUAN
    IF @newMaTienDo IS NULL
        SET @newMaTienDo = '00000'; 
	IF (CAST(@newMaTienDo AS INT) > -1)
		SET @newMaTienDo = RIGHT('00000' +CAST((CAST(@newMaTienDo AS INT) + 1) AS NVARCHAR),5);
	RETURN @newMaTienDo
END
go











-- Trigger 

CREATE TRIGGER checkSDT
ON NGUOIDUNG
FOR INSERT, UPDATE
AS
BEGIN
    IF EXISTS (SELECT * FROM INSERTED WHERE LEN(SDT) <> 10)
    BEGIN
        ROLLBACK TRANSACTION;
    END
END
go


CREATE TRIGGER checkNgay
ON HOPDONG
FOR INSERT, UPDATE
AS
BEGIN
    IF EXISTS (SELECT * FROM inserted WHERE NgayBatDau >= NgayKetThuc)
    BEGIN
        ROLLBACK TRANSACTION;
    END
END;