use MovieDataBase;

DELETE FROM Actors;

INSERT INTO Actors (CreateTime, UpdatedTime, IsDeleted, FirstName, LastName, Gender, BirthDate)
VALUES 
( SYSDATETIME(), SYSDATETIME(), 'false', 'Brad', 'Pitt', 'Male',  CONVERT(DATETIME, '1974-08-15', 102) ),
( SYSDATETIME(), SYSDATETIME(), 'false', 'Leonardo', 'di Caprio', 'Male',  CONVERT(DATETIME, '1963-01-19', 102) ),
( SYSDATETIME(), SYSDATETIME(), 'false', 'Angelina', 'Jolie', 'Female',  CONVERT(DATETIME, '1980-07-05', 102) ),
( SYSDATETIME(), SYSDATETIME(), 'false', 'Bruce', 'Lee', 'Male',  CONVERT(DATETIME, '1970-10-15', 102) ),
( SYSDATETIME(), SYSDATETIME(), 'false', 'Cameron', 'Diaz', 'Female',  CONVERT(DATETIME, '1979-08-01', 102) )

SELECT * FROM Actors;

