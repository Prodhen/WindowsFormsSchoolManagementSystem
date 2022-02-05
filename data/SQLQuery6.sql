Drop Table IF Exists Student
Create table Student
(
	StudentID INT PRIMARY KEY IDENTITY,
	firstName VARCHAR(30),
	lastName VARCHAR(30),
	Gender VARCHAR(10),
	DOB VARCHAR(20),
	ClassID VARCHAR(20),
	Shift VARCHAR(20),
	ParentsNID int FOREIGN KEY REFERENCES Parent(NID) ON DELETE CASCADE ON UPDATE CASCADE,
	Address VARCHAR(100),
	Image VARCHAR (100)
	
)
Go
Drop Table IF Exists Class
Create table Class
(
	ClassId INT PRIMARY KEY IDENTITY,
	Name VARCHAR(30),
	SeatCapacity int,
	Section VARCHAR(10),
	Adviser VARCHAR(20),
	RoomNo int
	
)
Go
Drop Table IF Exists Parent
Create table Parent
(
	ParentID INT PRIMARY KEY IDENTITY,
	Name VARCHAR(30),
	NID int Unique,
	Phone VARCHAR(10),
	Email VARCHAR(20),
	Occupation VARCHAR(100),
	Income int,
	Address VARCHAR (100)
	
	
)
Go
Drop Table IF Exists Teacher
Create table Teacher
(
	TeacherID INT PRIMARY KEY IDENTITY,
	Name VARCHAR(30),
	FatherName VARCHAR(30),
	Subject VARCHAR(10),
	JoiningDate VARCHAR(20),
	DOB VARCHAR(100),
	Email VARCHAR(20),
	Mobile VARCHAR(20),
	Address VARCHAR (100),
	Image VARCHAR (100)
	
)
Go
Drop Table IF Exists User1
Create table User1
(
	User1 INT PRIMARY KEY IDENTITY,
	Name VARCHAR(30),
	Password int
	
)
Go
insert into User1(Name,Password)
values ('Arosh', 5050)
select * from User1