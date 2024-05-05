--CREATE DATABASE Spotify

--USE Spotify

CREATE TABLE Users(
Id INT PRIMARY KEY IDENTITY,
Name NVARCHAR(25) NOT NULL,
Surname NVARCHAR(25) DEFAULT 'XXX',
Gender VARCHAR(20),
Username VARCHAR(128) NOT NULL UNIQUE,
Password NVARCHAR(128) CHECK(LEN(Password)>=6)
)
INSERT INTO Users VALUES ('ANAR', 'AMANLI','MALE', 'anaramanli1','anar1234')
SELECT * FROM Users
DROP TABLE Users

CREATE TABLE Artists(
	Id INT IDENTITY PRIMARY KEY,
	Name nvarchar(32) NOT NULL,
	Surname nvarchar(32) NOT NULL,
	BirthDate DATETIME  NOT NULL,
	Gender NVARCHAR(10) NOT NULL,
)
drop table Artists
INSERT INTO Artists VALUES 
('IMAGINE', 'DRAGON', '1990-05-01', 'Male' ),
('DRAKE', 'Aubrey', '1986-10-24', 'Male'),
('One', 'Republic', '1986-10-24', 'Male')

CREATE TABLE Categories(
	Id INT PRIMARY KEY IDENTITY,
	Name NVARCHAR(25) NOT NULL UNIQUE
)
INSERT INTO Categories VALUES 
('HIP-HOP'),
('POP'),
('TECHNO')
CREATE TABLE Musics(
	Id INT PRIMARY KEY IDENTITY,
	Name NVARCHAR(25) NOT NULL,
	Duration VARCHAR(25)NOT NULL,
	CategoryId INT REFERENCES Categories(Id)
)
UPDATE Music
SET Name = @Name, Duration = @NewDuration
WHERE Id = @Id

INSERT INTO Musics VALUES ('IM STILL STANDING', 220,1)
DROP TABLE Musics
SELECT * FROM Musics
UPDATE 

CREATE TABLE ArtistMusics(
ArtistId INT REFERENCES Artists(Id),
MusicId INT REFERENCES Musics(Id )
)
DROP TABLE ArtistMusics
CREATE TABLE Playlists(
UserId INT REFERENCES Users(Id)  NOT NULL,
MusicId INT REFERENCES Musics(Id) NOT NULL
)
DROP TABLE Playlists

CREATE VIEW GetMusics
AS
SELECT m.Name,m.Duration,c.Name AS Category, a.Name AS Artist FROM Musics AS m
JOIN Categories AS c
ON m.CategoryId=c.Id
JOIN ArtistMusics As am
ON m.Id=am.MusicId
JOIN Artists AS a
ON am.ArtistId=a.Id

SELECT * FROM GetMusics

SELECT u.Username,m.Name,c.Name FROM Users AS u
JOIN Playlists AS p
ON u.Id=p.UserId
JOIN Musics AS m
ON p.MusicId=m.Id
JOIN Categories AS c
ON m.CategoryId=c.Id

SELECT Name,Duration FROM Musics
ORDER BY  Duration 

CREATE VIEW GetMusicCount
AS
SELECT COUNT(m.Name) AS [Count],a.Name AS ARTIST FROM Musics AS m
JOIN ArtistMusics As am
ON m.Id=am.MusicId
JOIN Artists AS a
ON am.ArtistId=a.Id
GROUP BY a.Name


SELECT [Count],ARTIST FROM GetMusicCount WHERE (SELECT MAX(Count) FROM GetMusicCount)=Count



INSERT INTO Musics VALUES('Thunder',300,1)

CREATE PROCEDURE CreateMusic(@name NVARCHAR(40), @duration INT,@catId INT)
AS
INSERT INTO Musics VALUES(@duration,@catId)


EXEC CreateMusic 'Test2',600,



