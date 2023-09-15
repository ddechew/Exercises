CREATE DATABASE CarRental;
use CarRental;

CREATE TABLE Categories (
Id INT PRIMARY KEY IDENTITY,
CategoryName VARCHAR(20) NOT NULL,
DailyRate DECIMAL(5,2),
WeeklyRate DECIMAL (5,2),
MonthlyRate DECIMAL (5,2) NOT NULL,
WeekendRate DECIMAL (5,2)
);

INSERT INTO Categories (CategoryName, MonthlyRate) VALUES
('SUV', 15.3),
('Off-Road Vehicle', 19.3),
('Standard', 33.1);

CREATE TABLE Cars (
Id INT PRIMARY KEY IDENTITY,
PlateNumber VARCHAR(10) NOT NULL,
Manufacturer VARCHAR(15) NOT NULL,
Model VARCHAR(10) NOT NULL,
CarYear INT NOT NULL,
CategoryId INT NOT NULL,
Doors INT NOT NULL,
Picture VARBINARY(MAX),
Condition VARCHAR(20) NOT NULL,
Available BIT NOT NULL
);

INSERT INTO Cars (PlateNumber, Manufacturer, Model, CarYear, CategoryId, Doors, Condition, Available)
VALUES 
('B1343CH', 'Mercedes', 'X', 2001, 1, 4, 'Stable', 1),
('CA1343CH', 'BMW', 'X', 2020, 2, 4, 'New', 1),
('CO343CH', 'Audi', 'X', 2000, 1, 4, 'Stable', 1);


CREATE TABLE Employees (
Id INT PRIMARY KEY IDENTITY,
FirstName NVARCHAR(12) NOT NULL,
LastName NVARCHAR(10) NOT NULL,
Title VARCHAR(40) NOT NULL,
Notes VARCHAR(500)
);

INSERT INTO Employees (FirstName, LastName, Title) VALUES
('Dimitri', 'Zagorovich', 'Maintenance Employee'),
('Mark', 'Din', 'Rental Advisor'),
('George', 'Anderson', 'Manager');

CREATE TABLE Customers (
Id INT PRIMARY KEY IDENTITY,
DriverLicenseNumber INT NOT NULL,
FullName NVARCHAR (30) NOT NULL,
[Address] VARCHAR (50) NOT NULL,
City VARCHAR (50) NOT NULL,
ZIPCODE INT,
Notes VARCHAR(500)
);

INSERT INTO Customers (DriverLicenseNumber, FullName, [Address], City) VALUES
(1234567, 'Alexander Stefanov', 'Random Address', 'Burgas'),
(7654321, 'Vilislav Zagorov', 'Random', 'Sofia'),
(3131234, 'Mark Zuckerberg', 'CA, Markville Street 45', 'Los Angeles');

CREATE TABLE RentalOrders (
Id INT PRIMARY KEY IDENTITY,
EmployeeId INT NOT NULL,
CustomerId INT NOT NULL,
CarId INT NOT NULL,
TankLevel DECIMAL(7, 2) NOT NULL,
KilometrageStart INT,
KilometrageEnd INT,
TotalKilometrage INT NOT NULL,
StartDate DATE NOT NULL,
EndDate DATE NOT NULL,
TotalDays INT NOT NULL,
RateApplied DECIMAL (6,2),
TaxRate DECIMAL (7,2),
OrderStatus VARCHAR(20) NOT NULL,
Notes VARCHAR(500)
);

INSERT INTO RentalOrders (EmployeeId, CustomerId, CarId, TankLevel, TotalKilometrage, StartDate, EndDate, TotalDays, OrderStatus)
VALUES
(1, 1, 1, 300, 400, '12/12/2021', '1/12/2022', 30, 'Accepted'),
(2, 3, 4, 350, 460, '3/6/2023', '4/6/2023', 31, 'In process'),
(1, 2, 2, 345, 410, '4/11/2024', '4/29/2024', 18, 'Declined');
