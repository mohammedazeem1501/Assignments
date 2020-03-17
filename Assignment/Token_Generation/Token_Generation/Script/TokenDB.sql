create database TokenDB

use TokenDB

CREATE TABLE [dbo].[LoginDetails](
	[UserName] [varchar](20) NOT NULL,
	[Password] [varchar](20) NULL,
	[Role] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[LoginDetails] ([UserName], [Password], [Role]) VALUES (N'Admin', N'pass', N'admin')
GO
INSERT [dbo].[LoginDetails] ([UserName], [Password], [Role]) VALUES (N'Azeem', N'pass', N'user')
GO
