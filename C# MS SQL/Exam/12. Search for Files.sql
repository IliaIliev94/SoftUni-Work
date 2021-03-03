CREATE OR ALTER PROCEDURE usp_SearchForFiles(@fileExtension VARCHAR(MAX))
AS
SELECT Id, [Name], CAST(Size AS VARCHAR) + 'KB' AS Size FROM Files WHERE [Name] LIKE '%' + @fileExtension
ORDER BY Id, [Name], Size DESC
GO

EXEC usp_SearchForFiles 'txt'