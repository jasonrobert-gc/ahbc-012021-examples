# Using the Http Client

## Step 1 - Create a Service Class

There are a couple different methods for using the `HttpClient` in .NET Core.  Each of these can be found [here](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/http-requests?view=aspnetcore-3.1).  I prefer using [typed clients](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/http-requests?view=aspnetcore-3.1#typed-clients).  With this strategy, it is easiest to start with a service class and takes a `HttpClient` in the constructor.

```
public class StarWarsService
{
    private readonly HttpClient _client;

    public StarWarsService(HttpClient client)
    {
        _client = client;
    }
}
```

## Step 2 - Add the System.Net.Http.Json nuget package

The `System.Net.Http.Json` nuget package makes it easy to parse API results in JSON into a class object in .NET.  We can add this with the nuget package manager or with the package manager console with the following command.

```
dotnet packages add System.Net.Http.Json --version 3.2.1
```

## Step 3 - Create your API Classes

To parse our JSON text results into a class, that class must exist in our solution.  Luckily for us, Visual Studio makes this easy with the [Paste JSON as Classes](https://www.c-sharpcorner.com/article/how-to-paste-json-as-classes-or-xml-as-classes-in-visual-stu/) option.  If you can, grab a copy of the JSON you want to parse and use this strategy to create your class(es).

## Step 4 - Create Methods to interact with your API

With the service class created in Step 1, we have access to the `HttpClient`.  We can now add a method to use it (see `GetPeopleAsync` below).  It is also helpful to add an interface while you are at it (see `IStarWarsService` below).

```
public class StarWarsService : IStarWarsService
{
    private readonly HttpClient _client;

    public StarWarsService(HttpClient client)
    {
        _client = client;
    }
    
    public async Task<PersonCollection> GetPeopleAsync()
    {
        return await _client.GetFromJsonAsync<PersonCollection>("people/");
    }
}
```

HINT: If you are not seeing the `GetFromJsonAsync` method, you will need to make sure you have the following using statement at the top of your service class.
```
using System.Net.Http.Json;
```

## Step 5 - Configure your Service in Startup.cs

In order to use your service in a controller, you will need to have the service configured appropriately in the `ConfigureServices` method of your `startup.cs` class.  This is also a great place to configure your `BaseAddress` as shown below.

```
services.AddHttpClient<IStarWarsService, StarWarsService>(client =>
{
    client.BaseAddress = new Uri("https://swapi.dev/api/");
});
```

## Step 6 - Use your Service Class

At this point, you should be ready to interact with your API.  All you have to do is inject your service class and .NET Core will take care of the rest.

```
public class PeopleController : Controller
{
    private readonly IStarWarsService _service;

    public PeopleController(IStarWarsService service)
    {
        _service = service;
    }
}
```
