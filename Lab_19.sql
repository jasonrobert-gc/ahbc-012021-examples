SELECT *
FROM dbo.Customers

SELECT DISTINCT Country
FROM dbo.Customers

SELECT *
FROM dbo.Customers 
WHERE CustomerID LIKE 'Bl%'

SELECT TOP(100) *
FROM dbo.Orders

SELECT *
FROM dbo.Customers
WHERE PostalCode IN ('1010', '3012', '12209', '05023')

SELECT *
FROM dbo.Orders
WHERE ShipRegion IS NOT NULL

SELECT *
FROM dbo.Customers
ORDER BY Country, City

INSERT INTO dbo.Customers
(
    CustomerID,
    CompanyName
)
VALUES
(
    'JROBE',
    'Jason''s Company'
)

UPDATE dbo.Orders
SET ShipRegion = 'EuroZone'
WHERE ShipCountry = 'France'

DELETE FROM dbo.[Order Details]
WHERE Quantity = 1

SELECT 
  AVG(Quantity) AS Average,
  MAX(Quantity) AS Max,
  MIN(Quantity) AS Min
FROM dbo.[Order Details]

SELECT 
  OD.OrderId,
  AVG(OD.Quantity) AS Average,
  MAX(OD.Quantity) AS Max,
  MIN(OD.Quantity) AS Min
FROM dbo.[Order Details] AS OD
-- WHERE OD.Discount = 0 -- Filters records before grouped
GROUP BY OD.OrderID
-- HAVING AVG(OD.Quantity) > 9 -- Filters records after they are grouped

SELECT
  CustomerID
FROM dbo.Orders
WHERE OrderID = 10290

SELECT 
  C.CompanyName,
  O.OrderID
FROM dbo.Customers AS C
INNER JOIN dbo.Orders AS O
    ON O.CustomerID = C.CustomerID

SELECT 
  C.CompanyName,
  O.OrderID
FROM dbo.Customers AS C
LEFT OUTER JOIN dbo.Orders AS O
    ON O.CustomerID = C.CustomerID
WHERE O.OrderID IS NULL

SELECT 
  C.CompanyName,
  O.OrderID
FROM dbo.Customers AS C
RIGHT OUTER JOIN dbo.Orders AS O
    ON O.CustomerID = C.CustomerID

SELECT
  E.FirstName
FROM dbo.Employees AS E
WHERE E.ReportsTo IS NULL

SELECT
  E.FirstName
FROM dbo.Employees AS E
WHERE E.ReportsTo = 2

------------------------------

DECLARE @EmployeeID INT;
SELECT TOP(1)
  @EmployeeID = EmployeeID
FROM dbo.Employees
WHERE FirstName = 'Andrew'

SELECT
  E.FirstName
FROM dbo.Employees AS E
WHERE E.ReportsTo = @EmployeeID
