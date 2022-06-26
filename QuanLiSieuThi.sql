create database QuanLySieuThi
go
use QuanLySieuThi

go

create table KhachHang
(
	maKH varchar(10) not null primary key,
	tenKH nvarchar(30) null,
	diaChiKH nvarchar(50) null,
	SDT nvarchar(10) null,
	Email nvarchar(30) null
)

go
create table NhanVien
(
	maNV varchar(10) not null primary key,
	tenNV nvarchar(30) null,
	SDT nvarchar(10) null,
	email nvarchar(30) null,
	chucVu nvarchar(50),
	luong money null
)
go
create table TaiKhoan
(
	idTK int identity(1,1) not null,
	tenTK varchar(50) not null,
	matKhau varchar(50) not null,
	maNV varchar(10) not null foreign key references NhanVien(maNV),
	primary key (idTK,tenTK)
	
)

go
-- Bảng Sản phẩm
create table SanPham
(
	maSP varchar(10) not null primary key,
	tenSP nvarchar(15) null,
	donGiaBan money null,
	soLuongCon int null
)

go
create table HoaDon
(
	maHD int identity(1,1) not null primary key,
	ngayTaoHD Date null,
	maNV varchar(10),
	maKH varchar(10) not null,
	foreign key (maKH) references  KhachHang(maKH)
		on delete 
			cascade
		on update
			cascade,
	foreign key (maNV) references  NhanVien(maNV)
		on delete 
			cascade
		on update
			cascade
)

go
create table ChiTietHoaDon
(
	maHD int not null
	foreign key (maHD) references  HoaDon(maHD)
		on delete 
			cascade
		on update
			cascade,
	maSP varchar(10) not null
	foreign key (maSP) references  SanPham(maSP)
		on delete 
			cascade
		on update
			cascade,
	soLuongDat int null,
	primary key (maHD, maSP)
)

go
create table PhieuNhap
(
	maPN varchar(10) not null primary key,
	ngayNhapHang date null
)
go
-- Bảng Chi tiết phiếu nhâp --
create table ChiTietPhieuNhap
(
	maPN varchar(10) not null
	foreign key (maPN) references  PhieuNhap(maPN)
		on delete 
			cascade
		on update
			cascade,
	maSP varchar(10) not null
	foreign key (maSP) references  SanPham(maSP)
		on delete 
			cascade
		on update
			cascade,
	soLuongNhap int null,
	donGiaNhap money null,
	primary key (maPN, maSP)
)




--
go
alter table ChiTietPhieuNhap
	add constraint CK_ChiTietPhieuNhap_soLuongNhap check (
			soLuongNhap >= 0),
		constraint CK_ChiTietPhieuNhap_donGiaNhap check (
			donGiaNhap >= 0)
alter table ChiTietHoaDon
	add constraint CK_ChiTietDonHang_soLuongDat check (
			soLuongDat >= 0)

alter table SanPham
	add constraint CK_SanPham_donGiaBan check (
			donGiaBan >= 0)



--


go
insert into KhachHang
values  
	('KH0001',N'Trần Kim Vũ',N'Quảng Nam','0905374625','vudeptrai@gmail.com'),
	('KH0002',N'Nguyễn Trần Tiến',N'Quảng Nam','0332052897','tienGay@gmail.com'),
	('KH0003',N'Hà Phước Kỳ',N'Đà Nẵng','0904677123','Kydb@gmail.com'),
	('KH0004',N'Bùi Viết Trường',N'Đà Nẵng','0946436123','truongNgu@gmail.com')

go
insert into NhanVien
values 
	('NV0001',N'Bùi Huyền Trang','0964265321','trangbui@gmail.com',N'Thu ngân','6470000'),
	('NV0002',N'Nguyễn Quang Minh','0126478821','minhnguy@gmail.com',N'Bán hàng','870000'),
	('NV0003',N'Nguyễn Minh Anh','0247586963','anhcute@gmail.com',N'Bán hàng','779000'),
	('NV0004',N'Nguyễn Thị Kiều Diễm','0265865883','kdiem90@gmail.com',N'Thu ngân','163000'),
	('NV0005',N'Nguyễn Thanh Hằng','0913646321','hangnguy@gmail.com',N'Bán hàng','933000'),
	('NV0006',N'Phạm Thảo Anh','0896235321','ptanh@gmail.com',N'Thu ngân','215300')


go
insert into TaiKhoan
values  
	('trang','1','NV0001'),
	('minh','1','NV0002')

	
go
insert into SanPham
values
	('SP0001',N'Sữa','7000','1000'),
	('SP0002',N'Đường','5000','1500'),
	('SP0003',N'Giày','1000000','50'),
	('SP0004',N'Kẹo','1500','10000'),
	('SP0005',N'Osi','6000','15000'),
	('SP0006',N'Dầu Ăn','30000','1000'),
	('SP0007',N'Thuốc lá','15000','1500'),
	('SP0008',N'Mỳ Tôm','3500','35000'),
	('SP0009',N'Túi Nhựa','1000','100000'),
	('SP0010',N'Cafe','11000','1000'),
	('SP0011',N'Sách','50000','200')

go
insert into PhieuNhap
values
	('PN0001','2021-7-12'),
	('PN0002','2021-5-12'),
	('PN0003','2021-10-13'),
	('PN0004','2021-3-14'),
	('PN0005','2021-1-15')

go
insert into ChiTietPhieuNhap
values
	('PN0001','SP0001','100','3000'),
	('PN0001','SP0002','100','2000'),
	('PN0002','SP0003','20','1200000'),
	('PN0003','SP0011','50','20000'),
	('PN0004','SP0001','150','3000'),
	('PN0005','SP0005','150','2500'),
	('PN0005','SP0004','300','500')
go

insert into HoaDon
values
	('1-8-2021','NV0001','KH0001'),
	('2-5-2021','NV0001','KH0002'),
	('3-1-2021','NV0003','KH0004')

go
insert into ChiTietHoaDon
values	
	(1,'SP0002',1000),
	(1,'SP0003',100),
	(1,'SP0001',100),
	(2,'SP0005',1000),
	(2,'SP0007',100),
	(2,'SP0008',100),
	(3,'SP0009',1000),
	(3,'SP0004',100),
	(3,'SP0005',100)

SELECT dbo.SanPham.tenSP, dbo.ChiTietHoaDon.soLuongDat, dbo.SanPham.donGiaBan, dbo.ChiTietHoaDon.soLuongDat * dbo.SanPham.donGiaBan AS TongTien
FROM     dbo.ChiTietHoaDon INNER JOIN
                  dbo.HoaDon ON dbo.ChiTietHoaDon.maHD = dbo.HoaDon.maHD INNER JOIN
                  dbo.SanPham ON dbo.ChiTietHoaDon.maSP = dbo.SanPham.maSP
where dbo.HoaDon.maHD = '1'
GROUP BY dbo.SanPham.tenSP, dbo.ChiTietHoaDon.soLuongDat, dbo.SanPham.donGiaBan, dbo.ChiTietHoaDon.soLuongDat * dbo.SanPham.donGiaBan

	select HoaDon.maHD, HoaDon.ngayTaoHD ,KhachHang.tenKH, SanPham.tenSP, ChiTietHoaDon.soLuongDat,1 from ChiTietHoaDon
	INNER JOIN HoaDon ON ChiTietHoaDon.maHD = HoaDon.maHD
	INNER JOIN SanPham ON SanPham.maSP = ChiTietHoaDon.maSP
	INNER JOIN KhachHang ON KhachHang.maKH = HoaDon.maKH
	where HoaDon.maHD = 1;


/*
SELECT dbo.SanPham.tenSP, dbo.ChiTietHoaDon.soLuongDat, dbo.SanPham.donGiaBan, dbo.ChiTietHoaDon.soLuongDat * dbo.SanPham.donGiaBan AS TongTien
FROM     dbo.ChiTietHoaDon INNER JOIN
                  dbo.HoaDon ON dbo.ChiTietHoaDon.maHD = dbo.HoaDon.maHD INNER JOIN
                  dbo.SanPham ON dbo.ChiTietHoaDon.maSP = dbo.SanPham.maSP
where dbo.HoaDon.maHD = '2'
GROUP BY dbo.SanPham.tenSP, dbo.ChiTietHoaDon.soLuongDat, dbo.SanPham.donGiaBan, dbo.ChiTietHoaDon.soLuongDat * dbo.SanPham.donGiaBan
*/


SELECT * 
From SanPham 
WHERE tenSP like '%sua%'

SELECT * 
From SanPham 
WHERE contains(tenSP,'sua')

SELECT * From ChiTietHoaDon WHERE CONCAT(maSP, tenSP) like '%sua%'

SELECT SERVERPROPERTY('IsFullTextInstalled')


-- Hiển thị mua hàng
SELECT dbo.HoaDon.maHD as N'Mã hóa đơn', dbo.HoaDon.ngayTaoHD as N'Ngày tạo HĐ', dbo.KhachHang.tenKH N'Tên khách hàng', dbo.NhanVien.tenNV as N'Tên nhân viên', format(sum(dbo.ChiTietHoaDon.soLuongDat * dbo.SanPham.donGiaBan),'##,#\ VNĐ','es-ES') as N'Thành tiền'
FROM     dbo.HoaDon INNER JOIN
				dbo.ChiTietHoaDon ON dbo.HoaDon.maHD = dbo.ChiTietHoaDon.maHD INNER JOIN
				dbo.SanPham ON dbo.SanPham.maSP = dbo.ChiTietHoaDon.maSP INNER JOIN
                  dbo.KhachHang ON dbo.HoaDon.maKH = dbo.KhachHang.maKH INNER JOIN
                  dbo.NhanVien ON dbo.HoaDon.maNV = dbo.NhanVien.maNV
GROUP BY dbo.HoaDon.maHD, dbo.HoaDon.ngayTaoHD, dbo.KhachHang.tenKH, dbo.NhanVien.tenNV

-- Hiển thị form nhân viên
SELECT maNV as N'Mã nhân viên', tenNV as N'Tên nhân viên', SDT as N'Số điện thoại', email as 'Email', chucVu as N'Chức vụ', format((luong),'##,#\ VNĐ','es-ES') as N'Lương'
From NhanVien 
--Hiển thị form sản phẩm
SELECT maSP As N'Mã sản phẩm',tenSP As N'Tên sản phẩm', format((donGiaBan),'##,#\ VNĐ','es-ES') As N'Đơn giá', soLuongCon as N'Số lượng còn'
From SanPham

--

select  * from TaiKhoan
SELECT tenTK as N'Tài Khoản', matKhau as N'Mật khẩu',dbo.NhanVien.maNV as N'Mã nhân viên',tenNV as N'Tên nhân viên' , SDT as N'Số điện thoại', email as 'E-mail',chucVu as N'Chức vụ',format((luong),'##,#\ VNĐ','es-ES') as N'Lương'
					FROM    dbo.TaiKhoan INNER JOIN
					  dbo.NhanVien   ON dbo.NhanVien.maNV  = dbo.TaiKhoan.maNV
					  and tenTK = 'trang'

-- Cập nhật tài khoản
update  TaiKhoan  
set tenTK = N'" & giaText.Text & "',matKhau = '" & soLuongText.Text & "' 
where idTK = '" & maSPText.Text & "'

--cập nhật nhân viên
update  NhanVien  
set SDT = N'" & giaText.Text & "',email = '" & soLuongText.Text & "' ,chucVu = '" & soLuongText.Text & "',luong = '" & soLuongText.Text & "'
where maNV = '" & maSPText.Text & "'



-- Tìm kiếm TK and NV
SELECT tenTK as N'Tài Khoản', matKhau as N'Mật khẩu',NV.maNV as N'Mã nhân viên',tenNV as N'Tên nhân viên' , SDT as N'Số điện thoại', email as 'E-mail',chucVu as N'Chức vụ',format((luong),'##,#\ VNĐ','es-ES') as N'Lương'
From TaiKhoan as TK, NhanVien as NV 
WHERE   CONCAT(tenTK, matKhau, NV.maNV, tenNV, SDT, email, chucVu, luong) like '%" & valueToSearch & "%'


--Hiển thị form nhập hàng
select SP.maSP as N'Mã sản phẩm', tenSP as N'Tên sản phẩm', format((donGiaNhap),'##,#\ VNĐ','es-ES') as N'Đơn giá bán', ngayNhapHang as N'Ngày nhập hàng' 
from PhieuNhap as PN, ChiTietPhieuNhap as CT, SanPham as SP
where PN.maPN = CT.maPN and CT.maSP = SP.maSP

--Thêm hàng
update  SanPham  
set soLuongCon = soLuongCon - '" & txtSL.Text & "'
where maSP = '" & txtMaSP.Text & "'

select * from ChiTietHoaDon
--Hiển thị hóa đơn 
select HD.maHD as N'Mã hóa đơn',NV.tenNV as N'Nhân viên thanh toán',KH.tenKH as N'Tên khách hàng',SP.maSP as N'Mã sản phẩm', SP.tenSP as N'Tên sản phẩm',CT.soLuongDat as N'Số lượng đặt', format(SP.donGiaBan,'##,#\ VNĐ','es-ES') as N'Đơn giá bán',format(sum(CT.soLuongDat * SP.donGiaBan),'##,#\ VNĐ','es-ES') as N'Thành tiền'  
from SanPham as SP, ChiTietHoaDon as CT, HoaDon as HD, NhanVien as NV, KhachHang as KH, TaiKhoan as TK
where SP.maSP = CT.maSP and CT.maHD = HD.maHD  and HD.maKH = KH.maKH and HD.maNV = NV.maNV and NV.maNV = TK.maNV
		and tenTK = 'trang'
GROUP BY HD.maHD, NV.tenNV,KH.tenKH, SP.maSP, SP.tenSP, CT.soLuongDat, SP.donGiaBan

select*
from SanPham as SP, ChiTietHoaDon as CT, HoaDon as HD, NhanVien as NV, KhachHang as KH, TaiKhoan as TK
where SP.maSP = CT.maSP and CT.maHD = HD.maHD  and HD.maKH = KH.maKH and HD.maNV = NV.maNV and NV.maNV = TK.maNV
		and tenTK = 'tuan'
GROUP BY HD.maHD, NV.tenNV,KH.tenKH, SP.maSP, SP.tenSP, CT.soLuongDat, SP.donGiaBan
--
create proc sp_autoID 
	@idnextchar varchar(10) output
as 
begin
	declare @idnext int 
	select @idnext = max(right(maSP,4)) + 1
	from SanPham
	set @idnextchar = concat('SP',format(@idnext,'D4'))
	print @idnextchar
end
go
--Goi thủ tục
declare @idnextchar varchar(10)
exec sp_autoID @idnextchar 

--
create or alter function fn_autoID
(
)
returns varchar(7)
begin
declare @idnext int
select @idnext = max(right(maSP,4)) + 1
from SanPham
declare @idnextchar varchar(7)
set @idnextchar = (select max(maSP) as idMax
from SanPham) + 1
return concat('SP',format(@idnext,'D4'))
end
--Goi thủ tục
select dbo.fn_autoID() as N'ID tiếp theo'

SELECT * FROM SanPham
--
insert into SanPham(maSp,tenSP,donGiaBan,soLuongCon) 
values(dbo.fn_autoID(),N'Dầu ăn','15000',10)




create or alter function fn_autoIDKH
(
)
returns varchar(7)
begin
declare @idnext int
select @idnext = max(right(maKH,4)) + 1
from KhachHang
declare @idnextchar varchar(7)
set @idnextchar = (select max(maKH) as idMax
from KhachHang) + 1
return concat('KH',format(@idnext,'D4'))
end
--Goi thủ tục
select dbo.fn_autoIDKH() as N'ID tiếp theo'

SELECT * FROM KhachHang
--
insert into KhachHang(maKH,tenKH,diaChiKH,SDT,Email) 
values(dbo.fn_autoIDKH(),N'Nguyễn Văn Trung',N'Quảng Bình','0373532115','Cafebockhoi@gmail.com')


--Lấy mã KH max
create function makh_max
(
)
returns varchar(10)
begin
declare @idmax varchar(10)
select @idmax = max(maKH)
from KhachHang
return @idmax
end
--
select dbo.makh_max() as N'KH max'

-- Hiển thị hóa đơn
select * from HoaDon
insert into HoaDon 
values (GETDATE(),'NV0001',dbo.makh_max())

select MAX(maHD) from HoaDon

--
select * from ChiTietHoaDon
insert into ChiTietHoaDon
values ('3','SP0002',1)


--
create function fn_autoIDNV
(
)
returns varchar(10)
begin
declare @idnext int
select @idnext = max(right(maNV,4)) + 1
from NhanVien
declare @idnextchar varchar(7)
set @idnextchar = (select max(maNV) as idMax
from NhanVien) + 1
return concat('NV',format(@idnext,'D4'))
end
--Goi thủ tục
select dbo.fn_autoIDNV() as N'ID tiếp theo'





select HD.maHD ,HD.ngayTaoHD ,NV.tenNV,KH.tenKH ,SP.maSP, SP.tenSP,CT.soLuongDat, format(SP.donGiaBan,'##,#\ VNĐ','es-ES') ,format(sum(CT.soLuongDat * SP.donGiaBan),'##,#\ VNĐ','es-ES') 
                from SanPham as SP, ChiTietHoaDon as CT, HoaDon as HD, NhanVien as NV, KhachHang as KH, TaiKhoan as TK
                where SP.maSP = CT.maSP and CT.maHD = HD.maHD  and HD.maKH = KH.maKH and HD.maNV = NV.maNV and NV.maNV = TK.maNV     
                GROUP BY HD.maHD, HD.ngayTaoHD,NV.tenNV,KH.tenKH, SP.maSP, SP.tenSP, CT.soLuongDat, SP.donGiaBan

--
create function fn_TongTien
(
	@maDonhang char(7)
)
returns money

begin
	return(
	select sum(soLuongDat*donGiaBan) 
	from SanPham as SP, ChiTietHoaDon as CT
	where SP.maSP = CT.maSP
	group by SP.maSP
	having sp.maSP=@maDonhang)
end

---gọi hàm
go

select dbo.fn_TongTien(SP.maSP)
from SanPham as SP, ChiTietHoaDon as CT
where SP.maSP = CT.maSP

--Report Mua hàng
select maSP,tenSP,format(donGiaBan,'##,#\ VNĐ','es-ES') as donGiaBan,format(soLuongCon,'##,#','es-ES') as soLuongCon
from SanPham

--Report Nhân viên
select maNV,tenNV,SDT,email,chucVu,format(luong,'##,#\ VNĐ','es-ES') as luong from NhanVien

--Report Nhập hàng
select SP.maSP , tenSP , format(donGiaNhap,'##,#\ VNĐ','es-ES') as donGiaNhap, ngayNhapHang
                from PhieuNhap as PN, ChiTietPhieuNhap as CT, SanPham as SP
                where PN.maPN = CT.maPN and CT.maSP = SP.maSP

--Report Sản Phẩm
select maSP,tenSP,format(donGiaBan,'##,#\ VNĐ','es-ES'),format(soLuongCon,'##,#','es-ES') from SanPham

-- Khách hàng
select maKH as N'Mã khách hàng', tenKH as N'Tên khách hàng', diaChiKH as N'Địa chỉ', SDT as N'Số điện thoại', Email as 'E-mail' 
from KhachHang

--
SELECT maNV as N'Mã nhân viên', tenNV as N'Tên nhân viên', SDT as N'Số điện thoại', email as 'Email', chucVu as N'Chức vụ', format((luong),'##,#\ VNĐ','es-ES') as N'Lương'
                From NhanVien
                Where luong >= 5000000


select SP.maSP as N'Mã sản phẩm', SP.tenSP as N'Tên sản phẩm', format((donGiaNhap),'##,#\ VNĐ','es-ES') as N'Đơn giá nhập', ngayNhapHang as N'Ngày nhập hàng' 
                from PhieuNhap as PN, ChiTietPhieuNhap as CT, SanPham as SP
                where PN.maPN = CT.maPN and CT.maSP = SP.maSP and tenSP like N'Đường'

select SP.maSP as N'Mã sản phẩm', tenSP as N'Tên sản phẩm', format((donGiaNhap),'##,#\ VNĐ','es-ES') as N'Đơn giá nhập', ngayNhapHang as N'Ngày nhập hàng' 
                from PhieuNhap as PN, ChiTietPhieuNhap as CT, SanPham as SP
                where PN.maPN = CT.maPN and CT.maSP = SP.maSP and  donGiaNhap <= 1000000 and donGiaNhap > 500000

select SP.maSP as N'Mã sản phẩm', tenSP as N'Tên sản phẩm', format((donGiaNhap),'##,#\ VNĐ','es-ES') as N'Đơn giá nhập', ngayNhapHang as N'Ngày nhập hàng' 
                from PhieuNhap as PN, ChiTietPhieuNhap as CT, SanPham as SP
                where PN.maPN = CT.maPN and CT.maSP = SP.maSP  order by ngayNhapHang desc

---- NV
SELECT maSP As N'Mã sản phẩm',tenSP As N'Tên sản phẩm', format((donGiaBan),'##,#\ VNĐ','es-ES') As N'Đơn giá', soLuongCon as N'Số lượng còn'
                From SanPham
				where soLuongCon >= 1 and soLuongCon <= 1000


SELECT maSP As N'Mã sản phẩm',tenSP As N'Tên sản phẩm', format((donGiaBan),'##,#\ VNĐ','es-ES') As N'Đơn giá', soLuongCon as N'Số lượng còn'
                From SanPham
				where soLuongCon >1000


SELECT maSP As N'Mã sản phẩm',tenSP As N'Tên sản phẩm', format((donGiaBan),'##,#\ VNĐ','es-ES') As N'Đơn giá', soLuongCon as N'Số lượng còn'
                From SanPham
				where donGiaBan >= 1000000

				
SELECT maSP As N'Mã sản phẩm',tenSP As N'Tên sản phẩm', format((donGiaBan),'##,#\ VNĐ','es-ES') As N'Đơn giá', soLuongCon as N'Số lượng còn'
                From SanPham
				where donGiaBan < 1000000

--
select HD.maHD as N'Mã hóa đơn',HD.ngayTaoHD as N'Ngày tạo hóa đơn',NV.tenNV as N'Nhân viên thanh toán',KH.tenKH as N'Tên khách hàng',SP.maSP as N'Mã sản phẩm', SP.tenSP as N'Tên sản phẩm',CT.soLuongDat as N'Số lượng đặt', format(SP.donGiaBan,'##,#\ VNĐ','es-ES') as N'Đơn giá bán',format(sum(CT.soLuongDat * SP.donGiaBan),'##,#\ VNĐ','es-ES') as N'Thành tiền'  
                from SanPham as SP, ChiTietHoaDon as CT, HoaDon as HD, NhanVien as NV, KhachHang as KH, TaiKhoan as TK
                where SP.maSP = CT.maSP and CT.maHD = HD.maHD  and HD.maKH = KH.maKH and HD.maNV = NV.maNV and NV.maNV = TK.maNV
		                and tenTK = 'tuan' and soLuongDat >=1  and	soLuongDat< 1000
                GROUP BY HD.maHD, HD.ngayTaoHD,NV.tenNV,KH.tenKH, SP.maSP, SP.tenSP, CT.soLuongDat, SP.donGiaBan

				--
select HD.maHD as N'Mã hóa đơn',HD.ngayTaoHD as N'Ngày tạo hóa đơn',NV.tenNV as N'Nhân viên thanh toán',KH.tenKH as N'Tên khách hàng',SP.maSP as N'Mã sản phẩm', SP.tenSP as N'Tên sản phẩm',CT.soLuongDat as N'Số lượng đặt', format(SP.donGiaBan,'##,#\ VNĐ','es-ES') as N'Đơn giá bán',format(sum(CT.soLuongDat * SP.donGiaBan),'##,#\ VNĐ','es-ES') as N'Thành tiền'  
                from SanPham as SP, ChiTietHoaDon as CT, HoaDon as HD, NhanVien as NV, KhachHang as KH, TaiKhoan as TK
                where SP.maSP = CT.maSP and CT.maHD = HD.maHD  and HD.maKH = KH.maKH and HD.maNV = NV.maNV and NV.maNV = TK.maNV
		                and tenTK = 'tuan' and soLuongDat >=1000
                GROUP BY HD.maHD, HD.ngayTaoHD,NV.tenNV,KH.tenKH, SP.maSP, SP.tenSP, CT.soLuongDat, SP.donGiaBan
