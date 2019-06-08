Create Database QLBT
use QLBT
Drop Database QLBT
Create Table NCC
(
	MaNCC char(8) not null,
	TenNCC char(8) not null,
	DiaChi varchar(20),
	DienThoai int,
	CongNo float,
	Primary Key (MaNCC)
)
Create Table LoaiThuoc
(
	MaLoaiT char(8) not null,
	TenLoaiT varchar(20) not null,
	MaDangT char(8),
	Primary Key (MaLoaiT)
)
Create Table KHACHHANG
(
	MaKH char(8) not null,
	TenKH varchar(20) not null,
	DiaChi varchar(20),
	DienThoai int,
	CongNo float,
	Primary Key (MaKH)
)
Create Table THUOC
(
	MaT char(8) not null,
	TenT varchar(20),
	MaLoaiT Char(8),
	MaNCC char(8),
	Congdung varchar(20),
	SoLuong int,
	HSD date,
	NoiSX varchar(20),
	Primary Key (MaT),
	Constraint fk_THUOC_MaNCC Foreign Key (MaNCC)
	References NCC(MaNCC),
	Constraint fk_THUOC_MaLoaiT Foreign Key (MaLoaiT)
	References NCC(MaNCC)
)
Create Table HOADONNHAP
(
	MaHD char(8) not null,
	MaKH char(8) not null,
	MaT char(8),
	DVT char(8),
	SoLuong int,
	GiaNhap float,
	NgayNhap date,
	NVGiao varchar(30),
	NVNhan varchar(30),
	ThanhTien float,
	DaThanhToan float,
	ConLai float
	Primary Key (MaHD, MaKH, MaT),
	Constraint fk_HOADONNHAP_MaKH Foreign Key (MaKH)
	References KHACHHANG(MaKH),
	Constraint fk_HOADONNHAP_MaT Foreign Key (MaT)
	References THUOC(MaT)
)
Create Table HOADONXUAT
(
	MaHD char(8) not null,
	MaKH char(8) not null,
	MaT char(8),
	DVT char(8),	
	SoLuong int,
	GiaXuat float,
	NgayXuat date,
	NVGiao varchar(30),
	NVNhan varchar(30),
	ThanhTien float,
	DaThanhToan float,
	ConNo float,
	Primary Key (MaHD, MaKH, MaT),
	Constraint fk_HOADONXUAT_MaKH Foreign Key (MaKH)
	References KHACHHANG(MaKH),
	Constraint fk_HOADONXUAT_MaT Foreign Key (MaT)
	References THUOC(MaT)
)
Create Table DangNhap
(
	TenDN char(20) not null,
	Pass char(20) not null
)
