CREATE DATABASE [Online Store];
use [Online Store];

CREATE TABLE Cities (
CityID INT IDENTITY PRIMARY KEY,
[Name] VARCHAR(30)
);

CREATE TABLE Customers (
CustomerID INT IDENTITY PRIMARY KEY,
[Name] VARCHAR(50),
Birthday DATE,
CityID INT REFERENCES Cities(CityID)
);

CREATE TABLE Orders (
OrderID INT IDENTITY PRIMARY KEY,
CustomerID INT REFERENCES Customers(CustomerID)
);

CREATE TABLE ItemTypes (
ItemTypeID INT IDENTITY PRIMARY KEY,
[Name] VARCHAR(30)
);

CREATE TABLE Items (
ItemID INT IDENTITY PRIMARY KEY,
[Name] VARCHAR(40),
ItemTypeID INT REFERENCES ItemTypes(ItemTypeID)
);

CREATE TABLE OrderItems (
OrderID INT REFERENCES Orders(OrderID),
ItemID INT REFERENCES Items(ItemID)
CONSTRAINT PK_OrderItems PRIMARY KEY(OrderID, ItemID)
);


