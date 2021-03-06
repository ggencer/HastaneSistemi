USE [master]
GO
/****** Object:  Database [hbs_db]    Script Date: 26.05.2022 23:13:24 ******/
CREATE DATABASE [hbs_db]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'hbs_db', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\hbs_db.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'hbs_db_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\hbs_db_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [hbs_db] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [hbs_db].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [hbs_db] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [hbs_db] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [hbs_db] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [hbs_db] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [hbs_db] SET ARITHABORT OFF 
GO
ALTER DATABASE [hbs_db] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [hbs_db] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [hbs_db] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [hbs_db] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [hbs_db] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [hbs_db] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [hbs_db] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [hbs_db] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [hbs_db] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [hbs_db] SET  DISABLE_BROKER 
GO
ALTER DATABASE [hbs_db] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [hbs_db] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [hbs_db] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [hbs_db] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [hbs_db] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [hbs_db] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [hbs_db] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [hbs_db] SET RECOVERY FULL 
GO
ALTER DATABASE [hbs_db] SET  MULTI_USER 
GO
ALTER DATABASE [hbs_db] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [hbs_db] SET DB_CHAINING OFF 
GO
ALTER DATABASE [hbs_db] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [hbs_db] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [hbs_db] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [hbs_db] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'hbs_db', N'ON'
GO
ALTER DATABASE [hbs_db] SET QUERY_STORE = OFF
GO
USE [hbs_db]
GO
/****** Object:  Table [dbo].[doktor]    Script Date: 26.05.2022 23:13:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[doktor](
	[doktor_id] [int] IDENTITY(1,1) NOT NULL,
	[doktor_tc] [nvarchar](11) NOT NULL,
	[doktor_ad] [nvarchar](50) NOT NULL,
	[doktor_soyad] [nvarchar](50) NOT NULL,
	[doktor_uzmanlik] [nvarchar](50) NOT NULL,
	[doktor_sifre] [nvarchar](50) NOT NULL,
	[doktor_randevu_id] [int] NULL,
 CONSTRAINT [PK_doktor] PRIMARY KEY CLUSTERED 
(
	[doktor_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[hasta]    Script Date: 26.05.2022 23:13:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hasta](
	[hasta_id] [int] IDENTITY(1,1) NOT NULL,
	[hasta_tc] [nvarchar](11) NOT NULL,
	[hasta_ad] [nvarchar](50) NOT NULL,
	[hasta_soyad] [nvarchar](50) NOT NULL,
	[hasta_dob] [date] NULL,
	[hasta_tel] [nchar](11) NULL,
	[hasta_adres] [nvarchar](150) NULL,
	[hasta_sifre] [nvarchar](50) NOT NULL,
	[hasta_doktor_notlar] [nvarchar](150) NULL,
 CONSTRAINT [PK_hasta] PRIMARY KEY CLUSTERED 
(
	[hasta_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[kullanici]    Script Date: 26.05.2022 23:13:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[kullanici](
	[kullanici_id] [int] IDENTITY(1,1) NOT NULL,
	[kullanici_tc] [nvarchar](11) NOT NULL,
	[kullanici_sifre] [nvarchar](50) NOT NULL,
	[kullanici_ad] [nvarchar](50) NOT NULL,
	[kullanici_soyad] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_kullanici] PRIMARY KEY CLUSTERED 
(
	[kullanici_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[randevu]    Script Date: 26.05.2022 23:13:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[randevu](
	[randevu_id] [int] IDENTITY(1,1) NOT NULL,
	[randevu_hasta_id] [int] NOT NULL,
	[randevu_tarihi] [date] NOT NULL,
	[randevu_saati] [time](7) NOT NULL,
	[randevu_doktor_id] [int] NOT NULL,
 CONSTRAINT [PK_randevu] PRIMARY KEY CLUSTERED 
(
	[randevu_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[doktor] ON 

INSERT [dbo].[doktor] ([doktor_id], [doktor_tc], [doktor_ad], [doktor_soyad], [doktor_uzmanlik], [doktor_sifre], [doktor_randevu_id]) VALUES (1, N'22222222222', N'Joe', N'Black', N'Dahiliye', N'2222', NULL)
INSERT [dbo].[doktor] ([doktor_id], [doktor_tc], [doktor_ad], [doktor_soyad], [doktor_uzmanlik], [doktor_sifre], [doktor_randevu_id]) VALUES (2, N'12121212121', N'Turkan', N'Se', N'Dermatolog', N'1212', NULL)
INSERT [dbo].[doktor] ([doktor_id], [doktor_tc], [doktor_ad], [doktor_soyad], [doktor_uzmanlik], [doktor_sifre], [doktor_randevu_id]) VALUES (3, N'33333333333', N'Ali', N'Sari', N'Aile Hekimi', N'3333', NULL)
INSERT [dbo].[doktor] ([doktor_id], [doktor_tc], [doktor_ad], [doktor_soyad], [doktor_uzmanlik], [doktor_sifre], [doktor_randevu_id]) VALUES (5, N'44444444444', N'Gizem', N'Selvi', N'Diyetisyen', N'4444', NULL)
INSERT [dbo].[doktor] ([doktor_id], [doktor_tc], [doktor_ad], [doktor_soyad], [doktor_uzmanlik], [doktor_sifre], [doktor_randevu_id]) VALUES (6, N'55555555555', N'Rıza', N'Erdem', N'Göz Hastaliklari', N'5555', NULL)
SET IDENTITY_INSERT [dbo].[doktor] OFF
GO
SET IDENTITY_INSERT [dbo].[hasta] ON 

INSERT [dbo].[hasta] ([hasta_id], [hasta_tc], [hasta_ad], [hasta_soyad], [hasta_dob], [hasta_tel], [hasta_adres], [hasta_sifre], [hasta_doktor_notlar]) VALUES (1, N'33333333333', N'Ali', N'Veli', CAST(N'1978-02-01' AS Date), NULL, NULL, N'3333', NULL)
INSERT [dbo].[hasta] ([hasta_id], [hasta_tc], [hasta_ad], [hasta_soyad], [hasta_dob], [hasta_tel], [hasta_adres], [hasta_sifre], [hasta_doktor_notlar]) VALUES (18, N'12345678909', N'Gokhan', N'Gencer', CAST(N'1978-01-01' AS Date), N'5239578901 ', N'istanbul', N'1234', N'recete XDFGHHT6543')
INSERT [dbo].[hasta] ([hasta_id], [hasta_tc], [hasta_ad], [hasta_soyad], [hasta_dob], [hasta_tel], [hasta_adres], [hasta_sifre], [hasta_doktor_notlar]) VALUES (20, N'12345098765', N'Suat', N'Cet', CAST(N'1960-01-27' AS Date), N'5231234567 ', N'Izmir', N'1234', N'REÇETE VERİLDİ : XDQETT3341')
INSERT [dbo].[hasta] ([hasta_id], [hasta_tc], [hasta_ad], [hasta_soyad], [hasta_dob], [hasta_tel], [hasta_adres], [hasta_sifre], [hasta_doktor_notlar]) VALUES (21, N'12121212341', N'Arzu', N'Bilgili', CAST(N'1982-04-01' AS Date), N'5553211212 ', N'Kayseri', N'1234', NULL)
SET IDENTITY_INSERT [dbo].[hasta] OFF
GO
SET IDENTITY_INSERT [dbo].[kullanici] ON 

INSERT [dbo].[kullanici] ([kullanici_id], [kullanici_tc], [kullanici_sifre], [kullanici_ad], [kullanici_soyad]) VALUES (1, N'11111111111', N'1111', N'Kayit', N'Kabul')
INSERT [dbo].[kullanici] ([kullanici_id], [kullanici_tc], [kullanici_sifre], [kullanici_ad], [kullanici_soyad]) VALUES (2, N'12312312331', N'admin', N'Admin', N'Admin')
SET IDENTITY_INSERT [dbo].[kullanici] OFF
GO
SET IDENTITY_INSERT [dbo].[randevu] ON 

INSERT [dbo].[randevu] ([randevu_id], [randevu_hasta_id], [randevu_tarihi], [randevu_saati], [randevu_doktor_id]) VALUES (12, 20, CAST(N'2022-05-22' AS Date), CAST(N'16:00:00' AS Time), 1)
INSERT [dbo].[randevu] ([randevu_id], [randevu_hasta_id], [randevu_tarihi], [randevu_saati], [randevu_doktor_id]) VALUES (16, 20, CAST(N'2022-05-22' AS Date), CAST(N'13:30:00' AS Time), 1)
INSERT [dbo].[randevu] ([randevu_id], [randevu_hasta_id], [randevu_tarihi], [randevu_saati], [randevu_doktor_id]) VALUES (17, 21, CAST(N'2022-05-22' AS Date), CAST(N'09:00:00' AS Time), 6)
INSERT [dbo].[randevu] ([randevu_id], [randevu_hasta_id], [randevu_tarihi], [randevu_saati], [randevu_doktor_id]) VALUES (18, 18, CAST(N'2022-05-23' AS Date), CAST(N'09:30:00' AS Time), 5)
INSERT [dbo].[randevu] ([randevu_id], [randevu_hasta_id], [randevu_tarihi], [randevu_saati], [randevu_doktor_id]) VALUES (20, 18, CAST(N'2022-05-23' AS Date), CAST(N'09:30:00' AS Time), 3)
SET IDENTITY_INSERT [dbo].[randevu] OFF
GO
ALTER TABLE [dbo].[doktor]  WITH CHECK ADD  CONSTRAINT [FK_doktor_randevu] FOREIGN KEY([doktor_randevu_id])
REFERENCES [dbo].[randevu] ([randevu_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[doktor] CHECK CONSTRAINT [FK_doktor_randevu]
GO
ALTER TABLE [dbo].[randevu]  WITH CHECK ADD  CONSTRAINT [FK_randevu_hasta] FOREIGN KEY([randevu_hasta_id])
REFERENCES [dbo].[hasta] ([hasta_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[randevu] CHECK CONSTRAINT [FK_randevu_hasta]
GO
USE [master]
GO
ALTER DATABASE [hbs_db] SET  READ_WRITE 
GO
