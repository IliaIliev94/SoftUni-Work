CREATE PROCEDURE usp_EmployeesBySalaryLevel (@Salary VARCHAR(10))
AS
SELECT FirstName, LastName FROM Employees
WHERE dbo.ufn_GetSalaryLevel(Salary) = @Salary
GO

EXECUTE usp_EmployeesBySalaryLevel 'High'