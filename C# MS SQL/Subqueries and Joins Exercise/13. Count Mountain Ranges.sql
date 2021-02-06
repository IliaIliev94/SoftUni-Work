SELECT c.CountryCode, COUNT(*) AS  MountainRanges
FROM Countries c
	INNER JOIN MountainsCountries mc ON c.CountryCode = mc.CountryCode
	INNER JOIN Mountains m ON m.Id = mc.MountainId
WHERE c.CountryCode IN ('BG', 'RU', 'US')
GROUP BY c.CountryCode
