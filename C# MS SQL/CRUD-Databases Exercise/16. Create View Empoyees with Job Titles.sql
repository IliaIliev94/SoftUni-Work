-- Create a view which selects first name, middlename (replaces with empty string if null), last name and job title
CREATE VIEW V_EmployeeNameJobTitle AS
	SELECT FirstName + ' ' + ISNULL(MiddleName, '') + ' ' + LastName AS [Full Name], JobTitle
	FROM Employees