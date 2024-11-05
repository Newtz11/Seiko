use master
go

create database QuanLiHopDong

drop database QuanLiHopDong

use QuanLiHopDong


CREATE TABLE NGUOIDUNG
(
  MaNV NVARCHAR(5) DEFAULT dbo.taoMaNV(), 
  HoTen NVARCHAR(50) NOT NULL,
  GioiTinh BIT NOT NULL,  --0 nam, 1 nýÞ
  NgaySinh DATE NOT NULL,	
  MatKhau VARCHAR(20) NOT NULL DEFAULT '12345',
  Mail NVARCHAR(50) NOT NULL,
  VaiTro NVARCHAR(20) NOT NULL, -- 
  SDT NVARCHAR(10) NOT NULL, 
  PhongBan NVARCHAR(20) NOT NULL,
  NgayVaoLam DATE NOT NULL DEFAULT GETDATE(),
  DiaChi NVARCHAR(50) NOT NULL,
  PRIMARY KEY (MaNV)
)
go

---Thêm dýÞ liêòu Super Admin---
insert into NGUOIDUNG(HoTen, GioiTinh, NgaySinh, Mail, VaiTro, SDT, PhongBan, DiaChi)
values	('Admin',0,'1967-02-01','admin@gmail.com','Admin','0912332222','IT','quan 7')

---Thêm dýÞ liêòu nhân viên Sale---
insert into NGUOIDUNG(HoTen, GioiTinh, NgaySinh, Mail, VaiTro, SDT, PhongBan, DiaChi)
values	('Sale num0',0,'1970-10-22','sale0@gmail.com','Sale','0912332212','Sale','quan 7')

insert into NGUOIDUNG(HoTen, GioiTinh, NgaySinh, Mail, VaiTro, SDT, PhongBan, DiaChi)
values	('Sale num1',0,'1971-04-22','sale1@gmail.com','Sale','0912332213','Sale','quan 7')

insert into NGUOIDUNG(HoTen, GioiTinh, NgaySinh, Mail, VaiTro, SDT, PhongBan, DiaChi)
values ('Sale num2',1,'1980-01-18','sale2@gmail.com','Sale','0912339213','Sale','quan 7')

insert into NGUOIDUNG(HoTen, GioiTinh, NgaySinh, Mail, VaiTro, SDT, PhongBan, DiaChi)
values ('Sale num3',1,'2000-11-02','sale3@gmail.com','Sale','0912339523','Sale','quan 7')

insert into NGUOIDUNG(HoTen, GioiTinh, NgaySinh, Mail, VaiTro, SDT, PhongBan, DiaChi)
values ('Sale num4',1,'1990-09-05','sale4@gmail.com','Sale','0912394323','Sale','quan 7')

---Thêm dýÞ liêòu nhân viên Kêì toaìn---
insert into NGUOIDUNG(HoTen, GioiTinh, NgaySinh, Mail, VaiTro, SDT, PhongBan, DiaChi)
values ('Kêì toaìn num0', 1, '1992-04-04', 'ketoan0@gmail.com', 'Accountant', '0284851679', 'Accountant', 'quan7')

insert into NGUOIDUNG(HoTen, GioiTinh, NgaySinh, Mail, VaiTro, SDT, PhongBan, DiaChi)
values ('Kêì toaìn num1', 1,'1991-05-29', 'ketoan1@gmail.com', 'Accountant', '0284482679', 'Accountant', 'quan7')

insert into NGUOIDUNG(HoTen, GioiTinh, NgaySinh, Mail, VaiTro, SDT, PhongBan, DiaChi)
values ('Kêì toaìn num2', 0, '1992-06-24', 'ketoan2@gmail.com', 'Accountant', '0734851139', 'Accountant', 'quan7')

insert into NGUOIDUNG(HoTen, GioiTinh, NgaySinh, Mail, VaiTro, SDT, PhongBan, DiaChi)
values ('Kêì toaìn num3', 1,'1999-05-23', 'ketoan3@gmail.com', 'Accountant', '0284838651', 'Accountant', 'quan7')

insert into NGUOIDUNG(HoTen, GioiTinh, NgaySinh, Mail, VaiTro, SDT, PhongBan, DiaChi)
values ('Kêì toaìn num4', 0,'1991-09-20', 'ketoan4@gmail.com', 'Accountant', '0327451679', 'Accountant', 'quan7')

---Thêm dýÞ liêòu TrýõÒng phoÌng Sale---
insert into NGUOIDUNG(HoTen, GioiTinh, NgaySinh, Mail, VaiTro, SDT, PhongBan, DiaChi)
values	('TrýõÒng Sale num0',0,'1970-06-23','salemanager0@gmail.com','Sale Manager','0912332212','Sale','quan 7')

---Thêm dýÞ liêòu TrýõÒng phoÌng Kêì toaìn---
insert into NGUOIDUNG(HoTen, GioiTinh, NgaySinh, Mail, VaiTro, SDT, PhongBan, DiaChi)
values	('Kêì toaìn trýõÒng num0',1,'1980-05-21','ketoantruong0@gmail.com','Accountant Manager','0921092212','Accountant','quan 7')

---Thêm dýÞ liêòu Giaìm ðôìc---
insert into NGUOIDUNG(HoTen, GioiTinh, NgaySinh, Mail, VaiTro, SDT, PhongBan, DiaChi)
values	('Giaìm ðôìc num0',0,'1972-11-20','giamdoc0@gmail.com','CEO','0936681910','CEO','quan 7')



select * from NGUOIDUNG where MaNV = '00000' and MatKhau = '12345'



CREATE TABLE HOPDONG
(
  MaHD NVARCHAR(5) DEFAULT dbo.taoMaHD(),
  MaNV NVARCHAR(5) NOT NULL,
  TenKhachHang NVARCHAR(50) NOT NULL,
  GiaTriHD INT NOT NULL,
  NgayBatDau DATE NOT NULL DEFAULT GETDATE(),
  NgayKetThuc DATE NOT NULL, -- ngay ket thuc phai sau ngay bat dau
  TenDuAn NVARCHAR(50) NOT NULL,
  MucHoaHong INT NOT NULL,
  ChiaGiaiDoan INT NOT NULL,
  DaThanhToan INT NOT NULL,
  GiaTriConLai INT NOT NULL,
  TinhTrangHD NVARCHAR(20) NOT NULL,
  TrangThaiDuyet BIT NOT NULL, --0: chýa duyêòt, 1: ðaÞ duyêòt
  PRIMARY KEY (MaHD, MaNV),
  FOREIGN KEY (MaNV) REFERENCES NGUOIDUNG(MaNV)
)

---Thêm dýÞ liêòu Hõòp ÐôÌng---
insert into HOPDONG(MaNV, TenKhachHang, GiaTriHD, NgayBatDau, NgayKetThuc, TenDuAn, MucHoaHong, ChiaGiaiDoan, DaThanhToan, GiaTriConLai, TinhTrangHD, TrangThaiDuyet)
values ('00001', 'Milo', 1768, '2023-11-21', '2024-10-24', 'quang cao', 5, 2, 0, 1768, 'Chýa thýòc hiêòn', 0)
insert into HOPDONG(MaNV, TenKhachHang, GiaTriHD, NgayBatDau, NgayKetThuc, TenDuAn, MucHoaHong, ChiaGiaiDoan, DaThanhToan, GiaTriConLai, TinhTrangHD, TrangThaiDuyet)
values ('00003', 'Lays', 1231, '2024-1-2', '2024-5-6', 'quang cao', 5, 2, 0, 1231, 'Ðang thýòc hiêòn', 1)
insert into HOPDONG(MaNV, TenKhachHang, GiaTriHD, NgayBatDau, NgayKetThuc, TenDuAn, MucHoaHong, ChiaGiaiDoan, DaThanhToan, GiaTriConLai, TinhTrangHD, TrangThaiDuyet)
values ('00002', 'Omo', 7564, '2024-2-22', '2025-1-3', 'quang cao', 5, 2, 564, 7000,'Ðang thýòc hiêòn', 1)
insert into HOPDONG(MaNV, TenKhachHang, GiaTriHD, NgayBatDau, NgayKetThuc, TenDuAn, MucHoaHong, ChiaGiaiDoan, DaThanhToan, GiaTriConLai, TinhTrangHD, TrangThaiDuyet)
values ('00005', 'Asus', 8764, '2022-8-6', '2023-7-12', 'quang cao', 5, 2, 8000, 764, 'ChõÌ nghiêòm thu', 1)
insert into HOPDONG(MaNV, TenKhachHang, GiaTriHD, NgayBatDau, NgayKetThuc, TenDuAn, MucHoaHong, ChiaGiaiDoan, DaThanhToan, GiaTriConLai, TinhTrangHD, TrangThaiDuyet)
values ('00004', 'Grab', 8143, '2024-4-3', '2024-8-12', 'quang cao', 5, 2, 8143, 0, 'ÐaÞ xong', 1)
insert into HOPDONG(MaNV, TenKhachHang, GiaTriHD, NgayBatDau, NgayKetThuc, TenDuAn, MucHoaHong, ChiaGiaiDoan, DaThanhToan, GiaTriConLai, TinhTrangHD, TrangThaiDuyet)
values ('00002', 'Foody', 6523, '2024-4-3', '2024-4-5', 'quang cao', 5, 2, 0, 6523, 'Chýa thýòc hiêòn', 0)

select * from HOPDONG






CREATE TABLE THANHTOAN
(
  MaThanhToan NVARCHAR(5) DEFAULT dbo.taoMaThanhToan(),
  TienThanhToan INT NOT NULL,
  NgayThanhToan DATE NOT NULL DEFAULT GETDATE(),
  PhuongThuc BIT NOT NULL, --0 neu thanh toan bang tien mat, 1 neu chuyen khoan,
  PRIMARY KEY (MaThanhToan)
)

---Thêm dýÞ liêòu Thanh Toaìn---
insert into THANHTOAN(TienThanhToan, PhuongThuc)
values (564, 0)

insert into THANHTOAN(TienThanhToan, PhuongThuc)
values (8000, 1)

insert into THANHTOAN(TienThanhToan, PhuongThuc)
values (8143, 1)

select * from THANHTOAN




CREATE TABLE GIAIDOANHOPDONG
(
  MaGiaiDoan NVARCHAR(5) DEFAULT dbo.taoMaGiaiDoan(),
  TinhTrangTT BIT NOT NULL, --0 neu la chua thanh toan va 1 neu thanh toan roi
  PhanTramHD INT NOT NULL,
  NgayBatDau DATE NOT NULL,
  NgayKetThuc DATE NOT NULL,
  MaHD NVARCHAR(5) NOT NULL,
  MaThanhToan NVARCHAR(5) NOT NULL,
  MaNV NVARCHAR(5) NOT NULL,
  PRIMARY KEY (MaGiaiDoan),
  FOREIGN KEY (MaHD, MaNV) REFERENCES HOPDONG(MaHD,MaNV),
  FOREIGN KEY (MaThanhToan) REFERENCES THANHTOAN(MaThanhToan)
)

---Thêm dýÞ liêòu giai ðoaòn hõòp ðôÌng
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

---Thêm dýÞ liêòu tiêìn ðôò dýò aìn---
insert into TIENDODUAN(MucTienDo, NDCongViec, MaHD, MaNV)
values(50, 'Quay video 10 công thýìc nâìu ãn', '00001', '00003')

insert into TIENDODUAN(MucTienDo, NDCongViec, MaHD, MaNV)
values(40, 'Quay video 10 công thýìc pha Milo', '00000', '00001')

insert into TIENDODUAN(MucTienDo, NDCongViec, MaHD, MaNV)
values(30, 'Quay video công thýìc ðãòt Grab', '00004', '00004')

insert into TIENDODUAN(MucTienDo, NDCongViec, MaHD, MaNV)
values(50, 'Quay video công thýìc ðãòt Foody', '00005', '00002')

insert into TIENDODUAN(MucTienDo, NDCongViec, MaHD, MaNV)
values(70, 'Quay video caìch sýÒ duòng Omo', '00002', '00002')

select * from TIENDODUAN





--Function tao khoa chinh


CREATE FUNCTION taoMaNV()
RETURNS NVARCHAR(5)
AS
BEGIN
    DECLARE @newMaNV NVARCHAR(5);
    select @newMaNV = max(MaNV) from NGUOIDUNG 
    IF (@newMaNV IS NULL)
        SET @newMaNV = '00000'; 
	ELSE
		SET @newMaNV = RIGHT('00000' +CAST((CAST(@newMaNV AS INT) + 1) AS NVARCHAR),5);
	RETURN @newMaNV
END
go





CREATE FUNCTION taoMaHD()
RETURNS NVARCHAR(5)
AS
BEGIN
    DECLARE @newMaHD NVARCHAR(5);
    select @newMaHD = max(MaHD) from HOPDONG
    IF @newMaHD IS NULL
        SET @newMaHD = '00000'; 
	ELSE
		SET @newMaHD = RIGHT('00000' +CAST((CAST(@newMaHD AS INT) + 1) AS NVARCHAR),5);
	RETURN @newMaHD
END
go




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