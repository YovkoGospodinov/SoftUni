SELECT DISTINCT
	c.[CustomerID],
	c.[FirstName] + ' ' + c.[LastName] AS 'FullName',
	twns.[TownName] AS 'HomeTown'
FROM [dbo].[Customers] c
JOIN [dbo].[Towns] AS twns
ON c.[HomeTownID] = twns.[TownID]
JOIN [dbo].[Tickets] AS t
ON t.CustomerID = c.CustomerID
JOIN [dbo].[Flights] AS f
ON f.FlightID = t.FlightID
JOIN [dbo].[Airports] AS a
ON a.AirportID = f.OriginAirportID
WHERE a.TownID = c.HomeTownID
ORDER BY CustomerID ASC