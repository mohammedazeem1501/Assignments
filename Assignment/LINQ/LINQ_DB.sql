create database Exercise 

CREATE TABLE [dbo].[Student_Details](
	[Student_ID] [int] NOT NULL,
	[ Student_Name] [varchar](30) NULL,
	[Student_Add] [varchar](50) NULL,
	[Grade] [varchar](1) NULL,
	[Date_Of_Addmission] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[Student_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[sample_view]    Script Date: 3/10/2020 11:47:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[sample_view] as
select Student_ID from Student_Details
GO
/****** Object:  UserDefinedFunction [dbo].[MyFunction]    Script Date: 3/10/2020 11:47:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[MyFunction] (@ID int) 
returns table
as

return 
(select Student_ID, Grade from Student_Details
where Student_ID = @ID)
GO
/****** Object:  UserDefinedFunction [dbo].[MyFunc]    Script Date: 3/10/2020 11:47:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[MyFunc] (@ID int) 
returns table
as
return 
(select Student_ID, Grade from Student_Details where Student_ID = @ID)
GO
/****** Object:  Table [dbo].[Emp]    Script Date: 3/10/2020 11:47:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Emp](
	[ID] [int] IDENTITY(100,1) NOT NULL,
	[Salary] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sal]    Script Date: 3/10/2020 11:47:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sal](
	[ID] [int] NULL,
	[Salary] [money] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Salary_Details]    Script Date: 3/10/2020 11:47:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Salary_Details](
	[Employee_ID] [int] NULL,
	[Month] [varchar](15) NULL,
	[Salary] [money] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Stu_Details]    Script Date: 3/10/2020 11:47:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stu_Details](
	[Student_ID] [int] NOT NULL,
	[ Student_Name] [varchar](30) NULL,
	[Student_Add] [varchar](50) NULL,
	[Grade] [varchar](1) NULL,
	[Date_Of_Addmission] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_Employees]    Script Date: 3/10/2020 11:47:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_Employees](
	[Employee_ID] [int] IDENTITY(1000,1) NOT NULL,
	[Employee_Name] [varchar](50) NOT NULL,
	[DOB] [date] NULL,
	[Contact_Number] [varchar](10) NOT NULL,
	[Salary] [money] NULL,
	[Address] [varchar](80) NULL,
	[ZIP_Code] [varchar](6) NOT NULL,
	[Create_Date] [datetime2](7) NULL,
	[Modify_Date] [datetime2](7) NULL,
	[IsActive] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Employee_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Emp] ON 
GO
INSERT [dbo].[Emp] ([ID], [Salary]) VALUES (100, 3000.0000)
GO
INSERT [dbo].[Emp] ([ID], [Salary]) VALUES (101, 3000.0000)
GO
INSERT [dbo].[Emp] ([ID], [Salary]) VALUES (102, 3000.0000)
GO
INSERT [dbo].[Emp] ([ID], [Salary]) VALUES (103, NULL)
GO
SET IDENTITY_INSERT [dbo].[Emp] OFF
GO
INSERT [dbo].[sal] ([ID], [Salary]) VALUES (100, 1000.0000)
GO
INSERT [dbo].[sal] ([ID], [Salary]) VALUES (100, 1000.0000)
GO
INSERT [dbo].[sal] ([ID], [Salary]) VALUES (100, 1000.0000)
GO
INSERT [dbo].[sal] ([ID], [Salary]) VALUES (101, 1000.0000)
GO
INSERT [dbo].[sal] ([ID], [Salary]) VALUES (101, 1000.0000)
GO
INSERT [dbo].[sal] ([ID], [Salary]) VALUES (101, 1000.0000)
GO
INSERT [dbo].[sal] ([ID], [Salary]) VALUES (102, 1000.0000)
GO
INSERT [dbo].[sal] ([ID], [Salary]) VALUES (102, 1000.0000)
GO
INSERT [dbo].[sal] ([ID], [Salary]) VALUES (102, 1000.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1001, N'February', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1001, N'March', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1001, N'April', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1001, N'May', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1001, N'June', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1001, N'July', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1001, N'August', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1002, N'February', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1002, N'March', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1002, N'April', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1002, N'May', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1002, N'June', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1002, N'July', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1002, N'August', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1003, N'February', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1003, N'March', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1003, N'April', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1003, N'May', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1003, N'June', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1003, N'July', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1003, N'August', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1004, N'February', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1004, N'March', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1004, N'April', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1004, N'May', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1004, N'June', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1004, N'July', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1004, N'August', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1005, N'February', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1005, N'March', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1005, N'April', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1005, N'May', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1005, N'June', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1005, N'July', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1005, N'August', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1006, N'February', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1006, N'March', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1006, N'April', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1006, N'May', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1006, N'June', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1006, N'July', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1006, N'August', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1007, N'February', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1007, N'March', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1007, N'April', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1007, N'May', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1007, N'June', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1007, N'July', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1007, N'August', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1008, N'February', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1008, N'March', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1008, N'April', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1008, N'May', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1008, N'June', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1008, N'July', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1008, N'August', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1009, N'February', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1009, N'March', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1009, N'April', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1009, N'May', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1009, N'June', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1009, N'July', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1009, N'August', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1010, N'February', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1010, N'March', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1010, N'April', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1010, N'May', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1010, N'June', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1010, N'July', 15100.0000)
GO
INSERT [dbo].[Salary_Details] ([Employee_ID], [Month], [Salary]) VALUES (1010, N'August', 15100.0000)
GO
INSERT [dbo].[Stu_Details] ([Student_ID], [ Student_Name], [Student_Add], [Grade], [Date_Of_Addmission]) VALUES (101, N'Azeem', N'Delhi', N'B', CAST(N'2019-07-07' AS Date))
GO
INSERT [dbo].[Stu_Details] ([Student_ID], [ Student_Name], [Student_Add], [Grade], [Date_Of_Addmission]) VALUES (102, N'Arpit', N'Delhi', N'A', CAST(N'2020-07-05' AS Date))
GO
INSERT [dbo].[Stu_Details] ([Student_ID], [ Student_Name], [Student_Add], [Grade], [Date_Of_Addmission]) VALUES (103, N'Ashish', N'Delhi', N'B', CAST(N'2018-07-03' AS Date))
GO
INSERT [dbo].[Stu_Details] ([Student_ID], [ Student_Name], [Student_Add], [Grade], [Date_Of_Addmission]) VALUES (104, N'Abhishek', N'Delhi', N'A', CAST(N'2021-07-07' AS Date))
GO
INSERT [dbo].[Stu_Details] ([Student_ID], [ Student_Name], [Student_Add], [Grade], [Date_Of_Addmission]) VALUES (105, N'Viay', N'Delhi', N'A', CAST(N'2020-01-15' AS Date))
GO
INSERT [dbo].[Student_Details] ([Student_ID], [ Student_Name], [Student_Add], [Grade], [Date_Of_Addmission]) VALUES (101, N'Azeem', N'Delhi', N'B', CAST(N'2019-07-07' AS Date))
GO
INSERT [dbo].[Student_Details] ([Student_ID], [ Student_Name], [Student_Add], [Grade], [Date_Of_Addmission]) VALUES (102, N'Arpit', N'Delhi', N'C', CAST(N'2020-07-05' AS Date))
GO
INSERT [dbo].[Student_Details] ([Student_ID], [ Student_Name], [Student_Add], [Grade], [Date_Of_Addmission]) VALUES (103, N'Ashish', N'Delhi', N'A', CAST(N'2018-07-03' AS Date))
GO
INSERT [dbo].[Student_Details] ([Student_ID], [ Student_Name], [Student_Add], [Grade], [Date_Of_Addmission]) VALUES (104, N'Abhishek', N'Delhi', N'A', CAST(N'2021-07-07' AS Date))
GO
INSERT [dbo].[Student_Details] ([Student_ID], [ Student_Name], [Student_Add], [Grade], [Date_Of_Addmission]) VALUES (105, N'Viay', N'Delhi', N'A', CAST(N'2020-01-15' AS Date))
GO
INSERT [dbo].[Student_Details] ([Student_ID], [ Student_Name], [Student_Add], [Grade], [Date_Of_Addmission]) VALUES (106, N'Vinay', N'Delhi', N'B', CAST(N'2020-05-15' AS Date))
GO
SET IDENTITY_INSERT [dbo].[TBL_Employees] ON 
GO
INSERT [dbo].[TBL_Employees] ([Employee_ID], [Employee_Name], [DOB], [Contact_Number], [Salary], [Address], [ZIP_Code], [Create_Date], [Modify_Date], [IsActive]) VALUES (1001, N'Azeem', CAST(N'1996-01-15' AS Date), N'9560244072', 105700.0000, N'Yamuna Vihar, Delhi', N'110094', CAST(N'2020-02-26T20:58:56.2100000' AS DateTime2), NULL, 1)
GO
INSERT [dbo].[TBL_Employees] ([Employee_ID], [Employee_Name], [DOB], [Contact_Number], [Salary], [Address], [ZIP_Code], [Create_Date], [Modify_Date], [IsActive]) VALUES (1002, N'Arpit', CAST(N'1996-01-15' AS Date), N'9888888888', 105700.0000, N'Gaur City, Noida', N'200008', CAST(N'2020-02-26T21:35:41.1000000' AS DateTime2), NULL, 1)
GO
INSERT [dbo].[TBL_Employees] ([Employee_ID], [Employee_Name], [DOB], [Contact_Number], [Salary], [Address], [ZIP_Code], [Create_Date], [Modify_Date], [IsActive]) VALUES (1003, N'Abhishek', CAST(N'1996-01-15' AS Date), N'9888888888', 105700.0000, N'Sector 62, Noida', N'201301', CAST(N'2020-02-26T21:35:41.1100000' AS DateTime2), NULL, 1)
GO
INSERT [dbo].[TBL_Employees] ([Employee_ID], [Employee_Name], [DOB], [Contact_Number], [Salary], [Address], [ZIP_Code], [Create_Date], [Modify_Date], [IsActive]) VALUES (1004, N'Vishesh', CAST(N'1996-01-15' AS Date), N'9888888888', 105700.0000, N'Dilshad garden, Delhi', N'201301', CAST(N'2020-02-26T21:35:41.1100000' AS DateTime2), NULL, 1)
GO
INSERT [dbo].[TBL_Employees] ([Employee_ID], [Employee_Name], [DOB], [Contact_Number], [Salary], [Address], [ZIP_Code], [Create_Date], [Modify_Date], [IsActive]) VALUES (1005, N'Vijay', CAST(N'1996-01-15' AS Date), N'9888888888', 105700.0000, N'Akshardham, Delhi', N'201301', CAST(N'2020-02-26T21:35:41.1100000' AS DateTime2), NULL, 1)
GO
INSERT [dbo].[TBL_Employees] ([Employee_ID], [Employee_Name], [DOB], [Contact_Number], [Salary], [Address], [ZIP_Code], [Create_Date], [Modify_Date], [IsActive]) VALUES (1006, N'Neha', CAST(N'1996-01-15' AS Date), N'9888888888', 105700.0000, N'Akshardham, Delhi', N'201301', CAST(N'2020-02-26T21:35:41.1100000' AS DateTime2), NULL, 1)
GO
INSERT [dbo].[TBL_Employees] ([Employee_ID], [Employee_Name], [DOB], [Contact_Number], [Salary], [Address], [ZIP_Code], [Create_Date], [Modify_Date], [IsActive]) VALUES (1007, N'Sonal', CAST(N'1996-01-15' AS Date), N'9888888888', 105700.0000, N'Botanical Garden, Delhi', N'201301', CAST(N'2020-02-26T21:35:41.1100000' AS DateTime2), NULL, 1)
GO
INSERT [dbo].[TBL_Employees] ([Employee_ID], [Employee_Name], [DOB], [Contact_Number], [Salary], [Address], [ZIP_Code], [Create_Date], [Modify_Date], [IsActive]) VALUES (1008, N'Latika', CAST(N'1996-01-15' AS Date), N'9888888888', 105700.0000, N'Janakpuri, Delhi', N'201301', CAST(N'2020-02-26T21:35:41.1100000' AS DateTime2), NULL, 1)
GO
INSERT [dbo].[TBL_Employees] ([Employee_ID], [Employee_Name], [DOB], [Contact_Number], [Salary], [Address], [ZIP_Code], [Create_Date], [Modify_Date], [IsActive]) VALUES (1009, N'Shagun', CAST(N'1996-01-15' AS Date), N'9888888888', 105700.0000, N'Badarpur, Delhi', N'201301', CAST(N'2020-02-26T21:35:41.1100000' AS DateTime2), NULL, 1)
GO
INSERT [dbo].[TBL_Employees] ([Employee_ID], [Employee_Name], [DOB], [Contact_Number], [Salary], [Address], [ZIP_Code], [Create_Date], [Modify_Date], [IsActive]) VALUES (1010, N'Punita', CAST(N'1996-01-15' AS Date), N'9888888888', 105700.0000, N'Faridabad, Delhi', N'201301', CAST(N'2020-02-26T21:35:41.1100000' AS DateTime2), NULL, 1)
GO
SET IDENTITY_INSERT [dbo].[TBL_Employees] OFF
GO
ALTER TABLE [dbo].[TBL_Employees] ADD  DEFAULT (getdate()) FOR [Create_Date]
GO
ALTER TABLE [dbo].[TBL_Employees] ADD  DEFAULT ((0)) FOR [IsActive]
GO
ALTER TABLE [dbo].[sal]  WITH CHECK ADD FOREIGN KEY([ID])
REFERENCES [dbo].[Emp] ([ID])
GO
ALTER TABLE [dbo].[Salary_Details]  WITH CHECK ADD FOREIGN KEY([Employee_ID])
REFERENCES [dbo].[TBL_Employees] ([Employee_ID])
GO
ALTER TABLE [dbo].[TBL_Employees]  WITH CHECK ADD  CONSTRAINT [verify] CHECK  (([Contact_Number] like '[6-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'))
GO
ALTER TABLE [dbo].[TBL_Employees] CHECK CONSTRAINT [verify]
GO
ALTER TABLE [dbo].[TBL_Employees]  WITH CHECK ADD  CONSTRAINT [verifyZIP] CHECK  (([ZIP_Code] like '[0-9][0-9][0-9][0-9][0-9][0-9]'))
GO
ALTER TABLE [dbo].[TBL_Employees] CHECK CONSTRAINT [verifyZIP]
GO
/****** Object:  StoredProcedure [dbo].[Invoked_Procedure]    Script Date: 3/10/2020 11:47:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Invoked_Procedure]
as
begin 
update Student_Details 
set Grade = 'C'
where Student_ID = '102'
end
GO
/****** Object:  StoredProcedure [dbo].[My_proc]    Script Date: 3/10/2020 11:47:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[My_proc]
as
begin 
update Student_Details 
set Grade = 'A'
where Student_ID = '103'
end
GO
/****** Object:  StoredProcedure [dbo].[My_Procedure]    Script Date: 3/10/2020 11:47:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[My_Procedure]
as
begin 
exec Invoked_Procedure
end

