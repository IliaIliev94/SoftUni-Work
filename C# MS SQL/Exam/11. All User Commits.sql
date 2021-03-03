CREATE OR ALTER FUNCTION udf_AllUserCommits(@username VARCHAR(MAX))
RETURNS INT
AS
BEGIN
DECLARE @Commits INT = (SELECT COUNT(*) FROM Commits WHERE ContributorId = (SELECT TOP(1) Id FROM Users WHERE Username = @username))
RETURN @Commits
END

SELECT dbo.udf_AllUserCommits('UnderSinduxrein')