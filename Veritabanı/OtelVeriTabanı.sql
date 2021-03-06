USE [master]
GO

/****** Object:  Database [GrandUludag]    Script Date: 13.06.2021 20:57:32 ******/
CREATE DATABASE [GrandUludag]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GrandUludag', FILENAME = N'C:\ProgramData\SOLIDWORKS Electrical\MSSQL12.TEW_SQLEXPRESS\MSSQL\DATA\GrandUludag.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'GrandUludag_log', FILENAME = N'C:\ProgramData\SOLIDWORKS Electrical\MSSQL12.TEW_SQLEXPRESS\MSSQL\DATA\GrandUludag_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
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

ALTER DATABASE [GrandUludag] SET  READ_WRITE 
GO

