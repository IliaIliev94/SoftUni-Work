-- Select the count of all employees which don't have a manager
SELECT COUNT(*) AS Count FROM Employees
WHERE ManagerID IS NULL