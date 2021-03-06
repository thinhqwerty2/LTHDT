USE [master]
GO
/****** Object:  Database [QLPK]    Script Date: 2/9/2022 11:49:46 PM ******/
CREATE DATABASE [QLPK]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLPK', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QLPK.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLPK_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QLPK_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QLPK] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLPK].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLPK] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLPK] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLPK] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLPK] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLPK] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLPK] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLPK] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLPK] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLPK] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLPK] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLPK] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLPK] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLPK] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLPK] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLPK] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QLPK] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLPK] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLPK] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLPK] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLPK] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLPK] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLPK] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLPK] SET RECOVERY FULL 
GO
ALTER DATABASE [QLPK] SET  MULTI_USER 
GO
ALTER DATABASE [QLPK] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLPK] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLPK] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLPK] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLPK] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLPK] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLPK', N'ON'
GO
ALTER DATABASE [QLPK] SET QUERY_STORE = OFF
GO
USE [QLPK]
GO
/****** Object:  Table [dbo].[BacSi]    Script Date: 2/9/2022 11:49:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BacSi](
	[MaBacSi] [varchar](7) NOT NULL,
	[HoTen] [nvarchar](255) NOT NULL,
	[GioiTinh] [nvarchar](10) NOT NULL,
	[TrinhDo] [nvarchar](20) NOT NULL,
	[ChucVu] [nvarchar](20) NOT NULL,
	[DiaChi] [nvarchar](255) NOT NULL,
	[SDT] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBacSi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BanKe]    Script Date: 2/9/2022 11:49:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BanKe](
	[MaBanKe] [int] IDENTITY(1,1) NOT NULL,
	[NgayLapBanKe] [date] NOT NULL,
	[MaBenhNhan] [varchar](7) NOT NULL,
	[MaNhanVien] [varchar](7) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBanKe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Benh]    Script Date: 2/9/2022 11:49:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Benh](
	[MaBenh] [varchar](7) NOT NULL,
	[LoaiBenh] [nvarchar](255) NOT NULL,
	[MoTaBenh] [nvarchar](1000) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBenh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BenhNhan]    Script Date: 2/9/2022 11:49:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BenhNhan](
	[MaBenhNhan] [varchar](7) NOT NULL,
	[HoTen] [nvarchar](255) NOT NULL,
	[GioiTinh] [nvarchar](10) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[DiaChi] [nvarchar](255) NOT NULL,
	[SDT] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBenhNhan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietBanKe]    Script Date: 2/9/2022 11:49:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietBanKe](
	[MaBanKe] [int] NOT NULL,
	[MaDichVu] [varchar](7) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBanKe] ASC,
	[MaDichVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DichVu]    Script Date: 2/9/2022 11:49:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DichVu](
	[MaDichVu] [varchar](7) NOT NULL,
	[TenDichVu] [nvarchar](255) NOT NULL,
	[DonGia] [float] NOT NULL,
	[DonViTinh] [nvarchar](10) NOT NULL,
	[GhiChu] [nvarchar](255) NOT NULL,
	[SoLanSuDung] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDichVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoSoBenhAn]    Script Date: 2/9/2022 11:49:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoSoBenhAn](
	[SoBenhAn] [int] IDENTITY(1,1) NOT NULL,
	[MaBenhNhan] [varchar](7) NOT NULL,
	[MaBenh] [varchar](7) NOT NULL,
	[MaBacSi] [varchar](7) NOT NULL,
	[NgayKham] [date] NOT NULL,
	[ChanDoan] [nvarchar](1000) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SoBenhAn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KetQuaXetNghiem]    Script Date: 2/9/2022 11:49:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KetQuaXetNghiem](
	[MaBanKe] [int] NOT NULL,
	[MaDichVu] [varchar](7) NOT NULL,
	[MaBacSi] [varchar](7) NOT NULL,
	[NgayKham] [date] NOT NULL,
	[KetQua] [nvarchar](1000) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBanKe] ASC,
	[MaDichVu] ASC,
	[MaBacSi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 2/9/2022 11:49:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [varchar](7) NOT NULL,
	[HoTen] [nvarchar](255) NOT NULL,
	[GioiTinh] [nvarchar](10) NOT NULL,
	[ChucVu] [nvarchar](20) NOT NULL,
	[DiaChi] [nvarchar](255) NOT NULL,
	[SDT] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuThuTienTamUng]    Script Date: 2/9/2022 11:49:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuThuTienTamUng](
	[MaPhieuThuTienTamUng] [int] IDENTITY(1,1) NOT NULL,
	[SoTienThuTamUng] [float] NOT NULL,
	[NgayThuTienTamUng] [date] NOT NULL,
	[MaBanKe] [int] NOT NULL,
	[MaNhanVien] [varchar](7) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieuThuTienTamUng] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 2/9/2022 11:49:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[TenDangNhap] [varchar](7) NOT NULL,
	[MatKhau] [varchar](255) NOT NULL,
	[QuyenTruyCap] [int] NOT NULL,
	[TrangThai] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TongHopChiPhi]    Script Date: 2/9/2022 11:49:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TongHopChiPhi](
	[MaHoaDon] [int] IDENTITY(1,1) NOT NULL,
	[MaPhieuThuTienTamUng] [int] NOT NULL,
	[MaNhanVien] [varchar](7) NOT NULL,
	[ThanhTien] [float] NOT NULL,
	[NgayThanhToan] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[BacSi] ([MaBacSi], [HoTen], [GioiTinh], [TrinhDo], [ChucVu], [DiaChi], [SDT]) VALUES (N'BS1', N'Bùi Xuân Thịnh', N'Nam', N'PGS', N'Trưởng khoa', N'376 Xã Đàn, Đống Đa, Hà Nội', N'0123456789')
INSERT [dbo].[BacSi] ([MaBacSi], [HoTen], [GioiTinh], [TrinhDo], [ChucVu], [DiaChi], [SDT]) VALUES (N'BS2', N'Vũ Hoài Nam', N'Nam', N'Thạc sĩ', N'Bác sĩ chuyên khoa', N'118 Hai Bà Trưng, Hà Nội', N'1234567890')
INSERT [dbo].[BacSi] ([MaBacSi], [HoTen], [GioiTinh], [TrinhDo], [ChucVu], [DiaChi], [SDT]) VALUES (N'BS3', N'Ngô Thị Hương', N'Nữ', N'Thạc sĩ', N'Bác sĩ chuyên khoa', N'92 Trần Đại Nghĩa, Hai Bà Trưng, Hà Nội', N'1234567098')
INSERT [dbo].[BacSi] ([MaBacSi], [HoTen], [GioiTinh], [TrinhDo], [ChucVu], [DiaChi], [SDT]) VALUES (N'BS4', N'Ngô Thị Hương', N'Nữ', N'Thạc sĩ', N'Bác sĩ chuyên khoa', N'Trần Đại Nghĩa, Hai Bà Trưng, Hà Nội', N'1234567098')
INSERT [dbo].[BacSi] ([MaBacSi], [HoTen], [GioiTinh], [TrinhDo], [ChucVu], [DiaChi], [SDT]) VALUES (N'BS5', N'Bùi Tiến Thành', N'Nam', N'Thạc sĩ', N'Bác sĩ ', N'Bách khoa, Hà Nội', N'1029384756')
GO
SET IDENTITY_INSERT [dbo].[BanKe] ON 

INSERT [dbo].[BanKe] ([MaBanKe], [NgayLapBanKe], [MaBenhNhan], [MaNhanVien]) VALUES (1, CAST(N'2022-02-09' AS Date), N'BN1', N'NV1')
INSERT [dbo].[BanKe] ([MaBanKe], [NgayLapBanKe], [MaBenhNhan], [MaNhanVien]) VALUES (2, CAST(N'2022-02-09' AS Date), N'BN3', N'NV1')
SET IDENTITY_INSERT [dbo].[BanKe] OFF
GO
INSERT [dbo].[Benh] ([MaBenh], [LoaiBenh], [MoTaBenh]) VALUES (N'BE1', N'Tật khúc xạ', N'Cận thị, Loạn thị, Viễn thị ')
INSERT [dbo].[Benh] ([MaBenh], [LoaiBenh], [MoTaBenh]) VALUES (N'BE2', N'Viêm kết mạc', N'Viêm kết mạc, đau mắt đỏ')
INSERT [dbo].[Benh] ([MaBenh], [LoaiBenh], [MoTaBenh]) VALUES (N'BE3', N'Đục thuỷ tinh thể', N'Đục thuỷ tinh thể, mắt bị ...')
GO
INSERT [dbo].[BenhNhan] ([MaBenhNhan], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [SDT]) VALUES (N'BN1', N'Hoàng Minh Đức', N'Nam', CAST(N'1995-02-09' AS Date), N'Hà Nam', N'1234455670')
INSERT [dbo].[BenhNhan] ([MaBenhNhan], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [SDT]) VALUES (N'BN2', N'Hoàng Quang Đức', N'Nam', CAST(N'2014-05-01' AS Date), N'Bách khoa', N'098754321')
INSERT [dbo].[BenhNhan] ([MaBenhNhan], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [SDT]) VALUES (N'BN3', N'Đặng Minh Anh', N'Nữ', CAST(N'2001-02-09' AS Date), N'Đội Cấn, Hà Nội', N'1234567812')
GO
INSERT [dbo].[ChiTietBanKe] ([MaBanKe], [MaDichVu]) VALUES (1, N'DV1')
INSERT [dbo].[ChiTietBanKe] ([MaBanKe], [MaDichVu]) VALUES (1, N'DV6')
INSERT [dbo].[ChiTietBanKe] ([MaBanKe], [MaDichVu]) VALUES (2, N'DV2')
INSERT [dbo].[ChiTietBanKe] ([MaBanKe], [MaDichVu]) VALUES (2, N'DV6')
GO
INSERT [dbo].[DichVu] ([MaDichVu], [TenDichVu], [DonGia], [DonViTinh], [GhiChu], [SoLanSuDung]) VALUES (N'DV1', N'Khám thường', 80000, N'lần', N'Không', 1)
INSERT [dbo].[DichVu] ([MaDichVu], [TenDichVu], [DonGia], [DonViTinh], [GhiChu], [SoLanSuDung]) VALUES (N'DV2', N'Khám với bác sĩ thạc sĩ', 100000, N'lần', N'Không', 1)
INSERT [dbo].[DichVu] ([MaDichVu], [TenDichVu], [DonGia], [DonViTinh], [GhiChu], [SoLanSuDung]) VALUES (N'DV3', N'Khám với bác sĩ phó giáo sư', -1, N'lần', N'Không', 0)
INSERT [dbo].[DichVu] ([MaDichVu], [TenDichVu], [DonGia], [DonViTinh], [GhiChu], [SoLanSuDung]) VALUES (N'DV4', N'Mổ mắt', 12000000, N'lần', N'Mổ mắt phục hồi cho các tật khúc xạ', 0)
INSERT [dbo].[DichVu] ([MaDichVu], [TenDichVu], [DonGia], [DonViTinh], [GhiChu], [SoLanSuDung]) VALUES (N'DV5', N'Phẫu thuật hở mi', 2000000, N'lần', N'Chữa bệnh hở mi', 0)
INSERT [dbo].[DichVu] ([MaDichVu], [TenDichVu], [DonGia], [DonViTinh], [GhiChu], [SoLanSuDung]) VALUES (N'DV6', N'Siêu âm mắt', 200000, N'lần', N'Không', 2)
INSERT [dbo].[DichVu] ([MaDichVu], [TenDichVu], [DonGia], [DonViTinh], [GhiChu], [SoLanSuDung]) VALUES (N'DV7', N'Chụp cắt lớp đáy mắt - OCT', 520000, N'lần', N'Không', 0)
GO
SET IDENTITY_INSERT [dbo].[HoSoBenhAn] ON 

INSERT [dbo].[HoSoBenhAn] ([SoBenhAn], [MaBenhNhan], [MaBenh], [MaBacSi], [NgayKham], [ChanDoan]) VALUES (1, N'BN1', N'BE1', N'BS1', CAST(N'2022-02-09' AS Date), N'Cận 1.5 độ')
INSERT [dbo].[HoSoBenhAn] ([SoBenhAn], [MaBenhNhan], [MaBenh], [MaBacSi], [NgayKham], [ChanDoan]) VALUES (2, N'BN3', N'BE2', N'BS1', CAST(N'2022-02-09' AS Date), N'Viêm kết mạc')
SET IDENTITY_INSERT [dbo].[HoSoBenhAn] OFF
GO
INSERT [dbo].[KetQuaXetNghiem] ([MaBanKe], [MaDichVu], [MaBacSi], [NgayKham], [KetQua]) VALUES (1, N'DV6', N'BS1', CAST(N'2022-02-09' AS Date), N'Mắt bị cận thị')
INSERT [dbo].[KetQuaXetNghiem] ([MaBanKe], [MaDichVu], [MaBacSi], [NgayKham], [KetQua]) VALUES (2, N'DV6', N'BS1', CAST(N'2022-02-09' AS Date), N'Viêm kết mạc')
GO
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [GioiTinh], [ChucVu], [DiaChi], [SDT]) VALUES (N'admin', N'admin', N'admin', N'admin', N'admin', N'admin')
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [GioiTinh], [ChucVu], [DiaChi], [SDT]) VALUES (N'admin1', N'admin', N'Nam', N'admin', N'Bách khoa', N'0000000000')
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [GioiTinh], [ChucVu], [DiaChi], [SDT]) VALUES (N'admin2', N'admin', N'Nam', N'admin', N'Bách khoa', N'0000000000')
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [GioiTinh], [ChucVu], [DiaChi], [SDT]) VALUES (N'NV1', N'Ngô Thị Hương', N'Nữ', N'Tiếp tân', N'Đống Đa, Hà Nội', N'1234567890')
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [GioiTinh], [ChucVu], [DiaChi], [SDT]) VALUES (N'NV2', N'Nguyễn Thị Hường', N'Nữ', N'Thu ngân', N'Bách khoa', N'1234567890')
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [GioiTinh], [ChucVu], [DiaChi], [SDT]) VALUES (N'NV3', N'Nguyễn Đình Nhật', N'Nam', N'Tiếp tân', N'Hà Nội', N'1234567890')
GO
SET IDENTITY_INSERT [dbo].[PhieuThuTienTamUng] ON 

INSERT [dbo].[PhieuThuTienTamUng] ([MaPhieuThuTienTamUng], [SoTienThuTamUng], [NgayThuTienTamUng], [MaBanKe], [MaNhanVien]) VALUES (1, 100000, CAST(N'2022-02-09' AS Date), 1, N'NV1')
INSERT [dbo].[PhieuThuTienTamUng] ([MaPhieuThuTienTamUng], [SoTienThuTamUng], [NgayThuTienTamUng], [MaBanKe], [MaNhanVien]) VALUES (2, 150000, CAST(N'2022-02-09' AS Date), 2, N'NV1')
SET IDENTITY_INSERT [dbo].[PhieuThuTienTamUng] OFF
GO
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [QuyenTruyCap], [TrangThai]) VALUES (N'admin', N'1', 0, N'Đang làm việc')
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [QuyenTruyCap], [TrangThai]) VALUES (N'admin1', N'1', 1, N'Đang làm việc')
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [QuyenTruyCap], [TrangThai]) VALUES (N'admin2', N'2', 0, N'Đang làm việc')
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [QuyenTruyCap], [TrangThai]) VALUES (N'BS1', N'1', 1, N'Đang làm việc')
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [QuyenTruyCap], [TrangThai]) VALUES (N'BS2', N'1', 1, N'Đang làm việc')
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [QuyenTruyCap], [TrangThai]) VALUES (N'BS3', N'1', 1, N'Nghỉ việc')
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [QuyenTruyCap], [TrangThai]) VALUES (N'BS4', N'1', 1, N'Đang làm việc')
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [QuyenTruyCap], [TrangThai]) VALUES (N'BS5', N'1', 1, N'Đang làm việc')
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [QuyenTruyCap], [TrangThai]) VALUES (N'NV1', N'1', 1, N'Đang làm việc')
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [QuyenTruyCap], [TrangThai]) VALUES (N'NV2', N'1', 1, N'Đang làm việc')
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [QuyenTruyCap], [TrangThai]) VALUES (N'NV3', N'1', 1, N'Đang làm việc')
GO
SET IDENTITY_INSERT [dbo].[TongHopChiPhi] ON 

INSERT [dbo].[TongHopChiPhi] ([MaHoaDon], [MaPhieuThuTienTamUng], [MaNhanVien], [ThanhTien], [NgayThanhToan]) VALUES (1, 1, N'NV1', 280000, CAST(N'2022-02-09' AS Date))
SET IDENTITY_INSERT [dbo].[TongHopChiPhi] OFF
GO
ALTER TABLE [dbo].[BacSi]  WITH CHECK ADD FOREIGN KEY([MaBacSi])
REFERENCES [dbo].[TaiKhoan] ([TenDangNhap])
GO
ALTER TABLE [dbo].[BanKe]  WITH CHECK ADD FOREIGN KEY([MaBenhNhan])
REFERENCES [dbo].[BenhNhan] ([MaBenhNhan])
GO
ALTER TABLE [dbo].[BanKe]  WITH CHECK ADD FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[ChiTietBanKe]  WITH CHECK ADD FOREIGN KEY([MaBanKe])
REFERENCES [dbo].[BanKe] ([MaBanKe])
GO
ALTER TABLE [dbo].[ChiTietBanKe]  WITH CHECK ADD FOREIGN KEY([MaDichVu])
REFERENCES [dbo].[DichVu] ([MaDichVu])
GO
ALTER TABLE [dbo].[HoSoBenhAn]  WITH CHECK ADD FOREIGN KEY([MaBacSi])
REFERENCES [dbo].[BacSi] ([MaBacSi])
GO
ALTER TABLE [dbo].[HoSoBenhAn]  WITH CHECK ADD FOREIGN KEY([MaBenhNhan])
REFERENCES [dbo].[BenhNhan] ([MaBenhNhan])
GO
ALTER TABLE [dbo].[HoSoBenhAn]  WITH CHECK ADD FOREIGN KEY([MaBenh])
REFERENCES [dbo].[Benh] ([MaBenh])
GO
ALTER TABLE [dbo].[KetQuaXetNghiem]  WITH CHECK ADD FOREIGN KEY([MaBacSi])
REFERENCES [dbo].[BacSi] ([MaBacSi])
GO
ALTER TABLE [dbo].[KetQuaXetNghiem]  WITH CHECK ADD FOREIGN KEY([MaBanKe], [MaDichVu])
REFERENCES [dbo].[ChiTietBanKe] ([MaBanKe], [MaDichVu])
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[TaiKhoan] ([TenDangNhap])
GO
ALTER TABLE [dbo].[PhieuThuTienTamUng]  WITH CHECK ADD FOREIGN KEY([MaBanKe])
REFERENCES [dbo].[BanKe] ([MaBanKe])
GO
ALTER TABLE [dbo].[PhieuThuTienTamUng]  WITH CHECK ADD FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[TongHopChiPhi]  WITH CHECK ADD FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[TongHopChiPhi]  WITH CHECK ADD FOREIGN KEY([MaPhieuThuTienTamUng])
REFERENCES [dbo].[PhieuThuTienTamUng] ([MaPhieuThuTienTamUng])
GO
USE [master]
GO
ALTER DATABASE [QLPK] SET  READ_WRITE 
GO
