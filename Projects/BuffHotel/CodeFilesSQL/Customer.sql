-- ? Create Customers table
CREATE TABLE Customers (
   CustomerId INT AUTO_INCREMENT PRIMARY KEY COMMENT 'PRIMARY KEY',
   Name VARCHAR(50) NOT NULL,
   Email VARCHAR(75) NOT NULL
) COMMENT 'Hotel Customers Table';