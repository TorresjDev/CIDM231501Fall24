/* Reservations table
   * Reservations Table is used to store the details of the reservations made by customers.
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
   * It inserts the customer details into the Customers table.
   * It inserts the reservation details into the Reservations table.
   * It updates the room status to Reserved in the Rooms table.
   */
CREATE PROCEDURE CreateReservation(
   IN p_RoomNumber INT,
   IN p_CustomerName VARCHAR(50),
   IN p_CustomerEmail VARCHAR(75)
)
/*
   CALL CreateReservation(222, 'John Doe', 'joe2@mail.com');
*/
BEGIN
   DECLARE customerId INT;
   INSERT INTO Customers (Name, Email) VALUES (p_CustomerName, p_CustomerEmail);
   SET customerId = LAST_INSERT_ID(); --LAST_INSERT_ID is a MySQL function that returns the last auto-incremented column value which is the customerId
   INSERT INTO Reservations (RoomNumber, CustomerId) VALUES (p_RoomNumber, customerId);
   UPDATE Rooms SET IsAvailable = FALSE WHERE RoomNumber = p_RoomNumber;
END //

/* Store Procedure GetReservedRoomsByActive
   * It returns the room number and the customer name of the customer who has reserved the room.
   * It joins the Reservations, Rooms, and Customers tables to get the required data.
   * It filters the rooms that are not available (IsAvailable = FALSE) and have an active reservation (Status = 'Active').
   */
CREATE PROCEDURE GetReservedRoomsByActive()
/*
   CALL GetReservedRoomsByActive();
*/
BEGIN
      SELECT
         r.RoomNumber,
         c.Name AS CustomerName
      FROM
         Reservations AS res
      JOIN
         Rooms AS r ON res.RoomNumber = r.RoomNumber
      JOIN
         Customers AS c ON res.CustomerId = c.CustomerId
      WHERE
         r.IsAvailable = FALSE
         AND res.Status = 'Active';
END

/* Store Procedure GetReservedRoomById
   * It returns the room number and the customer name of the customer who has reserved the room by RoomNumber.
   * It joins the Reservations, Rooms, and Customers tables to get the required data.
   * It filters the rooms that are not available (IsAvailable = FALSE) and have an active reservation (Status = 'Active').
   */
CREATE PROCEDURE GetReservedRoomById(
   IN p_RoomNumber INT
)
/*
   CALL GetReservedRoomById(222);
*/
BEGIN 
   SELECT
      r.RoomNumber,
      cust.Name as CustomerName
      
   FROM
      Reservations AS res
   JOIN
      Rooms AS r ON res.RoomNumber = p_RoomNumber
   JOIN
      Customers AS cust ON res.CustomerId = cust.CustomerId 
   WHERE 
      r.RoomNumber = p_RoomNumber
   AND 
      res.Status = 'Active';
END

/* Store Procedure CheckOutReservation
   * It updates the reservation status to 'Completed' in the Reservations table.
   * It updates the room status to 'Available' in the Rooms table.
   */
CREATE PROCEDURE CheckOutReservation(
   IN p_RoomNumber INT    
)
/*
   CALL CheckOutReservation(222);
*/
BEGIN 
   UPDATE Reservations SET Status = 'Completed' WHERE RoomNumber = p_RoomNumber;
   UPDATE Rooms SET IsAvailable = TRUE WHERE RoomNumber = p_RoomNumber;
END 