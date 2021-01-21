use MovieDataBase;

DELETE FROM Productions;

INSERT INTO Productions (CreateTime, UpdatedTime, IsDeleted, Name)
VALUES 
( SYSDATETIME(), SYSDATETIME(), 'false', 'FilmMaking'),
( SYSDATETIME(), SYSDATETIME(), 'false', '20th Century Fox'),
( SYSDATETIME(), SYSDATETIME(), 'false', 'Universal Pictures')

SELECT * FROM Productions;