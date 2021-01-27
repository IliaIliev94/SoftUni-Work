-- Select all employees who are not from the marketing department
SELECT FirstName, LastName FROM Employees
	WHERE DepartmentID != 4