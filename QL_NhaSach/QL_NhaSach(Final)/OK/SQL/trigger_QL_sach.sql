

	  create trigger capnhapdongia on HOADON_SACH
	  for insert, update
	  as
	  begin
		update HOADON_SACH
		set DONGIABAN= SOLUONGBAN * (Select DONGIA from SACH where MASACH = (Select MASACH from inserted))
		where MASACH = (Select MASACH from inserted) and MAHD = (Select MAHD from inserted)
	  end;
	  alter trigger phanquyen on CHUCVU_NHANVIEN
for insert, update
as
begin
 declare @tencv nvarchar(50)
 set @tencv = (select TenCV from NHANVIEN nv
	inner join CHUCVU_NHANVIEN cvnv
	on nv.MANV = cvnv.MANV
	inner join CHUCVU cv
	on cvnv.MACV = cv.MACV where nv.MANV = (select MANV from inserted))
	if @tencv like N'%quản lý%'
		update NHANVIEN
		set PHANQUYEN =1 
		where MANV = (select MANV from inserted)

		if @tencv like N'%thu ngân%'
			update NHANVIEN
		set PHANQUYEN =2
		where MANV = (select MANV from inserted)
	if @tencv like N'%admin%'
		update NHANVIEN
			set PHANQUYEN =0
			where MANV = (select MANV from inserted)
			if @tencv like N'%kho%'
			update NHANVIEN
			set PHANQUYEN =3
			where MANV = (select MANV from inserted)
			
			

end;