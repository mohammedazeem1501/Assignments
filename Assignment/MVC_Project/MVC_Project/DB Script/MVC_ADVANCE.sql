USE [master]
GO
/****** Object:  Database [MVC]    Script Date: 4/10/2020 2:43:02 PM ******/
CREATE DATABASE [MVC]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MVC', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\MVC.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MVC_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\MVC_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [MVC] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MVC].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MVC] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MVC] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MVC] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MVC] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MVC] SET ARITHABORT OFF 
GO
ALTER DATABASE [MVC] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [MVC] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MVC] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MVC] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MVC] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MVC] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MVC] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MVC] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MVC] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MVC] SET  ENABLE_BROKER 
GO
ALTER DATABASE [MVC] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MVC] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MVC] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MVC] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MVC] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MVC] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MVC] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MVC] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MVC] SET  MULTI_USER 
GO
ALTER DATABASE [MVC] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MVC] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MVC] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MVC] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MVC] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MVC] SET QUERY_STORE = OFF
GO
USE [MVC]
GO
/****** Object:  Table [dbo].[Backend]    Script Date: 4/10/2020 2:43:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Backend](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](10) NULL,
	[Description] [varchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 4/10/2020 2:43:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[Emp_ID] [int] NOT NULL,
	[FirstName] [varchar](12) NOT NULL,
	[LastName] [varchar](10) NULL,
	[Designation] [varchar](10) NULL,
	[Competency] [varchar](10) NULL,
	[Experience] [int] NULL,
	[Salary] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[Emp_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Frontend]    Script Date: 4/10/2020 2:43:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Frontend](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](10) NULL,
	[Description] [varchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mobility]    Script Date: 4/10/2020 2:43:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mobility](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](10) NULL,
	[Description] [varchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Testing]    Script Date: 4/10/2020 2:43:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Testing](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](10) NULL,
	[Description] [varchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserDetails]    Script Date: 4/10/2020 2:43:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserDetails](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](20) NULL,
	[Password] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Backend] ON 
GO
INSERT [dbo].[Backend] ([ID], [Name], [Description]) VALUES (1, N'Grails', N'TO THE NEW (erstwhile IntelliGrape) is a global leader in Grails development and has helped Fortune 500 companies, as well as Silicon Valley start-ups, build mission-critical applications on Grails. Using Grails development capabilities, we have developed SaaS products, video portals, live-streaming applications, analytics engines, e-commerce sites & marketplaces. Our Grails center of excellence has acquired expertise on the latest Grails versions including Grails 3.1.')
GO
INSERT [dbo].[Backend] ([ID], [Name], [Description]) VALUES (2, N'Java', N'Right from choosing the best Java architecture to building custom applications and Java microservices with our tested methodology, we develop dynamic, feature-rich & business-critical applications using J2EE.')
GO
INSERT [dbo].[Backend] ([ID], [Name], [Description]) VALUES (3, N'Python', N'We choose Python to deliver tailored business applications that require rapid development and further maintenance efforts related to scalability.')
GO
SET IDENTITY_INSERT [dbo].[Backend] OFF
GO
INSERT [dbo].[Employee] ([Emp_ID], [FirstName], [LastName], [Designation], [Competency], [Experience], [Salary]) VALUES (7, N'pinki', N'bhati', N'trainee', N'jvm', 0, 1500.0000)
GO
INSERT [dbo].[Employee] ([Emp_ID], [FirstName], [LastName], [Designation], [Competency], [Experience], [Salary]) VALUES (8, N'suraj', N'saini', N'trainee', N'scala', 0, 1000.0000)
GO
INSERT [dbo].[Employee] ([Emp_ID], [FirstName], [LastName], [Designation], [Competency], [Experience], [Salary]) VALUES (1001, N'azeem', N'faisal', N'Trainee', N'.Net', 0, 1000.0000)
GO
INSERT [dbo].[Employee] ([Emp_ID], [FirstName], [LastName], [Designation], [Competency], [Experience], [Salary]) VALUES (1002, N'arpit', N'deora', N'Trainee', N'.Net', 0, 1000.0000)
GO
INSERT [dbo].[Employee] ([Emp_ID], [FirstName], [LastName], [Designation], [Competency], [Experience], [Salary]) VALUES (1003, N'Vishesh', N'Kumar', N'Trainee', N'.Net', 0, 1000.0000)
GO
INSERT [dbo].[Employee] ([Emp_ID], [FirstName], [LastName], [Designation], [Competency], [Experience], [Salary]) VALUES (1004, N'vijay', N'kumar', N'Trainee', N'.Net', 0, 1000.0000)
GO
INSERT [dbo].[Employee] ([Emp_ID], [FirstName], [LastName], [Designation], [Competency], [Experience], [Salary]) VALUES (1005, N'himanshu', N'bhansali', N'Trainee', N'JVM', 0, 1000.0000)
GO
SET IDENTITY_INSERT [dbo].[Frontend] ON 
GO
INSERT [dbo].[Frontend] ([ID], [Name], [Description]) VALUES (1, N'AngularJS', N'We are experts in Angular development. AngularJS two-way data binding and other features make it a very powerful JavaScript Framework.')
GO
INSERT [dbo].[Frontend] ([ID], [Name], [Description]) VALUES (2, N'ReactJS', N'React.js development is widely adopted. Using React.js development, we split entire website or application into smaller reusable components allowing you to MVP fast.')
GO
INSERT [dbo].[Frontend] ([ID], [Name], [Description]) VALUES (3, N'Angular5.0', N'Angular 5.0 is a major part of Angular development and consulting.')
GO
SET IDENTITY_INSERT [dbo].[Frontend] OFF
GO
SET IDENTITY_INSERT [dbo].[Mobility] ON 
GO
INSERT [dbo].[Mobility] ([ID], [Name], [Description]) VALUES (1, N'iOS', N'Designing elegant, feature-rich, custom iOS applications comes with a lot of complexity and our innovative “Apple” lab can handle all of it easily. Our iOS app development services turn the vision of an iOS application into reality with easy to use, interactive and intuitive interface. ')
GO
INSERT [dbo].[Mobility] ([ID], [Name], [Description]) VALUES (2, N'Android', N'We are Android craftsmen aiming to develop applications that engage users, create compelling experiences and generate millions of active downloads. There are a plethora of devices with varied dimensions using Android and hence, it requires a deep understanding of the whole ecosystem and best practices to build a scalable Android application.')
GO
SET IDENTITY_INSERT [dbo].[Mobility] OFF
GO
SET IDENTITY_INSERT [dbo].[Testing] ON 
GO
INSERT [dbo].[Testing] ([ID], [Name], [Description]) VALUES (1, N'Manual', N'Apart from automated testing services, we have years of experience in manual testing products. We plan, create and execute various tests that are quintessential for optimal product performance. Our QA lab is well-equipped with various devices and we have detailed knowledge about various tools required for developing test scenarios related to functional, non-functional and load testing. ')
GO
INSERT [dbo].[Testing] ([ID], [Name], [Description]) VALUES (2, N'Automated', N'Automation is at the core of our testing ecosystem. Our automation testing services help you to sustain agile and DevOps modes of product engineering lifecycle easily. Our test automation workflows and automated testing services will not just help you to cut costs, but also accelerate time to market.')
GO
SET IDENTITY_INSERT [dbo].[Testing] OFF
GO
SET IDENTITY_INSERT [dbo].[UserDetails] ON 
GO
INSERT [dbo].[UserDetails] ([Id], [UserName], [Password]) VALUES (1, N'admin', N'admin')
GO
INSERT [dbo].[UserDetails] ([Id], [UserName], [Password]) VALUES (2, N'ashish', N'12345')
GO
SET IDENTITY_INSERT [dbo].[UserDetails] OFF
GO
USE [master]
GO
ALTER DATABASE [MVC] SET  READ_WRITE 
GO
