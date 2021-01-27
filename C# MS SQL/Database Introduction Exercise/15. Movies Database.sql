CREATE DATABASE Movies

USE Movies CREATE TABLE Directors
(
	Id INT PRIMARY KEY,
	DirectorName NVARCHAR(60) NOT NULL,
	Notes TEXT
)

USE Movies CREATE TABLE Genres
(
	Id INT PRIMARY KEY,
	GenreName NVARCHAR(30) NOT NULL,
	Notes TEXT
)

USE Movies CREATE TABLE Categories
(
	Id INT PRIMARY KEY,
	CategoryName NVARCHAR(50) NOT NULL,
	Notes TEXT
)

USE Movies CREATE TABLE Movies
(
	Id INT PRIMARY KEY,
	Title NVARCHAR(200) NOT NULL,
	DirectorKey INT FOREIGN KEY REFERENCES Directors(Id) NOT NULL,
	CopyrightYear SMALLINT,
	[Length] TIME,
	GenreId INT FOREIGN KEY REFERENCES Genres(Id) NOT NULL,
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id) NOT NULL,
	Rating SMALLINT,
	Notes TEXT
)

INSERT INTO Directors (Id, DirectorName, Notes) VALUES (1, 'John Doe', 'Notes....')
INSERT INTO Directors (Id, DirectorName, Notes) VALUES (2, 'Mr.Smith', 'Mr.Smith''s notes.')
INSERT INTO Directors (Id, DirectorName, Notes) VALUES (3, 'Ilia Iliev', 'The notes of Mr.Iliev.')
INSERT INTO Directors (Id, DirectorName, Notes) VALUES (4, 'Valio', 'The notes of Valio.')
INSERT INTO Directors (Id, DirectorName, Notes) VALUES (5, 'Nqkoi', 'Nqkoi wrote....')

INSERT INTO Genres (Id, GenreName, Notes) VALUES (1, 'Science Fiction', 'Fantasy plus Science.')
INSERT INTO Genres (Id, GenreName, Notes) VALUES (2, 'Horror', 'Movies that scare people.')
INSERT INTO Genres (Id, GenreName, Notes) VALUES (3, 'Fantasy', 'For people that like imagination.')
INSERT INTO Genres (Id, GenreName, Notes) VALUES (4, 'Action', 'For people that like fighting and action.')
INSERT INTO Genres (Id, GenreName, Notes) VALUES (5, 'Adventure', 'Movies containing adventures.')

INSERT INTO Categories (Id, CategoryName, Notes) VALUES (1, 'First', 'First category.')
INSERT INTO Categories (Id, CategoryName, Notes) VALUES (2, 'Second', 'Second category.')
INSERT INTO Categories (Id, CategoryName, Notes) VALUES (3, 'Third', 'Third category.')
INSERT INTO Categories (Id, CategoryName, Notes) VALUES (4, 'Fourth', 'Fourth category.')
INSERT INTO Categories (Id, CategoryName, Notes) VALUES (5, 'Fifth', 'Fifth category.')

INSERT INTO Movies (Id, Title, DirectorKey, CopyrightYear, [Length], GenreId, CategoryId, Rating, Notes) 
	VALUES (1, 'District 9', 3, 2010, '02:00', 1, 2, 9, 'Very good movie!')
INSERT INTO Movies (Id, Title, DirectorKey, CopyrightYear, [Length], GenreId, CategoryId, Rating, Notes) 
	VALUES (2, 'Alien', 3, 1979, '03:00', 1, 4, 10, 'Excellent movie!')
INSERT INTO Movies (Id, Title, DirectorKey, CopyrightYear, [Length], GenreId, CategoryId, Rating, Notes) 
	VALUES (3, 'Lord of the Rings: Fellowship of the Ring', 3, 2001, '03:00', 3, 5, 10, 'Excellent movie!')
INSERT INTO Movies (Id, Title, DirectorKey, CopyrightYear, [Length], GenreId, CategoryId, Rating, Notes) 
	VALUES (4, 'The Terminator', 2, 1984, '01:45', 4, 3, 9, 'Very good movie!')
INSERT INTO Movies (Id, Title, DirectorKey, CopyrightYear, [Length], GenreId, CategoryId, Rating, Notes) 
	VALUES (5, 'The Predator', 1, 1987, '02:05', 1, 2, 10, 'Excellent movie!')