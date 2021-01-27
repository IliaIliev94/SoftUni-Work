CREATE TABLE Categories
(
	Id INT PRIMARY KEY,
	CategoryName NVARCHAR(60) NOT NULL,
	DailyRate SMALLINT,
	WeeklyRate SMALLINT,
	MonthlyRate INT,
	WeekendRate SMALLINT
)

CREATE TABLE Cars
(
	Id INT PRIMARY KEY,
	PlateNumber NVARCHAR(20) NOT NULL,
	Manufacturer NVARCHAR(60) NOT NULL,
	Model NVARCHAR(60) NOT NULL,
	CarYear INT NOT NULL,
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
	Doors SMALLINT NOT NULL,
	Picture VARCHAR(MAX),
	Condition VARCHAR(10) CHECK(Condition = 'Excellent' OR Condition = 'Good' OR Condition = 'Fair' OR Condition = 'Poor') NOT NULL,
	Available BIT NOT NULL
)

CREATE TABLE Employees
(
	Id INT PRIMARY KEY,
	FirstName NVARCHAR(60) NOT NULL,
	LastName NVARCHAR(60) NOT NULL,
	Title NVARCHAR(40),
	Notes TEXT,
)

CREATE TABLE Customers
(
	Id INT PRIMARY KEY,
	DriverLicenseNumber NVARCHAR(60) NOT NULL,
	FullName NVARCHAR(120) NOT NULL,
	Address NVARCHAR(100),
	City NVARCHAR(85),
	ZipCode SMALLINT,
	Notes TEXT
)

CREATE TABLE RentalOrders
(
	Id INT PRIMARY KEY,
	EmployeeId INT FOREIGN KEY REFERENCES Employees(Id) NOT NULL,
	CustomerId INT FOREIGN KEY REFERENCES Customers(Id) NOT NULL,
	CarId INT FOREIGN KEY REFERENCES Cars(Id) NOT NULL,
	TankLevel DECIMAL(3,2) CHECK (TankLevel <= 1 AND TankLevel >= 0)NOT NULL,
	KilometrageStart DECIMAL(16, 2),
	KilometrageEnd DECIMAL(16, 2),
	TotalKilometers DECIMAL (16, 2),
	StartDate DATE,
	EndDate DATE,
	TotalDays INT,
	RateApplied DECIMAL(10, 2),
	TaxRate DECIMAL(10, 2),
	OrderStatus NVARCHAR(30),
	Notes Text
)

INSERT INTO Categories (Id, CategoryName, DailyRate, WeeklyRate, MonthlyRate, WeekendRate)
	VALUES(1, 'First', 50, 60, 30, 20)
INSERT INTO Categories (Id, CategoryName, DailyRate, WeeklyRate, MonthlyRate, WeekendRate)
	VALUES(2, 'Second', 40, 600, 303, 250)
INSERT INTO Categories (Id, CategoryName, DailyRate, WeeklyRate, MonthlyRate, WeekendRate)
	VALUES(3, 'Third', 40, 450, 150, 250)

INSERT INTO Cars (Id, PlateNumber, Manufacturer, Model, CarYear, CategoryId, Doors, Picture, Condition, Available)
	VALUES(1, 1234, 'Tesla', 'S', 2017, 1, 4, 'https://tesla-cdn.thron.com/delivery/public/image/tesla/35d15221-0a5f-4dce-b484-a4db67b81dd2/bvlatuR/std/0x0/model-s@2x',
	'Excellent', 1)
INSERT INTO Cars (Id, PlateNumber, Manufacturer, Model, CarYear, CategoryId, Doors, Picture, Condition, Available)
	VALUES(2, 12345, 'BWM', 'X5', 2010, 2, 4, 'https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/2021-bmw-x5-mmp-1-1600284201.jpg',
	'Excellent', 1)
INSERT INTO Cars (Id, PlateNumber, Manufacturer, Model, CarYear, CategoryId, Doors, Picture, Condition, Available)
	VALUES(3, 12345676, 'Hyundai', 'Ionic Electric', 2020, 3, 4, 'https://www.topgear.com/sites/default/files/styles/16x9_1280w/public/cars-car/image/2019/09/hyundai-new-ioniq-electric-02.jpg?itok=vVjIwIGX',
	'Excellent', 1)

INSERT INTO Employees (Id, FirstName, LastName, Title, Notes)
	VALUES(1, 'Ilia', 'Iliev', 'Programmer', 'I am Ilia and I am a programmer!')
INSERT INTO Employees (Id, FirstName, LastName, Title, Notes)
	VALUES(2, 'Claudia', 'Williams', 'Accountant', 'I am Claudia and I am an accountant!')
INSERT INTO Employees (Id, FirstName, LastName, Title, Notes)
	VALUES(3, 'John', 'Doe', 'Consultant', 'I am John and I am a consultant!')

INSERT INTO Customers (Id, DriverLicenseNumber, FullName, Address, City, ZipCode, Notes)
	VALUES(1, '12345', 'John Doe', 'Test', 'New York', 1234, 'Something')
INSERT INTO Customers (Id, DriverLicenseNumber, FullName, Address, City, ZipCode, Notes)
	VALUES(2, '123456', 'John Smith', 'Test Two', 'Sofia', 12345, 'My name is John!')
INSERT INTO Customers (Id, DriverLicenseNumber, FullName, Address, City, ZipCode, Notes)
	VALUES(3, '1234567', 'Joe Johnson', 'Test Three', 'Varna', 12345, 'Hello!')

INSERT INTO RentalOrders (Id, EmployeeId, CustomerId, CarId, TankLevel, KilometrageStart, KilometrageEnd, TotalKilometers,
StartDate, EndDate, TotalDays, RateApplied, TaxRate, OrderStatus, Notes)
	VALUES(1, 1, 2, 3, 1, 50.4, 100.5, 50.1, '2015-05-15', '2021-01-19', 300, 20.4, 20, 'Completed', 'Test')
INSERT INTO RentalOrders (Id, EmployeeId, CustomerId, CarId, TankLevel, KilometrageStart, KilometrageEnd, TotalKilometers,
StartDate, EndDate, TotalDays, RateApplied, TaxRate, OrderStatus, Notes)
	VALUES(2, 2, 1, 2, 0.4, 25.4, 75.5, 25.1, '2015-04-26', '2021-01-19', 300, 20.4, 20, 'Completed', 'Something')
INSERT INTO RentalOrders (Id, EmployeeId, CustomerId, CarId, TankLevel, KilometrageStart, KilometrageEnd, TotalKilometers,
StartDate, EndDate, TotalDays, RateApplied, TaxRate, OrderStatus, Notes)
	VALUES(3, 3, 3, 1, 0.2, 28.4, 250.5, 47.5, '2017-04-16', '2021-01-19', 300, 20.4, 20, 'Completed', 'Hello!')
