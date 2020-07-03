CREATE PROCEDURE [dbo].[AddUser]
	@UserName VARCHAR(50),
	@Email VARCHAR(150),
	@Password VARCHAR(70),
	@CellPhone VARCHAR(15)
AS
BEGIN
  IF (SELECT COUNT(*) FROM [Users] WHERE [UserName] = @UserName OR [Email] = @Email) = 0
  BEGIN
    INSERT INTO [Users]([UserName], [Email], [Password], [CellPhone])
	 VALUES(@UserName, @Email, @Password, @CellPhone);
  END
END