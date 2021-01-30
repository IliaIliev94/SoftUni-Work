SELECT Id, [Name], Quantity, BoxCapacity, PalletCapacity, 
	CEILING(CEILING(Quantity * 1.0 / BoxCapacity) / PalletCapacity) AS [Number of pallets]
	FROM Products