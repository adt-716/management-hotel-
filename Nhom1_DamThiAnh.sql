USE [master]
GO

/****** Object:  Database [khach_san]    Script Date: 13/01/2024 2:46:10 SA ******/
CREATE DATABASE [khach_san]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'khach_san', FILENAME = N'C:\Users\ĐÀM ANH\khach_san.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'khach_san_log', FILENAME = N'C:\Users\ĐÀM ANH\khach_san_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [khach_san].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [khach_san] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [khach_san] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [khach_san] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [khach_san] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [khach_san] SET ARITHABORT OFF 
GO

ALTER DATABASE [khach_san] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [khach_san] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [khach_san] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [khach_san] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [khach_san] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [khach_san] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [khach_san] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [khach_san] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [khach_san] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [khach_san] SET  DISABLE_BROKER 
GO

ALTER DATABASE [khach_san] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [khach_san] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [khach_san] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [khach_san] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [khach_san] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [khach_san] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [khach_san] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [khach_san] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [khach_san] SET  MULTI_USER 
GO

ALTER DATABASE [khach_san] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [khach_san] SET DB_CHAINING OFF 
GO

ALTER DATABASE [khach_san] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [khach_san] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [khach_san] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [khach_san] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [khach_san] SET QUERY_STORE = OFF
GO

ALTER DATABASE [khach_san] SET  READ_WRITE 
GO

