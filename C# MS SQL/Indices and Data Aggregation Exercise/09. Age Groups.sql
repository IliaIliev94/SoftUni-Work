/* Using a case statement insert an age range in each of the entries from the wizard deposits table
and after that group them by the age range column and get the count of people in each range group */
SELECT t.AgeGroup, COUNT(*) AS WizardCount FROM (
SELECT *,
CASE 
	WHEN Age >= 0 AND Age <= 10 THEN '[0-10]'
	WHEN Age >= 11 AND Age <= 20 THEN '[11-20]'
	WHEN Age >= 21 AND Age <= 30 THEN '[21-30]'
	WHEN Age >= 31 AND Age <= 40 THEN '[31-40]'
	WHEN Age >= 41 AND Age <= 50 THEN '[41-50]'
	WHEN Age >= 51 AND Age <= 60 THEN '[51-60]'
	ELSE '[61+]'
END AS AgeGroup
FROM WizzardDeposits
) t
GROUP BY t.AgeGroup