CREATE PROCEDURE [dbo].[GetUserByEmail]
	@Email VARCHAR(150)
AS
BEGIN
  SELECT * 
   FROM [Users]
   WHERE [Email] = @Email
    AND [Available] = '1';
END