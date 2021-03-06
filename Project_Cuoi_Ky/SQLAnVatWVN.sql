USE [master]
GO
/****** Object:  Database [QLAnVatWVN]    Script Date: 05/05/2021 10:15:51 SA ******/
CREATE DATABASE [QLAnVatWVN]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLAnVatWVN', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QLAnVatWVN.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLAnVatWVN_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QLAnVatWVN_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QLAnVatWVN] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLAnVatWVN].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLAnVatWVN] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLAnVatWVN] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLAnVatWVN] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLAnVatWVN] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLAnVatWVN] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLAnVatWVN] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLAnVatWVN] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLAnVatWVN] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLAnVatWVN] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLAnVatWVN] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLAnVatWVN] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLAnVatWVN] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLAnVatWVN] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLAnVatWVN] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLAnVatWVN] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLAnVatWVN] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLAnVatWVN] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLAnVatWVN] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLAnVatWVN] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLAnVatWVN] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLAnVatWVN] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLAnVatWVN] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLAnVatWVN] SET RECOVERY FULL 
GO
ALTER DATABASE [QLAnVatWVN] SET  MULTI_USER 
GO
ALTER DATABASE [QLAnVatWVN] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLAnVatWVN] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLAnVatWVN] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLAnVatWVN] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLAnVatWVN] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLAnVatWVN', N'ON'
GO
ALTER DATABASE [QLAnVatWVN] SET QUERY_STORE = OFF
GO
USE [QLAnVatWVN]
GO
/****** Object:  Table [dbo].[Ban]    Script Date: 05/05/2021 10:15:51 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ban](
	[IDBan] [int] IDENTITY(1,1) NOT NULL,
	[idkv] [int] NOT NULL,
	[TenBan] [nvarchar](50) NOT NULL,
	[Trangthai] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTHD]    Script Date: 05/05/2021 10:15:51 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTHD](
	[IDCTHD] [int] IDENTITY(1,1) NOT NULL,
	[idhd] [int] NULL,
	[idtp] [int] NULL,
	[soluong] [int] NULL,
	[Tong] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDCTHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DMTP]    Script Date: 05/05/2021 10:15:51 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DMTP](
	[IDDMTP] [int] IDENTITY(1,1) NOT NULL,
	[TenDM] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDDMTP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hoadon]    Script Date: 05/05/2021 10:15:51 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hoadon](
	[IDHD] [int] IDENTITY(1,1) NOT NULL,
	[idnv] [int] NULL,
	[idban] [int] NULL,
	[DateIn] [datetime] NOT NULL,
	[DateOut] [datetime] NULL,
	[Tongtien] [money] NULL,
	[Trangthai] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Khuvuc]    Script Date: 05/05/2021 10:15:51 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khuvuc](
	[IDKV] [int] IDENTITY(1,1) NOT NULL,
	[TenKV] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDKV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nhanvien]    Script Date: 05/05/2021 10:15:51 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nhanvien](
	[IDNV] [varchar](50) NOT NULL,
	[idtk] [int] NULL,
	[TenNV] [nvarchar](100) NOT NULL,
	[Ngaysinh] [date] NOT NULL,
	[CMND] [nvarchar](12) NULL,
	[SDT] [nvarchar](12) NULL,
	[Mucluong] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[IDNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Taikhoan]    Script Date: 05/05/2021 10:15:51 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Taikhoan](
	[IDTK] [int] IDENTITY(1,1) NOT NULL,
	[Tentk] [varchar](50) NOT NULL,
	[Matkhau] [varchar](30) NOT NULL,
	[loai] [bit] NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[CMND] [char](20) NULL,
	[SDT] [char](13) NULL,
	[MucLuong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDTK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Thucpham]    Script Date: 05/05/2021 10:15:51 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Thucpham](
	[IDTP] [int] IDENTITY(1,1) NOT NULL,
	[iddmtp] [int] NULL,
	[TenTP] [nvarchar](50) NOT NULL,
	[Gia] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDTP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Ban] ON 

INSERT [dbo].[Ban] ([IDBan], [idkv], [TenBan], [Trangthai]) VALUES (122, 10, N'Bàn 1A', 0)
INSERT [dbo].[Ban] ([IDBan], [idkv], [TenBan], [Trangthai]) VALUES (123, 10, N'Bàn 2A', 0)
INSERT [dbo].[Ban] ([IDBan], [idkv], [TenBan], [Trangthai]) VALUES (124, 10, N'Bàn 3A', 0)
INSERT [dbo].[Ban] ([IDBan], [idkv], [TenBan], [Trangthai]) VALUES (125, 10, N'Bàn 4A', 0)
INSERT [dbo].[Ban] ([IDBan], [idkv], [TenBan], [Trangthai]) VALUES (126, 10, N'Bàn 5A', 0)
INSERT [dbo].[Ban] ([IDBan], [idkv], [TenBan], [Trangthai]) VALUES (127, 10, N'Bàn 6A', 0)
INSERT [dbo].[Ban] ([IDBan], [idkv], [TenBan], [Trangthai]) VALUES (128, 10, N'Bàn 7A', 0)
INSERT [dbo].[Ban] ([IDBan], [idkv], [TenBan], [Trangthai]) VALUES (129, 10, N'Bàn 8A', 0)
INSERT [dbo].[Ban] ([IDBan], [idkv], [TenBan], [Trangthai]) VALUES (130, 10, N'Bàn 9A', 0)
INSERT [dbo].[Ban] ([IDBan], [idkv], [TenBan], [Trangthai]) VALUES (131, 10, N'Bàn 10A', 0)
INSERT [dbo].[Ban] ([IDBan], [idkv], [TenBan], [Trangthai]) VALUES (132, 11, N'Bàn 1B', 0)
INSERT [dbo].[Ban] ([IDBan], [idkv], [TenBan], [Trangthai]) VALUES (133, 11, N'Bàn 2B', 0)
INSERT [dbo].[Ban] ([IDBan], [idkv], [TenBan], [Trangthai]) VALUES (134, 11, N'Bàn 3B', 0)
INSERT [dbo].[Ban] ([IDBan], [idkv], [TenBan], [Trangthai]) VALUES (135, 11, N'Bàn 4B', 0)
INSERT [dbo].[Ban] ([IDBan], [idkv], [TenBan], [Trangthai]) VALUES (136, 11, N'Bàn 5B', 0)
INSERT [dbo].[Ban] ([IDBan], [idkv], [TenBan], [Trangthai]) VALUES (137, 11, N'Bàn 6B', 0)
INSERT [dbo].[Ban] ([IDBan], [idkv], [TenBan], [Trangthai]) VALUES (138, 11, N'Bàn 7B', 0)
INSERT [dbo].[Ban] ([IDBan], [idkv], [TenBan], [Trangthai]) VALUES (139, 11, N'Bàn 8B', 0)
INSERT [dbo].[Ban] ([IDBan], [idkv], [TenBan], [Trangthai]) VALUES (140, 11, N'Bàn 9B', 0)
INSERT [dbo].[Ban] ([IDBan], [idkv], [TenBan], [Trangthai]) VALUES (141, 11, N'Bàn 10B', 0)
INSERT [dbo].[Ban] ([IDBan], [idkv], [TenBan], [Trangthai]) VALUES (142, 12, N'Bàn 1C', 0)
INSERT [dbo].[Ban] ([IDBan], [idkv], [TenBan], [Trangthai]) VALUES (143, 12, N'Bàn 2C', 0)
INSERT [dbo].[Ban] ([IDBan], [idkv], [TenBan], [Trangthai]) VALUES (144, 12, N'Bàn 3C', 0)
INSERT [dbo].[Ban] ([IDBan], [idkv], [TenBan], [Trangthai]) VALUES (145, 12, N'Bàn 4C', 0)
INSERT [dbo].[Ban] ([IDBan], [idkv], [TenBan], [Trangthai]) VALUES (146, 12, N'Bàn 5C', 0)
INSERT [dbo].[Ban] ([IDBan], [idkv], [TenBan], [Trangthai]) VALUES (147, 12, N'Bàn 6C', 0)
INSERT [dbo].[Ban] ([IDBan], [idkv], [TenBan], [Trangthai]) VALUES (148, 12, N'Bàn 7C', 0)
INSERT [dbo].[Ban] ([IDBan], [idkv], [TenBan], [Trangthai]) VALUES (149, 12, N'Bàn 8C', 0)
INSERT [dbo].[Ban] ([IDBan], [idkv], [TenBan], [Trangthai]) VALUES (150, 12, N'Bàn 9C', 0)
INSERT [dbo].[Ban] ([IDBan], [idkv], [TenBan], [Trangthai]) VALUES (151, 12, N'Bàn 10C', 0)
SET IDENTITY_INSERT [dbo].[Ban] OFF
GO
SET IDENTITY_INSERT [dbo].[DMTP] ON 

INSERT [dbo].[DMTP] ([IDDMTP], [TenDM]) VALUES (13, N'Thức ăn')
INSERT [dbo].[DMTP] ([IDDMTP], [TenDM]) VALUES (14, N'Ðồ uống')
INSERT [dbo].[DMTP] ([IDDMTP], [TenDM]) VALUES (15, N'Combo')
INSERT [dbo].[DMTP] ([IDDMTP], [TenDM]) VALUES (16, N'Khác')
INSERT [dbo].[DMTP] ([IDDMTP], [TenDM]) VALUES (17, N'Thử 1')
SET IDENTITY_INSERT [dbo].[DMTP] OFF
GO
SET IDENTITY_INSERT [dbo].[Khuvuc] ON 

INSERT [dbo].[Khuvuc] ([IDKV], [TenKV]) VALUES (10, N'Khu A')
INSERT [dbo].[Khuvuc] ([IDKV], [TenKV]) VALUES (11, N'Khu B')
INSERT [dbo].[Khuvuc] ([IDKV], [TenKV]) VALUES (12, N'Khu C')
SET IDENTITY_INSERT [dbo].[Khuvuc] OFF
GO
SET IDENTITY_INSERT [dbo].[Taikhoan] ON 

INSERT [dbo].[Taikhoan] ([IDTK], [Tentk], [Matkhau], [loai], [TenNV], [NgaySinh], [CMND], [SDT], [MucLuong]) VALUES (6, N'Admin123', N'0000', 1, N'Trần Minh Quân', CAST(N'2000-03-14' AS Date), N'285802640           ', NULL, NULL)
INSERT [dbo].[Taikhoan] ([IDTK], [Tentk], [Matkhau], [loai], [TenNV], [NgaySinh], [CMND], [SDT], [MucLuong]) VALUES (10, N'tentk', N'matkhau', 1, N'Tennv', CAST(N'2021-04-26' AS Date), N'CMND                ', N'SDT          ', 20000)
INSERT [dbo].[Taikhoan] ([IDTK], [Tentk], [Matkhau], [loai], [TenNV], [NgaySinh], [CMND], [SDT], [MucLuong]) VALUES (24, N'minhquan', N'14032000', 1, N'Trần Minh Quân', CAST(N'2020-12-01' AS Date), N'                    ', N'             ', 0)
INSERT [dbo].[Taikhoan] ([IDTK], [Tentk], [Matkhau], [loai], [TenNV], [NgaySinh], [CMND], [SDT], [MucLuong]) VALUES (28, N'admin1', N'123123', 1, N'Trần Minh Quân', CAST(N'2000-03-14' AS Date), N'                    ', N'             ', 0)
SET IDENTITY_INSERT [dbo].[Taikhoan] OFF
GO
SET IDENTITY_INSERT [dbo].[Thucpham] ON 

INSERT [dbo].[Thucpham] ([IDTP], [iddmtp], [TenTP], [Gia]) VALUES (51, 13, N'Đùi gà KFC', 45000.0000)
INSERT [dbo].[Thucpham] ([IDTP], [iddmtp], [TenTP], [Gia]) VALUES (52, 13, N'Hamburger Tôm', 42000.0000)
INSERT [dbo].[Thucpham] ([IDTP], [iddmtp], [TenTP], [Gia]) VALUES (53, 13, N'Hamburger Bò', 45000.0000)
INSERT [dbo].[Thucpham] ([IDTP], [iddmtp], [TenTP], [Gia]) VALUES (54, 13, N'Cơm gà xiên que', 41000.0000)
INSERT [dbo].[Thucpham] ([IDTP], [iddmtp], [TenTP], [Gia]) VALUES (55, 13, N'Khoai tây chiên (Lớn)', 27000.0000)
INSERT [dbo].[Thucpham] ([IDTP], [iddmtp], [TenTP], [Gia]) VALUES (56, 14, N'Red Bull lon', 28000.0000)
INSERT [dbo].[Thucpham] ([IDTP], [iddmtp], [TenTP], [Gia]) VALUES (57, 14, N'Pepsi lon', 22000.0000)
INSERT [dbo].[Thucpham] ([IDTP], [iddmtp], [TenTP], [Gia]) VALUES (58, 14, N'Coca Cola lon', 22000.0000)
INSERT [dbo].[Thucpham] ([IDTP], [iddmtp], [TenTP], [Gia]) VALUES (59, 14, N'7 Up lon', 22000.0000)
INSERT [dbo].[Thucpham] ([IDTP], [iddmtp], [TenTP], [Gia]) VALUES (60, 14, N'Mirinda Cream lon', 20000.0000)
INSERT [dbo].[Thucpham] ([IDTP], [iddmtp], [TenTP], [Gia]) VALUES (61, 13, N'Cơm gà xiên que', 1.0000)
SET IDENTITY_INSERT [dbo].[Thucpham] OFF
GO
ALTER TABLE [dbo].[Ban] ADD  DEFAULT ((0)) FOR [Trangthai]
GO
ALTER TABLE [dbo].[Hoadon] ADD  DEFAULT ((0)) FOR [Trangthai]
GO
ALTER TABLE [dbo].[Nhanvien] ADD  DEFAULT (N'Chưa nhập') FOR [CMND]
GO
ALTER TABLE [dbo].[Nhanvien] ADD  DEFAULT (N'Chưa nhập') FOR [SDT]
GO
ALTER TABLE [dbo].[Nhanvien] ADD  DEFAULT (N'Chưa nhập') FOR [Mucluong]
GO
ALTER TABLE [dbo].[Ban]  WITH CHECK ADD FOREIGN KEY([idkv])
REFERENCES [dbo].[Khuvuc] ([IDKV])
GO
ALTER TABLE [dbo].[CTHD]  WITH CHECK ADD FOREIGN KEY([idtp])
REFERENCES [dbo].[Thucpham] ([IDTP])
GO
ALTER TABLE [dbo].[CTHD]  WITH CHECK ADD FOREIGN KEY([idhd])
REFERENCES [dbo].[Hoadon] ([IDHD])
GO
ALTER TABLE [dbo].[Hoadon]  WITH CHECK ADD FOREIGN KEY([idban])
REFERENCES [dbo].[Ban] ([IDBan])
GO
ALTER TABLE [dbo].[Hoadon]  WITH CHECK ADD  CONSTRAINT [FK_Hoadon_TaiKhoan] FOREIGN KEY([idnv])
REFERENCES [dbo].[Taikhoan] ([IDTK])
GO
ALTER TABLE [dbo].[Hoadon] CHECK CONSTRAINT [FK_Hoadon_TaiKhoan]
GO
ALTER TABLE [dbo].[Nhanvien]  WITH CHECK ADD FOREIGN KEY([idtk])
REFERENCES [dbo].[Taikhoan] ([IDTK])
GO
ALTER TABLE [dbo].[Thucpham]  WITH CHECK ADD FOREIGN KEY([iddmtp])
REFERENCES [dbo].[DMTP] ([IDDMTP])
GO
/****** Object:  StoredProcedure [dbo].[USP_HienThiHoaDon]    Script Date: 05/05/2021 10:15:51 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_HienThiHoaDon]
@idban varchar(50)
as
begin
	select tp.TenTP as tentp,soluong,soluong*Tp.Gia as thanhtien 
	from dbo.Hoadon as  hd,dbo.CTHD as cthd,dbo.Thucpham as tp
	where cthd.idhd = hd.IDHD and cthd.idtp = tp.IDTP and hd.idban = @idban and hd.Trangthai = '0'
end
GO
/****** Object:  StoredProcedure [dbo].[USP_huyhoadon]    Script Date: 05/05/2021 10:15:51 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_huyhoadon]
@idban int
as 
begin
	declare @idhd int
	select @idhd=IDHD from dbo.Hoadon where idban = @idban and Trangthai = 0

	delete from dbo.CTHD where IDHD = @idhd
	delete from dbo.Hoadon where IDHD = @idhd

	update dbo.Ban set Trangthai = 0 where IDBan = @idban
end
GO
/****** Object:  StoredProcedure [dbo].[USP_showhoadon]    Script Date: 05/05/2021 10:15:51 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_showhoadon]
as
begin
	select  ban.TenBan,hd.DateIn,hd.DateOut,hd.Tongtien
	from dbo.Hoadon as hd,dbo.Ban as ban
	where hd.Trangthai = 1 and hd.idban = ban.IDBan
end
GO
/****** Object:  StoredProcedure [dbo].[USP_showOrder]    Script Date: 05/05/2021 10:15:51 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_showOrder]
@tenban nvarchar(50)
as
begin
	declare @idban int
	select @idban = IDBan from dbo.Ban
	select tp.TenTP as N'Món',soluong,soluong*Tp.Gia as N'Thành tiền' 
	from dbo.Hoadon as  hd,dbo.CTHD as cthd,dbo.Thucpham as tp
	where cthd.idhd = hd.IDHD and cthd.idtp = tp.IDTP and hd.idban = @idban and hd.Trangthai = '0'
end
GO
/****** Object:  StoredProcedure [dbo].[USP_TaoHoaDon]    Script Date: 05/05/2021 10:15:51 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_TaoHoaDon]
@idban int,@idnv varchar(50)
as 
begin
	declare @tontai int 
	select @tontai=count(*) from dbo.Hoadon where idban = @idban and Trangthai = 0;
	if(@tontai = 0)
	begin	
		insert dbo.Hoadon values (@idnv,@idban,GETDATE(),null,null,0)
		update dbo.Ban set Trangthai = 1 where IDBan = @idban
	end
	else
	begin
		declare @trangthai int 
		select @trangthai=Trangthai from dbo.Hoadon where idban=@idban
		if(@trangthai = 1)
		begin
			insert dbo.Hoadon values (@idnv,@idban,GETDATE(),null,null,0)
			update dbo.Ban set Trangthai = 1 where IDBan = @idban
		end
	end
end
GO
/****** Object:  StoredProcedure [dbo].[USP_Thanhtoan]    Script Date: 05/05/2021 10:15:51 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_Thanhtoan]
@idban int
as
begin
	declare @idhd int
	select @idhd = IDHD
	from dbo.Hoadon
	where idban =  @idban and Trangthai = '0'

	declare @tongtien int
	select @tongtien = sum(Tong) from dbo.CTHD where idhd = @idhd 
	update dbo.Hoadon set Trangthai = '1',DateOut = getdate(),Tongtien = @tongtien where IDHD = @idhd
	declare @cokhach bit
	select @cokhach = Trangthai from dbo.Ban where IDBan = @idban
	if(@cokhach = 1)
	begin
		update dbo.Ban set Trangthai = '0' where IDBan = @idban
	end
end
GO
/****** Object:  StoredProcedure [dbo].[USP_Themmon]    Script Date: 05/05/2021 10:15:51 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_Themmon]
@tenban nvarchar(50),@tenmon nvarchar(100),@soluong int
as
begin
	declare @idhd int,@idtp int,@tontai int,@soluongcu int,@giatp int

	select @idhd = hd.IDHD
	from dbo.Hoadon as hd,dbo.Ban as ban
	where hd.idban = ban.IDBan and ban.TenBan = @tenban and hd.Trangthai = '0'

	select @idtp = IDTP,@giatp = Gia
	from dbo.Thucpham 
	where TenTP = @tenmon

	select @tontai=cthd.IDCTHD,@soluongcu = soluong
	from dbo.CTHD as cthd,dbo.Hoadon as hd
	where idtp = @idtp and hd.IDHD = cthd.idhd and cthd.idhd = @idhd
	
	if(@tontai > 0)
	begin
		update dbo.CTHD set soluong = @soluongcu + @soluong where idtp = @idtp and idhd=@idhd
	end
	else
	begin
		insert dbo.CTHD values(@idhd,@idtp,@soluong,@soluong*@giatp)
	end
end
GO
/****** Object:  StoredProcedure [dbo].[USP_xacminhadmin]    Script Date: 05/05/2021 10:15:51 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_xacminhadmin]
@idnv varchar(30)
as
begin
	declare @tentk varchar(50),@matkhau varchar(50)
	select @tentk=tk.Tentk,@matkhau=tk.Matkhau
	from dbo.Taikhoan as tk,dbo.Nhanvien as nv
	where tk.IDTK = nv.idtk and nv.IDNV = @idnv

	select loai from dbo.Taikhoan where Tentk = @tentk and Matkhau = @matkhau
end
GO
/****** Object:  StoredProcedure [dbo].[USPgetIDNV]    Script Date: 05/05/2021 10:15:51 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USPgetIDNV]
@tentk varchar(50)
as
begin
	declare @idtk int 
	select @idtk =IDTK from dbo.Taikhoan where Tentk=@tentk
	select IDNV from dbo.Nhanvien where idtk=@idtk
end
GO
/****** Object:  StoredProcedure [dbo].[USPgetTenNV]    Script Date: 05/05/2021 10:15:51 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USPgetTenNV]
@tentk varchar(50)
as
begin
	declare @idtk int 
	select @idtk =IDTK from dbo.Taikhoan where Tentk=@tentk
	select TenNV from dbo.Nhanvien where idtk=@idtk
end
GO
/****** Object:  StoredProcedure [dbo].[viewtable]    Script Date: 05/05/2021 10:15:51 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[viewtable] 
@num int
as
begin
	if(@num = 1)
	begin
		select * from dbo.Taikhoan
	end
	if(@num = 2)
	begin
		select * from dbo.Nhanvien
	end
	if(@num = 3)
	begin
		select * from dbo.Khuvuc
	end
	if(@num = 4)
	begin
		select * from dbo.Ban
	end
	if(@num = 5)
	begin
		select * from dbo.DMTP
	end
	if(@num = 6)
	begin
		select * from dbo.Thucpham
	end
	if(@num = 7)
	begin
		select * from dbo.Hoadon
	end
	if(@num = 8)
	begin
		select * from dbo.CTHD
	end
end
GO
USE [master]
GO
ALTER DATABASE [QLAnVatWVN] SET  READ_WRITE 
GO
