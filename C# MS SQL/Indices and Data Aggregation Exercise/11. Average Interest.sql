/* Group by deposit group and whether the deposit has expired of all records with a start date later
than 01/01/1985 and get the average of every group. Finally order the result by deposit group descending
and is deposit expired.*/
SELECT DepositGroup, IsDepositExpired,
AVG (DepositInterest) 
	AS AverageInterest
FROM WizzardDeposits
WHERE DepositStartDate > '1985-01-01'
GROUP BY DepositGroup, IsDepositExpired
ORDER BY DepositGroup DESC, IsDepositExpired