SELECT t.ContinentCode, t.CurrencyCode, t.CurrencyUsage FROM (SELECT cn.ContinentCode, c.CurrencyCode, 
DENSE_RANK() OVER (PARTITION BY cn.ContinentCode ORDER BY COUNT(*) DESC) AS Rank,
COUNT(*) AS CurrencyUsage
FROM Continents cn
	INNER JOIN Countries c ON cn.ContinentCode = c.ContinentCode
GROUP BY cn.ContinentCode, c.CurrencyCode
HAVING COUNT(*) > 1
) t
WHERE t.Rank = 1