SELECT
	t.[TicketID],
	a.[AirportName] AS 'Destination',
	c.FirstName + ' ' + c.LastName AS 'CustomerName'
FROM [dbo].[Tickets] AS t
JOIN [dbo].[Customers] AS c
ON t.CustomerID = c.CustomerID
JOIN [dbo].[Flights] as f
ON t.FlightID = f.FlightID
JOIN [dbo].[Airports] AS a
ON f.DestinationAirportID = a.AirportID
WHERE t.Price < 5000 AND t.Class = 'First'