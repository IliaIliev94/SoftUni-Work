SELECT e.EmployeeID, e.FirstName, 
m.EmployeeID AS ManagerID,
m.FirstName AS ManagerName
FROM Employees e
	JOIN Employees m ON e.ManagerID = m.EmployeeID
WHERE e.ManagerID IN (3, 7)
ORDER BY e.EmployeeID