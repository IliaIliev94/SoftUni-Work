CREATE TABLE People
(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	[Name] NVARCHAR(200) NOT NULL,
	Picture NVARCHAR(MAX),
	Height DECIMAL(16,2),
	[Weight] DECIMAL(16,2),
	Gender VARCHAR(6) NOT NULL CHECK(Gender = 'Male' OR Gender = 'Female'),
	Birthdate DATE NOT NULL,
	Biography NVARCHAR(MAX)
)

INSERT INTO People(Name, Picture, Height, Weight, Gender, Birthdate, Biography) 
	VALUES('Ivan', 'https://images.unsplash.com/photo-1511367461989-f85a21fda167?ixid=MXwxMjA3fDB8MHxzZWFyY2h8M3x8cHJvZmlsZXxlbnwwfHwwfA%3D%3D&ixlib=rb-1.2.1&w=1000&q=80',
		1.80, 79.8,'Male', '1994-03-11', 'Hello! My name is Ivan and I am a student.')

INSERT INTO People(Name, Picture, Height, Weight, Gender, Birthdate, Biography) 
	VALUES('Pesho', 'https://cdn.business2community.com/wp-content/uploads/2017/08/blank-profile-picture-973460_640.png',
		1.85, 84.2, 'Male', '1994-03-11', 'Hello! My name is Pesho and I am a student.')

INSERT INTO People(Name, Picture, Height, Weight, Gender, Birthdate, Biography) 
	VALUES('Vesko', 'https://images.unsplash.com/photo-1511367461989-f85a21fda167?ixid=MXwxMjA3fDB8MHxzZWFyY2h8M3x8cHJvZmlsZXxlbnwwfHwwfA%3D%3D&ixlib=rb-1.2.1&w=1000&q=80',
		1.78, 72.45, 'Male', '1998-05-28', 'Hello! My name is Vesko and I am a worker.')

INSERT INTO People(Name, Picture, Height, Weight, Gender, Birthdate, Biography) 
	VALUES('Katya', 'https://images.unsplash.com/photo-1511367461989-f85a21fda167?ixid=MXwxMjA3fDB8MHxzZWFyY2h8M3x8cHJvZmlsZXxlbnwwfHwwfA%3D%3D&ixlib=rb-1.2.1&w=1000&q=80',
		1.65, 58.4, 'Female', '1995-05-28', NULL)

INSERT INTO People(Name, Picture, Height, Weight, Gender, Birthdate, Biography) 
	VALUES('Maria', 'https://cdn.business2community.com/wp-content/uploads/2017/08/blank-profile-picture-973460_640.png',
		1.70, 60, 'Female', '1994-09-18', 'Hello! My name is Maria.')