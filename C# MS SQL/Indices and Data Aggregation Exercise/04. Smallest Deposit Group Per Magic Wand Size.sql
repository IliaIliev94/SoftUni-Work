/* Group by deposit groups then order them by the average magic wand size ascending and 
get the first two rows */
SELECT TOP(2) DepositGroup
FROM WizzardDeposits
GROUP BY DepositGroup
ORDER BY AVG(MagicWandSize)