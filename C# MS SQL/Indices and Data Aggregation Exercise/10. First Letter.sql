-- Get the records with deposit group of Troll Chest then get unique first letters from the result
SELECT DISTINCT LEFT(t.FirstName, 1) AS FirstLetter FROM(SELECT FirstName
FROM WizzardDeposits
WHERE DepositGroup = 'Troll Chest'
GROUP BY FirstName) t
ORDER BY FirstLetter