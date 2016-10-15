CREATE TABLE Categories
(
Id INT NOT NULL IDENTITY PRIMARY KEY, 
Category VARCHAR(50), 
DailyRate DECIMAL, 
WeeklyRate DECIMAL, 
MonthlyRate DECIMAL, 
WeekendRate DECIMAL
)

INSERT INTO Categories (Category, DailyRate, WeeklyRate, MonthlyRate, WeekendRate)
VALUES
('Sedan', 30.00, 180.00, 700.00, 80.00),
('Sport', 50.00, 250.00, 850.00, 120.00),
('Limo', 100.00, 500.00, 1500.00, 300.00)

CREATE TABLE Cars
(
Id INT NOT NULL IDENTITY PRIMARY KEY, 
PlateNumber VARCHAR(50) NOT NULL, 
Make VARCHAR(50) NOT NULL, 
Model VARCHAR(50) NOT NULL, 
CarYear INT NOT NULL, 
CategoryId INT NOT NULL FOREIGN KEY REFERENCES Categories(Id), 
Doors INT NOT NULL, 
Picture VARBINARY, 
Condition VARCHAR(50), 
Available BIT NOT NULL
)

INSERT INTO Cars (PlateNumber, Make, Model, CarYear, CategoryId, Doors, Available)
VALUES
('CA1254CC', 'Ford', 'Mondeo', 2014, 1, 4, 1),
('CA6969CB', 'Nissan', 'GT-R', 2013, 2, 2, 1),
('MYLIMO', 'CHRYSLER', 'Limo', 2010, 3, 4, 1)

CREATE TABLE Employees
(
Id INT NOT NULL IDENTITY PRIMARY KEY, 
FirstName VARCHAR(50) NOT NULL, 
LastName VARCHAR(50) NOT NULL, 
Title VARCHAR(50) NOT NULL, 
Notes TEXT
)

INSERT INTO Employees (FirstName, LastName, Title)
VALUES
('Ivan', 'Ivanov', 'Mechanic'),
('Donka', 'Petrova', 'Clark'),
('Mincho', 'Gechev', 'Manager')

CREATE TABLE Customers
(
Id INT NOT NULL IDENTITY PRIMARY KEY, 
DriverLicenceNumber VARCHAR(50) NOT NULL, 
FullName VARCHAR(50) NOT NULL, 
Address VARCHAR(50) NOT NULL, 
City VARCHAR(50) NOT NULL, 
ZIPCode VARCHAR(50) NOT NULL, 
Notes TEXT
)

INSERT INTO Customers (DriverLicenceNumber, FullName, Address, City, ZIPCode)
VALUES
('123456', 'John Kain', 'Limoncello Ave 12', 'Cape Canaveral', '90902'),
('34557', 'Kiro Kirchev', 'Bulgaria blv 122', 'Sofia', '1404'),
('5431222', 'Dimo Kocev', 'Liubliana str 32', 'Plovdiv', '3100')

CREATE TABLE RentalOrders
(
Id INT NOT NULL IDENTITY PRIMARY KEY, 
EmployeeId INT NOT NULL FOREIGN KEY REFERENCES Employees(Id), 
CustomerId INT NOT NULL FOREIGN KEY REFERENCES Customers(Id), 
CarId INT NOT NULL FOREIGN KEY REFERENCES Cars(Id),
CarCondition VARCHAR(50) NOT NULL, 
TankLevel VARCHAR(50) NOT NULL, 
KilometrageStart VARCHAR(50) NOT NULL, 
KilometrageEnd VARCHAR(50), 
TotalKilometrage VARCHAR(50), 
StartDate DATE NOT NULL, 
EndDate  DATE NOT NULL, 
TotalDays INT NOT NULL, 
RateApplied VARCHAR(50) NOT NULL, 
TaxRate DECIMAL NOT NULL, 
OrderStatus VARCHAR(50) NOT NULL, 
Notes TEXT
)

INSERT INTO RentalOrders (EmployeeId, CustomerId, CarId, CarCondition, TankLevel, KilometrageStart, StartDate, EndDate, TotalDays, RateApplied, TaxRate, OrderStatus)
VALUES
(1, 1, 1, 'Good', 'full', 80123, '2016-10-15', '2016-10-25', 10, 'Regular', 210, 'ongoing'),
(2, 2, 2, 'Nice', 'full', 10123, '2016-10-15', '2016-10-22', 7, 'Regular', 250, 'ongoing'),
(3, 3, 3, 'Good', 'full', 23000, '2016-10-15', '2016-10-17', 2, 'Regular', 300, 'ongoing')