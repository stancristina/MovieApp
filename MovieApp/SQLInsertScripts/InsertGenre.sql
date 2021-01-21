use MovieDataBase;

DELETE FROM Genres;

INSERT INTO Genres (CreateTime, UpdatedTime, IsDeleted, Type)
VALUES 
( SYSDATETIME(), SYSDATETIME(), 'false', 'Action'),
( SYSDATETIME(), SYSDATETIME(), 'false', 'Roamnce'),
( SYSDATETIME(), SYSDATETIME(), 'false', 'Drama'),
( SYSDATETIME(), SYSDATETIME(), 'false', 'Horror'),
( SYSDATETIME(), SYSDATETIME(), 'false', 'Adventure'),
( SYSDATETIME(), SYSDATETIME(), 'false', 'Comedy'),
( SYSDATETIME(), SYSDATETIME(), 'false', 'Mistery')

SELECT * FROM Genres;