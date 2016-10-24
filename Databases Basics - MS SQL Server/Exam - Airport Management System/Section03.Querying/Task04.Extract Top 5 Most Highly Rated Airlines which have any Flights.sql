SELECT DISTINCT  TOP 5 
	a.[AirlineID],
	a.[AirlineName],
	a.[Nationality],
	a.[Rating]
FROM [dbo].[Airlines] AS a
INNER JOIN  [dbo].[Flights] AS f
ON a.AirlineID = f.AirlineID
ORDER BY Rating DESC, a.AirlineID ASC