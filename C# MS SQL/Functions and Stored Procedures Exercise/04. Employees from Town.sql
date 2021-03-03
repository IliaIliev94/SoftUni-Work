CREATE PROCEDURE usp_GetEmployeesFromTown @TownName VARCHAR(MAX)
AS
SELECT FirstName, LastName FROM Employees e
LEFT JOIN Addresses a ON e.AddressID = a.AddressID
LEFT JOIN Towns t ON a.TownID = t.TownID
WHERE t.[Name] = @TownName
GO

EXECUTE usp_GetEmployeesFromTown 'Sofia'