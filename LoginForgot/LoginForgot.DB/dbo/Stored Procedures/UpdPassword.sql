CREATE PROCEDURE [dbo].[UpdPassword]
	@UserID INT, 
	@Password VARCHAR(70)
AS
BEGIN
  UPDATE [Users]
   SET [Password] = @Password,
       [LastUpdated] = GETDATE()
   WHERE [UserID] = @UserID;
END