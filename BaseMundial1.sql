USE [master]
GO
/****** Object:  Database [mundial_Fifa]    Script Date: 26/09/2022 10:47:21 ******/
CREATE DATABASE [mundial_Fifa]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'mundial_Fifa', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\mundial_Fifa.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'mundial_Fifa_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\mundial_Fifa_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [mundial_Fifa] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [mundial_Fifa].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [mundial_Fifa] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [mundial_Fifa] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [mundial_Fifa] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [mundial_Fifa] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [mundial_Fifa] SET ARITHABORT OFF 
GO
ALTER DATABASE [mundial_Fifa] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [mundial_Fifa] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [mundial_Fifa] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [mundial_Fifa] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [mundial_Fifa] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [mundial_Fifa] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [mundial_Fifa] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [mundial_Fifa] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [mundial_Fifa] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [mundial_Fifa] SET  DISABLE_BROKER 
GO
ALTER DATABASE [mundial_Fifa] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [mundial_Fifa] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [mundial_Fifa] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [mundial_Fifa] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [mundial_Fifa] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [mundial_Fifa] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [mundial_Fifa] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [mundial_Fifa] SET RECOVERY FULL 
GO
ALTER DATABASE [mundial_Fifa] SET  MULTI_USER 
GO
ALTER DATABASE [mundial_Fifa] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [mundial_Fifa] SET DB_CHAINING OFF 
GO
ALTER DATABASE [mundial_Fifa] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [mundial_Fifa] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [mundial_Fifa] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [mundial_Fifa] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'mundial_Fifa', N'ON'
GO
ALTER DATABASE [mundial_Fifa] SET QUERY_STORE = OFF
GO
USE [mundial_Fifa]
GO
/****** Object:  Table [dbo].[DetalleGol1]    Script Date: 26/09/2022 10:47:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleGol1](
	[Id_detalle] [varchar](50) NOT NULL,
	[Seleccion] [varchar](50) NOT NULL,
	[Jug_gol] [varchar](50) NOT NULL,
	[Jug_asis] [varchar](50) NOT NULL,
	[Tipo_gol] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EstadJug]    Script Date: 26/09/2022 10:47:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstadJug](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Id_jugador] [varchar](50) NULL,
	[Goles] [int] NULL,
	[Tiros_marc] [int] NULL,
	[Tiros_des] [int] NULL,
	[Tarjetas_amarillas] [int] NULL,
	[Tarjetas_rojas] [int] NULL,
	[Minutos] [int] NULL,
	[Asistencias] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EstadSeleccion1]    Script Date: 26/09/2022 10:47:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstadSeleccion1](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Id_pais] [varchar](50) NULL,
	[Gol] [int] NULL,
	[Tiros_marco] [int] NULL,
	[Tiros_des] [int] NULL,
	[Tarjetas_amarillas] [int] NULL,
	[Tarjetas_rojas] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[JugadoresInfo]    Script Date: 26/09/2022 10:47:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[JugadoresInfo](
	[Id_jugador] [varchar](50) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Dorsal] [int] NULL,
	[Id_pais] [varchar](50) NULL,
	[Fecha] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_jugador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Seleccion]    Script Date: 26/09/2022 10:47:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Seleccion](
	[Id_pais] [varchar](50) NOT NULL,
	[Pais] [varchar](50) NOT NULL,
	[Entrenador] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Seleccion] PRIMARY KEY CLUSTERED 
(
	[Id_pais] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[EstadJug]  WITH CHECK ADD  CONSTRAINT [FK_EstadJug_JugadoresInfo] FOREIGN KEY([Id_jugador])
REFERENCES [dbo].[JugadoresInfo] ([Id_jugador])
GO
ALTER TABLE [dbo].[EstadJug] CHECK CONSTRAINT [FK_EstadJug_JugadoresInfo]
GO
ALTER TABLE [dbo].[EstadSeleccion1]  WITH CHECK ADD  CONSTRAINT [FK_EstadSeleccion1_Seleccion] FOREIGN KEY([Id_pais])
REFERENCES [dbo].[Seleccion] ([Id_pais])
GO
ALTER TABLE [dbo].[EstadSeleccion1] CHECK CONSTRAINT [FK_EstadSeleccion1_Seleccion]
GO
USE [master]
GO
ALTER DATABASE [mundial_Fifa] SET  READ_WRITE 
GO
