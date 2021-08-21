CREATE PROCEDURE [dbo].[UpdPassword]
	@UserId INT, 
	@Password VARCHAR(70)
AS
BEGIN
  UPDATE [Users]
   SET [Password] = @Password,
       [LastUpdated] = GETDATE()
   WHERE [UserID] = @UserId;
END