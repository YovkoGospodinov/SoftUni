SELECT 
	ti.CustomerID,
	cu.FirstName + ' ' + cu.LastName AS 'FullName',
	convert(int,DATEDIFF(d, cu.DateOfBirth, getdate())/365) AS 'Age'
FROM [dbo].[Tickets] AS ti
JOIN [dbo].[Customers] AS cu
ON ti.CustomerID = cu.CustomerID
JOIN [dbo].[Flights] fly
ON ti.FlightID = fly.FlightID
WHERE convert(int,DATEDIFF(d, cu.DateOfBirth, getdate())/365) < 21 AND fly.Status = 'Arrived'