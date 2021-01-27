/* Get the name, code and currency of all countries, if their currency is in euro the write 'Euro' else
	write 'Not euro' and lastly order them alphabetically by name */
SELECT CountryName, CountryCode,
	CASE
	WHEN CurrencyCode = 'EUR' THEN 'Euro'
	ELSE 'Not Euro'
	END AS Currency
	FROM Countries
	ORDER BY CountryName