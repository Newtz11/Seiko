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
  HinhAnh image,
  PRIMARY KEY (MaNV)
)
go


---Thêm dữ liệu Super Admin---
insert into NGUOIDUNG(HoTen, TenDangNhap, GioiTinh, NgaySinh, Mail, VaiTro, SDT, PhongBan, DiaChi)
values	(N'Admin','nguyenvana',0,'1967-02-01','admin@gmail.com',N'Admin','0912332222',N'IT','quan 7')

---Thêm dữ liệu nhân viên Sale---
insert into NGUOIDUNG(HoTen, TenDangNhap, GioiTinh, NgaySinh, Mail, VaiTro, SDT, PhongBan, DiaChi)
values	(N'Sale num0', 'nguyenthia', 0,'1970-10-22','sale0@gmail.com',N'Giám đốc','0912332212',N'Kế toán','quan 7')

insert into NGUOIDUNG(HoTen, TenDangNhap, GioiTinh, NgaySinh, Mail, VaiTro, SDT, PhongBan, DiaChi)
values	(N'Sale num1', 'nguyenvanu', 0,'1971-04-22','sale1@gmail.com',N'Trưởng phòng Sale','0912332213',N'Kế toán','quan 7')

select * from NGUOIDUNG
---Thêm dữ liệu Giám đốc---
insert into NGUOIDUNG(HoTen, TenDangNhap, GioiTinh, NgaySinh, Mail, VaiTro, SDT, PhongBan, DiaChi)
values	(N'Giám đốc num0','trannguyenvanf', 0,'1972-11-20','giamdoc0@gmail.com',N'Giám đốc','0936681910',N'Giám đốc','quan 7')


insert into NGUOIDUNG(HoTen, TenDangNhap, GioiTinh, NgaySinh, Mail, VaiTro, SDT, PhongBan, DiaChi)
values	(N'Bảo','dinhgiabao', 0,'1972-11-20','dgb2k4@gmail.com','CEO','0936681910','CEO','quan 7')


select * from NGUOIDUNG 

select * from GIAIDOANTHANHTOAN

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
  DaThanhToan INT NOT NULL DEFAULT 0, --Trừ số tiền ghi nhận thanh toán
  NoiDungHD NVARCHAR(100) NOT NULL,
  TinhTrangHD NVARCHAR(20) NOT NULL DEFAULT N'Chưa thực hiện', --Chưa thực hiện, đang thực hiện, chờ nghiệm thu, đã xong
  TenNguoiLienHe NVARCHAR(50) NOT NULL, --của người liên hệ
  DiaChi NVARCHAR(50) NOT NULL, --của người liên hệ
  SDT NVARCHAR(10) NOT NULL, --của người liên hệ
  Mail NVARCHAR(50) NOT NULL, --của người liên hệ
  PRIMARY KEY (MaHD),
  FOREIGN KEY (MaNV) REFERENCES NGUOIDUNG(MaNV)
)
ALTER TABLE HOPDONG
ALTER COLUMN NoiDungHD NVARCHAR(100);

---Thêm dữ liệu Hợp Đồng---
insert into HOPDONG(MaNV, TenHopDong, TenNguoiDaiDien, NgayBatDau, NgayKetThuc, GiaTriHD, MucHoaHong, DaThanhToan, NoiDungHD, TinhTrangHD, TenNguoiLienHe, DiaChi, SDT, Mail, TienDoHD)
values ('00001', N'Quay 50 video',N'Công ty Milo', '2023-11-21', '2024-10-24', 1768, 5, 0, N'Quay video về abc',N'Chưa thực hiện', N'Đại sứ Milo', N'1 NHT Quận 7', '0936681910', 'abc@gmail.com', 4)
insert into HOPDONG(MaNV, TenHopDong, TenNguoiDaiDien, NgayBatDau, NgayKetThuc, GiaTriHD, MucHoaHong, DaThanhToan, NoiDungHD, TinhTrangHD, TenNguoiLienHe, DiaChi, SDT, Mail, TienDoHD)
values ('00003', N'Chụp 5 hình', N'Valhein', '2024-1-2', '2024-5-6', 1231, 5, 0, N'Chụp hình về abc', N'Đang thực hiện', N'Valhein', N'1 NHT Quận 7', '0936681911', 'def@gmail.com', 3)


insert into HOPDONG(MaNV, TenHopDong, TenNguoiDaiDien,NgayKetThuc, GiaTriHD, NoiDungHD, TenNguoiLienHe, DiaChi, SDT, Mail, TienDoHD)
values ('00002', N'Chụp 15 hình', N'Công ty Foody','2024-11-30', 6523, N'Chụp hình về abc', N'Đại sứ Foody', N'1 NHT Quận 7', '0936681911', 'abce@gmail.com', 1)
insert into HOPDONG(MaNV, TenHopDong, TenNguoiDaiDien,NgayKetThuc, GiaTriHD, NoiDungHD,TinhTrangHD, TenNguoiLienHe, DiaChi, SDT, Mail, TienDoHD)
values ('00004', N'Chụp 15 hình', N'Công ty Foody','2024-12-24', 6523, N'Chụp hình về abc', N'Đã xong',N'Đại sứ Foody', N'1 NHT Quận 7', '0936681914', 'abce@gmail.com', 1)


select * from HOPDONG

CREATE TABLE GIAIDOANTHANHTOAN
(
  MaGiaiDoanThanhToan NVARCHAR(5) DEFAULT dbo.taoMaGiaiDoanThanhToan(),
  MaHD NVARCHAR(5) NOT NULL,
  GiaiDoan INT NOT NULL,
  NgayThanhToan DATE NOT NULL DEFAULT GETDATE(), --Ngày hạn thanh toán DỰ KIẾN
  PhanTramThanhToan INT NOT NULL DEFAULT 100,
  GiaTriThanhToan INT NOT NULL DEFAULT 0,
  TrangThaiThanhToan BIT NOT NULL DEFAULT 0, -- 1 Đã thanh toán, 0 Chờ thanh toán
  NgayNhanThanhToan DATE NOT NULL,	-- Ngày thanh toán thực tế
  GhiChu NVARCHAR(100) NOT NULL ,
  PRIMARY KEY (MaGiaiDoanThanhToan, MaHD),
  FOREIGN KEY (MaHD) REFERENCES HOPDONG(MaHD)
)

insert into GIAIDOANTHANHTOAN(MaHD, GiaiDoan, NgayThanhToan, PhanTramThanhToan, GiaTriThanhToan,NgayNhanThanhToan,GhiChu)
values('HD001', 1, '2024-11-24', 60, 1000, '2024-11-26', N'Thanh toán giai đoạn 1 HD001')
insert into GIAIDOANTHANHTOAN(MaHD, GiaiDoan, NgayThanhToan, PhanTramThanhToan, GiaTriThanhToan,NgayNhanThanhToan,GhiChu)
values('HD001', 2, '2024-11-26', 40, 768, '2024-11-28', N'Thanh toán giai đoạn 2 HD001')
insert into GIAIDOANTHANHTOAN(MaHD, GiaiDoan, NgayThanhToan, PhanTramThanhToan, GiaTriThanhToan,NgayNhanThanhToan,GhiChu)
values('HD002', 1, '2024-11-24', 50, 500, '2024-11-26', N'Thanh toán giai đoạn 1 HD002')

insert into GIAIDOANTHANHTOAN(MaHD, GiaiDoan, NgayThanhToan, PhanTramThanhToan, GiaTriThanhToan,NgayNhanThanhToan,GhiChu)
values('HD002', 2, '2024/11/24', 50, 500, '2024/11/26', N'Thanh toán giai đoạn 1 HD002')

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
values('2024-01-02', '2024-04-02', 'HD001', '00002', N'Sơn', N'Quay 2 video')
insert into TIENDOHOPDONG(NgayBatDau, NgayKetThuc, MaHD, MaNV, NVThucHienCV, NoiDungCV)
values('2024-01-02', '2024-04-02', 'HD001', '00002', N'Thủy', N'Quay 18 video')
insert into TIENDOHOPDONG(NgayBatDau, NgayKetThuc, MaHD, MaNV, NVThucHienCV, NoiDungCV)
values('2024-03-12', '2024-05-15', 'HD002', '00004', N'Hỏa', N'Chụp 3 hình')
insert into TIENDOHOPDONG(NgayBatDau, NgayKetThuc, MaHD, MaNV, NoiDungCV)
values('2024-03-12', '2024-05-15', 'HD001', 'Thổ', N'Chụp 3 hình')
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
		--Procedure load thông tin thông toán On ContractDetail--
create proc loadThongTinThanhToan
	@MaHD NVARCHAR(5)
as
begin
	select GiaiDoan as [Giai đoạn],
			NgayThanhToan as [Ngày thanh toán],
			NgayNhanThanhToan as [Ngày xác nhận thanh toán],
			PhanTramThanhToan as [Phần trăm thanh toán(%)],
			GiaTriThanhToan as [Giá trị thanh toán],
			TrangThaiThanhToan as [Trạng thái],
			GhiChu as [Ghi chú]
	from GIAIDOANTHANHTOAN
	where MaHD = @MaHD
end
go
--drop proc loadThongTinThanhToan
--exec loadThongTinThanhToan

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

		--Proc loadPaymentProgress giai đoạn thanh toán On PaymentProgress
create proc loadPaymentProgress
as
begin
	select gd.MaHD as [Mã hợp đồng],
			hd.TenHopDong as [Tên hợp đồng],
			gd.GiaiDoan as [Giai đoạn],
			gd.NgayThanhToan as [Ngày thanh toán],
			gd.PhanTramThanhToan as [Phần trăm thanh toán],
			gd.GiaTriThanhToan as [Giá trị thanh toán],
			gd.TrangThaiThanhToan as [Trạng thái],
			gd.NgayNhanThanhToan as [Ngày nhận thanh toán],
			gd.GhiChu as [Ghi chú],
			gd.MaGiaiDoanThanhToan as [Mã GD]
	from GIAIDOANTHANHTOAN as gd
	INNER JOIN HOPDONG as hd ON gd.MaHD = hd.MaHD
end
go

--drop proc loadPaymentProgress
exec loadPaymentProgress
--select * from GIAIDOANTHANHTOAN



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
        hd.TinhTrangHD AS [Tình trạng],
		td.MaTienDoHopDong AS [MaTD]
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
        hd.TinhTrangHD AS [Tình trạng],
		td.MaTienDoHopDong as [MaTD]
    FROM HOPDONG AS hd
	INNER JOIN TIENDOHOPDONG AS td ON hd.MaHD = td.MaHD
end
go
--drop proc loadProjectProgressForAll
select * from TIENDOHOPDONG
exec loadProjectProgressForAll


		--Procedure load Form ContractHistory For Sale
create proc loadContractOnContractHistoryForSale
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
		nv.HoTen as [Account/Sale],
        hd.TinhTrangHD AS [Tình trạng hợp đồng]
    FROM 
        HOPDONG AS hd
    INNER JOIN 
        NGUOIDUNG AS nv ON hd.MaNV = nv.MaNV
    WHERE 
        nv.MaNV = @MaNV and hd.TinhTrangHD = N'Đã xong'
END
GO
--exec loadContractOnContractHistoryForSale @MaNV = '00004'

		--Procedure load Form ContractHistory For All
create proc loadConTractOnContractHistoryForAll
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
		nv.HoTen as [Account/Sale],
        hd.TinhTrangHD AS [Tình trạng hợp đồng]
    FROM 
        HOPDONG AS hd
    INNER JOIN 
        NGUOIDUNG AS nv ON hd.MaNV = nv.MaNV
    WHERE hd.TinhTrangHD = N'Đã xong'
END
GO
--exec loadConTractOnContractHistoryForAll


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
	   OR PhongBan LIKE '%' + @Keyword + '%'
	   OR VaiTro LIKE '%' + @Keyword + '%'
END
GO

--drop proc searchGlobalOnListUser
exec searchGlobalOnListUser @Keyword = 'Super Admin'

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


--procedure dùng cho Form PaymentProgress
	--Procedure search giai đoạn thanh toán On PaymentProgress
create proc searchGlobalOnPaymentProgress
	@Keyword NVARCHAR(50)
AS
BEGIN
    select gd.MaHD as [Mã hợp đồng],
			hd.TenHopDong as [Tên hợp đồng],
			gd.GiaiDoan as [Giai đoạn],
			gd.NgayThanhToan as [Ngày thanh toán],
			gd.PhanTramThanhToan as [Phần trăm thanh toán],
			gd.GiaTriThanhToan as [Giá trị thanh toán],
			gd.TrangThaiThanhToan as [Trạng thái],
			gd.NgayNhanThanhToan as [Ngày nhận thanh toán],
			gd.GhiChu as [Ghi chú]
	from GIAIDOANTHANHTOAN as gd
	INNER JOIN HOPDONG as hd ON gd.MaHD = hd.MaHD
    WHERE gd.MaHD LIKE '%' + @Keyword + '%'
	   OR hd.TenHopDong LIKE '%' + @Keyword + '%'
	   OR (CAST(gd.GiaiDoan AS NVARCHAR(2)) LIKE '%' + @Keyword + '%')
	   OR (CAST(gd.PhanTramThanhToan AS NVARCHAR(4)) LIKE '%' + @Keyword + '%')
	   OR (CAST(gd.GiaTriThanhToan AS NVARCHAR(11)) LIKE '%' + @Keyword + '%')
	   OR gd.GhiChu LIKE '%' + @Keyword + '%'
END
GO

--drop proc searchGlobalOnPaymentProgress
--exec searchGlobalOnPaymentProgress @Keyword = N'HD001'

--select * from GIAIDOANTHANHTOAN


	--Procedure search trạng thái thanh toán On PaymentProgress
create proc searchTrangThaiOnPaymentProgress
	@TrangThai BIT = NULL
AS
BEGIN
    select gd.MaHD as [Mã hợp đồng],
			hd.TenHopDong as [Tên hợp đồng],
			gd.GiaiDoan as [Giai đoạn],
			gd.NgayThanhToan as [Ngày thanh toán],
			gd.PhanTramThanhToan as [Phần trăm thanh toán],
			gd.GiaTriThanhToan as [Giá trị thanh toán],
			gd.TrangThaiThanhToan as [Trạng thái],
			gd.NgayNhanThanhToan as [Ngày nhận thanh toán],
			gd.GhiChu as [Ghi chú]
	from GIAIDOANTHANHTOAN as gd
	INNER JOIN HOPDONG as hd ON gd.MaHD = hd.MaHD
    WHERE (@TrangThai IS NULL OR gd.TrangThaiThanhToan = @TrangThai)
END
GO

--drop proc searchTrangThaiOnPaymentProgress
--exec searchTrangThaiOnPaymentProgress @TrangThai = 0



		-- Procedure search thời gian On PaymentProgress
create proc searchTimeOnPaymentProgress
	@NgayThanhToan DATE = NULL,
	@NgayNhanThanhToan DATE = NULL
AS
BEGIN
    select gd.MaHD as [Mã hợp đồng],
			hd.TenHopDong as [Tên hợp đồng],
			gd.GiaiDoan as [Giai đoạn],
			gd.NgayThanhToan as [Ngày thanh toán],
			gd.PhanTramThanhToan as [Phần trăm thanh toán],
			gd.GiaTriThanhToan as [Giá trị thanh toán],
			gd.TrangThaiThanhToan as [Trạng thái],
			gd.NgayNhanThanhToan as [Ngày nhận thanh toán],
			gd.GhiChu as [Ghi chú]
	from GIAIDOANTHANHTOAN as gd
	INNER JOIN HOPDONG as hd ON gd.MaHD = hd.MaHD
    WHERE (@NgayThanhToan IS NULL OR gd.NgayThanhToan >= @NgayThanhToan) AND (@NgayNhanThanhToan IS NULL OR gd.NgayNhanThanhToan <= @NgayNhanThanhToan)
END
GO

--drop proc searchTimeOnPaymentProgress
--exec searchTimeOnPaymentProgress @NgayThanhToan = '2024-11-25', @NgayNhanThanhToan = '2024-11-28'



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
	  OR (CAST(hd.GiaTriHD AS NVARCHAR(11)) LIKE '%' + @Keyword + '%')
	  OR (nv.HoTen LIKE '%' + @Keyword + '%')
	  OR (hd.TinhTrangHD LIKE '%' + @Keyword + '%')
END
GO

--drop proc searchGlobalOnContractTrackingForSale
--exec searchGlobalOnContractTrackingForSale @Keyword = N''

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
--exec searchContractByTimeOnContractTrackingForSale @Keyword = N''


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
select * from NGUOIDUNG

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
        td.MaHD AS [Mã hợp đồng], 
        hd.TenHopDong AS [Tên hợp đồng], 
        td.NoiDungCV AS [Nội dung công việc], 
        td.TongKhoiLuongCV AS [Khối lượng yêu cầu], 
        td.NgayBatDau AS [Ngày bắt đầu], 
        td.NgayKetThuc AS [Ngày kết thúc], 
        td.KhoiLuongCV AS [Tiến độ], 
        td.NVThucHienCV AS [Người thực hiện], 
        hd.TinhTrangHD AS [Tình trạng],
		td.MaTienDoHopDong as [MaTD]
    FROM TIENDOHOPDONG AS td
	INNER JOIN HOPDONG AS hd ON td.MaHD = hd.MaHD
    WHERE (td.MaHD LIKE '%' + @Keyword + '%')
	  OR (hd.TenHopDong LIKE '%' + @Keyword + '%')
      OR (td.NoiDungCV LIKE '%' + @Keyword + '%')
      OR (CAST(td.TongKhoiLuongCV AS NVARCHAR(3)) LIKE '%' + @Keyword + '%')
      OR (CAST(td.KhoiLuongCV AS NVARCHAR(3)) LIKE '%' + @Keyword + '%')
	  OR (td.NVThucHienCV LIKE '%' + @Keyword + '%')
      OR (hd.TinhTrangHD LIKE '%' + @Keyword + '%')
END
GO
select * from TIENDOHOPDONG

--drop proc searchGlobalOnProjectProgress
--exec searchGlobalOnProjectProgress @Keyword = N'Thủy'


		-- Procedure search Time on ProjectProgress
CREATE PROC searchTimeOnProjectProgress
    @NgayBatDau DATE = NULL,
	@NgayKetThuc DATE = NULL
AS
BEGIN
    SELECT 
        td.MaHD AS [Mã hợp đồng], 
        hd.TenHopDong AS [Tên hợp đồng], 
        td.NoiDungCV AS [Nội dung công việc], 
        td.TongKhoiLuongCV AS [Khối lượng yêu cầu], 
        td.NgayBatDau AS [Ngày bắt đầu], 
        td.NgayKetThuc AS [Ngày kết thúc], 
        td.KhoiLuongCV AS [Tiến độ], 
        td.NVThucHienCV AS [Người thực hiện], 
        hd.TinhTrangHD AS [Tình trạng],
		td.MaTienDoHopDong AS [MaTD]
    FROM TIENDOHOPDONG AS td
	INNER JOIN HOPDONG AS hd ON td.MaHD = hd.MaHD
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
        td.MaHD AS [Mã hợp đồng], 
        hd.TenHopDong AS [Tên hợp đồng], 
        td.NoiDungCV AS [Nội dung công việc], 
        td.TongKhoiLuongCV AS [Khối lượng yêu cầu], 
        td.NgayBatDau AS [Ngày bắt đầu], 
        td.NgayKetThuc AS [Ngày kết thúc], 
        td.KhoiLuongCV AS [Tiến độ], 
        td.NVThucHienCV AS [Người thực hiện], 
        hd.TinhTrangHD AS [Tình trạng],
		td.MaTienDoHopDong AS [MaTD]
    FROM TIENDOHOPDONG AS td
	INNER JOIN HOPDONG AS hd ON td.MaHD = hd.MaHD
    WHERE (@TinhTrangHD IS NULL OR hd.TinhTrangHD = @TinhTrangHD)
END
GO


--drop proc searchTinhTrangHopDongOnProjectProgress
--exec searchTinhTrangHopDongOnProjectProgress @TinhTrangHD = N'Chưa thực hiện'
--exec searchTinhTrangHopDongOnProjectProgress

		--Procedure lấy giai đoạn lớn nhất
create proc getNewStage
	@MaHD NVARCHAR(5)
AS
BEGIN
    -- Lấy giai đoạn lớn nhất (mới nhất) của hợp đồng theo MaHD
    SELECT TOP 1 GiaiDoan
    FROM GIAIDOANTHANHTOAN
    WHERE MaHD = @MaHD
    ORDER BY GiaiDoan DESC;  -- Sắp xếp theo GiaiDoan giảm dần, giai đoạn mới nhất sẽ được lấy đầu tiên
END
GO

exec getNewStage @MaHD = N'HD001'



-- UPDATE DATA

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



--procedure sửa giai đoạn thanh toán changeProjectProgress

create proc updatePaymentProgress
	@MaHD NVARCHAR(5),
	@GiaiDoan INT,
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
	where MaHD = @MaHD and GiaiDoan = @GiaiDoan
end
go
exec updatePaymentProgress @MaGiaiDoanThanhToan = '00001', @NgayThanhToan = '2024-11-29', @PhanTramThanhToan = 20, @GiaTriThanhToan = 10, @TrangThaiThanhToan = 0, @NgayNhanThanhToan = '2024-12-10', @GhiChu = N'adiae'
--drop proc updatePaymentProgress
select * from GIAIDOANTHANHTOAN


-- INSERT DATA
create proc createAccount
	@TenDangNhap NVARCHAR(50),
	@MatKhau VARCHAR(20),
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
	insert into NGUOIDUNG (TenDangNhap, MatKhau, HoTen, NgaySinh, GioiTinh, DiaChi, PhongBan, VaiTro, Mail, SDT)
	values (@TenDangNhap, @MatKhau, @HoTen, @NgaySinh, @GioiTinh, @DiaChi, @PhongBan,@VaiTro, @Mail, @SDT )
end
go

--EXEC createAccount @TenDangNhap = 'admin', @MatKhau = '12345', @HoTen = N'Admin', @NgaySinh = '2004-11-30', @GioiTinh = 1, @DiaChi = N'12 kbdnd', @PhongBan = N'IT', @VaiTro = N'Super Admin', @Mail = N'abc@gmail.com', @SDT = '09087456'
--EXEC createAccount @TenDangNhap = 'bao', @MatKhau = '12345', @HoTen = N'ketoan2', @NgaySinh = '2004-11-30', @GioiTinh = 1, @DiaChi = N'12 kbdnd', @PhongBan = N'Kế toán', @VaiTro = N'Kế toán', @Mail = N'abcde@gmail.com', @SDT = '09087456'

-- update account
create proc updateAccount
	@MaNV NVARCHAR(5),
	@HinhAnh image
as
begin
	update NGUOIDUNG
	set HinhAnh = @HinhAnh
	where MaNV = @MaNV
end
go





--drop proc insertProgress
--exec insertProgress @NgayBatDau = '2024-11-25', @NgayKetThuc = '2024-12-29', @MaNV = '00002', @NVThucHienCV = N'Sơn', @NoiDungCV = N'quay 5 video'




	--Procedure tao ProjectProgress
create proc createProjectProgress
	@MaHD NVARCHAR(5)
	
as
begin
	declare @NgayBatDau AS DATE 
	declare @NgayKetThuc as  DATE
	declare @NoiDungCV as NVARCHAR(50)
	declare @MaNV as NVARCHAR(5)

	select @NgayBatDau = NgayBatDau, @NgayKetThuc = NgayKetThuc, @NoiDungCV = TenHopDong, @MaNV = MaNV
	from HOPDONG
	where @MaHD = MaHD

	insert into TIENDOHOPDONG (MaHD, NgayBatDau, NgayKetThuc, NoiDungCV, MaNV)
	values (@MaHD, @NgayBatDau, @NgayKetThuc, @NoiDungCV, @MaNV)
end
go
exec createProjectProgress @MaHD = 'HD001'

select * from TIENDOHOPDONG

	--Procedure sua ProjectProgress
create proc updateProjectProgress
	@MaTienDoHopDong NVARCHAR(5),
	@NoiDungCV NVARCHAR(50),
	@KhoiLuongCV INT,
	@NgayBatDau DATE, 
	@NgayKetThuc DATE, 
	@TienDo INT, 
	@TenNguoiThucHien NVARCHAR(50)
as
begin
	update TIENDOHOPDONG
	set MaTienDoHopDong = @MaTienDoHopDong,
		NoiDungCV = @NoiDungCV,
		TongKhoiLuongCV = @KhoiLuongCV,
		NgayBatDau = @NgayBatDau,
		NgayKetThuc = @NgayKetThuc,
		KhoiLuongCV = @TienDo,
		NVThucHienCV = @TenNguoiThucHien
	where MaTienDoHopDong = @MaTienDoHopDong
end
go



	--Procedure tạo giai đoạn thanh toán PaymentProgress
create proc createPaymentProgress
	@MaHD NVARCHAR(5),
	@GiaiDoan INT,
	@NgayThanhToan DATE,
	@PhanTramThanhToan INT,
	@GiaTriThanhToan INT,
	@NgayNhanThanhToan DATE,
	@GhiChu NVARCHAR(100)
as
begin
	insert into GIAIDOANTHANHTOAN (MaHD, GiaiDoan, NgayThanhToan, PhanTramThanhToan, GiaTriThanhToan, NgayNhanThanhToan, GhiChu)
	values (@MaHD, @GiaiDoan, @NgayThanhToan, @PhanTramThanhToan, @GiaTriThanhToan, @NgayNhanThanhToan, @GhiChu)
end
go
select * from HOPDONG

exec createPaymentProgress @MaHD = 'HD003', @GiaiDoan = 1, @NgayThanhToan = '2024-11-29', @PhanTramThanhToan = 20, @GiaTriThanhToan = 3000, @NgayNhanThanhToan = '2024-11-29', @GhiChu = N'Thanh toán giai đoạn 1'
select * from GIAIDOANTHANHTOAN


CREATE PROCEDURE GetNewestMaHD
AS
BEGIN
    SELECT TOP 1 MaHD
    FROM HOPDONG
    ORDER BY MaHD DESC;
END
GO



CREATE PROCEDURE getNewestTienDoHopDong
    @MaHD NVARCHAR(5)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT TOP 1 MaTienDoHopDong
    FROM TIENDOHOPDONG
    WHERE MaHD = @MaHD
    ORDER BY MaTienDoHopDong DESC; -- Assuming newer values are higher
END
GO


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


