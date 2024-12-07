/* Rooms Table
   * Used to store the details of the hotel rooms.
*/
CREATE TABLE Rooms(  
    RoomNumber INT NOT NULL PRIMARY KEY COMMENT 'Primary Key NOT NULL',
    Capacity INT NOT NULL COMMENT 'NOT NULL',
    IsAvailable TINYINT NOT NULL DEFAULT 1 COMMENT 'NOT NULL'
) COMMENT 'Hotel Rooms Table';

-- Insert Data into Rooms Table
INSERT INTO Rooms (RoomNumber, Capacity) VALUES (110, 6);

/* Store Procedure GetAvailableRooms
   * GET All the Rooms in the Hotel Rooms Table
   */
CREATE PROCEDURE GetAllRooms()
/* 
   CALL GetAllRooms();
*/
BEGIN   
      SELECT * FROM Rooms;   
END

/* Store Procedure GetAvailableRooms
   * GET All Available Rooms in the Hotel Rooms Table
   */
CREATE PROCEDURE GetAvailableRooms()
/* 
   CALL GetAvailableRooms();
*/
BEGIN   
      SELECT 
            RoomNumber,
            Capacity
       FROM Rooms Where IsAvailable = 1;   
END

/* Store Procedure UpdateRooms by ID
   * UPDATES Room property Capacity or IsAvailable status by RoomNumber.
   */
CREATE PROCEDURE UpdateRoomById(
   IN p_RoomNumber INT,
   IN p_Capacity INT,
   IN p_IsAvailable TINYINT
)
/* 
   CALL UpdateRoomById(100, 1, 1);
*/
BEGIN
      UPDATE Rooms SET 
         Capacity = p_Capacity, 
         IsAvailable = COALESCE(p_IsAvailable, TRUE)
      WHERE 
         RoomNumber = p_RoomNumber;
END

