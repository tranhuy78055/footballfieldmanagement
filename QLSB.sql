USE [master]
GO
/****** Object:  Database [QuanLySanBong]    Script Date: 12/31/2022 4:12:25 PM ******/
CREATE DATABASE [QuanLySanBong]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLySanBong', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS2012\MSSQL\DATA\QuanLySanBong.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLySanBong_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS2012\MSSQL\DATA\QuanLySanBong_log.ldf' , SIZE = 784KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QuanLySanBong] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLySanBong].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLySanBong] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLySanBong] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLySanBong] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLySanBong] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLySanBong] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLySanBong] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QuanLySanBong] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLySanBong] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLySanBong] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLySanBong] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLySanBong] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLySanBong] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLySanBong] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLySanBong] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLySanBong] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLySanBong] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLySanBong] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLySanBong] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLySanBong] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLySanBong] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLySanBong] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLySanBong] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLySanBong] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLySanBong] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLySanBong] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLySanBong] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLySanBong] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLySanBong] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLySanBong] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [QuanLySanBong]
GO
/****** Object:  StoredProcedure [dbo].[THOIGIANDA]    Script Date: 12/31/2022 4:12:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[THOIGIANDA] @MaHd CHAR(10)
AS
DECLARE @GIO FLOAT, @PHUT FLOAT, @GIA FLOAT
SET @GIO=(SELECT DATEPART(HOUR,TGTraSan)-DATEPART(HOUR,TGNhanSan) from HOADON WHERE IdHoaDon=@MaHd)
SET @PHUT= (SELECT DATEPART(MINUTE,TGTraSan)-DATEPART(minute,TGNhanSan) from HOADON where IdHoaDon=@MaHd)
BEGIN
SELECT @GIO+(@PHUT/60)
END
GO
/****** Object:  Table [dbo].[ADDMIN]    Script Date: 12/31/2022 4:12:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ADDMIN](
	[IdAM] [nchar](10) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[SDT] [nchar](20) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nvarchar](5) NULL,
	[Email] [nvarchar](40) NULL,
	[DiaChi] [nvarchar](80) NULL,
 CONSTRAINT [PK_ADDMIN] PRIMARY KEY CLUSTERED 
(
	[IdAM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 12/31/2022 4:12:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[IdHoaDon] [nchar](10) NOT NULL,
	[IdKH] [nchar](10) NULL,
	[IdSan] [nchar](10) NULL,
	[NgayDatSan] [date] NULL,
	[TGNhanSan] [time](7) NULL,
	[TGTraSan] [time](7) NULL,
	[TongTien] [decimal](18, 2) NULL,
	[NgayLap] [date] NULL,
 CONSTRAINT [PK_HOADON] PRIMARY KEY CLUSTERED 
(
	[IdHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 12/31/2022 4:12:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[IdKH] [nchar](10) NOT NULL,
	[Hoten] [nvarchar](30) NULL,
	[GioiTinh] [nvarchar](5) NULL,
	[SDT] [nchar](20) NULL,
	[Email] [nvarchar](40) NULL,
	[DiaChi] [nvarchar](40) NULL,
 CONSTRAINT [PK_KHACHHANG] PRIMARY KEY CLUSTERED 
(
	[IdKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LOAISAN]    Script Date: 12/31/2022 4:12:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAISAN](
	[IdLoaiSan] [nchar](10) NOT NULL,
	[TenLoaiSan] [nvarchar](30) NULL,
	[SoLuongSan] [int] NULL,
	[ThongTin] [nvarchar](30) NULL,
	[Ghichu] [nvarchar](80) NULL,
 CONSTRAINT [PK_LOAISAN] PRIMARY KEY CLUSTERED 
(
	[IdLoaiSan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SAN]    Script Date: 12/31/2022 4:12:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SAN](
	[IdSan] [nchar](10) NOT NULL,
	[IdLoaiSan] [nchar](10) NULL,
	[TenSan] [nvarchar](50) NULL,
	[Gia] [decimal](18, 2) NULL,
	[TrangThai] [nvarchar](20) NULL,
	[MoTa] [nvarchar](80) NULL,
 CONSTRAINT [PK_SAN] PRIMARY KEY CLUSTERED 
(
	[IdSan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 12/31/2022 4:12:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[SDT] [nchar](20) NOT NULL,
	[MatKhau] [varchar](20) NULL,
	[vaitro] [nchar](10) NULL,
 CONSTRAINT [PK_TAIKHOAI] PRIMARY KEY CLUSTERED 
(
	[SDT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[ADDMIN] ([IdAM], [HoTen], [SDT], [NgaySinh], [GioiTinh], [Email], [DiaChi]) VALUES (N'AM001     ', N'Trần Bảo Huy', N'0129313             ', CAST(N'2002-10-10' AS Date), N'Nam', N'tranhuy123@gmail.com', N'TPHCM')
INSERT [dbo].[HOADON] ([IdHoaDon], [IdKH], [IdSan], [NgayDatSan], [TGNhanSan], [TGTraSan], [TongTien], [NgayLap]) VALUES (N'HD001     ', N'KH001     ', N'S001      ', CAST(N'2022-11-11' AS Date), CAST(N'13:12:00' AS Time), CAST(N'14:15:00' AS Time), CAST(210000.00 AS Decimal(18, 2)), CAST(N'2022-10-12' AS Date))
INSERT [dbo].[HOADON] ([IdHoaDon], [IdKH], [IdSan], [NgayDatSan], [TGNhanSan], [TGTraSan], [TongTien], [NgayLap]) VALUES (N'HD002     ', N'KH002     ', N'S002      ', CAST(N'2022-12-11' AS Date), CAST(N'15:00:00' AS Time), CAST(N'16:30:00' AS Time), CAST(200000.00 AS Decimal(18, 2)), CAST(N'2022-10-12' AS Date))
INSERT [dbo].[HOADON] ([IdHoaDon], [IdKH], [IdSan], [NgayDatSan], [TGNhanSan], [TGTraSan], [TongTien], [NgayLap]) VALUES (N'HD003     ', N'KH003     ', N'S001      ', CAST(N'2022-11-11' AS Date), CAST(N'16:30:00' AS Time), CAST(N'18:00:00' AS Time), CAST(300000.00 AS Decimal(18, 2)), CAST(N'2022-11-11' AS Date))
INSERT [dbo].[HOADON] ([IdHoaDon], [IdKH], [IdSan], [NgayDatSan], [TGNhanSan], [TGTraSan], [TongTien], [NgayLap]) VALUES (N'HD004     ', N'KH004     ', N'S002      ', CAST(N'2022-11-11' AS Date), CAST(N'13:00:00' AS Time), CAST(N'14:30:00' AS Time), CAST(200000.00 AS Decimal(18, 2)), CAST(N'2022-11-12' AS Date))
INSERT [dbo].[HOADON] ([IdHoaDon], [IdKH], [IdSan], [NgayDatSan], [TGNhanSan], [TGTraSan], [TongTien], [NgayLap]) VALUES (N'HD005     ', N'KH001     ', N'S001      ', CAST(N'2022-12-28' AS Date), CAST(N'16:30:00' AS Time), CAST(N'18:00:00' AS Time), CAST(300000.00 AS Decimal(18, 2)), CAST(N'2022-11-13' AS Date))
INSERT [dbo].[HOADON] ([IdHoaDon], [IdKH], [IdSan], [NgayDatSan], [TGNhanSan], [TGTraSan], [TongTien], [NgayLap]) VALUES (N'HD006     ', N'KH001     ', N'S001      ', CAST(N'2022-12-29' AS Date), CAST(N'16:30:00' AS Time), CAST(N'22:00:00' AS Time), CAST(1100000.00 AS Decimal(18, 2)), CAST(N'2022-11-14' AS Date))
INSERT [dbo].[HOADON] ([IdHoaDon], [IdKH], [IdSan], [NgayDatSan], [TGNhanSan], [TGTraSan], [TongTien], [NgayLap]) VALUES (N'HD007     ', N'KH001     ', N'S001      ', CAST(N'2022-12-30' AS Date), CAST(N'16:30:00' AS Time), CAST(N'18:30:00' AS Time), CAST(400000.00 AS Decimal(18, 2)), CAST(N'2022-11-15' AS Date))
INSERT [dbo].[HOADON] ([IdHoaDon], [IdKH], [IdSan], [NgayDatSan], [TGNhanSan], [TGTraSan], [TongTien], [NgayLap]) VALUES (N'HD008     ', N'KH001     ', N'S001      ', CAST(N'2022-12-27' AS Date), CAST(N'16:30:00' AS Time), CAST(N'18:00:00' AS Time), CAST(300000.00 AS Decimal(18, 2)), CAST(N'2022-11-15' AS Date))
INSERT [dbo].[HOADON] ([IdHoaDon], [IdKH], [IdSan], [NgayDatSan], [TGNhanSan], [TGTraSan], [TongTien], [NgayLap]) VALUES (N'HD009     ', N'KH001     ', N'S002      ', CAST(N'2022-12-28' AS Date), CAST(N'16:30:00' AS Time), CAST(N'18:00:00' AS Time), CAST(300000.00 AS Decimal(18, 2)), CAST(N'2022-11-15' AS Date))
INSERT [dbo].[HOADON] ([IdHoaDon], [IdKH], [IdSan], [NgayDatSan], [TGNhanSan], [TGTraSan], [TongTien], [NgayLap]) VALUES (N'HD010     ', N'KH001     ', N'S003      ', CAST(N'2022-12-28' AS Date), CAST(N'16:30:00' AS Time), CAST(N'18:00:00' AS Time), CAST(300000.00 AS Decimal(18, 2)), CAST(N'2022-11-16' AS Date))
INSERT [dbo].[HOADON] ([IdHoaDon], [IdKH], [IdSan], [NgayDatSan], [TGNhanSan], [TGTraSan], [TongTien], [NgayLap]) VALUES (N'HD011     ', N'KH001     ', N'S004      ', CAST(N'2022-12-28' AS Date), CAST(N'16:30:00' AS Time), CAST(N'18:00:00' AS Time), CAST(300000.00 AS Decimal(18, 2)), CAST(N'2022-11-17' AS Date))
INSERT [dbo].[HOADON] ([IdHoaDon], [IdKH], [IdSan], [NgayDatSan], [TGNhanSan], [TGTraSan], [TongTien], [NgayLap]) VALUES (N'HD012     ', N'KH001     ', N'S005      ', CAST(N'2022-12-28' AS Date), CAST(N'16:30:00' AS Time), CAST(N'18:30:00' AS Time), CAST(400000.00 AS Decimal(18, 2)), CAST(N'2022-11-18' AS Date))
INSERT [dbo].[HOADON] ([IdHoaDon], [IdKH], [IdSan], [NgayDatSan], [TGNhanSan], [TGTraSan], [TongTien], [NgayLap]) VALUES (N'HD013     ', N'KH001     ', N'S001      ', CAST(N'2022-12-31' AS Date), CAST(N'16:00:00' AS Time), CAST(N'18:00:00' AS Time), CAST(400000.00 AS Decimal(18, 2)), CAST(N'2022-12-31' AS Date))
INSERT [dbo].[HOADON] ([IdHoaDon], [IdKH], [IdSan], [NgayDatSan], [TGNhanSan], [TGTraSan], [TongTien], [NgayLap]) VALUES (N'HD014     ', N'KH002     ', N'S002      ', CAST(N'2022-12-31' AS Date), CAST(N'16:00:00' AS Time), CAST(N'18:00:00' AS Time), CAST(400000.00 AS Decimal(18, 2)), CAST(N'2022-12-31' AS Date))
INSERT [dbo].[HOADON] ([IdHoaDon], [IdKH], [IdSan], [NgayDatSan], [TGNhanSan], [TGTraSan], [TongTien], [NgayLap]) VALUES (N'HD015     ', N'KH002     ', N'S006      ', CAST(N'2022-12-28' AS Date), CAST(N'16:00:00' AS Time), CAST(N'18:00:00' AS Time), CAST(800000.00 AS Decimal(18, 2)), CAST(N'2022-12-31' AS Date))
INSERT [dbo].[HOADON] ([IdHoaDon], [IdKH], [IdSan], [NgayDatSan], [TGNhanSan], [TGTraSan], [TongTien], [NgayLap]) VALUES (N'HD016     ', N'KH002     ', N'S002      ', CAST(N'2022-12-30' AS Date), CAST(N'16:00:00' AS Time), CAST(N'18:00:00' AS Time), CAST(400000.00 AS Decimal(18, 2)), CAST(N'2022-12-31' AS Date))
INSERT [dbo].[KHACHHANG] ([IdKH], [Hoten], [GioiTinh], [SDT], [Email], [DiaChi]) VALUES (N'KH001     ', N'Trần Văn A', N'Nam', N'01234               ', N'taksjf@gmail.com', N'19213')
INSERT [dbo].[KHACHHANG] ([IdKH], [Hoten], [GioiTinh], [SDT], [Email], [DiaChi]) VALUES (N'KH002     ', N'Thành Công', N'Nam', N'001                 ', N'tkasfk@gmail.com', N'Ha noi')
INSERT [dbo].[KHACHHANG] ([IdKH], [Hoten], [GioiTinh], [SDT], [Email], [DiaChi]) VALUES (N'KH003     ', N'Nguyen tuan vu', N'Nam', N'002                 ', N'tkasfk@gmail.com', N'1313')
INSERT [dbo].[KHACHHANG] ([IdKH], [Hoten], [GioiTinh], [SDT], [Email], [DiaChi]) VALUES (N'KH004     ', N'Si Giai Dương', N'Nam', N'003                 ', N'tkasfk@gmail.com', N'1313')
INSERT [dbo].[KHACHHANG] ([IdKH], [Hoten], [GioiTinh], [SDT], [Email], [DiaChi]) VALUES (N'KH005     ', N'Nguyễn Thị Định', N'Nữ', N'0369878455          ', N'dinh@gmail.com', N'tphcm')
INSERT [dbo].[KHACHHANG] ([IdKH], [Hoten], [GioiTinh], [SDT], [Email], [DiaChi]) VALUES (N'KH006     ', N'Nguyễn Văn D', N'Nữ', N'111                 ', N'C@gmail.com', N'tphcm')
INSERT [dbo].[KHACHHANG] ([IdKH], [Hoten], [GioiTinh], [SDT], [Email], [DiaChi]) VALUES (N'KH007     ', NULL, NULL, N'333                 ', NULL, NULL)
INSERT [dbo].[KHACHHANG] ([IdKH], [Hoten], [GioiTinh], [SDT], [Email], [DiaChi]) VALUES (N'KH008     ', NULL, NULL, N'123123              ', NULL, NULL)
INSERT [dbo].[LOAISAN] ([IdLoaiSan], [TenLoaiSan], [SoLuongSan], [ThongTin], [Ghichu]) VALUES (N'LS001     ', N'Sân 5', 5, N'Sân cỏ nhân tạo', N'sân xịn vcl')
INSERT [dbo].[LOAISAN] ([IdLoaiSan], [TenLoaiSan], [SoLuongSan], [ThongTin], [Ghichu]) VALUES (N'LS002     ', N'Sân 7', 5, N'Sân cỏ nhân tạo', N'Sân xịn')
INSERT [dbo].[LOAISAN] ([IdLoaiSan], [TenLoaiSan], [SoLuongSan], [ThongTin], [Ghichu]) VALUES (N'LS003     ', N'Sân 11', 5, N'Sân cỏ nhân tạo', N'Sân xịn')
INSERT [dbo].[SAN] ([IdSan], [IdLoaiSan], [TenSan], [Gia], [TrangThai], [MoTa]) VALUES (N'S001      ', N'LS001     ', N'Sân 5 1', CAST(200000.00 AS Decimal(18, 2)), N'Đang trống', N'Sân đẹp')
INSERT [dbo].[SAN] ([IdSan], [IdLoaiSan], [TenSan], [Gia], [TrangThai], [MoTa]) VALUES (N'S002      ', N'LS002     ', N'Sân 5 2', CAST(200000.00 AS Decimal(18, 2)), N'Đang trống', N'Sân đẹp')
INSERT [dbo].[SAN] ([IdSan], [IdLoaiSan], [TenSan], [Gia], [TrangThai], [MoTa]) VALUES (N'S003      ', N'LS001     ', N'Sân 5 3', CAST(200000.00 AS Decimal(18, 2)), N'Đang Trống', N'Sân đẹp')
INSERT [dbo].[SAN] ([IdSan], [IdLoaiSan], [TenSan], [Gia], [TrangThai], [MoTa]) VALUES (N'S004      ', N'LS001     ', N'Sân 5 4', CAST(200000.00 AS Decimal(18, 2)), N'Đang trống ', N'Sân đẹp')
INSERT [dbo].[SAN] ([IdSan], [IdLoaiSan], [TenSan], [Gia], [TrangThai], [MoTa]) VALUES (N'S005      ', N'LS001     ', N'Sân 5 5', CAST(200000.00 AS Decimal(18, 2)), N'Đang trống', N'Sân đẹp')
INSERT [dbo].[SAN] ([IdSan], [IdLoaiSan], [TenSan], [Gia], [TrangThai], [MoTa]) VALUES (N'S006      ', N'LS001     ', N'Sân 7 1', CAST(400000.00 AS Decimal(18, 2)), N'Đang trống', N'Sân đẹp')
INSERT [dbo].[SAN] ([IdSan], [IdLoaiSan], [TenSan], [Gia], [TrangThai], [MoTa]) VALUES (N'S007      ', N'LS002     ', N'Sân 7 2', CAST(400000.00 AS Decimal(18, 2)), N'Đang trống', N'Sân đẹp')
INSERT [dbo].[SAN] ([IdSan], [IdLoaiSan], [TenSan], [Gia], [TrangThai], [MoTa]) VALUES (N'S008      ', N'LS002     ', N'Sân 7 3', CAST(400000.00 AS Decimal(18, 2)), N'Đang trống', N'Sân đẹp')
INSERT [dbo].[SAN] ([IdSan], [IdLoaiSan], [TenSan], [Gia], [TrangThai], [MoTa]) VALUES (N'S009      ', N'LS002     ', N'Sân 7 4', CAST(400000.00 AS Decimal(18, 2)), N'Đang trống', N'Sân đẹp')
INSERT [dbo].[SAN] ([IdSan], [IdLoaiSan], [TenSan], [Gia], [TrangThai], [MoTa]) VALUES (N'S010      ', N'LS002     ', N'Sân 7 5', CAST(400000.00 AS Decimal(18, 2)), N'Đang trống ', N'Sân đẹp')
INSERT [dbo].[TAIKHOAN] ([SDT], [MatKhau], [vaitro]) VALUES (N'001                 ', N'10381924', N'user      ')
INSERT [dbo].[TAIKHOAN] ([SDT], [MatKhau], [vaitro]) VALUES (N'002                 ', N'1238912', N'user      ')
INSERT [dbo].[TAIKHOAN] ([SDT], [MatKhau], [vaitro]) VALUES (N'003                 ', N'1233123', N'user      ')
INSERT [dbo].[TAIKHOAN] ([SDT], [MatKhau], [vaitro]) VALUES (N'01234               ', N'12344', N'user      ')
INSERT [dbo].[TAIKHOAN] ([SDT], [MatKhau], [vaitro]) VALUES (N'0129313             ', N'Huypro123', N'addmin    ')
INSERT [dbo].[TAIKHOAN] ([SDT], [MatKhau], [vaitro]) VALUES (N'0312312             ', N'123', N'user      ')
INSERT [dbo].[TAIKHOAN] ([SDT], [MatKhau], [vaitro]) VALUES (N'036987              ', N'123', N'user      ')
INSERT [dbo].[TAIKHOAN] ([SDT], [MatKhau], [vaitro]) VALUES (N'03698784            ', N'123', N'user      ')
INSERT [dbo].[TAIKHOAN] ([SDT], [MatKhau], [vaitro]) VALUES (N'0369878455          ', N'123', N'user      ')
INSERT [dbo].[TAIKHOAN] ([SDT], [MatKhau], [vaitro]) VALUES (N'0988                ', N'123', N'user      ')
INSERT [dbo].[TAIKHOAN] ([SDT], [MatKhau], [vaitro]) VALUES (N'111                 ', N'123', N'user      ')
INSERT [dbo].[TAIKHOAN] ([SDT], [MatKhau], [vaitro]) VALUES (N'123123              ', N'1234', N'user      ')
INSERT [dbo].[TAIKHOAN] ([SDT], [MatKhau], [vaitro]) VALUES (N'333                 ', N'123', N'user      ')
ALTER TABLE [dbo].[ADDMIN]  WITH CHECK ADD  CONSTRAINT [FK_ADDMIN_TAIKHOAI] FOREIGN KEY([SDT])
REFERENCES [dbo].[TAIKHOAN] ([SDT])
GO
ALTER TABLE [dbo].[ADDMIN] CHECK CONSTRAINT [FK_ADDMIN_TAIKHOAI]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_IdKH] FOREIGN KEY([IdKH])
REFERENCES [dbo].[KHACHHANG] ([IdKH])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_IdKH]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_IdSan] FOREIGN KEY([IdSan])
REFERENCES [dbo].[SAN] ([IdSan])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_IdSan]
GO
ALTER TABLE [dbo].[KHACHHANG]  WITH CHECK ADD  CONSTRAINT [FK_KHACHHANG_TAIKHOAI] FOREIGN KEY([SDT])
REFERENCES [dbo].[TAIKHOAN] ([SDT])
GO
ALTER TABLE [dbo].[KHACHHANG] CHECK CONSTRAINT [FK_KHACHHANG_TAIKHOAI]
GO
ALTER TABLE [dbo].[SAN]  WITH CHECK ADD  CONSTRAINT [FK_SAN_IdLoaiSan] FOREIGN KEY([IdLoaiSan])
REFERENCES [dbo].[LOAISAN] ([IdLoaiSan])
GO
ALTER TABLE [dbo].[SAN] CHECK CONSTRAINT [FK_SAN_IdLoaiSan]
GO
USE [master]
GO
ALTER DATABASE [QuanLySanBong] SET  READ_WRITE 
GO
