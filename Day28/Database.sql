﻿CREATE DATABASE [Day28];
GO

USE [Day28]

CREATE TABLE dbo.Food
(
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(50) NOT NULL,
    Category NVARCHAR(50) NOT NULL
)