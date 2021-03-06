USE [master]
GO
/****** Object:  Database [GrandUludag]    Script Date: 13.06.2021 20:59:12 ******/
CREATE DATABASE [GrandUludag]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GrandUludag', FILENAME = N'C:\ProgramData\SOLIDWORKS Electrical\MSSQL12.TEW_SQLEXPRESS\MSSQL\DATA\GrandUludag.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'GrandUludag_log', FILENAME = N'C:\ProgramData\SOLIDWORKS Electrical\MSSQL12.TEW_SQLEXPRESS\MSSQL\DATA\GrandUludag_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [GrandUludag] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GrandUludag].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GrandUludag] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GrandUludag] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GrandUludag] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GrandUludag] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GrandUludag] SET ARITHABORT OFF 
GO
ALTER DATABASE [GrandUludag] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [GrandUludag] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GrandUludag] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GrandUludag] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GrandUludag] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GrandUludag] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GrandUludag] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GrandUludag] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GrandUludag] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GrandUludag] SET  DISABLE_BROKER 
GO
ALTER DATABASE [GrandUludag] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GrandUludag] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GrandUludag] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GrandUludag] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GrandUludag] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GrandUludag] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [GrandUludag] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GrandUludag] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [GrandUludag] SET  MULTI_USER 
GO
ALTER DATABASE [GrandUludag] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GrandUludag] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GrandUludag] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GrandUludag] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [GrandUludag] SET DELAYED_DURABILITY = DISABLED 
GO
USE [GrandUludag]
GO
/****** Object:  Table [dbo].[AdminGiris]    Script Date: 13.06.2021 20:59:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdminGiris](
	[Kullanici] [varchar](25) NULL,
	[Sifre] [varchar](25) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Faturalar]    Script Date: 13.06.2021 20:59:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Faturalar](
	[Elektrik] [int] NULL,
	[Su] [int] NULL,
	[İnternet] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mesajlar]    Script Date: 13.06.2021 20:59:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mesajlar](
	[Mesajid] [int] IDENTITY(1,1) NOT NULL,
	[Adsoyad] [varchar](50) NULL,
	[Mesaj] [varchar](1000) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MusteriEkle]    Script Date: 13.06.2021 20:59:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MusteriEkle](
	[Musteriid] [int] IDENTITY(1,1) NOT NULL,
	[Adi] [varchar](30) NULL,
	[Soyadi] [varchar](30) NULL,
	[Cinsiyet] [varchar](5) NULL,
	[Telefon] [varchar](15) NULL,
	[Mail] [varchar](40) NULL,
	[TC] [varchar](12) NULL,
	[OdaNo] [varchar](5) NULL,
	[Ucret] [int] NULL,
	[GirisTarihi] [date] NULL,
	[CikisTarihi] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Oda301]    Script Date: 13.06.2021 20:59:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oda301](
	[Adi] [varchar](50) NULL,
	[Soyadi] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Oda302]    Script Date: 13.06.2021 20:59:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oda302](
	[Adi] [varchar](50) NULL,
	[Soyadi] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Oda303]    Script Date: 13.06.2021 20:59:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oda303](
	[Adi] [varchar](50) NULL,
	[Soyadi] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Oda304]    Script Date: 13.06.2021 20:59:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oda304](
	[Adi] [varchar](50) NULL,
	[Soyadi] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Oda305]    Script Date: 13.06.2021 20:59:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oda305](
	[Adi] [varchar](50) NULL,
	[Soyadi] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Oda306]    Script Date: 13.06.2021 20:59:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oda306](
	[Adi] [varchar](50) NULL,
	[Soyadi] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Oda307]    Script Date: 13.06.2021 20:59:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oda307](
	[Adi] [varchar](50) NULL,
	[Soyadi] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Oda308]    Script Date: 13.06.2021 20:59:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oda308](
	[Adi] [varchar](50) NULL,
	[Soyadi] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Oda309]    Script Date: 13.06.2021 20:59:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oda309](
	[Adi] [varchar](50) NULL,
	[Soyadi] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Stoklar]    Script Date: 13.06.2021 20:59:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stoklar](
	[Gida] [int] NULL,
	[İcecek] [int] NULL,
	[Cerezler] [int] NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[MusteriEkle] ADD  CONSTRAINT [DF_MusteriEkle_GirisTarihi]  DEFAULT (getdate()) FOR [GirisTarihi]
GO
ALTER TABLE [dbo].[MusteriEkle] ADD  CONSTRAINT [DF_MusteriEkle_CikisTarihi]  DEFAULT (getdate()) FOR [CikisTarihi]
GO
USE [master]
GO
ALTER DATABASE [GrandUludag] SET  READ_WRITE 
GO
