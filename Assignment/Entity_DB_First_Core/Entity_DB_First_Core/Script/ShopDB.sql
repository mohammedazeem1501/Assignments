create database ShopDB
use ShopDB
CREATE TABLE [dbo].[Customer](
	[ID] [int] NOT NULL,
	[Customer_Name] [varchar](25) NULL,
	[Address] [varchar](30) NULL,
	[Contact] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 3/18/2020 7:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[ID] [int] NOT NULL,
	[Date_Ordered] [datetime] NULL,
	[Amount] [money] NULL,
	[Customer_ID] [int] NULL,
	[Product_ID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 3/18/2020 7:24:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ID] [int] NOT NULL,
	[Product_Name] [varchar](20) NULL,
	[Unit_Price] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Customer] ([ID], [Customer_Name], [Address], [Contact]) VALUES (101, N'Azeem', N'Yamuna Vihar,Delhi', N'9876543210')
GO
INSERT [dbo].[Customer] ([ID], [Customer_Name], [Address], [Contact]) VALUES (102, N'Arpit', N'Gaur City,Noida', N'9876543210')
GO
INSERT [dbo].[Customer] ([ID], [Customer_Name], [Address], [Contact]) VALUES (103, N'Latika', N'Janakpuri,Delhi', N'9876543210')
GO
INSERT [dbo].[Customer] ([ID], [Customer_Name], [Address], [Contact]) VALUES (104, N'Vishesh', N'Shalimar Bagh,Delhi', N'9876543210')
GO
INSERT [dbo].[Customer] ([ID], [Customer_Name], [Address], [Contact]) VALUES (105, N'Shagun', N'Faridabad,Delhi', N'9876543210')
GO
INSERT [dbo].[Customer] ([ID], [Customer_Name], [Address], [Contact]) VALUES (106, N'Rahul', N'Akshardham', N'9876543210')
GO
INSERT [dbo].[Orders] ([ID], [Date_Ordered], [Amount], [Customer_ID], [Product_ID]) VALUES (1, CAST(N'2020-03-12T00:00:00.000' AS DateTime), 9000.0000, 101, 1009)
GO
INSERT [dbo].[Orders] ([ID], [Date_Ordered], [Amount], [Customer_ID], [Product_ID]) VALUES (2, CAST(N'2020-03-12T00:00:00.000' AS DateTime), 1000.0000, 101, 1008)
GO
INSERT [dbo].[Orders] ([ID], [Date_Ordered], [Amount], [Customer_ID], [Product_ID]) VALUES (3, CAST(N'2020-03-12T00:00:00.000' AS DateTime), 2400.0000, 103, 1001)
GO
INSERT [dbo].[Orders] ([ID], [Date_Ordered], [Amount], [Customer_ID], [Product_ID]) VALUES (4, CAST(N'2020-03-12T00:00:00.000' AS DateTime), 3600.0000, 102, 1003)
GO
INSERT [dbo].[Orders] ([ID], [Date_Ordered], [Amount], [Customer_ID], [Product_ID]) VALUES (5, CAST(N'2020-03-12T00:00:00.000' AS DateTime), 2300.0000, 105, 1002)
GO
INSERT [dbo].[Orders] ([ID], [Date_Ordered], [Amount], [Customer_ID], [Product_ID]) VALUES (6, CAST(N'2020-04-12T00:00:00.000' AS DateTime), 6000.0000, NULL, NULL)
GO
INSERT [dbo].[Product] ([ID], [Product_Name], [Unit_Price]) VALUES (1001, N'Shirt', 1200.0000)
GO
INSERT [dbo].[Product] ([ID], [Product_Name], [Unit_Price]) VALUES (1002, N'Jeans', 2300.0000)
GO
INSERT [dbo].[Product] ([ID], [Product_Name], [Unit_Price]) VALUES (1003, N'Chinos', 1800.0000)
GO
INSERT [dbo].[Product] ([ID], [Product_Name], [Unit_Price]) VALUES (1004, N'Polo T-Shirts', 900.0000)
GO
INSERT [dbo].[Product] ([ID], [Product_Name], [Unit_Price]) VALUES (1005, N'Round Neck T-Shirt', 400.0000)
GO
INSERT [dbo].[Product] ([ID], [Product_Name], [Unit_Price]) VALUES (1006, N'Watch', 3200.0000)
GO
INSERT [dbo].[Product] ([ID], [Product_Name], [Unit_Price]) VALUES (1007, N'Suit', 12000.0000)
GO
INSERT [dbo].[Product] ([ID], [Product_Name], [Unit_Price]) VALUES (1008, N'Tie', 1000.0000)
GO
INSERT [dbo].[Product] ([ID], [Product_Name], [Unit_Price]) VALUES (1009, N'Shoes', 3000.0000)
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([Customer_ID])
REFERENCES [dbo].[Customer] ([ID])
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([Product_ID])
REFERENCES [dbo].[Product] ([ID])
GO
