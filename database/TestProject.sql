CREATE DATABASE TestProject

use master
DROP DATABASE TestProject
go

use TestProject
Go
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
	ParentsNID VARCHAR(20),
	Address VARCHAR(100),
	Image VARCHAR (100)
	--CourseID int FOREIGN KEY REFERENCES Course(CourseID)
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
	RoomNo VARCHAR(100)
	
)
Go
Drop Table IF Exists Parent
Create table Parent
(
	ParentID INT PRIMARY KEY IDENTITY,
	Name VARCHAR(30),
	NID VARCHAR(30),
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
Drop Table IF Exists Teacher
Create table User
(
	TeacherID INT PRIMARY KEY IDENTITY,
	Name VARCHAR(30),
	Password int
	
)
Go
