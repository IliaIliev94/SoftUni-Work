SELECT e.EmployeeID, e.FirstName, p.Name
FROM Employees e
	LEFT JOIN EmployeesProjects ep ON e.EmployeeID = ep.EmployeeID
	JOIN Projects p ON ep.ProjectID = p.ProjectID
