SELECT ABS(
SUM(Difference)) AS SumDifference FROM
(SELECT t.FirstName AS HostName, 
t.DepositAmount AS HostDeposit, 
wd.FirstName, 
wd.DepositAmount, wd.DepositAmount - t.DepositAmount 
	AS Difference
FROM (SELECT * FROM WizzardDeposits
WHERE Id != 162
) t
INNER JOIN WizzardDeposits wd ON t.Id + 1 = wd.Id
) t2