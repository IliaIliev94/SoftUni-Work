SELECT c.CountryCode, m.MountainRange,
p.PeakName, p.Elevation
FROM Countries c
	INNER JOIN MountainsCountries mc ON c.CountryCode = mc.CountryCode
	RIGHT JOIN Mountains m ON mc.MountainId = m.Id
	INNER JOIN Peaks p ON m.Id = p.MountainID
WHERE c.CountryCode = 'BG' AND p.Elevation > 2835
ORDER BY Elevation DESC