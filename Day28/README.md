# Table of Contents
1. [Database First Approach](#database-first)
    1. [Create your database](#create-your-database)
    1. [Setup your Project and Scaffold](#scaffold)
    1. [Update your Startup.cs ](#startup)
1. [Code First Approach](#code-first)
    1. [Setup your Project](#setup)
    1. [Create your Models](#models)
    1. [Create your DB Context](#dbcontext)
    1. [Update your Startup.cs ](#startup-cf)
    1. [Update your Program.cs ](#program)

## Database First Approach

### 1. Create your database <a name="create-your-database"></a>

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

### 2. Setup your Project and Scaffold <a name="scaffold"></a>

From the `Package Manager Console` (Windows) or `Termial` (Mac).  Make sure your **Default Project** is set to your project.

```
dotnet user-secrets init
dotnet user-secrets set ConnectionStrings:Countries "Server=localhost;Database=Day25;User=sa;Password=Password.;"
dotnet add package Microsoft.EntityFrameworkCore.Design -v 3.1.14
dotnet add package Microsoft.EntityFrameworkCore.SqlServer -v 3.1.14
dotnet ef dbcontext scaffold Name=ConnectionStrings:Countries Microsoft.EntityFrameworkCore.SqlServer --output-dir Data
```

### 3. Update your Startup.cs <a name="startup"></a>

```
services.AddDbContext<Day25Context>(options =>
{
    options.UseSqlServer(Configuration.GetConnectionString("Countries"));
});
```

## Code First Approach

### 1. Setup your Project <a name="setup"></a>

From the `Package Manager Console` (Windows) or `Termial` (Mac).  Make sure your **Default Project** is set to your project.

```
dotnet user-secrets set ConnectionStrings:Countries "Server=localhost;Database=Countries;User=sa;Password=Password.;"
dotnet add package Microsoft.EntityFrameworkCore.SqlServer -v 3.1.14
```

### 2. Create your Models <a name="models"></a>

In this step, you will be creating your model classes.  These classes represent logical entities ("tables" in SQL Server).  They are nothing more than C# classes with properties.  These classes may also be referred to as POCOs (Plain Old CLR Objects). 

Below is an example of a Country class.

```
public class Country
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Continent { get; set; }
}
```

### 3. Create your DB Context <a name="dbcontext"></a>

The database context allows developers to interact with their database.  It also tells entity framework which classes to use as entity framework models.  Below is an example db context class.

```
public partial class CountriesContext : DbContext
{
    public CountriesContext(DbContextOptions<Day25Context> options)
        : base(options)
    {
    }

    public DbSet<Country> Country { get; set; }
}
```

### 4. Update your Startup.cs <a name="startup-cf"></a>

```
services.AddDbContext<CountriesContext>(options =>
{
    options.UseSqlServer(Configuration.GetConnectionString("Countries"));
});
```

### 5. Update your Program.cs <a name="program"></a>

Since entity framework is responsible for our database, we need to explicitly tell it to create it.  We want this to happen _before_ our application starts so, we need to add the following code to our `Program.cs` file.

```
public static void Main(string[] args)
{
    var host = CreateHostBuilder(args).Build();

    using (var scope = host.Services.CreateScope())
    {
        var services = scope.ServiceProvider;
        var context = services.GetRequiredService<CountriesContext>();
        context.Database.EnsureCreated();
    }

    host.Run();
}
```
