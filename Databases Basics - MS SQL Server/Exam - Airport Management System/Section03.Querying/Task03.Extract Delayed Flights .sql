SELECT FlightID,
	DepartureTime,
	ArrivalTime
FROM [dbo].[Flights]
WHERE Status = 'Delayed'
ORDER BY FlightID ASC