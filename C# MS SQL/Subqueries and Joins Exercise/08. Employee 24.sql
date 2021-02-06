SELECT e.EmployeeID, e.FirstName, 
	p.[Name] AS ProjectName
FROM Employees e
	JOIN EmployeesProjects ep ON ep.EmployeeID = e.EmployeeID
	LEFT JOIN Projects p ON p.ProjectID = ep.ProjectID AND p.StartDate < '2005-01-01'
WHERE e.EmployeeID = 24