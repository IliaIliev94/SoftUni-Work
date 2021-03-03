CREATE PROCEDURE usp_GetTownsStartingWith @Start VARCHAR(MAX)
AS
SELECT [Name] FROM Towns AS Town
WHERE [Name] LIKE @Start + '%'
GO

usp_GetTownsStartingWith 'b'