/* Get the full name and salary of all employees with salary greater than 50000 and order 
them descending by salary*/
SELECT FirstName, LastName, Salary FROM Employees
	WHERE Salary > 50000 ORDER BY Salary DESC