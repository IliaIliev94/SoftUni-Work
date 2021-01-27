CREATE DATABASE Hotel

CREATE TABLE Employees
(
	Id INT PRIMARY KEY,
	FirstName VARCHAR(60) NOT NULL,
	LastName VARCHAR(60) NOT NULL,
	Title VARCHAR(50),
	Notes VARCHAR(MAX)
)

CREATE TABLE Customers
(
	AccountNumber INT PRIMARY KEY,
	FirstName VARCHAR(60) NOT NULL,
	LastName VARCHAR(60) NOT NULL,
	PhoneNumber VARCHAR(15),
	EmergencyName VARCHAR(50),
	EmergencyNumber VARCHAR(15),
	Notes VARCHAR(MAX)
)

CREATE TABLE RoomStatus
(
	RoomStatus TINYINT UNIQUE NOT NULL,
	Notes VARCHAR(MAX)
)

CREATE TABLE RoomTypes
(
	RoomType VARCHAR(25) UNIQUE NOT NULL,
	Notes VARCHAR(MAX)
)

CREATE TABLE BedTypes
(
	BedType VARCHAR(25) UNIQUE NOT NULL,
	Notes VARCHAR(MAX)
)

CREATE TABLE Rooms
(
	RoomNumber SMALLINT PRIMARY KEY,
	RoomType VARCHAR(25) FOREIGN KEY REFERENCES RoomTypes(RoomType) NOT NULL,
	BedType VARCHAR(25) FOREIGN KEY REFERENCES BedTypes(BedType) NOT NULL,
	Rate TINYINT CHECK(Rate >= 0 AND Rate <= 10),
	RoomStatus TINYINT FOREIGN KEY REFERENCES RoomStatus(RoomStatus) NOT NULL,
	Notes VARCHAR(MAX)
)

CREATE TABLE Payments
(
	Id INT PRIMARY KEY,
	EmployeeId INT FOREIGN KEY REFERENCES Employees(Id) NOT NULL,
	PaymentDate DATE NOT NULL,
	AccountNumber INT FOREIGN KEY REFERENCES Customers(AccountNumber) NOT NULL,
	FirstDateOccupied DATE NOT NULL,
	LastDateOccupied DATE NOT NULL,
	TotalDays SMALLINT NOT NULL,
	AmountCharged DECIMAL(10, 2) NOT NULL,
	TaxRate TINYINT CHECK(TaxRate >= 0 AND TaxRate <= 100) NOT NULL,
	TaxAmount INT NOT NULL,
	PaymentAmount INT,
	Notes VARCHAR(MAX)
)

CREATE TABLE Occupancies
(
	Id INT PRIMARY KEY,
	EmployeeId INT FOREIGN KEY REFERENCES Employees(Id) NOT NULL,
	DateOccupied DATE NOT NULL,
	AccountNumber INT FOREIGN KEY REFERENCES Customers(AccountNumber) NOT NULL,
	RoomNumber SMALLINT FOREIGN KEY REFERENCES Rooms(RoomNumber) NOT NULL,
	RateApplied TINYINT CHECK(RateApplied >= 0 AND RateApplied <= 10),
	PhoneCharge DECIMAL (10, 2) NOT NULL,
	Notes VARCHAR(MAX)
)

INSERT INTO Employees(Id, FirstName, LastName, Title, Notes)
	VALUES(1, 'Ilia', 'Iliev', 'Programmer', 'My name is Ilia and I am a programmer!')
INSERT INTO Employees(Id, FirstName, LastName, Title, Notes)
	VALUES(2, 'Pesho', 'Ivanov', 'Receptionist', 'My name is Pesho and I am a receptionist!')
INSERT INTO Employees(Id, FirstName, LastName, Title, Notes)
	VALUES(3, 'Stamat', 'Petkov', 'Manager', 'My name is Stamat and I am a manager!')

INSERT INTO Customers(AccountNumber, FirstName, LastName, PhoneNumber, EmergencyName, EmergencyNumber, Notes)
	VALUES(1, 'Claudia', 'Williamson', '+35928562', 'Alexandra', '+35928261', 'My name is Claudia and I like Ilia!')
INSERT INTO Customers(AccountNumber, FirstName, LastName, PhoneNumber, EmergencyName, EmergencyNumber, Notes)
	VALUES(2, 'John', 'Smith', '+3298717', 'Jahna', '+325621', 'I am John!')
INSERT INTO Customers(AccountNumber, FirstName, LastName, PhoneNumber, EmergencyName, EmergencyNumber, Notes)
	VALUES(3, 'Jim', 'Jackson', '+51261', 'Stamat', '+3521521', 'I am Jim!')

INSERT INTO RoomStatus(RoomStatus, Notes)
	VALUES(0, 'Free room!')
INSERT INTO RoomStatus(RoomStatus, Notes)
	VALUES(1, 'Taken room!')
INSERT INTO RoomStatus(RoomStatus, Notes)
	VALUES(2, 'Free!')

INSERT INTO RoomTypes(RoomType, Notes)
	VALUES('Excellent', 'Excellent room!')
INSERT INTO RoomTypes(RoomType, Notes)
	VALUES('Good', 'Good room!')
INSERT INTO RoomTypes(RoomType, Notes)
	VALUES('Bad', 'Bad room!')

INSERT INTO BedTypes(BedType, Notes)
	VALUES('Excellent', 'Excellent bed!')
INSERT INTO BedTypes(BedType, Notes)
	VALUES('Good', 'Good bed!')
INSERT INTO BedTypes(BedType, Notes)
	VALUES('Bad', 'Bad bed!')

INSERT INTO Rooms(RoomNumber, RoomType, BedType, Rate, RoomStatus, Notes)
	VALUES(1, 'Excellent', 'Excellent', 10, 1, 'Excellent')
INSERT INTO Rooms(RoomNumber, RoomType, BedType, Rate, RoomStatus, Notes)
	VALUES(2, 'Good', 'Good', 8, 0, 'Very good room!')
INSERT INTO Rooms(RoomNumber, RoomType, BedType, Rate, RoomStatus, Notes)
	VALUES(3, 'Good', 'Good', 9, 0, 'Very good room!')

INSERT INTO Payments(Id, EmployeeId, PaymentDate, AccountNumber, FirstDateOccupied, LastDateOccupied,
TotalDays, AmountCharged, TaxRate, TaxAmount, PaymentAmount, Notes)
	VALUES(1, 1, '2021-01-19', 1, '2021-01-02', '2021-01-19', 17, 250, 20, 230, 2680, 'Very nice stay!')
INSERT INTO Payments(Id, EmployeeId, PaymentDate, AccountNumber, FirstDateOccupied, LastDateOccupied,
TotalDays, AmountCharged, TaxRate, TaxAmount, PaymentAmount, Notes)
	VALUES(2, 2, '2021-01-19', 2, '2021-01-02', '2021-01-19', 17, 340, 35, 288, 3500, 'Very nice stay!')
INSERT INTO Payments(Id, EmployeeId, PaymentDate, AccountNumber, FirstDateOccupied, LastDateOccupied,
TotalDays, AmountCharged, TaxRate, TaxAmount, PaymentAmount, Notes)
	VALUES(3, 3, '2021-01-19', 3, '2021-01-02', '2021-01-19', 17, 335, 35, 245, 3500, 'Good stay!')

INSERT INTO Occupancies(Id, EmployeeId, DateOccupied, AccountNumber, RoomNumber, RateApplied, PhoneCharge, Notes)
	VALUES(1, 1, '2021-01-17', 1, 1, 10, 20.5, 'Very nice stay!')
INSERT INTO Occupancies(Id, EmployeeId, DateOccupied, AccountNumber, RoomNumber, RateApplied, PhoneCharge, Notes)
	VALUES(2, 2, '2021-01-17', 2, 2, 9, 21, 'Very nice stay!')
INSERT INTO Occupancies(Id, EmployeeId, DateOccupied, AccountNumber, RoomNumber, RateApplied, PhoneCharge, Notes)
	VALUES(3, 3, '2021-01-17', 3, 3, 9, 21, 'Very nice stay!')