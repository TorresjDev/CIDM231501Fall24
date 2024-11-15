-- ? Create Rooms table
CREATE TABLE Rooms(  
    RoomNumber INT NOT NULL PRIMARY KEY COMMENT 'Primary Key NOT NULL',
    Capacity INT NOT NULL COMMENT 'NOT NULL',
    IsAvailable TINYINT NOT NULL DEFAULT 1 COMMENT 'NOT NULL'
) COMMENT 'Hotel Rooms Table';

-- ? Update Rooms table to add a new column

--  ? Insert data into Rooms table
INSERT INTO Rooms (RoomNumber, Capacity) VALUES (666, 4);


-- ! Stored Procedures SQL
-- ? Get Available Rooms Procedure
CREATE PROCEDURE GetAvailableRooms()
BEGIN   
      SELECT * FROM Rooms Where IsAvailable = 1;   
END