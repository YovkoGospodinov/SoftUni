SELECT
	fly.OriginAirportID AS 'AirportID',
	arp.AirportName,
	1 AS 'Passengers'
FROM [dbo].[Tickets] as ti
JOIN [dbo].[Flights] AS fly
ON ti.FlightID = fly.FlightID
JOIN [dbo].[Airports] AS arp
ON fly.OriginAirportID = arp.AirportID
WHERE fly.Status = 'Departing'
ORDER BY fly.OriginAirportID