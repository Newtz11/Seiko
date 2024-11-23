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
  TinhTrangHoatDong BIT NOT NULL DEFAULT 1, --1 Đang hoạt động, 0 Ngưng hoạt động
  PRIMARY KEY (MaNV)
)
go

---Thêm dữ liệu Super Admin---
insert into NGUOIDUNG(HoTen, TenDangNhap, GioiTinh, NgaySinh, Mail, VaiTro, SDT, PhongBan, DiaChi)
values	(N'Admin','nguyenvana',0,'1967-02-01','admin@gmail.com','Admin','0912332222','IT','quan 7')

---Thêm dữ liệu nhân viên Sale---
insert into NGUOIDUNG(HoTen, TenDangNhap, GioiTinh, NgaySinh, Mail, VaiTro, SDT, PhongBan, DiaChi)
values	(N'Sale num0', 'nguyenvanb', 0,'1970-10-22','sale0@gmail.com','Sale','0912332212','Sale','quan 7')

insert into NGUOIDUNG(HoTen, TenDangNhap, GioiTinh, NgaySinh, Mail, VaiTro, SDT, PhongBan, DiaChi)
values	(N'Sale num1', 'nguyenvanc', 0,'1971-04-22','sale1@gmail.com','Sale','0912332213','Sale','quan 7')

insert into NGUOIDUNG(HoTen, TenDangNhap, GioiTinh, NgaySinh, Mail, VaiTro, SDT, PhongBan, DiaChi)
values (N'Sale num2', 'nguyenvand', 1,'1980-01-18','sale2@gmail.com','Sale','0912339213','Sale','quan 7')

insert into NGUOIDUNG(HoTen, TenDangNhap, GioiTinh, NgaySinh, Mail, VaiTro, SDT, PhongBan, DiaChi)
values (N'Sale num3','nguyenvane', 1,'2000-11-02','sale3@gmail.com','Sale','0912339523','Sale','quan 7')

insert into NGUOIDUNG(HoTen, TenDangNhap, GioiTinh, NgaySinh, Mail, VaiTro, SDT, PhongBan, DiaChi)
values (N'Sale num4', 'nguyenvanf', 1,'1990-09-05','sale4@gmail.com','Sale','0912394323','Sale','quan 7')

---Thêm dữ liệu nhân viên Kế toán---
insert into NGUOIDUNG(HoTen, TenDangNhap, GioiTinh, NgaySinh, Mail, VaiTro, SDT, PhongBan, DiaChi)
values (N'Kế toán num0', 'tranvana', 1, '1992-04-04', 'ketoan0@gmail.com', 'Accountant', '0284851679', 'Accountant', 'quan7')

insert into NGUOIDUNG(HoTen, TenDangNhap, GioiTinh, NgaySinh, Mail, VaiTro, SDT, PhongBan, DiaChi)
values (N'Kế toán num1', 'tranvanb', 1,'1991-05-29', 'ketoan1@gmail.com', 'Accountant', '0284482679', 'Accountant', 'quan7')

insert into NGUOIDUNG(HoTen, TenDangNhap, GioiTinh, NgaySinh, Mail, VaiTro, SDT, PhongBan, DiaChi)
values (N'Kế toán num2', 'tranvanc', 0, '1992-06-24', 'ketoan2@gmail.com', 'Accountant', '0734851139', 'Accountant', 'quan7')

insert into NGUOIDUNG(HoTen, TenDangNhap, GioiTinh, NgaySinh, Mail, VaiTro, SDT, PhongBan, DiaChi)
values (N'Kế toán num3', 'tranvand', 1,'1999-05-23', 'ketoan3@gmail.com', 'Accountant', '0284838651', 'Accountant', 'quan7')

insert into NGUOIDUNG(HoTen, TenDangNhap, GioiTinh, NgaySinh, Mail, VaiTro, SDT, PhongBan, DiaChi)
values (N'Kế toán num4', 'tranvane', 0,'1991-09-20', 'ketoan4@gmail.com', 'Accountant', '0327451679', 'Accountant', 'quan7')

---Thêm dữ liệu Trưởng phòng Sale---
insert into NGUOIDUNG(HoTen, TenDangNhap, GioiTinh, NgaySinh, Mail, VaiTro, SDT, PhongBan, DiaChi)
values	(N'Trưởng Sale num0', 'trannguyenvana', 0,'1970-06-23','salemanager0@gmail.com','Sale Manager','0912332212','Sale','quan 7')

---Thêm dữ liệu Trưởng phòng Kế toán---
insert into NGUOIDUNG(HoTen, TenDangNhap, GioiTinh, NgaySinh, Mail, VaiTro, SDT, PhongBan, DiaChi)
values	(N'Kế toán trưởng num0', 'trannguyenvanb', 1,'1980-05-21','ketoantruong0@gmail.com','Accountant Manager','0921092212','Accountant','quan 7')

---Thêm dữ liệu Giám đốc---
insert into NGUOIDUNG(HoTen, TenDangNhap, GioiTinh, NgaySinh, Mail, VaiTro, SDT, PhongBan, DiaChi)
values	(N'Giám đốc num0','trannguyenvanc', 0,'1972-11-20','giamdoc0@gmail.com','CEO','0936681910','CEO','quan 7')


insert into NGUOIDUNG(HoTen, TenDangNhap, GioiTinh, NgaySinh, Mail, VaiTro, SDT, PhongBan, DiaChi)
values	(N'Bảo','dinhgiabao', 0,'1972-11-20','dgb2k4@gmail.com','CEO','0936681910','CEO','quan 7')


select * from NGUOIDUNG where MaNV = '00000' and MatKhau = '12345'

select * from NGUOIDUNG 


CREATE TABLE HOPDONG
(
  MaHD NVARCHAR(5) DEFAULT dbo.taoMaHD(),
  MaNV NVARCHAR(5) NOT NULL, --ma nhan vien tao hop dong
  TenHopDong NVARCHAR(50) NOT NULL,
  TenNguoiDaiDien NVARCHAR(50) NOT NULL,
  NgayBatDau DATE NOT NULL DEFAULT GETDATE(),
  NgayKetThuc DATE NOT NULL, -- ngay ket thuc phai sau ngay bat dau
  GiaTriHD INT NOT NULL,
  MucHoaHong INT NOT NULL DEFAULT 5, --Mặc định ban đầu 5% (Không cho phép người tạo hđ thay đổi- chỉ trưởng Sale được thay đổi)
  ChiaGiaiDoan VARCHAR(20) NOT NULL DEFAULT '100%', --Chia theo thời gian ('100%', '30%-30%-40%','30%-70%','40%-30%-30%','40%-60%','50%-50%')
  DaThanhToan INT NOT NULL DEFAULT 0, --Trừ số tiền ghi nhận thanh toán
  NoiDungHD NVARCHAR(100) NOT NULL,
  TinhTrangHD NVARCHAR(20) NOT NULL DEFAULT N'Chưa thực hiện', --Chưa thực hiện, đang thực hiện, chờ nghiệm thu, đã xong
  TenNguoiLienHe NVARCHAR(50) NOT NULL, --của người liên hệ
  DiaChi NVARCHAR(50) NOT NULL, --của người liên hệ
  SDT NVARCHAR(10) NOT NULL, --của người liên hệ
  Mail NVARCHAR(50) NOT NULL, --của người liên hệ
  TienDoHD INT NOT NULL, --Số tiến độ hợp đồng CẮT CHUỖI NỘI DUNG HỢP ĐỒNG
  NhanVienThanhToan NVARCHAR(5) NULL,	--Mã nhân viên kế toán phụ trách giai đoạn ban đầu là rỗng
  PRIMARY KEY (MaHD),
  FOREIGN KEY (MaNV) REFERENCES NGUOIDUNG(MaNV)
)

---Thêm dữ liệu Hợp Đồng---
insert into HOPDONG(MaNV, TenHopDong, TenNguoiDaiDien, NgayBatDau, NgayKetThuc, GiaTriHD, MucHoaHong, ChiaGiaiDoan, DaThanhToan, NoiDungHD, TinhTrangHD, TenNguoiLienHe, DiaChi, SDT, Mail, TienDoHD)
values ('00001', N'Quay 50 video',N'Công ty Milo', '2023-11-21', '2024-10-24', 1768, 5, '100%', 0, N'Quay video về abc',N'Chưa thực hiện', N'Đại sứ Milo', N'1 NHT Quận 7', '0936681910', 'abc@gmail.com', 4)
insert into HOPDONG(MaNV, TenHopDong, TenNguoiDaiDien, NgayBatDau, NgayKetThuc, GiaTriHD, MucHoaHong, ChiaGiaiDoan, DaThanhToan, NoiDungHD, TinhTrangHD, TenNguoiLienHe, DiaChi, SDT, Mail, TienDoHD)
values ('00003', N'Chụp 5 hình', N'Valhein', '2024-1-2', '2024-5-6', 1231, 5, 2, 0, N'Chụp hình về abc', N'Đang thực hiện', N'Valhein', N'1 NHT Quận 7', '0936681911', 'def@gmail.com', 3)
insert into HOPDONG(MaNV, TenHopDong, TenNguoiDaiDien, NgayBatDau, NgayKetThuc, GiaTriHD, MucHoaHong, ChiaGiaiDoan, DaThanhToan, NoiDungHD, TinhTrangHD, TenNguoiLienHe, DiaChi, SDT, Mail, TienDoHD)
values ('00002', N'Quay 10 video', N'Công ty Omo', '2024-2-22', '2025-1-3', 7564, 5, 2, 564, N'Quay video về abc', N'Đang thực hiện', N'Đại sứ Omo', N'1 NHT Quận 7', '0936681912', 'jkl@gmail.com', 3)
insert into HOPDONG(MaNV, TenHopDong, TenNguoiDaiDien, NgayBatDau, NgayKetThuc, GiaTriHD, MucHoaHong, ChiaGiaiDoan, DaThanhToan, NoiDungHD, TinhTrangHD, TenNguoiLienHe, DiaChi, SDT, Mail, TienDoHD)
values ('00005', N'Chụp 10 hình', N'Công ty Asus', '2022-8-6', '2023-7-12', 8764, 5, 2, 8000, N'Chụp hình về abc', N'Chờ nghiệm thu', N'Đại sứ Asus', N'1 NHT Quận 7', '0936681913', 'abcd@gmail.com', 4)
insert into HOPDONG(MaNV, TenHopDong, TenNguoiDaiDien, NgayBatDau, NgayKetThuc, GiaTriHD, MucHoaHong, ChiaGiaiDoan, DaThanhToan, NoiDungHD, TinhTrangHD, TenNguoiLienHe, DiaChi, SDT, Mail, TienDoHD)
values ('00004', N'Quay 5 video', N'Công ty Grab', '2024-4-3', '2024-8-12', 8143, 5, 2, 8143, N'Quay video về abc', N'Đã xong', N'Đại sứ Grab', N'1 NHT Quận 7', '0936681914', 'abcf@gmail.com', 2)
insert into HOPDONG(MaNV, TenHopDong, TenNguoiDaiDien, NgayBatDau, NgayKetThuc, GiaTriHD, MucHoaHong, ChiaGiaiDoan, DaThanhToan, NoiDungHD, TinhTrangHD, TenNguoiLienHe, DiaChi, SDT, Mail, TienDoHD)
values ('00002', N'Chụp 15 hình', N'Công ty Foody', '2024-4-3', '2024-4-5', 6523, 5, 2, 0, N'Chụp hình về abc', N'Chưa thực hiện', N'Đại sứ Foody', N'1 NHT Quận 7', '0936681915', 'abce@gmail.com', 1)
insert into HOPDONG(MaNV, TenHopDong, TenNguoiDaiDien,NgayKetThuc, GiaTriHD, NoiDungHD, TenNguoiLienHe, DiaChi, SDT, Mail, TienDoHD)
values ('00002', N'Chụp 15 hình', N'Công ty Foody','2024-12-29', 6523, N'Chụp hình về abc', N'Đại sứ Foody', N'1 NHT Quận 7', '0936681915', 'abce@gmail.com', 1)

select * from HOPDONG


CREATE TABLE GIAIDOANTHANHTOAN
(
  MaGiaiDoanThanhToan NVARCHAR(10) DEFAULT dbo.taoMaGiaiDoanThanhToan(),
  MaHD NVARCHAR(5) NOT NULL,
  TenHopDong NVARCHAR(50) NOT NULL,
  NgayThanhToan DATE NOT NULL, --Ngày hạn thanh toán (có lúc tạo CHIA GIAI ĐOẠN)
  PhanTramThanhToan INT NOT NULL,
  GiaTriThanhToan INT NOT NULL,
  TrangThaiThanhToan BIT NOT NULL DEFAULT 0, -- 1 Đã thanh toán, 0 Chờ thanh toán
  NgayNhanThanhToan DATE,
  GhiChu NVARCHAR(100),
  NhanVienQuanLy NVARCHAR(5), --Người quản lý thanh toán (kế toán)
  PRIMARY KEY (MaGiaiDoanThanhToan, MaHD),
  FOREIGN KEY (MaHD) REFERENCES HOPDONG(MaHD),
  FOREIGN KEY (NhanVienQuanLy) REFERENCES NGUOIDUNG(MaNV)
)


insert into GIAIDOANTHANHTOAN(MaHD, TenHopDong, NgayThanhToan, PhanTramThanhToan, GiaTriThanhToan,NgayNhanThanhToan,GhiChu)
values('HD001',N'Quay 50 video', '2024-11-24', 60, 1000, '2024-11-26', N'Thanh toán giai đoạn 1 HD001')
insert into GIAIDOANTHANHTOAN(MaHD, TenHopDong, NgayThanhToan, PhanTramThanhToan, GiaTriThanhToan,NgayNhanThanhToan,GhiChu)
values('HD001',N'Quay 50 video', '2024-11-26', 40, 768, '2024-11-28', N'Thanh toán giai đoạn 2 HD001')
insert into GIAIDOANTHANHTOAN(MaHD, TenHopDong, NgayThanhToan, PhanTramThanhToan, GiaTriThanhToan,NgayNhanThanhToan,GhiChu)
values('HD002',N'Chụp 5 hình', '2024-11-24', 50, 500, '2024-11-26', N'Thanh toán giai đoạn 1 HD002')
select * from GIAIDOANTHANHTOAN 


CREATE TABLE TIENDOHOPDONG
(
  MaTienDoHopDong NVARCHAR(5) DEFAULT dbo.taoMaTienDoHopDong(),
  NgayBatDau DATE NOT NULL,
  NgayKetThuc DATE NOT NULL, --NGÀY KẾT THÚC HỢP ĐỒNG
  MaHD NVARCHAR(5) NOT NULL,
  MaNV NVARCHAR(5) NOT NULL, --Người tạo HĐ
  NVThucHienCV NVARCHAR(50), --TÊN Người thực hiện CV trong HĐ
  NoiDungCV NVARCHAR(50) NOT NULL,
  KhoiLuongCV INT NOT NULL DEFAULT 0, --Số lượng công việc đã hoàn thành
  TongKhoiLuongCV INT NOT NULL DEFAULT 0, --Tổng số lượng công việc phải hoàn thành (sẽ sửa chung với lúc thêm tên người thực hiện công việc)
  PRIMARY KEY (MaTienDoHopDong),
  FOREIGN KEY (MaHD) REFERENCES HOPDONG(MaHD),
)

---Thêm dữ liệu giai đoạn hợp đồng
insert into TIENDOHOPDONG(NgayBatDau, NgayKetThuc, MaHD, MaNV, NVThucHienCV, NoiDungCV)
values('2024-01-02', '2024-04-02', 'HD001', '00002', '00005', N'Quay 2 video')
insert into TIENDOHOPDONG(NgayBatDau, NgayKetThuc, MaHD, MaNV, NVThucHienCV, NoiDungCV)
values('2024-01-02', '2024-04-02', 'HD001', '00002', '00006', N'Quay 18 video')
insert into TIENDOHOPDONG(NgayBatDau, NgayKetThuc, MaHD, MaNV, NVThucHienCV, NoiDungCV)
values('2024-03-12', '2024-05-15', 'HD002', '00004', '00007', N'Chụp 3 hình')

select * from TIENDOHOPDONG






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

-- Tạo mã giai đoạn thanh toán --
CREATE FUNCTION taoMaGiaiDoanThanhToan()
RETURNS NVARCHAR(5)
AS
BEGIN
    DECLARE @newMaTienDoTT NVARCHAR(5)
    DECLARE @maxNumericPart INT

    -- Lấy phần số lớn nhất hiện tại trong MaTienDoTT
    SELECT @maxNumericPart = MAX(CAST(MaGiaiDoanThanhToan AS INT))
    FROM GIAIDOANTHANHTOAN

    -- Nếu chưa có mã tiến độ nào, bắt đầu từ 00001
    IF @maxNumericPart IS NULL
        SET @maxNumericPart = 0

    -- Tăng phần số lên 1 và tạo mã mới
    SET @newMaTienDoTT = RIGHT('00000' + CAST(@maxNumericPart + 1 AS NVARCHAR), 5)

    RETURN @newMaTienDoTT
END
GO

-- Tạo mã tiến độ hợp đồng --
CREATE FUNCTION taoMaTienDoHopDong()
RETURNS NVARCHAR(5)
AS
BEGIN
    DECLARE @newMaTienDo NVARCHAR(5);
    select @newMaTienDo = max(MaTienDoHopDong) from TIENDOHOPDONG
    IF @newMaTienDo IS NULL
        SET @newMaTienDo = '00000'; 
	IF (CAST(@newMaTienDo AS INT) > -1)
		SET @newMaTienDo = RIGHT('00000' +CAST((CAST(@newMaTienDo AS INT) + 1) AS NVARCHAR),5);
	RETURN @newMaTienDo
END
go



-- Procedure
--Procedure ContractTrackingForSale--
create proc loadContractTrackingForSale
@MaNV NVARCHAR(5)
as
begin
	select hd.MaHD, hd.TenHopDong, hd.TenNguoiDaiDien, hd.TenNguoiLienHe, hd.NgayBatDau, hd.NgayKetThuc, hd.GiaTriHD, hd.TinhTrangHD, nv.HoTen from HOPDONG as hd, NGUOIDUNG as nv where nv.MaNV = @MaNV 
end
go	
	
exec loadContractTrackingForSale @MaNV = '00004'

--Procedure Danh sách tất cả hợp đồng dành cho những role khác trừ Sale --
create proc loadContractTrackingForAll
as
begin
	select hd.MaHD, hd.TenHopDong, hd.TenNguoiDaiDien, hd.TenNguoiLienHe, hd.NgayBatDau, hd.NgayKetThuc, hd.GiaTriHD, hd.TinhTrangHD, nv.HoTen 
	from HOPDONG as hd
	INNER JOIN NGUOIDUNG as nv on hd.MaNV = nv.MaNV;
end
go	

drop proc loadContractTrackingForAll
exec loadContractTrackingForAll




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


