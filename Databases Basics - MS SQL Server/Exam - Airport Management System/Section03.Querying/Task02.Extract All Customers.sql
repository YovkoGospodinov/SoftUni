SELECT CustomerID,
	Customers.FirstName + ' ' + Customers.LastName
	AS 'FullName',
	Gender
FROM dbo.Customers
ORDER BY FullName ASC, CustomerID ASC