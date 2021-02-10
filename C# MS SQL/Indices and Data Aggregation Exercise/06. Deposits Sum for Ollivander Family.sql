/* Get all records where the magic wand creater is 'Ollivander family' and then group by deposit groups
and get the sum of the deposit amount for each group */
SELECT DepositGroup,
SUM(DepositAmount) AS TotalSum
FROM WizzardDeposits
WHERE MagicWandCreator = 'Ollivander family'
GROUP BY DepositGroup