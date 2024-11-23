-- *****SQL COMMANDS******

-- Use to create a new table
CREATE TABLE <table_name> (
    <column_name> <data_type> <constraints> <default_value> COMMENT '<comment>',
);

-- Use to create a stored procedure
CREATE PROCEDURE <procedure_name>()
BEGIN
    -- SQL Query
END;

-- Use update a table by modifying a column
ALTER TABLE <table_name>
     MODIFY <column_name> <data_type> <constraints> <default_value> COMMENT '<comment>';

CALL <procedure_name>(); -- Call the procedure

-- Use to drop the procedure if it already exists
DROP PROCEDURE IF EXISTS <procedure_name>;




