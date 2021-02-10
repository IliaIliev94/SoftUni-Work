/* Get all records from Employees table and groupthem by Department ID. After that display the
maximum salary for each department where the maximum salary is not in the range of 30000-70000 */
SELECT DepartmentID, 
MAX (Salary) AS MaxSalary 
FROM Employees
GROUP BY DepartmentID
HAVING MAX(Salary) < 30000 OR MAX(Salary) > 70000