USE [master]
GO
/****** Object:  Database [gasolinera]    Script Date: 12/11/2015 5:43:25 ******/
CREATE DATABASE [gasolinera]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'gasolinera', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.ALTIMEX\MSSQL\DATA\gasolinera.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'gasolinera_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.ALTIMEX\MSSQL\DATA\gasolinera_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [gasolinera] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [gasolinera].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [gasolinera] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [gasolinera] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [gasolinera] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [gasolinera] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [gasolinera] SET ARITHABORT OFF 
GO
ALTER DATABASE [gasolinera] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [gasolinera] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [gasolinera] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [gasolinera] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [gasolinera] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [gasolinera] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [gasolinera] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [gasolinera] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [gasolinera] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [gasolinera] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [gasolinera] SET  DISABLE_BROKER 
GO
ALTER DATABASE [gasolinera] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [gasolinera] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [gasolinera] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [gasolinera] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [gasolinera] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [gasolinera] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [gasolinera] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [gasolinera] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [gasolinera] SET  MULTI_USER 
GO
ALTER DATABASE [gasolinera] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [gasolinera] SET DB_CHAINING OFF 
GO
ALTER DATABASE [gasolinera] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [gasolinera] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [gasolinera]
GO
/****** Object:  User [gasolinera]    Script Date: 12/11/2015 5:43:25 ******/
CREATE USER [gasolinera] FOR LOGIN [gasolinera] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [gas]    Script Date: 12/11/2015 5:43:25 ******/
CREATE USER [gas] FOR LOGIN [gas] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [gasolinera]
GO
ALTER ROLE [db_denydatawriter] ADD MEMBER [gasolinera]
GO
ALTER ROLE [db_owner] ADD MEMBER [gas]
GO
/****** Object:  StoredProcedure [dbo].[GetEmple]    Script Date: 12/11/2015 5:43:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetEmple]
	-- Add the parameters for the stored procedure here
	@tipo int, @nombre varchar(500),  @activo int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
	if @tipo = 1
	begin
	SELECT * from empleado
	where nombre like '%' +  @nombre + '%'
	end
	else
	begin
	if @tipo = 2
	begin
	SELECT * from empleado
	where apellido like '%' +  @nombre + '%'
	end
	else
	begin
	SELECT * from empleado
	where estado = @activo
	end
	end
	 
END

GO
/****** Object:  StoredProcedure [dbo].[GetUser]    Script Date: 12/11/2015 5:43:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetUser]
	-- Add the parameters for the stored procedure here
	@tipo int, @nombre varchar(500),@idperfil int,  @activo int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
	if @tipo = 1
	begin
	SELECT * from usuario
	where usuario like '%' +  @nombre + '%'
	end
	else
	begin
	if @tipo = 2
	begin
	SELECT * from usuario
	where idperfil like '%' +  @nombre + '%'
	end
	else
	begin
	if @tipo =3
	begin 
	SELECT * from usuario
	where estado = @activo
	end
	else
	begin
	SELECT * from usuario
	end
	
	end
	end
	 
END

GO
/****** Object:  StoredProcedure [dbo].[InsertEmple]    Script Date: 12/11/2015 5:43:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsertEmple]
	-- Add the parameters for the stored procedure here
	@nombre varchar(500), @apellido varchar(500), @fechnac datetime, @genero varchar(5), @direccion varchar(max), @telefono varchar(50), 
	@fecingre datetime, @dui varchar(50), @nit varchar(50), @estado int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into empleado (nombre,apellido,fecha_nac,genero,direccion,telefono,fechaingreso,dui,nit,estado)
	values (@nombre,@apellido,@fechnac,@genero,@direccion,@telefono,@fecingre,@dui,@nit,@estado)
END

GO
/****** Object:  StoredProcedure [dbo].[InsertUser]    Script Date: 12/11/2015 5:43:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsertUser]
	-- Add the parameters for the stored procedure here
	@idempleado int, @Userd varchar(50), @Pasword varchar(50), @perfil int, @estado int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into usuario (idempleado,usuario,pasword,idperfil,estado ) 
	values (@idempleado,@Userd,@Pasword,@perfil,@estado)
END

GO
/****** Object:  Table [dbo].[empleado]    Script Date: 12/11/2015 5:43:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[empleado](
	[idempleado] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](5000) NULL,
	[apellido] [varchar](5000) NULL,
	[genero] [varchar](5) NULL,
	[fecha_nac] [datetime] NULL,
	[dui] [varchar](500) NULL,
	[nit] [varchar](500) NULL,
	[fechaingreso] [datetime] NULL,
	[telefono] [varchar](50) NULL,
	[direccion] [varchar](max) NULL,
	[estado] [int] NULL,
 CONSTRAINT [PK_empleado] PRIMARY KEY CLUSTERED 
(
	[idempleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[perfil]    Script Date: 12/11/2015 5:43:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[perfil](
	[idperfil] [int] IDENTITY(1,1) NOT NULL,
	[descripccion] [varchar](500) NOT NULL,
	[estado] [int] NOT NULL,
 CONSTRAINT [PK_perfil] PRIMARY KEY CLUSTERED 
(
	[idperfil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 12/11/2015 5:43:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[usuario](
	[idusuario] [int] IDENTITY(1,1) NOT NULL,
	[idempleado] [int] NOT NULL,
	[usuario] [varchar](50) NULL,
	[pasword] [varchar](500) NULL,
	[idperfil] [int] NOT NULL,
	[estado] [int] NULL,
 CONSTRAINT [PK_usuario] PRIMARY KEY CLUSTERED 
(
	[idusuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
USE [master]
GO
ALTER DATABASE [gasolinera] SET  READ_WRITE 
GO
