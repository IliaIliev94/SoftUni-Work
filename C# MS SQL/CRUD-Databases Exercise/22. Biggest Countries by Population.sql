-- Select top 30 countries from Europe with the most population
SELECT TOP(30) CountryName, [Population] 
	FROM Countries
	WHERE ContinentCode = 'EU'
	ORDER BY [Population] DESC