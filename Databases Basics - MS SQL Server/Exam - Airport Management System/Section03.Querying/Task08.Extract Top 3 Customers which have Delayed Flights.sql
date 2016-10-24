SELECT TOP 3
	ti.CustomerID,
	cu.FirstName + ' ' + cu.LastName AS 'FullName',
	ti.Price AS 'TicketPrice',
	arp.AirportName AS 'Destination'
FROM [dbo].[Tickets] AS ti
JOIN [dbo].[Customers] AS cu
ON ti.CustomerID = cu.CustomerID
JOIN [dbo].[Flights] AS fly
ON ti.FlightID = fly.FlightID
JOIN [dbo].[Airports] AS arp
ON fly.DestinationAirportID = arp.AirportID
WHERE fly.Status = 'Delayed'
ORDER BY ti.Price DESC