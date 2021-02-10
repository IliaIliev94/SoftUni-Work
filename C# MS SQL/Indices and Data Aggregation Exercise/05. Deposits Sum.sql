-- Group by deposit groups then sum the deposit amount for each group
SELECT DepositGroup,
SUM(DepositAmount) AS TotalSum
FROM WizzardDeposits
GROUP BY DepositGroup