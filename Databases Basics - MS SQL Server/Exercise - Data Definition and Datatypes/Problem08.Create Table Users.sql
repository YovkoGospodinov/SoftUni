CREATE TABLE Users
 (
 Id INT NOT NULL IDENTITY PRIMARY KEY CHECK(Id < 9223372036854775807),
 Username VARCHAR(30) UNIQUE NOT NULL,
 Password VARCHAR(26) NOT NULL,
 Picture VARBINARY(1),
 LastLoginTime DATE,
 IsDeleted BIT
 )

 INSERT INTO Users (Username, Password, LastLoginTime, IsDeleted)
 VALUES
 ('Koko', 'kiki', '2016-10-11', 0),
 ('Momo', 'mimi', '2016-10-11', 1),
 ('Bibi', 'jiji', '2016-10-12', 0),
 ('Zizi', 'sisi', '2016-10-09', 0),
 ('Qiqi', 'wiwi', '2016-10-01', 1)