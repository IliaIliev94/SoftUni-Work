CREATE VIEW V_ObfuscateCCNumbers AS
SELECT CustomerID AS ID, FirstName, LastName,
	LEFT(PaymentNumber, 6) + REPLICATE('*', LEN(PaymentNumber) - 6) AS PaymentNumber
	FROM Customers