-- Create a new table with employees having salary greater than 30000
SELECT * 
INTO NewEmployees
FROM Employees
WHERE Salary > 30000

-- Delete from the new table all employees with a manager with ID of 42
DELETE FROM NewEmployees
WHERE ManagerID = 42


-- Increase the salary of all the employees from the new table with departmend ID of 1 with 5000
UPDATE NewEmployees
SET Salary += 5000
WHERE DepartmentID = 1

-- Group all the employees from the new table by department ID and return the average salary for each group
SELECT DepartmentID, 
AVG(Salary) AS AverageSalary
FROM NewEmployees
GROUP BY DepartmentID
