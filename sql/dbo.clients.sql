CREATE TABLE [dbo].[clients]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [login_user] NVARCHAR(255) NOT NULL, 
    [password] NCHAR(255) NOT NULL, 
    [time] INT NULL DEFAULT 0, 
    [balance] INT NULL DEFAULT 0
)
