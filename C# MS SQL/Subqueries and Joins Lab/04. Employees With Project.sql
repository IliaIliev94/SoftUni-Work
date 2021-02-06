SELECT TOP(50) e.EmployeeID, 
e.FirstName + ' ' + e.LastName 
	AS EmployeeName,
e2.FirstName + ' ' + e2.LastName
	AS ManagerName,
[Name] AS DepartmentName
FROM Employees e
	LEFT JOIN Employees e2 ON e.ManagerID = e2.EmployeeID
	LEFT JOIN Departments d on E.DepartmentID = d.DepartmentID
ORDER BY e.EmployeeID