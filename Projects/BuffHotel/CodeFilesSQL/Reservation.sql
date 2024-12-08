/* Reservations table
   * Used to store the details of the room and reservations made by customers.
*/
CREATE TABLE Reservations(
   ReservationId INT AUTO_INCREMENT PRIMARY KEY COMMENT 'PRIMARY KEY',
   RoomNumber INT NOT NULL COMMENT 'F.KEY to Rooms>RoomNumber NOT NULL',
   CustomerId INT NOT NULL COMMENT 'F.KEY to Customers>CustomerId NOT NULL',
   Status ENUM('CheckedIn', 'CheckedOut', 'OutOfService') NOT NULL DEFAULT 'Reserved' COMMENT 'NOT NULL',
   CheckInDate DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP COMMENT 'NOT NULL',
   FOREIGN KEY (RoomNumber) REFERENCES Rooms(RoomNumber),
   FOREIGN KEY (CustomerId) REFERENCES Customers(CustomerId)
) COMMENT 'Hotel Reservations Table';

/* Store Procedure CreateReservation 
   * Inserts customer details into Customers table.
   * Inserts reservation details into Reservations table.
   * Updates room status to Reserved in Rooms table.
   */
CREATE PROCEDURE CreateReservation(
   IN p_RoomNumber INT,
   IN p_CustomerName VARCHAR(50),
   IN p_CustomerEmail VARCHAR(75)
)
/*
   CALL CreateReservation(101, 'John Doe', 'joe2@mail.com');
*/
BEGIN
   DECLARE customerId INT;
   INSERT INTO Customers (Name, Email) 
      VALUES (p_CustomerName, p_CustomerEmail);
   SET customerId = LAST_INSERT_ID(); --LAST_INSERT_ID is a MySQL function that returns the last auto-incremented column value which is the customerId
   INSERT INTO Reservations (RoomNumber, CustomerId, CheckInDate) 
      VALUES (p_RoomNumber, customerId, CURRENT_TIMESTAMP);
   UPDATE Rooms SET IsAvailable = FALSE 
      WHERE RoomNumber = p_RoomNumber;
END

/* Store Procedure GetAllReservations
   * Return all reservation details.
   */
CREATE PROCEDURE GetAllReservations()
/*
   CALL GetAllReservations();
*/
BEGIN
   SELECT
      res.ReservationId,
      r.RoomNumber,
      c.Name AS CustomerName,
      res.Status,
      res.CheckInDate
   FROM
      Reservations AS res
   JOIN
      Rooms AS r ON res.RoomNumber = r.RoomNumber
   JOIN
      Customers AS c ON res.CustomerId = c.CustomerId;
END

/* Store Procedure CheckOutReservation
   * Updates reservation status to Completed.
   */
CREATE PROCEDURE CheckOutReservation(
   IN p_RoomNumber INT    
)
/*
   CALL CheckOutReservation(101);
*/
BEGIN 
   UPDATE Reservations 
      SET 
         Status = 'Completed',
         CheckOutDate = CURRENT_TIMESTAMP
      WHERE RoomNumber = p_RoomNumber;
         UPDATE Rooms 
            SET IsAvailable = TRUE 
         WHERE RoomNumber = p_RoomNumber;
END 
-- Reset the auto-increment value for the Reservations table
ALTER TABLE Reservations AUTO_INCREMENT = 1;
-- Delete all data from the Reservations table
TRUNCATE TABLE Reservations;
