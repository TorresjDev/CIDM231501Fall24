-- ? Used to create the Rooms table in the database
CREATE TABLE Rooms(  
    roomNumber INT NOT NULL PRIMARY KEY COMMENT 'Primary Key NOT NULL',
    capacity INT NOT NULL COMMENT 'NOT NULL',
    status VARCHAR(20) NOT NULL COMMENT 'NOT NULL',
    customer_name VARCHAR(30) NULL COMMENT 'NULLABLE',
    customer_email VARCHAR(50) NULL COMMENT 'NULLABLE',
    create_time DATETIME COMMENT 'Date Created'
    
) COMMENT 'Hotel Rooms Table';

-- ? Used to update the Rooms table in the database
ALTER TABLE Rooms
   --  MODIFY roomNumber INT  COMMENT 'Primary Key NOT NULL'
   --  MODIFY capacity INT NOT NULL COMMENT 'NOT NULL'
   --  MODIFY status VARCHAR(20) NOT NULL COMMENT 'NOT NULL'
   --  MODIFY customer_name VARCHAR(30) NULL COMMENT 'NULLABLE'
   --  MODIFY customer_email VARCHAR(50) NULL COMMENT 'NULLABLE'
   --  MODIFY create_time DATETIME COMMENT 'Date Created'
 COMMENT 'Hotel Rooms Table';