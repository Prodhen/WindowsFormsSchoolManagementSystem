Drop Table IF Exists Student
Create table Student
(
	StudentID INT PRIMARY KEY IDENTITY,
	firstName VARCHAR(30),
	lastName VARCHAR(30),
	Gender VARCHAR(10),
	DOB VARCHAR(20),
	Address VARCHAR(100),
	Image VARCHAR (100)
)
Go