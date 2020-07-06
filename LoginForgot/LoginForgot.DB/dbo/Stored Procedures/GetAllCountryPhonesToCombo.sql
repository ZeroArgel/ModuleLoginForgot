CREATE PROCEDURE [dbo].[GetAllCountryPhonesToCombo]
AS
BEGIN
  SELECT 
    [Code] AS [Key],
    [Code] + ' - ' + [CountryName] AS [Value]
   FROM [CountryPhones]
   WHERE [Available] = '1';
END