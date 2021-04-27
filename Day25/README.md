# Database First

## 1. Create your database

```
CREATE DATABASE Day25;
GO

USE [Day25];
GO

CREATE TABLE Country
(
    Id INT IDENTITY(1, 1) PRIMARY KEY,
    Name NVARCHAR(40) NOT NULL,
    Continent NVARCHAR(40) NOT NULL
);
GO

INSERT INTO Country
VALUES ('China', 'Asia'),
('India', 'Asia'),
('Murica', 'North America');
```

## 2. Setup your Project and Scaffold
```

dotnet user-secrets set ConnectionStrings:Countries "Server=localhost;Database=Day25;User=sa;Password=Password.;"
dotnet add package Microsoft.EntityFrameworkCore.Design -v 3.1.14
dotnet add package Microsoft.EntityFrameworkCore.SqlServer -v 3.1.14
dotnet ef dbcontext scaffold Name=ConnectionStrings:Countries Microsoft.EntityFrameworkCore.SqlServer --output-dir Data
```
## 3. Update your startup.cs

```
services.AddDbContext<Day25Context>(options =>
{
    options.UseSqlServer(Configuration.GetConnectionString("Countries"));
});
```