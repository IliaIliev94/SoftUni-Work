SELECT d.DepartmentID, d.Salary FROM
(
SELECT DepartmentID, 
Salary,
ROW_NUMBER() OVER (PARTITION BY DepartmentID ORDER BY Salary DESC) 
	AS Rank
FROM Employees
GROUP BY DepartmentID, Salary
) d
WHERE d.Rank = 3
