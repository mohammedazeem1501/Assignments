
create database [ADO_database]

USE [ADO_database]
GO
/****** Object:  Table [dbo].[customer]    Script Date: 3/3/2020 8:03:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customer](
	[CID] [int] NOT NULL,
	[Customer_name] [varchar](25) NULL,
	[Customer_Address] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[CID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[orders]    Script Date: 3/3/2020 8:03:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orders](
	[OID] [int] NOT NULL,
	[Quantity] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[OID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[product]    Script Date: 3/3/2020 8:03:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[product](
	[PID] [int] NOT NULL,
	[Price] [money] NULL,
	[Product_name] [varchar](25) NULL,
PRIMARY KEY CLUSTERED 
(
	[PID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[customer] ([CID], [Customer_name], [Customer_Address]) VALUES (1001, N'Azeem', N'Delhi')
GO
INSERT [dbo].[customer] ([CID], [Customer_name], [Customer_Address]) VALUES (1002, N'Vishesh', N'Gurugram')
GO
INSERT [dbo].[customer] ([CID], [Customer_name], [Customer_Address]) VALUES (1003, N'Arpit', N'Noida')
GO
INSERT [dbo].[customer] ([CID], [Customer_name], [Customer_Address]) VALUES (1004, N'Abhishek', N'Allahabad')
GO
INSERT [dbo].[customer] ([CID], [Customer_name], [Customer_Address]) VALUES (1005, N'Akash', N'Delhi')
GO
INSERT [dbo].[orders] ([OID], [Quantity]) VALUES (1, 5)
GO
INSERT [dbo].[orders] ([OID], [Quantity]) VALUES (2, 1)
GO
INSERT [dbo].[orders] ([OID], [Quantity]) VALUES (3, -3)
GO
INSERT [dbo].[orders] ([OID], [Quantity]) VALUES (4, 14)
GO
INSERT [dbo].[orders] ([OID], [Quantity]) VALUES (5, 3)
GO
INSERT [dbo].[orders] ([OID], [Quantity]) VALUES (6, 8)
GO
INSERT [dbo].[orders] ([OID], [Quantity]) VALUES (7, 10)
GO
INSERT [dbo].[orders] ([OID], [Quantity]) VALUES (8, 9)
GO
INSERT [dbo].[product] ([PID], [Price], [Product_name]) VALUES (101, 200.0000, N'Shampoo')
GO
INSERT [dbo].[product] ([PID], [Price], [Product_name]) VALUES (102, 600.0000, N'Shirt')
GO
INSERT [dbo].[product] ([PID], [Price], [Product_name]) VALUES (103, 900.0000, N'Jeans')
GO
INSERT [dbo].[product] ([PID], [Price], [Product_name]) VALUES (104, 2000.0000, N'Shoes')
GO
INSERT [dbo].[product] ([PID], [Price], [Product_name]) VALUES (105, 100.0000, N'Socks')
GO
/****** Object:  StoredProcedure [dbo].[get_Product]    Script Date: 3/3/2020 8:03:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[get_Product]
@name varchar(20)
as
begin
select * from product where Product_name like @name + '%'
end

GO
