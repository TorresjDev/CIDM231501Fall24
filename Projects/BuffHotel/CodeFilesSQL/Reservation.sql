-- ? Create Reservations Table
CREATE TABLE Reservations(
   ReservationId INT AUTO_INCREMENT PRIMARY KEY COMMENT 'PRIMARY KEY',
   RoomNumber INT NOT NULL COMMENT 'F.KEY to Rooms>RoomNumber NOT NULL',
   CustomerId INT NOT NULL COMMENT 'F.KEY to Customers>CustomerId NOT NULL',
   Status ENUM('CheckedIn', 'CheckedOut', 'OutOfService') NOT NULL DEFAULT 'Reserved' COMMENT 'NOT NULL',
   CheckInDate DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP COMMENT 'NOT NULL',
   FOREIGN KEY (RoomNumber) REFERENCES Rooms(RoomNumber),
   FOREIGN KEY (CustomerId) REFERENCES Customers(CustomerId)
) COMMENT 'Hotel Reservations Table';

ALTER TABLE Reservations 
   MODIFY COLUMN  CheckInDate DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP COMMENT 'NOT NULL';

-- ! Stored Procedures SQL
-- ? Get Reserved Rooms Procedure
-- This procedure returns the list of rooms that are reserved by customers who have an active reservation.
CREATE PROCEDURE GetReservedRoomsByActive()
BEGIN
      SELECT
         r.RoomNumber,
         c.Name AS CustomerName
      FROM
         Reservations AS res
      JOIN
         Rooms AS r ON res.RoomNumber = r.RoomNumber
      JOIN
         Customers AS c ON res.CustomerId = c.`CustomerId`
      WHERE
         r.IsAvailable = FALSE
         AND res.Status = 'Active';
END

-- ? Create Reservation Procedure

CREATE PROCEDURE CreateReservation(
   IN p_RoomNumber INT,
   IN p_CustomerName VARCHAR(50),
   IN p_CustomerEmail VARCHAR(75)
)

BEGIN

   DECLARE customerId INT;
   -- Insert customer details
   INSERT INTO Customers (Name, Email) VALUES (p_CustomerName, p_CustomerEmail);
   /*LAST_INSERT_ID is a MySQL function that returns the last auto-incremented column value which is the customerId*/
   SET customerId = LAST_INSERT_ID(); 
   -- Insert reservation details
   INSERT INTO Reservations (RoomNumber, CustomerId) VALUES (p_RoomNumber, customerId);
   -- Update the room status to Reserved
   UPDATE Rooms SET IsAvailable = FALSE WHERE RoomNumber = p_RoomNumber;

END //

-- Insert with CreateReservation Procedure
CALL CreateReservation(222, 'John Doe', 'joe2@mail.com')
CALL GetReservedRooms();

-- ? Check Out Reservation Procedure by RoomNumber
-- updates the status of the reservation to Completed by RoomNumber
-- also updates the room table > column IsAvailable to 1 (TRUE)

CREATE PROCEDURE CheckOutReservation(
   IN p_RoomNumber INT    
)
BEGIN 
   UPDATE Reservations SET Status = 'Completed' WHERE RoomNumber = p_RoomNumber;
   UPDATE Rooms SET IsAvailable = TRUE WHERE RoomNumber = p_RoomNumber;
END // 

CALL CheckOutReservation(222);

SHOW CREATE TABLE Reservations;
