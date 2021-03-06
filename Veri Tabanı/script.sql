USE [master]
GO
/****** Object:  Database [Kafem]    Script Date: 14.09.2020 19:59:25 ******/
CREATE DATABASE [Kafem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Kafem', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Kafem.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Kafem_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Kafem_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Kafem] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Kafem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Kafem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Kafem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Kafem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Kafem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Kafem] SET ARITHABORT OFF 
GO
ALTER DATABASE [Kafem] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Kafem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Kafem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Kafem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Kafem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Kafem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Kafem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Kafem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Kafem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Kafem] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Kafem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Kafem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Kafem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Kafem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Kafem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Kafem] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Kafem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Kafem] SET RECOVERY FULL 
GO
ALTER DATABASE [Kafem] SET  MULTI_USER 
GO
ALTER DATABASE [Kafem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Kafem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Kafem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Kafem] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Kafem] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Kafem', N'ON'
GO
ALTER DATABASE [Kafem] SET QUERY_STORE = OFF
GO
USE [Kafem]
GO
/****** Object:  Table [dbo].[Gecmis]    Script Date: 14.09.2020 19:59:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gecmis](
	[GecmisID] [int] IDENTITY(1,1) NOT NULL,
	[MasaID] [int] NULL,
	[ToplamKazanc] [int] NULL,
	[tarihsaat] [nvarchar](50) NULL,
 CONSTRAINT [PK_Gecmis] PRIMARY KEY CLUSTERED 
(
	[GecmisID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[giris]    Script Date: 14.09.2020 19:59:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[giris](
	[ID] [int] NULL,
	[Adi] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Gruplar]    Script Date: 14.09.2020 19:59:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gruplar](
	[GrupID] [int] IDENTITY(1,1) NOT NULL,
	[GrupAdi] [nvarchar](15) NULL,
 CONSTRAINT [PK_Gruplar] PRIMARY KEY CLUSTERED 
(
	[GrupID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 14.09.2020 19:59:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[KullaniciAdi] [nvarchar](50) NULL,
	[Sifre] [nvarchar](50) NULL,
	[Yetki] [nvarchar](15) NULL,
	[Adi] [nvarchar](50) NULL,
	[Soyadi] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Masa]    Script Date: 14.09.2020 19:59:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Masa](
	[MasaID] [int] IDENTITY(1,1) NOT NULL,
	[Masalar] [nvarchar](15) NULL,
 CONSTRAINT [PK_Masa] PRIMARY KEY CLUSTERED 
(
	[MasaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Menu]    Script Date: 14.09.2020 19:59:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Menu](
	[MenuID] [int] IDENTITY(1,1) NOT NULL,
	[GrupID] [int] NULL,
	[MenuUrunAdi] [nvarchar](50) NULL,
	[MenuUrunFiyati] [int] NULL,
	[foto] [nvarchar](200) NULL,
 CONSTRAINT [PK_Menu] PRIMARY KEY CLUSTERED 
(
	[MenuID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personel]    Script Date: 14.09.2020 19:59:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personel](
	[PersonelID] [int] IDENTITY(1,1) NOT NULL,
	[PersonelAdi] [nvarchar](50) NULL,
	[PersonelSoyadi] [nvarchar](50) NULL,
	[PersonelTel] [nvarchar](13) NULL,
	[PersonelYas] [int] NULL,
	[PersonelMaas] [int] NULL,
	[PersonelAdres] [nvarchar](250) NULL,
 CONSTRAINT [PK_Personel] PRIMARY KEY CLUSTERED 
(
	[PersonelID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Siparisler]    Script Date: 14.09.2020 19:59:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Siparisler](
	[SiparislerID] [int] IDENTITY(1,1) NOT NULL,
	[MasaID] [int] NULL,
	[UrunAdi] [nvarchar](50) NULL,
	[UrunTutari] [int] NULL,
 CONSTRAINT [PK_Siparisler] PRIMARY KEY CLUSTERED 
(
	[SiparislerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Gecmis] ON 

INSERT [dbo].[Gecmis] ([GecmisID], [MasaID], [ToplamKazanc], [tarihsaat]) VALUES (1, 1, 8, N'29.07.2020 06:14:08')
INSERT [dbo].[Gecmis] ([GecmisID], [MasaID], [ToplamKazanc], [tarihsaat]) VALUES (2, 1, 8, N'29.07.2020 06:15:33')
INSERT [dbo].[Gecmis] ([GecmisID], [MasaID], [ToplamKazanc], [tarihsaat]) VALUES (3, 1, 8, N'29.07.2020 06:19:22')
INSERT [dbo].[Gecmis] ([GecmisID], [MasaID], [ToplamKazanc], [tarihsaat]) VALUES (4, 2, 18, N'29.07.2020 06:20:22')
INSERT [dbo].[Gecmis] ([GecmisID], [MasaID], [ToplamKazanc], [tarihsaat]) VALUES (6, 7, 11, N'29.07.2020 06:26:28')
INSERT [dbo].[Gecmis] ([GecmisID], [MasaID], [ToplamKazanc], [tarihsaat]) VALUES (7, 4, 3, N'29.07.2020 06:26:39')
INSERT [dbo].[Gecmis] ([GecmisID], [MasaID], [ToplamKazanc], [tarihsaat]) VALUES (23, 3, 14, N'9.09.2020 01:42:36')
INSERT [dbo].[Gecmis] ([GecmisID], [MasaID], [ToplamKazanc], [tarihsaat]) VALUES (24, 3, 15, N'9.09.2020 01:46:07')
SET IDENTITY_INSERT [dbo].[Gecmis] OFF
SET IDENTITY_INSERT [dbo].[Gruplar] ON 

INSERT [dbo].[Gruplar] ([GrupID], [GrupAdi]) VALUES (1, N'içecekler')
INSERT [dbo].[Gruplar] ([GrupID], [GrupAdi]) VALUES (2, N'yiyecekler')
SET IDENTITY_INSERT [dbo].[Gruplar] OFF
SET IDENTITY_INSERT [dbo].[Login] ON 

INSERT [dbo].[Login] ([ID], [KullaniciAdi], [Sifre], [Yetki], [Adi], [Soyadi]) VALUES (6, N'AhmetJiyan', N'123', N'yönetici', N'Ahmet Jiyan', N'BAYAT')
SET IDENTITY_INSERT [dbo].[Login] OFF
SET IDENTITY_INSERT [dbo].[Masa] ON 

INSERT [dbo].[Masa] ([MasaID], [Masalar]) VALUES (1, N'Masa 1')
INSERT [dbo].[Masa] ([MasaID], [Masalar]) VALUES (2, N'Masa 2')
INSERT [dbo].[Masa] ([MasaID], [Masalar]) VALUES (3, N'Masa 3')
INSERT [dbo].[Masa] ([MasaID], [Masalar]) VALUES (4, N'Masa 4')
INSERT [dbo].[Masa] ([MasaID], [Masalar]) VALUES (5, N'Masa 5')
INSERT [dbo].[Masa] ([MasaID], [Masalar]) VALUES (6, N'Masa 6')
INSERT [dbo].[Masa] ([MasaID], [Masalar]) VALUES (7, N'Masa 7')
INSERT [dbo].[Masa] ([MasaID], [Masalar]) VALUES (8, N'Masa 8')
SET IDENTITY_INSERT [dbo].[Masa] OFF
SET IDENTITY_INSERT [dbo].[Menu] ON 

INSERT [dbo].[Menu] ([MenuID], [GrupID], [MenuUrunAdi], [MenuUrunFiyati], [foto]) VALUES (1, 1, N'Çay', 3, NULL)
INSERT [dbo].[Menu] ([MenuID], [GrupID], [MenuUrunAdi], [MenuUrunFiyati], [foto]) VALUES (2, 1, N'Kahve', 7, NULL)
INSERT [dbo].[Menu] ([MenuID], [GrupID], [MenuUrunAdi], [MenuUrunFiyati], [foto]) VALUES (3, 1, N'Sıcak Süt', 5, NULL)
INSERT [dbo].[Menu] ([MenuID], [GrupID], [MenuUrunAdi], [MenuUrunFiyati], [foto]) VALUES (4, 1, N'Salep', 6, NULL)
INSERT [dbo].[Menu] ([MenuID], [GrupID], [MenuUrunAdi], [MenuUrunFiyati], [foto]) VALUES (5, 1, N'Sıcak Çikolata', 6, NULL)
INSERT [dbo].[Menu] ([MenuID], [GrupID], [MenuUrunAdi], [MenuUrunFiyati], [foto]) VALUES (6, 1, N'Bitki Çayı', 5, NULL)
INSERT [dbo].[Menu] ([MenuID], [GrupID], [MenuUrunAdi], [MenuUrunFiyati], [foto]) VALUES (7, 2, N'Tost', 10, NULL)
INSERT [dbo].[Menu] ([MenuID], [GrupID], [MenuUrunAdi], [MenuUrunFiyati], [foto]) VALUES (8, 2, N'Dürüm', 10, NULL)
INSERT [dbo].[Menu] ([MenuID], [GrupID], [MenuUrunAdi], [MenuUrunFiyati], [foto]) VALUES (10, 2, N'Tavuk Döner Menü', 15, NULL)
INSERT [dbo].[Menu] ([MenuID], [GrupID], [MenuUrunAdi], [MenuUrunFiyati], [foto]) VALUES (11, 2, N'Et Döner Menü', 18, NULL)
INSERT [dbo].[Menu] ([MenuID], [GrupID], [MenuUrunAdi], [MenuUrunFiyati], [foto]) VALUES (12, 2, N'Büryan', 12, NULL)
INSERT [dbo].[Menu] ([MenuID], [GrupID], [MenuUrunAdi], [MenuUrunFiyati], [foto]) VALUES (13, 2, N'Lahmacun', 18, NULL)
INSERT [dbo].[Menu] ([MenuID], [GrupID], [MenuUrunAdi], [MenuUrunFiyati], [foto]) VALUES (14, 2, N'Pide', 22, NULL)
INSERT [dbo].[Menu] ([MenuID], [GrupID], [MenuUrunAdi], [MenuUrunFiyati], [foto]) VALUES (15, 2, N'Saç Tava', 25, NULL)
INSERT [dbo].[Menu] ([MenuID], [GrupID], [MenuUrunAdi], [MenuUrunFiyati], [foto]) VALUES (16, 2, N'Kebap', 23, NULL)
INSERT [dbo].[Menu] ([MenuID], [GrupID], [MenuUrunAdi], [MenuUrunFiyati], [foto]) VALUES (17, 2, N'İskender Kebap', 28, NULL)
INSERT [dbo].[Menu] ([MenuID], [GrupID], [MenuUrunAdi], [MenuUrunFiyati], [foto]) VALUES (18, 2, N'Karışık Izgara', 35, NULL)
INSERT [dbo].[Menu] ([MenuID], [GrupID], [MenuUrunAdi], [MenuUrunFiyati], [foto]) VALUES (19, 1, N'ahmet', 5, NULL)
INSERT [dbo].[Menu] ([MenuID], [GrupID], [MenuUrunAdi], [MenuUrunFiyati], [foto]) VALUES (21, 1, N'dv', 5, NULL)
INSERT [dbo].[Menu] ([MenuID], [GrupID], [MenuUrunAdi], [MenuUrunFiyati], [foto]) VALUES (22, 2, N'ds', 3, NULL)
INSERT [dbo].[Menu] ([MenuID], [GrupID], [MenuUrunAdi], [MenuUrunFiyati], [foto]) VALUES (23, 1, N'gg', 5, NULL)
INSERT [dbo].[Menu] ([MenuID], [GrupID], [MenuUrunAdi], [MenuUrunFiyati], [foto]) VALUES (24, 1, N'kuru', 18, NULL)
INSERT [dbo].[Menu] ([MenuID], [GrupID], [MenuUrunAdi], [MenuUrunFiyati], [foto]) VALUES (25, 2, N'sdg', 6, NULL)
INSERT [dbo].[Menu] ([MenuID], [GrupID], [MenuUrunAdi], [MenuUrunFiyati], [foto]) VALUES (26, 1, N'dvds', 3, NULL)
INSERT [dbo].[Menu] ([MenuID], [GrupID], [MenuUrunAdi], [MenuUrunFiyati], [foto]) VALUES (27, 1, N'fgf', 2, NULL)
INSERT [dbo].[Menu] ([MenuID], [GrupID], [MenuUrunAdi], [MenuUrunFiyati], [foto]) VALUES (28, 1, N'xf', 5, NULL)
INSERT [dbo].[Menu] ([MenuID], [GrupID], [MenuUrunAdi], [MenuUrunFiyati], [foto]) VALUES (29, 1, N'fb', 8, NULL)
INSERT [dbo].[Menu] ([MenuID], [GrupID], [MenuUrunAdi], [MenuUrunFiyati], [foto]) VALUES (30, 1, N'dz', 5, NULL)
INSERT [dbo].[Menu] ([MenuID], [GrupID], [MenuUrunAdi], [MenuUrunFiyati], [foto]) VALUES (31, 1, N'fe', 4, NULL)
INSERT [dbo].[Menu] ([MenuID], [GrupID], [MenuUrunAdi], [MenuUrunFiyati], [foto]) VALUES (32, 1, N'vfsda', 5, NULL)
INSERT [dbo].[Menu] ([MenuID], [GrupID], [MenuUrunAdi], [MenuUrunFiyati], [foto]) VALUES (33, 1, N'vx', 3, NULL)
INSERT [dbo].[Menu] ([MenuID], [GrupID], [MenuUrunAdi], [MenuUrunFiyati], [foto]) VALUES (34, 1, N'b c', 5, NULL)
INSERT [dbo].[Menu] ([MenuID], [GrupID], [MenuUrunAdi], [MenuUrunFiyati], [foto]) VALUES (35, 1, N'zvc', 3, NULL)
INSERT [dbo].[Menu] ([MenuID], [GrupID], [MenuUrunAdi], [MenuUrunFiyati], [foto]) VALUES (36, 1, N'zvd', 4, NULL)
INSERT [dbo].[Menu] ([MenuID], [GrupID], [MenuUrunAdi], [MenuUrunFiyati], [foto]) VALUES (37, 1, N'vgf', 45, NULL)
INSERT [dbo].[Menu] ([MenuID], [GrupID], [MenuUrunAdi], [MenuUrunFiyati], [foto]) VALUES (38, 1, N'zdvzdv', 5, NULL)
INSERT [dbo].[Menu] ([MenuID], [GrupID], [MenuUrunAdi], [MenuUrunFiyati], [foto]) VALUES (39, 2, N'sdv', 3, NULL)
INSERT [dbo].[Menu] ([MenuID], [GrupID], [MenuUrunAdi], [MenuUrunFiyati], [foto]) VALUES (40, 1, N'hng', 45, NULL)
SET IDENTITY_INSERT [dbo].[Menu] OFF
SET IDENTITY_INSERT [dbo].[Personel] ON 

INSERT [dbo].[Personel] ([PersonelID], [PersonelAdi], [PersonelSoyadi], [PersonelTel], [PersonelYas], [PersonelMaas], [PersonelAdres]) VALUES (1, N'Mehmet ', N'Taş', N'05455455555', 30, 2500, N'MUŞ')
SET IDENTITY_INSERT [dbo].[Personel] OFF
SET IDENTITY_INSERT [dbo].[Siparisler] ON 

INSERT [dbo].[Siparisler] ([SiparislerID], [MasaID], [UrunAdi], [UrunTutari]) VALUES (30, 4, N'Sıcak Süt', 5)
INSERT [dbo].[Siparisler] ([SiparislerID], [MasaID], [UrunAdi], [UrunTutari]) VALUES (31, 4, N'Bitki Çayı', 5)
SET IDENTITY_INSERT [dbo].[Siparisler] OFF
ALTER TABLE [dbo].[Menu]  WITH CHECK ADD  CONSTRAINT [FK_Menu_Gruplar] FOREIGN KEY([GrupID])
REFERENCES [dbo].[Gruplar] ([GrupID])
GO
ALTER TABLE [dbo].[Menu] CHECK CONSTRAINT [FK_Menu_Gruplar]
GO
ALTER TABLE [dbo].[Siparisler]  WITH CHECK ADD  CONSTRAINT [FK_Siparisler_Masa] FOREIGN KEY([MasaID])
REFERENCES [dbo].[Masa] ([MasaID])
GO
ALTER TABLE [dbo].[Siparisler] CHECK CONSTRAINT [FK_Siparisler_Masa]
GO
USE [master]
GO
ALTER DATABASE [Kafem] SET  READ_WRITE 
GO
