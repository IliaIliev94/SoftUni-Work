SELECT d.[Name], 
SUM(e.Salary) AS TotalSalary 
FROM Employees e
INNER JOIN Departments d ON e.DepartmentID = d.DepartmentID
GROUP BY d.[Name]
HAVING SUM(e.Salary) >= 15000