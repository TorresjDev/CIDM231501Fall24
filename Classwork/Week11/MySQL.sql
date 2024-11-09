-- Active: 1730784061116@@34.69.59.37@8080@jtorres8
-- !CRUD Operations
--? Create tables with SQL 
-- Create the tables
CREATE TABLE Student(
      studentID INT,
      studentName VARCHAR(50) NOT NULL, -- not null means that the value cannot be null i.e. value is required or value can not be empty
      PRIMARY KEY(studentID) -- Sets the primary key to studentID
);

CREATE TABLE Course (
      courseID INT,
      courseName VARCHAR(50) NOT NULL,
      courseCredit INT NOT NULL,
      PRIMARY KEY(courseID)
);

CREATE TABLE Enrollment (
   studentID INT NOT NULL,
   courseID INT NOT NULL,
   semester VARCHAR(20) NOT NULL,
   PRIMARY KEY(studentID, courseID),
   FOREIGN KEY(studentID) REFERENCES Student(studentID),
   FOREIGN KEY(courseID) REFERENCES Course(courseID) -- This line sets the foreign key for courseID to reference the courseID in the Course table
);

-- * SQL Store Procedures
--? Insert store procedure with SQL
-- Insert records into the tables
INSERT INTO Course(
   courseID,
   courseName,
   courseCredit
)
Values (2315, 'C#', 3);
INSERT INTO Course VALUES (4360, 'OOAD', 3);
INSERT INTO Student VALUES (111, 'Alice'), (222, 'Bob');
INSERT INTO Enrollment VALUES (111, 2315, 'Fall2022'),(222, 4360,'Fall2022');

--? Select store procedure with SQL
-- Select all records from the tables
-- Select all records from the Student table
SELECT * FROM StudentCourse;
SELECT * FROM Course, Student, Enrollment
WHERE
   Course.courseID = Enrollment.courseID
   AND
   Student.studentID = Enrollment.studentID;

   

--? Update store procedure with SQL
-- Update records in the tables
UPDATE Course
SET courseName = "Business App Development"
WHERE courseID = 2315;

-- Delete a Record 
--? Delete store procedure with SQL
-- Delete a record from the Enrollment table
DELETE FROM Enrollment
WHERE 
   studentID = 111
   AND
   courseID = 2315;

--? Create View store procedure with SQL
-- SQL view - used to view the data in a table 
-- Create a view that combines the Student, Course, and Enrollment tables into one view called StudentCourse
CREATE VIEW StudentCourse AS
   SELECT studentName, courseName FROM Student, Course, Enrollment
   WHERE
      Student.studentID = Enrollment.studentID
      AND
      Course.courseID = Enrollment.courseID;

