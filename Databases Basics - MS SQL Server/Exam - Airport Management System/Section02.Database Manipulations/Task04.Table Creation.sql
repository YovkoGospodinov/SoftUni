CREATE TABLE CustomerReviews
(
ReviewID INT NOT NULL PRIMARY KEY,
ReviewContent VARCHAR(255) NOT NULL,
ReviewGrade TINYINT CHECK(ReviewGrade >= 0 AND ReviewGrade <= 10),
AirlineID INT NOT NULL,
CustomerID INT NOT NULL,
CONSTRAINT FK_Customer_AirLine FOREIGN KEY(AirlineID) REFERENCES Airlines (AirlineID),
CONSTRAINT FK_Customer_Customer FOREIGN KEY(CustomerID) REFERENCES Customers (CustomerID)
)

CREATE TABLE CustomerBankAccounts
(
AccountID  INT NOT NULL PRIMARY KEY,
AccountNumber VARCHAR(10) NOT NULL UNIQUE,
Balance DECIMAL(10, 2) NOT NULL,
CustomerID INT NOT NULL,
CONSTRAINT FK_Banl_Customer FOREIGN KEY(CustomerID) REFERENCES Customers (CustomerID)
)
