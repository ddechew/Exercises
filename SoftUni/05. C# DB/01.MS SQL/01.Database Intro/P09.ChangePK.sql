ALTER TABLE Users
DROP CONSTRAINT PK_IdUsername;

ALTER TABLE Users
ADD CONSTRAINT PK_IdUser PRIMARY KEY (Id, Username);