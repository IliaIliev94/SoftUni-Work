-- Find the full name and job title of all employees with salaries between 20000 and 30000
SELECT FirstName, LastName, JobTitle 
	FROM Employees 
	WHERE Salary BETWEEN 20000 AND 30000