CREATE PROCEDURE [dbo].[GetAllCountryPhones]
AS
BEGIN
  SELECT *
   FROM [CountryPhones]
   WHERE [Available] = '1';
END