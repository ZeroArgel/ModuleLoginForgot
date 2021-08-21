CREATE PROCEDURE [dbo].[GetUserToLogin]
	@UserName VARCHAR(150), 
	@Password VARCHAR(70)
AS
BEGIN
  SELECT *
   FROM [Users]
   WHERE ([UserName] = @UserName OR [Email] = @UserName)
    AND [Password] = @Password
	AND [Available] = 1;
END