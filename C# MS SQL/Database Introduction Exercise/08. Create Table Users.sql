CREATE TABLE Users 
(
	Id BIGINT PRIMARY KEY IDENTITY(1,1),
	Username VARCHAR(30) NOT NULL,
	[Password] VARCHAR(26) NOT NULL,
	ProfilePicture VARCHAR(MAX),
	LastLoginTime DATETIME2,
	IsDeleted BIT 
)

INSERT INTO Users (Username, [Password], ProfilePicture, LastLoginTime, IsDeleted)
	VALUES ('ivan_ivanov', '1234', 'https://cdn.business2community.com/wp-content/uploads/2017/08/blank-profile-picture-973460_640.png',
	'2021-01-17 12:34:35', 0)

INSERT INTO Users (Username, [Password], ProfilePicture, LastLoginTime, IsDeleted)
	VALUES ('bai_pesho', 'qwerty', 'https://cdn.business2community.com/wp-content/uploads/2017/08/blank-profile-picture-973460_640.png',
	'2021-01-17 15:34', 0)

INSERT INTO Users (Username, [Password], ProfilePicture, LastLoginTime, IsDeleted)
	VALUES ('batkata', 'azsumbatka', 'https://cdn.business2community.com/wp-content/uploads/2017/08/blank-profile-picture-973460_640.png',
	'2021-01-01 10:00:24', 1)

INSERT INTO Users (Username, [Password], ProfilePicture, LastLoginTime, IsDeleted)
VALUES ('user', '1234', 'https://images.unsplash.com/photo-1511367461989-f85a21fda167?ixid=MXwxMjA3fDB8MHxzZWFyY2h8M3x8cHJvZmlsZXxlbnwwfHwwfA%3D%3D&ixlib=rb-1.2.1&w=1000&q=80',
'2021-01-15 20:00:45', 0)

INSERT INTO Users (Username, [Password], ProfilePicture, LastLoginTime, IsDeleted)
VALUES ('Gosho', 'sm765802', 'https://images.unsplash.com/photo-1511367461989-f85a21fda167?ixid=MXwxMjA3fDB8MHxzZWFyY2h8M3x8cHJvZmlsZXxlbnwwfHwwfA%3D%3D&ixlib=rb-1.2.1&w=1000&q=80',
'2021-01-16 22:30', 0)