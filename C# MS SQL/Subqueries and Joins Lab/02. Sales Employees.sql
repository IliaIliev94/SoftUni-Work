SELECT EmployeeID, FirstName, 
LastName, [Name] 
	AS DepartmentName
FROM Employees e
	JOIN Departments d on e.DepartmentID = d.DepartmentID
	WHERE d.[Name] = 'Sales'
ORDER BY e.EmployeeID