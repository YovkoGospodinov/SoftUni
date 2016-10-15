CREATE TABLE People
 (
  Id INT NOT NULL IDENTITY PRIMARY KEY CHECK(Id < 2147483647),
  Name NVARCHAR(200) NOT NULL,
  Picture VARBINARY(2),
  Height FLOAT(2),
  Weight FLOAT(2),
  Gender CHAR(1) NOT NULL CHECK(Gender = 'm' OR Gender = 'f'),
  Birthdate DATE NOT NULL,
  Biography TEXT
 )

 INSERT INTO People (Name, Height, Weight, Gender, Birthdate, Biography)
 VALUES ('Ivan Ivanov', 1.75, 89.01, 'm', '1983-09-07', 'Nothing for me just human'),
('Dimityr Kirov', 1.85, 79.01, 'm', '1982-09-07', 'PornStar'),
('Kiro Donev', 1.75, 100.00, 'm', '1983-09-07', 'RockStar'),
('Neno Nenov', 1.65, 60.23, 'm', '1981-09-07', 'Developer'),
('Minka Kocheva', 1.55, 42.41, 'f', '1992-10-01', 'I am cute')
