CREATE PROCEDURE [dbo].[GetCodeValid]
	@Code VARCHAR(50)
AS
BEGIN
  SELECT TOP (1) *
   FROM [CodeToUsers]
   WHERE [Code] = @Code 
	AND [Available] = '1'
	AND [LastUpdated] BETWEEN DATEADD(MINUTE, -15, GETDATE()) AND GETDATE()
   ORDER BY [LastUpdated] DESC
END