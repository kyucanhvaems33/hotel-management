USE [master]
GO
/****** Object:  Database [QLKS]    Script Date: 18/07/2022 2:10:42 PM ******/
CREATE DATABASE [QLKS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLKS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QLKS.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLKS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QLKS_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLKS] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLKS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLKS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLKS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLKS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLKS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLKS] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLKS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLKS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLKS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLKS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLKS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLKS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLKS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLKS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLKS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLKS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLKS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLKS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLKS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLKS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLKS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLKS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLKS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLKS] SET RECOVERY FULL 
GO
ALTER DATABASE [QLKS] SET  MULTI_USER 
GO
ALTER DATABASE [QLKS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLKS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLKS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLKS] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QLKS] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLKS', N'ON'
GO
USE [QLKS]
GO
/****** Object:  Table [dbo].[ChiTietSDDV]    Script Date: 18/07/2022 2:10:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietSDDV](
	[MaChiTiet] [int] IDENTITY(1,1) NOT NULL,
	[SoPhieuDV] [int] NOT NULL,
	[MaDV] [int] NOT NULL,
	[SL] [int] NOT NULL,
 CONSTRAINT [PK_ChiTietSĐV] PRIMARY KEY CLUSTERED 
(
	[MaChiTiet] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DichVu]    Script Date: 18/07/2022 2:10:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DichVu](
	[MaDV] [int] IDENTITY(1,1) NOT NULL,
	[TenDV] [nchar](50) NOT NULL,
	[DonGia] [money] NOT NULL,
	[MaNV] [int] NULL,
 CONSTRAINT [PK_DichVu] PRIMARY KEY CLUSTERED 
(
	[MaDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 18/07/2022 2:10:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nchar](50) NOT NULL,
	[CCCD] [nchar](15) NOT NULL,
	[DiaChi] [nchar](100) NOT NULL,
	[DienThoai] [nchar](10) NOT NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[listlogintime]    Script Date: 18/07/2022 2:10:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[listlogintime](
	[username] [nchar](50) NOT NULL,
	[login] [smalldatetime] NULL,
	[Logout] [smalldatetime] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 18/07/2022 2:10:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nchar](50) NOT NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Phong]    Script Date: 18/07/2022 2:10:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phong](
	[MaPhong] [nchar](10) NOT NULL,
	[Loai] [nchar](15) NOT NULL,
	[DonGia] [money] NOT NULL,
	[TrangThai] [nchar](10) NOT NULL,
	[MaNV] [int] NULL,
 CONSTRAINT [PK_Phong] PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SDDV]    Script Date: 18/07/2022 2:10:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SDDV](
	[SoPhieuDV] [int] IDENTITY(1,1) NOT NULL,
	[GioCungCap] [smalldatetime] NULL,
	[MaKH] [int] NOT NULL,
	[SoPhieuThue] [int] NOT NULL,
 CONSTRAINT [PK_SDDV] PRIMARY KEY CLUSTERED 
(
	[SoPhieuDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Table_1]    Script Date: 18/07/2022 2:10:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Table_1](
	[test] [int] IDENTITY(1,1) NOT NULL,
	[aa] [nchar](10) NULL,
 CONSTRAINT [PK_Table_1_1] PRIMARY KEY CLUSTERED 
(
	[test] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Thue]    Script Date: 18/07/2022 2:10:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Thue](
	[SoPhieuThue] [int] IDENTITY(1,1) NOT NULL,
	[NgayThue] [smalldatetime] NOT NULL,
	[MaPhong] [nchar](10) NOT NULL,
	[MaKH] [int] NOT NULL,
 CONSTRAINT [PK_Thue] PRIMARY KEY CLUSTERED 
(
	[SoPhieuThue] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TK]    Script Date: 18/07/2022 2:10:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TK](
	[username] [nchar](50) NOT NULL,
	[pass] [nchar](50) NOT NULL,
	[MaNV] [int] NULL,
	[Quyen] [nchar](20) NOT NULL,
 CONSTRAINT [PK_TK] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tra]    Script Date: 18/07/2022 2:10:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tra](
	[SoHoaDon] [int] IDENTITY(1,1) NOT NULL,
	[NgayTra] [smalldatetime] NOT NULL,
	[NgayThue] [smalldatetime] NOT NULL,
	[SoPhieuThue] [int] NOT NULL,
	[MaKH] [int] NOT NULL,
	[MaPhong] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Tra] PRIMARY KEY CLUSTERED 
(
	[SoHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[doanhthu]    Script Date: 18/07/2022 2:10:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[doanhthu] as select Tra.MaPhong, MaKH, NgayThue, NgayTra, cast (case when DATEDIFF(DAY,NgayThue,NgayTra) = 0 then 1 else DATEDIFF(DAY,NgayThue,NgayTra) end as int) as Ngayo,Phong.DonGia,(DonGia * cast (case when DATEDIFF(DAY,NgayThue,NgayTra) = 0 then 1 else DATEDIFF(DAY,NgayThue,NgayTra) end as int)) as tienphong from Tra,Phong where Tra.MaPhong = Phong.MaPhong
GO
/****** Object:  View [dbo].[doanhthu1]    Script Date: 18/07/2022 2:10:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[doanhthu1] as select ChiTietSDDV.MaDV,DichVu.TenDV,SDDV.GioCungCap,DichVu.DonGia,ChiTietSDDV.SL,(DichVu.DonGia*ChiTietSDDV.SL) as thanhtien  from ChiTietSDDV,DichVu,SDDV where ChiTietSDDV.SoPhieuDV = SDDV.SoPhieuDV and ChiTietSDDV.MaDV = DichVu.MaDV
GO
/****** Object:  View [dbo].[phieuchitietsddv]    Script Date: 18/07/2022 2:10:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[phieuchitietsddv] as select SoPhieuDV,DichVu.TenDV,DichVu.DonGia,ChiTietSDDV.SL,(DichVu.DonGia*ChiTietSDDV.SL) as thanhtien from ChiTietSDDV,DichVu where ChiTietSDDV.MaDV = DichVu.MaDV
GO
/****** Object:  View [dbo].[phieusddv]    Script Date: 18/07/2022 2:10:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[phieusddv] as select SoPhieuDV,GioCungCap,SoPhieuThue,KhachHang.HoTen,KhachHang.DiaChi,KhachHang.DienThoai,KhachHang.CCCD from SDDV,KhachHang where SDDV.MaKH = KhachHang.MaKH
GO
/****** Object:  View [dbo].[phieuthue]    Script Date: 18/07/2022 2:10:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[phieuthue] as select Thue.SoPhieuThue,KhachHang.HoTen,KhachHang.DiaChi,KhachHang.DienThoai,KhachHang.CCCD,NgayThue,Thue.MaPhong,Phong.Loai,Phong.TrangThai,Phong.DonGia from Thue,KhachHang,Phong where Thue.MaKH = KhachHang.MaKH and Thue.MaPhong = Phong.MaPhong
GO
/****** Object:  View [dbo].[phieutra]    Script Date: 18/07/2022 2:10:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[phieutra] as select  Tra.SoHoaDon,Tra.SoPhieuThue,KhachHang.HoTen,KhachHang.DiaChi,KhachHang.DienThoai,KhachHang.CCCD,Tra.NgayThue,Tra.NgayTra,cast (case when DATEDIFF(DAY,Tra.NgayThue,Tra.NgayTra) = 0 then 1 else DATEDIFF(DAY,Tra.NgayThue,Tra.NgayTra) end as int) as ngayo, Phong.MaPhong, Phong.Loai,Phong.DonGia, (DonGia * cast (case when DATEDIFF(DAY,NgayThue,NgayTra) = 0 then 1 else DATEDIFF(DAY,NgayThue,NgayTra) end as int)) as tienphong from Tra,Phong,KhachHang where Tra.MaKH = KhachHang.MaKH and Tra.MaPhong = Phong.MaPhong
GO
SET IDENTITY_INSERT [dbo].[ChiTietSDDV] ON 

INSERT [dbo].[ChiTietSDDV] ([MaChiTiet], [SoPhieuDV], [MaDV], [SL]) VALUES (1, 1, 7, 3)
INSERT [dbo].[ChiTietSDDV] ([MaChiTiet], [SoPhieuDV], [MaDV], [SL]) VALUES (2, 1, 5, 4)
INSERT [dbo].[ChiTietSDDV] ([MaChiTiet], [SoPhieuDV], [MaDV], [SL]) VALUES (3, 3, 4, 3)
INSERT [dbo].[ChiTietSDDV] ([MaChiTiet], [SoPhieuDV], [MaDV], [SL]) VALUES (4, 3, 7, 4)
INSERT [dbo].[ChiTietSDDV] ([MaChiTiet], [SoPhieuDV], [MaDV], [SL]) VALUES (5, 3, 11, 1)
INSERT [dbo].[ChiTietSDDV] ([MaChiTiet], [SoPhieuDV], [MaDV], [SL]) VALUES (6, 4, 2, 3)
INSERT [dbo].[ChiTietSDDV] ([MaChiTiet], [SoPhieuDV], [MaDV], [SL]) VALUES (7, 4, 6, 4)
INSERT [dbo].[ChiTietSDDV] ([MaChiTiet], [SoPhieuDV], [MaDV], [SL]) VALUES (8, 4, 8, 5)
INSERT [dbo].[ChiTietSDDV] ([MaChiTiet], [SoPhieuDV], [MaDV], [SL]) VALUES (9, 5, 6, 4)
INSERT [dbo].[ChiTietSDDV] ([MaChiTiet], [SoPhieuDV], [MaDV], [SL]) VALUES (10, 5, 8, 5)
INSERT [dbo].[ChiTietSDDV] ([MaChiTiet], [SoPhieuDV], [MaDV], [SL]) VALUES (11, 5, 4, 6)
INSERT [dbo].[ChiTietSDDV] ([MaChiTiet], [SoPhieuDV], [MaDV], [SL]) VALUES (12, 6, 5, 4)
INSERT [dbo].[ChiTietSDDV] ([MaChiTiet], [SoPhieuDV], [MaDV], [SL]) VALUES (13, 6, 7, 5)
INSERT [dbo].[ChiTietSDDV] ([MaChiTiet], [SoPhieuDV], [MaDV], [SL]) VALUES (14, 6, 8, 6)
INSERT [dbo].[ChiTietSDDV] ([MaChiTiet], [SoPhieuDV], [MaDV], [SL]) VALUES (15, 7, 7, 3)
INSERT [dbo].[ChiTietSDDV] ([MaChiTiet], [SoPhieuDV], [MaDV], [SL]) VALUES (16, 7, 8, 4)
INSERT [dbo].[ChiTietSDDV] ([MaChiTiet], [SoPhieuDV], [MaDV], [SL]) VALUES (17, 8, 6, 3)
INSERT [dbo].[ChiTietSDDV] ([MaChiTiet], [SoPhieuDV], [MaDV], [SL]) VALUES (18, 8, 8, 5)
INSERT [dbo].[ChiTietSDDV] ([MaChiTiet], [SoPhieuDV], [MaDV], [SL]) VALUES (19, 8, 9, 6)
INSERT [dbo].[ChiTietSDDV] ([MaChiTiet], [SoPhieuDV], [MaDV], [SL]) VALUES (20, 9, 6, 3)
INSERT [dbo].[ChiTietSDDV] ([MaChiTiet], [SoPhieuDV], [MaDV], [SL]) VALUES (21, 9, 5, 4)
INSERT [dbo].[ChiTietSDDV] ([MaChiTiet], [SoPhieuDV], [MaDV], [SL]) VALUES (22, 10, 7, 3)
INSERT [dbo].[ChiTietSDDV] ([MaChiTiet], [SoPhieuDV], [MaDV], [SL]) VALUES (23, 10, 8, 4)
INSERT [dbo].[ChiTietSDDV] ([MaChiTiet], [SoPhieuDV], [MaDV], [SL]) VALUES (24, 11, 6, 3)
INSERT [dbo].[ChiTietSDDV] ([MaChiTiet], [SoPhieuDV], [MaDV], [SL]) VALUES (25, 11, 8, 4)
INSERT [dbo].[ChiTietSDDV] ([MaChiTiet], [SoPhieuDV], [MaDV], [SL]) VALUES (26, 11, 9, 5)
INSERT [dbo].[ChiTietSDDV] ([MaChiTiet], [SoPhieuDV], [MaDV], [SL]) VALUES (27, 12, 4, 3)
INSERT [dbo].[ChiTietSDDV] ([MaChiTiet], [SoPhieuDV], [MaDV], [SL]) VALUES (28, 12, 6, 5)
INSERT [dbo].[ChiTietSDDV] ([MaChiTiet], [SoPhieuDV], [MaDV], [SL]) VALUES (29, 12, 8, 6)
INSERT [dbo].[ChiTietSDDV] ([MaChiTiet], [SoPhieuDV], [MaDV], [SL]) VALUES (30, 13, 7, 3)
INSERT [dbo].[ChiTietSDDV] ([MaChiTiet], [SoPhieuDV], [MaDV], [SL]) VALUES (31, 13, 8, 5)
INSERT [dbo].[ChiTietSDDV] ([MaChiTiet], [SoPhieuDV], [MaDV], [SL]) VALUES (32, 13, 10, 6)
INSERT [dbo].[ChiTietSDDV] ([MaChiTiet], [SoPhieuDV], [MaDV], [SL]) VALUES (33, 14, 6, 3)
INSERT [dbo].[ChiTietSDDV] ([MaChiTiet], [SoPhieuDV], [MaDV], [SL]) VALUES (34, 14, 8, 5)
INSERT [dbo].[ChiTietSDDV] ([MaChiTiet], [SoPhieuDV], [MaDV], [SL]) VALUES (35, 14, 9, 6)
INSERT [dbo].[ChiTietSDDV] ([MaChiTiet], [SoPhieuDV], [MaDV], [SL]) VALUES (36, 14, 2, 1)
INSERT [dbo].[ChiTietSDDV] ([MaChiTiet], [SoPhieuDV], [MaDV], [SL]) VALUES (37, 15, 6, 5)
INSERT [dbo].[ChiTietSDDV] ([MaChiTiet], [SoPhieuDV], [MaDV], [SL]) VALUES (38, 15, 9, 7)
INSERT [dbo].[ChiTietSDDV] ([MaChiTiet], [SoPhieuDV], [MaDV], [SL]) VALUES (39, 15, 5, 8)
INSERT [dbo].[ChiTietSDDV] ([MaChiTiet], [SoPhieuDV], [MaDV], [SL]) VALUES (40, 16, 7, 4)
INSERT [dbo].[ChiTietSDDV] ([MaChiTiet], [SoPhieuDV], [MaDV], [SL]) VALUES (41, 16, 8, 6)
INSERT [dbo].[ChiTietSDDV] ([MaChiTiet], [SoPhieuDV], [MaDV], [SL]) VALUES (42, 16, 9, 7)
INSERT [dbo].[ChiTietSDDV] ([MaChiTiet], [SoPhieuDV], [MaDV], [SL]) VALUES (43, 16, 5, 8)
INSERT [dbo].[ChiTietSDDV] ([MaChiTiet], [SoPhieuDV], [MaDV], [SL]) VALUES (44, 17, 6, 9)
INSERT [dbo].[ChiTietSDDV] ([MaChiTiet], [SoPhieuDV], [MaDV], [SL]) VALUES (45, 17, 8, 6)
INSERT [dbo].[ChiTietSDDV] ([MaChiTiet], [SoPhieuDV], [MaDV], [SL]) VALUES (46, 17, 9, 7)
INSERT [dbo].[ChiTietSDDV] ([MaChiTiet], [SoPhieuDV], [MaDV], [SL]) VALUES (47, 19, 3, 3)
INSERT [dbo].[ChiTietSDDV] ([MaChiTiet], [SoPhieuDV], [MaDV], [SL]) VALUES (48, 19, 7, 5)
INSERT [dbo].[ChiTietSDDV] ([MaChiTiet], [SoPhieuDV], [MaDV], [SL]) VALUES (49, 19, 9, 5)
INSERT [dbo].[ChiTietSDDV] ([MaChiTiet], [SoPhieuDV], [MaDV], [SL]) VALUES (50, 20, 6, 2)
INSERT [dbo].[ChiTietSDDV] ([MaChiTiet], [SoPhieuDV], [MaDV], [SL]) VALUES (51, 20, 8, 2)
SET IDENTITY_INSERT [dbo].[ChiTietSDDV] OFF
SET IDENTITY_INSERT [dbo].[DichVu] ON 

INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [MaNV]) VALUES (1, N'Trà 0 độ                                          ', 18000.0000, 1)
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [MaNV]) VALUES (2, N'Trà ô long                                        ', 18000.0000, 1)
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [MaNV]) VALUES (3, N'DR.Thanh                                          ', 18000.0000, 1)
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [MaNV]) VALUES (4, N'STING                                             ', 18000.0000, 1)
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [MaNV]) VALUES (5, N'RED BULL                                          ', 20000.0000, 1)
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [MaNV]) VALUES (6, N'Trà C2                                            ', 15000.0000, 1)
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [MaNV]) VALUES (7, N'COCA COLA                                         ', 15000.0000, 1)
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [MaNV]) VALUES (8, N'PEPSI                                             ', 15000.0000, 1)
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [MaNV]) VALUES (9, N'Nước suối                                         ', 15000.0000, 1)
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [MaNV]) VALUES (10, N'Chanh muối                                        ', 15000.0000, 1)
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [MaNV]) VALUES (11, N'Giặt là                                           ', 50000.0000, 1)
SET IDENTITY_INSERT [dbo].[DichVu] OFF
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([MaKH], [HoTen], [CCCD], [DiaChi], [DienThoai]) VALUES (1, N'Vũ Hoài Nam                                       ', N'0123456789     ', N'Hải Phòng                                                                                           ', N'0916723476')
INSERT [dbo].[KhachHang] ([MaKH], [HoTen], [CCCD], [DiaChi], [DienThoai]) VALUES (2, N'Vũ Huy Hoàng                                      ', N'9876543210     ', N'Hải Phòng                                                                                           ', N'0916723479')
INSERT [dbo].[KhachHang] ([MaKH], [HoTen], [CCCD], [DiaChi], [DienThoai]) VALUES (3, N'Lưu Thanh Hoàng                                   ', N'442342344      ', N'Hà Nội                                                                                              ', N'423423423 ')
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
INSERT [dbo].[listlogintime] ([username], [login], [Logout]) VALUES (N'admin                                             ', CAST(N'2022-05-29 20:40:00' AS SmallDateTime), CAST(N'2022-07-08 09:54:00' AS SmallDateTime))
INSERT [dbo].[listlogintime] ([username], [login], [Logout]) VALUES (N'thang                                             ', CAST(N'2022-05-29 20:41:00' AS SmallDateTime), CAST(N'2022-05-30 08:17:00' AS SmallDateTime))
INSERT [dbo].[listlogintime] ([username], [login], [Logout]) VALUES (N'admin                                             ', CAST(N'2022-05-29 20:47:00' AS SmallDateTime), CAST(N'2022-07-08 09:54:00' AS SmallDateTime))
INSERT [dbo].[listlogintime] ([username], [login], [Logout]) VALUES (N'thang                                             ', CAST(N'2022-05-29 20:47:00' AS SmallDateTime), CAST(N'2022-05-30 08:17:00' AS SmallDateTime))
INSERT [dbo].[listlogintime] ([username], [login], [Logout]) VALUES (N'thang                                             ', CAST(N'2022-05-29 20:48:00' AS SmallDateTime), CAST(N'2022-05-30 08:17:00' AS SmallDateTime))
INSERT [dbo].[listlogintime] ([username], [login], [Logout]) VALUES (N'admin                                             ', CAST(N'2022-05-29 20:49:00' AS SmallDateTime), CAST(N'2022-07-08 09:54:00' AS SmallDateTime))
INSERT [dbo].[listlogintime] ([username], [login], [Logout]) VALUES (N'admin                                             ', CAST(N'2022-05-29 20:51:00' AS SmallDateTime), CAST(N'2022-07-08 09:54:00' AS SmallDateTime))
INSERT [dbo].[listlogintime] ([username], [login], [Logout]) VALUES (N'admin                                             ', CAST(N'2022-05-29 20:53:00' AS SmallDateTime), CAST(N'2022-07-08 09:54:00' AS SmallDateTime))
INSERT [dbo].[listlogintime] ([username], [login], [Logout]) VALUES (N'admin                                             ', CAST(N'2022-05-29 20:54:00' AS SmallDateTime), CAST(N'2022-07-08 09:54:00' AS SmallDateTime))
INSERT [dbo].[listlogintime] ([username], [login], [Logout]) VALUES (N'thang                                             ', CAST(N'2022-05-29 22:45:00' AS SmallDateTime), CAST(N'2022-05-30 08:17:00' AS SmallDateTime))
INSERT [dbo].[listlogintime] ([username], [login], [Logout]) VALUES (N'thang                                             ', CAST(N'2022-05-29 22:56:00' AS SmallDateTime), CAST(N'2022-05-30 08:17:00' AS SmallDateTime))
INSERT [dbo].[listlogintime] ([username], [login], [Logout]) VALUES (N'thang                                             ', CAST(N'2022-05-30 08:17:00' AS SmallDateTime), CAST(N'2022-05-30 08:17:00' AS SmallDateTime))
INSERT [dbo].[listlogintime] ([username], [login], [Logout]) VALUES (N'thang                                             ', CAST(N'2022-05-30 08:17:00' AS SmallDateTime), CAST(N'2022-05-30 08:17:00' AS SmallDateTime))
INSERT [dbo].[listlogintime] ([username], [login], [Logout]) VALUES (N'admin                                             ', CAST(N'2022-05-30 08:17:00' AS SmallDateTime), CAST(N'2022-07-08 09:54:00' AS SmallDateTime))
INSERT [dbo].[listlogintime] ([username], [login], [Logout]) VALUES (N'admin                                             ', CAST(N'2022-05-30 08:19:00' AS SmallDateTime), CAST(N'2022-07-08 09:54:00' AS SmallDateTime))
INSERT [dbo].[listlogintime] ([username], [login], [Logout]) VALUES (N'admin                                             ', CAST(N'2022-05-30 08:21:00' AS SmallDateTime), CAST(N'2022-07-08 09:54:00' AS SmallDateTime))
INSERT [dbo].[listlogintime] ([username], [login], [Logout]) VALUES (N'admin                                             ', CAST(N'2022-05-30 08:21:00' AS SmallDateTime), CAST(N'2022-07-08 09:54:00' AS SmallDateTime))
INSERT [dbo].[listlogintime] ([username], [login], [Logout]) VALUES (N'admin                                             ', CAST(N'2022-05-30 08:22:00' AS SmallDateTime), CAST(N'2022-07-08 09:54:00' AS SmallDateTime))
INSERT [dbo].[listlogintime] ([username], [login], [Logout]) VALUES (N'admin                                             ', CAST(N'2022-05-30 08:24:00' AS SmallDateTime), CAST(N'2022-07-08 09:54:00' AS SmallDateTime))
INSERT [dbo].[listlogintime] ([username], [login], [Logout]) VALUES (N'admin                                             ', CAST(N'2022-05-30 08:25:00' AS SmallDateTime), CAST(N'2022-07-08 09:54:00' AS SmallDateTime))
INSERT [dbo].[listlogintime] ([username], [login], [Logout]) VALUES (N'admin                                             ', CAST(N'2022-05-30 08:26:00' AS SmallDateTime), CAST(N'2022-07-08 09:54:00' AS SmallDateTime))
INSERT [dbo].[listlogintime] ([username], [login], [Logout]) VALUES (N'admin                                             ', CAST(N'2022-05-30 08:27:00' AS SmallDateTime), CAST(N'2022-07-08 09:54:00' AS SmallDateTime))
INSERT [dbo].[listlogintime] ([username], [login], [Logout]) VALUES (N'admin                                             ', CAST(N'2022-05-30 08:28:00' AS SmallDateTime), CAST(N'2022-07-08 09:54:00' AS SmallDateTime))
INSERT [dbo].[listlogintime] ([username], [login], [Logout]) VALUES (N'admin                                             ', CAST(N'2022-05-30 08:29:00' AS SmallDateTime), CAST(N'2022-07-08 09:54:00' AS SmallDateTime))
INSERT [dbo].[listlogintime] ([username], [login], [Logout]) VALUES (N'admin                                             ', CAST(N'2022-05-30 08:30:00' AS SmallDateTime), CAST(N'2022-07-08 09:54:00' AS SmallDateTime))
INSERT [dbo].[listlogintime] ([username], [login], [Logout]) VALUES (N'admin                                             ', CAST(N'2022-05-30 08:31:00' AS SmallDateTime), CAST(N'2022-07-08 09:54:00' AS SmallDateTime))
INSERT [dbo].[listlogintime] ([username], [login], [Logout]) VALUES (N'admin                                             ', CAST(N'2022-05-30 09:26:00' AS SmallDateTime), CAST(N'2022-07-08 09:54:00' AS SmallDateTime))
INSERT [dbo].[listlogintime] ([username], [login], [Logout]) VALUES (N'admin                                             ', CAST(N'2022-05-30 20:06:00' AS SmallDateTime), CAST(N'2022-07-08 09:54:00' AS SmallDateTime))
INSERT [dbo].[listlogintime] ([username], [login], [Logout]) VALUES (N'admin                                             ', CAST(N'2022-06-09 15:55:00' AS SmallDateTime), CAST(N'2022-07-08 09:54:00' AS SmallDateTime))
INSERT [dbo].[listlogintime] ([username], [login], [Logout]) VALUES (N'admin                                             ', CAST(N'2022-07-08 09:51:00' AS SmallDateTime), CAST(N'2022-07-08 09:54:00' AS SmallDateTime))
INSERT [dbo].[listlogintime] ([username], [login], [Logout]) VALUES (N'admin                                             ', CAST(N'2022-05-29 22:29:00' AS SmallDateTime), CAST(N'2022-07-08 09:54:00' AS SmallDateTime))
INSERT [dbo].[listlogintime] ([username], [login], [Logout]) VALUES (N'admin                                             ', CAST(N'2022-05-29 22:30:00' AS SmallDateTime), CAST(N'2022-07-08 09:54:00' AS SmallDateTime))
INSERT [dbo].[listlogintime] ([username], [login], [Logout]) VALUES (N'admin                                             ', CAST(N'2022-05-29 22:33:00' AS SmallDateTime), CAST(N'2022-07-08 09:54:00' AS SmallDateTime))
INSERT [dbo].[listlogintime] ([username], [login], [Logout]) VALUES (N'thang                                             ', CAST(N'2022-05-29 22:36:00' AS SmallDateTime), CAST(N'2022-05-30 08:17:00' AS SmallDateTime))
SET IDENTITY_INSERT [dbo].[NhanVien] ON 

INSERT [dbo].[NhanVien] ([MaNV], [HoTen]) VALUES (1, N'admin                                             ')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen]) VALUES (2, N'Bùi Đức Thắng                                     ')
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
INSERT [dbo].[Phong] ([MaPhong], [Loai], [DonGia], [TrangThai], [MaNV]) VALUES (N'H102      ', N'VIP ĐÔI        ', 1000000.0000, N'BẬN       ', 1)
INSERT [dbo].[Phong] ([MaPhong], [Loai], [DonGia], [TrangThai], [MaNV]) VALUES (N'H103      ', N'THƯỜNG ĐƠN     ', 400000.0000, N'RẢNH      ', 1)
INSERT [dbo].[Phong] ([MaPhong], [Loai], [DonGia], [TrangThai], [MaNV]) VALUES (N'H104      ', N'THƯỜNG ĐÔI     ', 600000.0000, N'RẢNH      ', 1)
INSERT [dbo].[Phong] ([MaPhong], [Loai], [DonGia], [TrangThai], [MaNV]) VALUES (N'H105      ', N'VIP ĐƠN        ', 800000.0000, N'BẬN       ', 1)
SET IDENTITY_INSERT [dbo].[SDDV] ON 

INSERT [dbo].[SDDV] ([SoPhieuDV], [GioCungCap], [MaKH], [SoPhieuThue]) VALUES (1, CAST(N'2022-05-22 15:34:00' AS SmallDateTime), 2, 3)
INSERT [dbo].[SDDV] ([SoPhieuDV], [GioCungCap], [MaKH], [SoPhieuThue]) VALUES (3, CAST(N'2022-05-29 14:47:00' AS SmallDateTime), 3, 22)
INSERT [dbo].[SDDV] ([SoPhieuDV], [GioCungCap], [MaKH], [SoPhieuThue]) VALUES (4, CAST(N'2022-05-29 15:28:00' AS SmallDateTime), 3, 22)
INSERT [dbo].[SDDV] ([SoPhieuDV], [GioCungCap], [MaKH], [SoPhieuThue]) VALUES (5, CAST(N'2022-05-29 15:29:00' AS SmallDateTime), 3, 22)
INSERT [dbo].[SDDV] ([SoPhieuDV], [GioCungCap], [MaKH], [SoPhieuThue]) VALUES (6, CAST(N'2022-05-29 15:31:00' AS SmallDateTime), 2, 3)
INSERT [dbo].[SDDV] ([SoPhieuDV], [GioCungCap], [MaKH], [SoPhieuThue]) VALUES (7, CAST(N'2022-05-29 15:36:00' AS SmallDateTime), 3, 22)
INSERT [dbo].[SDDV] ([SoPhieuDV], [GioCungCap], [MaKH], [SoPhieuThue]) VALUES (8, CAST(N'2022-05-29 15:39:00' AS SmallDateTime), 3, 22)
INSERT [dbo].[SDDV] ([SoPhieuDV], [GioCungCap], [MaKH], [SoPhieuThue]) VALUES (9, CAST(N'2022-05-29 15:40:00' AS SmallDateTime), 3, 22)
INSERT [dbo].[SDDV] ([SoPhieuDV], [GioCungCap], [MaKH], [SoPhieuThue]) VALUES (10, CAST(N'2022-05-29 15:42:00' AS SmallDateTime), 3, 22)
INSERT [dbo].[SDDV] ([SoPhieuDV], [GioCungCap], [MaKH], [SoPhieuThue]) VALUES (11, CAST(N'2022-05-29 17:54:00' AS SmallDateTime), 3, 22)
INSERT [dbo].[SDDV] ([SoPhieuDV], [GioCungCap], [MaKH], [SoPhieuThue]) VALUES (12, CAST(N'2022-05-29 18:02:00' AS SmallDateTime), 2, 3)
INSERT [dbo].[SDDV] ([SoPhieuDV], [GioCungCap], [MaKH], [SoPhieuThue]) VALUES (13, CAST(N'2022-05-29 18:03:00' AS SmallDateTime), 3, 22)
INSERT [dbo].[SDDV] ([SoPhieuDV], [GioCungCap], [MaKH], [SoPhieuThue]) VALUES (14, CAST(N'2022-05-29 18:06:00' AS SmallDateTime), 3, 22)
INSERT [dbo].[SDDV] ([SoPhieuDV], [GioCungCap], [MaKH], [SoPhieuThue]) VALUES (15, CAST(N'2022-05-29 18:06:00' AS SmallDateTime), 3, 22)
INSERT [dbo].[SDDV] ([SoPhieuDV], [GioCungCap], [MaKH], [SoPhieuThue]) VALUES (16, CAST(N'2022-05-29 18:09:00' AS SmallDateTime), 3, 22)
INSERT [dbo].[SDDV] ([SoPhieuDV], [GioCungCap], [MaKH], [SoPhieuThue]) VALUES (17, CAST(N'2022-05-29 18:12:00' AS SmallDateTime), 3, 22)
INSERT [dbo].[SDDV] ([SoPhieuDV], [GioCungCap], [MaKH], [SoPhieuThue]) VALUES (19, CAST(N'2022-05-30 09:27:00' AS SmallDateTime), 3, 24)
INSERT [dbo].[SDDV] ([SoPhieuDV], [GioCungCap], [MaKH], [SoPhieuThue]) VALUES (20, CAST(N'2022-05-30 09:28:00' AS SmallDateTime), 3, 24)
SET IDENTITY_INSERT [dbo].[SDDV] OFF
SET IDENTITY_INSERT [dbo].[Thue] ON 

INSERT [dbo].[Thue] ([SoPhieuThue], [NgayThue], [MaPhong], [MaKH]) VALUES (1, CAST(N'2022-05-21 14:26:00' AS SmallDateTime), N'H102      ', 1)
INSERT [dbo].[Thue] ([SoPhieuThue], [NgayThue], [MaPhong], [MaKH]) VALUES (2, CAST(N'2022-05-21 20:16:00' AS SmallDateTime), N'H103      ', 2)
INSERT [dbo].[Thue] ([SoPhieuThue], [NgayThue], [MaPhong], [MaKH]) VALUES (3, CAST(N'2022-05-21 22:08:00' AS SmallDateTime), N'H105      ', 2)
INSERT [dbo].[Thue] ([SoPhieuThue], [NgayThue], [MaPhong], [MaKH]) VALUES (4, CAST(N'2022-05-29 10:23:00' AS SmallDateTime), N'H104      ', 3)
INSERT [dbo].[Thue] ([SoPhieuThue], [NgayThue], [MaPhong], [MaKH]) VALUES (5, CAST(N'2022-05-29 10:27:00' AS SmallDateTime), N'H102      ', 3)
INSERT [dbo].[Thue] ([SoPhieuThue], [NgayThue], [MaPhong], [MaKH]) VALUES (6, CAST(N'2022-05-29 10:28:00' AS SmallDateTime), N'H102      ', 3)
INSERT [dbo].[Thue] ([SoPhieuThue], [NgayThue], [MaPhong], [MaKH]) VALUES (7, CAST(N'2022-05-29 10:31:00' AS SmallDateTime), N'H103      ', 3)
INSERT [dbo].[Thue] ([SoPhieuThue], [NgayThue], [MaPhong], [MaKH]) VALUES (8, CAST(N'2022-05-29 10:32:00' AS SmallDateTime), N'H103      ', 1)
INSERT [dbo].[Thue] ([SoPhieuThue], [NgayThue], [MaPhong], [MaKH]) VALUES (9, CAST(N'2022-05-29 10:42:00' AS SmallDateTime), N'H103      ', 3)
INSERT [dbo].[Thue] ([SoPhieuThue], [NgayThue], [MaPhong], [MaKH]) VALUES (10, CAST(N'2022-05-29 10:44:00' AS SmallDateTime), N'H103      ', 3)
INSERT [dbo].[Thue] ([SoPhieuThue], [NgayThue], [MaPhong], [MaKH]) VALUES (11, CAST(N'2022-05-29 11:21:00' AS SmallDateTime), N'H103      ', 3)
INSERT [dbo].[Thue] ([SoPhieuThue], [NgayThue], [MaPhong], [MaKH]) VALUES (12, CAST(N'2022-05-29 12:21:00' AS SmallDateTime), N'H103      ', 2)
INSERT [dbo].[Thue] ([SoPhieuThue], [NgayThue], [MaPhong], [MaKH]) VALUES (13, CAST(N'2022-05-29 12:33:00' AS SmallDateTime), N'H104      ', 1)
INSERT [dbo].[Thue] ([SoPhieuThue], [NgayThue], [MaPhong], [MaKH]) VALUES (14, CAST(N'2022-05-29 13:17:00' AS SmallDateTime), N'H104      ', 3)
INSERT [dbo].[Thue] ([SoPhieuThue], [NgayThue], [MaPhong], [MaKH]) VALUES (15, CAST(N'2022-05-29 13:18:00' AS SmallDateTime), N'H104      ', 2)
INSERT [dbo].[Thue] ([SoPhieuThue], [NgayThue], [MaPhong], [MaKH]) VALUES (16, CAST(N'2022-05-29 13:19:00' AS SmallDateTime), N'H104      ', 3)
INSERT [dbo].[Thue] ([SoPhieuThue], [NgayThue], [MaPhong], [MaKH]) VALUES (17, CAST(N'2022-05-29 13:21:00' AS SmallDateTime), N'H104      ', 3)
INSERT [dbo].[Thue] ([SoPhieuThue], [NgayThue], [MaPhong], [MaKH]) VALUES (18, CAST(N'2022-05-29 13:23:00' AS SmallDateTime), N'H102      ', 3)
INSERT [dbo].[Thue] ([SoPhieuThue], [NgayThue], [MaPhong], [MaKH]) VALUES (19, CAST(N'2022-05-29 13:25:00' AS SmallDateTime), N'H102      ', 3)
INSERT [dbo].[Thue] ([SoPhieuThue], [NgayThue], [MaPhong], [MaKH]) VALUES (20, CAST(N'2022-05-29 13:26:00' AS SmallDateTime), N'H103      ', 1)
INSERT [dbo].[Thue] ([SoPhieuThue], [NgayThue], [MaPhong], [MaKH]) VALUES (21, CAST(N'2022-05-29 13:27:00' AS SmallDateTime), N'H102      ', 2)
INSERT [dbo].[Thue] ([SoPhieuThue], [NgayThue], [MaPhong], [MaKH]) VALUES (22, CAST(N'2022-05-29 14:45:00' AS SmallDateTime), N'H104      ', 3)
INSERT [dbo].[Thue] ([SoPhieuThue], [NgayThue], [MaPhong], [MaKH]) VALUES (23, CAST(N'2022-05-29 20:18:00' AS SmallDateTime), N'H102      ', 3)
INSERT [dbo].[Thue] ([SoPhieuThue], [NgayThue], [MaPhong], [MaKH]) VALUES (24, CAST(N'2022-05-29 20:20:00' AS SmallDateTime), N'H102      ', 3)
INSERT [dbo].[Thue] ([SoPhieuThue], [NgayThue], [MaPhong], [MaKH]) VALUES (25, CAST(N'2022-05-29 22:50:00' AS SmallDateTime), N'H103      ', 1)
INSERT [dbo].[Thue] ([SoPhieuThue], [NgayThue], [MaPhong], [MaKH]) VALUES (26, CAST(N'2022-05-30 09:26:00' AS SmallDateTime), N'H104      ', 1)
SET IDENTITY_INSERT [dbo].[Thue] OFF
INSERT [dbo].[TK] ([username], [pass], [MaNV], [Quyen]) VALUES (N'admin                                             ', N'admin                                             ', 1, N'ADMIN               ')
INSERT [dbo].[TK] ([username], [pass], [MaNV], [Quyen]) VALUES (N'hoang                                             ', N'hoang                                             ', 2, N'NHÂN VIÊN           ')
INSERT [dbo].[TK] ([username], [pass], [MaNV], [Quyen]) VALUES (N'thang                                             ', N'thang                                             ', 2, N'NHÂN VIÊN           ')
SET IDENTITY_INSERT [dbo].[Tra] ON 

INSERT [dbo].[Tra] ([SoHoaDon], [NgayTra], [NgayThue], [SoPhieuThue], [MaKH], [MaPhong]) VALUES (1, CAST(N'2022-05-21 21:48:00' AS SmallDateTime), CAST(N'2022-05-21 14:26:00' AS SmallDateTime), 1, 1, N'H102      ')
INSERT [dbo].[Tra] ([SoHoaDon], [NgayTra], [NgayThue], [SoPhieuThue], [MaKH], [MaPhong]) VALUES (2, CAST(N'2022-05-21 22:08:00' AS SmallDateTime), CAST(N'2022-05-21 20:16:00' AS SmallDateTime), 2, 2, N'H103      ')
INSERT [dbo].[Tra] ([SoHoaDon], [NgayTra], [NgayThue], [SoPhieuThue], [MaKH], [MaPhong]) VALUES (3, CAST(N'2022-05-29 10:25:00' AS SmallDateTime), CAST(N'2022-05-29 10:23:00' AS SmallDateTime), 4, 3, N'H104      ')
INSERT [dbo].[Tra] ([SoHoaDon], [NgayTra], [NgayThue], [SoPhieuThue], [MaKH], [MaPhong]) VALUES (4, CAST(N'2022-05-29 10:27:00' AS SmallDateTime), CAST(N'2022-05-29 10:27:00' AS SmallDateTime), 5, 3, N'H102      ')
INSERT [dbo].[Tra] ([SoHoaDon], [NgayTra], [NgayThue], [SoPhieuThue], [MaKH], [MaPhong]) VALUES (5, CAST(N'2022-05-29 10:31:00' AS SmallDateTime), CAST(N'2022-05-29 10:28:00' AS SmallDateTime), 6, 3, N'H102      ')
INSERT [dbo].[Tra] ([SoHoaDon], [NgayTra], [NgayThue], [SoPhieuThue], [MaKH], [MaPhong]) VALUES (6, CAST(N'2022-05-29 10:32:00' AS SmallDateTime), CAST(N'2022-05-29 10:31:00' AS SmallDateTime), 7, 3, N'H103      ')
INSERT [dbo].[Tra] ([SoHoaDon], [NgayTra], [NgayThue], [SoPhieuThue], [MaKH], [MaPhong]) VALUES (7, CAST(N'2022-05-29 10:42:00' AS SmallDateTime), CAST(N'2022-05-29 10:32:00' AS SmallDateTime), 8, 1, N'H103      ')
INSERT [dbo].[Tra] ([SoHoaDon], [NgayTra], [NgayThue], [SoPhieuThue], [MaKH], [MaPhong]) VALUES (8, CAST(N'2022-05-29 10:43:00' AS SmallDateTime), CAST(N'2022-05-29 10:42:00' AS SmallDateTime), 9, 3, N'H103      ')
INSERT [dbo].[Tra] ([SoHoaDon], [NgayTra], [NgayThue], [SoPhieuThue], [MaKH], [MaPhong]) VALUES (9, CAST(N'2022-05-29 11:21:00' AS SmallDateTime), CAST(N'2022-05-29 10:44:00' AS SmallDateTime), 10, 3, N'H103      ')
INSERT [dbo].[Tra] ([SoHoaDon], [NgayTra], [NgayThue], [SoPhieuThue], [MaKH], [MaPhong]) VALUES (10, CAST(N'2022-05-29 12:19:00' AS SmallDateTime), CAST(N'2022-05-29 11:21:00' AS SmallDateTime), 11, 3, N'H103      ')
INSERT [dbo].[Tra] ([SoHoaDon], [NgayTra], [NgayThue], [SoPhieuThue], [MaKH], [MaPhong]) VALUES (11, CAST(N'2022-05-29 12:21:00' AS SmallDateTime), CAST(N'2022-05-29 12:21:00' AS SmallDateTime), 12, 2, N'H103      ')
INSERT [dbo].[Tra] ([SoHoaDon], [NgayTra], [NgayThue], [SoPhieuThue], [MaKH], [MaPhong]) VALUES (12, CAST(N'2022-05-29 12:33:00' AS SmallDateTime), CAST(N'2022-05-29 12:33:00' AS SmallDateTime), 13, 1, N'H104      ')
INSERT [dbo].[Tra] ([SoHoaDon], [NgayTra], [NgayThue], [SoPhieuThue], [MaKH], [MaPhong]) VALUES (13, CAST(N'2022-05-29 13:17:00' AS SmallDateTime), CAST(N'2022-05-29 13:17:00' AS SmallDateTime), 14, 3, N'H104      ')
INSERT [dbo].[Tra] ([SoHoaDon], [NgayTra], [NgayThue], [SoPhieuThue], [MaKH], [MaPhong]) VALUES (14, CAST(N'2022-05-29 13:18:00' AS SmallDateTime), CAST(N'2022-05-29 13:18:00' AS SmallDateTime), 15, 2, N'H104      ')
INSERT [dbo].[Tra] ([SoHoaDon], [NgayTra], [NgayThue], [SoPhieuThue], [MaKH], [MaPhong]) VALUES (15, CAST(N'2022-05-29 13:19:00' AS SmallDateTime), CAST(N'2022-05-29 13:19:00' AS SmallDateTime), 16, 3, N'H104      ')
INSERT [dbo].[Tra] ([SoHoaDon], [NgayTra], [NgayThue], [SoPhieuThue], [MaKH], [MaPhong]) VALUES (16, CAST(N'2022-05-29 13:21:00' AS SmallDateTime), CAST(N'2022-05-29 13:21:00' AS SmallDateTime), 17, 3, N'H104      ')
INSERT [dbo].[Tra] ([SoHoaDon], [NgayTra], [NgayThue], [SoPhieuThue], [MaKH], [MaPhong]) VALUES (17, CAST(N'2022-05-29 13:23:00' AS SmallDateTime), CAST(N'2022-05-29 13:23:00' AS SmallDateTime), 18, 3, N'H102      ')
INSERT [dbo].[Tra] ([SoHoaDon], [NgayTra], [NgayThue], [SoPhieuThue], [MaKH], [MaPhong]) VALUES (18, CAST(N'2022-05-29 13:25:00' AS SmallDateTime), CAST(N'2022-05-29 13:25:00' AS SmallDateTime), 19, 3, N'H102      ')
INSERT [dbo].[Tra] ([SoHoaDon], [NgayTra], [NgayThue], [SoPhieuThue], [MaKH], [MaPhong]) VALUES (19, CAST(N'2022-05-29 13:26:00' AS SmallDateTime), CAST(N'2022-05-29 13:26:00' AS SmallDateTime), 20, 1, N'H103      ')
INSERT [dbo].[Tra] ([SoHoaDon], [NgayTra], [NgayThue], [SoPhieuThue], [MaKH], [MaPhong]) VALUES (20, CAST(N'2022-05-29 13:27:00' AS SmallDateTime), CAST(N'2022-05-29 13:27:00' AS SmallDateTime), 21, 2, N'H102      ')
INSERT [dbo].[Tra] ([SoHoaDon], [NgayTra], [NgayThue], [SoPhieuThue], [MaKH], [MaPhong]) VALUES (21, CAST(N'2022-05-29 20:18:00' AS SmallDateTime), CAST(N'2022-05-29 14:45:00' AS SmallDateTime), 22, 3, N'H104      ')
INSERT [dbo].[Tra] ([SoHoaDon], [NgayTra], [NgayThue], [SoPhieuThue], [MaKH], [MaPhong]) VALUES (22, CAST(N'2022-05-29 20:20:00' AS SmallDateTime), CAST(N'2022-05-29 20:18:00' AS SmallDateTime), 23, 3, N'H102      ')
INSERT [dbo].[Tra] ([SoHoaDon], [NgayTra], [NgayThue], [SoPhieuThue], [MaKH], [MaPhong]) VALUES (23, CAST(N'2022-05-29 22:51:00' AS SmallDateTime), CAST(N'2022-05-29 22:50:00' AS SmallDateTime), 25, 1, N'H103      ')
INSERT [dbo].[Tra] ([SoHoaDon], [NgayTra], [NgayThue], [SoPhieuThue], [MaKH], [MaPhong]) VALUES (24, CAST(N'2022-05-30 09:27:00' AS SmallDateTime), CAST(N'2022-05-30 09:26:00' AS SmallDateTime), 26, 1, N'H104      ')
SET IDENTITY_INSERT [dbo].[Tra] OFF
ALTER TABLE [dbo].[ChiTietSDDV]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietSDDV_DichVu] FOREIGN KEY([MaDV])
REFERENCES [dbo].[DichVu] ([MaDV])
GO
ALTER TABLE [dbo].[ChiTietSDDV] CHECK CONSTRAINT [FK_ChiTietSDDV_DichVu]
GO
ALTER TABLE [dbo].[ChiTietSDDV]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietSDDV_SDDV] FOREIGN KEY([SoPhieuDV])
REFERENCES [dbo].[SDDV] ([SoPhieuDV])
GO
ALTER TABLE [dbo].[ChiTietSDDV] CHECK CONSTRAINT [FK_ChiTietSDDV_SDDV]
GO
ALTER TABLE [dbo].[DichVu]  WITH CHECK ADD  CONSTRAINT [FK_DichVu_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[DichVu] CHECK CONSTRAINT [FK_DichVu_NhanVien]
GO
ALTER TABLE [dbo].[listlogintime]  WITH CHECK ADD  CONSTRAINT [FK_listlogintime_TK] FOREIGN KEY([username])
REFERENCES [dbo].[TK] ([username])
GO
ALTER TABLE [dbo].[listlogintime] CHECK CONSTRAINT [FK_listlogintime_TK]
GO
ALTER TABLE [dbo].[Phong]  WITH CHECK ADD  CONSTRAINT [FK_Phong_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[Phong] CHECK CONSTRAINT [FK_Phong_NhanVien]
GO
ALTER TABLE [dbo].[SDDV]  WITH CHECK ADD  CONSTRAINT [FK_SDDV_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[SDDV] CHECK CONSTRAINT [FK_SDDV_KhachHang]
GO
ALTER TABLE [dbo].[Thue]  WITH CHECK ADD  CONSTRAINT [FK_Thue_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[Thue] CHECK CONSTRAINT [FK_Thue_KhachHang]
GO
ALTER TABLE [dbo].[Thue]  WITH CHECK ADD  CONSTRAINT [FK_Thue_Phong] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[Phong] ([MaPhong])
GO
ALTER TABLE [dbo].[Thue] CHECK CONSTRAINT [FK_Thue_Phong]
GO
ALTER TABLE [dbo].[TK]  WITH CHECK ADD  CONSTRAINT [FK_TK_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[TK] CHECK CONSTRAINT [FK_TK_NhanVien]
GO
ALTER TABLE [dbo].[Tra]  WITH CHECK ADD  CONSTRAINT [FK_Tra_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[Tra] CHECK CONSTRAINT [FK_Tra_KhachHang]
GO
ALTER TABLE [dbo].[Tra]  WITH CHECK ADD  CONSTRAINT [FK_Tra_Phong] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[Phong] ([MaPhong])
GO
ALTER TABLE [dbo].[Tra] CHECK CONSTRAINT [FK_Tra_Phong]
GO
USE [master]
GO
ALTER DATABASE [QLKS] SET  READ_WRITE 
GO
