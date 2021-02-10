/* Group by deposit group and magic wand creater then get the minimal deposit charge value for each group
 and finally order the results by magic wand creater and deposit group ascending.*/
SELECT DepositGroup, MagicWandCreator,
MIN(DepositCharge) AS MinDepositCharge
FROM WizzardDeposits
GROUP BY DepositGroup, MagicWandCreator
ORDER BY MagicWandCreator, DepositGroup