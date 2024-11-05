-- Active: 1730784061116@@34.69.59.37@8080@jtorres8

-- Creates the Student table 
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

INSERT INTO Course(
   courseID,
   courseName,
   courseCredit
)
Values (2315, 'C#', 3);
INSERT INTO Course VALUES (4360, 'OOAD', 3);
INSERT INTO Student VALUES (111, 'Alice'), (222, 'Bob');
INSERT INTO Enrollment VALUES (111, 2315, 'Fall2022'),(222, 4360,'Fall2022');

-- Join Tables with Foreign Keys
SELECT * FROM Course, Student, Enrollment
WHERE
   Course.courseID = Enrollment.courseID
   AND
   Student.studentID = Enrollment.studentID;

-- Update the courseName for courseID 2315
UPDATE Course
SET courseName = "Business App Development"
WHERE courseID = 2315;

-- Delete a Record 
DELETE FROM Enrollment
WHERE 
   studentID = 111
   AND
   courseID = 2315;

-- SQL view - used to view the data in a table 
CREATE VIEW StudentCourse AS
   SELECT studentName, courseName FROM Student, Course, Enrollment
   WHERE
      Student.studentID = Enrollment.studentID
      AND
      Course.courseID = Enrollment.courseID;

-- Select all records from the Student table
SELECT * FROM StudentCourse;