USE [master]
GO
/****** Object:  Database [gestion des etudiants]    Script Date: 17/03/2021 00:50:26 ******/
CREATE DATABASE [gestion des etudiants]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'gestion des etudiants', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\gestion des etudiants.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'gestion des etudiants_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\gestion des etudiants_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [gestion des etudiants] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [gestion des etudiants].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [gestion des etudiants] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [gestion des etudiants] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [gestion des etudiants] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [gestion des etudiants] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [gestion des etudiants] SET ARITHABORT OFF 
GO
ALTER DATABASE [gestion des etudiants] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [gestion des etudiants] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [gestion des etudiants] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [gestion des etudiants] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [gestion des etudiants] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [gestion des etudiants] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [gestion des etudiants] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [gestion des etudiants] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [gestion des etudiants] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [gestion des etudiants] SET  DISABLE_BROKER 
GO
ALTER DATABASE [gestion des etudiants] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [gestion des etudiants] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [gestion des etudiants] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [gestion des etudiants] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [gestion des etudiants] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [gestion des etudiants] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [gestion des etudiants] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [gestion des etudiants] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [gestion des etudiants] SET  MULTI_USER 
GO
ALTER DATABASE [gestion des etudiants] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [gestion des etudiants] SET DB_CHAINING OFF 
GO
ALTER DATABASE [gestion des etudiants] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [gestion des etudiants] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [gestion des etudiants] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [gestion des etudiants] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [gestion des etudiants] SET QUERY_STORE = OFF
GO
USE [gestion des etudiants]
GO
/****** Object:  Table [dbo].[Etudiant]    Script Date: 17/03/2021 00:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Etudiant](
	[cne] [varchar](50) NOT NULL,
	[nom] [varchar](50) NULL,
	[prenom] [varchar](50) NULL,
	[sexe] [char](1) NULL,
	[date_naiss] [date] NULL,
	[photo] [varchar](100) NULL,
	[email] [varchar](50) NULL,
	[id_fil] [int] NULL,
	[annee_cycle] [int] NULL,
 CONSTRAINT [PK_Etudiant] PRIMARY KEY CLUSTERED 
(
	[cne] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Filiere]    Script Date: 17/03/2021 00:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Filiere](
	[Id_filiere] [int] IDENTITY(1,1) NOT NULL,
	[Nom_filiere] [varchar](100) NULL,
	[Responsable] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_filiere] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Etudiant] ([cne], [nom], [prenom], [sexe], [date_naiss], [photo], [email], [id_fil], [annee_cycle]) VALUES (N'BK', N'Bouchwik', N'Lamiaa', N'F', CAST(N'1999-08-07' AS Date), N'Assets/BK.jpeg', N'BK@outlook.com', 1, 2)
INSERT [dbo].[Etudiant] ([cne], [nom], [prenom], [sexe], [date_naiss], [photo], [email], [id_fil], [annee_cycle]) VALUES (N'GR2356', N'Grif', N'Center', N'M', CAST(N'2020-03-17' AS Date), N'Assets/GR2356.png', N'grif.center@gmail.com', 3, 3)
INSERT [dbo].[Etudiant] ([cne], [nom], [prenom], [sexe], [date_naiss], [photo], [email], [id_fil], [annee_cycle]) VALUES (N'H45', N'Amine', N'Mhamed', N'M', CAST(N'2021-03-11' AS Date), N'Assets/H45.jpg', N'amine@gmail.com', 6, 1)
INSERT [dbo].[Etudiant] ([cne], [nom], [prenom], [sexe], [date_naiss], [photo], [email], [id_fil], [annee_cycle]) VALUES (N'h78', N'yara', N'mk', N'F', CAST(N'2021-05-06' AS Date), N'Assets/h78.jpg', N'yara@gmail.com', 6, 1)
INSERT [dbo].[Etudiant] ([cne], [nom], [prenom], [sexe], [date_naiss], [photo], [email], [id_fil], [annee_cycle]) VALUES (N'HT123', N'Tazribine', N'Hassan', N'M', CAST(N'1998-03-04' AS Date), N'Assets/HT123.jpeg', N'Hassan@gmail.com', 1, 2)
INSERT [dbo].[Etudiant] ([cne], [nom], [prenom], [sexe], [date_naiss], [photo], [email], [id_fil], [annee_cycle]) VALUES (N'k19', N'manal', N'bk', N'F', CAST(N'2021-03-07' AS Date), N'Assets/k19.jpg', N'manalbk@gmail.com', 14, 1)
INSERT [dbo].[Etudiant] ([cne], [nom], [prenom], [sexe], [date_naiss], [photo], [email], [id_fil], [annee_cycle]) VALUES (N'k41', N'Hachimi', N'yassine', N'M', CAST(N'2021-03-13' AS Date), N'Assets/k41.jpg', N'yassine@gmail.com', 16, 1)
INSERT [dbo].[Etudiant] ([cne], [nom], [prenom], [sexe], [date_naiss], [photo], [email], [id_fil], [annee_cycle]) VALUES (N'k548', N'Mohamed', N'yatim', N'M', CAST(N'2021-03-05' AS Date), N'Assets/k548.jpg', N'mohamed@gmail.com', 14, 2)
INSERT [dbo].[Etudiant] ([cne], [nom], [prenom], [sexe], [date_naiss], [photo], [email], [id_fil], [annee_cycle]) VALUES (N'K66', N'EL HIMER', N'Safae', N'F', CAST(N'2021-03-21' AS Date), N'Assets/K66.jpg', N'safae@gmail.com', 1, 3)
INSERT [dbo].[Etudiant] ([cne], [nom], [prenom], [sexe], [date_naiss], [photo], [email], [id_fil], [annee_cycle]) VALUES (N'k78', N'sara', N'bnz', N'F', CAST(N'2021-03-01' AS Date), N'Assets/k78.jpg', N'sara@gmail.com', 14, 3)
INSERT [dbo].[Etudiant] ([cne], [nom], [prenom], [sexe], [date_naiss], [photo], [email], [id_fil], [annee_cycle]) VALUES (N'k85', N'Vaneck', N'fouckou', N'M', CAST(N'2021-03-13' AS Date), N'Assets/k85.jpg', N'vaneck@gmail.com', 6, 2)
INSERT [dbo].[Etudiant] ([cne], [nom], [prenom], [sexe], [date_naiss], [photo], [email], [id_fil], [annee_cycle]) VALUES (N'L89', N'yani', N'mamado', N'M', CAST(N'2021-03-07' AS Date), N'Assets/L89.jpg', N'yani@gmail.com', 14, 1)
INSERT [dbo].[Etudiant] ([cne], [nom], [prenom], [sexe], [date_naiss], [photo], [email], [id_fil], [annee_cycle]) VALUES (N'M15', N'Vanelle', N'Cindy', N'F', CAST(N'2021-03-21' AS Date), N'Assets/M15.jpg', N'vanelle@gmail.com', 6, 3)
INSERT [dbo].[Etudiant] ([cne], [nom], [prenom], [sexe], [date_naiss], [photo], [email], [id_fil], [annee_cycle]) VALUES (N'MM1345', N'Matrouh', N'Mohammed', N'M', CAST(N'1999-05-22' AS Date), N'Assets/MM1345.jpeg', N'MatrouhM@gmail.com', 1, 2)
INSERT [dbo].[Etudiant] ([cne], [nom], [prenom], [sexe], [date_naiss], [photo], [email], [id_fil], [annee_cycle]) VALUES (N'SR9764', N'Rouddasse', N'Saad', N'M', CAST(N'1997-07-05' AS Date), N'Assets/SR9764.jpg', N'saadrds@gmail.com', 1, 2)
INSERT [dbo].[Etudiant] ([cne], [nom], [prenom], [sexe], [date_naiss], [photo], [email], [id_fil], [annee_cycle]) VALUES (N'T135395', N'Taoussi', N'Jamal', N'M', CAST(N'1995-06-16' AS Date), N'Assets/T135395.jpeg', N'Ettousy@gmail.com', 1, 3)
INSERT [dbo].[Etudiant] ([cne], [nom], [prenom], [sexe], [date_naiss], [photo], [email], [id_fil], [annee_cycle]) VALUES (N'YT977', N'Touama', N'Youssef', N'M', CAST(N'1998-08-20' AS Date), N'Assets/YT977.jpg', N'Touama@gmail.com', 1, 2)
GO
SET IDENTITY_INSERT [dbo].[Filiere] ON 

INSERT [dbo].[Filiere] ([Id_filiere], [Nom_filiere], [Responsable]) VALUES (1, N'Genie Informatique', N'Said Echadi')
INSERT [dbo].[Filiere] ([Id_filiere], [Nom_filiere], [Responsable]) VALUES (3, N'Génie réseaux ', N'Habba')
INSERT [dbo].[Filiere] ([Id_filiere], [Nom_filiere], [Responsable]) VALUES (6, N'Génie industriel', N'Abidi')
INSERT [dbo].[Filiere] ([Id_filiere], [Nom_filiere], [Responsable]) VALUES (14, N'GPMC', N'Abouyatim')
INSERT [dbo].[Filiere] ([Id_filiere], [Nom_filiere], [Responsable]) VALUES (15, N'Génie mécatronique', N'Bendaoud')
INSERT [dbo].[Filiere] ([Id_filiere], [Nom_filiere], [Responsable]) VALUES (16, N'Génie anglais', N'atri')
SET IDENTITY_INSERT [dbo].[Filiere] OFF
GO
USE [master]
GO
ALTER DATABASE [gestion des etudiants] SET  READ_WRITE 
GO
