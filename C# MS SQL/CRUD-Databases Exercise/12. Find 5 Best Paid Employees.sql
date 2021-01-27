-- Get 5 Top Paid Employees
SELECT TOP(5) FirstName, LastName FROM Employees
	ORDER BY Salary DESC