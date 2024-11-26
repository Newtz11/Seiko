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
  VaiTro NVARCHAR(50) NOT NULL, 
  SDT NVARCHAR(10) NOT NULL, 
  PhongBan NVARCHAR(20) NOT NULL,
  NgayVaoLam DATE NOT NULL DEFAULT GETDATE(),
  DiaChi NVARCHAR(50) NOT NULL,
  TinhTrangHoatDong BIT NOT NULL DEFAULT 1, --1 Đang hoạt động, 0 Ngưng hoạt động
  PRIMARY KEY (MaNV)
)
go

select * from NGUOIDUNG


---Thêm dữ liệu Super Admin---
insert into NGUOIDUNG(HoTen, TenDangNhap, GioiTinh, NgaySinh, Mail, VaiTro, SDT, PhongBan, DiaChi)
values	(N'Admin','nguyenvana',0,'1967-02-01','admin@gmail.com',N'Admin','0912332222',N'IT','quan 7')

---Thêm dữ liệu nhân viên Sale---
insert into NGUOIDUNG(HoTen, TenDangNhap, GioiTinh, NgaySinh, Mail, VaiTro, SDT, PhongBan, DiaChi)
values	(N'Sale num0', 'nguyenvang', 0,'1970-10-22','sale0@gmail.com',N'Nhân viên Sale','0912332212',N'Sale','quan 7')

insert into NGUOIDUNG(HoTen, TenDangNhap, GioiTinh, NgaySinh, Mail, VaiTro, SDT, PhongBan, DiaChi)
values	(N'Sale num1', 'nguyenvank', 0,'1971-04-22','sale1@gmail.com',N'Nhân viên Sale','0912332213',N'Sale','quan 7')

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


select * from NGUOIDUNG where Mail = 'abc@gmail.com'

select * from NGUOIDUNG 

CREATE TABLE TAIKHOANDAXOA
(
	MaTaiKhoanDaXoa NVARCHAR(5) PRIMARY KEY,
	MaNV NVARCHAR(5),
	TenDangNhap VARCHAR(50) NOT NULL UNIQUE, -- tên đăng nhập duy nhất
	HoTen NVARCHAR(50) NOT NULL,
	GioiTinh BIT NOT NULL,  --0 nam, 1 nữ
	NgaySinh DATE NOT NULL,	
	MatKhau VARCHAR(20) NOT NULL DEFAULT '12345',
	Mail NVARCHAR(50) NOT NULL,
	VaiTro NVARCHAR(50) NOT NULL, 
	SDT NVARCHAR(10) NOT NULL, 
	PhongBan NVARCHAR(20) NOT NULL,
	NgayVaoLam DATE NOT NULL DEFAULT GETDATE(),
	DiaChi NVARCHAR(50) NOT NULL,
	TinhTrangHoatDong BIT NOT NULL DEFAULT 0, --1 Đang hoạt động, 0 Ngưng hoạt động
)
go


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
  NhanVienThanhToan VARCHAR(50) NULL,	--Tên đăng nhập của kế toán phụ trách giai đoạn ban đầu là rỗng
  PRIMARY KEY (MaHD),
  FOREIGN KEY (MaNV) REFERENCES NGUOIDUNG(MaNV),
  FOREIGN KEY (NhanVienThanhToan) REFERENCES NGUOIDUNG(TenDangNhap)
)

---Thêm dữ liệu Hợp Đồng---
insert into HOPDONG(MaNV, TenHopDong, TenNguoiDaiDien, NgayBatDau, NgayKetThuc, GiaTriHD, MucHoaHong, ChiaGiaiDoan, DaThanhToan, NoiDungHD, TinhTrangHD, TenNguoiLienHe, DiaChi, SDT, Mail, TienDoHD)
values ('00001', N'Quay 50 video',N'Công ty Milo', '2023-11-21', '2024-10-24', 1768, 5, '100%', 0, N'Quay video về abc',N'Chưa thực hiện', N'Đại sứ Milo', N'1 NHT Quận 7', '0936681910', 'abc@gmail.com', 4)
insert into HOPDONG(MaNV, TenHopDong, TenNguoiDaiDien, NgayBatDau, NgayKetThuc, GiaTriHD, MucHoaHong, ChiaGiaiDoan, DaThanhToan, NoiDungHD, TinhTrangHD, TenNguoiLienHe, DiaChi, SDT, Mail, TienDoHD)
values ('00003', N'Chụp 5 hình', N'Valhein', '2024-1-2', '2024-5-6', 1231, 5, 2, 0, N'Chụp hình về abc', N'Đang thực hiện', N'Valhein', N'1 NHT Quận 7', '0936681911', 'def@gmail.com', 3)
insert into HOPDONG(MaNV, TenHopDong, TenNguoiDaiDien, NgayBatDau, NgayKetThuc, GiaTriHD, MucHoaHong, ChiaGiaiDoan, DaThanhToan, NoiDungHD, TinhTrangHD, TenNguoiLienHe, DiaChi, SDT, Mail, TienDoHD)
values ('00002', N'Ghi Hình capcut', N'Công ty Omo', '2024-2-22', '2025-1-3', 7564, 5, 2, 564, N'Quay video về bột giặt', N'Chưa thực hiện', N'Đại sứ Omo', N'1 NHT Quận 7', '0936681912', 'jkl@gmail.com', 3)
insert into HOPDONG(MaNV, TenHopDong, TenNguoiDaiDien, NgayBatDau, NgayKetThuc, GiaTriHD, MucHoaHong, ChiaGiaiDoan, DaThanhToan, NoiDungHD, TinhTrangHD, TenNguoiLienHe, DiaChi, SDT, Mail, TienDoHD)
values ('00005', N'Chụp 10 hình', N'Công ty Asus', '2022-8-6', '2023-7-12', 8764, 5, 2, 8000, N'Chụp hình về abc', N'Chờ nghiệm thu', N'Đại sứ Asus', N'1 NHT Quận 7', '0936681913', 'abcd@gmail.com', 4)
insert into HOPDONG(MaNV, TenHopDong, TenNguoiDaiDien, NgayBatDau, NgayKetThuc, GiaTriHD, MucHoaHong, ChiaGiaiDoan, DaThanhToan, NoiDungHD, TinhTrangHD, TenNguoiLienHe, DiaChi, SDT, Mail, TienDoHD)
values ('00004', N'Quay 5 video', N'Công ty Grab', '2024-4-3', '2024-8-12', 8143, 5, 2, 8143, N'Quay video về abc', N'Đã xong', N'Đại sứ Grab', N'1 NHT Quận 7', '0936681914', 'abcf@gmail.com', 2)
insert into HOPDONG(MaNV, TenHopDong, TenNguoiDaiDien, NgayBatDau, NgayKetThuc, GiaTriHD, MucHoaHong, ChiaGiaiDoan, DaThanhToan, NoiDungHD, TinhTrangHD, TenNguoiLienHe, DiaChi, SDT, Mail, TienDoHD)
values ('00002', N'Chụp 15 hình', N'Công ty Foody', '2024-11-24', '2024-11-28', 6523, 5, 2, 0, N'Chụp hình về abc', N'Chưa thực hiện', N'Đại sứ Foody', N'1 NHT Quận 7', '0936681915', 'abce@gmail.com', 1)
insert into HOPDONG(MaNV, TenHopDong, TenNguoiDaiDien,NgayKetThuc, GiaTriHD, NoiDungHD, TenNguoiLienHe, DiaChi, SDT, Mail, TienDoHD)
values ('00002', N'Chụp 15 hình', N'Công ty Foody','2024-11-24', 6523, N'Chụp hình về abc', N'Đại sứ Foody', N'1 NHT Quận 7', '0936681915', 'abce@gmail.com', 1)
insert into HOPDONG(MaNV, TenHopDong, TenNguoiDaiDien,NgayKetThuc, GiaTriHD, NoiDungHD, TenNguoiLienHe, DiaChi, SDT, Mail, TienDoHD)
values ('00017', N'Chụp 15 hình', N'Công ty Foody','2024-11-30', 6523, N'Chụp hình về abc', N'Đại sứ Foody', N'1 NHT Quận 7', '0936681911', 'abce@gmail.com', 1)
insert into HOPDONG(MaNV, TenHopDong, TenNguoiDaiDien,NgayKetThuc, GiaTriHD, NoiDungHD, TenNguoiLienHe, DiaChi, SDT, Mail, TienDoHD)
values ('00018', N'Chụp 15 hình', N'Công ty Foody','2024-12-24', 6523, N'Chụp hình về abc', N'Đại sứ Foody', N'1 NHT Quận 7', '0936681914', 'abce@gmail.com', 1)


select * from HOPDONG

CREATE TABLE GIAIDOANTHANHTOAN
(
  MaGiaiDoanThanhToan NVARCHAR(5) DEFAULT dbo.taoMaGiaiDoanThanhToan(),
  MaHD NVARCHAR(5) NOT NULL,
  NgayThanhToan DATE NOT NULL DEFAULT GETDATE(), --Ngày hạn thanh toán (có lúc tạo CHIA GIAI ĐOẠN)
  PhanTramThanhToan INT NOT NULL DEFAULT 100,
  GiaTriThanhToan INT NOT NULL DEFAULT 0,
  TrangThaiThanhToan BIT NOT NULL DEFAULT 0, -- 1 Đã thanh toán, 0 Chờ thanh toán
  NgayNhanThanhToan DATE,
  GhiChu NVARCHAR(100),
  NhanVienQuanLy VARCHAR(50), --Người quản lý thanh toán (kế toán) TÊN ĐĂNG NHẬP
  PRIMARY KEY (MaGiaiDoanThanhToan, MaHD),
  FOREIGN KEY (MaHD) REFERENCES HOPDONG(MaHD),
  FOREIGN KEY (NhanVienQuanLy) REFERENCES NGUOIDUNG(TenDangNhap)
)


insert into GIAIDOANTHANHTOAN(MaHD, NgayThanhToan, PhanTramThanhToan, GiaTriThanhToan,NgayNhanThanhToan,GhiChu)
values('HD001', '2024-11-24', 60, 1000, '2024-11-26', N'Thanh toán giai đoạn 1 HD001')
insert into GIAIDOANTHANHTOAN(MaHD, NgayThanhToan, PhanTramThanhToan, GiaTriThanhToan,NgayNhanThanhToan,GhiChu)
values('HD001', '2024-11-26', 40, 768, '2024-11-28', N'Thanh toán giai đoạn 2 HD001')
insert into GIAIDOANTHANHTOAN(MaHD, NgayThanhToan, PhanTramThanhToan, GiaTriThanhToan,NgayNhanThanhToan,GhiChu)
values('HD002', '2024-11-24', 50, 500, '2024-11-26', N'Thanh toán giai đoạn 1 HD002')

insert into GIAIDOANTHANHTOAN(MaHD, NgayThanhToan, PhanTramThanhToan, GiaTriThanhToan,NgayNhanThanhToan,GhiChu)
values('HD002', '2024/11/24', 50, 500, '2024/11/26', N'Thanh toán giai đoạn 1 HD002')

--select * from GIAIDOANTHANHTOAN 



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
values('2024-01-02', '2024-04-02', 'HD001', '00002', N'00005', N'Quay 2 video')
insert into TIENDOHOPDONG(NgayBatDau, NgayKetThuc, MaHD, MaNV, NVThucHienCV, NoiDungCV)
values('2024-01-02', '2024-04-02', 'HD001', '00002', N'00006', N'Quay 18 video')
insert into TIENDOHOPDONG(NgayBatDau, NgayKetThuc, MaHD, MaNV, NVThucHienCV, NoiDungCV)
values('2024-03-12', '2024-05-15', 'HD002', '00004', N'00007', N'Chụp 3 hình')
insert into TIENDOHOPDONG(NgayBatDau, NgayKetThuc, MaHD, MaNV, NoiDungCV)
values('2024-03-12', '2024-05-15', 'HD001', '00002', N'Chụp 3 hình')

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

-- LOAD DATA
		--Procedure ContractTrackingForSale--
CREATE PROC loadContractTrackingForSale
    @MaNV NVARCHAR(5)
AS
BEGIN
    SELECT 
        hd.MaHD AS [Mã hợp đồng],
        hd.TenHopDong AS [Tên hợp đồng],
        hd.TenNguoiDaiDien AS [Tên Công ty/Cá nhân],
        hd.TenNguoiLienHe AS [Người liên hệ],
        hd.NgayBatDau AS [Ngày bắt đầu],
        hd.NgayKetThuc AS [Ngày hết hạn],
        hd.GiaTriHD AS [Giá trị hợp đồng],
        hd.TinhTrangHD AS [Tình trạng hợp đồng],
        nv.HoTen AS [Phụ trách quản lý]
    FROM 
        HOPDONG AS hd
    INNER JOIN 
        NGUOIDUNG AS nv ON hd.MaNV = nv.MaNV
    WHERE 
        nv.MaNV = @MaNV
END
GO
--drop proc loadContractTrackingForSale
--exec loadContractTrackingForSale @MaNV = '00003'

		--Procedure Danh sách tất cả hợp đồng dành cho những role khác trừ Sale --
create proc loadContractTrackingForAll
as
begin
	select hd.MaHD as [Mã hợp đồng], hd.TenHopDong as [Tên hợp đồng], hd.TenNguoiDaiDien as [Tên Công ty/Cá nhân], hd.TenNguoiLienHe as [Người liên hệ] , hd.NgayBatDau as [Ngày bắt đầu], hd.NgayKetThuc as [Ngày hết hạn], hd.GiaTriHD as [Giá trị hợp đồng], hd.TinhTrangHD as [Tình trạng hợp đồng], nv.HoTen as [Phụ trách quản lý] 
	from HOPDONG as hd
	INNER JOIN NGUOIDUNG as nv on hd.MaNV = nv.MaNV;
end
go	

--exec loadContractTrackingForAll

		--Procedure ProjectProgressForSale --
create proc loadProjectProgressForSale
	@MaNV NVARCHAR(5)
as
begin
	SELECT 
        hd.MaHD AS [Mã hợp đồng], 
        hd.TenHopDong AS [Tên hợp đồng], 
        td.NoiDungCV AS [Nội dung công việc], 
        td.TongKhoiLuongCV AS [Khối lượng yêu cầu], 
        td.NgayBatDau AS [Ngày bắt đầu], 
        td.NgayKetThuc AS [Ngày kết thúc], 
        td.KhoiLuongCV AS [Tiến độ], 
        td.NVThucHienCV AS [Người thực hiện], 
        hd.TinhTrangHD AS [Tình trạng]
    FROM HOPDONG AS hd
	INNER JOIN TIENDOHOPDONG AS td ON hd.MaHD = td.MaHD
    WHERE td.MaNV = @MaNV
end
go

--drop proc loadProjectProgressForSale
--exec loadProjectProgressForSale @MaNV = '00002'


		--Procedure ProjectProgressForAll trừ Sale, Kế toán, Trưởng phòng Kế toán --
create proc loadProjectProgressForAll
as
begin
	SELECT 
        hd.MaHD AS [Mã hợp đồng], 
        hd.TenHopDong AS [Tên hợp đồng], 
        td.NoiDungCV AS [Nội dung công việc], 
        td.TongKhoiLuongCV AS [Khối lượng yêu cầu], 
        td.NgayBatDau AS [Ngày bắt đầu], 
        td.NgayKetThuc AS [Ngày kết thúc], 
        td.KhoiLuongCV AS [Tiến độ], 
        td.NVThucHienCV AS [Người thực hiện], 
        hd.TinhTrangHD AS [Tình trạng]
    FROM HOPDONG AS hd
	INNER JOIN TIENDOHOPDONG AS td ON hd.MaHD = td.MaHD
end
go

--exec loadProjectProgressForAll


		--load ContractTracking For Accountant
create proc loadConTractTrackingForAccountant
	@MaNV NVARCHAR(5)
as
begin
	SELECT 
        hd.MaHD AS [Mã hợp đồng],
        hd.TenHopDong AS [Tên hợp đồng],
        hd.TenNguoiDaiDien AS [Tên Công ty/Cá nhân],
        hd.TenNguoiLienHe AS [Người liên hệ],
        hd.NgayBatDau AS [Ngày bắt đầu],
        hd.NgayKetThuc AS [Ngày hết hạn],
        hd.GiaTriHD AS [Giá trị hợp đồng],
        hd.TinhTrangHD AS [Tình trạng hợp đồng],
        hd.NhanVienThanhToan AS [Phụ trách thanh toán]
    FROM HOPDONG AS hd
	INNER JOIN NGUOIDUNG AS nv ON hd.NhanVienThanhToan = nv.TenDangNhap
	INNER JOIN GIAIDOANTHANHTOAN AS gd ON hd.NhanVienThanhToan = gd.NhanVienQuanLy
	WHERE nv.VaiTro = N'Kế toán'
end
go

--drop proc loadConTractTrackingForAccountant
--exec loadConTractTrackingForAccountant @MaNV = '00004'


		--Procedure PaymentProgress for Accountant--
create proc loadPaymentProgressForAccountant
	@MaNV NVARCHAR(5)
as
begin
	SELECT 
        hd.MaHD AS [Mã hợp đồng], 
        hd.TenHopDong AS [Tên hợp đồng],
		gd.NgayThanhToan AS [Ngày thanh toán],
        gd.PhanTramThanhToan AS [Phần trăm thanh toán(%)], 
        gd.GiaTriThanhToan AS [Giá trị thanh toán], 
        gd.TrangThaiThanhToan AS [Trạng thái],
		gd.NgayNhanThanhToan AS [Ngày nhận thanh toán],
		gd.GhiChu AS [Ghi chú]
    FROM GIAIDOANTHANHTOAN AS gd
	INNER JOIN HOPDONG AS hd ON gd.MaHD = hd.MaHD
	INNER JOIN NGUOIDUNG AS nv ON gd.NhanVienQuanLy = nv.TenDangNhap
end
go

--drop proc loadPaymentProgressForAccountant
--exec loadPaymentProgressForAccountant @MaNV = '00002'



-- procedure dung cho Form ListUser
		-- Procedure search On ListUser --
CREATE PROC searchGlobalOnListUser
    @Keyword NVARCHAR(50)
AS
BEGIN
    SELECT TenDangNhap AS [Tên đăng nhập], 
           Mail AS [Email], 
           HoTen AS [Tên người dùng], 
           MaNV AS [Mã người dùng], 
           PhongBan AS [Phòng ban], 
           VaiTro AS [Chức vụ], 
           TinhTrangHoatDong AS [Tình trạng] 
    FROM NGUOIDUNG
    WHERE MaNV LIKE '%' + @Keyword + '%'
       OR HoTen LIKE '%' + @Keyword + '%'
       OR Mail LIKE '%' + @Keyword + '%'
       OR TenDangNhap LIKE '%' + @Keyword + '%'
END
GO


--drop proc searchGlobalOnListUser
--exec searchGlobalOnListUser @Keyword = 'b'

		--Procedure search Chức Vụ On ListUser
create proc searchChucVuOnListUser
	@VaiTro NVARCHAR(50) = NULL
as
begin
	select TenDangNhap as [Tên đăng nhập], Mail as [Email], HoTen as [Tên người dùng], MaNV as [Mã người dùng], PhongBan as [Phòng ban], VaiTro as [Chức vụ], TinhTrangHoatDong as [Tình trạng] 
	from NGUOIDUNG 
	where @VaiTro IS NULL OR VaiTro = @VaiTro
end
go

--drop proc searchChucVuOnListUser
--exec searchChucVuOnListUser
--exec searchChucVuOnListUser @VaiTro = N'Super Admin'

		--Procedure search tình trạng hoạt động
create proc searchTinhTrangHoatDongOnListUser
	@TinhTrangHoatDong BIT = NULL
as
begin
	select TenDangNhap as [Tên đăng nhập], Mail as [Email], HoTen as [Tên người dùng], MaNV as [Mã người dùng], PhongBan as [Phòng ban], VaiTro as [Chức vụ], TinhTrangHoatDong as [Tình trạng] 
	from NGUOIDUNG 
	where @TinhTrangHoatDong IS NULL OR TinhTrangHoatDong = @TinhTrangHoatDong
end
go

--drop proc searchTinhTrangHoatDongOnListUser
--exec searchTinhTrangHoatDongOnListUser @TinhTrangHoatDong = 1

		-- Procedure search Phòng Ban On ListUser
create proc searchPhongBanOnListUser
@PhongBan NVARCHAR(20) = NULL
as
begin
	select TenDangNhap as [Tên đăng nhập], Mail as [Email], HoTen as [Tên người dùng], MaNV as [Mã người dùng], PhongBan as [Phòng ban], VaiTro as [Chức vụ], TinhTrangHoatDong as [Tình trạng] 
	from NGUOIDUNG 
	where @PhongBan IS NULL OR PhongBan = @PhongBan
end
go

--drop searchPhongBanOnListUser
--exec searchPhongBanOnListUser @PhongBan = 'IT'


-- procedure dung cho Form ContractTrackingForSale
		--Procedure search hợp đồng On ContractTrackingForSale--
CREATE PROC searchGlobalOnContractTrackingForSale
    @Keyword NVARCHAR(50)
AS
BEGIN
    SELECT 
        hd.MaHD AS [Mã hợp đồng], 
        hd.TenHopDong AS [Tên hợp đồng], 
        hd.TenNguoiDaiDien AS [Tên Công ty/Cá nhân], 
        hd.TenNguoiLienHe AS [Người liên hệ], 
        hd.NgayBatDau AS [Ngày bắt đầu], 
        hd.NgayKetThuc AS [Ngày hết hạn], 
        hd.GiaTriHD AS [Giá trị hợp đồng], 
        hd.TinhTrangHD AS [Tình trạng hợp đồng], 
        nv.HoTen AS [Phụ trách quản lý]
    FROM HOPDONG AS hd
    INNER JOIN NGUOIDUNG AS nv ON hd.MaNV = nv.MaNV
    WHERE (hd.MaHD LIKE '%' + @Keyword + '%')
	  OR (hd.TenHopDong LIKE '%' + @Keyword + '%')
      OR (hd.TenNguoiDaiDien LIKE '%' + @Keyword + '%')
      OR (hd.TenNguoiLienHe LIKE '%' + @Keyword + '%')
      OR (nv.HoTen LIKE '%' + @Keyword + '%');
END
GO
select * from NGUOIDUNG
--drop proc searchGlobalOnContractTrackingForSale
--exec searchGlobalOnContractTrackingForSale @Keyword = 'd'

		--Procedure lọc ngày bắt đầu và kết thúc On ContractTrackingForSale --
CREATE PROC searchContractByTimeOnContractTrackingForSale
    @NgayBatDau DATE = NULL,
	@NgayKetThuc DATE = NULL
AS
BEGIN
    SELECT 
        hd.MaHD AS [Mã hợp đồng], 
        hd.TenHopDong AS [Tên hợp đồng], 
        hd.TenNguoiDaiDien AS [Tên Công ty/Cá nhân], 
        hd.TenNguoiLienHe AS [Người liên hệ], 
        hd.NgayBatDau AS [Ngày bắt đầu], 
        hd.NgayKetThuc AS [Ngày hết hạn], 
        hd.GiaTriHD AS [Giá trị hợp đồng], 
        hd.TinhTrangHD AS [Tình trạng hợp đồng], 
        nv.HoTen AS [Phụ trách quản lý]
    FROM HOPDONG AS hd
    INNER JOIN NGUOIDUNG AS nv ON hd.MaNV = nv.MaNV
    WHERE (@NgayBatDau IS NULL OR hd.NgayBatDau >= @NgayBatDau) AND (@NgayKetThuc IS NULL OR hd.NgayKetThuc <= @NgayKetThuc)
END
GO


--drop proc searchContractByTimeOnContractTrackingForSale
--exec searchContractByTimeOnContractTrackingForSale @NgayBatDau = '2024-11-23'
--exec searchContractByTimeOnContractTrackingForSale @NgayBatDau = '2024-11-23', @NgayKetThuc = '2024-11-30'
--exec searchContractByTimeOnContractTrackingForSale


		--Procedure search tình trạng hợp đồng On ContractTrackingForSale --
CREATE PROC searchTinhTrangHopDongOnContractTrackingForSale
    @TinhTrangHD NVARCHAR(20) = NULL
AS
BEGIN
    SELECT 
        hd.MaHD AS [Mã hợp đồng], 
        hd.TenHopDong AS [Tên hợp đồng], 
        hd.TenNguoiDaiDien AS [Tên Công ty/Cá nhân], 
        hd.TenNguoiLienHe AS [Người liên hệ], 
        hd.NgayBatDau AS [Ngày bắt đầu], 
        hd.NgayKetThuc AS [Ngày hết hạn], 
        hd.GiaTriHD AS [Giá trị hợp đồng], 
        hd.TinhTrangHD AS [Tình trạng hợp đồng], 
        nv.HoTen AS [Phụ trách quản lý]
    FROM HOPDONG AS hd
    INNER JOIN NGUOIDUNG AS nv ON hd.MaNV = nv.MaNV
    WHERE (@TinhTrangHD IS NULL OR hd.TinhTrangHD = @TinhTrangHD)
END
GO


--drop proc searchTinhTrangHopDongOnContractTrackingForSale
--exec searchTinhTrangHopDongOnContractTrackingForSale @TinhTrangHD = N'Đã xong'
--exec searchTinhTrangHopDongOnContractTrackingForSale


-- procedure dung cho Form ProjectProgress
		-- Procedure search Contract on ProjectProgress
CREATE PROC searchGlobalOnProjectProgress
    @Keyword NVARCHAR(50)
AS
BEGIN
    SELECT 
        hd.MaHD AS [Mã hợp đồng], 
        hd.TenHopDong AS [Tên hợp đồng], 
        td.NoiDungCV AS [Nội dung công việc], 
        td.TongKhoiLuongCV AS [Khối lượng yêu cầu], 
        td.NgayBatDau AS [Ngày bắt đầu], 
        td.NgayKetThuc AS [Ngày kết thúc], 
        td.KhoiLuongCV AS [Tiến độ], 
        td.NVThucHienCV AS [Người thực hiện], 
        hd.TinhTrangHD AS [Tình trạng]
    FROM HOPDONG AS hd
	INNER JOIN TIENDOHOPDONG AS td ON hd.MaHD = td.MaHD
    WHERE (hd.MaHD LIKE '%' + @Keyword + '%')
	  OR (hd.TenHopDong LIKE '%' + @Keyword + '%')
      OR (td.NoiDungCV LIKE '%' + @Keyword + '%')
      OR (td.TongKhoiLuongCV LIKE '%' + @Keyword + '%')
      OR (td.KhoiLuongCV LIKE '%' + @Keyword + '%')
	  OR (td.NVThucHienCV LIKE '%' + @Keyword + '%')
      OR (hd.TinhTrangHD LIKE '%' + @Keyword + '%')
END
GO


--drop proc searchGlobalOnProjectProgress
--exec searchGlobalOnProjectProgress @Keyword = 'tiktok'


		-- Procedure search Time on ProjectProgress
CREATE PROC searchTimeOnProjectProgress
    @NgayBatDau DATE = NULL,
	@NgayKetThuc DATE = NULL
AS
BEGIN
    SELECT 
        hd.MaHD AS [Mã hợp đồng], 
        hd.TenHopDong AS [Tên hợp đồng], 
        td.NoiDungCV AS [Nội dung công việc], 
        td.TongKhoiLuongCV AS [Khối lượng yêu cầu], 
        td.NgayBatDau AS [Ngày bắt đầu], 
        td.NgayKetThuc AS [Ngày kết thúc], 
        td.KhoiLuongCV AS [Tiến độ], 
        td.NVThucHienCV AS [Người thực hiện], 
        hd.TinhTrangHD AS [Tình trạng]
    FROM HOPDONG AS hd
	INNER JOIN TIENDOHOPDONG AS td ON hd.MaHD = td.MaHD
    WHERE (@NgayBatDau IS NULL OR td.NgayBatDau >= @NgayBatDau) AND (@NgayKetThuc IS NULL OR td.NgayKetThuc <= @NgayKetThuc)
END
GO


--drop proc searchTimeOnProjectProgress
--exec searchTimeOnProjectProgress @NgayBatDau = '2024-10-13', @NgayKetThuc = '2024-11-30'
--exec searchTimeOnProjectProgress


		-- Procedure search Tình trạng hợp đồng on ProjectProgress
CREATE PROC searchTinhTrangHopDongOnProjectProgress
	@TinhTrangHD NVARCHAR(20) = NULL
AS
BEGIN
    SELECT 
        hd.MaHD AS [Mã hợp đồng], 
        hd.TenHopDong AS [Tên hợp đồng], 
        td.NoiDungCV AS [Nội dung công việc], 
        td.TongKhoiLuongCV AS [Khối lượng yêu cầu], 
        td.NgayBatDau AS [Ngày bắt đầu], 
        td.NgayKetThuc AS [Ngày kết thúc], 
        td.KhoiLuongCV AS [Tiến độ], 
        td.NVThucHienCV AS [Người thực hiện], 
        hd.TinhTrangHD AS [Tình trạng]
    FROM HOPDONG AS hd
	INNER JOIN TIENDOHOPDONG AS td ON hd.MaHD = td.MaHD
    WHERE (@TinhTrangHD IS NULL OR hd.TinhTrangHD = @TinhTrangHD)
END
GO


--drop proc searchTinhTrangHopDongOnProjectProgress
--exec searchTinhTrangHopDongOnProjectProgress @TinhTrangHD = N'Chưa thực hiện'
--exec searchTinhTrangHopDongOnProjectProgress


-- procedure dung cho Form PaymentProgress
		--Procedure search Contract On PaymentProgress
CREATE PROC searchConTractOnPaymentProgress
    @MaHD NVARCHAR(5) = NULL, 
    @TenHopDong NVARCHAR(50) = NULL,
	@PhanTramThanhToan INT = NULL,
	@GiaTriThanhToan INT = NULL,
	@TrangThaiThanhToan BIT = NULL,
	@GhiChu NVARCHAR(100) = NULL
AS
BEGIN
    SELECT 
        hd.MaHD AS [Mã hợp đồng], 
        hd.TenHopDong AS [Tên hợp đồng], 
        gd.NgayThanhToan AS [Ngày thanh toán], 
        gd.PhanTramThanhToan AS [Phần trăm thanh toán], 
        gd.GiaTriThanhToan AS [Giá trị thanh toán],
		gd.TrangThaiThanhToan AS [Trạng thái],

        
    FROM HOPDONG AS hd
	INNER JOIN GIAIDOANTHANHTOAN AS gd ON hd.MaHD = gd.MaHD
    WHERE (@MaHD IS NULL OR hd.MaHD LIKE '%' + @MaHD + '%')
      AND (@TenHopDong IS NULL OR hd.TenHopDong LIKE '%' + @TenHopDong + '%')
      AND (@NoiDungCV IS NULL OR td.NoiDungCV LIKE '%' + @NoiDungCV + '%')
      AND (@TongKhoiLuongCV IS NULL OR td.TongKhoiLuongCV LIKE '%' + @TongKhoiLuongCV + '%')
      AND (@KhoiLuongCV IS NULL OR td.KhoiLuongCV LIKE '%' + @KhoiLuongCV + '%')
	  AND (@NVThucHienCV IS NULL OR td.NVThucHienCV LIKE '%' + @NVThucHienCV + '%')
      AND (@TinhTrangHD IS NULL OR hd.TinhTrangHD LIKE '%' + @TinhTrangHD + '%')
END
GO


drop proc searchConTractOnPaymentProgress
exec searchConTractOnPaymentProgress @MaHD = 'HD002'
exec searchConTractOnPaymentProgress @NVThucHienCV = N'A'
exec searchConTractOnPaymentProgress


select * from NGUOIDUNG

-- UPDATE DATA

		--Procedure update hợp đồng
create proc updateNhanVienThanhToan
	@MaHD NVARCHAR(5),
	@NhanVienThanhToan VARCHAR(50)
AS
BEGIN
	UPDATE HOPDONG
	SET NhanVienThanhToan = @NhanVienThanhToan
	WHERE MaHD = @MaHD
END
GO

--drop proc updateNhanVienThanhToan
exec updateNhanVienThanhToan @MaHD = 'HD002' , @NhanVienThanhToan = 'kiennt'
select * from HOPDONG
		--Procedure updateChiaGiaiDoanHopDong
create proc updateChiaGiaiDoanHopDong
	@MaHD NVARCHAR(5),
	@ChiaGiaiDoan VARCHAR(20)
AS
BEGIN
	UPDATE HOPDONG
	SET ChiaGiaiDoan = @ChiaGiaiDoan
	WHERE MaHD = @MaHD
END
GO

--drop proc updateChiaGiaiDoanHopDong
--exec updateChiaGiaiDoanHopDong @MaHD = 'HD002' , @ChiaGiaiDoan = '100%'



		-- Procedure Đổi mật khẩu --
create proc changePassword
	@MaNV NVARCHAR(5),
	@MatKhauMoi VARCHAR(20)
as
begin
	update NGUOIDUNG
	set MatKhau = @MatKhauMoi
	where MaNV = @MaNV
end
go

exec changePassword @MaNV = '00002' , @MatKhauMoi = 'nguyenvanb'
select * from NGUOIDUNG


		-- Procedure sửa tiến độ hợp đồng
create proc changeProjectProgress
	@MaTienDoHopDong NVARCHAR(5),
	@NVThucHienCV NVARCHAR(50),
	@KhoiLuongCV INT,
	@TongKhoiLuongCV INT
as
begin
	update TIENDOHOPDONG
	set NVThucHienCV = @NVThucHienCV,
		KhoiLuongCV = @KhoiLuongCV,
		TongKhoiLuongCV = @TongKhoiLuongCV
	where MaTienDoHopDong = @MaTienDoHopDong
end
go


--drop proc changeProjectProgress


--procedure sửa giai đoạn thanh toán changeProjectProgress

create proc changePaymentProgress
	@MaGiaiDoanThanhToan NVARCHAR(5),
	@NgayThanhToan DATE,
	@PhanTramThanhToan INT,
	@GiaTriThanhToan INT,
	@TrangThaiThanhToan BIT,
	@NgayNhanThanhToan DATE,
	@GhiChu NVARCHAR(100)
as
begin
	update GIAIDOANTHANHTOAN
	set
		NgayThanhToan = @NgayThanhToan,
		PhanTramThanhToan = @PhanTramThanhToan,
		GiaTriThanhToan = @GiaTriThanhToan,
		TrangThaiThanhToan = @TrangThaiThanhToan,
		NgayNhanThanhToan = @NgayNhanThanhToan,
		GhiChu = @GhiChu
	where MaGiaiDoanThanhToan = @MaGiaiDoanThanhToan
end
go

--drop proc changePaymentProgress



-- INSERT DATA
create proc createAccount
	@TenDangNhap NVARCHAR(50),
	@HoTen NVARCHAR(50),
	@NgaySinh DATE,
	@GioiTinh BIT,
	@DiaChi NVARCHAR(50),
	@PhongBan NVARCHAR(20),
	@VaiTro NVARCHAR(50),
	@Mail NVARCHAR(50),
	@SDT NVARCHAR(10)
as
begin
	insert into NGUOIDUNG (TenDangNhap, HoTen, NgaySinh, GioiTinh, DiaChi, PhongBan, VaiTro, Mail, SDT)
	values (@TenDangNhap, @HoTen, @NgaySinh, @GioiTinh, @DiaChi, @PhongBan,@VaiTro, @Mail, @SDT )
end
go
--drop proc createAccount
exec createAccount @TenDangNhap = 'b', @HoTen = N'đinh gia bảo', @NgaySinh = '2004-3-12', 
					@GioiTinh = 0, @DiaChi = N'nguyễn hữu thọ quận 7', @PhongBan = N'Giám đốc',@VaiTro = N'Giám đốc', @Mail = N'dgb35k4@gmail.com', @SDT = N'0911162180'

--delete  NGUOIDUNG
select * from NGUOIDUNG

		--Procedure insert tiến độ hợp đồng --
create proc insertProgress
	@NgayBatDau DATE,
	@NgayKetThuc DATE,
	@MaNV NVARCHAR(5),
	@NVThucHienCV NVARCHAR(50),
	@NoiDungCV NVARCHAR(50)

as
begin
	DECLARE @MaHD NVARCHAR(5);
    SELECT TOP 1 @MaHD = MaHD
    FROM HOPDONG
    WHERE MaHD LIKE 'HD%'
    ORDER BY MaHD DESC;
	
	insert into TIENDOHOPDONG(NgayBatDau, NgayKetThuc, MaHD,MaNV, NVThucHienCV, NoiDungCV)
	values (@NgayBatDau, @NgayKetThuc, @MaHD,@MaNV, @NVThucHienCV, @NoiDungCV)
end
go

--drop proc insertProgress
--exec insertProgress @NgayBatDau = '2024-11-25', @NgayKetThuc = '2024-12-29', 
					@MaNV = '00002', @NVThucHienCV = N'Sơn', @NoiDungCV = N'quay 5 video'


		--Procedure insert giai đoạn thanh toán
create proc insertGiaiDoanThanhToan
	@MaHD NVARCHAR(5),
	@PhanTramThanhToan INT
as
begin
	
	
	insert into GIAIDOANTHANHTOAN(MaHD, PhanTramThanhToan)
	values (@MaHD, @PhanTramThanhToan)
end
go

--drop proc insertGiaiDoanThanhToan
--exec insertGiaiDoanThanhToan @MaHD = 'HD002', @PhanTramThanhToan = 40



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


