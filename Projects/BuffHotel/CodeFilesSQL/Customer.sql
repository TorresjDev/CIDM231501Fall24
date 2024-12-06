/* Customers table
   * Customers Table is used to store the details of the customers who have made reservations.
*/
CREATE TABLE Customers (
   CustomerId INT AUTO_INCREMENT PRIMARY KEY COMMENT 'PRIMARY KEY',
   Name VARCHAR(50) NOT NULL,
   Email VARCHAR(75) NOT NULL
) COMMENT 'Hotel Customers Table';

