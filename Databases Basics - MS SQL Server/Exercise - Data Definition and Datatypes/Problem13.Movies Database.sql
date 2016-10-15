CREATE TABLE Directors
(
Id INT NOT NULL IDENTITY PRIMARY KEY,
Name VARCHAR(50),
Notes TEXT
)

INSERT INTO Directors (Name, Notes)
VALUES
('Ivan', 'Best Man'),
('Misho', 'Good Man'),
('Kiro', 'Requester'),
('Doncho', 'Trainer'),
('Gosho', 'Ordinary man')

CREATE TABLE Genres 
(
Id INT NOT NULL IDENTITY PRIMARY KEY,
Name VARCHAR(50),
Notes TEXT
)

INSERT INTO Genres (Name, Notes)
VALUES
('Action', 'Dark'),
('Misho', 'Good Man'),
('Kiro', 'Requester'),
('Doncho', 'Trainer'),
('Gosho', 'Ordinary man')

CREATE TABLE Categories
(
Id INT NOT NULL IDENTITY PRIMARY KEY,
Name VARCHAR(50),
Notes TEXT
)

INSERT INTO Categories (Name, Notes)
VALUES
('Ivan', 'Best Man'),
('Misho', 'Good Man'),
('Kiro', 'Requester'),
('Doncho', 'Trainer'),
('Gosho', 'Ordinary man')

CREATE TABLE Movies
(
Id INT NOT NULL IDENTITY PRIMARY KEY, 
Title VARCHAR(50), 
DirectorId INT, 
CopyrightYear INT, 
Length VARCHAR(50), 
GenreId INT, 
CategoryId INT, 
Rating VARCHAR(50), 
Notes TEXT
)

INSERT INTO Movies (Title, DirectorId, Length, GenreId, CategoryId, Rating)
VALUES
('Fight Club', 1, 150, 4, 1, 10.0),
('Snatch', 3, 120, 2, 1, 9.5),
('Dark Knight', 2, 130, 1, 2, 9.7),
('Mad Max : Fury Road', 5, 110, 1, 2, 9.9),
('Kill Bill', 4, 170, 1, 2, 8.5)