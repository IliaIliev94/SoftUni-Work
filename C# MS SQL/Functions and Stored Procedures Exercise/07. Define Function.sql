CREATE FUNCTION ufn_IsWordComprised(@SetOfLetters VARCHAR(MAX), @Word VARCHAR(MAX))
RETURNS BIT
AS
BEGIN
DECLARE @Counter INT = 1
WHILE(@Counter <= LEN(@Word))
	BEGIN
	IF CHARINDEX(SUBSTRING(@Word, @Counter, 1), @SetOfLetters) = 0
		RETURN 0
	SET @Counter += 1
	END
RETURN 1
END

SELECT dbo.ufn_IsWordComprised('pppp', 'Guy')