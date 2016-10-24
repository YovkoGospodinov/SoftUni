SELECT 
	fly.FlightID,
	fly.DepartureTime,
	fly.ArrivalTime,
	arp.AirportName AS 'Origin',
	arpd.AirportName AS 'Destination'
FROM [dbo].[Flights] fly
JOIN [dbo].[Airports] arp
ON fly.OriginAirportID = arp.AirportID
JOIN [dbo].[Airports] arpd
ON fly.DestinationAirportID = arpd.AirportID
WHERE Status = 'Departing'
ORDER BY DepartureTime ASC