CREATE PROCEDURE [dbo].[GetUserToLogin]
	@User VARCHAR(150), 
	@Password VARCHAR(70)
AS
BEGIN
  SELECT *
   FROM [Users]
   WHERE ([UserName] = @User OR [Email] = @User)
    AND [Password] = @Password
	AND [Available] = 1;
END