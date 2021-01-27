
-- Highest Salaries
CREATE VIEW v_EmployeesWithHighestSalaries AS
SELECT FirstName, LastName, FirstName + ' ' + LastName AS FullName, Salary
	FROM Employees
	WHERE Salary > 40000