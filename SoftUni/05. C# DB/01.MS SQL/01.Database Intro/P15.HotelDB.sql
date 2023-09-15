CREATE DATABASE Hotel;

use Hotel;

CREATE TABLE Employees (
Id INT PRIMARY KEY IDENTITY,
FirstName NVARCHAR(30) NOT NULL,
LastName NVARCHAR(30) NOT NULL,
Title VARCHAR(20) NOT NULL,
Notes VARCHAR(500)
);

INSERT INTO Employees (FirstName, LastName, Title) VALUES
('Mike', 'Landson', 'Receptionist'),
('James', 'Burry', 'Chef'),
('Emilly', 'Wilson', 'Caterer');

CREATE TABLE Customers (
AccountNumber INT PRIMARY KEY IDENTITY,
FirstName NVARCHAR(30) NOT NULL,
LastName NVARCHAR(30) NOT NULL,
EmergencyName NVARCHAR(35) NOT NULL,
EmergencyNumber INT NOT NULL,
Notes VARCHAR(500)
);

INSERT INTO Customers (FirstName, LastName, EmergencyName, EmergencyNumber) VALUES
('Ran', 'Dom', 'Ran', 1234567890),
('An', 'Don', 'An', 1234567890),
('Na', 'Drim', 'Drim', 1234567890);

CREATE TABLE RoomStatus (
RoomStatus VARCHAR(30) NOT NULL,
Notes VARCHAR(500)
);

INSERT INTO RoomStatus (RoomStatus) VALUES
('Occupied'),
('Free'),
('Under Construction');

CREATE TABLE RoomTypes (
RoomType VARCHAR(30) NOT NULL,
Notes VARCHAR(500)
);

INSERT INTO RoomTypes (RoomType) VALUES
('Apartment'),
('Two-room'),
('One-room');

CREATE TABLE BedTypes (
BedType VARCHAR(30) NOT NULL,
Notes VARCHAR(500)
);

INSERT INTO BedTypes (BedType) VALUES
('One-bed'),
('Two-bed'),
('Big-bed');

CREATE TABLE Rooms (
RoomNumber INT PRIMARY KEY IDENTITY,
RoomType VARCHAR(30) NOT NULL,
BedType VARCHAR(30) NOT NULL,
Rate DECIMAL(6,2),
RoomStatus VARCHAR(30) NOT NULL,
Notes VARCHAR(500)
);

INSERT INTO Rooms (RoomType, BedType, Rate, RoomStatus) VALUES
('Apartment', 'Big-bed', 8.9, 'Occupied'),
('Two-room', 'Two-bed', 6.8, 'Free'),
('One-room', 'One-bed', 6.4, 'Under Construction');

CREATE TABLE Payments (
Id INT PRIMARY KEY IDENTITY,
EmployeeId INT NOT NULL,
PaymentDate DATE NOT NULL,
AccountNumber INT NOT NULL,
FirstDateOccupied DATE NOT NULL,
LastDateOccupied DATE NOT NULL,
TotalDays INT NOT NULL,
AmountCharged DECIMAL(6,2) NOT NULL,
TaxRate DECIMAL(5,2),
TaxAmount DECIMAL(7,2),
PaymentTotal DECIMAL(7,2) NOT NULL,
Notes VARCHAR(500)
);

INSERT INTO Payments (EmployeeId, PaymentDate, AccountNumber, FirstDateOccupied, LastDateOccupied, TotalDays, AmountCharged, TaxRate, TaxAmount, PaymentTotal)
VALUES
(1, '12/24/2006', 3, '12/26/2006', '1/1/2007', 6, 300, 9.4, 28.2, 328.2),
(2, '2/1/2008', 1, '2/1/2008', '2/8/2008', 7, 350, 9, 31.5, 381.5),
(1, '11/9/2023', 2, '9/15/2023', '10/15/2023', 1500, 30, 10, 150, 1650);

CREATE TABLE Occupancies (
Id INT PRIMARY KEY IDENTITY,
EmployeeId INT NOT NULL,
DateOccupied DATE NOT NULL,
AccountNumber INT NOT NULL,
RoomNumber INT NOT NULL,
RateApplied DECIMAL(5,2),
PhoneCharge DECIMAL(7,2),
Notes VARCHAR(500)
);

INSERT INTO Occupancies (EmployeeId, DateOccupied, AccountNumber, RoomNumber, RateApplied, PhoneCharge) VALUES
(1, '12/24/2006', 3, 105, NULL, NULL),
(2, '6/22/2012', 3, 106, 9.2, 15.2),
(3, '5/1/2018', 3, 105, 6.5, NULL);