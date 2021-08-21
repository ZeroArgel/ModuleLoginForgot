﻿CREATE TABLE [dbo].[CodeToUsers]
(
	[Code] VARCHAR(50) NOT NULL PRIMARY KEY,
	[UserId] INT NOT NULL FOREIGN KEY REFERENCES [Users]([UserId]),
	[LastUpdated] DATETIME NOT NULL DEFAULT GETDATE(),
	[Available] BIT NOT NULL DEFAULT '1'
)