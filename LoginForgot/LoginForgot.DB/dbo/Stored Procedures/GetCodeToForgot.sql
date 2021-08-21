CREATE PROCEDURE [dbo].[GetCodeToForgot]
	@Email VARCHAR(150)
AS
BEGIN
  -- Get code to return password.
  DECLARE @Code INT = (SELECT 1000000 - CAST(RAND()*999999 AS INT));
  DECLARE @UserId INT = (SELECT [UserId] FROM [Users] WHERE [Email] = @Email AND [Available] = '1');

  IF @UserID = NULL
  BEGIN
    RAISERROR (15600,-1,-1, 'Code to Forgot');  
  END
  INSERT INTO [CodeToUsers]([UserId], [Code])
   VALUES(@UserId, @Code);

  SELECT 
    @Code AS [Code],
    @Email AS [Email],
    [CellPhone]
    FROM [Users]
    WHERE [Email] = @Email
     AND [Available] = '1';
END