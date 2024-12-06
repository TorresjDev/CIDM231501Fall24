/* Rooms Table
   * It stores the information of the rooms in the hotel.
*/
CREATE TABLE Rooms(  
    RoomNumber INT NOT NULL PRIMARY KEY COMMENT 'Primary Key NOT NULL',
    Capacity INT NOT NULL COMMENT 'NOT NULL',
    IsAvailable TINYINT NOT NULL DEFAULT 1 COMMENT 'NOT NULL'
) COMMENT 'Hotel Rooms Table';


/* Store Procedure GetAvailableRooms
   * It returns the room number and the capacity of the rooms that are available.
   * It filters the rooms that are available (IsAvailable = TRUE).
   */
CREATE PROCEDURE GetAllRooms()
/* 
   CALL GetAllRooms();
*/
BEGIN   
      SELECT * FROM Rooms;   
END

/* Store Procedure GetAvailableRooms
   * It returns the room number and the capacity of the rooms that are available.
   * It filters the rooms that are available (IsAvailable = TRUE).
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
