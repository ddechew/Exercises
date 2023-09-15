CREATE TABLE Users (
Id INT IDENTITY,
Username VARCHAR(30) NOT NULL,
[Password] VARCHAR(26) NOT NULL,
ProfilePicture VARBINARY(MAX),
LastLoginTime DATETIME,
IsDeleted BIT
);

ALTER TABLE Users
ADD CONSTRAINT PK_IdUsername PRIMARY KEY (Id, Username);

INSERT INTO Users (Username, [Password], ProfilePicture, LastLoginTime, IsDeleted) VALUES
('MTK', '1231', NULL, '12/02/2003', 0),
('MTK', '1231', NULL, '12/02/2004', 0),
('MT', '1237', NULL, '12/02/2003', 0),
('MS', '1236', NULL, '12/02/2003', 0),
('MZ', '1235', NULL, '12/02/2003', 0);

SELECT * FROM Users