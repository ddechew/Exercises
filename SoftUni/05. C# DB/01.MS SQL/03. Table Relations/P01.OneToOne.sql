CREATE TABLE Passports (
PassportID INT IDENTITY(101,1) PRIMARY KEY,
PassportNumber VARCHAR(8)
);

CREATE TABLE Persons (
PersonID INT IDENTITY,
FirstName VARCHAR(50),
Salary DECIMAL(10,2),
PassportID INT
);

INSERT INTO Persons(FirstName, Salary, PassportID) VALUES
('Roberto', 43300.00, 102),
('Tom', 56100.00, 103),
('Yana', 60200.00, 101);

INSERT INTO Passports(PassportNumber) VALUES
('N34FG21B'),
('K65LO4R7'),
('ZE657QP2');

ALTER TABLE Persons
	ADD 
		CONSTRAINT PK_PersonID PRIMARY KEY (PersonID),
		FOREIGN KEY(PassportID) REFERENCES Passports(PassportID);