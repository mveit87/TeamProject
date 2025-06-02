USE master;
If DB_ID('UniversityDB') IS NOT NULL DROP DATABASE UniversityDB;
CREATE DATABASE UniversityDB;
GO
USE UniversityDB;
-- Create Schema
USE UniversityDB;
    GO



-- Create Users Table
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Users]') AND type in (N'U'))
BEGIN
    CREATE TABLE Users (
        UserID INT PRIMARY KEY IDENTITY(1,1),
        Username VARCHAR(50) NOT NULL UNIQUE,
        PasswordHash VARCHAR(255) NOT NULL,
        UserType VARCHAR(20) CHECK (UserType IN ('Administrator', 'Faculty', 'Student')) NOT NULL,
        CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP
    );
END

-- Create Courses Table
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Courses]') AND type in (N'U'))
BEGIN
    CREATE TABLE Courses (
        CourseID INT PRIMARY KEY IDENTITY(1,1),
        CourseName VARCHAR(100) NOT NULL,
        Credits INT NOT NULL,
        Semester VARCHAR(10) CHECK (Semester IN ('Fall', 'Spring', 'Summer')) NOT NULL,
        Prerequisites VARCHAR(255),
        CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP
    );
END

-- Create Applications Table
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Applications]') AND type in (N'U'))
BEGIN
    CREATE TABLE Applications (
        ApplicationID INT PRIMARY KEY IDENTITY(1,1),
        StudentID INT,
        Status VARCHAR(10) CHECK (Status IN ('Pending', 'Accepted', 'Rejected')) DEFAULT 'Pending',
        CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP,
        FOREIGN KEY (StudentID) REFERENCES Users(UserID)
    );
END

-- Create Enrollments Table
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Enrollments]') AND type in (N'U'))
BEGIN
    CREATE TABLE Enrollments (
        EnrollmentID INT PRIMARY KEY IDENTITY(1,1),
        StudentID INT,
        CourseID INT,
        Grade CHAR(2),
        Attendance INT,
        FOREIGN KEY (StudentID) REFERENCES Users(UserID),
        FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
    );
END

-- Create DegreeAudit Table
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DegreeAudit]') AND type in (N'U'))
BEGIN
    CREATE TABLE DegreeAudit (
        AuditID INT PRIMARY KEY IDENTITY(1,1),
        StudentID INT,
        TotalCredits INT DEFAULT 0,
        GraduationDate DATE,
        FOREIGN KEY (StudentID) REFERENCES Users(UserID)
    );
END

-- Create FacultyCourses Table
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FacultyCourses]') AND type in (N'U'))
BEGIN
    CREATE TABLE FacultyCourses (
        FacultyCourseID INT PRIMARY KEY IDENTITY(1,1),
        FacultyName VARCHAR(100) NOT NULL,
        FacultyID INT,
        CourseName VARCHAR(100) NOT NULL,
        CourseID INT,
        FOREIGN KEY (FacultyID) REFERENCES Users(UserID),
        FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
    );
END

-- Demo Data: Courses
INSERT INTO Courses (CourseName, Credits, Semester) VALUES ('Web Design', 3, 'Fall'); 
INSERT INTO Courses (CourseName, Credits, Semester) VALUES ('Advanced Agile Software Development', 4, 'Spring'); 
INSERT INTO Courses (CourseName, Credits, Semester) VALUES ('Business Finance', 3, 'Fall'); 
INSERT INTO Courses (CourseName, Credits, Semester) VALUES ('Cybercrime', 3, 'Spring'); 
INSERT INTO Courses (CourseName, Credits, Semester) VALUES ('Business Communication', 3, 'Fall'); 
INSERT INTO Courses (CourseName, Credits, Semester) VALUES ('Project Development', 3, 'Spring');

-- Demo Data: Users
INSERT INTO Users (Username, PasswordHash, UserType) VALUES ('studentWhiskey', '12345', 'Student');
INSERT INTO Users (Username, PasswordHash, UserType) VALUES ('studentTango', '12345', 'Student');
INSERT INTO Users (Username, PasswordHash, UserType) VALUES ('studentFoxtrot', '12345', 'Student');
INSERT INTO Users (Username, PasswordHash, UserType) VALUES ('facultyAlpha', '12345', 'Faculty');
INSERT INTO Users (Username, PasswordHash, UserType) VALUES ('facultyBeta', '12345', 'Faculty');
INSERT INTO Users (Username, PasswordHash, UserType) VALUES ('facultyCharlie', '12345', 'Faculty');
INSERT INTO Users (Username, PasswordHash, UserType) VALUES ('admin', 'admin', 'Administrator');

-- Demo Data: Enrollments
INSERT INTO Enrollments (StudentID, CourseID, Grade, Attendance) VALUES ((SELECT UserID FROM Users WHERE Username LIKE 'studentWhiskey'), (SELECT CourseID FROM Courses WHERE CourseName LIKE 'Cybercrime'), 'A', 12);
INSERT INTO Enrollments (StudentID, CourseID, Grade, Attendance) VALUES ((SELECT UserID FROM Users WHERE Username LIKE 'studentTango'), (SELECT CourseID FROM Courses WHERE CourseName LIKE 'Web Design'), 'B', 8);
INSERT INTO Enrollments (StudentID, CourseID, Grade, Attendance) VALUES ((SELECT UserID FROM Users WHERE Username LIKE 'studentFoxtrot'), (SELECT CourseID FROM Courses WHERE CourseName LIKE 'Cybercrime'), 'D', 2);

-- Demo Data: FacultyCourses
INSERT INTO FacultyCourses (FacultyName, FacultyID, CourseName, CourseID) VALUES ((SELECT Username FROM Users WHERE Username LIKE 'facultyAlpha'), (SELECT UserID FROM Users WHERE Username LIKE 'facultyAlpha'), (SELECT CourseName FROM Courses WHERE CourseName LIKE 'Cybercrime'), (SELECT CourseID FROM Courses WHERE CourseName LIKE 'Cybercrime'));
INSERT INTO FacultyCourses (FacultyName, FacultyID, CourseName, CourseID) VALUES ((SELECT Username FROM Users WHERE Username LIKE 'facultyAlpha'), (SELECT UserID FROM Users WHERE Username LIKE 'facultyAlpha'), (SELECT CourseName FROM Courses WHERE CourseName LIKE 'Business Communication'), (SELECT CourseID FROM Courses WHERE CourseName LIKE 'Business Communication'));
INSERT INTO FacultyCourses (FacultyName, FacultyID, CourseName, CourseID) VALUES ((SELECT Username FROM Users WHERE Username LIKE 'facultyAlpha'), (SELECT UserID FROM Users WHERE Username LIKE 'facultyAlpha'), (SELECT CourseName FROM Courses WHERE CourseName LIKE 'Business Finance'), (SELECT CourseID FROM Courses WHERE CourseName LIKE 'Business Finance'));
INSERT INTO FacultyCourses (FacultyName, FacultyID, CourseName, CourseID) VALUES ((SELECT Username FROM Users WHERE Username LIKE 'facultyBeta'), (SELECT UserID FROM Users WHERE Username LIKE 'facultyBeta'), (SELECT CourseName FROM Courses WHERE CourseName LIKE 'Web Design'), (SELECT CourseID FROM Courses WHERE CourseName LIKE 'Web Design'));
INSERT INTO FacultyCourses (FacultyName, FacultyID, CourseName, CourseID) VALUES ((SELECT Username FROM Users WHERE Username LIKE 'facultyCharlie'), (SELECT UserID FROM Users WHERE Username LIKE 'facultyCharlie'), (SELECT CourseName FROM Courses WHERE CourseName LIKE 'Advanced Agile Software Development'), (SELECT CourseID FROM Courses WHERE CourseName LIKE 'Advanced Agile Software Development'));
INSERT INTO FacultyCourses (FacultyName, FacultyID, CourseName, CourseID) VALUES ((SELECT Username FROM Users WHERE Username LIKE 'facultyCharlie'), (SELECT UserID FROM Users WHERE Username LIKE 'facultyCharlie'), (SELECT CourseName FROM Courses WHERE CourseName LIKE 'Project Development'), (SELECT CourseID FROM Courses WHERE CourseName LIKE 'Project Development'));