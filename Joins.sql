SELECT *
FROM dbo.Orders
 
SELECT 
  COUNT(*) AS Order_Count,
  SUM(Freight) AS Total_Freight,
  AVG(Freight) AS Average_Freight,
  MIN(Freight) AS Min_Freight,
  MAX(Freight) AS Max_Freight
FROM dbo.Orders

SELECT C.CompanyName, O.OrderDate
FROM dbo.Orders AS O
INNER JOIN dbo.Customers AS C
  ON C.CustomerID = O.CustomerID

SELECT C.CompanyName, O.OrderDate
FROM dbo.Customers AS C 
LEFT OUTER JOIN dbo.Orders AS O
  ON C.CustomerID = O.CustomerID

SELECT *
FROM dbo.Categories
CROSS JOIN dbo.Products

SELECT CompanyName
FROM dbo.Customers

SELECT 
  O.OrderID,
  C.CompanyName,
  P.ProductName,
  OD.UnitPrice,
  OD.Quantity
FROM dbo.Orders AS O
INNER JOIN dbo.[Order Details] AS OD
  ON OD.OrderID = O.OrderID
INNER JOIN dbo.Customers AS C
  ON C.CustomerID = O.CustomerID
INNER JOIN dbo.Products AS P
  ON P.ProductID = OD.ProductID
ORDER BY O.OrderID