USE [master]
GO
/****** Object:  Database [QLSUCKHOE]    Script Date: 2018-07-26 5:21:08 PM ******/
CREATE DATABASE [QLSUCKHOE]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLSUCKHOE', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QLSUCKHOE.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLSUCKHOE_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QLSUCKHOE_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLSUCKHOE] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLSUCKHOE].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLSUCKHOE] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLSUCKHOE] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLSUCKHOE] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLSUCKHOE] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLSUCKHOE] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLSUCKHOE] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QLSUCKHOE] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QLSUCKHOE] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLSUCKHOE] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLSUCKHOE] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLSUCKHOE] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLSUCKHOE] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLSUCKHOE] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLSUCKHOE] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLSUCKHOE] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLSUCKHOE] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QLSUCKHOE] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLSUCKHOE] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLSUCKHOE] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLSUCKHOE] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLSUCKHOE] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLSUCKHOE] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLSUCKHOE] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLSUCKHOE] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLSUCKHOE] SET  MULTI_USER 
GO
ALTER DATABASE [QLSUCKHOE] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLSUCKHOE] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLSUCKHOE] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLSUCKHOE] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [QLSUCKHOE]
GO
/****** Object:  StoredProcedure [dbo].[BACSI_DeleteByField]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BACSI_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[BACSI] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)


GO
/****** Object:  StoredProcedure [dbo].[BACSI_DeleteByPrimaryKey]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BACSI_DeleteByPrimaryKey]
	@ID int
AS

DELETE FROM [dbo].[BACSI]
 WHERE 
	[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[BACSI_Insert]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BACSI_Insert]
	@ID int output,
	@HOTEN nvarchar(MAX) = null ,
	@GIOITINH int = null ,
	@SDT nvarchar(MAX) = null ,
	@QUEQUAN nvarchar(MAX) = null ,
	@QUYEN int = null ,
	@NGAYSINH datetime = null ,
	@CAPBACID int = null ,
	@CHUCVUID int = null ,
	@DONVI nvarchar(MAX) = null ,
	@DANTOC nvarchar(MAX) = null ,
	@TRINHDOVANHOA nvarchar(MAX) = null ,
	@DOITUONGID int = null ,
	@DONVIID int = null ,
	@TAIKHOANID int = null ,
	@GHICHU nvarchar(MAX) = null 

AS

INSERT [dbo].[BACSI]
(
	[HOTEN],
	[GIOITINH],
	[SDT],
	[QUEQUAN],
	[QUYEN],
	[NGAYSINH],
	[CAPBACID],
	[CHUCVUID],
	[DONVI],
	[DANTOC],
	[TRINHDOVANHOA],
	[DOITUONGID],
	[DONVIID],
	[TAIKHOANID],
	[GHICHU]

)
VALUES
(
	@HOTEN,
	@GIOITINH,
	@SDT,
	@QUEQUAN,
	@QUYEN,
	@NGAYSINH,
	@CAPBACID,
	@CHUCVUID,
	@DONVI,
	@DANTOC,
	@TRINHDOVANHOA,
	@DOITUONGID,
	@DONVIID,
	@TAIKHOANID,
	@GHICHU

)
	SELECT @ID=SCOPE_IDENTITY();



GO
/****** Object:  StoredProcedure [dbo].[BACSI_SelectAll]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BACSI_SelectAll]
AS

	SELECT 
	*	
	FROM [dbo].[BACSI]


GO
/****** Object:  StoredProcedure [dbo].[BACSI_SelectByField]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BACSI_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT * FROM [dbo].[BACSI] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)


GO
/****** Object:  StoredProcedure [dbo].[BACSI_SelectByPrimaryKey]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BACSI_SelectByPrimaryKey]
	@ID int
AS

	SELECT 
	*	
	FROM [dbo].[BACSI]
	WHERE 
			[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[BACSI_Update]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BACSI_Update]
	@ID int,
	@HOTEN nvarchar(MAX) = null,
	@GIOITINH int = null,
	@SDT nvarchar(MAX) = null,
	@QUEQUAN nvarchar(MAX) = null,
	@QUYEN int = null,
	@NGAYSINH datetime = null,
	@CAPBACID int = null,
	@CHUCVUID int = null,
	@DONVI nvarchar(MAX) = null,
	@DANTOC nvarchar(MAX) = null,
	@TRINHDOVANHOA nvarchar(MAX) = null,
	@DOITUONGID int = null,
	@DONVIID int = null,
	@TAIKHOANID int = null,
	@GHICHU nvarchar(MAX) = null

AS

UPDATE [dbo].[BACSI]
SET
	[HOTEN] = @HOTEN,
	[GIOITINH] = @GIOITINH,
	[SDT] = @SDT,
	[QUEQUAN] = @QUEQUAN,
	[QUYEN] = @QUYEN,
	[NGAYSINH] = @NGAYSINH,
	[CAPBACID] = @CAPBACID,
	[CHUCVUID] = @CHUCVUID,
	[DONVI] = @DONVI,
	[DANTOC] = @DANTOC,
	[TRINHDOVANHOA] = @TRINHDOVANHOA,
	[DOITUONGID] = @DOITUONGID,
	[DONVIID] = @DONVIID,
	[TAIKHOANID] = @TAIKHOANID,
	[GHICHU] = @GHICHU
 WHERE 
	[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[BENH_DeleteByField]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BENH_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[BENH] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)


GO
/****** Object:  StoredProcedure [dbo].[BENH_DeleteByPrimaryKey]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BENH_DeleteByPrimaryKey]
	@ID int
AS

DELETE FROM [dbo].[BENH]
 WHERE 
	[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[BENH_Insert]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BENH_Insert]
	@ID int output,
	@TEN nvarchar(MAX) = null ,
	@MOTA nvarchar(MAX) = null ,
	@LOAIBENHID int = null ,
	@GHICHU nvarchar(MAX) = null 

AS

INSERT [dbo].[BENH]
(
	[TEN],
	[MOTA],
	[LOAIBENHID],
	[GHICHU]

)
VALUES
(
	@TEN,
	@MOTA,
	@LOAIBENHID,
	@GHICHU

)
	SELECT @ID=SCOPE_IDENTITY();



GO
/****** Object:  StoredProcedure [dbo].[BENH_SelectAll]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BENH_SelectAll]
AS

	SELECT 
	*	
	FROM [dbo].[BENH]


GO
/****** Object:  StoredProcedure [dbo].[BENH_SelectByField]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BENH_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT * FROM [dbo].[BENH] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)


GO
/****** Object:  StoredProcedure [dbo].[BENH_SelectByPrimaryKey]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BENH_SelectByPrimaryKey]
	@ID int
AS

	SELECT 
	*	
	FROM [dbo].[BENH]
	WHERE 
			[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[BENH_Update]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BENH_Update]
	@ID int,
	@TEN nvarchar(MAX) = null,
	@MOTA nvarchar(MAX) = null,
	@LOAIBENHID int = null,
	@GHICHU nvarchar(MAX) = null

AS

UPDATE [dbo].[BENH]
SET
	[TEN] = @TEN,
	[MOTA] = @MOTA,
	[LOAIBENHID] = @LOAIBENHID,
	[GHICHU] = @GHICHU
 WHERE 
	[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[BENHNHAN_DeleteByField]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BENHNHAN_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[BENHNHAN] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)


GO
/****** Object:  StoredProcedure [dbo].[BENHNHAN_DeleteByPrimaryKey]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BENHNHAN_DeleteByPrimaryKey]
	@ID int
AS

DELETE FROM [dbo].[BENHNHAN]
 WHERE 
	[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[BENHNHAN_Insert]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BENHNHAN_Insert]
	@ID int output,
	@HOTEN nvarchar(MAX) = null ,
	@GIOITINH int = null ,
	@SDT nvarchar(MAX) = null ,
	@QUEQUAN nvarchar(MAX) = null ,
	@NGAYSINH datetime = null ,
	@MATHEBHYT nvarchar(MAX) = null ,
	@NAMNHAPNGU int = null ,
	@TRINHDOVANHOA nvarchar(MAX) = null ,
	@CAPBACID int = null ,
	@CHUCVUID int = null ,
	@NGHENGHIEPTRUOCNN nvarchar(MAX) = null ,
	@NGHENGHIEPSAUNN nvarchar(MAX) = null ,
	@DOITUONGID int = null ,
	@DONVIID int = null ,
	@TIENSUBANTHAN nvarchar(MAX) = null ,
	@TIENSUGIADINH nvarchar(MAX) = null ,
	@DANTOC nvarchar(MAX) = null ,
	@DIACHI nvarchar(MAX) = null ,
	@TINHTRANGCONGTAC int = null ,
	@NHOMMAU nvarchar(MAX) = null ,
	@DIUNG nvarchar(MAX) = null ,
	@GHICHU nvarchar(MAX) = null 

AS

INSERT [dbo].[BENHNHAN]
(
	[HOTEN],
	[GIOITINH],
	[SDT],
	[QUEQUAN],
	[NGAYSINH],
	[MATHEBHYT],
	[NAMNHAPNGU],
	[TRINHDOVANHOA],
	[CAPBACID],
	[CHUCVUID],
	[NGHENGHIEPTRUOCNN],
	[NGHENGHIEPSAUNN],
	[DOITUONGID],
	[DONVIID],
	[TIENSUBANTHAN],
	[TIENSUGIADINH],
	[DANTOC],
	[DIACHI],
	[TINHTRANGCONGTAC],
	[NHOMMAU],
	[DIUNG],
	[GHICHU]

)
VALUES
(
	@HOTEN,
	@GIOITINH,
	@SDT,
	@QUEQUAN,
	@NGAYSINH,
	@MATHEBHYT,
	@NAMNHAPNGU,
	@TRINHDOVANHOA,
	@CAPBACID,
	@CHUCVUID,
	@NGHENGHIEPTRUOCNN,
	@NGHENGHIEPSAUNN,
	@DOITUONGID,
	@DONVIID,
	@TIENSUBANTHAN,
	@TIENSUGIADINH,
	@DANTOC,
	@DIACHI,
	@TINHTRANGCONGTAC,
	@NHOMMAU,
	@DIUNG,
	@GHICHU

)
	SELECT @ID=SCOPE_IDENTITY();



GO
/****** Object:  StoredProcedure [dbo].[BENHNHAN_SelectAll]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BENHNHAN_SelectAll]
AS

	SELECT 
	*	
	FROM [dbo].[BENHNHAN]


GO
/****** Object:  StoredProcedure [dbo].[BENHNHAN_SelectByField]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BENHNHAN_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT * FROM [dbo].[BENHNHAN] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)


GO
/****** Object:  StoredProcedure [dbo].[BENHNHAN_SelectByPrimaryKey]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BENHNHAN_SelectByPrimaryKey]
	@ID int
AS

	SELECT 
	*	
	FROM [dbo].[BENHNHAN]
	WHERE 
			[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[BENHNHAN_Update]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BENHNHAN_Update]
	@ID int,
	@HOTEN nvarchar(MAX) = null,
	@GIOITINH int = null,
	@SDT nvarchar(MAX) = null,
	@QUEQUAN nvarchar(MAX) = null,
	@NGAYSINH datetime = null,
	@MATHEBHYT nvarchar(MAX) = null,
	@NAMNHAPNGU int = null,
	@TRINHDOVANHOA nvarchar(MAX) = null,
	@CAPBACID int = null,
	@CHUCVUID int = null,
	@NGHENGHIEPTRUOCNN nvarchar(MAX) = null,
	@NGHENGHIEPSAUNN nvarchar(MAX) = null,
	@DOITUONGID int = null,
	@DONVIID int = null,
	@TIENSUBANTHAN nvarchar(MAX) = null,
	@TIENSUGIADINH nvarchar(MAX) = null,
	@DANTOC nvarchar(MAX) = null,
	@DIACHI nvarchar(MAX) = null,
	@TINHTRANGCONGTAC int = null,
	@NHOMMAU nvarchar(MAX) = null,
	@DIUNG nvarchar(MAX) = null,
	@GHICHU nvarchar(MAX) = null

AS

UPDATE [dbo].[BENHNHAN]
SET
	[HOTEN] = @HOTEN,
	[GIOITINH] = @GIOITINH,
	[SDT] = @SDT,
	[QUEQUAN] = @QUEQUAN,
	[NGAYSINH] = @NGAYSINH,
	[MATHEBHYT] = @MATHEBHYT,
	[NAMNHAPNGU] = @NAMNHAPNGU,
	[TRINHDOVANHOA] = @TRINHDOVANHOA,
	[CAPBACID] = @CAPBACID,
	[CHUCVUID] = @CHUCVUID,
	[NGHENGHIEPTRUOCNN] = @NGHENGHIEPTRUOCNN,
	[NGHENGHIEPSAUNN] = @NGHENGHIEPSAUNN,
	[DOITUONGID] = @DOITUONGID,
	[DONVIID] = @DONVIID,
	[TIENSUBANTHAN] = @TIENSUBANTHAN,
	[TIENSUGIADINH] = @TIENSUGIADINH,
	[DANTOC] = @DANTOC,
	[DIACHI] = @DIACHI,
	[TINHTRANGCONGTAC] = @TINHTRANGCONGTAC,
	[NHOMMAU] = @NHOMMAU,
	[DIUNG] = @DIUNG,
	[GHICHU] = @GHICHU
 WHERE 
	[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[BENHVIEN_DeleteByField]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BENHVIEN_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[BENHVIEN] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)


GO
/****** Object:  StoredProcedure [dbo].[BENHVIEN_DeleteByPrimaryKey]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BENHVIEN_DeleteByPrimaryKey]
	@ID int
AS

DELETE FROM [dbo].[BENHVIEN]
 WHERE 
	[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[BENHVIEN_Insert]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BENHVIEN_Insert]
	@ID int output,
	@TEN nvarchar(MAX) = null ,
	@DIACHI nvarchar(MAX) = null ,
	@KIHIEU nvarchar(MAX) = null ,
	@GHICHU nvarchar(MAX) = null 

AS

INSERT [dbo].[BENHVIEN]
(
	[TEN],
	[DIACHI],
	[KIHIEU],
	[GHICHU]

)
VALUES
(
	@TEN,
	@DIACHI,
	@KIHIEU,
	@GHICHU

)
	SELECT @ID=SCOPE_IDENTITY();



GO
/****** Object:  StoredProcedure [dbo].[BENHVIEN_SelectAll]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BENHVIEN_SelectAll]
AS

	SELECT 
	*	
	FROM [dbo].[BENHVIEN]


GO
/****** Object:  StoredProcedure [dbo].[BENHVIEN_SelectByField]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BENHVIEN_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT * FROM [dbo].[BENHVIEN] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)


GO
/****** Object:  StoredProcedure [dbo].[BENHVIEN_SelectByPrimaryKey]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BENHVIEN_SelectByPrimaryKey]
	@ID int
AS

	SELECT 
	*	
	FROM [dbo].[BENHVIEN]
	WHERE 
			[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[BENHVIEN_Update]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BENHVIEN_Update]
	@ID int,
	@TEN nvarchar(MAX) = null,
	@DIACHI nvarchar(MAX) = null,
	@KIHIEU nvarchar(MAX) = null,
	@GHICHU nvarchar(MAX) = null

AS

UPDATE [dbo].[BENHVIEN]
SET
	[TEN] = @TEN,
	[DIACHI] = @DIACHI,
	[KIHIEU] = @KIHIEU,
	[GHICHU] = @GHICHU
 WHERE 
	[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[CAPBAC_DeleteByField]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CAPBAC_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[CAPBAC] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)


GO
/****** Object:  StoredProcedure [dbo].[CAPBAC_DeleteByPrimaryKey]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CAPBAC_DeleteByPrimaryKey]
	@ID int
AS

DELETE FROM [dbo].[CAPBAC]
 WHERE 
	[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[CAPBAC_Insert]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CAPBAC_Insert]
	@ID int output,
	@TEN nvarchar(MAX) = null ,
	@KIHIEU nvarchar(MAX) = null ,
	@CANBOCAPCAO int = null ,
	@GHICHU nvarchar(MAX) = null 

AS

INSERT [dbo].[CAPBAC]
(
	[TEN],
	[KIHIEU],
	[CANBOCAPCAO],
	[GHICHU]

)
VALUES
(
	@TEN,
	@KIHIEU,
	@CANBOCAPCAO,
	@GHICHU

)
	SELECT @ID=SCOPE_IDENTITY();



GO
/****** Object:  StoredProcedure [dbo].[CAPBAC_SelectAll]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CAPBAC_SelectAll]
AS

	SELECT 
	*	
	FROM [dbo].[CAPBAC]


GO
/****** Object:  StoredProcedure [dbo].[CAPBAC_SelectByField]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CAPBAC_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT * FROM [dbo].[CAPBAC] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)


GO
/****** Object:  StoredProcedure [dbo].[CAPBAC_SelectByPrimaryKey]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CAPBAC_SelectByPrimaryKey]
	@ID int
AS

	SELECT 
	*	
	FROM [dbo].[CAPBAC]
	WHERE 
			[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[CAPBAC_Update]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CAPBAC_Update]
	@ID int,
	@TEN nvarchar(MAX) = null,
	@KIHIEU nvarchar(MAX) = null,
	@CANBOCAPCAO int = null,
	@GHICHU nvarchar(MAX) = null

AS

UPDATE [dbo].[CAPBAC]
SET
	[TEN] = @TEN,
	[KIHIEU] = @KIHIEU,
	[CANBOCAPCAO] = @CANBOCAPCAO,
	[GHICHU] = @GHICHU
 WHERE 
	[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[CAPTHUOC_DeleteByField]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CAPTHUOC_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[CAPTHUOC] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)


GO
/****** Object:  StoredProcedure [dbo].[CAPTHUOC_DeleteByPrimaryKey]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CAPTHUOC_DeleteByPrimaryKey]
	@ID int
AS

DELETE FROM [dbo].[CAPTHUOC]
 WHERE 
	[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[CAPTHUOC_Insert]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CAPTHUOC_Insert]
	@ID int output,
	@NGAY datetime = null ,
	@BACSIID int = null ,
	@KHAMTHUONGXUYENID int = null ,
	@GHICHU nvarchar(MAX) = null 

AS

INSERT [dbo].[CAPTHUOC]
(
	[NGAY],
	[BACSIID],
	[KHAMTHUONGXUYENID],
	[GHICHU]

)
VALUES
(
	@NGAY,
	@BACSIID,
	@KHAMTHUONGXUYENID,
	@GHICHU

)
	SELECT @ID=SCOPE_IDENTITY();



GO
/****** Object:  StoredProcedure [dbo].[CAPTHUOC_SelectAll]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CAPTHUOC_SelectAll]
AS

	SELECT 
	*	
	FROM [dbo].[CAPTHUOC]


GO
/****** Object:  StoredProcedure [dbo].[CAPTHUOC_SelectByField]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CAPTHUOC_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT * FROM [dbo].[CAPTHUOC] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)


GO
/****** Object:  StoredProcedure [dbo].[CAPTHUOC_SelectByPrimaryKey]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CAPTHUOC_SelectByPrimaryKey]
	@ID int
AS

	SELECT 
	*	
	FROM [dbo].[CAPTHUOC]
	WHERE 
			[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[CAPTHUOC_Update]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CAPTHUOC_Update]
	@ID int,
	@NGAY datetime = null,
	@BACSIID int = null,
	@KHAMTHUONGXUYENID int = null,
	@GHICHU nvarchar(MAX) = null

AS

UPDATE [dbo].[CAPTHUOC]
SET
	[NGAY] = @NGAY,
	[BACSIID] = @BACSIID,
	[KHAMTHUONGXUYENID] = @KHAMTHUONGXUYENID,
	[GHICHU] = @GHICHU
 WHERE 
	[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[CHITIETCAPTHUOC_DeleteByField]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CHITIETCAPTHUOC_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[CHITIETCAPTHUOC] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)


GO
/****** Object:  StoredProcedure [dbo].[CHITIETCAPTHUOC_DeleteByPrimaryKey]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CHITIETCAPTHUOC_DeleteByPrimaryKey]
	@ID int
AS

DELETE FROM [dbo].[CHITIETCAPTHUOC]
 WHERE 
	[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[CHITIETCAPTHUOC_Insert]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CHITIETCAPTHUOC_Insert]
	@ID int output,
	@CAPTHUOCID int = null ,
	@THUOCID int = null ,
	@SOLUONG int = null ,
	@GHICHU nvarchar(MAX) = null 

AS

INSERT [dbo].[CHITIETCAPTHUOC]
(
	[CAPTHUOCID],
	[THUOCID],
	[SOLUONG],
	[GHICHU]

)
VALUES
(
	@CAPTHUOCID,
	@THUOCID,
	@SOLUONG,
	@GHICHU

)
	SELECT @ID=SCOPE_IDENTITY();



GO
/****** Object:  StoredProcedure [dbo].[CHITIETCAPTHUOC_SelectAll]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CHITIETCAPTHUOC_SelectAll]
AS

	SELECT 
	*	
	FROM [dbo].[CHITIETCAPTHUOC]


GO
/****** Object:  StoredProcedure [dbo].[CHITIETCAPTHUOC_SelectByField]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CHITIETCAPTHUOC_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT * FROM [dbo].[CHITIETCAPTHUOC] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)


GO
/****** Object:  StoredProcedure [dbo].[CHITIETCAPTHUOC_SelectByPrimaryKey]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CHITIETCAPTHUOC_SelectByPrimaryKey]
	@ID int
AS

	SELECT 
	*	
	FROM [dbo].[CHITIETCAPTHUOC]
	WHERE 
			[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[CHITIETCAPTHUOC_Update]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CHITIETCAPTHUOC_Update]
	@ID int,
	@CAPTHUOCID int = null,
	@THUOCID int = null,
	@SOLUONG int = null,
	@GHICHU nvarchar(MAX) = null

AS

UPDATE [dbo].[CHITIETCAPTHUOC]
SET
	[CAPTHUOCID] = @CAPTHUOCID,
	[THUOCID] = @THUOCID,
	[SOLUONG] = @SOLUONG,
	[GHICHU] = @GHICHU
 WHERE 
	[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[CHITIETMUONVATTU_DeleteByField]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CHITIETMUONVATTU_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[CHITIETMUONVATTU] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)


GO
/****** Object:  StoredProcedure [dbo].[CHITIETMUONVATTU_DeleteByPrimaryKey]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CHITIETMUONVATTU_DeleteByPrimaryKey]
	@ID int
AS

DELETE FROM [dbo].[CHITIETMUONVATTU]
 WHERE 
	[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[CHITIETMUONVATTU_Insert]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CHITIETMUONVATTU_Insert]
	@ID int output,
	@MUONVATTUID int = null ,
	@VATTUID int = null ,
	@SOLUONG int = null ,
	@GHICHU nvarchar(MAX) = null 

AS

INSERT [dbo].[CHITIETMUONVATTU]
(
	[MUONVATTUID],
	[VATTUID],
	[SOLUONG],
	[GHICHU]

)
VALUES
(
	@MUONVATTUID,
	@VATTUID,
	@SOLUONG,
	@GHICHU

)
	SELECT @ID=SCOPE_IDENTITY();



GO
/****** Object:  StoredProcedure [dbo].[CHITIETMUONVATTU_SelectAll]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CHITIETMUONVATTU_SelectAll]
AS

	SELECT 
	*	
	FROM [dbo].[CHITIETMUONVATTU]


GO
/****** Object:  StoredProcedure [dbo].[CHITIETMUONVATTU_SelectByField]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CHITIETMUONVATTU_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT * FROM [dbo].[CHITIETMUONVATTU] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)


GO
/****** Object:  StoredProcedure [dbo].[CHITIETMUONVATTU_SelectByPrimaryKey]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CHITIETMUONVATTU_SelectByPrimaryKey]
	@ID int
AS

	SELECT 
	*	
	FROM [dbo].[CHITIETMUONVATTU]
	WHERE 
			[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[CHITIETMUONVATTU_Update]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CHITIETMUONVATTU_Update]
	@ID int,
	@MUONVATTUID int = null,
	@VATTUID int = null,
	@SOLUONG int = null,
	@GHICHU nvarchar(MAX) = null

AS

UPDATE [dbo].[CHITIETMUONVATTU]
SET
	[MUONVATTUID] = @MUONVATTUID,
	[VATTUID] = @VATTUID,
	[SOLUONG] = @SOLUONG,
	[GHICHU] = @GHICHU
 WHERE 
	[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[CHITIETNHAP_DeleteByField]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CHITIETNHAP_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[CHITIETNHAP] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)


GO
/****** Object:  StoredProcedure [dbo].[CHITIETNHAP_DeleteByPrimaryKey]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CHITIETNHAP_DeleteByPrimaryKey]
	@ID int
AS

DELETE FROM [dbo].[CHITIETNHAP]
 WHERE 
	[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[CHITIETNHAP_Insert]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CHITIETNHAP_Insert]
	@ID int output,
	@NHAPTHUOCID int = null ,
	@THUOCID int = null ,
	@SOLUONG int = null ,
	@DONGIA int = null ,
	@THANHTIEN int = null ,
	@GHICHU nvarchar(MAX) = null 

AS

INSERT [dbo].[CHITIETNHAP]
(
	[NHAPTHUOCID],
	[THUOCID],
	[SOLUONG],
	[DONGIA],
	[THANHTIEN],
	[GHICHU]

)
VALUES
(
	@NHAPTHUOCID,
	@THUOCID,
	@SOLUONG,
	@DONGIA,
	@THANHTIEN,
	@GHICHU

)
	SELECT @ID=SCOPE_IDENTITY();



GO
/****** Object:  StoredProcedure [dbo].[CHITIETNHAP_SelectAll]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CHITIETNHAP_SelectAll]
AS

	SELECT 
	*	
	FROM [dbo].[CHITIETNHAP]


GO
/****** Object:  StoredProcedure [dbo].[CHITIETNHAP_SelectByField]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CHITIETNHAP_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT * FROM [dbo].[CHITIETNHAP] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)


GO
/****** Object:  StoredProcedure [dbo].[CHITIETNHAP_SelectByPrimaryKey]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CHITIETNHAP_SelectByPrimaryKey]
	@ID int
AS

	SELECT 
	*	
	FROM [dbo].[CHITIETNHAP]
	WHERE 
			[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[CHITIETNHAP_Update]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CHITIETNHAP_Update]
	@ID int,
	@NHAPTHUOCID int = null,
	@THUOCID int = null,
	@SOLUONG int = null,
	@DONGIA int = null,
	@THANHTIEN int = null,
	@GHICHU nvarchar(MAX) = null

AS

UPDATE [dbo].[CHITIETNHAP]
SET
	[NHAPTHUOCID] = @NHAPTHUOCID,
	[THUOCID] = @THUOCID,
	[SOLUONG] = @SOLUONG,
	[DONGIA] = @DONGIA,
	[THANHTIEN] = @THANHTIEN,
	[GHICHU] = @GHICHU
 WHERE 
	[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[CHUCVU_DeleteByField]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CHUCVU_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[CHUCVU] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)


GO
/****** Object:  StoredProcedure [dbo].[CHUCVU_DeleteByPrimaryKey]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CHUCVU_DeleteByPrimaryKey]
	@ID int
AS

DELETE FROM [dbo].[CHUCVU]
 WHERE 
	[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[CHUCVU_Insert]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CHUCVU_Insert]
	@ID int output,
	@TEN nvarchar(MAX) = null ,
	@KIHIEU nvarchar(MAX) = null ,
	@GHICHU nvarchar(MAX) = null 

AS

INSERT [dbo].[CHUCVU]
(
	[TEN],
	[KIHIEU],
	[GHICHU]

)
VALUES
(
	@TEN,
	@KIHIEU,
	@GHICHU

)
	SELECT @ID=SCOPE_IDENTITY();



GO
/****** Object:  StoredProcedure [dbo].[CHUCVU_SelectAll]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CHUCVU_SelectAll]
AS

	SELECT 
	*	
	FROM [dbo].[CHUCVU]


GO
/****** Object:  StoredProcedure [dbo].[CHUCVU_SelectByField]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CHUCVU_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT * FROM [dbo].[CHUCVU] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)


GO
/****** Object:  StoredProcedure [dbo].[CHUCVU_SelectByPrimaryKey]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CHUCVU_SelectByPrimaryKey]
	@ID int
AS

	SELECT 
	*	
	FROM [dbo].[CHUCVU]
	WHERE 
			[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[CHUCVU_Update]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CHUCVU_Update]
	@ID int,
	@TEN nvarchar(MAX) = null,
	@KIHIEU nvarchar(MAX) = null,
	@GHICHU nvarchar(MAX) = null

AS

UPDATE [dbo].[CHUCVU]
SET
	[TEN] = @TEN,
	[KIHIEU] = @KIHIEU,
	[GHICHU] = @GHICHU
 WHERE 
	[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[DOITUONG_DeleteByField]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DOITUONG_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[DOITUONG] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)


GO
/****** Object:  StoredProcedure [dbo].[DOITUONG_DeleteByPrimaryKey]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DOITUONG_DeleteByPrimaryKey]
	@ID int
AS

DELETE FROM [dbo].[DOITUONG]
 WHERE 
	[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[DOITUONG_Insert]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DOITUONG_Insert]
	@ID int output,
	@TEN nvarchar(MAX) = null ,
	@KYHIEU nvarchar(MAX) = null ,
	@GHICHU nvarchar(MAX) = null 

AS

INSERT [dbo].[DOITUONG]
(
	[TEN],
	[KYHIEU],
	[GHICHU]

)
VALUES
(
	@TEN,
	@KYHIEU,
	@GHICHU

)
	SELECT @ID=SCOPE_IDENTITY();



GO
/****** Object:  StoredProcedure [dbo].[DOITUONG_SelectAll]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DOITUONG_SelectAll]
AS

	SELECT 
	*	
	FROM [dbo].[DOITUONG]


GO
/****** Object:  StoredProcedure [dbo].[DOITUONG_SelectByField]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DOITUONG_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT * FROM [dbo].[DOITUONG] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)


GO
/****** Object:  StoredProcedure [dbo].[DOITUONG_SelectByPrimaryKey]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DOITUONG_SelectByPrimaryKey]
	@ID int
AS

	SELECT 
	*	
	FROM [dbo].[DOITUONG]
	WHERE 
			[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[DOITUONG_Update]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DOITUONG_Update]
	@ID int,
	@TEN nvarchar(MAX) = null,
	@KYHIEU nvarchar(MAX) = null,
	@GHICHU nvarchar(MAX) = null

AS

UPDATE [dbo].[DOITUONG]
SET
	[TEN] = @TEN,
	[KYHIEU] = @KYHIEU,
	[GHICHU] = @GHICHU
 WHERE 
	[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[DONVI_DeleteByField]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DONVI_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[DONVI] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)


GO
/****** Object:  StoredProcedure [dbo].[DONVI_DeleteByPrimaryKey]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DONVI_DeleteByPrimaryKey]
	@ID int
AS

DELETE FROM [dbo].[DONVI]
 WHERE 
	[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[DONVI_Insert]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DONVI_Insert]
	@ID int output,
	@TEN nvarchar(MAX) = null ,
	@KIHIEU nvarchar(MAX) = null ,
	@GHICHU nvarchar(MAX) = null 

AS

INSERT [dbo].[DONVI]
(
	[TEN],
	[KIHIEU],
	[GHICHU]

)
VALUES
(
	@TEN,
	@KIHIEU,
	@GHICHU

)
	SELECT @ID=SCOPE_IDENTITY();



GO
/****** Object:  StoredProcedure [dbo].[DONVI_SelectAll]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DONVI_SelectAll]
AS

	SELECT 
	*	
	FROM [dbo].[DONVI]


GO
/****** Object:  StoredProcedure [dbo].[DONVI_SelectByField]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DONVI_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT * FROM [dbo].[DONVI] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)


GO
/****** Object:  StoredProcedure [dbo].[DONVI_SelectByPrimaryKey]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DONVI_SelectByPrimaryKey]
	@ID int
AS

	SELECT 
	*	
	FROM [dbo].[DONVI]
	WHERE 
			[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[DONVI_Update]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DONVI_Update]
	@ID int,
	@TEN nvarchar(MAX) = null,
	@KIHIEU nvarchar(MAX) = null,
	@GHICHU nvarchar(MAX) = null

AS

UPDATE [dbo].[DONVI]
SET
	[TEN] = @TEN,
	[KIHIEU] = @KIHIEU,
	[GHICHU] = @GHICHU
 WHERE 
	[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[GIAYGIOITHIEU_DeleteByField]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GIAYGIOITHIEU_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[GIAYGIOITHIEU] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)


GO
/****** Object:  StoredProcedure [dbo].[GIAYGIOITHIEU_DeleteByPrimaryKey]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GIAYGIOITHIEU_DeleteByPrimaryKey]
	@ID int
AS

DELETE FROM [dbo].[GIAYGIOITHIEU]
 WHERE 
	[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[GIAYGIOITHIEU_Insert]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GIAYGIOITHIEU_Insert]
	@ID int output,
	@NGAY datetime = null ,
	@KHAMTHUONGXUYENID int = null ,
	@YKIENDENGHI nvarchar(MAX) = null ,
	@GHICHU nvarchar(MAX) = null 

AS

INSERT [dbo].[GIAYGIOITHIEU]
(
	[NGAY],
	[KHAMTHUONGXUYENID],
	[YKIENDENGHI],
	[GHICHU]

)
VALUES
(
	@NGAY,
	@KHAMTHUONGXUYENID,
	@YKIENDENGHI,
	@GHICHU

)
	SELECT @ID=SCOPE_IDENTITY();



GO
/****** Object:  StoredProcedure [dbo].[GIAYGIOITHIEU_SelectAll]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GIAYGIOITHIEU_SelectAll]
AS

	SELECT 
	*	
	FROM [dbo].[GIAYGIOITHIEU]


GO
/****** Object:  StoredProcedure [dbo].[GIAYGIOITHIEU_SelectByField]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GIAYGIOITHIEU_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT * FROM [dbo].[GIAYGIOITHIEU] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)


GO
/****** Object:  StoredProcedure [dbo].[GIAYGIOITHIEU_SelectByPrimaryKey]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GIAYGIOITHIEU_SelectByPrimaryKey]
	@ID int
AS

	SELECT 
	*	
	FROM [dbo].[GIAYGIOITHIEU]
	WHERE 
			[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[GIAYGIOITHIEU_Update]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GIAYGIOITHIEU_Update]
	@ID int,
	@NGAY datetime = null,
	@KHAMTHUONGXUYENID int = null,
	@YKIENDENGHI nvarchar(MAX) = null,
	@GHICHU nvarchar(MAX) = null

AS

UPDATE [dbo].[GIAYGIOITHIEU]
SET
	[NGAY] = @NGAY,
	[KHAMTHUONGXUYENID] = @KHAMTHUONGXUYENID,
	[YKIENDENGHI] = @YKIENDENGHI,
	[GHICHU] = @GHICHU
 WHERE 
	[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[KHAMCANLAMSANG_DeleteByField]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[KHAMCANLAMSANG_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[KHAMCANLAMSANG] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)


GO
/****** Object:  StoredProcedure [dbo].[KHAMCANLAMSANG_DeleteByPrimaryKey]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[KHAMCANLAMSANG_DeleteByPrimaryKey]
	@ID int
AS

DELETE FROM [dbo].[KHAMCANLAMSANG]
 WHERE 
	[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[KHAMCANLAMSANG_Insert]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[KHAMCANLAMSANG_Insert]
	@ID int output,
	@BACSIID int = null ,
	@MAU nvarchar(MAX) = null ,
	@NUOCTIEU nvarchar(MAX) = null ,
	@SIEUAM nvarchar(MAX) = null ,
	@DIENTIM nvarchar(MAX) = null ,
	@XQUANG nvarchar(MAX) = null ,
	@XETNGHIEMKHAC nvarchar(MAX) = null ,
	@KETQUACANLAMSANG nvarchar(MAX) = null ,
	@GHICHU nvarchar(MAX) = null 

AS

INSERT [dbo].[KHAMCANLAMSANG]
(
	[BACSIID],
	[MAU],
	[NUOCTIEU],
	[SIEUAM],
	[DIENTIM],
	[XQUANG],
	[XETNGHIEMKHAC],
	[KETQUACANLAMSANG],
	[GHICHU]

)
VALUES
(
	@BACSIID,
	@MAU,
	@NUOCTIEU,
	@SIEUAM,
	@DIENTIM,
	@XQUANG,
	@XETNGHIEMKHAC,
	@KETQUACANLAMSANG,
	@GHICHU

)
	SELECT @ID=SCOPE_IDENTITY();



GO
/****** Object:  StoredProcedure [dbo].[KHAMCANLAMSANG_SelectAll]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[KHAMCANLAMSANG_SelectAll]
AS

	SELECT 
	*	
	FROM [dbo].[KHAMCANLAMSANG]


GO
/****** Object:  StoredProcedure [dbo].[KHAMCANLAMSANG_SelectByField]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[KHAMCANLAMSANG_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT * FROM [dbo].[KHAMCANLAMSANG] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)


GO
/****** Object:  StoredProcedure [dbo].[KHAMCANLAMSANG_SelectByPrimaryKey]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[KHAMCANLAMSANG_SelectByPrimaryKey]
	@ID int
AS

	SELECT 
	*	
	FROM [dbo].[KHAMCANLAMSANG]
	WHERE 
			[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[KHAMCANLAMSANG_Update]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[KHAMCANLAMSANG_Update]
	@ID int,
	@BACSIID int = null,
	@MAU nvarchar(MAX) = null,
	@NUOCTIEU nvarchar(MAX) = null,
	@SIEUAM nvarchar(MAX) = null,
	@DIENTIM nvarchar(MAX) = null,
	@XQUANG nvarchar(MAX) = null,
	@XETNGHIEMKHAC nvarchar(MAX) = null,
	@KETQUACANLAMSANG nvarchar(MAX) = null,
	@GHICHU nvarchar(MAX) = null

AS

UPDATE [dbo].[KHAMCANLAMSANG]
SET
	[BACSIID] = @BACSIID,
	[MAU] = @MAU,
	[NUOCTIEU] = @NUOCTIEU,
	[SIEUAM] = @SIEUAM,
	[DIENTIM] = @DIENTIM,
	[XQUANG] = @XQUANG,
	[XETNGHIEMKHAC] = @XETNGHIEMKHAC,
	[KETQUACANLAMSANG] = @KETQUACANLAMSANG,
	[GHICHU] = @GHICHU
 WHERE 
	[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[KHAMCHUYENKHOA_DeleteByField]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[KHAMCHUYENKHOA_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[KHAMCHUYENKHOA] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)


GO
/****** Object:  StoredProcedure [dbo].[KHAMCHUYENKHOA_DeleteByPrimaryKey]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[KHAMCHUYENKHOA_DeleteByPrimaryKey]
	@ID int
AS

DELETE FROM [dbo].[KHAMCHUYENKHOA]
 WHERE 
	[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[KHAMCHUYENKHOA_Insert]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[KHAMCHUYENKHOA_Insert]
	@ID int output,
	@BACSIID int = null ,
	@TAI nvarchar(MAX) = null ,
	@MUI nvarchar(MAX) = null ,
	@HONG nvarchar(MAX) = null ,
	@RANG nvarchar(MAX) = null ,
	@HAM nvarchar(MAX) = null ,
	@MAT nvarchar(MAX) = null ,
	@KHAC nvarchar(MAX) = null ,
	@GHICHU nvarchar(MAX) = null 

AS

INSERT [dbo].[KHAMCHUYENKHOA]
(
	[BACSIID],
	[TAI],
	[MUI],
	[HONG],
	[RANG],
	[HAM],
	[MAT],
	[KHAC],
	[GHICHU]

)
VALUES
(
	@BACSIID,
	@TAI,
	@MUI,
	@HONG,
	@RANG,
	@HAM,
	@MAT,
	@KHAC,
	@GHICHU

)
	SELECT @ID=SCOPE_IDENTITY();



GO
/****** Object:  StoredProcedure [dbo].[KHAMCHUYENKHOA_SelectAll]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[KHAMCHUYENKHOA_SelectAll]
AS

	SELECT 
	*	
	FROM [dbo].[KHAMCHUYENKHOA]


GO
/****** Object:  StoredProcedure [dbo].[KHAMCHUYENKHOA_SelectByField]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[KHAMCHUYENKHOA_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT * FROM [dbo].[KHAMCHUYENKHOA] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)


GO
/****** Object:  StoredProcedure [dbo].[KHAMCHUYENKHOA_SelectByPrimaryKey]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[KHAMCHUYENKHOA_SelectByPrimaryKey]
	@ID int
AS

	SELECT 
	*	
	FROM [dbo].[KHAMCHUYENKHOA]
	WHERE 
			[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[KHAMCHUYENKHOA_Update]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[KHAMCHUYENKHOA_Update]
	@ID int,
	@BACSIID int = null,
	@TAI nvarchar(MAX) = null,
	@MUI nvarchar(MAX) = null,
	@HONG nvarchar(MAX) = null,
	@RANG nvarchar(MAX) = null,
	@HAM nvarchar(MAX) = null,
	@MAT nvarchar(MAX) = null,
	@KHAC nvarchar(MAX) = null,
	@GHICHU nvarchar(MAX) = null

AS

UPDATE [dbo].[KHAMCHUYENKHOA]
SET
	[BACSIID] = @BACSIID,
	[TAI] = @TAI,
	[MUI] = @MUI,
	[HONG] = @HONG,
	[RANG] = @RANG,
	[HAM] = @HAM,
	[MAT] = @MAT,
	[KHAC] = @KHAC,
	[GHICHU] = @GHICHU
 WHERE 
	[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[KHAMDINHKI_DeleteByField]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[KHAMDINHKI_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[KHAMDINHKI] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)


GO
/****** Object:  StoredProcedure [dbo].[KHAMDINHKI_DeleteByPrimaryKey]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[KHAMDINHKI_DeleteByPrimaryKey]
	@ID int
AS

DELETE FROM [dbo].[KHAMDINHKI]
 WHERE 
	[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[KHAMDINHKI_Insert]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[KHAMDINHKI_Insert]
	@ID int output,
	@BENHNHANID int = null ,
	@PHANLOAISUCKHOEID int = null ,
	@BACSIID int = null ,
	@KHAMTHELUCID int = null ,
	@KHAMCANLAMSANGID int = null ,
	@KHAMCHUYENKHOAID int = null ,
	@KETLUAN nvarchar(MAX) = null ,
	@THOIGIANKHAM datetime = null ,
	@LOAIHINHKHAM int = null ,
	@BENHHIEMNGHEO int = null ,
	@GHICHU nvarchar(MAX) = null 

AS

INSERT [dbo].[KHAMDINHKI]
(
	[BENHNHANID],
	[PHANLOAISUCKHOEID],
	[BACSIID],
	[KHAMTHELUCID],
	[KHAMCANLAMSANGID],
	[KHAMCHUYENKHOAID],
	[KETLUAN],
	[THOIGIANKHAM],
	[LOAIHINHKHAM],
	[BENHHIEMNGHEO],
	[GHICHU]

)
VALUES
(
	@BENHNHANID,
	@PHANLOAISUCKHOEID,
	@BACSIID,
	@KHAMTHELUCID,
	@KHAMCANLAMSANGID,
	@KHAMCHUYENKHOAID,
	@KETLUAN,
	@THOIGIANKHAM,
	@LOAIHINHKHAM,
	@BENHHIEMNGHEO,
	@GHICHU

)
	SELECT @ID=SCOPE_IDENTITY();



GO
/****** Object:  StoredProcedure [dbo].[KHAMDINHKI_SelectAll]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[KHAMDINHKI_SelectAll]
AS

	SELECT 
	*	
	FROM [dbo].[KHAMDINHKI]


GO
/****** Object:  StoredProcedure [dbo].[KHAMDINHKI_SelectByField]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[KHAMDINHKI_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT * FROM [dbo].[KHAMDINHKI] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)


GO
/****** Object:  StoredProcedure [dbo].[KHAMDINHKI_SelectByPrimaryKey]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[KHAMDINHKI_SelectByPrimaryKey]
	@ID int
AS

	SELECT 
	*	
	FROM [dbo].[KHAMDINHKI]
	WHERE 
			[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[KHAMDINHKI_Update]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[KHAMDINHKI_Update]
	@ID int,
	@BENHNHANID int = null,
	@PHANLOAISUCKHOEID int = null,
	@BACSIID int = null,
	@KHAMTHELUCID int = null,
	@KHAMCANLAMSANGID int = null,
	@KHAMCHUYENKHOAID int = null,
	@KETLUAN nvarchar(MAX) = null,
	@THOIGIANKHAM datetime = null,
	@LOAIHINHKHAM int = null,
	@BENHHIEMNGHEO int = null,
	@GHICHU nvarchar(MAX) = null

AS

UPDATE [dbo].[KHAMDINHKI]
SET
	[BENHNHANID] = @BENHNHANID,
	[PHANLOAISUCKHOEID] = @PHANLOAISUCKHOEID,
	[BACSIID] = @BACSIID,
	[KHAMTHELUCID] = @KHAMTHELUCID,
	[KHAMCANLAMSANGID] = @KHAMCANLAMSANGID,
	[KHAMCHUYENKHOAID] = @KHAMCHUYENKHOAID,
	[KETLUAN] = @KETLUAN,
	[THOIGIANKHAM] = @THOIGIANKHAM,
	[LOAIHINHKHAM] = @LOAIHINHKHAM,
	[BENHHIEMNGHEO] = @BENHHIEMNGHEO,
	[GHICHU] = @GHICHU
 WHERE 
	[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[KHAMTHELUC_DeleteByField]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[KHAMTHELUC_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[KHAMTHELUC] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)


GO
/****** Object:  StoredProcedure [dbo].[KHAMTHELUC_DeleteByPrimaryKey]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[KHAMTHELUC_DeleteByPrimaryKey]
	@ID int
AS

DELETE FROM [dbo].[KHAMTHELUC]
 WHERE 
	[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[KHAMTHELUC_Insert]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[KHAMTHELUC_Insert]
	@ID int output,
	@BACSIID int = null ,
	@CHIEUCAO nvarchar(MAX) = null ,
	@CANNANG int = null ,
	@MACH nvarchar(MAX) = null ,
	@HUYETAP nvarchar(MAX) = null ,
	@VONGNGUC int = null ,
	@NHIETDO int = null ,
	@KETQUALAMSANG nvarchar(MAX) = null ,
	@GHICHU nvarchar(MAX) = null 

AS

INSERT [dbo].[KHAMTHELUC]
(
	[BACSIID],
	[CHIEUCAO],
	[CANNANG],
	[MACH],
	[HUYETAP],
	[VONGNGUC],
	[NHIETDO],
	[KETQUALAMSANG],
	[GHICHU]

)
VALUES
(
	@BACSIID,
	@CHIEUCAO,
	@CANNANG,
	@MACH,
	@HUYETAP,
	@VONGNGUC,
	@NHIETDO,
	@KETQUALAMSANG,
	@GHICHU

)
	SELECT @ID=SCOPE_IDENTITY();



GO
/****** Object:  StoredProcedure [dbo].[KHAMTHELUC_SelectAll]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[KHAMTHELUC_SelectAll]
AS

	SELECT 
	*	
	FROM [dbo].[KHAMTHELUC]


GO
/****** Object:  StoredProcedure [dbo].[KHAMTHELUC_SelectByField]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[KHAMTHELUC_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT * FROM [dbo].[KHAMTHELUC] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)


GO
/****** Object:  StoredProcedure [dbo].[KHAMTHELUC_SelectByPrimaryKey]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[KHAMTHELUC_SelectByPrimaryKey]
	@ID int
AS

	SELECT 
	*	
	FROM [dbo].[KHAMTHELUC]
	WHERE 
			[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[KHAMTHELUC_Update]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[KHAMTHELUC_Update]
	@ID int,
	@BACSIID int = null,
	@CHIEUCAO nvarchar(MAX) = null,
	@CANNANG int = null,
	@MACH nvarchar(MAX) = null,
	@HUYETAP nvarchar(MAX) = null,
	@VONGNGUC int = null,
	@NHIETDO int = null,
	@KETQUALAMSANG nvarchar(MAX) = null,
	@GHICHU nvarchar(MAX) = null

AS

UPDATE [dbo].[KHAMTHELUC]
SET
	[BACSIID] = @BACSIID,
	[CHIEUCAO] = @CHIEUCAO,
	[CANNANG] = @CANNANG,
	[MACH] = @MACH,
	[HUYETAP] = @HUYETAP,
	[VONGNGUC] = @VONGNGUC,
	[NHIETDO] = @NHIETDO,
	[KETQUALAMSANG] = @KETQUALAMSANG,
	[GHICHU] = @GHICHU
 WHERE 
	[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[KHAMTHUONGXUYEN_DeleteByField]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[KHAMTHUONGXUYEN_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[KHAMTHUONGXUYEN] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)


GO
/****** Object:  StoredProcedure [dbo].[KHAMTHUONGXUYEN_DeleteByPrimaryKey]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[KHAMTHUONGXUYEN_DeleteByPrimaryKey]
	@ID int
AS

DELETE FROM [dbo].[KHAMTHUONGXUYEN]
 WHERE 
	[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[KHAMTHUONGXUYEN_Insert]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[KHAMTHUONGXUYEN_Insert]
	@ID int output,
	@BENHNHANID int = null ,
	@BACSIID int = null ,
	@THOIGIAN datetime = null ,
	@BENHID int = null ,
	@CHANDOANSOBO nvarchar(MAX) = null ,
	@CACHGIAIQUYET int = null ,
	@THOIGIANCHUYEN datetime = null ,
	@BENHVIENID int = null ,
	@THOIGIANVAO datetime = null ,
	@THOIGIANRA datetime = null ,
	@PHUONGPHAPDIEUTRI nvarchar(MAX) = null ,
	@KETQUADIEUTRI varchar(MAX) = null ,
	@CHIPHIKHAM int = null ,
	@GHICHU nvarchar(MAX) = null ,
	@TRIEUCHUNG nvarchar(MAX) = null 

AS

INSERT [dbo].[KHAMTHUONGXUYEN]
(
	[BENHNHANID],
	[BACSIID],
	[THOIGIAN],
	[BENHID],
	[CHANDOANSOBO],
	[CACHGIAIQUYET],
	[THOIGIANCHUYEN],
	[BENHVIENID],
	[THOIGIANVAO],
	[THOIGIANRA],
	[PHUONGPHAPDIEUTRI],
	[KETQUADIEUTRI],
	[CHIPHIKHAM],
	[GHICHU],
	[TRIEUCHUNG]

)
VALUES
(
	@BENHNHANID,
	@BACSIID,
	@THOIGIAN,
	@BENHID,
	@CHANDOANSOBO,
	@CACHGIAIQUYET,
	@THOIGIANCHUYEN,
	@BENHVIENID,
	@THOIGIANVAO,
	@THOIGIANRA,
	@PHUONGPHAPDIEUTRI,
	@KETQUADIEUTRI,
	@CHIPHIKHAM,
	@GHICHU,
	@TRIEUCHUNG

)
	SELECT @ID=SCOPE_IDENTITY();



GO
/****** Object:  StoredProcedure [dbo].[KHAMTHUONGXUYEN_SelectAll]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[KHAMTHUONGXUYEN_SelectAll]
AS

	SELECT 
	*	
	FROM [dbo].[KHAMTHUONGXUYEN]


GO
/****** Object:  StoredProcedure [dbo].[KHAMTHUONGXUYEN_SelectByField]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[KHAMTHUONGXUYEN_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT * FROM [dbo].[KHAMTHUONGXUYEN] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)


GO
/****** Object:  StoredProcedure [dbo].[KHAMTHUONGXUYEN_SelectByPrimaryKey]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[KHAMTHUONGXUYEN_SelectByPrimaryKey]
	@ID int
AS

	SELECT 
	*	
	FROM [dbo].[KHAMTHUONGXUYEN]
	WHERE 
			[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[KHAMTHUONGXUYEN_Update]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[KHAMTHUONGXUYEN_Update]
	@ID int,
	@BENHNHANID int = null,
	@BACSIID int = null,
	@THOIGIAN datetime = null,
	@BENHID int = null,
	@CHANDOANSOBO nvarchar(MAX) = null,
	@CACHGIAIQUYET int = null,
	@THOIGIANCHUYEN datetime = null,
	@BENHVIENID int = null,
	@THOIGIANVAO datetime = null,
	@THOIGIANRA datetime = null,
	@PHUONGPHAPDIEUTRI nvarchar(MAX) = null,
	@KETQUADIEUTRI varchar(MAX) = null,
	@CHIPHIKHAM int = null,
	@GHICHU nvarchar(MAX) = null,
	@TRIEUCHUNG nvarchar(MAX) = null

AS

UPDATE [dbo].[KHAMTHUONGXUYEN]
SET
	[BENHNHANID] = @BENHNHANID,
	[BACSIID] = @BACSIID,
	[THOIGIAN] = @THOIGIAN,
	[BENHID] = @BENHID,
	[CHANDOANSOBO] = @CHANDOANSOBO,
	[CACHGIAIQUYET] = @CACHGIAIQUYET,
	[THOIGIANCHUYEN] = @THOIGIANCHUYEN,
	[BENHVIENID] = @BENHVIENID,
	[THOIGIANVAO] = @THOIGIANVAO,
	[THOIGIANRA] = @THOIGIANRA,
	[PHUONGPHAPDIEUTRI] = @PHUONGPHAPDIEUTRI,
	[KETQUADIEUTRI] = @KETQUADIEUTRI,
	[CHIPHIKHAM] = @CHIPHIKHAM,
	[GHICHU] = @GHICHU,
	[TRIEUCHUNG] = @TRIEUCHUNG
 WHERE 
	[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[LOAIBENH_DeleteByField]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LOAIBENH_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[LOAIBENH] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)


GO
/****** Object:  StoredProcedure [dbo].[LOAIBENH_DeleteByPrimaryKey]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LOAIBENH_DeleteByPrimaryKey]
	@ID int
AS

DELETE FROM [dbo].[LOAIBENH]
 WHERE 
	[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[LOAIBENH_Insert]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LOAIBENH_Insert]
	@ID int output,
	@TEN nvarchar(MAX) = null ,
	@NHOMBENHID int = null ,
	@GHICHU nvarchar(MAX) = null 

AS

INSERT [dbo].[LOAIBENH]
(
	[TEN],
	[NHOMBENHID],
	[GHICHU]

)
VALUES
(
	@TEN,
	@NHOMBENHID,
	@GHICHU

)
	SELECT @ID=SCOPE_IDENTITY();



GO
/****** Object:  StoredProcedure [dbo].[LOAIBENH_SelectAll]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LOAIBENH_SelectAll]
AS

	SELECT 
	*	
	FROM [dbo].[LOAIBENH]


GO
/****** Object:  StoredProcedure [dbo].[LOAIBENH_SelectByField]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LOAIBENH_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT * FROM [dbo].[LOAIBENH] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)


GO
/****** Object:  StoredProcedure [dbo].[LOAIBENH_SelectByPrimaryKey]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LOAIBENH_SelectByPrimaryKey]
	@ID int
AS

	SELECT 
	*	
	FROM [dbo].[LOAIBENH]
	WHERE 
			[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[LOAIBENH_Update]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LOAIBENH_Update]
	@ID int,
	@TEN nvarchar(MAX) = null,
	@NHOMBENHID int = null,
	@GHICHU nvarchar(MAX) = null

AS

UPDATE [dbo].[LOAIBENH]
SET
	[TEN] = @TEN,
	[NHOMBENHID] = @NHOMBENHID,
	[GHICHU] = @GHICHU
 WHERE 
	[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[MUONVATTU_DeleteByField]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MUONVATTU_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[MUONVATTU] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)


GO
/****** Object:  StoredProcedure [dbo].[MUONVATTU_DeleteByPrimaryKey]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MUONVATTU_DeleteByPrimaryKey]
	@ID int
AS

DELETE FROM [dbo].[MUONVATTU]
 WHERE 
	[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[MUONVATTU_Insert]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MUONVATTU_Insert]
	@ID int output,
	@NGAYMUON datetime = null ,
	@NGAYTRA datetime = null ,
	@GHICHU nvarchar(MAX) = null ,
	@BACSIMUONID int = null ,
	@BACSITRAID int = null ,
	@KHAMTHUONGXUYENID int = null ,
	@TRANGTHAI int = null 

AS

INSERT [dbo].[MUONVATTU]
(
	[NGAYMUON],
	[NGAYTRA],
	[GHICHU],
	[BACSIMUONID],
	[BACSITRAID],
	[KHAMTHUONGXUYENID],
	[TRANGTHAI]

)
VALUES
(
	@NGAYMUON,
	@NGAYTRA,
	@GHICHU,
	@BACSIMUONID,
	@BACSITRAID,
	@KHAMTHUONGXUYENID,
	@TRANGTHAI

)
	SELECT @ID=SCOPE_IDENTITY();



GO
/****** Object:  StoredProcedure [dbo].[MUONVATTU_SelectAll]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MUONVATTU_SelectAll]
AS

	SELECT 
	*	
	FROM [dbo].[MUONVATTU]


GO
/****** Object:  StoredProcedure [dbo].[MUONVATTU_SelectByField]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MUONVATTU_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT * FROM [dbo].[MUONVATTU] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)


GO
/****** Object:  StoredProcedure [dbo].[MUONVATTU_SelectByPrimaryKey]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MUONVATTU_SelectByPrimaryKey]
	@ID int
AS

	SELECT 
	*	
	FROM [dbo].[MUONVATTU]
	WHERE 
			[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[MUONVATTU_Update]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MUONVATTU_Update]
	@ID int,
	@NGAYMUON datetime = null,
	@NGAYTRA datetime = null,
	@GHICHU nvarchar(MAX) = null,
	@BACSIMUONID int = null,
	@BACSITRAID int = null,
	@KHAMTHUONGXUYENID int = null,
	@TRANGTHAI int = null

AS

UPDATE [dbo].[MUONVATTU]
SET
	[NGAYMUON] = @NGAYMUON,
	[NGAYTRA] = @NGAYTRA,
	[GHICHU] = @GHICHU,
	[BACSIMUONID] = @BACSIMUONID,
	[BACSITRAID] = @BACSITRAID,
	[KHAMTHUONGXUYENID] = @KHAMTHUONGXUYENID,
	[TRANGTHAI] = @TRANGTHAI
 WHERE 
	[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[NHAPTHUOC_DeleteByField]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NHAPTHUOC_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[NHAPTHUOC] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)


GO
/****** Object:  StoredProcedure [dbo].[NHAPTHUOC_DeleteByPrimaryKey]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NHAPTHUOC_DeleteByPrimaryKey]
	@ID int
AS

DELETE FROM [dbo].[NHAPTHUOC]
 WHERE 
	[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[NHAPTHUOC_Insert]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NHAPTHUOC_Insert]
	@ID int output,
	@NGAY datetime = null ,
	@BACSIID int = null ,
	@TONGTIEN int = null ,
	@GHICHU nvarchar(MAX) = null 

AS

INSERT [dbo].[NHAPTHUOC]
(
	[NGAY],
	[BACSIID],
	[TONGTIEN],
	[GHICHU]

)
VALUES
(
	@NGAY,
	@BACSIID,
	@TONGTIEN,
	@GHICHU

)
	SELECT @ID=SCOPE_IDENTITY();



GO
/****** Object:  StoredProcedure [dbo].[NHAPTHUOC_SelectAll]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NHAPTHUOC_SelectAll]
AS

	SELECT 
	*	
	FROM [dbo].[NHAPTHUOC]


GO
/****** Object:  StoredProcedure [dbo].[NHAPTHUOC_SelectByField]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NHAPTHUOC_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT * FROM [dbo].[NHAPTHUOC] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)


GO
/****** Object:  StoredProcedure [dbo].[NHAPTHUOC_SelectByPrimaryKey]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NHAPTHUOC_SelectByPrimaryKey]
	@ID int
AS

	SELECT 
	*	
	FROM [dbo].[NHAPTHUOC]
	WHERE 
			[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[NHAPTHUOC_Update]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NHAPTHUOC_Update]
	@ID int,
	@NGAY datetime = null,
	@BACSIID int = null,
	@TONGTIEN int = null,
	@GHICHU nvarchar(MAX) = null

AS

UPDATE [dbo].[NHAPTHUOC]
SET
	[NGAY] = @NGAY,
	[BACSIID] = @BACSIID,
	[TONGTIEN] = @TONGTIEN,
	[GHICHU] = @GHICHU
 WHERE 
	[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[NHOMBENH_DeleteByField]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NHOMBENH_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[NHOMBENH] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)


GO
/****** Object:  StoredProcedure [dbo].[NHOMBENH_DeleteByPrimaryKey]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NHOMBENH_DeleteByPrimaryKey]
	@ID int
AS

DELETE FROM [dbo].[NHOMBENH]
 WHERE 
	[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[NHOMBENH_Insert]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NHOMBENH_Insert]
	@ID int output,
	@TEN nvarchar(MAX) = null ,
	@GHICHU nvarchar(MAX) = null 

AS

INSERT [dbo].[NHOMBENH]
(
	[TEN],
	[GHICHU]

)
VALUES
(
	@TEN,
	@GHICHU

)
	SELECT @ID=SCOPE_IDENTITY();



GO
/****** Object:  StoredProcedure [dbo].[NHOMBENH_SelectAll]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NHOMBENH_SelectAll]
AS

	SELECT 
	*	
	FROM [dbo].[NHOMBENH]


GO
/****** Object:  StoredProcedure [dbo].[NHOMBENH_SelectByField]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NHOMBENH_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT * FROM [dbo].[NHOMBENH] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)


GO
/****** Object:  StoredProcedure [dbo].[NHOMBENH_SelectByPrimaryKey]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NHOMBENH_SelectByPrimaryKey]
	@ID int
AS

	SELECT 
	*	
	FROM [dbo].[NHOMBENH]
	WHERE 
			[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[NHOMBENH_Update]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NHOMBENH_Update]
	@ID int,
	@TEN nvarchar(MAX) = null,
	@GHICHU nvarchar(MAX) = null

AS

UPDATE [dbo].[NHOMBENH]
SET
	[TEN] = @TEN,
	[GHICHU] = @GHICHU
 WHERE 
	[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[PHANLOAISUCKHOE_DeleteByField]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PHANLOAISUCKHOE_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[PHANLOAISUCKHOE] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)


GO
/****** Object:  StoredProcedure [dbo].[PHANLOAISUCKHOE_DeleteByPrimaryKey]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PHANLOAISUCKHOE_DeleteByPrimaryKey]
	@ID int
AS

DELETE FROM [dbo].[PHANLOAISUCKHOE]
 WHERE 
	[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[PHANLOAISUCKHOE_Insert]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PHANLOAISUCKHOE_Insert]
	@ID int output,
	@TEN nvarchar(MAX) = null ,
	@KIHIEU nvarchar(MAX) = null ,
	@GHICHU nvarchar(MAX) = null 

AS

INSERT [dbo].[PHANLOAISUCKHOE]
(
	[TEN],
	[KIHIEU],
	[GHICHU]

)
VALUES
(
	@TEN,
	@KIHIEU,
	@GHICHU

)
	SELECT @ID=SCOPE_IDENTITY();



GO
/****** Object:  StoredProcedure [dbo].[PHANLOAISUCKHOE_SelectAll]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PHANLOAISUCKHOE_SelectAll]
AS

	SELECT 
	*	
	FROM [dbo].[PHANLOAISUCKHOE]


GO
/****** Object:  StoredProcedure [dbo].[PHANLOAISUCKHOE_SelectByField]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PHANLOAISUCKHOE_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT * FROM [dbo].[PHANLOAISUCKHOE] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)


GO
/****** Object:  StoredProcedure [dbo].[PHANLOAISUCKHOE_SelectByPrimaryKey]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PHANLOAISUCKHOE_SelectByPrimaryKey]
	@ID int
AS

	SELECT 
	*	
	FROM [dbo].[PHANLOAISUCKHOE]
	WHERE 
			[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[PHANLOAISUCKHOE_Update]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PHANLOAISUCKHOE_Update]
	@ID int,
	@TEN nvarchar(MAX) = null,
	@KIHIEU nvarchar(MAX) = null,
	@GHICHU nvarchar(MAX) = null

AS

UPDATE [dbo].[PHANLOAISUCKHOE]
SET
	[TEN] = @TEN,
	[KIHIEU] = @KIHIEU,
	[GHICHU] = @GHICHU
 WHERE 
	[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[TAIKHOAN_DeleteByField]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TAIKHOAN_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[TAIKHOAN] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)


GO
/****** Object:  StoredProcedure [dbo].[TAIKHOAN_DeleteByPrimaryKey]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TAIKHOAN_DeleteByPrimaryKey]
	@ID int
AS

DELETE FROM [dbo].[TAIKHOAN]
 WHERE 
	[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[TAIKHOAN_Insert]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TAIKHOAN_Insert]
	@ID int output,
	@TENDANGNHAP nvarchar(MAX) = null ,
	@PASSWORDMD5 nvarchar(MAX) = null 

AS

INSERT [dbo].[TAIKHOAN]
(
	[TENDANGNHAP],
	[PASSWORDMD5]

)
VALUES
(
	@TENDANGNHAP,
	@PASSWORDMD5

)
	SELECT @ID=SCOPE_IDENTITY();



GO
/****** Object:  StoredProcedure [dbo].[TAIKHOAN_SelectAll]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TAIKHOAN_SelectAll]
AS

	SELECT 
	*	
	FROM [dbo].[TAIKHOAN]


GO
/****** Object:  StoredProcedure [dbo].[TAIKHOAN_SelectByField]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TAIKHOAN_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT * FROM [dbo].[TAIKHOAN] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)


GO
/****** Object:  StoredProcedure [dbo].[TAIKHOAN_SelectByPrimaryKey]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TAIKHOAN_SelectByPrimaryKey]
	@ID int
AS

	SELECT 
	*	
	FROM [dbo].[TAIKHOAN]
	WHERE 
			[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[TAIKHOAN_Update]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TAIKHOAN_Update]
	@ID int,
	@TENDANGNHAP nvarchar(MAX) = null,
	@PASSWORDMD5 nvarchar(MAX) = null

AS

UPDATE [dbo].[TAIKHOAN]
SET
	[TENDANGNHAP] = @TENDANGNHAP,
	[PASSWORDMD5] = @PASSWORDMD5
 WHERE 
	[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[THUOC_DeleteByField]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[THUOC_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[THUOC] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)


GO
/****** Object:  StoredProcedure [dbo].[THUOC_DeleteByPrimaryKey]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[THUOC_DeleteByPrimaryKey]
	@ID int
AS

DELETE FROM [dbo].[THUOC]
 WHERE 
	[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[THUOC_Insert]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[THUOC_Insert]
	@ID int output,
	@TEN nvarchar(MAX) = null ,
	@HAMLUONG nvarchar(MAX) = null ,
	@CACHSUDUNG nvarchar(MAX) = null ,
	@SOLUONG int = null ,
	@HANSUDUNG int = null ,
	@GHICHU nvarchar(MAX) = null 

AS

INSERT [dbo].[THUOC]
(
	[TEN],
	[HAMLUONG],
	[CACHSUDUNG],
	[SOLUONG],
	[HANSUDUNG],
	[GHICHU]

)
VALUES
(
	@TEN,
	@HAMLUONG,
	@CACHSUDUNG,
	@SOLUONG,
	@HANSUDUNG,
	@GHICHU

)
	SELECT @ID=SCOPE_IDENTITY();



GO
/****** Object:  StoredProcedure [dbo].[THUOC_SelectAll]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[THUOC_SelectAll]
AS

	SELECT 
	*	
	FROM [dbo].[THUOC]


GO
/****** Object:  StoredProcedure [dbo].[THUOC_SelectByField]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[THUOC_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT * FROM [dbo].[THUOC] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)


GO
/****** Object:  StoredProcedure [dbo].[THUOC_SelectByPrimaryKey]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[THUOC_SelectByPrimaryKey]
	@ID int
AS

	SELECT 
	*	
	FROM [dbo].[THUOC]
	WHERE 
			[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[THUOC_Update]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[THUOC_Update]
	@ID int,
	@TEN nvarchar(MAX) = null,
	@HAMLUONG nvarchar(MAX) = null,
	@CACHSUDUNG nvarchar(MAX) = null,
	@SOLUONG int = null,
	@HANSUDUNG int = null,
	@GHICHU nvarchar(MAX) = null

AS

UPDATE [dbo].[THUOC]
SET
	[TEN] = @TEN,
	[HAMLUONG] = @HAMLUONG,
	[CACHSUDUNG] = @CACHSUDUNG,
	[SOLUONG] = @SOLUONG,
	[HANSUDUNG] = @HANSUDUNG,
	[GHICHU] = @GHICHU
 WHERE 
	[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[VATTU_DeleteByField]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VATTU_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[VATTU] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)


GO
/****** Object:  StoredProcedure [dbo].[VATTU_DeleteByPrimaryKey]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VATTU_DeleteByPrimaryKey]
	@ID int
AS

DELETE FROM [dbo].[VATTU]
 WHERE 
	[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[VATTU_Insert]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VATTU_Insert]
	@ID int output,
	@TEN nvarchar(MAX) = null ,
	@SOLUONG int = null ,
	@KYHIEU nvarchar(MAX) = null ,
	@GHICHU nvarchar(MAX) = null 

AS

INSERT [dbo].[VATTU]
(
	[TEN],
	[SOLUONG],
	[KYHIEU],
	[GHICHU]

)
VALUES
(
	@TEN,
	@SOLUONG,
	@KYHIEU,
	@GHICHU

)
	SELECT @ID=SCOPE_IDENTITY();



GO
/****** Object:  StoredProcedure [dbo].[VATTU_SelectAll]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VATTU_SelectAll]
AS

	SELECT 
	*	
	FROM [dbo].[VATTU]


GO
/****** Object:  StoredProcedure [dbo].[VATTU_SelectByField]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VATTU_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT * FROM [dbo].[VATTU] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)


GO
/****** Object:  StoredProcedure [dbo].[VATTU_SelectByPrimaryKey]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VATTU_SelectByPrimaryKey]
	@ID int
AS

	SELECT 
	*	
	FROM [dbo].[VATTU]
	WHERE 
			[ID] = @ID


GO
/****** Object:  StoredProcedure [dbo].[VATTU_Update]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VATTU_Update]
	@ID int,
	@TEN nvarchar(MAX) = null,
	@SOLUONG int = null,
	@KYHIEU nvarchar(MAX) = null,
	@GHICHU nvarchar(MAX) = null

AS

UPDATE [dbo].[VATTU]
SET
	[TEN] = @TEN,
	[SOLUONG] = @SOLUONG,
	[KYHIEU] = @KYHIEU,
	[GHICHU] = @GHICHU
 WHERE 
	[ID] = @ID


GO
/****** Object:  Table [dbo].[BACSI]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BACSI](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[HOTEN] [nvarchar](max) NULL,
	[GIOITINH] [int] NULL,
	[SDT] [nvarchar](max) NULL,
	[QUEQUAN] [nvarchar](max) NULL,
	[QUYEN] [int] NULL,
	[NGAYSINH] [datetime] NULL,
	[CAPBACID] [int] NULL,
	[CHUCVUID] [int] NULL,
	[DONVI] [nvarchar](max) NULL,
	[DANTOC] [nvarchar](max) NULL,
	[TRINHDOVANHOA] [nvarchar](max) NULL,
	[DOITUONGID] [int] NULL,
	[DONVIID] [int] NULL,
	[TAIKHOANID] [int] NULL,
	[GHICHU] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BENH]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BENH](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TEN] [nvarchar](max) NULL,
	[MOTA] [nvarchar](max) NULL,
	[LOAIBENHID] [int] NULL,
	[GHICHU] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BENHNHAN]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BENHNHAN](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[HOTEN] [nvarchar](max) NULL,
	[GIOITINH] [int] NULL,
	[SDT] [nvarchar](max) NULL,
	[QUEQUAN] [nvarchar](max) NULL,
	[NGAYSINH] [datetime] NULL,
	[MATHEBHYT] [nvarchar](max) NULL,
	[NAMNHAPNGU] [int] NULL,
	[TRINHDOVANHOA] [nvarchar](max) NULL,
	[CAPBACID] [int] NULL,
	[CHUCVUID] [int] NULL,
	[NGHENGHIEPTRUOCNN] [nvarchar](max) NULL,
	[NGHENGHIEPSAUNN] [nvarchar](max) NULL,
	[DOITUONGID] [int] NULL,
	[DONVIID] [int] NULL,
	[TIENSUBANTHAN] [nvarchar](max) NULL,
	[TIENSUGIADINH] [nvarchar](max) NULL,
	[DANTOC] [nvarchar](max) NULL,
	[DIACHI] [nvarchar](max) NULL,
	[TINHTRANGCONGTAC] [int] NULL,
	[NHOMMAU] [nvarchar](max) NULL,
	[DIUNG] [nvarchar](max) NULL,
	[GHICHU] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BENHVIEN]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BENHVIEN](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TEN] [nvarchar](max) NULL,
	[DIACHI] [nvarchar](max) NULL,
	[KIHIEU] [nvarchar](max) NULL,
	[GHICHU] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CAPBAC]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CAPBAC](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TEN] [nvarchar](max) NULL,
	[KIHIEU] [nvarchar](max) NULL,
	[CANBOCAPCAO] [int] NULL,
	[GHICHU] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CAPTHUOC]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CAPTHUOC](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NGAY] [datetime] NULL,
	[BACSIID] [int] NULL,
	[KHAMTHUONGXUYENID] [int] NULL,
	[GHICHU] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CHITIETCAPTHUOC]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETCAPTHUOC](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CAPTHUOCID] [int] NULL,
	[THUOCID] [int] NULL,
	[SOLUONG] [int] NULL,
	[GHICHU] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CHITIETMUONVATTU]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETMUONVATTU](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MUONVATTUID] [int] NULL,
	[VATTUID] [int] NULL,
	[SOLUONG] [int] NULL,
	[GHICHU] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CHITIETNHAP]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETNHAP](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NHAPTHUOCID] [int] NULL,
	[THUOCID] [int] NULL,
	[SOLUONG] [int] NULL,
	[DONGIA] [int] NULL,
	[THANHTIEN] [int] NULL,
	[GHICHU] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CHUCVU]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHUCVU](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TEN] [nvarchar](max) NULL,
	[KIHIEU] [nvarchar](max) NULL,
	[GHICHU] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DOITUONG]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DOITUONG](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TEN] [nvarchar](max) NULL,
	[KYHIEU] [nvarchar](max) NULL,
	[GHICHU] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DONVI]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DONVI](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TEN] [nvarchar](max) NULL,
	[KIHIEU] [nvarchar](max) NULL,
	[GHICHU] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GIAYGIOITHIEU]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GIAYGIOITHIEU](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NGAY] [datetime] NULL,
	[KHAMTHUONGXUYENID] [int] NULL,
	[YKIENDENGHI] [nvarchar](max) NULL,
	[GHICHU] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KHAMCANLAMSANG]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHAMCANLAMSANG](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[BACSIID] [int] NULL,
	[MAU] [nvarchar](max) NULL,
	[NUOCTIEU] [nvarchar](max) NULL,
	[SIEUAM] [nvarchar](max) NULL,
	[DIENTIM] [nvarchar](max) NULL,
	[XQUANG] [nvarchar](max) NULL,
	[XETNGHIEMKHAC] [nvarchar](max) NULL,
	[KETQUACANLAMSANG] [nvarchar](max) NULL,
	[GHICHU] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KHAMCHUYENKHOA]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHAMCHUYENKHOA](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[BACSIID] [int] NULL,
	[TAI] [nvarchar](max) NULL,
	[MUI] [nvarchar](max) NULL,
	[HONG] [nvarchar](max) NULL,
	[RANG] [nvarchar](max) NULL,
	[HAM] [nvarchar](max) NULL,
	[MAT] [nvarchar](max) NULL,
	[KHAC] [nvarchar](max) NULL,
	[GHICHU] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KHAMDINHKI]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHAMDINHKI](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[BENHNHANID] [int] NULL,
	[PHANLOAISUCKHOEID] [int] NULL,
	[BACSIID] [int] NULL,
	[KHAMTHELUCID] [int] NULL,
	[KHAMCANLAMSANGID] [int] NULL,
	[KHAMCHUYENKHOAID] [int] NULL,
	[KETLUAN] [nvarchar](max) NULL,
	[THOIGIANKHAM] [datetime] NULL,
	[LOAIHINHKHAM] [int] NULL,
	[BENHHIEMNGHEO] [int] NULL,
	[GHICHU] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KHAMTHELUC]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHAMTHELUC](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[BACSIID] [int] NULL,
	[CHIEUCAO] [nvarchar](max) NULL,
	[CANNANG] [int] NULL,
	[MACH] [nvarchar](max) NULL,
	[HUYETAP] [nvarchar](max) NULL,
	[VONGNGUC] [int] NULL,
	[NHIETDO] [int] NULL,
	[KETQUALAMSANG] [nvarchar](max) NULL,
	[GHICHU] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KHAMTHUONGXUYEN]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KHAMTHUONGXUYEN](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[BENHNHANID] [int] NULL,
	[BACSIID] [int] NULL,
	[THOIGIAN] [datetime] NULL,
	[BENHID] [int] NULL,
	[CHANDOANSOBO] [nvarchar](max) NULL,
	[CACHGIAIQUYET] [int] NULL,
	[THOIGIANCHUYEN] [datetime] NULL,
	[BENHVIENID] [int] NULL,
	[THOIGIANVAO] [datetime] NULL,
	[THOIGIANRA] [datetime] NULL,
	[PHUONGPHAPDIEUTRI] [nvarchar](max) NULL,
	[KETQUADIEUTRI] [varchar](max) NULL,
	[CHIPHIKHAM] [int] NULL,
	[GHICHU] [nvarchar](max) NULL,
	[TRIEUCHUNG] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LOAIBENH]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIBENH](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TEN] [nvarchar](max) NULL,
	[NHOMBENHID] [int] NULL,
	[GHICHU] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MUONVATTU]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MUONVATTU](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NGAYMUON] [datetime] NULL,
	[NGAYTRA] [datetime] NULL,
	[GHICHU] [nvarchar](max) NULL,
	[BACSIMUONID] [int] NULL,
	[BACSITRAID] [int] NULL,
	[KHAMTHUONGXUYENID] [int] NULL,
	[TRANGTHAI] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NHAPTHUOC]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHAPTHUOC](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NGAY] [datetime] NULL,
	[BACSIID] [int] NULL,
	[TONGTIEN] [int] NULL,
	[GHICHU] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NHOMBENH]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHOMBENH](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TEN] [nvarchar](max) NULL,
	[GHICHU] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHANLOAISUCKHOE]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHANLOAISUCKHOE](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TEN] [nvarchar](max) NULL,
	[KIHIEU] [nvarchar](max) NULL,
	[GHICHU] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TENDANGNHAP] [nvarchar](max) NULL,
	[PASSWORDMD5] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[THUOC]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THUOC](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TEN] [nvarchar](max) NULL,
	[HAMLUONG] [nvarchar](max) NULL,
	[CACHSUDUNG] [nvarchar](max) NULL,
	[SOLUONG] [int] NULL,
	[HANSUDUNG] [int] NULL,
	[GHICHU] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[VATTU]    Script Date: 2018-07-26 5:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VATTU](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TEN] [nvarchar](max) NULL,
	[SOLUONG] [int] NULL,
	[KYHIEU] [nvarchar](max) NULL,
	[GHICHU] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[BACSI] ON 

INSERT [dbo].[BACSI] ([ID], [HOTEN], [GIOITINH], [SDT], [QUEQUAN], [QUYEN], [NGAYSINH], [CAPBACID], [CHUCVUID], [DONVI], [DANTOC], [TRINHDOVANHOA], [DOITUONGID], [DONVIID], [TAIKHOANID], [GHICHU]) VALUES (1, N'Bùi Xuân Thủy', 1, N'0967 048 238', N'Đồng Văn - Yên Lạc - Vĩnh Phúc', 1, CAST(N'1996-07-24 14:55:07.740' AS DateTime), 3, 2, NULL, N'Kinh', N'12/12', 2, 1, 2, NULL)
INSERT [dbo].[BACSI] ([ID], [HOTEN], [GIOITINH], [SDT], [QUEQUAN], [QUYEN], [NGAYSINH], [CAPBACID], [CHUCVUID], [DONVI], [DANTOC], [TRINHDOVANHOA], [DOITUONGID], [DONVIID], [TAIKHOANID], [GHICHU]) VALUES (2, N'Nguyễn Nam Anh', 1, N'09123456789', N'Hà Tĩnh', 0, CAST(N'1998-07-24 14:56:03.323' AS DateTime), 1, 1, NULL, N'Kinh', N'12/12', 1, 4, 8, NULL)
SET IDENTITY_INSERT [dbo].[BACSI] OFF
SET IDENTITY_INSERT [dbo].[BENH] ON 

INSERT [dbo].[BENH] ([ID], [TEN], [MOTA], [LOAIBENHID], [GHICHU]) VALUES (1, N'Bệnh 1.1.1', N' ', 1, NULL)
INSERT [dbo].[BENH] ([ID], [TEN], [MOTA], [LOAIBENHID], [GHICHU]) VALUES (2, N'Bệnh 1.1.2', N' ', 1, NULL)
SET IDENTITY_INSERT [dbo].[BENH] OFF
SET IDENTITY_INSERT [dbo].[BENHNHAN] ON 

INSERT [dbo].[BENHNHAN] ([ID], [HOTEN], [GIOITINH], [SDT], [QUEQUAN], [NGAYSINH], [MATHEBHYT], [NAMNHAPNGU], [TRINHDOVANHOA], [CAPBACID], [CHUCVUID], [NGHENGHIEPTRUOCNN], [NGHENGHIEPSAUNN], [DOITUONGID], [DONVIID], [TIENSUBANTHAN], [TIENSUGIADINH], [DANTOC], [DIACHI], [TINHTRANGCONGTAC], [NHOMMAU], [DIUNG], [GHICHU]) VALUES (1, N'Trần Tuấn Phong', 0, N'094541785', N'Hạ Long - Nam Định', CAST(N'1996-07-24 14:58:30.157' AS DateTime), N'458962145', 2014, N'Đại học', 1, 2, N'Học sinh', N'Bộ đội', 1, 1, N'Không', N'Không', NULL, NULL, NULL, N'O', NULL, NULL)
SET IDENTITY_INSERT [dbo].[BENHNHAN] OFF
SET IDENTITY_INSERT [dbo].[BENHVIEN] ON 

INSERT [dbo].[BENHVIEN] ([ID], [TEN], [DIACHI], [KIHIEU], [GHICHU]) VALUES (1, N'Bệnh viện Bạch Mai', N'Hai Bà Trưng - Hà Nội', N'bv BM', NULL)
INSERT [dbo].[BENHVIEN] ([ID], [TEN], [DIACHI], [KIHIEU], [GHICHU]) VALUES (2, N'Bệnh viện K', N'Kim Mã - Hà Nội', N'bvK', NULL)
SET IDENTITY_INSERT [dbo].[BENHVIEN] OFF
SET IDENTITY_INSERT [dbo].[CAPBAC] ON 

INSERT [dbo].[CAPBAC] ([ID], [TEN], [KIHIEU], [CANBOCAPCAO], [GHICHU]) VALUES (1, N'Hạ sĩ', N'h1', 0, NULL)
INSERT [dbo].[CAPBAC] ([ID], [TEN], [KIHIEU], [CANBOCAPCAO], [GHICHU]) VALUES (2, N'Trung sĩ', N'h2', 0, NULL)
INSERT [dbo].[CAPBAC] ([ID], [TEN], [KIHIEU], [CANBOCAPCAO], [GHICHU]) VALUES (3, N'Thượng sĩ', N'h3', 0, NULL)
INSERT [dbo].[CAPBAC] ([ID], [TEN], [KIHIEU], [CANBOCAPCAO], [GHICHU]) VALUES (4, N'Thượng úy', N'3/', 0, NULL)
INSERT [dbo].[CAPBAC] ([ID], [TEN], [KIHIEU], [CANBOCAPCAO], [GHICHU]) VALUES (5, N'Thượng tá', N'3//', 1, NULL)
SET IDENTITY_INSERT [dbo].[CAPBAC] OFF
SET IDENTITY_INSERT [dbo].[CHITIETNHAP] ON 

INSERT [dbo].[CHITIETNHAP] ([ID], [NHAPTHUOCID], [THUOCID], [SOLUONG], [DONGIA], [THANHTIEN], [GHICHU]) VALUES (2, 2, 2, 10, 280000, 2800000, N'')
INSERT [dbo].[CHITIETNHAP] ([ID], [NHAPTHUOCID], [THUOCID], [SOLUONG], [DONGIA], [THANHTIEN], [GHICHU]) VALUES (3, 2, 1, 8, 40000, 320000, N'')
INSERT [dbo].[CHITIETNHAP] ([ID], [NHAPTHUOCID], [THUOCID], [SOLUONG], [DONGIA], [THANHTIEN], [GHICHU]) VALUES (4, 3, 3, 8, 50000, 400000, N'')
INSERT [dbo].[CHITIETNHAP] ([ID], [NHAPTHUOCID], [THUOCID], [SOLUONG], [DONGIA], [THANHTIEN], [GHICHU]) VALUES (5, 4, 3, 8, 35000, 280000, N'')
INSERT [dbo].[CHITIETNHAP] ([ID], [NHAPTHUOCID], [THUOCID], [SOLUONG], [DONGIA], [THANHTIEN], [GHICHU]) VALUES (6, 4, 1, 3, 50000, 150000, N'')
INSERT [dbo].[CHITIETNHAP] ([ID], [NHAPTHUOCID], [THUOCID], [SOLUONG], [DONGIA], [THANHTIEN], [GHICHU]) VALUES (7, 6, 1, 8, 50000, 400000, N'')
INSERT [dbo].[CHITIETNHAP] ([ID], [NHAPTHUOCID], [THUOCID], [SOLUONG], [DONGIA], [THANHTIEN], [GHICHU]) VALUES (8, 7, 1, 8, 45000, 360000, N'')
INSERT [dbo].[CHITIETNHAP] ([ID], [NHAPTHUOCID], [THUOCID], [SOLUONG], [DONGIA], [THANHTIEN], [GHICHU]) VALUES (9, 8, 1, 10, 50000, 500000, N'')
INSERT [dbo].[CHITIETNHAP] ([ID], [NHAPTHUOCID], [THUOCID], [SOLUONG], [DONGIA], [THANHTIEN], [GHICHU]) VALUES (10, 9, 1, 50000, 10, 500000, N'')
INSERT [dbo].[CHITIETNHAP] ([ID], [NHAPTHUOCID], [THUOCID], [SOLUONG], [DONGIA], [THANHTIEN], [GHICHU]) VALUES (11, 10, 1, 8, 45000, 360000, N'')
INSERT [dbo].[CHITIETNHAP] ([ID], [NHAPTHUOCID], [THUOCID], [SOLUONG], [DONGIA], [THANHTIEN], [GHICHU]) VALUES (13, 11, 1, 8, 38000, 304000, N'')
INSERT [dbo].[CHITIETNHAP] ([ID], [NHAPTHUOCID], [THUOCID], [SOLUONG], [DONGIA], [THANHTIEN], [GHICHU]) VALUES (14, 12, 1, 20, 15000, 300000, N'')
INSERT [dbo].[CHITIETNHAP] ([ID], [NHAPTHUOCID], [THUOCID], [SOLUONG], [DONGIA], [THANHTIEN], [GHICHU]) VALUES (16, 13, 1, 10, 500000, 5000000, N'')
INSERT [dbo].[CHITIETNHAP] ([ID], [NHAPTHUOCID], [THUOCID], [SOLUONG], [DONGIA], [THANHTIEN], [GHICHU]) VALUES (17, 14, 2, 8, 15000, 120000, N'')
INSERT [dbo].[CHITIETNHAP] ([ID], [NHAPTHUOCID], [THUOCID], [SOLUONG], [DONGIA], [THANHTIEN], [GHICHU]) VALUES (18, 14, 3, 15, 36000, 540000, N'')
SET IDENTITY_INSERT [dbo].[CHITIETNHAP] OFF
SET IDENTITY_INSERT [dbo].[CHUCVU] ON 

INSERT [dbo].[CHUCVU] ([ID], [TEN], [KIHIEU], [GHICHU]) VALUES (1, N'Đại đội trưởng', N'ct', NULL)
INSERT [dbo].[CHUCVU] ([ID], [TEN], [KIHIEU], [GHICHU]) VALUES (2, N'Học viên', N'HV', NULL)
SET IDENTITY_INSERT [dbo].[CHUCVU] OFF
SET IDENTITY_INSERT [dbo].[DOITUONG] ON 

INSERT [dbo].[DOITUONG] ([ID], [TEN], [KYHIEU], [GHICHU]) VALUES (1, N'Con cán bộ ', N'ccb', NULL)
INSERT [dbo].[DOITUONG] ([ID], [TEN], [KYHIEU], [GHICHU]) VALUES (2, N'Học sinh thpt', N'hsthpt', NULL)
SET IDENTITY_INSERT [dbo].[DOITUONG] OFF
SET IDENTITY_INSERT [dbo].[DONVI] ON 

INSERT [dbo].[DONVI] ([ID], [TEN], [KIHIEU], [GHICHU]) VALUES (1, N'Đại đội 350', N'c350', NULL)
INSERT [dbo].[DONVI] ([ID], [TEN], [KIHIEU], [GHICHU]) VALUES (2, N'Đại đội 351', N'c351', NULL)
INSERT [dbo].[DONVI] ([ID], [TEN], [KIHIEU], [GHICHU]) VALUES (3, N'Đại đội 250', N'c250', NULL)
INSERT [dbo].[DONVI] ([ID], [TEN], [KIHIEU], [GHICHU]) VALUES (4, N'Tiểu đoàn 3', N'd3', NULL)
SET IDENTITY_INSERT [dbo].[DONVI] OFF
SET IDENTITY_INSERT [dbo].[LOAIBENH] ON 

INSERT [dbo].[LOAIBENH] ([ID], [TEN], [NHOMBENHID], [GHICHU]) VALUES (1, N'Loại 1.1', 1, NULL)
INSERT [dbo].[LOAIBENH] ([ID], [TEN], [NHOMBENHID], [GHICHU]) VALUES (2, N'Loại 1.2', 1, NULL)
SET IDENTITY_INSERT [dbo].[LOAIBENH] OFF
SET IDENTITY_INSERT [dbo].[NHAPTHUOC] ON 

INSERT [dbo].[NHAPTHUOC] ([ID], [NGAY], [BACSIID], [TONGTIEN], [GHICHU]) VALUES (1, CAST(N'2018-07-26 00:48:12.010' AS DateTime), 1, 0, N'')
INSERT [dbo].[NHAPTHUOC] ([ID], [NGAY], [BACSIID], [TONGTIEN], [GHICHU]) VALUES (2, CAST(N'2018-07-26 00:54:59.207' AS DateTime), 2, 3120000, N'')
INSERT [dbo].[NHAPTHUOC] ([ID], [NGAY], [BACSIID], [TONGTIEN], [GHICHU]) VALUES (3, CAST(N'2018-07-26 01:00:15.130' AS DateTime), 1, 0, N'')
INSERT [dbo].[NHAPTHUOC] ([ID], [NGAY], [BACSIID], [TONGTIEN], [GHICHU]) VALUES (4, CAST(N'2018-07-26 01:01:38.523' AS DateTime), 1, 430000, N'2')
INSERT [dbo].[NHAPTHUOC] ([ID], [NGAY], [BACSIID], [TONGTIEN], [GHICHU]) VALUES (5, CAST(N'2018-07-26 01:02:46.537' AS DateTime), 2, 0, N'2')
INSERT [dbo].[NHAPTHUOC] ([ID], [NGAY], [BACSIID], [TONGTIEN], [GHICHU]) VALUES (6, CAST(N'2018-07-26 01:03:45.683' AS DateTime), 1, 0, N'3')
INSERT [dbo].[NHAPTHUOC] ([ID], [NGAY], [BACSIID], [TONGTIEN], [GHICHU]) VALUES (7, CAST(N'2018-07-26 01:06:37.213' AS DateTime), 1, 0, N'4')
INSERT [dbo].[NHAPTHUOC] ([ID], [NGAY], [BACSIID], [TONGTIEN], [GHICHU]) VALUES (8, CAST(N'2018-07-26 01:07:27.950' AS DateTime), 1, 0, N'4')
INSERT [dbo].[NHAPTHUOC] ([ID], [NGAY], [BACSIID], [TONGTIEN], [GHICHU]) VALUES (9, CAST(N'2018-07-26 01:08:53.997' AS DateTime), 1, 500000, N'6')
INSERT [dbo].[NHAPTHUOC] ([ID], [NGAY], [BACSIID], [TONGTIEN], [GHICHU]) VALUES (10, CAST(N'2018-07-26 01:12:36.667' AS DateTime), 1, 360000, N'123')
INSERT [dbo].[NHAPTHUOC] ([ID], [NGAY], [BACSIID], [TONGTIEN], [GHICHU]) VALUES (11, CAST(N'2018-07-26 01:13:02.070' AS DateTime), 1, 304000, N'456')
INSERT [dbo].[NHAPTHUOC] ([ID], [NGAY], [BACSIID], [TONGTIEN], [GHICHU]) VALUES (12, CAST(N'2018-07-26 01:16:33.203' AS DateTime), 1, 300000, N'999')
INSERT [dbo].[NHAPTHUOC] ([ID], [NGAY], [BACSIID], [TONGTIEN], [GHICHU]) VALUES (13, CAST(N'2018-07-26 06:45:19.747' AS DateTime), 1, 5000000, N'785')
INSERT [dbo].[NHAPTHUOC] ([ID], [NGAY], [BACSIID], [TONGTIEN], [GHICHU]) VALUES (14, CAST(N'2018-07-26 06:45:48.653' AS DateTime), 1, 660000, N'231')
SET IDENTITY_INSERT [dbo].[NHAPTHUOC] OFF
SET IDENTITY_INSERT [dbo].[NHOMBENH] ON 

INSERT [dbo].[NHOMBENH] ([ID], [TEN], [GHICHU]) VALUES (1, N'Nhóm 1', NULL)
INSERT [dbo].[NHOMBENH] ([ID], [TEN], [GHICHU]) VALUES (2, N'Nhóm 3', NULL)
SET IDENTITY_INSERT [dbo].[NHOMBENH] OFF
SET IDENTITY_INSERT [dbo].[PHANLOAISUCKHOE] ON 

INSERT [dbo].[PHANLOAISUCKHOE] ([ID], [TEN], [KIHIEU], [GHICHU]) VALUES (1, N'Loại 1', N'L1', NULL)
INSERT [dbo].[PHANLOAISUCKHOE] ([ID], [TEN], [KIHIEU], [GHICHU]) VALUES (2, N'Loại 2', N'L2', NULL)
SET IDENTITY_INSERT [dbo].[PHANLOAISUCKHOE] OFF
SET IDENTITY_INSERT [dbo].[TAIKHOAN] ON 

INSERT [dbo].[TAIKHOAN] ([ID], [TENDANGNHAP], [PASSWORDMD5]) VALUES (1, N'public', N'E10ADC3949BA59ABBE56E057F20F883E')
INSERT [dbo].[TAIKHOAN] ([ID], [TENDANGNHAP], [PASSWORDMD5]) VALUES (2, N'mtazero', N'E10ADC3949BA59ABBE56E057F20F883E')
INSERT [dbo].[TAIKHOAN] ([ID], [TENDANGNHAP], [PASSWORDMD5]) VALUES (7, N'public2', N'E10ADC3949BA59ABBE56E057F20F883E')
INSERT [dbo].[TAIKHOAN] ([ID], [TENDANGNHAP], [PASSWORDMD5]) VALUES (8, N'namanh', N'E10ADC3949BA59ABBE56E057F20F883E')
SET IDENTITY_INSERT [dbo].[TAIKHOAN] OFF
SET IDENTITY_INSERT [dbo].[THUOC] ON 

INSERT [dbo].[THUOC] ([ID], [TEN], [HAMLUONG], [CACHSUDUNG], [SOLUONG], [HANSUDUNG], [GHICHU]) VALUES (1, N'Panadon', N'Cafein', N'Uống với nước', 18, 5, NULL)
INSERT [dbo].[THUOC] ([ID], [TEN], [HAMLUONG], [CACHSUDUNG], [SOLUONG], [HANSUDUNG], [GHICHU]) VALUES (2, N'Thuốc sổ', N' ', N'Uống với nước', 13, 6, NULL)
INSERT [dbo].[THUOC] ([ID], [TEN], [HAMLUONG], [CACHSUDUNG], [SOLUONG], [HANSUDUNG], [GHICHU]) VALUES (3, N'Hoa vàng', N'Gồm các thảo dược từ thiên nhiên', N'Pha cùng nước và uống sau khi ăn 30 đến 45 phút', 15, 3, NULL)
SET IDENTITY_INSERT [dbo].[THUOC] OFF
SET IDENTITY_INSERT [dbo].[VATTU] ON 

INSERT [dbo].[VATTU] ([ID], [TEN], [SOLUONG], [KYHIEU], [GHICHU]) VALUES (1, N'Găng tay y tế', 10, N'gtyt', NULL)
INSERT [dbo].[VATTU] ([ID], [TEN], [SOLUONG], [KYHIEU], [GHICHU]) VALUES (2, N'Băng cuốn ', 8, N'bc', NULL)
SET IDENTITY_INSERT [dbo].[VATTU] OFF
ALTER TABLE [dbo].[BACSI]  WITH CHECK ADD FOREIGN KEY([CAPBACID])
REFERENCES [dbo].[CAPBAC] ([ID])
GO
ALTER TABLE [dbo].[BACSI]  WITH CHECK ADD FOREIGN KEY([CHUCVUID])
REFERENCES [dbo].[CHUCVU] ([ID])
GO
ALTER TABLE [dbo].[BACSI]  WITH CHECK ADD FOREIGN KEY([DOITUONGID])
REFERENCES [dbo].[DOITUONG] ([ID])
GO
ALTER TABLE [dbo].[BACSI]  WITH CHECK ADD FOREIGN KEY([DONVIID])
REFERENCES [dbo].[DONVI] ([ID])
GO
ALTER TABLE [dbo].[BACSI]  WITH CHECK ADD FOREIGN KEY([TAIKHOANID])
REFERENCES [dbo].[TAIKHOAN] ([ID])
GO
ALTER TABLE [dbo].[BENH]  WITH CHECK ADD FOREIGN KEY([LOAIBENHID])
REFERENCES [dbo].[LOAIBENH] ([ID])
GO
ALTER TABLE [dbo].[BENHNHAN]  WITH CHECK ADD FOREIGN KEY([CAPBACID])
REFERENCES [dbo].[CAPBAC] ([ID])
GO
ALTER TABLE [dbo].[BENHNHAN]  WITH CHECK ADD FOREIGN KEY([CHUCVUID])
REFERENCES [dbo].[CHUCVU] ([ID])
GO
ALTER TABLE [dbo].[BENHNHAN]  WITH CHECK ADD FOREIGN KEY([DOITUONGID])
REFERENCES [dbo].[DOITUONG] ([ID])
GO
ALTER TABLE [dbo].[BENHNHAN]  WITH CHECK ADD FOREIGN KEY([DONVIID])
REFERENCES [dbo].[DONVI] ([ID])
GO
ALTER TABLE [dbo].[CAPTHUOC]  WITH CHECK ADD FOREIGN KEY([BACSIID])
REFERENCES [dbo].[BACSI] ([ID])
GO
ALTER TABLE [dbo].[CAPTHUOC]  WITH CHECK ADD FOREIGN KEY([KHAMTHUONGXUYENID])
REFERENCES [dbo].[KHAMTHUONGXUYEN] ([ID])
GO
ALTER TABLE [dbo].[CHITIETCAPTHUOC]  WITH CHECK ADD FOREIGN KEY([CAPTHUOCID])
REFERENCES [dbo].[CAPTHUOC] ([ID])
GO
ALTER TABLE [dbo].[CHITIETCAPTHUOC]  WITH CHECK ADD FOREIGN KEY([THUOCID])
REFERENCES [dbo].[THUOC] ([ID])
GO
ALTER TABLE [dbo].[CHITIETMUONVATTU]  WITH CHECK ADD FOREIGN KEY([MUONVATTUID])
REFERENCES [dbo].[MUONVATTU] ([ID])
GO
ALTER TABLE [dbo].[CHITIETMUONVATTU]  WITH CHECK ADD FOREIGN KEY([VATTUID])
REFERENCES [dbo].[VATTU] ([ID])
GO
ALTER TABLE [dbo].[CHITIETNHAP]  WITH CHECK ADD FOREIGN KEY([NHAPTHUOCID])
REFERENCES [dbo].[NHAPTHUOC] ([ID])
GO
ALTER TABLE [dbo].[CHITIETNHAP]  WITH CHECK ADD FOREIGN KEY([THUOCID])
REFERENCES [dbo].[THUOC] ([ID])
GO
ALTER TABLE [dbo].[GIAYGIOITHIEU]  WITH CHECK ADD FOREIGN KEY([KHAMTHUONGXUYENID])
REFERENCES [dbo].[KHAMTHUONGXUYEN] ([ID])
GO
ALTER TABLE [dbo].[KHAMCANLAMSANG]  WITH CHECK ADD FOREIGN KEY([BACSIID])
REFERENCES [dbo].[BACSI] ([ID])
GO
ALTER TABLE [dbo].[KHAMCHUYENKHOA]  WITH CHECK ADD FOREIGN KEY([BACSIID])
REFERENCES [dbo].[BACSI] ([ID])
GO
ALTER TABLE [dbo].[KHAMDINHKI]  WITH CHECK ADD FOREIGN KEY([BACSIID])
REFERENCES [dbo].[BACSI] ([ID])
GO
ALTER TABLE [dbo].[KHAMDINHKI]  WITH CHECK ADD FOREIGN KEY([BENHNHANID])
REFERENCES [dbo].[BENHNHAN] ([ID])
GO
ALTER TABLE [dbo].[KHAMDINHKI]  WITH CHECK ADD FOREIGN KEY([KHAMCANLAMSANGID])
REFERENCES [dbo].[KHAMCANLAMSANG] ([ID])
GO
ALTER TABLE [dbo].[KHAMDINHKI]  WITH CHECK ADD FOREIGN KEY([KHAMCHUYENKHOAID])
REFERENCES [dbo].[KHAMCHUYENKHOA] ([ID])
GO
ALTER TABLE [dbo].[KHAMDINHKI]  WITH CHECK ADD FOREIGN KEY([KHAMTHELUCID])
REFERENCES [dbo].[KHAMTHELUC] ([ID])
GO
ALTER TABLE [dbo].[KHAMDINHKI]  WITH CHECK ADD FOREIGN KEY([PHANLOAISUCKHOEID])
REFERENCES [dbo].[PHANLOAISUCKHOE] ([ID])
GO
ALTER TABLE [dbo].[KHAMTHELUC]  WITH CHECK ADD FOREIGN KEY([BACSIID])
REFERENCES [dbo].[BACSI] ([ID])
GO
ALTER TABLE [dbo].[KHAMTHUONGXUYEN]  WITH CHECK ADD FOREIGN KEY([BACSIID])
REFERENCES [dbo].[BACSI] ([ID])
GO
ALTER TABLE [dbo].[KHAMTHUONGXUYEN]  WITH CHECK ADD FOREIGN KEY([BENHID])
REFERENCES [dbo].[BENH] ([ID])
GO
ALTER TABLE [dbo].[KHAMTHUONGXUYEN]  WITH CHECK ADD FOREIGN KEY([BENHNHANID])
REFERENCES [dbo].[BENHNHAN] ([ID])
GO
ALTER TABLE [dbo].[KHAMTHUONGXUYEN]  WITH CHECK ADD FOREIGN KEY([BENHVIENID])
REFERENCES [dbo].[BENHVIEN] ([ID])
GO
ALTER TABLE [dbo].[LOAIBENH]  WITH CHECK ADD FOREIGN KEY([NHOMBENHID])
REFERENCES [dbo].[NHOMBENH] ([ID])
GO
ALTER TABLE [dbo].[MUONVATTU]  WITH CHECK ADD FOREIGN KEY([BACSIMUONID])
REFERENCES [dbo].[BACSI] ([ID])
GO
ALTER TABLE [dbo].[MUONVATTU]  WITH CHECK ADD FOREIGN KEY([BACSITRAID])
REFERENCES [dbo].[BACSI] ([ID])
GO
ALTER TABLE [dbo].[MUONVATTU]  WITH CHECK ADD FOREIGN KEY([KHAMTHUONGXUYENID])
REFERENCES [dbo].[KHAMTHUONGXUYEN] ([ID])
GO
ALTER TABLE [dbo].[NHAPTHUOC]  WITH CHECK ADD FOREIGN KEY([BACSIID])
REFERENCES [dbo].[BACSI] ([ID])
GO
USE [master]
GO
ALTER DATABASE [QLSUCKHOE] SET  READ_WRITE 
GO
