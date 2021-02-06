SELECT MIN(t.average) FROM (SELECT d.Name, (SELECT AVG(Salary) FROM Employees WHERE DepartmentID = d.departmentID) AS average
FROM Departments d) t