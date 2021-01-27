-- Select the last 7 hired employees
SELECT TOP(7) FirstName, LastName, HireDate
	FROM Employees
	ORDER BY HireDate DESC