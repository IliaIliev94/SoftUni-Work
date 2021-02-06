SELECT p.PeakName, r.RiverName, 
LOWER(p.PeakName + RIGHT(r.RiverName, LEN(r.RiverName) - 1))
	AS Mix
FROM Peaks p, Rivers r
WHERE RIGHT(p.PeakName, 1) = LEFT (r.RiverName, 1)
ORDER BY Mix