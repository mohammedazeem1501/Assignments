
create database LoginDB
use LoginDB
CREATE TABLE [dbo].[form_data](
	[username] [varchar](30) NOT NULL,
	[age] [int] NULL,
	[pass] [varchar](15) NULL,
	[email] [varchar](30) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[form_data] ([username], [age], [pass], [email]) VALUES (N'azeem', 24, N'azeem', N'a@gmail.com')
GO
INSERT [dbo].[form_data] ([username], [age], [pass], [email]) VALUES (N'pinki', 23, N'pinki', N'p@gmial.com')
GO
INSERT [dbo].[form_data] ([username], [age], [pass], [email]) VALUES (N'himanshu', 24, N'1234', N'h@gmial.com')
GO
INSERT [dbo].[form_data] ([username], [age], [pass], [email]) VALUES (N'azeem', 18, N'azeem', N'a@gmail.com')
GO
INSERT [dbo].[form_data] ([username], [age], [pass], [email]) VALUES (N'azeem', 20, N'azeem', N'a@gmail.com')
GO
/****** Object:  StoredProcedure [dbo].[Insert_User]    Script Date: 5/4/2020 7:45:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Insert_User 'Mudassar2', '12345', 'mudassar@aspsnippets.com'
CREATE PROCEDURE [dbo].[Insert_User]
	@Username NVARCHAR(20),
	@Password NVARCHAR(20),
	@Email NVARCHAR(30)
AS
BEGIN
	SET NOCOUNT ON;
	IF EXISTS(SELECT UserId FROM Users WHERE Username = @Username)
	BEGIN
		SELECT -1 -- Username exists.
	END
	ELSE IF EXISTS(SELECT UserId FROM Users WHERE Email = @Email)
	BEGIN
		SELECT -2 -- Email exists.
	END
	ELSE
	BEGIN
		INSERT INTO [Users]
			   ([Username]
			   ,[Password]
			   ,[Email]
			   ,[CreatedDate])
		VALUES
			   (@Username
			   ,@Password
			   ,@Email
			   ,GETDATE())
		
		SELECT SCOPE_IDENTITY() -- UserId			   
     END
END

GO

