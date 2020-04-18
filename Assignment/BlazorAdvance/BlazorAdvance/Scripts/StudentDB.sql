create database StudentDB
use StudentDB
CREATE TABLE [dbo].[Sidebar](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[LinkName] [varchar](15) NULL,
	[LinkAddress] [varchar](40) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 4/18/2020 5:14:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Firstname] [varchar](20) NULL,
	[Lastname] [varchar](20) NULL,
	[Age] [int] NULL,
	[Address] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserDetails]    Script Date: 4/18/2020 5:14:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserDetails](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](10) NULL,
	[Password] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Sidebar] ON 
GO
INSERT [dbo].[Sidebar] ([ID], [LinkName], [LinkAddress]) VALUES (1, N'Counter', N'counter')
GO
INSERT [dbo].[Sidebar] ([ID], [LinkName], [LinkAddress]) VALUES (2, N'Fetch Data', N'fetchdata')
GO
INSERT [dbo].[Sidebar] ([ID], [LinkName], [LinkAddress]) VALUES (3, N'Student', N'Student')
GO
INSERT [dbo].[Sidebar] ([ID], [LinkName], [LinkAddress]) VALUES (5, N'One', N'one')
GO
INSERT [dbo].[Sidebar] ([ID], [LinkName], [LinkAddress]) VALUES (6, N'Two', N'two')
GO
INSERT [dbo].[Sidebar] ([ID], [LinkName], [LinkAddress]) VALUES (7, N'Three', N'three')
GO
INSERT [dbo].[Sidebar] ([ID], [LinkName], [LinkAddress]) VALUES (8, N'Four', N'four')
GO
INSERT [dbo].[Sidebar] ([ID], [LinkName], [LinkAddress]) VALUES (9, N'Calculator', N'Calculator')
GO
SET IDENTITY_INSERT [dbo].[Sidebar] OFF
GO
SET IDENTITY_INSERT [dbo].[Student] ON 
GO
INSERT [dbo].[Student] ([ID], [Firstname], [Lastname], [Age], [Address]) VALUES (1, N'vijay', N'kumar', 25, N'akshardham')
GO
SET IDENTITY_INSERT [dbo].[Student] OFF
GO
SET IDENTITY_INSERT [dbo].[UserDetails] ON 
GO
INSERT [dbo].[UserDetails] ([ID], [Username], [Password]) VALUES (1, N'admin', N'admin')
GO
SET IDENTITY_INSERT [dbo].[UserDetails] OFF
GO

