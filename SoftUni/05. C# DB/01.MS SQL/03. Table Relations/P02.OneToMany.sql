CREATE TABLE Manufacturers (
ManufacturerID INT IDENTITY PRIMARY KEY,
[Name] VARCHAR(20),
EstablishedOn DATE
);

CREATE TABLE Models (
ModelID INT IDENTITY(101,1) PRIMARY KEY,
[Name] VARCHAR(20),
ManufacturerID INT REFERENCES Manufacturers(ManufacturerID)
);
