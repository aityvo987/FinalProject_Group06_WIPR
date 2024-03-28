DROP TABLE IF EXISTS Lecturer;
DROP TABLE IF EXISTS Student;
DROP TABLE IF EXISTS Account;
DROP TABLE IF EXISTS Topic;
DROP TABLE IF EXISTS Major;

CREATE TABLE Lecturer (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(100),
    DateofBirth DateTime,
    Email VARCHAR(100),
    Phone INT,
    CitizenId INT,
    Address VARCHAR(255),
    Major INT
);

CREATE TABLE Student (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(100),
    DateofBirth DateTime,
    Email VARCHAR(100),
    Phone INT,
    CitizenId INT,
    Address VARCHAR(255),
    Major INT,
    GPAPoint FLOAT
);

CREATE TABLE Account (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Username VARCHAR(20),
    Password VARCHAR(100),
    MemberId INT,
    Role INT
);

CREATE TABLE Topic (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(100),
    Major INT,
    Type VARCHAR(20),
    Description VARCHAR(200),
    Requirement VARCHAR(200),
    Student1 VARCHAR(20),
    Student2 VARCHAR(20),
    Student3 VARCHAR(20),
    Instructor VARCHAR(20),
    ThesisLecturer VARCHAR(20),
    Semester INT,
    Year INT,
    Status INT,
);

CREATE TABLE Major (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(100)
);

INSERT INTO Lecturer(Name, DateofBirth, Email, Phone, CitizenId, Address, Major)
VALUES ('Nguyen Van Bay', '2003-03-02', 'baydep@gmail.com', 12, 201110011, '110 Hoang Dieu', 1);

INSERT INTO Student(Name, DateofBirth, Email, Phone, CitizenId, Address, Major, GPAPoint)
VALUES ('Hoang Le Minh', '2003-03-02', 'bayde222p@gmail.com',14 , 203120011, '112 Hoang Dieu', 1, 8.1);

INSERT INTO Account(Username, Password, MemberId, Role)
VALUES ('lecturer01', '123456', 1, 2);

INSERT INTO Account(Username, Password, MemberId, Role)
VALUES ('student01', '123456', 1, 1);


INSERT INTO Topic(Name, Major, Type,Description, Requirement, Student1, Student2, Student3, Instructor, ThesisLecturer, Semester, Year,Status)
VALUES ('Developing E-Commerce Website Selling Electrical Using ReactJS', 0, 'Web Application','ReactJS Web','GPA >7.0', NULL, NULL, NULL, '1', '1', 1, 2023,0);

INSERT INTO Major(Name)
VALUES ('Software Engineering');
INSERT INTO Major(Name)
VALUES ('Information Security');