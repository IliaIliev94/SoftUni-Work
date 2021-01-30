SELECT EmployeeID, CONCAT_WS(' ', FirstName, MiddleName, LastName) AS [Name], HireDate,
	DATEPART (QUARTER, HireDate) as Quarter,
	DATEPART (MONTH, HireDate) AS Month,
	DATEPART (YEAR, HireDate) AS Year,
	DATEPART (DAY, HireDate) AS Day
	FROM Employees