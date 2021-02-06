SELECT TOP(5) hp.Country, hp.[Highest Peak Name],hp.[Highest Peak Elevation], 
hp.Mountain 
FROM 
(SELECT c.CountryName AS Country, 
ISNULL(p.PeakName, '(no highest peak)')
	AS [Highest Peak Name], 
ISNULL(p.Elevation, 0)
	AS [Highest Peak Elevation], 
ISNULL(m.MountainRange, '(no mountain)')
	AS Mountain,
DENSE_RANK() OVER (PARTITION BY c.CountryName ORDER BY p.Elevation DESC)
	AS Rank
FROM Countries c
	LEFT JOIN MountainsCountries mc ON c.CountryCode = mc.CountryCode
	LEFT JOIN Mountains m ON m.Id = mc.MountainId
	LEFT JOIN Peaks p ON p.MountainId = m.Id
GROUP BY c.CountryName, p.PeakName, p.Elevation, m.MountainRange
) hp
WHERE hp.Rank = 1
ORDER BY hp.Country, hp.[Highest Peak Name]