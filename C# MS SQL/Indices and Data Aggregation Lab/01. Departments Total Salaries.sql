SELECT e.DepartmentID, 
(SELECT [Name] FROM Departments WHERE DepartmentID = e.DepartmentID) AS DepartmentName,
SUM(e.Salary) AS TotalSalary FROM Employees e
GROUP BY e.DepartmentId
ORDER BY TotalSalary DESC