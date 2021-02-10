/* Get all employes in departments 2,5 and 7 which are hired after 01.01.2000 and group them by 
departmentID. Finally get the minimal salary for each group. */
SELECT DepartmentID, 
MIN(Salary) AS MinimumSalary
FROM Employees
WHERE DepartmentID IN (2, 5, 7) 
	AND HireDate > '2000-01-01'
GROUP BY DepartmentID