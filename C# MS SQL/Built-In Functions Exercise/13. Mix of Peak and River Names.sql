SELECT pk.PeakName, rv.RiverName, 
	LOWER(CONCAT (pk.PeakName, RIGHT(rv.RiverName, LEN(rv.RiverName) - 1))) AS mix  
	FROM Peaks as pk
	INNER JOIN Rivers AS rv ON  RIGHT(pk.PeakName, 1) = LEFT(rv.RiverName, 1)
	ORDER BY mix