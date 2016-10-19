CREATE TABLE Flights
(
FlightID INT NOT NULL PRIMARY KEY,
DepartureTime DATETIME NOT NULL,
ArrivalTime DATETIME NOT NULL,
Status VARCHAR(9) CHECK(Status = 'Departing' OR Status = 'Delayed' OR Status = 'Arrived' OR Status = 'Cancelled'),
OriginAirportID INT NOT NULL,
DestinationAirportID INT NOT NULL,
AirlineID INT NOT NULL,
CONSTRAINT FK_Origin_Airport FOREIGN KEY(OriginAirportID) REFERENCES Airports (AirportID),
CONSTRAINT FK_Destination_Airport FOREIGN KEY(DestinationAirportID) REFERENCES Airports (AirportID),
CONSTRAINT FK_AirLine FOREIGN KEY(AirlineID) REFERENCES Airlines (AirlineID)
)

CREATE TABLE Tickets
(
TicketID INT NOT NULL PRIMARY KEY,
Price DECIMAL(10, 2) NOT NULL,
Class VARCHAR(6) CHECK(Class = 'First' OR Class = 'Second' OR Class = 'Third'),
Seat VARCHAR(5) NOT NULL,
CustomerID INT NOT NULL,
FlightID INT NOT NULL,
CONSTRAINT FK_Customer FOREIGN KEY(CustomerID) REFERENCES Customers (CustomerID),
CONSTRAINT FK_Flight FOREIGN KEY(FlightID) REFERENCES Flights (FlightID)
)