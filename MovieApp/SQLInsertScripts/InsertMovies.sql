use MovieDataBase;

DELETE FROM Movies;

INSERT INTO Movies(CreateTime, UpdatedTime, IsDeleted, premierDate, premierLocation)
VALUES 
( SYSDATETIME(), SYSDATETIME(), 'false', CONVERT(DATETIME, '2010-10-15', 102), 'Los Angeles'),
( SYSDATETIME(), SYSDATETIME(), 'false', CONVERT(DATETIME, '2000-10-15', 102), 'Canada'),
( SYSDATETIME(), SYSDATETIME(), 'false', CONVERT(DATETIME, '2020-10-15', 102), 'New York'),
( SYSDATETIME(), SYSDATETIME(), 'false', CONVERT(DATETIME, '2021-10-15', 102), 'Bucuresti'),
( SYSDATETIME(), SYSDATETIME(), 'false', CONVERT(DATETIME, '2018-10-15', 102), 'Las vegas')

SELECT * FROM Movies;