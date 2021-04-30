# ASP.NET Core with Identity

## Initial Setup

### Prerequisites

1. Make sure you have the dotnet ef tools installed (`dotnet tool install --global dotnet-ef`)

### Create a new Web Application

- Be sure to select `Individual User Accounts` for authentication

### Setup Database

Rule the following command in the `Package Manager Console`.  You may need to `cd` into your project folder.

```
dotnet user-secrets set ConnectionStrings:DefaultConnection "Server=localhost;Database=Day27;User=sa;Password=Password."
```

I also like to remove the default connection string from the appsettings.json file.

#### For mac only

Update your `startup.cs` to use sql server instead of sqllite.

```
services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(
        Configuration.GetConnectionString("DefaultConnection")));
```

### Update Program.cs

You can run the following command to migrate your database.

```
dotnet ef database update
```

BUT, I like to update my `program.cs` like this so, the migrations run everytime the project starts.

```
public static void Main(string[] args)
{
    var host = CreateHostBuilder(args).Build();

    using (var scope = host.Services.CreateScope())
    {
        var services = scope.ServiceProvider;
        var context = services.GetRequiredService<ApplicationDbContext>();
        context.Database.Migrate();
    }

    host.Run();
}
```

## Extending our Database
 
###  Creating our Model

You can create relationships to the Identity Schema if needed, as shown below.

```
public class ShoppingListItem
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Quantity { get; set; }
    public IdentityUser User { get; set; }
}
```

### Update our DB Context

```
public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<ShoppingListItem> Items { get; set; }
}
```

### Create a Migration

Make sure you save your changes before running the command line

```
dotnet ef migrations add ShoppingListSchema
```

Now when you run your application it should automatically update the schema.