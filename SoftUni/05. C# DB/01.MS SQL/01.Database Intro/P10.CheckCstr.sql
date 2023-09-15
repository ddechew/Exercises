DELETE FROM Users;

ALTER TABLE Users 
ADD CONSTRAINT CHK_PasswordValid  CHECK (len([Password]) >= 5);
