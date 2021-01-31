SELECT [Name] AS Game, 
CASE
	WHEN CAST(DATENAME(hour, [Start]) AS int) BETWEEN 0 AND 11 THEN 'Morning'
	WHEN CAST(DATENAME(hour, [Start]) AS int) BETWEEN 12 AND 17 THEN 'Afternoon'
	WHEN CAST(DATENAME(hour, [Start]) AS int) BETWEEN 18 AND 23 THEN 'Evening'
END AS [Part of the Day],
CASE
	WHEN Duration <= 3 THEN 'Extra Short'
	WHEN Duration BETWEEN 4 AND 6 THEN 'Short'
	WHEN Duration > 6 THEN 'Long'
	ELSE 'Extra Long'
END AS Duration
FROM Games
ORDER BY Game,Duration, [Part of the Day]