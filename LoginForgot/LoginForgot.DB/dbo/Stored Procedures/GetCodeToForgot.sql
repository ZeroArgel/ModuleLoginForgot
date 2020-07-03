CREATE PROCEDURE [dbo].[GetCodeToForgot]
	@Email VARCHAR(150)
AS
BEGIN
  -- Get code to return password.
  DECLARE @Code INT = (SELECT 1000000 - CAST(RAND()*999999 AS INT));
  DECLARE @UserID INT = (SELECT [UserID] FROM [Users] WHERE [Email] = @Email);

  INSERT INTO [CodeToUsers]([UserID], [Code])
   VALUES(@UserID, @Code);

  SELECT @Code AS [Code];
END