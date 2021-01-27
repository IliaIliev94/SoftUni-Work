CREATE DATABASE Passports

CREATE TABLE Passports
(
	PassportID INT PRIMARY KEY,
	PassportNumber CHAR(8) NOT NULL
)

CREATE TABLE Persons
(
	PersonID INT NOT NULL,
	FirstName VARCHAR(60) NOT NULL,
	Salary DECIMAL(15, 2) NOT NULL,
	PassportID INT
) 

INSERT INTO Passports (PassportId, PassportNumber)
	VALUES (101, 'N34FG21B'),
		   (102, 'K65LO4R7'),
		   (103, 'ZE657QP2')

INSERT INTO Persons (PersonId, FirstName, Salary, PassportId)
	VALUES (1, 'Roberto', 43300.00, 102),
		   (2, 'Tom', 56100.00, 103),
		   (3, 'Yana', 60200.00, 101)

ALTER TABLE Persons ADD CONSTRAINT PK_Persons PRIMARY KEY (PersonID)
ALTER TABLE Persons ADD CONSTRAINT FK_Passport FOREIGN KEY (PassportID) REFERENCES Passports (PassportID)
