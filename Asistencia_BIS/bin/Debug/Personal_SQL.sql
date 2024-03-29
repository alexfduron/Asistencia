USE [master]
GO
/****** Object:  Database [PERSONAL_RH]    Script Date: 1/24/2023 10:08:46 PM ******/
CREATE DATABASE [PERSONAL_RH]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PERSONAL_RH', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\PERSONAL_RH.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PERSONAL_RH_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\PERSONAL_RH_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [PERSONAL_RH] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PERSONAL_RH].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PERSONAL_RH] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PERSONAL_RH] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PERSONAL_RH] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PERSONAL_RH] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PERSONAL_RH] SET ARITHABORT OFF 
GO
ALTER DATABASE [PERSONAL_RH] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PERSONAL_RH] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PERSONAL_RH] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PERSONAL_RH] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PERSONAL_RH] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PERSONAL_RH] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PERSONAL_RH] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PERSONAL_RH] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PERSONAL_RH] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PERSONAL_RH] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PERSONAL_RH] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PERSONAL_RH] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PERSONAL_RH] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PERSONAL_RH] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PERSONAL_RH] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PERSONAL_RH] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PERSONAL_RH] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PERSONAL_RH] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PERSONAL_RH] SET  MULTI_USER 
GO
ALTER DATABASE [PERSONAL_RH] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PERSONAL_RH] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PERSONAL_RH] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PERSONAL_RH] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PERSONAL_RH] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PERSONAL_RH] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [PERSONAL_RH] SET QUERY_STORE = OFF
GO
USE [PERSONAL_RH]
GO
/****** Object:  Table [dbo].[Tbl_Cargo]    Script Date: 1/24/2023 10:08:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Cargo](
	[ID_Cargo] [int] IDENTITY(1,1) NOT NULL,
	[Cargo] [varchar](max) NULL,
	[ID_Estado] [int] NULL,
 CONSTRAINT [PK_Tbl_Cargo] PRIMARY KEY CLUSTERED 
(
	[ID_Cargo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_CC]    Script Date: 1/24/2023 10:08:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_CC](
	[ID_Centro_de_Costo] [int] IDENTITY(1,1) NOT NULL,
	[Centro_de_Costo] [varchar](max) NULL,
	[ID_Estado] [int] NULL,
	[Planta] [varchar](max) NULL,
 CONSTRAINT [PK_Tbl_CC] PRIMARY KEY CLUSTERED 
(
	[ID_Centro_de_Costo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Estado]    Script Date: 1/24/2023 10:08:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Estado](
	[ID_Estado] [int] IDENTITY(1,1) NOT NULL,
	[Estado] [varchar](max) NULL,
	[Aplicar_a_Tabla] [varchar](max) NULL,
 CONSTRAINT [PK_Tbl_Estado] PRIMARY KEY CLUSTERED 
(
	[ID_Estado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Personal]    Script Date: 1/24/2023 10:08:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Personal](
	[ID_Personal] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [varchar](max) NULL,
	[Nombre] [varchar](max) NULL,
	[Apellido] [varchar](max) NULL,
	[ID_Centro_de_Costo] [int] NULL,
	[ID_Cargo] [int] NULL,
	[ID_Supervisor] [int] NULL,
	[ID_Estado] [int] NULL,
	[Foto] [varbinary](max) NULL,
 CONSTRAINT [PK_Tbl_Personal_1] PRIMARY KEY CLUSTERED 
(
	[ID_Personal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Super]    Script Date: 1/24/2023 10:08:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Super](
	[ID_Supervisor] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](max) NULL,
	[Apellido] [varchar](max) NULL,
	[ID_Estado] [int] NULL,
	[ID_CC] [int] NULL,
 CONSTRAINT [PK_Tbl_Super] PRIMARY KEY CLUSTERED 
(
	[ID_Supervisor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Transaccion]    Script Date: 1/24/2023 10:08:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Transaccion](
	[ID_Transaccion] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [date] NULL,
	[Hora] [time](7) NULL,
	[FechaHora] [datetime] NULL,
	[Usuario] [varchar](max) NULL,
	[ID_Personal] [int] NULL,
	[Campo] [varchar](max) NULL,
	[Val_1] [varchar](max) NULL,
	[Val_2] [varchar](max) NULL,
 CONSTRAINT [PK_Tbl_Transaccion] PRIMARY KEY CLUSTERED 
(
	[ID_Transaccion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Tbl_Cargo]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_Cargo_Tbl_Estado] FOREIGN KEY([ID_Estado])
REFERENCES [dbo].[Tbl_Estado] ([ID_Estado])
GO
ALTER TABLE [dbo].[Tbl_Cargo] CHECK CONSTRAINT [FK_Tbl_Cargo_Tbl_Estado]
GO
ALTER TABLE [dbo].[Tbl_CC]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_CC_Tbl_Estado] FOREIGN KEY([ID_Estado])
REFERENCES [dbo].[Tbl_Estado] ([ID_Estado])
GO
ALTER TABLE [dbo].[Tbl_CC] CHECK CONSTRAINT [FK_Tbl_CC_Tbl_Estado]
GO
ALTER TABLE [dbo].[Tbl_Personal]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_Personal_Tbl_Cargo] FOREIGN KEY([ID_Cargo])
REFERENCES [dbo].[Tbl_Cargo] ([ID_Cargo])
GO
ALTER TABLE [dbo].[Tbl_Personal] CHECK CONSTRAINT [FK_Tbl_Personal_Tbl_Cargo]
GO
ALTER TABLE [dbo].[Tbl_Personal]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_Personal_Tbl_CC] FOREIGN KEY([ID_Centro_de_Costo])
REFERENCES [dbo].[Tbl_CC] ([ID_Centro_de_Costo])
GO
ALTER TABLE [dbo].[Tbl_Personal] CHECK CONSTRAINT [FK_Tbl_Personal_Tbl_CC]
GO
ALTER TABLE [dbo].[Tbl_Personal]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_Personal_Tbl_Estado] FOREIGN KEY([ID_Estado])
REFERENCES [dbo].[Tbl_Estado] ([ID_Estado])
GO
ALTER TABLE [dbo].[Tbl_Personal] CHECK CONSTRAINT [FK_Tbl_Personal_Tbl_Estado]
GO
ALTER TABLE [dbo].[Tbl_Personal]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_Personal_Tbl_Super] FOREIGN KEY([ID_Supervisor])
REFERENCES [dbo].[Tbl_Super] ([ID_Supervisor])
GO
ALTER TABLE [dbo].[Tbl_Personal] CHECK CONSTRAINT [FK_Tbl_Personal_Tbl_Super]
GO
ALTER TABLE [dbo].[Tbl_Super]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_Super_Tbl_Estado] FOREIGN KEY([ID_Estado])
REFERENCES [dbo].[Tbl_Estado] ([ID_Estado])
GO
ALTER TABLE [dbo].[Tbl_Super] CHECK CONSTRAINT [FK_Tbl_Super_Tbl_Estado]
GO
ALTER TABLE [dbo].[Tbl_Transaccion]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_Transaccion_Tbl_Personal] FOREIGN KEY([ID_Personal])
REFERENCES [dbo].[Tbl_Personal] ([ID_Personal])
GO
ALTER TABLE [dbo].[Tbl_Transaccion] CHECK CONSTRAINT [FK_Tbl_Transaccion_Tbl_Personal]
GO
/****** Object:  StoredProcedure [dbo].[Buscar_Personal]    Script Date: 1/24/2023 10:08:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Alex Duron
-- Create date: 24ENE23
-- Description:	Buscar Personal
-- =============================================
CREATE PROCEDURE [dbo].[Buscar_Personal]
	-- Add the parameters for the stored procedure here
	@Desde as int,
	@Hasta as int,
	@Buscador as varchar(max)

AS
BEGIN

    -- Insert statements for procedure here
	SET NOCOUNT ON;

	SELECT ID_Personal, Codigo, Empleado, Centro_de_Costo, Cargo, Supervisor, Estado, Foto 
	FROM(
		SELECT ID_Personal, Codigo, 
			CONCAT(Tbl_Personal.Nombre, ' ', Tbl_Personal.Apellido) AS 'Empleado', 
			Tbl_CC.Centro_de_Costo, Tbl_Personal.ID_Centro_de_Costo, 
			Tbl_Cargo.Cargo, Tbl_Personal.ID_Cargo, 
			CONCAT(Tbl_Super.Nombre, ' ', Tbl_Super.Apellido) AS 'Supervisor', Tbl_Personal.ID_Supervisor,
			Tbl_Estado.Estado, Tbl_Personal.ID_Estado,
			Foto,
			ROW_NUMBER() OVER(ORDER BY ID_Personal) AS 'Num_Fila' 
		FROM Tbl_Personal 
		INNER JOIN Tbl_CC ON Tbl_CC.ID_Centro_de_Costo = Tbl_Personal.ID_Centro_de_Costo
		INNER JOIN Tbl_Cargo ON Tbl_Cargo.ID_Cargo = Tbl_Personal.ID_Cargo 
		INNER JOIN Tbl_Super ON Tbl_Super.ID_Supervisor = Tbl_Personal.ID_Supervisor
		INNER JOIN Tbl_Estado ON Tbl_Estado.ID_Estado = Tbl_Personal.ID_Estado
		
		) AS Paginado
	WHERE	(Paginado.Num_Fila >= @Desde) AND 
			(Paginado.Num_Fila <= @Hasta) AND 
			(Codigo + Empleado + Centro_de_Costo + Cargo + Supervisor LIKE '%' + @Buscador + '%')

END
GO
/****** Object:  StoredProcedure [dbo].[Editar_Personal]    Script Date: 1/24/2023 10:08:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Alex Duron
-- Create date: 22ENE23
-- Description:	Editar Personal
-- =============================================
CREATE PROCEDURE [dbo].[Editar_Personal]
	-- Add the parameters for the stored procedure here
	@ID_Personal int,
	@Codigo as varchar(max),
    @Nombre as varchar(max),
    @Apellido as varchar(max),
    @ID_Centro_de_Costo as int,
    @ID_Cargo as int,
    @ID_Supervisor as int,
    @ID_Estado as int,
    @Foto as varbinary(max)

AS
	
	DECLARE @Fecha as date
	DECLARE @Hora as time(7)
	DECLARE @FechaHora as datetime
	DECLARE @Usuario as varchar(max)

	SET @Fecha = CONVERT(date, GETDATE())
	SET @Hora = CONVERT(time, GETDATE())
	SET @FechaHora = GETDATE()
	SET @Usuario = 'ADMIN'

	IF EXISTS(SELECT Codigo FROM Tbl_Personal WHERE Codigo = @Codigo AND ID_Personal <> @ID_Personal)
		BEGIN
			RAISERROR('Ya existe un registro con este codigo',16,1)
		END
	ELSE
		BEGIN
			-- Insert statements for procedure here
			IF (SELECT Nombre FROM Tbl_Personal WHERE ID_Personal = @ID_Personal) <> @Nombre
				BEGIN
					INSERT INTO Tbl_Transaccion(Fecha, Hora, FechaHora, Usuario, ID_Personal, Campo, Val_1, Val_2)
						VALUES(	@Fecha, @Hora, @FechaHora, @Usuario, @ID_Personal, 'NOMBRE', 
								(SELECT Nombre FROM Tbl_Personal WHERE ID_Personal = @ID_Personal), @Nombre)

					UPDATE Tbl_Personal SET Nombre = @Nombre WHERE ID_Personal = @ID_Personal
				END

			IF (SELECT Apellido FROM Tbl_Personal WHERE ID_Personal = @ID_Personal) <> @Apellido
				BEGIN
					INSERT INTO Tbl_Transaccion(Fecha, Hora, FechaHora, Usuario, ID_Personal, Campo, Val_1, Val_2)
						VALUES(	@Fecha, @Hora, @FechaHora, @Usuario, @ID_Personal, 'APELLIDO', 
								(SELECT Apellido FROM Tbl_Personal WHERE ID_Personal = @ID_Personal), @Apellido)

					UPDATE Tbl_Personal SET Apellido = @Apellido WHERE ID_Personal = @ID_Personal
				END
			
			IF (SELECT ID_Centro_de_Costo FROM Tbl_Personal WHERE ID_Personal = @ID_Personal) <> @ID_Centro_de_Costo
				BEGIN
					INSERT INTO Tbl_Transaccion(Fecha, Hora, FechaHora, Usuario, ID_Personal, Campo, Val_1, Val_2)
						VALUES(	@Fecha, @Hora, @FechaHora, @Usuario, @ID_Personal, 'CENTRO DE COSTO', 
								(SELECT ID_Centro_de_Costo FROM Tbl_Personal WHERE ID_Personal = @ID_Personal), @ID_Centro_de_Costo)

					UPDATE Tbl_Personal SET ID_Centro_de_Costo = @ID_Centro_de_Costo WHERE ID_Personal = @ID_Personal
				END

			IF (SELECT ID_Cargo FROM Tbl_Personal WHERE ID_Personal = @ID_Personal) <> @ID_Cargo
				BEGIN
					INSERT INTO Tbl_Transaccion(Fecha, Hora, FechaHora, Usuario, ID_Personal, Campo, Val_1, Val_2)
						VALUES(	@Fecha, @Hora, @FechaHora, @Usuario, @ID_Personal, 'CARGO', 
								(SELECT ID_Cargo FROM Tbl_Personal WHERE ID_Personal = @ID_Personal), @ID_Cargo)

					UPDATE Tbl_Personal SET ID_Cargo = @ID_Cargo WHERE ID_Personal = @ID_Personal
				END

			IF (SELECT ID_Supervisor FROM Tbl_Personal WHERE ID_Personal = @ID_Personal) <> @ID_Supervisor
				BEGIN
					INSERT INTO Tbl_Transaccion(Fecha, Hora, FechaHora, Usuario, ID_Personal, Campo, Val_1, Val_2)
						VALUES(	@Fecha, @Hora, @FechaHora, @Usuario, @ID_Personal, 'SUPERVISOR', 
								(SELECT ID_Supervisor FROM Tbl_Personal WHERE ID_Personal = @ID_Personal), @ID_Supervisor)

					UPDATE Tbl_Personal SET ID_Supervisor = @ID_Supervisor WHERE ID_Personal = @ID_Personal
				END
				
			IF (SELECT ID_Estado FROM Tbl_Personal WHERE ID_Personal = @ID_Personal) <> @ID_Estado
				BEGIN
					INSERT INTO Tbl_Transaccion(Fecha, Hora, FechaHora, Usuario, ID_Personal, Campo, Val_1, Val_2)
						VALUES(	@Fecha, @Hora, @FechaHora, @Usuario, @ID_Personal, 'ESTADO', 
								(SELECT ID_Estado FROM Tbl_Personal WHERE ID_Personal = @ID_Personal), @ID_Estado)

					UPDATE Tbl_Personal SET ID_Estado = @ID_Estado WHERE ID_Personal = @ID_Personal
				END
				
			IF (SELECT Foto FROM Tbl_Personal WHERE ID_Personal = @ID_Personal) <> @Foto
				BEGIN
					INSERT INTO Tbl_Transaccion(Fecha, Hora, FechaHora, Usuario, ID_Personal, Campo, Val_1, Val_2)
						VALUES(	@Fecha, @Hora, @FechaHora, @Usuario, @ID_Personal, 'FOTO', 
								(SELECT Foto FROM Tbl_Personal WHERE ID_Personal = @ID_Personal), @Foto)

					UPDATE Tbl_Personal SET Foto = @Foto WHERE ID_Personal = @ID_Personal
				END

			--UPDATE Tbl_Personal 
			--SET 
			--	Nombre = @Nombre,
			--	Apellido = @Apellido,
			--	ID_Centro_de_Costo = @ID_Centro_de_Costo,
			--	ID_Cargo = @ID_Cargo,
			--	ID_Supervisor = @ID_Supervisor,
			--	ID_Estado = @ID_Estado,
			--	Foto = @Foto
			--WHERE ID_Personal = @ID_Personal

		END
GO
/****** Object:  StoredProcedure [dbo].[Eliminar_Personal]    Script Date: 1/24/2023 10:08:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Alex Duron
-- Create date: 24ENE23
-- Description:	Eliminar Personal
-- =============================================
CREATE PROCEDURE [dbo].[Eliminar_Personal]
	-- Add the parameters for the stored procedure here
	@ID_Personal as int

AS
BEGIN
    -- Insert statements for procedure here
	UPDATE Tbl_Personal 
	SET ID_Estado = (SELECT ID_Estado FROM Tbl_Estado WHERE Estado = 'INACTIVO')
	WHERE ID_Personal = @ID_Personal

END
GO
/****** Object:  StoredProcedure [dbo].[Insertar_Personal]    Script Date: 1/24/2023 10:08:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Alex Duron
-- Create date: 22ENE23
-- Description:	Insertar Personal
-- =============================================
CREATE PROCEDURE [dbo].[Insertar_Personal]
	-- Add the parameters for the stored procedure here
	@Codigo as varchar(max),
	@Nombre as varchar(max),
	@Apellido as varchar(max),
	@ID_Centro_de_Costo as int,
	@ID_Cargo as int,
	@ID_Supervisor as int,
	--@ID_Estado as int,
	@Foto as varbinary(max)


AS

	DECLARE @ID_Estado as int
	DECLARE @ID_Generado as int

	SET @ID_Estado = 1

	IF EXISTS(SELECT Codigo FROM Tbl_Personal WHERE Codigo = @Codigo)
		BEGIN
			RAISERROR('Ya existe un registro con este Codigo', 16, 1)
		END
	ELSE
		BEGIN
			-- Insert statements for procedure here
			INSERT INTO Tbl_Personal
			VALUES(	@Codigo,
					@Nombre,
					@Apellido,
					@ID_Centro_de_Costo,
					@ID_Cargo,
					@ID_Supervisor,
					@ID_Estado,
					@Foto)

			SELECT @ID_Generado = SCOPE_IDENTITY()

			INSERT INTO Tbl_Transaccion (	Fecha, 
											Hora, 
											FechaHora, 
											Usuario, 
											ID_Personal, 
											Campo)
			VALUES(	CONVERT(date, GETDATE()),
					CONVERT(time, GETDATE()),
					GETDATE(),
					'ADMIN',
					@ID_Generado,
					'ALL')

		END
GO
/****** Object:  StoredProcedure [dbo].[Mostrar_Personal]    Script Date: 1/24/2023 10:08:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Alex Duron
-- Create date: 22ENE23
-- Description:	Mostrar Personal
-- =============================================
CREATE PROCEDURE [dbo].[Mostrar_Personal]
	-- Add the parameters for the stored procedure here
	@Desde as int,
	@Hasta as int

AS
BEGIN

    -- Insert statements for procedure here
	SET NOCOUNT ON;

	SELECT ID_Personal, Codigo, Empleado, Centro_de_Costo, Cargo, Supervisor, Estado, Foto 
	FROM(
		SELECT ID_Personal, Codigo, 
			CONCAT(Tbl_Personal.Nombre, ' ', Tbl_Personal.Apellido) AS 'Empleado', 
			Tbl_CC.Centro_de_Costo, Tbl_Personal.ID_Centro_de_Costo, 
			Tbl_Cargo.Cargo, Tbl_Personal.ID_Cargo, 
			CONCAT(Tbl_Super.Nombre, ' ', Tbl_Super.Apellido) AS 'Supervisor', Tbl_Personal.ID_Supervisor,
			Tbl_Estado.Estado, Tbl_Personal.ID_Estado,
			Foto,
			ROW_NUMBER() OVER(ORDER BY ID_Personal) AS 'Num_Fila' 
		FROM Tbl_Personal 
		INNER JOIN Tbl_CC ON Tbl_CC.ID_Centro_de_Costo = Tbl_Personal.ID_Centro_de_Costo
		INNER JOIN Tbl_Cargo ON Tbl_Cargo.ID_Cargo = Tbl_Personal.ID_Cargo 
		INNER JOIN Tbl_Super ON Tbl_Super.ID_Supervisor = Tbl_Personal.ID_Supervisor
		INNER JOIN Tbl_Estado ON Tbl_Estado.ID_Estado = Tbl_Personal.ID_Estado
		
		) AS Paginado
	--WHERE Paginado.Estado = 'ACTIVO'
	WHERE (Paginado.Num_Fila >= @Desde) AND (Paginado.Num_Fila <= @Hasta)

END
GO
USE [master]
GO
ALTER DATABASE [PERSONAL_RH] SET  READ_WRITE 
GO
