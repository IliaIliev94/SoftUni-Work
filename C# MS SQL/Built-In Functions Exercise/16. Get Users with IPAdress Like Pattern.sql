SELECT UserName, IpAddress
FROM Users
WHERE IpAddress LIKE '___.1%.%.___'
ORDER BY UserName