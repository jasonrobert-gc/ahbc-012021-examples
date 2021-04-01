-- Create a database called Assessment4Prep
CREATE DATABASE Assessment4Prep;

-- Create a Customer table
--     - Id - INT, auto increment (Primary Key)
--     - Name - NVARCHAR(50)
--     - Phone - NVARCHAR(30)
--     - Email - NVARCHAR(30)

CREATE TABLE dbo.Customer
(
    Id INT IDENTITY(1, 1) PRIMARY KEY,
    Name NVARCHAR(50) NOT NULL,
    Phone NVARCHAR(30),
    Email NVARCHAR(30)
)

-- Add 10 Customer Records (Be Creative)

INSERT INTO dbo.Customer
(
    Name,
    Phone,
    Email
)
VALUES
( 'Nike', '3131234567', 'nike@nike.com'),
( 'Adidas', '2481234567', NULL),
( 'Microsoft', '3131234567', NULL),
( 'Under Armour', '3131234567', NULL)

-- Update the phone number of customer with Id of 2

UPDATE dbo.Customer
SET Phone = '8675309'
WHERE Id = 2

-- Remove the customer with id of 7

DELETE FROM dbo.Customer
WHERE Id = 3

-- Select all customers named 'Grand Circus'

SELECT * 
FROM dbo.Customer
WHERE Name = 'Grand Circus'

-- Select all customers phone is 313 and Name is 'Nike'

SELECT *
FROM dbo.Customer
WHERE Phone LIKE '313%'
  AND Name = 'Nike'

-- Create a Order Table
--     - Id - INT, auto increment (Primary Key) 
--     - Date DATE
--     - CustomerID - Foreign key to customer table

CREATE TABLE dbo.Orders
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    [Date] DATE NOT NULL,
    CustomerID INT,
    FOREIGN KEY (CustomerID) REFERENCES Customer(Id)
)

-- Add 10 records to the order table

INSERT INTO dbo.Orders
(
    [Date],
    CustomerID
)
VALUES
(
    '3/31/2021',
    4
)

-- List all customer's who have an order after 1/1/2021

SELECT 
    C.Name,
    O.[Date]
FROM dbo.Customer AS C
INNER JOIN dbo.Orders AS O
  ON O.CustomerID = C.Id
WHERE O.[Date] > '1/1/2021'

-- List all customer's who do NOT have an order (only list the customer name)

SELECT *
FROM dbo.Customer AS C 
LEFT OUTER JOIN dbo.Orders AS O
  ON O.CustomerID = C.Id
WHERE O.Id IS NULL