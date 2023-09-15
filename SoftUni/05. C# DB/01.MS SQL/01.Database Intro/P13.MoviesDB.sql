use master;
CREATE DATABASE Movies;

use Movies;

CREATE TABLE Directors (
Id INT PRIMARY KEY IDENTITY,
DirectorName NVARCHAR(30) NOT NULL,
Notes NVARCHAR(500)
);

INSERT INTO Directors (DirectorName, Notes) VALUES 
('Michael De Santa', 'Meltdown - The Movie, Producing Director'),
('Jimmy De Santa', 'Meltdown - The Movie, Statist'),
('Mike', 'Meltdown - The Movie, Producing Co-Director'),
('Tina', 'Meltdown- The Movie, Audio Scripter'),
('Solomon', 'Meltdown - The Movie, Director'); 

CREATE TABLE Genres (
Id INT PRIMARY KEY IDENTITY,
GenreName VARCHAR(20) NOT NULL,
Notes NVARCHAR(500)
);

INSERT INTO Genres (GenreName) VALUES
('Action'),
('Fantasy'),
('Sci-Fi'),
('Comedy'),
('Horror');

CREATE TABLE Categories (
Id INT PRIMARY KEY IDENTITY,
CategoryName VARCHAR(40) NOT NULL,
Notes NVARCHAR(500)
);

INSERT INTO Categories (CategoryName) VALUES
('Western'),
('Absolute'),
('Documentary'),
('Experimental'),
('Narrative');

CREATE TABLE Movies ( 
Id INT PRIMARY KEY IDENTITY,
Title NVARCHAR(30) NOT NULL,
DirectorId INT NOT NULL,
CopyrightYear DATE NOT NULL,
[Length] INT NOT NULL,
GenreId INT NOT NULL,
CategoryId INT NOT NULL,
Rating DECIMAL(2,1),
Notes NVARCHAR(500)
);

INSERT INTO Movies (Title, DirectorId, CopyrightYear, [Length], GenreId, CategoryId, Rating) VALUES
('X-Men', 3, '7/14/2000', 120, 1, 1, 9.3),
('Star Wars', 6, '3/16/1998', 160, 1, 2, 9.2),
('Indiana Jones', 6, '6/18/1999', 140, 3, 4, 8.6),
('Spider-Man', 2, '1/12/2001', 130, 1, 4, 7.8),
('Iron-Man', 10, '1/4/2003', 130, 1, 3, 8.9);