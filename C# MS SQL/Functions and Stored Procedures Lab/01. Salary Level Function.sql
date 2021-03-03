CREATE OR ALTER FUNCTION ufn_GetSalaryLevel(@Salary MONEY)
RETURNS VARCHAR(7)
AS
BEGIN
DECLARE @Result VARCHAR(7)
IF @Salary IS NULL
	SET @Result = NULL
IF @Salary < 30000
	SET @Result = 'Low'
ELSE IF @Salary <= 50000
	SET @Result = 'Average'
ELSE
	SET @Result = 'High'
RETURN @Result
END