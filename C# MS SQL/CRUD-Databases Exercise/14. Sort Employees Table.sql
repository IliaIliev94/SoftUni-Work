/* Sort employees by salary descending then first name alphabetically then last 
name descending then middlename alphabetically */
SELECT * FROM Employees
	ORDER BY Salary DESC, 
	FirstName, 
	LastName DESC, 
	MiddleName