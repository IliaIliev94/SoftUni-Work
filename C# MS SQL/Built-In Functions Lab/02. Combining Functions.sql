SELECT UPPER(SUBSTRING(Instructions, 1, 5)),
	SUBSTRING(Instructions, 6, LEN(Instructions) - 10),
	LOWER(SUBSTRING(Instructions, LEN(Instructions) - 4, 5)),
	Instructions
	FROM Recipes