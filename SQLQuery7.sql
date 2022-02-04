create database QUANLYPHONGKHAM
go
CREATE TABLE BenhNhan
(
  MaBenhNhan CHAR(7) NOT NULL,
  HoTen NVARCHAR(255) NOT NULL,
  GioiTinh INT NOT NULL,
  NgaySinh DATE NOT NULL,
  DiaChi NVARCHAR(1000) NOT NULL,
  SDT CHAR(10) NOT NULL,
  PRIMARY KEY (MaBenhNhan)
);

CREATE TABLE DichVu
(
  MaDichVu CHAR(7) NOT NULL,
  TenDichVu NVARCHAR(255) NOT NULL,
  DonGia FLOAT NOT NULL,
  DonViTinh NVARCHAR(10) NOT NULL,
  GhiChu NVARCHAR(255) NOT NULL,
  PRIMARY KEY (MaDichVu)
);

CREATE TABLE TaiKhoan
(
  TenDangNhap NVARCHAR(255) NOT NULL,
  MatKhau NVARCHAR(255) NOT NULL,
  QuyenTruyCap INT NOT NULL,
  PRIMARY KEY (TenDangNhap)
);

CREATE TABLE NhanVien
(
  MaNhanVien CHAR NOT NULL,
  HoTen NVARCHAR(255) NOT NULL,
  ChucVu NVARCHAR(20) NOT NULL,
  DiaChi NVARCHAR(1000) NOT NULL,
  GioiTinh INT NOT NULL,
  SDT CHAR(10) NOT NULL,
  TenDangNhap NVARCHAR(255) NOT NULL,
  PRIMARY KEY (MaNhanVien),
  FOREIGN KEY (TenDangNhap) REFERENCES TaiKhoan(TenDangNhap)
);

CREATE TABLE BacSi
(
  MaBacSi CHAR(7) NOT NULL,
  HoTen NVARCHAR(255) NOT NULL,
  TrinhDo NVARCHAR(20) NOT NULL,
  ChucVu NVARCHAR(20) NOT NULL,
  DiaChi NVARCHAR(1000) NOT NULL,
  SDT CHAR(10) NOT NULL,
  GioiTinh INT NOT NULL,
  TenDangNhap NVARCHAR(255) NOT NULL,
  PRIMARY KEY (MaBacSi),
  FOREIGN KEY (TenDangNhap) REFERENCES TaiKhoan(TenDangNhap)
);

CREATE TABLE BanKe
(
  MaBanKe CHAR(100) NOT NULL,
  NgayLapBanKe DATE NOT NULL,
  MaBenhNhan CHAR(7) NOT NULL,
  MaNhanVien CHAR NOT NULL,
  PRIMARY KEY (MaBanKe),
  FOREIGN KEY (MaBenhNhan) REFERENCES BenhNhan(MaBenhNhan),
  FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)
);

CREATE TABLE ChiTietBanKe
(
  SoLuong INT NOT NULL,
  MaBanKe CHAR(100) NOT NULL,
  MaDichVu CHAR(7) NOT NULL,
  PRIMARY KEY (MaBanKe, MaDichVu),
  FOREIGN KEY (MaBanKe) REFERENCES BanKe(MaBanKe),
  FOREIGN KEY (MaDichVu) REFERENCES DichVu(MaDichVu)
);

CREATE TABLE PhieuThuTienTamUng
(
  MaPhieuThuTienTamUng DATE NOT NULL,
  SoTienThuTamUng FLOAT NOT NULL,
  NgayThuTienTamUng DATE NOT NULL,
  MaNhanVien CHAR NOT NULL,
  MaBanKe CHAR(100) NOT NULL,
  PRIMARY KEY (MaPhieuThuTienTamUng),
  FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien),
  FOREIGN KEY (MaBanKe) REFERENCES BanKe(MaBanKe)
);

CREATE TABLE KetQuaXetNghiem
(
  NgayThongBao DATE NOT NULL,
  KetQua NVARCHAR(1000) NOT NULL,
  MaBacSi CHAR(7) NOT NULL,
  MaBanKe CHAR(100) NOT NULL,
  MaDichVu CHAR(7) NOT NULL,
  PRIMARY KEY (MaBacSi),
  FOREIGN KEY (MaBacSi) REFERENCES BacSi(MaBacSi),
  FOREIGN KEY (MaBanKe, MaDichVu) REFERENCES ChiTietBanKe(MaBanKe, MaDichVu)
);

CREATE TABLE TongHopChiPhi
(
  ThanhTien FLOAT NOT NULL,
  NgayThanhToan DATE NOT NULL,
  MaHoaDon NVARCHAR(100) NOT NULL,
  MaNhanVien CHAR NOT NULL,
  MaPhieuThuTienTamUng DATE NOT NULL,
  PRIMARY KEY (MaHoaDon),
  FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien),
  FOREIGN KEY (MaPhieuThuTienTamUng) REFERENCES PhieuThuTienTamUng(MaPhieuThuTienTamUng)
);

USE [QUANLYPHONGKHAM]
GO
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [QuyenTruyCap]) VALUES (N'admin', N'1', 0)
GO
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [QuyenTruyCap]) VALUES (N'bacsi1', N'1', 1)
GO
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [QuyenTruyCap]) VALUES (N'bacsi2', N'1', 1)
GO
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [QuyenTruyCap]) VALUES (N'nhanvien1', N'1', 2)
GO
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [QuyenTruyCap]) VALUES (N'nhanvien2', N'1', 2)
GO
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [ChucVu], [DiaChi], [GioiTinh], [SDT], [TenDangNhap]) VALUES (N'1', N'Thinh1', N'1', N'1', 1, N'1         ', N'nhanvien1')
GO
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [ChucVu], [DiaChi], [GioiTinh], [SDT], [TenDangNhap]) VALUES (N'2', N'Chi1', N'1', N'1', 1, N'1         ', N'nhanvien2')
GO
INSERT [dbo].[BacSi] ([MaBacSi], [HoTen], [TrinhDo], [ChucVu], [DiaChi], [SDT], [GioiTinh], [TenDangNhap]) VALUES (N'BS1    ', N'Thinh', N'1', N'1', N'1', N'1         ', 1, N'bacsi1')
GO
INSERT [dbo].[BacSi] ([MaBacSi], [HoTen], [TrinhDo], [ChucVu], [DiaChi], [SDT], [GioiTinh], [TenDangNhap]) VALUES (N'BS2    ', N'Chi', N'1', N'1', N'1', N'1         ', 1, N'bacsi2')
GO
INSERT [dbo].[BenhNhan] ([MaBenhNhan], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [SDT]) VALUES (N'BN1    ', N'Xuân', 1, CAST(N'1111-11-11' AS Date), N'1', N'1         ')
GO
INSERT [dbo].[BenhNhan] ([MaBenhNhan], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [SDT]) VALUES (N'BN2    ', N'Anh', 1, CAST(N'1111-11-11' AS Date), N'1', N'1         ')
GO
INSERT [dbo].[DichVu] ([MaDichVu], [TenDichVu], [DonGia], [DonViTinh], [GhiChu]) VALUES (N'DV1    ', N'KhamMatToanDien', 100000, N'1', N'Không')
GO
INSERT [dbo].[DichVu] ([MaDichVu], [TenDichVu], [DonGia], [DonViTinh], [GhiChu]) VALUES (N'DV2    ', N'KhamMatToanDienVip', 1000000, N'1', N'Không')
GO
