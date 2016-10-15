CREATE TABLE Towns
(
Id INT NOT NULL IDENTITY PRIMARY KEY,
Name VARCHAR(50) NOT NULL
)

INSERT INTO Towns (Name)
VALUES 
('Sofia'),
('Varna'),
('Plovdiv')

CREATE TABLE Addresses
(
Id INT NOT NULL IDENTITY PRIMARY KEY,
AddressText VARCHAR(50) NOT NULL,
TownId INT NOT NULL FOREIGN KEY REFERENCES Towns(Id)
)

INSERT INTO Addresses (AddressText, TownId)
VALUES
('Tintiava str 12', 1),
('Primorski blv 1', 2),
('Mladejki 1', 3)


CREATE TABLE Departments
(
Id INT NOT NULL IDENTITY PRIMARY KEY,
Name VARCHAR(50) NOT NULL
)

INSERT INTO Departments (Name)
VALUES
('Dev'),
('Administration'),
('Trainers')

CREATE TABLE Employees
(
Id INT NOT NULL IDENTITY PRIMARY KEY,
FirstName VARCHAR(50) NOT NULL,
MiddleName VARCHAR(50) NOT NULL,
LastName VARCHAR(50) NOT NULL,
JobTitle VARCHAR(50) NOT NULL,
DepartmentId INT NOT NULL FOREIGN KEY REFERENCES Departments(Id),
HireDate Date NOT NULL,
Salary DECIMAL NOT NULL,
AddressId INT NOT NULL FOREIGN KEY REFERENCES Addresses(Id)
)

INSERT INTO Employees (FirstName, MiddleName, LastName, JobTitle, DepartmentId, HireDate, Salary, AddressId)
VALUES 
('Ivan', 'Ivanov', 'Kirov', '.Net Developer', 1, '2016-01-03', 3000, 1),
('Misho', 'Boykov', 'Naydenov', 'Java Developer', 1, '2015-03-07', 4000, 1),
('Gosho', 'Petkov', 'Penkov', 'Senior Trainer', 2, '2015-11-04', 2500, 3)