-- CREATE DATABASE Class_03242021;

-- USE Class_03242021;

-- CREATE TABLE dbo.Students
-- (
--     StudentId INT PRIMARY KEY,
--     FirstName NVARCHAR(200) NOT NULL,
--     LastName NVARCHAR(200) NOT NULL,
--     MiddleName NVARCHAR(200) NULL
-- );

-- DROP TABLE dbo.Students;

-- INSERT INTO dbo.Students 
-- (
--     StudentId,
--     FirstName,
--     LastName,
--     MiddleName
-- )
-- VALUES
-- (
--     2,
--     'Dany',
--     'Novoa',
--     NULL
-- );

-- UPDATE dbo.Students
-- SET MiddleName = 'Dominic'
-- WHERE StudentId = 1

-- DELETE FROM dbo.Students
-- WHERE StudentId = 2

SELECT * -- FirstName
FROM dbo.Students
WHERE StudentId = 1
