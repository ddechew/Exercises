CREATE DATABASE University;
use University;

CREATE TABLE Majors (
MajorID INT IDENTITY PRIMARY KEY,
[Name] VARCHAR(50)
);

CREATE TABLE Students (
StudentID INT IDENTITY PRIMARY KEY,
StudentNumber VARCHAR(20),
StudentName VARCHAR(25),
MajorID INT REFERENCES Majors(MajorID)
);

CREATE TABLE Payments (
PaymentID INT IDENTITY PRIMARY KEY,
PaymentDate DATE,
PaymentAmount DECIMAL(5,2),
StudentID INT REFERENCES Students(StudentID)
);

CREATE TABLE Subjects (
SubjectID INT IDENTITY PRIMARY KEY,
SubjectName VARCHAR(40)
);

CREATE TABLE Agenda (
StudentID INT REFERENCES Students(StudentID),
SubjectID INT REFERENCES Subjects(SubjectID),
CONSTRAINT PK_StudentSubject PRIMARY KEY(StudentID, SubjectID)
);