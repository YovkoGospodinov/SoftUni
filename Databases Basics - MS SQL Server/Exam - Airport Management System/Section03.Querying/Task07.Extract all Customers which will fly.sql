SELECT
	ti.CustomerID,
	cust.FirstName + ' ' + cust.LastName AS 'FullName',
	convert(int,DATEDIFF(d, cust.DateOfBirth, getdate())/365.25) AS 'Age'
 FROM [dbo].[Tickets] AS ti
  JOIN [dbo].[Flights] AS fly
  ON ti.[FlightID] = fly.[FlightID]
  JOIN [dbo].[Customers] AS cust
  ON ti.CustomerID = cust.CustomerID
  WHERE fly.Status = 'Departing'
  ORDER BY cust.DateOfBirth ASC, ti.CustomerID ASC