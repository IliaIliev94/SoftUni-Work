SELECT SUM(t.SumDifference) AS SumDifference FROM 
(
	SELECT TOP((SELECT COUNT(*) - 1 FROM WizzardDeposits)) 
	Id, 
	DepositAmount - (SELECT DepositAmount FROM WizzardDeposits WHERE Id = wd.Id + 1) 
		AS SumDifference
	FROM WizzardDeposits wd
) t