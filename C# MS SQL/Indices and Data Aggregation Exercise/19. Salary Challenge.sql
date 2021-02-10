SELECT TOP(10) e.FirstName, e.LastName, e.DepartmentID FROM Employees e
WHERE Salary > (SELECT AVG(Salary) FROM Employees WHERE DepartmentID = e.DepartmentID)
ORDER BY E.departmentID