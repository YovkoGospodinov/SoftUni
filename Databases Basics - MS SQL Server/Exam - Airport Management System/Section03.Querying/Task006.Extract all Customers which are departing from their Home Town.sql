SELECT
	c.[CustomerID],
	c.[FirstName] + ' ' + c.[LastName] AS 'FullName',
	twns.[TownName] AS 'HomeTown'
FROM [dbo].[Tickets] AS ti
JOIN [dbo].[Customers] AS c
ON ti.CustomerID = c.CustomerID
JOIN [dbo].[Flights] AS fly
ON ti.FlightID = fly.FlightID
JOIN [dbo].[Airports] AS arp
ON fly.OriginAirportID = arp.AirportID
JOIN [dbo].[Towns] AS twns
ON arp.TownID = twns.TownID
WHERE c.HomeTownID = fly.OriginAirportID
ORDER BY CustomerID ASC