UPDATE Tickets
SET Price = Price + 0.5 * Price
WHERE FlightID = 1
OR FlightID = 5
OR FlightID = 6
OR FlightID = 8
OR FlightID = 9