/* Get all records where the magic wand creator is 'Ollivander family' then group by deposit group
and get the total sum of the deposit amount for each group having a sum less than 150000. Finally group
the result by total sum of the deposit amount descending*/
SELECT DepositGroup,
SUM (DepositAmount) AS TotalSum
FROM WizzardDeposits
WHERE MagicWandCreator = 'Ollivander family'
GROUP BY DepositGroup
HAVING SUM(DepositAmount) < 150000
ORDER BY TotalSum DESC