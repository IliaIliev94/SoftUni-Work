-- Increase the salary of all emplyoees in the engineering, tool design, marketing and information services department by 12%
UPDATE Employees SET Salary = Salary + Salary * 0.12
	WHERE DepartmentID IN (1, 2, 4, 11)

SELECT Salary FROM Employees