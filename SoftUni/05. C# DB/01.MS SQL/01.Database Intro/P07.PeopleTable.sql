CREATE TABLE People (
Id INT PRIMARY KEY IDENTITY,
[Name] NVARCHAR(200) NOT NULL,
Picture VARBINARY(MAX),
Height DECIMAL(10, 2),
[Weight] DECIMAL(10, 2),
Gender CHAR(1) CHECK (Gender IN ('m', 'f')) NOT NULL,
Birthdate DATE NOT NULL,
Biography NVARCHAR(MAX)
);

INSERT INTO People ([Name], Picture, Height, [Weight], Gender, Birthdate, Biography) VALUES
('M', NULL, 182.3, 130.2, 'f', '12/12/2013', NULL),
('M2', NULL, 182.3, 130.2, 'f', '12/2/2022', NULL),
('M3', NULL, 182.3, 130.2, 'm', '8/9/2024', NULL),
('M4', NULL, 182.3, 130.2, 'f', '12/12/2012', NULL),
('M5', NULL, 182.3, 130.2, 'f', '11/2/2009', NULL);