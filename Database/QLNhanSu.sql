--database QLNS
create database QLNhanSu
use QLNhanSu


--table USERS
create table Users(
	Id int primary key identity(1,1),
	TaiKhoan nchar(50) not null,
	MatKhau nchar(10) not null,
	Idper int
)


--table CHUCVU
create table ChucVu(
	MaCV nchar(10) primary key,
	TenCV nvarchar(50) not null,
	PCCV float
)
--cập nhật pccv
alter table ChucVu
alter column PCCV numeric(18,0)



--table NHANVIEN
create table NhanVien(
	MaNV nchar(10) primary key,
	MaCV nchar(10) not null,
	MaPB nchar(10) not null,
	TenNV nvarchar(50) not null,
	NgaySinh date not null,
	DiaChi nvarchar(200),
	GioiTinh nvarchar(5),
	SDT char(14),
	UrlAnh image,
	NgayVaoLam date,
	HeSoLuong float not null
	
)
alter table NhanVien
add --rang buoc
	constraint fk_nv_cv foreign key(MaCV) references ChucVu(MaCV),
	constraint fk_nv_pb foreign key(MaPB) references PhongBan(MaPB)



--table PhongBan
create table PhongBan(
	MaPB nchar(10) primary key,
	TenPB nvarchar(100) not null,
	SDT nchar(14)
)

--table Luong
create table Luong(
	MaNV nchar(10) primary key,
	MaPB nchar(10),
	Luong numeric(18,0) not null,
	GhiChu nvarchar(200),
	TongLuong numeric(18,0) not null
	constraint fk_luong_pb foreign key(MaPB) references PhongBan(MaPB),
	constraint fk_luong_nv foreign key(MaNV) references NhanVien(MaNV)
)
alter table Luong
alter column Luong numeric(18,0) not null
--
alter table Luong
add constraint df_luong_ghichu default 'NVCT' for GhiChu

--thay doi kieu du lieu
alter table Luong
alter column TongLuong nchar(100)
--table ChamCong
create table ChamCongNV(
	MaNV nchar(10) primary key,
	SoNgayCong int not null,
	SoNgayNghi int not null,
	GhiChu nvarchar(200)

	--rang buoc 
	constraint fk_chamcong_nv foreign key(MaNV) references NhanVien(MaNV)

)
--them cot tong ngay cong
alter table ChamCongNV
add TongNgayCong int 
--đặt mặt định số ngày công là 26 ngày
alter table ChamCongNV
add constraint df_chamcongnhanvien_songaycong default 26 for SoNgayCong


--câu lệnh tìm kiếm bảng nhân viên
select *from NhanVien where TenNV like N'%test%'

/*--câu lệnh trigger update ngaycong
create trigger trg_update_ngaycong on ChamCongNV
for insert
as
	declare @songaycong int
	declare @songaynghi int
	declare @tongngaycong int
	declare @manv nchar(10)

	select @manv = MaNV, @songaycong = SoNgayCong
	from inserted

	select @songaynghi = SoNgayNghi
	from ChamCongNV where MaNV = @manv

	if @songaynghi =''
		print '...'
	else
		update ChamCongNV
		set @tongngaycong = @songaycong - @songaynghi
		where MaNV = @manv

*/
/*
--cau lenh trigger lay du lieu mapb tu bang nhan vien
create trigger trg_update_luong on luong
for insert
as
	declare @mapb nchar(10)
	declare @manv nchar(10)

	select @manv = MaNV
	from inserted

	select @mapb = MaPB
	from NhanVien where MaNV = @manv

	if @manv =''
		print '...'
	else
		update Luong
		set MaPB = @mapb
		where MaNV = @manv
	*/
--kiemtra tai khoan va password
create proc [dbo].[SP_AuthoLogin]
@Username nvarchar(20),
@Password nvarchar(20)
as
begin
    if exists (select * from Users where TaiKhoan = @Username and MatKhau = @Password and Idper = 1)
        select 1 as code
    else if exists (select * from Users where TaiKhoan = @Username and MatKhau = @Password and IDPer =0)
        select 0 as code
    else if exists(select * from Users where TaiKhoan = @Username and MatKhau != @Password) 
        select 2 as code
    else select 3 as code
end

--luong cap nhat
create trigger trg_update_luong_nv on luong
for insert
as
	declare @manv_nv nchar(10)
	declare @manv_luong nchar(10)

	select @manv_nv = MaNV
	from inserted

	select @manv_luong = MaNV
	from NhanVien where MaNV = @manv_nv

	if @manv_luong =''
		update Luong
		set MaPB = @manv_luong
		where MaNV = @manv_nv
	else
		print('...')



