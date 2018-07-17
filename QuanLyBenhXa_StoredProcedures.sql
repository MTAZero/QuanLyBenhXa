SET NOCOUNT ON
GO
USE [QLSUCKHOE]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CAPBAC_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[CAPBAC_Insert]
GO
CREATE PROCEDURE [dbo].[CAPBAC_Insert]
	@ID int output,
	@TEN nvarchar(MAX) = null ,
	@KIHIEU nvarchar(MAX) = null ,
	@GHICHU nvarchar(MAX) = null 

AS

INSERT [dbo].[CAPBAC]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CAPBAC_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[CAPBAC_Update]
GO
CREATE PROCEDURE [dbo].[CAPBAC_Update]
	@ID int,
	@TEN nvarchar(MAX) = null,
	@KIHIEU nvarchar(MAX) = null,
	@GHICHU nvarchar(MAX) = null

AS

UPDATE [dbo].[CAPBAC]
SET
	[TEN] = @TEN,
	[KIHIEU] = @KIHIEU,
	[GHICHU] = @GHICHU
 WHERE 
	[ID] = @ID

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CAPBAC_SelectByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[CAPBAC_SelectByPrimaryKey]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CAPBAC_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[CAPBAC_SelectAll]
GO
CREATE PROCEDURE [dbo].[CAPBAC_SelectAll]
AS

	SELECT 
	*	
	FROM [dbo].[CAPBAC]

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CAPBAC_SelectByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[CAPBAC_SelectByField]
GO
CREATE PROCEDURE [dbo].[CAPBAC_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT * FROM [dbo].[CAPBAC] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CAPBAC_DeleteByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[CAPBAC_DeleteByPrimaryKey]
GO
CREATE PROCEDURE [dbo].[CAPBAC_DeleteByPrimaryKey]
	@ID int
AS

DELETE FROM [dbo].[CAPBAC]
 WHERE 
	[ID] = @ID

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CAPBAC_DeleteByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[CAPBAC_DeleteByField]
GO
CREATE PROCEDURE [dbo].[CAPBAC_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[CAPBAC] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CHUCVU_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[CHUCVU_Insert]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CHUCVU_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[CHUCVU_Update]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CHUCVU_SelectByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[CHUCVU_SelectByPrimaryKey]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CHUCVU_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[CHUCVU_SelectAll]
GO
CREATE PROCEDURE [dbo].[CHUCVU_SelectAll]
AS

	SELECT 
	*	
	FROM [dbo].[CHUCVU]

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CHUCVU_SelectByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[CHUCVU_SelectByField]
GO
CREATE PROCEDURE [dbo].[CHUCVU_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT * FROM [dbo].[CHUCVU] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CHUCVU_DeleteByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[CHUCVU_DeleteByPrimaryKey]
GO
CREATE PROCEDURE [dbo].[CHUCVU_DeleteByPrimaryKey]
	@ID int
AS

DELETE FROM [dbo].[CHUCVU]
 WHERE 
	[ID] = @ID

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CHUCVU_DeleteByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[CHUCVU_DeleteByField]
GO
CREATE PROCEDURE [dbo].[CHUCVU_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[CHUCVU] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[DONVI_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[DONVI_Insert]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[DONVI_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[DONVI_Update]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[DONVI_SelectByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[DONVI_SelectByPrimaryKey]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[DONVI_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[DONVI_SelectAll]
GO
CREATE PROCEDURE [dbo].[DONVI_SelectAll]
AS

	SELECT 
	*	
	FROM [dbo].[DONVI]

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[DONVI_SelectByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[DONVI_SelectByField]
GO
CREATE PROCEDURE [dbo].[DONVI_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT * FROM [dbo].[DONVI] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[DONVI_DeleteByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[DONVI_DeleteByPrimaryKey]
GO
CREATE PROCEDURE [dbo].[DONVI_DeleteByPrimaryKey]
	@ID int
AS

DELETE FROM [dbo].[DONVI]
 WHERE 
	[ID] = @ID

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[DONVI_DeleteByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[DONVI_DeleteByField]
GO
CREATE PROCEDURE [dbo].[DONVI_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[DONVI] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[DOITUONG_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[DOITUONG_Insert]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[DOITUONG_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[DOITUONG_Update]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[DOITUONG_SelectByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[DOITUONG_SelectByPrimaryKey]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[DOITUONG_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[DOITUONG_SelectAll]
GO
CREATE PROCEDURE [dbo].[DOITUONG_SelectAll]
AS

	SELECT 
	*	
	FROM [dbo].[DOITUONG]

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[DOITUONG_SelectByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[DOITUONG_SelectByField]
GO
CREATE PROCEDURE [dbo].[DOITUONG_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT * FROM [dbo].[DOITUONG] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[DOITUONG_DeleteByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[DOITUONG_DeleteByPrimaryKey]
GO
CREATE PROCEDURE [dbo].[DOITUONG_DeleteByPrimaryKey]
	@ID int
AS

DELETE FROM [dbo].[DOITUONG]
 WHERE 
	[ID] = @ID

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[DOITUONG_DeleteByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[DOITUONG_DeleteByField]
GO
CREATE PROCEDURE [dbo].[DOITUONG_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[DOITUONG] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[VATTU_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[VATTU_Insert]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[VATTU_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[VATTU_Update]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[VATTU_SelectByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[VATTU_SelectByPrimaryKey]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[VATTU_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[VATTU_SelectAll]
GO
CREATE PROCEDURE [dbo].[VATTU_SelectAll]
AS

	SELECT 
	*	
	FROM [dbo].[VATTU]

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[VATTU_SelectByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[VATTU_SelectByField]
GO
CREATE PROCEDURE [dbo].[VATTU_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT * FROM [dbo].[VATTU] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[VATTU_DeleteByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[VATTU_DeleteByPrimaryKey]
GO
CREATE PROCEDURE [dbo].[VATTU_DeleteByPrimaryKey]
	@ID int
AS

DELETE FROM [dbo].[VATTU]
 WHERE 
	[ID] = @ID

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[VATTU_DeleteByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[VATTU_DeleteByField]
GO
CREATE PROCEDURE [dbo].[VATTU_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[VATTU] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PHANLOAISUCKHOE_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[PHANLOAISUCKHOE_Insert]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PHANLOAISUCKHOE_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[PHANLOAISUCKHOE_Update]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PHANLOAISUCKHOE_SelectByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[PHANLOAISUCKHOE_SelectByPrimaryKey]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PHANLOAISUCKHOE_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[PHANLOAISUCKHOE_SelectAll]
GO
CREATE PROCEDURE [dbo].[PHANLOAISUCKHOE_SelectAll]
AS

	SELECT 
	*	
	FROM [dbo].[PHANLOAISUCKHOE]

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PHANLOAISUCKHOE_SelectByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[PHANLOAISUCKHOE_SelectByField]
GO
CREATE PROCEDURE [dbo].[PHANLOAISUCKHOE_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT * FROM [dbo].[PHANLOAISUCKHOE] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PHANLOAISUCKHOE_DeleteByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[PHANLOAISUCKHOE_DeleteByPrimaryKey]
GO
CREATE PROCEDURE [dbo].[PHANLOAISUCKHOE_DeleteByPrimaryKey]
	@ID int
AS

DELETE FROM [dbo].[PHANLOAISUCKHOE]
 WHERE 
	[ID] = @ID

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PHANLOAISUCKHOE_DeleteByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[PHANLOAISUCKHOE_DeleteByField]
GO
CREATE PROCEDURE [dbo].[PHANLOAISUCKHOE_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[PHANLOAISUCKHOE] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TAIKHOAN_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[TAIKHOAN_Insert]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TAIKHOAN_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[TAIKHOAN_Update]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TAIKHOAN_SelectByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[TAIKHOAN_SelectByPrimaryKey]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TAIKHOAN_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[TAIKHOAN_SelectAll]
GO
CREATE PROCEDURE [dbo].[TAIKHOAN_SelectAll]
AS

	SELECT 
	*	
	FROM [dbo].[TAIKHOAN]

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TAIKHOAN_SelectByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[TAIKHOAN_SelectByField]
GO
CREATE PROCEDURE [dbo].[TAIKHOAN_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT * FROM [dbo].[TAIKHOAN] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TAIKHOAN_DeleteByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[TAIKHOAN_DeleteByPrimaryKey]
GO
CREATE PROCEDURE [dbo].[TAIKHOAN_DeleteByPrimaryKey]
	@ID int
AS

DELETE FROM [dbo].[TAIKHOAN]
 WHERE 
	[ID] = @ID

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TAIKHOAN_DeleteByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[TAIKHOAN_DeleteByField]
GO
CREATE PROCEDURE [dbo].[TAIKHOAN_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[TAIKHOAN] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[BACSI_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[BACSI_Insert]
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
	@CANBOCAPCAO int = null ,
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
	[CANBOCAPCAO],
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
	@CANBOCAPCAO,
	@TAIKHOANID,
	@GHICHU

)
	SELECT @ID=SCOPE_IDENTITY();


GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[BACSI_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[BACSI_Update]
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
	@CANBOCAPCAO int = null,
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
	[CANBOCAPCAO] = @CANBOCAPCAO,
	[TAIKHOANID] = @TAIKHOANID,
	[GHICHU] = @GHICHU
 WHERE 
	[ID] = @ID

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[BACSI_SelectByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[BACSI_SelectByPrimaryKey]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[BACSI_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[BACSI_SelectAll]
GO
CREATE PROCEDURE [dbo].[BACSI_SelectAll]
AS

	SELECT 
	*	
	FROM [dbo].[BACSI]

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[BACSI_SelectByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[BACSI_SelectByField]
GO
CREATE PROCEDURE [dbo].[BACSI_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT * FROM [dbo].[BACSI] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[BACSI_DeleteByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[BACSI_DeleteByPrimaryKey]
GO
CREATE PROCEDURE [dbo].[BACSI_DeleteByPrimaryKey]
	@ID int
AS

DELETE FROM [dbo].[BACSI]
 WHERE 
	[ID] = @ID

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[BACSI_DeleteByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[BACSI_DeleteByField]
GO
CREATE PROCEDURE [dbo].[BACSI_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[BACSI] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[BENHNHAN_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[BENHNHAN_Insert]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[BENHNHAN_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[BENHNHAN_Update]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[BENHNHAN_SelectByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[BENHNHAN_SelectByPrimaryKey]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[BENHNHAN_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[BENHNHAN_SelectAll]
GO
CREATE PROCEDURE [dbo].[BENHNHAN_SelectAll]
AS

	SELECT 
	*	
	FROM [dbo].[BENHNHAN]

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[BENHNHAN_SelectByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[BENHNHAN_SelectByField]
GO
CREATE PROCEDURE [dbo].[BENHNHAN_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT * FROM [dbo].[BENHNHAN] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[BENHNHAN_DeleteByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[BENHNHAN_DeleteByPrimaryKey]
GO
CREATE PROCEDURE [dbo].[BENHNHAN_DeleteByPrimaryKey]
	@ID int
AS

DELETE FROM [dbo].[BENHNHAN]
 WHERE 
	[ID] = @ID

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[BENHNHAN_DeleteByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[BENHNHAN_DeleteByField]
GO
CREATE PROCEDURE [dbo].[BENHNHAN_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[BENHNHAN] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[NHOMBENH_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[NHOMBENH_Insert]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[NHOMBENH_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[NHOMBENH_Update]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[NHOMBENH_SelectByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[NHOMBENH_SelectByPrimaryKey]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[NHOMBENH_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[NHOMBENH_SelectAll]
GO
CREATE PROCEDURE [dbo].[NHOMBENH_SelectAll]
AS

	SELECT 
	*	
	FROM [dbo].[NHOMBENH]

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[NHOMBENH_SelectByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[NHOMBENH_SelectByField]
GO
CREATE PROCEDURE [dbo].[NHOMBENH_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT * FROM [dbo].[NHOMBENH] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[NHOMBENH_DeleteByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[NHOMBENH_DeleteByPrimaryKey]
GO
CREATE PROCEDURE [dbo].[NHOMBENH_DeleteByPrimaryKey]
	@ID int
AS

DELETE FROM [dbo].[NHOMBENH]
 WHERE 
	[ID] = @ID

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[NHOMBENH_DeleteByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[NHOMBENH_DeleteByField]
GO
CREATE PROCEDURE [dbo].[NHOMBENH_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[NHOMBENH] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[LOAIBENH_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[LOAIBENH_Insert]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[LOAIBENH_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[LOAIBENH_Update]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[LOAIBENH_SelectByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[LOAIBENH_SelectByPrimaryKey]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[LOAIBENH_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[LOAIBENH_SelectAll]
GO
CREATE PROCEDURE [dbo].[LOAIBENH_SelectAll]
AS

	SELECT 
	*	
	FROM [dbo].[LOAIBENH]

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[LOAIBENH_SelectByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[LOAIBENH_SelectByField]
GO
CREATE PROCEDURE [dbo].[LOAIBENH_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT * FROM [dbo].[LOAIBENH] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[LOAIBENH_DeleteByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[LOAIBENH_DeleteByPrimaryKey]
GO
CREATE PROCEDURE [dbo].[LOAIBENH_DeleteByPrimaryKey]
	@ID int
AS

DELETE FROM [dbo].[LOAIBENH]
 WHERE 
	[ID] = @ID

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[LOAIBENH_DeleteByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[LOAIBENH_DeleteByField]
GO
CREATE PROCEDURE [dbo].[LOAIBENH_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[LOAIBENH] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[BENH_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[BENH_Insert]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[BENH_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[BENH_Update]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[BENH_SelectByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[BENH_SelectByPrimaryKey]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[BENH_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[BENH_SelectAll]
GO
CREATE PROCEDURE [dbo].[BENH_SelectAll]
AS

	SELECT 
	*	
	FROM [dbo].[BENH]

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[BENH_SelectByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[BENH_SelectByField]
GO
CREATE PROCEDURE [dbo].[BENH_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT * FROM [dbo].[BENH] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[BENH_DeleteByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[BENH_DeleteByPrimaryKey]
GO
CREATE PROCEDURE [dbo].[BENH_DeleteByPrimaryKey]
	@ID int
AS

DELETE FROM [dbo].[BENH]
 WHERE 
	[ID] = @ID

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[BENH_DeleteByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[BENH_DeleteByField]
GO
CREATE PROCEDURE [dbo].[BENH_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[BENH] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[BENHVIEN_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[BENHVIEN_Insert]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[BENHVIEN_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[BENHVIEN_Update]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[BENHVIEN_SelectByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[BENHVIEN_SelectByPrimaryKey]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[BENHVIEN_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[BENHVIEN_SelectAll]
GO
CREATE PROCEDURE [dbo].[BENHVIEN_SelectAll]
AS

	SELECT 
	*	
	FROM [dbo].[BENHVIEN]

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[BENHVIEN_SelectByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[BENHVIEN_SelectByField]
GO
CREATE PROCEDURE [dbo].[BENHVIEN_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT * FROM [dbo].[BENHVIEN] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[BENHVIEN_DeleteByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[BENHVIEN_DeleteByPrimaryKey]
GO
CREATE PROCEDURE [dbo].[BENHVIEN_DeleteByPrimaryKey]
	@ID int
AS

DELETE FROM [dbo].[BENHVIEN]
 WHERE 
	[ID] = @ID

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[BENHVIEN_DeleteByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[BENHVIEN_DeleteByField]
GO
CREATE PROCEDURE [dbo].[BENHVIEN_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[BENHVIEN] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[THUOC_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[THUOC_Insert]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[THUOC_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[THUOC_Update]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[THUOC_SelectByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[THUOC_SelectByPrimaryKey]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[THUOC_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[THUOC_SelectAll]
GO
CREATE PROCEDURE [dbo].[THUOC_SelectAll]
AS

	SELECT 
	*	
	FROM [dbo].[THUOC]

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[THUOC_SelectByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[THUOC_SelectByField]
GO
CREATE PROCEDURE [dbo].[THUOC_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT * FROM [dbo].[THUOC] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[THUOC_DeleteByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[THUOC_DeleteByPrimaryKey]
GO
CREATE PROCEDURE [dbo].[THUOC_DeleteByPrimaryKey]
	@ID int
AS

DELETE FROM [dbo].[THUOC]
 WHERE 
	[ID] = @ID

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[THUOC_DeleteByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[THUOC_DeleteByField]
GO
CREATE PROCEDURE [dbo].[THUOC_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[THUOC] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[NHAPTHUOC_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[NHAPTHUOC_Insert]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[NHAPTHUOC_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[NHAPTHUOC_Update]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[NHAPTHUOC_SelectByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[NHAPTHUOC_SelectByPrimaryKey]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[NHAPTHUOC_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[NHAPTHUOC_SelectAll]
GO
CREATE PROCEDURE [dbo].[NHAPTHUOC_SelectAll]
AS

	SELECT 
	*	
	FROM [dbo].[NHAPTHUOC]

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[NHAPTHUOC_SelectByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[NHAPTHUOC_SelectByField]
GO
CREATE PROCEDURE [dbo].[NHAPTHUOC_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT * FROM [dbo].[NHAPTHUOC] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[NHAPTHUOC_DeleteByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[NHAPTHUOC_DeleteByPrimaryKey]
GO
CREATE PROCEDURE [dbo].[NHAPTHUOC_DeleteByPrimaryKey]
	@ID int
AS

DELETE FROM [dbo].[NHAPTHUOC]
 WHERE 
	[ID] = @ID

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[NHAPTHUOC_DeleteByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[NHAPTHUOC_DeleteByField]
GO
CREATE PROCEDURE [dbo].[NHAPTHUOC_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[NHAPTHUOC] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CHITIETNHAP_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[CHITIETNHAP_Insert]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CHITIETNHAP_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[CHITIETNHAP_Update]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CHITIETNHAP_SelectByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[CHITIETNHAP_SelectByPrimaryKey]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CHITIETNHAP_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[CHITIETNHAP_SelectAll]
GO
CREATE PROCEDURE [dbo].[CHITIETNHAP_SelectAll]
AS

	SELECT 
	*	
	FROM [dbo].[CHITIETNHAP]

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CHITIETNHAP_SelectByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[CHITIETNHAP_SelectByField]
GO
CREATE PROCEDURE [dbo].[CHITIETNHAP_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT * FROM [dbo].[CHITIETNHAP] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CHITIETNHAP_DeleteByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[CHITIETNHAP_DeleteByPrimaryKey]
GO
CREATE PROCEDURE [dbo].[CHITIETNHAP_DeleteByPrimaryKey]
	@ID int
AS

DELETE FROM [dbo].[CHITIETNHAP]
 WHERE 
	[ID] = @ID

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CHITIETNHAP_DeleteByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[CHITIETNHAP_DeleteByField]
GO
CREATE PROCEDURE [dbo].[CHITIETNHAP_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[CHITIETNHAP] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KHAMTHUONGXUYEN_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KHAMTHUONGXUYEN_Insert]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KHAMTHUONGXUYEN_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KHAMTHUONGXUYEN_Update]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KHAMTHUONGXUYEN_SelectByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KHAMTHUONGXUYEN_SelectByPrimaryKey]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KHAMTHUONGXUYEN_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KHAMTHUONGXUYEN_SelectAll]
GO
CREATE PROCEDURE [dbo].[KHAMTHUONGXUYEN_SelectAll]
AS

	SELECT 
	*	
	FROM [dbo].[KHAMTHUONGXUYEN]

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KHAMTHUONGXUYEN_SelectByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KHAMTHUONGXUYEN_SelectByField]
GO
CREATE PROCEDURE [dbo].[KHAMTHUONGXUYEN_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT * FROM [dbo].[KHAMTHUONGXUYEN] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KHAMTHUONGXUYEN_DeleteByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KHAMTHUONGXUYEN_DeleteByPrimaryKey]
GO
CREATE PROCEDURE [dbo].[KHAMTHUONGXUYEN_DeleteByPrimaryKey]
	@ID int
AS

DELETE FROM [dbo].[KHAMTHUONGXUYEN]
 WHERE 
	[ID] = @ID

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KHAMTHUONGXUYEN_DeleteByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KHAMTHUONGXUYEN_DeleteByField]
GO
CREATE PROCEDURE [dbo].[KHAMTHUONGXUYEN_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[KHAMTHUONGXUYEN] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CAPTHUOC_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[CAPTHUOC_Insert]
GO
CREATE PROCEDURE [dbo].[CAPTHUOC_Insert]
	@ID int output,
	@NGAY datetime = null ,
	@BACSIID int = null ,
	@BENHNHANID int = null ,
	@KHAMTHUONGXUYENID int = null ,
	@GHICHU nvarchar(MAX) = null 

AS

INSERT [dbo].[CAPTHUOC]
(
	[NGAY],
	[BACSIID],
	[BENHNHANID],
	[KHAMTHUONGXUYENID],
	[GHICHU]

)
VALUES
(
	@NGAY,
	@BACSIID,
	@BENHNHANID,
	@KHAMTHUONGXUYENID,
	@GHICHU

)
	SELECT @ID=SCOPE_IDENTITY();


GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CAPTHUOC_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[CAPTHUOC_Update]
GO
CREATE PROCEDURE [dbo].[CAPTHUOC_Update]
	@ID int,
	@NGAY datetime = null,
	@BACSIID int = null,
	@BENHNHANID int = null,
	@KHAMTHUONGXUYENID int = null,
	@GHICHU nvarchar(MAX) = null

AS

UPDATE [dbo].[CAPTHUOC]
SET
	[NGAY] = @NGAY,
	[BACSIID] = @BACSIID,
	[BENHNHANID] = @BENHNHANID,
	[KHAMTHUONGXUYENID] = @KHAMTHUONGXUYENID,
	[GHICHU] = @GHICHU
 WHERE 
	[ID] = @ID

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CAPTHUOC_SelectByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[CAPTHUOC_SelectByPrimaryKey]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CAPTHUOC_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[CAPTHUOC_SelectAll]
GO
CREATE PROCEDURE [dbo].[CAPTHUOC_SelectAll]
AS

	SELECT 
	*	
	FROM [dbo].[CAPTHUOC]

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CAPTHUOC_SelectByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[CAPTHUOC_SelectByField]
GO
CREATE PROCEDURE [dbo].[CAPTHUOC_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT * FROM [dbo].[CAPTHUOC] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CAPTHUOC_DeleteByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[CAPTHUOC_DeleteByPrimaryKey]
GO
CREATE PROCEDURE [dbo].[CAPTHUOC_DeleteByPrimaryKey]
	@ID int
AS

DELETE FROM [dbo].[CAPTHUOC]
 WHERE 
	[ID] = @ID

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CAPTHUOC_DeleteByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[CAPTHUOC_DeleteByField]
GO
CREATE PROCEDURE [dbo].[CAPTHUOC_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[CAPTHUOC] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CHITIETCAPTHUOC_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[CHITIETCAPTHUOC_Insert]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CHITIETCAPTHUOC_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[CHITIETCAPTHUOC_Update]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CHITIETCAPTHUOC_SelectByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[CHITIETCAPTHUOC_SelectByPrimaryKey]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CHITIETCAPTHUOC_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[CHITIETCAPTHUOC_SelectAll]
GO
CREATE PROCEDURE [dbo].[CHITIETCAPTHUOC_SelectAll]
AS

	SELECT 
	*	
	FROM [dbo].[CHITIETCAPTHUOC]

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CHITIETCAPTHUOC_SelectByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[CHITIETCAPTHUOC_SelectByField]
GO
CREATE PROCEDURE [dbo].[CHITIETCAPTHUOC_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT * FROM [dbo].[CHITIETCAPTHUOC] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CHITIETCAPTHUOC_DeleteByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[CHITIETCAPTHUOC_DeleteByPrimaryKey]
GO
CREATE PROCEDURE [dbo].[CHITIETCAPTHUOC_DeleteByPrimaryKey]
	@ID int
AS

DELETE FROM [dbo].[CHITIETCAPTHUOC]
 WHERE 
	[ID] = @ID

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CHITIETCAPTHUOC_DeleteByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[CHITIETCAPTHUOC_DeleteByField]
GO
CREATE PROCEDURE [dbo].[CHITIETCAPTHUOC_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[CHITIETCAPTHUOC] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[MUONVATTU_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[MUONVATTU_Insert]
GO
CREATE PROCEDURE [dbo].[MUONVATTU_Insert]
	@ID int output,
	@NGAYMUON datetime = null ,
	@NGAYTRA datetime = null ,
	@GHICHU nvarchar(MAX) = null ,
	@BACSIMUONID int = null ,
	@BACSITRAID int = null ,
	@BENHNHANID int = null ,
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
	[BENHNHANID],
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
	@BENHNHANID,
	@KHAMTHUONGXUYENID,
	@TRANGTHAI

)
	SELECT @ID=SCOPE_IDENTITY();


GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[MUONVATTU_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[MUONVATTU_Update]
GO
CREATE PROCEDURE [dbo].[MUONVATTU_Update]
	@ID int,
	@NGAYMUON datetime = null,
	@NGAYTRA datetime = null,
	@GHICHU nvarchar(MAX) = null,
	@BACSIMUONID int = null,
	@BACSITRAID int = null,
	@BENHNHANID int = null,
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
	[BENHNHANID] = @BENHNHANID,
	[KHAMTHUONGXUYENID] = @KHAMTHUONGXUYENID,
	[TRANGTHAI] = @TRANGTHAI
 WHERE 
	[ID] = @ID

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[MUONVATTU_SelectByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[MUONVATTU_SelectByPrimaryKey]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[MUONVATTU_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[MUONVATTU_SelectAll]
GO
CREATE PROCEDURE [dbo].[MUONVATTU_SelectAll]
AS

	SELECT 
	*	
	FROM [dbo].[MUONVATTU]

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[MUONVATTU_SelectByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[MUONVATTU_SelectByField]
GO
CREATE PROCEDURE [dbo].[MUONVATTU_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT * FROM [dbo].[MUONVATTU] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[MUONVATTU_DeleteByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[MUONVATTU_DeleteByPrimaryKey]
GO
CREATE PROCEDURE [dbo].[MUONVATTU_DeleteByPrimaryKey]
	@ID int
AS

DELETE FROM [dbo].[MUONVATTU]
 WHERE 
	[ID] = @ID

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[MUONVATTU_DeleteByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[MUONVATTU_DeleteByField]
GO
CREATE PROCEDURE [dbo].[MUONVATTU_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[MUONVATTU] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CHITIETMUONVATTU_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[CHITIETMUONVATTU_Insert]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CHITIETMUONVATTU_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[CHITIETMUONVATTU_Update]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CHITIETMUONVATTU_SelectByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[CHITIETMUONVATTU_SelectByPrimaryKey]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CHITIETMUONVATTU_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[CHITIETMUONVATTU_SelectAll]
GO
CREATE PROCEDURE [dbo].[CHITIETMUONVATTU_SelectAll]
AS

	SELECT 
	*	
	FROM [dbo].[CHITIETMUONVATTU]

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CHITIETMUONVATTU_SelectByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[CHITIETMUONVATTU_SelectByField]
GO
CREATE PROCEDURE [dbo].[CHITIETMUONVATTU_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT * FROM [dbo].[CHITIETMUONVATTU] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CHITIETMUONVATTU_DeleteByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[CHITIETMUONVATTU_DeleteByPrimaryKey]
GO
CREATE PROCEDURE [dbo].[CHITIETMUONVATTU_DeleteByPrimaryKey]
	@ID int
AS

DELETE FROM [dbo].[CHITIETMUONVATTU]
 WHERE 
	[ID] = @ID

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CHITIETMUONVATTU_DeleteByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[CHITIETMUONVATTU_DeleteByField]
GO
CREATE PROCEDURE [dbo].[CHITIETMUONVATTU_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[CHITIETMUONVATTU] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[GIAYGIOITHIEU_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[GIAYGIOITHIEU_Insert]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[GIAYGIOITHIEU_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[GIAYGIOITHIEU_Update]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[GIAYGIOITHIEU_SelectByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[GIAYGIOITHIEU_SelectByPrimaryKey]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[GIAYGIOITHIEU_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[GIAYGIOITHIEU_SelectAll]
GO
CREATE PROCEDURE [dbo].[GIAYGIOITHIEU_SelectAll]
AS

	SELECT 
	*	
	FROM [dbo].[GIAYGIOITHIEU]

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[GIAYGIOITHIEU_SelectByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[GIAYGIOITHIEU_SelectByField]
GO
CREATE PROCEDURE [dbo].[GIAYGIOITHIEU_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT * FROM [dbo].[GIAYGIOITHIEU] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[GIAYGIOITHIEU_DeleteByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[GIAYGIOITHIEU_DeleteByPrimaryKey]
GO
CREATE PROCEDURE [dbo].[GIAYGIOITHIEU_DeleteByPrimaryKey]
	@ID int
AS

DELETE FROM [dbo].[GIAYGIOITHIEU]
 WHERE 
	[ID] = @ID

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[GIAYGIOITHIEU_DeleteByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[GIAYGIOITHIEU_DeleteByField]
GO
CREATE PROCEDURE [dbo].[GIAYGIOITHIEU_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[GIAYGIOITHIEU] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KHAMTHELUC_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KHAMTHELUC_Insert]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KHAMTHELUC_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KHAMTHELUC_Update]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KHAMTHELUC_SelectByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KHAMTHELUC_SelectByPrimaryKey]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KHAMTHELUC_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KHAMTHELUC_SelectAll]
GO
CREATE PROCEDURE [dbo].[KHAMTHELUC_SelectAll]
AS

	SELECT 
	*	
	FROM [dbo].[KHAMTHELUC]

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KHAMTHELUC_SelectByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KHAMTHELUC_SelectByField]
GO
CREATE PROCEDURE [dbo].[KHAMTHELUC_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT * FROM [dbo].[KHAMTHELUC] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KHAMTHELUC_DeleteByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KHAMTHELUC_DeleteByPrimaryKey]
GO
CREATE PROCEDURE [dbo].[KHAMTHELUC_DeleteByPrimaryKey]
	@ID int
AS

DELETE FROM [dbo].[KHAMTHELUC]
 WHERE 
	[ID] = @ID

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KHAMTHELUC_DeleteByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KHAMTHELUC_DeleteByField]
GO
CREATE PROCEDURE [dbo].[KHAMTHELUC_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[KHAMTHELUC] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KHAMCANLAMSANG_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KHAMCANLAMSANG_Insert]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KHAMCANLAMSANG_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KHAMCANLAMSANG_Update]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KHAMCANLAMSANG_SelectByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KHAMCANLAMSANG_SelectByPrimaryKey]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KHAMCANLAMSANG_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KHAMCANLAMSANG_SelectAll]
GO
CREATE PROCEDURE [dbo].[KHAMCANLAMSANG_SelectAll]
AS

	SELECT 
	*	
	FROM [dbo].[KHAMCANLAMSANG]

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KHAMCANLAMSANG_SelectByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KHAMCANLAMSANG_SelectByField]
GO
CREATE PROCEDURE [dbo].[KHAMCANLAMSANG_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT * FROM [dbo].[KHAMCANLAMSANG] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KHAMCANLAMSANG_DeleteByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KHAMCANLAMSANG_DeleteByPrimaryKey]
GO
CREATE PROCEDURE [dbo].[KHAMCANLAMSANG_DeleteByPrimaryKey]
	@ID int
AS

DELETE FROM [dbo].[KHAMCANLAMSANG]
 WHERE 
	[ID] = @ID

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KHAMCANLAMSANG_DeleteByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KHAMCANLAMSANG_DeleteByField]
GO
CREATE PROCEDURE [dbo].[KHAMCANLAMSANG_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[KHAMCANLAMSANG] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KHAMCHUYENKHOA_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KHAMCHUYENKHOA_Insert]
GO
CREATE PROCEDURE [dbo].[KHAMCHUYENKHOA_Insert]
	@ID int output,
	@BACSIID int = null ,
	@TAI nvarchar(MAX) = null ,
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
	@RANG,
	@HAM,
	@MAT,
	@KHAC,
	@GHICHU

)
	SELECT @ID=SCOPE_IDENTITY();


GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KHAMCHUYENKHOA_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KHAMCHUYENKHOA_Update]
GO
CREATE PROCEDURE [dbo].[KHAMCHUYENKHOA_Update]
	@ID int,
	@BACSIID int = null,
	@TAI nvarchar(MAX) = null,
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
	[RANG] = @RANG,
	[HAM] = @HAM,
	[MAT] = @MAT,
	[KHAC] = @KHAC,
	[GHICHU] = @GHICHU
 WHERE 
	[ID] = @ID

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KHAMCHUYENKHOA_SelectByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KHAMCHUYENKHOA_SelectByPrimaryKey]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KHAMCHUYENKHOA_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KHAMCHUYENKHOA_SelectAll]
GO
CREATE PROCEDURE [dbo].[KHAMCHUYENKHOA_SelectAll]
AS

	SELECT 
	*	
	FROM [dbo].[KHAMCHUYENKHOA]

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KHAMCHUYENKHOA_SelectByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KHAMCHUYENKHOA_SelectByField]
GO
CREATE PROCEDURE [dbo].[KHAMCHUYENKHOA_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT * FROM [dbo].[KHAMCHUYENKHOA] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KHAMCHUYENKHOA_DeleteByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KHAMCHUYENKHOA_DeleteByPrimaryKey]
GO
CREATE PROCEDURE [dbo].[KHAMCHUYENKHOA_DeleteByPrimaryKey]
	@ID int
AS

DELETE FROM [dbo].[KHAMCHUYENKHOA]
 WHERE 
	[ID] = @ID

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KHAMCHUYENKHOA_DeleteByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KHAMCHUYENKHOA_DeleteByField]
GO
CREATE PROCEDURE [dbo].[KHAMCHUYENKHOA_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[KHAMCHUYENKHOA] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KHAMDINHKI_Insert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KHAMDINHKI_Insert]
GO
CREATE PROCEDURE [dbo].[KHAMDINHKI_Insert]
	@ID int output,
	@BENHNHANID int = null ,
	@PHANLOAISUCKHOEID int = null ,
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KHAMDINHKI_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KHAMDINHKI_Update]
GO
CREATE PROCEDURE [dbo].[KHAMDINHKI_Update]
	@ID int,
	@BENHNHANID int = null,
	@PHANLOAISUCKHOEID int = null,
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KHAMDINHKI_SelectByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KHAMDINHKI_SelectByPrimaryKey]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KHAMDINHKI_SelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KHAMDINHKI_SelectAll]
GO
CREATE PROCEDURE [dbo].[KHAMDINHKI_SelectAll]
AS

	SELECT 
	*	
	FROM [dbo].[KHAMDINHKI]

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KHAMDINHKI_SelectByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KHAMDINHKI_SelectByField]
GO
CREATE PROCEDURE [dbo].[KHAMDINHKI_SelectByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'SELECT * FROM [dbo].[KHAMDINHKI] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KHAMDINHKI_DeleteByPrimaryKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KHAMDINHKI_DeleteByPrimaryKey]
GO
CREATE PROCEDURE [dbo].[KHAMDINHKI_DeleteByPrimaryKey]
	@ID int
AS

DELETE FROM [dbo].[KHAMDINHKI]
 WHERE 
	[ID] = @ID

GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[KHAMDINHKI_DeleteByField]') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure [dbo].[KHAMDINHKI_DeleteByField]
GO
CREATE PROCEDURE [dbo].[KHAMDINHKI_DeleteByField]
	@FieldName varchar(100),
	@Value varchar(1000)
AS

	DECLARE @query varchar(2000);

	SET @query = 'DELETE FROM [dbo].[KHAMDINHKI] WHERE [' + @FieldName  + '] = ''' + @Value + ''''
	EXEC(@query)

GO
