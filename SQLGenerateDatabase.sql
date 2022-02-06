create database QLPK
go
use QLPK
go
CREATE TABLE BenhNhan
(
  MaBenhNhan VARCHAR(7) NOT NULL,
  HoTen NVARCHAR(255) NOT NULL,
  GioiTinh NVARCHAR(10) NOT NULL,
  NgaySinh DATE NOT NULL,
  DiaChi NVARCHAR(255) NOT NULL,
  SDT VARCHAR(10) NOT NULL,
  PRIMARY KEY (MaBenhNhan)
);

CREATE TABLE DichVu
(
  MaDichVu VARCHAR(7) NOT NULL,
  TenDichVu NVARCHAR(255) NOT NULL,
  DonGia FLOAT NOT NULL,
  DonViTinh NVARCHAR(10) NOT NULL,
  GhiChu NVARCHAR(255) NOT NULL,
  SoLanSuDung INT NOT NULL,
  PRIMARY KEY (MaDichVu)
);

CREATE TABLE TaiKhoan
(
  TenDangNhap VARCHAR(7) NOT NULL,
  MatKhau VARCHAR(255) NOT NULL,
  QuyenTruyCap INT NOT NULL,
  TrangThai NVARCHAR(20) NOT NULL,
  PRIMARY KEY (TenDangNhap)
);

CREATE TABLE Benh
(
  MaBenh VARCHAR(7) NOT NULL,
  LoaiBenh NVARCHAR(255) NOT NULL,
  MoTaBenh NVARCHAR(1000) NOT NULL,
  PRIMARY KEY (MaBenh)
);

CREATE TABLE NhanVien
(
  MaNhanVien VARCHAR(7) NOT NULL,
  HoTen NVARCHAR(255) NOT NULL,
  GioiTinh NVARCHAR(10) NOT NULL,
  ChucVu NVARCHAR(20) NOT NULL,
  DiaChi NVARCHAR(255) NOT NULL,
  SDT VARCHAR(10) NOT NULL,
  PRIMARY KEY (MaNhanVien),
  FOREIGN KEY (MaNhanVien) REFERENCES TaiKhoan(TenDangNhap)
);

CREATE TABLE BacSi
(
  MaBacSi VARCHAR(7) NOT NULL,
  HoTen NVARCHAR(255) NOT NULL,
  GioiTinh NVARCHAR(10) NOT NULL,
  TrinhDo NVARCHAR(20) NOT NULL,
  ChucVu NVARCHAR(20) NOT NULL,
  DiaChi NVARCHAR(255) NOT NULL,
  SDT VARCHAR(10) NOT NULL,
  PRIMARY KEY (MaBacSi),
  FOREIGN KEY (MaBacSi) REFERENCES TaiKhoan(TenDangNhap)
);

CREATE TABLE BanKe
(
  MaBanKe INT Identity(1,1) NOT NULL,
  NgayLapBanKe DATE NOT NULL,
  MaBenhNhan VARCHAR(7) NOT NULL,
  MaNhanVien VARCHAR(7) NOT NULL,
  PRIMARY KEY (MaBanKe),
  FOREIGN KEY (MaBenhNhan) REFERENCES BenhNhan(MaBenhNhan),
  FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)
);

CREATE TABLE ChiTietBanKe
(
  MaBanKe INT NOT NULL,
  MaDichVu VARCHAR(7) NOT NULL,
  SoLuong INT NOT NULL,
  PRIMARY KEY (MaBanKe, MaDichVu),
  FOREIGN KEY (MaBanKe) REFERENCES BanKe(MaBanKe),
  FOREIGN KEY (MaDichVu) REFERENCES DichVu(MaDichVu)
);

CREATE TABLE HoSoBenhAn
(
  SoBenhAn VARCHAR(10) NOT NULL,
  MaBenhNhan VARCHAR(7) NOT NULL,
  MaBenh VARCHAR(7) NOT NULL,
  MaBacSi VARCHAR(7) NOT NULL,
  NgayKham DATE NOT NULL,
  ChanDoan NVARCHAR(1000) NOT NULL,
  PRIMARY KEY (SoBenhAn),
  FOREIGN KEY (MaBenhNhan) REFERENCES BenhNhan(MaBenhNhan),
  FOREIGN KEY (MaBenh) REFERENCES Benh(MaBenh),
  FOREIGN KEY (MaBacSi) REFERENCES BacSi(MaBacSi)
);

CREATE TABLE PhieuThuTienTamUng
(
  MaPhieuThuTienTamUng VARCHAR(10) NOT NULL,
  SoTienThuTamUng FLOAT NOT NULL,
  NgayThuTienTamUng DATE NOT NULL,
  MaBanKe INT NOT NULL,
  MaNhanVien VARCHAR(7) NOT NULL,
  PRIMARY KEY (MaPhieuThuTienTamUng),
  FOREIGN KEY (MaBanKe) REFERENCES BanKe(MaBanKe),
  FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)
);

CREATE TABLE KetQuaXetNghiem
(
  MaBanKe INT NOT NULL,
  MaDichVu VARCHAR(7) NOT NULL,
  MaBacSi VARCHAR(7) NOT NULL,
  NgayKham DATE NOT NULL,
  KetQua NVARCHAR(1000) NOT NULL,
  PRIMARY KEY (MaBanKe, MaDichVu, MaBacSi),
  FOREIGN KEY (MaBanKe, MaDichVu) REFERENCES ChiTietBanKe(MaBanKe, MaDichVu),
  FOREIGN KEY (MaBacSi) REFERENCES BacSi(MaBacSi)
);

CREATE TABLE TongHopChiPhi
(
  MaHoaDon VARCHAR(10) NOT NULL,
  MaPhieuThuTienTamUng VARCHAR(10) NOT NULL,
  MaNhanVien VARCHAR(7) NOT NULL,
  ThanhTien FLOAT NOT NULL,
  NgayThanhToan DATE NOT NULL,
  PRIMARY KEY (MaHoaDon),
  FOREIGN KEY (MaPhieuThuTienTamUng) REFERENCES PhieuThuTienTamUng(MaPhieuThuTienTamUng),
  FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)
);

INSERT INTO TaiKhoan (TenDangNhap, MatKhau, QuyenTruyCap, TrangThai)
VALUES ('admin','123',0,N'Đang làm việc');

INSERT INTO TaiKhoan (TenDangNhap, MatKhau, QuyenTruyCap, TrangThai)
VALUES ('BS001','123',1,N'Đang làm việc');

INSERT INTO TaiKhoan (TenDangNhap, MatKhau, QuyenTruyCap, TrangThai)
VALUES ('BS002','123',1,N'Đang làm việc');

INSERT INTO TaiKhoan (TenDangNhap, MatKhau, QuyenTruyCap, TrangThai)
VALUES ('BS003','123',1,N'Nghỉ việc');

INSERT INTO TaiKhoan (TenDangNhap, MatKhau, QuyenTruyCap, TrangThai)
VALUES ('NV001','123',2,N'Đang làm việc');

INSERT INTO TaiKhoan (TenDangNhap, MatKhau, QuyenTruyCap, TrangThai)
VALUES ('NV002','123',2,N'Đang làm việc');

INSERT INTO TaiKhoan (TenDangNhap, MatKhau, QuyenTruyCap, TrangThai)
VALUES ('NV003','123',2,N'Nghỉ việc');

INSERT INTO BacSi (MaBacSi,HoTen,GioiTinh,TrinhDo,ChucVu,DiaChi,SDT)
VALUES ('BS001',N'Vũ Đinh Trường An',N'Nam',N'Thạc sĩ',N'Làm thêm',N'Hai Bà Trưng, Hà Nội','01234567');

INSERT INTO BacSi (MaBacSi,HoTen,GioiTinh,TrinhDo,ChucVu,DiaChi,SDT)
VALUES ('BS002',N'Hoàng Trung Chiến',N'Nam',N'PGS',N'Phó',N'Hà Nam','987654');

INSERT INTO BacSi (MaBacSi,HoTen,GioiTinh,TrinhDo,ChucVu,DiaChi,SDT)
VALUES ('BS003',N'Nguyễn Thị Hường',N'Nữ',N'Thạc sĩ',N'Làm thêm',N'Ba Đình, Hà Nội','1029384756');

INSERT INTO NhanVien (MaNhanVien,HoTen,GioiTinh,ChucVu,DiaChi,SDT)
VALUES ('NV001',N'Chu Thị Ngân',N'Nữ',N'Thu ngân',N'Hoài Đức','20394874')

INSERT INTO NhanVien (MaNhanVien,HoTen,GioiTinh,ChucVu,DiaChi,SDT)
VALUES ('NV002',N'Nguyễn Đình Nhật',N'Nam',N'Tiếp đón',N'Nghệ An','20194923')

INSERT INTO NhanVien (MaNhanVien,HoTen,GioiTinh,ChucVu,DiaChi,SDT)
VALUES ('NV003',N'Phạm Nhật Quang',N'Nam',N'Thu ngân',N'Hưng Yên','21394874')

INSERT INTO BenhNhan (MaBenhNhan,HoTen,GioiTinh,NgaySinh,DiaChi,SDT)
VALUES ('BN001',N'Vũ Hoài Nam',N'Nam','2001-10-10',N'KTX Mỹ Đình Hà Nội','01929404')

INSERT INTO BenhNhan (MaBenhNhan,HoTen,GioiTinh,NgaySinh,DiaChi,SDT)
VALUES ('BN002',N'Bùi Tiến Thành',N'Nam','2005-10-12',N'KTX Bách khoa, Hà Nội','0638404')

INSERT INTO BenhNhan (MaBenhNhan,HoTen,GioiTinh,NgaySinh,DiaChi,SDT)
VALUES ('BN003',N'Ngô Thị Hương',N'Nữ','1997-12-10',N'Hai Bà Trưng, Hà Nội','12352132')

