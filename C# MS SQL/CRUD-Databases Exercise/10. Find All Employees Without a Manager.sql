-- Find the first name and last name of all employees without a manager
SELECT FirstName, LastName FROM Employees 
	WHERE ManagerID IS NULL