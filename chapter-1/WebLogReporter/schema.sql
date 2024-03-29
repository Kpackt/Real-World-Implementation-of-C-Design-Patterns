﻿USE [WebLogReporter]
GO
ALTER TABLE [dbo].[WebLogEntries] DROP CONSTRAINT [DF_WebLogEntries_DateEntered]
    GO
/****** Object:  Table [dbo].[WebLogEntries]    Script Date: 1/16/2022 7:01:09 PM ******/
    IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[WebLogEntries]') AND type in (N'U'))
DROP TABLE [dbo].[WebLogEntries]
    GO
    USE [master]
    GO
/****** Object:  Database [WebLogReporter]    Script Date: 1/16/2022 7:01:09 PM ******/
DROP DATABASE [WebLogReporter]
GO
/****** Object:  Database [WebLogReporter]    Script Date: 1/16/2022 7:01:09 PM ******/
CREATE DATABASE [WebLogReporter]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'WebLogReporter', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\WebLogReporter.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'WebLogReporter_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\WebLogReporter_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [WebLogReporter] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [WebLogReporter].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [WebLogReporter] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [WebLogReporter] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [WebLogReporter] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [WebLogReporter] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [WebLogReporter] SET ARITHABORT OFF 
GO
ALTER DATABASE [WebLogReporter] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [WebLogReporter] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [WebLogReporter] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [WebLogReporter] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [WebLogReporter] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [WebLogReporter] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [WebLogReporter] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [WebLogReporter] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [WebLogReporter] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [WebLogReporter] SET  DISABLE_BROKER 
GO
ALTER DATABASE [WebLogReporter] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [WebLogReporter] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [WebLogReporter] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [WebLogReporter] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [WebLogReporter] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [WebLogReporter] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [WebLogReporter] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [WebLogReporter] SET RECOVERY FULL 
GO
ALTER DATABASE [WebLogReporter] SET  MULTI_USER 
GO
ALTER DATABASE [WebLogReporter] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [WebLogReporter] SET DB_CHAINING OFF 
GO
ALTER DATABASE [WebLogReporter] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [WebLogReporter] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [WebLogReporter] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [WebLogReporter] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'WebLogReporter', N'ON'
GO
ALTER DATABASE [WebLogReporter] SET QUERY_STORE = OFF
GO
USE [WebLogReporter]
GO
/****** Object:  Table [dbo].[WebLogEntries]    Script Date: 1/16/2022 7:01:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WebLogEntries](
    [id] [int] IDENTITY(1,1) NOT NULL,
    [ServerIPAddress] [varchar](15) NULL,
    [RequestDateTime] [datetime] NULL,
    [Verb] [varchar](10) NULL,
    [Route] [varchar](255) NULL,
    [ResponseCode] [int] NULL,
    [SizeInBytes] [int] NULL,
    [RequestingAgent] [varchar](255) NULL,
    [DateEntered] [datetime] NOT NULL,
    CONSTRAINT [PK_WebLogEntries] PRIMARY KEY CLUSTERED
(
[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
    ) ON [PRIMARY]
    GO
ALTER TABLE [dbo].[WebLogEntries] ADD  CONSTRAINT [DF_WebLogEntries_DateEntered]  DEFAULT (getdate()) FOR [DateEntered]
    GO
    USE [master]
    GO
ALTER DATABASE [WebLogReporter] SET  READ_WRITE 
GO
