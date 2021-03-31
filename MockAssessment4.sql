CREATE DATABASE CompanyDb

CREATE TABLE Department
(
    Id INT PRIMARY KEY IDENTITY(1, 1),
    Name NVARCHAR(25) NOT NULL,
    Hiring BIT,
    Location NVARCHAR(50)
)

INSERT INTO dbo.Department
(
    Name,
    Hiring,
    Location
)
VALUES
(
    'Technology',
    1,
    '1570 Woodward Ave.' 
),
(
    'Shipping and Receiving',
    0,
    'Southfield'
)


CREATE TABLE dbo.Employee
(
    SSN NCHAR(9) PRIMARY KEY,
    DOB DATE,
    Phone NCHAR(10),
    FirstName NVARCHAR(30) NOT NULL,
    LastName NVARCHAR(30) NOT NULL,
    DepartmentId INT,
    FOREIGN KEY (DepartmentId) REFERENCES Department(Id)
)

INSERT dbo.Employee
(
    SSN,
    DOB,
    Phone,
    FirstName,
    LastName,
    DepartmentId
)
VALUES
('23456789', '1/5/1975', '3135555505', 'Charles', 'Charleston', 2),
('987654321', '5/2/1990', '2489995555', 'Jimmy', 'Scrambles', 1),
('456789123', '8/6/2001', '7895555525', 'Vince', 'Jabowski', 1),
('654854632', '4/6/1988', '3139721400', 'John', 'Johnston', 2)


UPDATE dbo.Employee
SET LastName = 'Spiderman'
WHERE SSN = '456789123'

-----------------------

UPDATE dbo.Employee
SET LastName = 'Spiderman' 
WHERE SSN = (
    SELECT TOP(1)
        SSN
    FROM dbo.Employee
    ORDER BY DOB DESC
)

SELECT *
FROM dbo.Employee
WHERE LastName LIKE 'J%'

DELETE FROM dbo.Employee
WHERE SSN = (
    SELECT TOP(1)
        SSN
    FROM dbo.Employee
    ORDER BY DOB ASC
)

SELECT *
FROM dbo.Employee
WHERE Phone LIKE '313%'

SELECT *
FROM dbo.Employee
WHERE DOB < '9/9/1999'

UPDATE dbo.Employee
SET Phone = NULL
WHERE DOB > '12/31/2000'

SELECT *
FROM Employee
WHERE Phone IS NULL

SELECT 
  E.FirstName,
  E.LastName,
  D.Name,
  D.[Location]
FROM dbo.Employee AS E
INNER JOIN dbo.Department AS D
    ON E.DepartmentId = D.Id
 
DELETE FROM dbo.Department
DELETE FROM dbo.Employee

DROP TABLE dbo.Department
DROP TABLE dbo.Employee