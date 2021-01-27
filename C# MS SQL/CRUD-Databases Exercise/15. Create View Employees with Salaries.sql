-- Create a view selecting the first name, last name and salary of employees
CREATE VIEW V_EmployeesSalaries AS
	SELECT FirstName, LastName, Salary
	FROM Employees