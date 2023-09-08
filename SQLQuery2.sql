CREATE  DATABASE FINAL
GO
USE FINAL
GO
CREATE TABLE students
(
	id INT PRIMARY KEY IDENTITY,
	name VARCHAR(50) NOT NULL,
	roll INT NOT NULL
)
GO
CREATE TABLE Subjects
(
	id INT PRIMARY KEY IDENTITY,
	name VARCHAR(50) NOT NULL
)
GO
CREATE TABLE result
(
	studentId INT,
	subjectId INT,
	result INT,
	PRIMARY KEY(studentId,subjectId) 
)
GO
CREATE TABLE tutors
(
	tutorId INT PRIMARY KEY IDENTITY,
	tutorName NVARCHAR(50) NOT NULL,
	tutorContact NVARCHAR(20) NOT NULL,
	tutorEmail NVARCHAR(30) NOT NULL,
	picture VARBINARY(MAX) NULL,
	dob Date NOT NULL,
	gender BIT NOT NULL,
	salary INT NOT NULL,
	subjectId INT REFERENCES subjects(id)
)
GO

SELECT id,name FROM Subjects
GO
SELECT * FRom tutors
GO
INSERT INTO tutors(tutorName,tutorContact,tutorEmail,picture,dob,gender, salary,subjectId) VALUES
('name','contact','email','picture','dob','gender','salary','subjectId')
GO
SELECT tutorId,tutorName,tutorContact,tutorEmail,picture,subjectId FROM tutors
SELECT tutorId,tutorName,tutorContact,tutorEmail,picture,subjectId FROM tutors WHERE tutorId=1
GO
UPDATE tutors SET tutorName='',tutorContact='',tutorEmail='',picture='',subjectId='' WHERE tutorId=1
GO
SELECT t.tutorId,t.tutorName,t.tutorContact,t.tutorEmail,t.picture,s.name FROM tutors t INNER JOIN Subjects s ON t.subjectId=s.id

select * from tutors
go

select t.tutorId,t.tutorName,t.tutorContact,t.tutorEmail,t.dob,t.gender,t.salary,t.picture,s.name from 
tutors t inner join Subjects s ON t.subjectId=s.id